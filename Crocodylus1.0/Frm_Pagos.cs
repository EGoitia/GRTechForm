using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0
{
    public partial class Frm_Pagos : Form
    {
        public bool Aceptado = false;
        public decimal MontoMax = 0;
        private bool Cargado = true;
        private DataTable dtTipoPago;

        public Frm_Pagos()
        {
            InitializeComponent();

            ListarTipoPagos();
            ListarBancos();
            Cargado = true;
        }

        public void Borrar()
        {
            Cargado = false;
            txtMontoBs.Clear();
            txtMontoSus.Clear();

            txtEfectivoBs.Text = "0.00";
            txtEfectivoSus.Text = "0.00";
            txtTarjetaBs.Text = "0.00";
            txtTarjetaSus.Text = "0.00";
            txtCheque.Text = "0.00";
            txtDeposito.Text = "0.00";
            txtTranferencia.Text = "0.00";
            txtTotalPagado.Text = "0.00";
            txtCambioBs.Text = "0.00";
            txtCambioSus.Text = "0.00";

            TxtNroRef1.Clear();
            TxtNroCheque.Clear();
            TxtNroDeposito.Clear();
            TxtNroCpte.Clear();
            Cargado = true;
        }

        private bool Verificar()
        {
            double montoverif;
            double.TryParse(txtTotalPagado.Text, out montoverif);

            if (montoverif <= 0)
            {
                MessageBox.Show("EL MONTO TOTAL NO PUEDE SER MENOR O IGUAL A CERO", "MONTO TOTAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (Convert.ToDecimal(txtMontoBs.Text) > Convert.ToDecimal(txtTotalPagado.Text))
            {
                MessageBox.Show("TIENE QUE COMPLETAR EL PAGO", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((Convert.ToDecimal(txtEfectivoBs.Text)==0) && 
                    (Convert.ToDecimal(txtTarjetaBs.Text) + Convert.ToDecimal(txtTranferencia.Text) +
                     Convert.ToDecimal(txtCheque.Text) + Convert.ToDecimal(txtDeposito.Text) > Convert.ToDecimal(txtMontoBs.Text)))
            {
                MessageBox.Show("LA SUMATORIA DE LOS PAGOS TRANSFERENCIA, CHEQUE, TARJETA, DEPÓSITO NO PUEDE SER MAYOR AL IMPORTE A PAGAR", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (Convert.ToDecimal(txtTarjetaBs.Text) + Convert.ToDecimal(txtTranferencia.Text) +
                     Convert.ToDecimal(txtCheque.Text) + Convert.ToDecimal(txtDeposito.Text) >= Convert.ToDecimal(txtMontoBs.Text))
            {
                if (Convert.ToDecimal(txtEfectivoBs.Text) > 0)
                {
                    MessageBox.Show("LA SUMATORIA DE LOS PAGOS TRANSFERENCIA, CHEQUE, TARJETA, DEPÓSITO Y EFECTIVO NO PUEDE SER MAYOR AL IMPORTE A PAGAR", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;
        }

        private void Total_Pago()
        {
            if (!Cargado)
                return;

            Cargado = false;

            decimal efectivo, tarjeta, chequebs, transfbs, depositobs;
            if (txtEfectivoSus.Focused)
            {
                decimal.TryParse(txtEfectivoSus.Text, out efectivo);
                if (efectivo <= 0)
                    txtEfectivoBs.Text = "0.00";
                else
                    txtEfectivoBs.Text = string.Format("{0:#,##0.00}", Math.Round(efectivo * Convert.ToDecimal(TxtTipoCambioOf.Text), 4));
            }
            if (txtTarjetaSus.Focused)
            {
                decimal.TryParse(txtTarjetaSus.Text, out tarjeta);
                if (tarjeta <= 0)
                    txtTarjetaBs.Text = "0.00";
                else
                    txtTarjetaBs.Text = string.Format("{0:#,##0.00}", Math.Round(tarjeta * Convert.ToDecimal(TxtTipoCambioOf.Text), 4));
            }
            

            decimal.TryParse(txtEfectivoBs.Text, out efectivo);
            decimal.TryParse(txtTarjetaBs.Text, out tarjeta);
            decimal.TryParse(txtCheque.Text, out chequebs);
            decimal.TryParse(txtTranferencia.Text, out transfbs);
            decimal.TryParse(txtDeposito.Text, out depositobs);

            if (efectivo <= 0)
                txtEfectivoBs.Text = "0.00";
            if (tarjeta <= 0)
                txtTarjetaBs.Text = "0.00";
            if (chequebs <= 0)
                txtCheque.Text = "0.00";
            if (transfbs <= 0)
                txtTranferencia.Text = "0.00";
            if (depositobs <= 0)
                txtDeposito.Text = "0.00";

            txtTotalPagado.Text = string.Format("{0:#,##0.00}", (efectivo + tarjeta + chequebs + transfbs + depositobs));
            txtCambioBs.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotalPagado.Text) - Convert.ToDecimal(txtMontoBs.Text));

            Cargado = true;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                Aceptado = true;
                this.Close();
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptado = false;
            this.Close();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            Total_Pago();    
        }

        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
               Process calc=new Process{ StartInfo = { FileName= @"calc.exe" }};
               calc.Start();
               calc.WaitForExit();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUDO ABRIR LA CALCULADORA DEL SISTEMA", "CALCULADORA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ListarBancos()
        {
            try
            {
                DataTable dtbanco = DListarPersonalizado.ConsultarDT("SELECT CajaID, NomCaja FROM Caja WHERE Estado=1 AND TipoCajaID=" + OConstantes.Tipo_Caja_BANCO);

                if (dtTipoPago != null)
                {
                    //verificamos si esta habilitado el pago en efectivo
                    var valortarj = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_TARJETA.ToString());
                    if (valortarj.Length > 0)
                    {
                        CmbTipoTarjeta.DataSource = DListarPersonalizado.ConsultarDT("SELECT CajaID, NomCaja FROM Caja WHERE Estado=1 AND TipoCajaID=" + OConstantes.Tipo_Pago_TARJETA);
                        CmbTipoTarjeta.DisplayMember = "NomCaja";
                        CmbTipoTarjeta.ValueMember = "CajaID";
                    }

                    var valorcheq = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_CHEQUE.ToString());
                    if (valorcheq.Length > 0)
                    {
                        DataTable dtbanco2 = dtbanco.Copy();
                        cmbBancoCheque.DataSource = dtbanco2;
                        cmbBancoCheque.DisplayMember = "NomCaja";
                        cmbBancoCheque.ValueMember = "CajaID";
                    }
                    var valordep = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_DEPOSITO.ToString());
                    if (valordep.Length > 0)
                    {
                        DataTable dtbanco3 = dtbanco.Copy();
                        cmbBancoDeposito.DataSource = dtbanco3;
                        cmbBancoDeposito.DisplayMember = "NomCaja";
                        cmbBancoDeposito.ValueMember = "CajaID";
                    }
                    var valortrans = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_TRANSFERENCIA.ToString());
                    if (valortrans.Length > 0)
                    {
                        DataTable dtbanco4 = dtbanco.Copy();
                        cmbBancoTransferencia.DataSource = dtbanco4;
                        cmbBancoTransferencia.DisplayMember = "NomCaja";
                        cmbBancoTransferencia.ValueMember = "CajaID";
                    }
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoPagos()
        {
            try
            {
                dtTipoPago = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Tupla='PAGO' AND Estado=1");
                if (dtTipoPago != null)
                {
                    //verificamos si esta habilitado el pago en efectivo
                    var valorefec = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_EFECTIVO.ToString());
                    if (valorefec.Length == 0)
                    {
                        panelEfectivo.Visible = false;
                        this.Height -= panelEfectivo.Height;
                    }
                    var valortarj = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_TARJETA.ToString());
                    if (valortarj.Length == 0)
                    {
                        panelTarjeta.Visible = false;
                        this.Height -= panelTarjeta.Height;
                    }
                    var valorcheq = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_CHEQUE.ToString());
                    if (valorcheq.Length == 0)
                    {
                        panelCheque.Visible = false;
                        this.Height -= panelCheque.Height;
                    }
                    var valordep = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_DEPOSITO.ToString());
                    if (valordep.Length == 0)
                    {
                        panelDeposito.Visible = false;
                        this.Height -= panelDeposito.Height;
                    }
                    var valortrans = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_TRANSFERENCIA.ToString());
                    if (valortrans.Length == 0)
                    {
                        panelTransferencia.Visible = false;
                        this.Height -= panelTransferencia.Height;
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY NINGUN TIPO DE PAGO HABILITADO", "TIPO PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Frm_Pagos_Load(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Negocio;

namespace GRTechnology1._0
{
    public partial class DevolPagAnticip : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OVenta> LVen = null;

        string CodVenta = string.Empty;
        string CodInmode = string.Empty;

        public DevolPagAnticip()
        {
            InitializeComponent();
        }

        #region Configuracoin Formulario

        private void NombreColumnas()
        {
            dgvPagosAnticip.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "CodVenta";
            c1.Visible = false;
            dgvPagosAnticip.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Numero";
            c2.Width = 100;
            dgvPagosAnticip.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 100;
            dgvPagosAnticip.Columns.Add(c3);
        }

        #endregion

        #region Conexion Capa de Negocios

        private void ListarCajas()
        {
            try
            {
                //List<OCaja> LCaj = NCaja.NListarCaja(OConexionGlobal.SucursalID, OConexionGlobal.UsuarioID,
                //                            "Cajas Usuario").Where(x => x.Estado).ToList();

                cboCaja.DataSource = null;
                cboCaja.DisplayMember = "NomCaja";
                cboCaja.ValueMember = "CajaID";
                cboCaja.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPagAnticip()
        {
            try
            {
                //LVen = NVenta.NListarPagosAnticipSinRegul(OConexionGlobal.SucursalID).Where(x => x.Estado).ToList();
                CargarPagAnticip(LVen);
            }
            catch (Exception)
            {
                NombreColumnas();
            }
        }

        private void InsertReciboDevolPagAnticip()
        {
            if (txtNum.Text != string.Empty)
            {
                try
                {
                    Verificar();

                    OInmode inm = new OInmode();
                    inm.CodInmode = CodInmode;
                    inm.UsuarioID = OConexionGlobal.UsuarioID;
                    inm.NomInmode = OConexionGlobal.NomPer;
                    inm.TipoInmode = "Insertar";
                    inm.IPInmode = op.SaberIP();
                    inm.MacInmode = op.SaberMac();
                    inm.MaquinaInmode = op.SaberNomMaquina();
                    inm.SistOperInmode = op.SaberSistemOper();
                    
                    OIngresoEgreso rec = new OIngresoEgreso();
                    rec.CodIngrEgre = CodVenta;
                    rec.CajaID = Convert.ToInt32(cboCaja.SelectedValue);
                    rec.Concepto = "Devolucion Pago Anticipado al Cliente " + txtReferencia.Text;
                    //rec.TipoRecibo = "Egreso";
                    //rec.GastosIngrID = 1; //id de la cuenta de antipo de clientes
                    //rec.Detalle = txtDet.Text;
                    //rec.MontoBs = numUpDownMontoBs.Value;
                    //rec.MontoSus = numUpDownSus.Value;
                    rec.TC = numUpDownTC.Value;

                    int resp = NReciboIngEgr.NInsertReciboDevolPagAnticip(rec, inm);
                    if (resp > 0)
                    {
                        MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando.....");

                        ListarPagAnticip();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    op.CerrarCargando();
                }
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarPagAnticip(List<OVenta> lven)
        {
            if(lven != null)
            {
                NombreColumnas();

                foreach (var item in lven)
                {
                    //dgvPagosAnticip.Rows.Add(item.CodVenta, item.NumVenta, item.Fecha.ToShortDateString());
                }
            }
            else
            {
                NombreColumnas();
            }
        }

        private void CargarCliente(Int32 cod, string nomcli)
        {
            cboCliente.Items.Clear();
            cboCliente.Items.Add(nomcli);
            cboCliente.ValueMember = cod.ToString();
            cboCliente.Text = nomcli;
        }

        private void BuscarPagAnticip()
        {
            if (txtBuscador.Text == string.Empty)
            {
                CargarPagAnticip(LVen);
            }
            else
            {
                List<OVenta> lbusqven=null;

                switch(cboOpBusq.Text)
                {
                    case "Numero Nota":
                        //lbusqven = LVen.Where(x => x.NumVenta == txtBuscador.Text).ToList();
                        break;
                    case "Cliente":
                        //lbusqven = LVen.FindAll(x => x.NomClien.ToUpper().Contains(txtBuscador.Text.ToUpper()));
                        break;
                    case "Referencia":
                        lbusqven = LVen.FindAll(x => x.Referencia.ToUpper().Contains(txtBuscador.Text.ToUpper()));
                        break;
                }
                CargarPagAnticip(lbusqven);
            }
        }

        private void SeleccionarPagAnticip(DataGridViewCellEventArgs e)
        {
            try
            {
                CodVenta = dgvPagosAnticip["CodVenta", e.RowIndex].Value.ToString();

                OVenta Ven = LVen.Find(x => x.CodVenta == CodVenta);
                if(Ven != null)
                {
                    //txtNum.Text = Ven.NumVenta;
                    //cboCaja.Text = Ven.NomCaja;
                    txtReferencia.Text = Ven.Referencia;
                    txtObs.Text = Ven.Detalle;

                    //CargarCliente(Ven.ClienteID, Ven.NomClien);
                    //cboCliente.Text = Ven.NomClien;

                    //txtSubTotBs.Text = string.Format("{0:#,##0.00}", Ven.MontoBs);
                    //txtDsctoBs.Text = string.Format("{0:#,##0.00}", Ven.DsctoBs);
                    //txtTotalBs.Text = string.Format("{0:#,##0.00}", Ven.MontoBs - Ven.DsctoBs);

                    //txtTotPagadoBs.Text = string.Format("{0:#,##0.00}", Ven.TotalPagadoBs);
                    //txtTotDsctoBs.Text = string.Format("{0:#,##0.00}", Ven.TotalDsctoBs);
                    //txtSaldoBs.Text = string.Format("{0:#,##0.00}", Ven.TotalSaldoBs);
                }
            }
            catch (Exception)
            {   }
        }

        #endregion

        #region Funciones

        private void Verificar()
        {
            if(txtDet.Text == string.Empty)
                throw new Exception("Tiene que ingresar el detalle");
            else if ((numUpDownMontoBs.Value <= 0) && (numUpDownSus.Value <= 0))
                throw new Exception("Tiene que ingresar el monto a devolver");
        }

        private void MostrarNumaLet(decimal num, string moned)
        {
            txtSuma.Text = Numalet.ToCardinal(num) + " " + moned;
        }

        #endregion

        #region Eventos Formulario

        private void DevolPagAnticip_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            cboOpBusq.Text = "Numero Nota";

            //tipo de cambio de dolar
            numUpDownTC.Value = 1;
            //listamos cajas y los pagos anticipados
            ListarCajas();
            ListarPagAnticip();
            //ponemos el foco en el dgvPagosAnticip
            dgvPagosAnticip.Focus();

            op.CerrarCargando();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarPagAnticip();
        }

        private void btnPag_Click(object sender, EventArgs e)
        {
            InsertReciboDevolPagAnticip();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            ListarCajas();
            ListarPagAnticip();

            op.CerrarCargando();
        }

        private void DevolPagAnticip_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dgvPagosAnticip_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarPagAnticip(e);
        }

        private void numUpDownSus_ValueChanged(object sender, EventArgs e)
        {
            numUpDownMontoBs.Value = 0;

            if (numUpDownSus.Value != 0)
                MostrarNumaLet(numUpDownSus.Value, "Dolares");
        }

        private void numUpDownMontoBs_ValueChanged(object sender, EventArgs e)
        {
            numUpDownSus.Value = 0;

            if (numUpDownMontoBs.Value != 0)
                MostrarNumaLet(numUpDownMontoBs.Value, "Boliviamos");
        }

        #endregion
    }
}

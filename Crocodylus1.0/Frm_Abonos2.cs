using Datos;
using GRTechnology1._0.ControlUsuario;
using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Abonos2 : Form
    {
        public static Frm_Abonos2 frmaboncli = null;
        public static Frm_Abonos2 frmabonprov = null;

        private bool AbonoCli;
        private bool Cargado = false;

        CntrUsuCheque cheque = null;
        CntrUsuDeposito deposito = null;
        CntrUsuTarjetas tarjeta = null;
        CntrUsuTransferencia transf = null;
        CntrlUsuTecladoNumerico teclado = null;

        TextBox txtFoco;

        public Frm_Abonos2(bool _aboncli)
        {
            InitializeComponent();

            this.AbonoCli = _aboncli;

            if (!_aboncli)
            {
                chkPagarCaja.Visible = true;
                //btnImpListaCliProv.Text = "Lista de Proveedores";
                //btnCuentasCobPag.Text = "Cuentas por Pagar";
                //btnNota.Text = "Nota de Compra";
                //btnCuentasCobPagCliChof.Text = "Cuentas por Pagar por Proveedor";
                this.Text = "PAGOS A PROVEEDOR";
            }
        }

        private void btnBusqClient_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bcli = new Buscadores.Buscador();
            bcli.Opcion = "Cliente";
            bcli.Owner = this;
            bcli.ShowDialog();
                        
            CargarCliente(Convert.ToInt32(bcli.dgvDatos["ID", bcli.dgvDatos.CurrentRow.Index].Value),
                bcli.dgvDatos["Nombre", bcli.dgvDatos.CurrentRow.Index].Value.ToString());

            bcli.Dispose();
        }

        private void CargarCliente(Int32 cod, string nomcli)
        {
            cboCliente.Items.Clear();
            cboCliente.Items.Add(nomcli);
            cboCliente.ValueMember = cod.ToString();
            cboCliente.Text = nomcli;

            SeleccionarCliProv();
        }

        private void SeleccionarCliProv()
        {
            if (Cargado)
            {
                DataTable SaldosDT = null;
                try
                {
                    string Consulta = string.Empty;
                    if (AbonoCli)
                        Consulta = "SELECT CodVenta CodNota, NumVenta NumNota, NumFactura, Fecha, Referencia, SucursalID, NomSuc, NomVendedor, Monto, Abonado, (Monto-Abonado)Saldo, TipoVenta Tipo " +
                            "FROM Vista_Saldos_Ventas WHERE ClienteID=" + cboCliente.ValueMember.ToString() + " AND (Monto-Abonado)>0" +
                            " UNION " +
                            "SELECT CodVenta CodNota, NumVenta NumNota, NumFactura, Fecha, Referencia, SucursalID, NomSuc, NomVendedor, Monto, Abonado, (Monto-Abonado)Saldo, TipoVenta Tipo " +
                            "FROM Vista_Saldos_Anticipos WHERE ClienteID=" + cboCliente.ValueMember.ToString();
                    else
                        Consulta = "SELECT CodCompraProd CodNota, NumCompraProd NumNota, 0 NumFactura, FechaCompra Fecha, Referencia, SucursalID, NomSuc, Monto, Abonado, (Monto-Abonado)Saldo, Tipo " +
                                " FROM Vista_Saldos_Proveedores WHERE ProveedorID=" + cboCliente.ValueMember.ToString();

                    Consulta += " AND (Monto-Abonado)>0";
                    SaldosDT = DListarPersonalizado.ConsultarDT(Consulta);
                    dgvDeudas.DataSource = SaldosDT;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ColumnasSaldos();

                    //Totales
                    decimal val;
                    decimal.TryParse(SaldosDT.Compute("SUM(Monto)", "").ToString(), out val);
                    LblTotal.Text = string.Format("{0:#,##0.00}", val);

                    decimal.TryParse(SaldosDT.Compute("SUM(Abonado)", "").ToString(), out val);
                    LblPagado.Text = string.Format("{0:#,##0.00}", val);

                    decimal.TryParse(SaldosDT.Compute("SUM(Saldo)", "").ToString(), out val);
                    LblSaldo.Text = string.Format("{0:#,##0.00}", val);
                    lblAbonar.Text = "0.00";

                    CAbonar.FillWeight = 40;
                }
            }
        }

        private void Frm_Abonos2_Load(object sender, EventArgs e)
        {
            Listar_TipoPago();
            Cargar_Bolsin();

            Cargado = true;
        }

        private void Frm_Abonos2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AbonoCli)
            {
                frmaboncli.Dispose();
                frmaboncli = null;
            }
            else
            {
                frmabonprov.Dispose();
                frmabonprov = null;
            }
        }

        private void Cargar_Bolsin()
        {
            try
            {
                DataTable DT = DListarPersonalizado.ConsultarDT("SELECT TOP 1 TCVenta FROM Tipo_Cambio ORDER BY Fecha DESC");

                if (DT.Rows.Count > 0)
                    txtTC.Text = string.Format("{0:#,##0.00}", DT.Rows[0].Field<decimal>("TCVenta"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_TipoPago()
        {
            try
            {
                DataTable dtTipo = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo " +
                        "WHERE Estado=1 AND Tupla='PAGO' AND TipoID NOT IN(" + OConstantes.Tipo_Pago_POSTERIOR + ") " +
                        "ORDER BY NomTipo");
                cboTipoPago.DataSource = dtTipo;
                cboTipoPago.DisplayMember = "NomTipo";
                cboTipoPago.ValueMember = "TipoID";
                cboTipoPago.SelectedValue = OConstantes.Tipo_Pago_EFECTIVO;  //por defecto pago Efectivo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Verificar_Abono()
        {
            if (chkPagarCaja.Checked)
            {
                if (!DInicioCaja.TieneInicioCajaUsuarioSucursal())
                {
                    MessageBox.Show("TIENE QUE INICIAR CAJA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            decimal monto = 0;

            if (Convert.ToDecimal(lblAbonar.Text) <= 0)
            {
                dgvDeudas.Focus();
                MessageBox.Show("SELECCIONE UNA NOTA PARA ABONAR", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboTipoPago.Text == string.Empty)
            {
                cboTipoPago.Focus();
                MessageBox.Show("SELECCIONE EL TIPO DE PAGO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!decimal.TryParse(txtAbonarBs.Text, out monto))
            {
                txtAbonarBs.Focus();
                MessageBox.Show("INGRESE UN MONTO VÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (monto <= 0)
            {
                txtAbonarBs.Focus();
                MessageBox.Show("EL MONTO A ABONAR NO PUEDE SER MENOR O IGUAL A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (monto > Convert.ToDecimal(lblAbonar.Text))
            {
                txtAbonarBs.Focus();
                MessageBox.Show("EL MONTO A ABONAR NO PUEDE SER MAYOR AL TOTAL A ABONAR", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!decimal.TryParse(txtTC.Text, out monto))
            {
                txtTC.Focus();
                MessageBox.Show("INGRESE EL TIPO DE CAMBIO VÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (monto <= 0)
            {
                txtTC.Focus();
                MessageBox.Show("ERROR EN EL TIPO DE CAMBIO, NO PUEDE SER MENOR O IGUAL A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //else if (txtCuentaContID.Text == "-1")
            //{
            //    txtCuentaCont.Focus();
            //    MessageBox.Show("SELECCIONE UN CUENTA CONTABLE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return false;
            //}

            else if ((cboTipoPago.Text == "CHEQUE") && (!cheque.Verificar_cheque()))
                return false;
            else if ((cboTipoPago.Text == "DEPOSITO") && (!deposito.Verificar_Deposito()))
                return false;
            else if ((cboTipoPago.Text == "TRANSFERENCIA") && (!transf.Verificar_Transferencia()))
                return false;
            else if ((cboTipoPago.Text == "TARJETA") && (!tarjeta.verificar_Tarjeta()))
                return false;


            return true;
        }

        private DataTable InsertDetalleAbono()
        {
            DataTable DetAbonoDT = new DataTable();
            DetAbonoDT.Columns.Add("CodNota");
            DetAbonoDT.Columns.Add("TipoNota");
            DetAbonoDT.Columns.Add("Monto");

            DataRow fila;
            decimal montoabonar = 0; decimal montototabonar = Convert.ToDecimal(txtAbonarBs.Text);
            for (int i = 0; i < dgvDeudas.Rows.Count; i++)
            {
                fila = DetAbonoDT.NewRow();

                if (dgvDeudas["CAbonar", i].Value != null)
                    if ((bool)dgvDeudas["CAbonar", i].Value)
                    {
                        montoabonar = Convert.ToDecimal(dgvDeudas["Saldo", i].Value);

                        if (montototabonar > 0)
                        {
                            fila["CodNota"] = dgvDeudas["CodNota", i].Value.ToString();
                            fila["TipoNota"] = dgvDeudas["Tipo", i].Value.ToString();
                            fila["Monto"] = (montototabonar > montoabonar ? montoabonar : montototabonar);
                            DetAbonoDT.Rows.Add(fila);
                            montototabonar -= montoabonar;
                        }
                        else
                            break;
                    }
            }

            if (DetAbonoDT.Rows.Count == 0)
                throw new Exception("SELECCIONE POR LO MENOS UNA NOTA PARA ABONAR");

            return DetAbonoDT;
        }

        private DataTable InsertDetallePago()
        {
            DataTable DetPagoDT = new DataTable();
            DetPagoDT.Columns.Add("PagoID");
            DetPagoDT.Columns.Add("TipoPagoID");
            DetPagoDT.Columns.Add("BancoID");
            DetPagoDT.Columns.Add("Monto");
            DetPagoDT.Columns.Add("Cambio");
            DetPagoDT.Columns.Add("TC");
            DetPagoDT.Columns.Add("Fecha1");
            DetPagoDT.Columns.Add("Fecha2");
            DetPagoDT.Columns.Add("Numero1");
            DetPagoDT.Columns.Add("Numero2");
            DetPagoDT.Columns.Add("Banco1");
            DetPagoDT.Columns.Add("Banco2");
            DetPagoDT.Columns.Add("Estado");

            DataRow fila = DetPagoDT.NewRow();
            fila["PagoID"] = -1;
            fila["TipoPagoID"] = cboTipoPago.SelectedValue;
            fila["Monto"] = decimal.Parse(txtAbonarBs.Text);
            fila["TC"] = decimal.Parse(txtTC.Text);
            fila["Cambio"] = 0;
            fila["Estado"] = true;

            switch (cboTipoPago.SelectedValue.ToString())
            {
                case "13":    //TARJETA
                    fila["Banco1"] = tarjeta.txtbancoTar.Text.Trim();
                    fila["Numero1"] = tarjeta.txtRefTar.Text.Trim();
                    break;
                case "14":    //CHEQUE
                    fila["Banco1"] = cheque.txtBancoCheque.Text.Trim();
                    fila["Numero1"] = cheque.TxtCheque.Text.Trim();
                    fila["Fecha1"] = cheque.txtFechaChequeEmi.Value;
                    fila["Fecha2"] = cheque.txtFechaChequeCobro.Value;
                    break;
                case "15":    //DEPOSITO
                    fila["Banco1"] = deposito.txtBancoDep.Text.Trim();
                    fila["Numero1"] = deposito.txtCuentaDep.Text.Trim();
                    fila["Fecha1"] = deposito.DtFecCobroDep.Value;
                    break;
                case "16":    //TRANSFERENCIA
                    fila["BancoID"] = transf.cboBanco.SelectedValue;
                    fila["Banco2"] = transf.txtBancoDestino.Text.Trim();
                    fila["Banco1"] = transf.cboBanco.Text;
                    fila["Numero2"] = transf.txtCtaDestino.Text.Trim();
                    fila["Fecha1"] = transf.DtFecCobroTransf.Value;
                    break;
            }

            DetPagoDT.Rows.Add(fila);

            return DetPagoDT;
        }

        private void InsertModif_Abono()
        {
            if (Verificar_Abono())
            {
                try
                {
                    OAbono abon = new OAbono();
                    abon.CodAbono = string.Empty;
                    abon.CajaID = 2; //CAJA DE VENTAS
                    abon.ClienteID = Convert.ToInt32(cboCliente.ValueMember);
                    abon.Referencia = txtRef.Text.Trim();
                    abon.Detalle = txtObs.Text.Trim();
                    abon.TC = Convert.ToDecimal(txtTC.Text);
                    abon.Dscto = 0;
                    abon.Fecha = DateTime.Now;
                    abon.Monto = decimal.Parse(txtAbonarBs.Text);
                    abon.SucursalID = OConexionGlobal.SucursalID;
                    abon.TipoAbono = (AbonoCli ? "Cliente" : "Proveedor");
                    abon.PagarConCaja = chkPagarCaja.Checked;
                    abon.DetalleAbonoDT = InsertDetalleAbono();
                    abon.DetallePagoDT = InsertDetallePago();

                    string resp = DAbono.DInsertModifAbono(abon, OInmode.DTInmode("", "NUEVO", "")).ToString();
                    if (resp != string.Empty)
                    {
                        MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BorrarCampos();
                        Cargar_Bolsin();
                        SeleccionarCliProv();

                        ImpNota(resp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ImpNota(string abonoid)
        {
            try
            {
                Frm_Reporte rep = new Frm_Reporte();
                rep.Titulo = (AbonoCli ? "RECIBO" : "NOTA DE PAGO");
                rep.Llenar_Tabla("SELECT * FROM Vista_Abonos WHERE CodAbono='" + abonoid + "'", "Lista_Abonos");
                rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Abonos WHERE CodAbono='" + abonoid + "'", "Detalle_Abonos");
                rep.Cargar("RepNotaAbonos", false);
                rep.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BorrarCampos()
        {
            cboTipoPago.Text = "EFECTIVO";
            txtTC.Text = "6.96";
            lblAbonar.Text = "0.00";
            txtAbonarBs.Text = "0.00";
            txtAbonarSus.Text = "0.00";
            txtRef.Clear();
            txtObs.Clear();            
        }

        private void ColumnasSaldos()
        {
            dgvDeudas.Columns["CodNota"].Visible = false;
            dgvDeudas.Columns["SucursalID"].Visible = false;

            dgvDeudas.Columns["NumNota"].HeaderText = "Nº Nota";
            dgvDeudas.Columns["NumNota"].Width = 60;
            dgvDeudas.Columns["NumNota"].ReadOnly = true;

            dgvDeudas.Columns["NumFactura"].HeaderText = "Nº Factura";
            dgvDeudas.Columns["NumFactura"].Width = 50;
            dgvDeudas.Columns["NumFactura"].ReadOnly = true;

            dgvDeudas.Columns["Fecha"].Width = 90;

            dgvDeudas.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDeudas.Columns["NomSuc"].Width = 100;
            dgvDeudas.Columns["NomSuc"].ReadOnly = true;

            dgvDeudas.Columns["Referencia"].HeaderText = "Referencia";
            dgvDeudas.Columns["Referencia"].Width = 150;
            dgvDeudas.Columns["Referencia"].ReadOnly = true;

            dgvDeudas.Columns["Monto"].HeaderText = "Monto " + (AbonoCli ? "Venta" : "");
            dgvDeudas.Columns["Monto"].Width = 80;
            dgvDeudas.Columns["Monto"].DefaultCellStyle.Format = "N2";
            dgvDeudas.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDeudas.Columns["Monto"].ReadOnly = true;

            dgvDeudas.Columns["Abonado"].HeaderText = "Abonado";
            dgvDeudas.Columns["Abonado"].Width = 80;
            dgvDeudas.Columns["Abonado"].DefaultCellStyle.Format = "N2";
            dgvDeudas.Columns["Abonado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDeudas.Columns["Abonado"].ReadOnly = true;

            dgvDeudas.Columns["Saldo"].HeaderText = "Saldo";
            dgvDeudas.Columns["Saldo"].Width = 80;
            dgvDeudas.Columns["Saldo"].DefaultCellStyle.Format = "N2";
            dgvDeudas.Columns["Saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDeudas.Columns["Saldo"].ReadOnly = true;

            dgvDeudas.Columns["Tipo"].Width = 70;

            if (AbonoCli)
            {
                dgvDeudas.Columns["NomVendedor"].HeaderText = "Vendedor";
                dgvDeudas.Columns["NomVendedor"].Width = 150;
                dgvDeudas.Columns["NomVendedor"].ReadOnly = true;
            }
        }

        private void MostrarTeclado()
        {
            if (teclado == null)
            {
                teclado = new CntrlUsuTecladoNumerico();

                // Obtener posición real en el formulario
                Point punto = this.PointToClient(txtFoco.Parent.PointToScreen(txtFoco.Location));

                int margen = 5;

                // Posición por defecto (abajo)
                int posY = punto.Y + txtFoco.Height + margen;

                // Validar si se sale del formulario
                if (posY + teclado.Height > this.ClientSize.Height)
                {
                    // Mostrar arriba
                    posY = punto.Y - teclado.Height - margen;
                }

                // Si igual se sale por arriba
                if (posY < 0)
                    posY = margen;

                // Posición X (derecha del textbox)
                int posX = punto.X;

                // Evitar que se salga a la derecha
                if (posX + teclado.Width > this.ClientSize.Width)
                    posX = this.ClientSize.Width - teclado.Width - margen;

                teclado.Location = new Point(posX, posY);

                // Suscribir eventos
                teclado.OnNumeroPresionado += Teclado_OnNumeroPresionado;
                teclado.OnBorrar += Teclado_OnBorrar;
                teclado.OnBorrarTodo += Teclado_OnBorrarTodo;
                teclado.OnEnter += Teclado_OnEnter;
                
                if (!this.Controls.Contains(teclado))
                    this.Controls.Add(teclado);

                teclado.BringToFront();
                teclado.Visible = true;
            }
        }

        private void dgvDeudas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Cargado && dgvDeudas.Rows.Count > 0 && e.RowIndex > -1)
            {
                decimal abonar = 0;
                for (int i = 0; i < dgvDeudas.Rows.Count; i++)
                {
                    if (dgvDeudas["CAbonar", i].Value != null)
                    {
                        if ((bool)dgvDeudas["CAbonar", i].Value)
                            abonar += Convert.ToDecimal(dgvDeudas["Saldo", i].Value);
                    }
                }

                lblAbonar.Text = string.Format("{0:#,##0.00}", abonar);

                Cargado = false;
                txtAbonarBs.Text = string.Format("{0:#,##0.00}", abonar);
                txtAbonarSus.Text = string.Format("{0:#,##0.00}", Math.Round((abonar / Convert.ToDecimal(txtTC.Text)), 2));
                Cargado = true;
            }
        }

        private void dgvDeudas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvDeudas.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvDeudas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDeudas.IsCurrentCellDirty)
                dgvDeudas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cargado)
            {
                panelTipPago.Controls.Clear();

                switch (cboTipoPago.SelectedValue.ToString())
                {
                    case "13":  //TARJETA
                        if (tarjeta == null)
                        { tarjeta = new CntrUsuTarjetas(); }
                        panelTipPago.Controls.Add(tarjeta);
                        tarjeta.BorrarTarjeta();
                        break;
                    case "14":  //CHEQUE
                        if (cheque == null)
                        { cheque = new CntrUsuCheque(); }
                        panelTipPago.Controls.Add(cheque);
                        cheque.BorrarCheque();
                        break;
                    case "15": //DEPOSITO
                        if (deposito == null)
                        { deposito = new CntrUsuDeposito(); }
                        panelTipPago.Controls.Add(deposito);
                        deposito.BorrarDeposito();
                        break;
                    case "16": //TRANSFERENCIA
                        if (transf == null)
                        { transf = new CntrUsuTransferencia(); }
                        panelTipPago.Controls.Add(transf);
                        transf.BorrarTransf();
                        break;
                }
            }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            InsertModif_Abono();
        }

        private void txtAbonarBs_TextChanged(object sender, EventArgs e)
        {
            if (Cargado)
            {
                Cargado = false;

                decimal tc, bs, sus;
                if (!decimal.TryParse(txtTC.Text, out tc))
                {
                    txtTC.Text = "6.96";
                    txtTC.SelectAll();
                }


                if (txtAbonarBs.Focused || txtTC.Focused)
                {
                    decimal.TryParse(txtAbonarBs.Text, out bs);
                    txtAbonarSus.Text = string.Format("{0:#,##0.00}", Math.Round((tc == 0 ? 0 : bs / tc), 2));

                    if (bs == 0)
                    {
                        txtAbonarBs.Text = "0.00";
                        txtAbonarBs.SelectAll();
                    }
                }
                else
                {
                    decimal.TryParse(txtAbonarSus.Text, out sus);
                    txtAbonarBs.Text = string.Format("{0:#,##0.00}", Math.Round(sus * tc, 2));

                    if (sus == 0)
                    {
                        txtAbonarSus.Text = "0.00";
                        txtAbonarSus.SelectAll();
                    }
                }

                Cargado = true;
            }
        }

        private void txtAbonarSus_TextChanged(object sender, EventArgs e)
        {
            if (Cargado)
            {
                Cargado = false;

                decimal tc, bs, sus;
                if (!decimal.TryParse(txtTC.Text, out tc))
                {
                    txtTC.Text = "6.96";
                    txtTC.SelectAll();
                }


                if (txtAbonarBs.Focused || txtTC.Focused)
                {
                    decimal.TryParse(txtAbonarBs.Text, out bs);
                    txtAbonarSus.Text = string.Format("{0:#,##0.00}", Math.Round((tc == 0 ? 0 : bs / tc), 2));

                    if (bs == 0)
                    {
                        txtAbonarBs.Text = "0.00";
                        txtAbonarBs.SelectAll();
                    }
                }
                else
                {
                    decimal.TryParse(txtAbonarSus.Text, out sus);
                    txtAbonarBs.Text = string.Format("{0:#,##0.00}", Math.Round(sus * tc, 2));

                    if (sus == 0)
                    {
                        txtAbonarSus.Text = "0.00";
                        txtAbonarSus.SelectAll();
                    }
                }

                Cargado = true;
            }
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (Cargado)
            {
                Cargado = false;

                decimal tc, bs, sus;
                if (!decimal.TryParse(txtTC.Text, out tc))
                {
                    txtTC.Text = "6.96";
                    txtTC.SelectAll();
                }


                if (txtAbonarBs.Focused || txtTC.Focused)
                {
                    decimal.TryParse(txtAbonarBs.Text, out bs);
                    txtAbonarSus.Text = string.Format("{0:#,##0.00}", Math.Round((tc == 0 ? 0 : bs / tc), 2));

                    if (bs == 0)
                    {
                        txtAbonarBs.Text = "0.00";
                        txtAbonarBs.SelectAll();
                    }
                }
                else
                {
                    decimal.TryParse(txtAbonarSus.Text, out sus);
                    txtAbonarBs.Text = string.Format("{0:#,##0.00}", Math.Round(sus * tc, 2));

                    if (sus == 0)
                    {
                        txtAbonarSus.Text = "0.00";
                        txtAbonarSus.SelectAll();
                    }
                }

                Cargado = true;
            }
        }

        private void txtAbonarBs_Enter(object sender, EventArgs e)
        {
            txtFoco = txtAbonarBs;
            MostrarTeclado();
        }

        private void Teclado_OnNumeroPresionado(string numero)
        {
            if (numero == "." && txtFoco.Text.Contains(".")) return;

            txtFoco.Text += numero;
            txtFoco.SelectionStart = txtFoco.Text.Length;
        }

        private void Teclado_OnBorrar()
        {
            if (!string.IsNullOrEmpty(txtFoco.Text))
            {
                txtFoco.Text = txtFoco.Text.Substring(0, txtFoco.Text.Length - 1);
                txtFoco.SelectionStart = txtFoco.Text.Length;
            }
        }

        private void Teclado_OnBorrarTodo()
        {
            txtFoco.Clear();
        }

        private void Teclado_OnEnter()
        {
            teclado.Visible = false;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txtAbonarSus_Enter(object sender, EventArgs e)
        {
            txtFoco = txtAbonarSus;
            MostrarTeclado();
        }

        private void txtTC_Enter(object sender, EventArgs e)
        {
            txtFoco = txtTC;
            MostrarTeclado();
        }
    }
}

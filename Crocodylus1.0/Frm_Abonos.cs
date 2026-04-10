using GRTechnology1._0.ControlUsuario;
using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Objetos;

namespace GRTechnology1._0
{
    public partial class Frm_Abonos : Form
    {
        public static Frm_Abonos frmaboncli = null;
        public static Frm_Abonos frmabonprov = null;

        private DataTable DTCliProv = null;
        private bool AbonoCli;
        private bool Cargado = false;

        CntrUsuCheque cheque = null;
        CntrUsuDeposito deposito = null;
        CntrUsuTarjetas tarjeta = null;
        CntrUsuTransferencia transf = null;

        public Frm_Abonos(bool _aboncli)
        {
            InitializeComponent();

            this.AbonoCli = _aboncli;

            if (!_aboncli)
            {
                btnImpListaCliProv.Text = "Lista de Proveedores";
                btnCuentasCobPag.Text = "Cuentas por Pagar";
                btnNota.Text = "Nota de Compra";
                btnCuentasCobPagCliChof.Text = "Cuentas por Pagar por Proveedor";
                this.Text = "PAGOS A PROVEEDOR";
            }
        }

        private void ColumnasCliProv()
        {
            if (AbonoCli)
            {
                dgvCliProv.Columns["LimiteCredito"].HeaderText = "Límite Crédito";
                dgvCliProv.Columns["LimiteCredito"].FillWeight = 70;
                dgvCliProv.Columns["LimiteCredito"].DefaultCellStyle.Format = "N2";
                dgvCliProv.Columns["LimiteCredito"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvCliProv.Columns["SaldoAnticipo"].HeaderText = "Saldo Anticipo";
                dgvCliProv.Columns["SaldoAnticipo"].FillWeight = 70;
                dgvCliProv.Columns["SaldoAnticipo"].DefaultCellStyle.Format = "N2";
                dgvCliProv.Columns["SaldoAnticipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dgvCliProv.Columns["ID"].FillWeight = 50;
            dgvCliProv.Columns["Nombre"].FillWeight = 200;
            dgvCliProv.Columns["Saldo"].FillWeight = 90;
            dgvCliProv.Columns["Telf"].HeaderText = "Telf.";
            dgvCliProv.Columns["Correo"].HeaderText = "Email";
            dgvCliProv.Columns["Saldo"].DefaultCellStyle.Format = "N2";
            dgvCliProv.Columns["Saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
        
        private void Listar_Persona()
        {
            try
            {
                string consulta = (AbonoCli ? "SELECT ClienteID ID, NomClien Nombre, TipoClien Tipo, Telf, Correo, LimiteCredito, " +
                    "Saldo, SaldoAnticipo FROM Vista_Salto_Total_Cliente WHERE NomClien LIKE '%" + txtNombre.Text.Trim() + "%' " +
                    "AND (Saldo>0 OR SaldoAnticipo>0)" :
                    "SELECT ProveedorID ID, NomProv Nombre, TipoProv Tipo, Telf, Correo, (SUM(Monto)-SUM(Abonado))Saldo " +
                    "FROM Vista_Saldos_Compra GROUP BY ProveedorID, NomProv, TipoProv, Telf, Correo HAVING (SUM(Monto)-SUM(Abonado))>0");

                DTCliProv = DListarPersonalizado.ConsultarDT(consulta);
                CargarPersona(DTCliProv);
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
                cboTipoPago.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo Where Estado=1 AND Tupla='PAGO' ORDER BY NomTipo");
                cboTipoPago.DisplayMember = "NomTipo";
                cboTipoPago.ValueMember = "TipoID";
                cboTipoPago.SelectedValue = 12;  //por defecto pago Efectivo
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
                    abon.ClienteID = (int)dgvCliProv["ID", dgvCliProv.CurrentRow.Index].Value;
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

                        ImpNota(resp);
                        BorrarCampos();
                        Cargar_Bolsin();
                        SeleccionarCliProv(dgvCliProv.CurrentRow.Index);
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
            Frm_Reporte rep = new Frm_Reporte();
            rep.Titulo = (AbonoCli ? "RECIBO" : "NOTA DE PAGO");
            rep.Llenar_Tabla("SELECT * FROM Vista_Abonos WHERE CodAbono='" + abonoid + "'", "Lista_Abonos");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Abonos WHERE CodAbono='" + abonoid + "'", "Detalle_Abonos");
            rep.Cargar("RepNotaAbonos", false);
            rep.Show();
        }

        private void BorrarCampos()
        {
            cboTipoPago.Text = "EFECTIVO";
            txtTC.Text = "6.96";
            lblAbonar.Text = "0.00";
            txtAbonarBs.Text = "0.00";
            txtAbonarSus.Text = "0.00";
            //txtCuentaContID.Text = "-1";
            //txtCuentaCont.Clear();
            txtRef.Clear();
            txtObs.Clear();
        }

        private void CargarPersona(DataTable dtper)
        {
            dgvCliProv.DataSource = dtper;
            ColumnasCliProv();
        }

        private void FiltrarCliProv()
        {
            if (DTCliProv.Rows.Count > 0)
            {
                IEnumerable<DataRow> PerQuery = (from Persona in DTCliProv.AsEnumerable()
                                                 select Persona).Where(p => p.Field<string>("Nombre").Contains(txtNombre.Text.Trim()));

                if (PerQuery.Count() > 0)
                    CargarPersona(PerQuery.CopyToDataTable());
                else
                {
                    DataTable dt = DTCliProv.Clone();
                    CargarPersona(dt);
                }
            }
        }

        private void SeleccionarCliProv(int fila)
        {
            if (dgvCliProv.Rows.Count > 0 && Cargado && fila > -1)
            {
                DataTable SaldosDT = null;
                try
                {
                    string Consulta = string.Empty;
                    if (AbonoCli)
                        Consulta = "SELECT CodVenta CodNota, NumVenta NumNota, NumFactura, Fecha, SucursalID, NomSuc, NomVendedor, Monto, Abonado, (Monto-Abonado)Saldo, TipoVenta Tipo " +
                            "FROM Vista_Saldos_Ventas WHERE ClienteID=" + dgvCliProv["ID", fila].Value.ToString() + " AND (Monto-Abonado)>0" + 
                            " UNION " +
                            "SELECT CodVenta CodNota, NumVenta NumNota, NumFactura, Fecha, SucursalID, NomSuc, NomVendedor, Monto, Abonado, (Monto-Abonado)Saldo, TipoVenta Tipo " +
                            "FROM Vista_Saldos_Anticipos WHERE ClienteID=" + dgvCliProv["ID", fila].Value.ToString();
                    else
                        Consulta = "SELECT CodCompraProd CodNota, NumCompraProd NumNota, 0 NumFactura, FechaCompra Fecha, SucursalID, NomSuc, Monto, Abonado, (Monto-Abonado)Saldo, Tipo " +
                                " FROM Vista_Saldos_Proveedores WHERE ProveedorID=" + dgvCliProv["ID", fila].Value.ToString();

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
            dgvDeudas.Columns["NomSuc"].Width = 150;
            dgvDeudas.Columns["NomSuc"].ReadOnly = true;

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

        private void Frm_Abonos_Load(object sender, EventArgs e)
        {
            Listar_TipoPago();
            Listar_Persona();
            Cargar_Bolsin();

            Cargado = true;
        }

        private void dgvCliProv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarCliProv(e.RowIndex);
        }

        private void Frm_Abonos_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvCliProv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvCliProv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
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

        private void dgvDeudas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDeudas.IsCurrentCellDirty)
                dgvDeudas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void txtAbonar_TextChanged(object sender, EventArgs e)
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

        private void btnNota_Click(object sender, EventArgs e)
        {
            if (dgvDeudas.Rows.Count > 0)
            {
                Frm_Reporte rep = new Frm_Reporte();
                rep.Dts.Clear();

                if (AbonoCli)
                {
                    rep.Llenar_Tabla("SELECT * FROM Vista_Ventas WHERE CodVenta='" + dgvDeudas["CodNota", dgvDeudas.CurrentRow.Index].Value.ToString() + "'", "Lista_Venta");
                    rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + dgvDeudas["CodNota", dgvDeudas.CurrentRow.Index].Value.ToString() + "'", "Detalle_Venta");
                    rep.Cargar(DConstantes.Imprimir.Nota_Venta.NOM_REPORTE_NOTA_VENTA, false, true,
                               DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_COPIAR,
                               DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_EXPORT,
                               DConstantes.Imprimir.Nota_Venta.MOSTRAR_ARBOL,
                               (int)dgvDeudas["SucursalID", dgvDeudas.CurrentRow.Index].Value);
                }
                else
                {
                    rep.Llenar_Tabla("SELECT * FROM Vista_CompraProd WHERE CodCompraProd='" + dgvDeudas["CodNota", dgvDeudas.CurrentRow.Index].Value.ToString() + "'", "Lista_Compra");
                    rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_CompraProd WHERE CodCompraProd='" + dgvDeudas["CodNota", dgvDeudas.CurrentRow.Index].Value.ToString() + "'", "Detalle_Compra");
                    rep.Cargar(DConstantes.Imprimir.Nota_Compra.NOM_REPORTE_NOTA_COMPRA, false,
                               DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_IMP,
                               DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_COPIAR,
                               DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_EXPORT,
                               DConstantes.Imprimir.Nota_Compra.MOSTRAR_ARBOL,
                               (int)dgvDeudas["SucursalID", dgvDeudas.CurrentRow.Index].Value);                   
                }

                rep.Show();
            }
        }

        private void btnCuentasCobPagCliChof_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            string[] param = new string[1];
            param[0] = dgvCliProv["Nombre", dgvCliProv.CurrentRow.Index].Value.ToString();
            rep.Cargar_Reporte((AbonoCli ? "Cuentas_Cobrar" : "Cuentas_Pagar"), param);
            rep.Show();
        }

        private void btnImpListaCliProv_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte();

            if (AbonoCli)
            {
                rep.Llenar_Tabla("SELECT * FROM Vista_Clientes WHERE Estado=1", "Lista_Clientes");
                rep.Cargar("RptListaClientes", false);
            }
            else
            {
                rep.Llenar_Tabla("SELECT * FROM Vista_Proveedores WHERE Estado=1", "Lista_Proveedores");
                rep.Cargar("RptListaProveedores", false);
            }

            rep.Show();
        }

        private void btnCuentasCobPag_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte((AbonoCli ? "Cuentas_Cobrar": "Cuentas_Pagar"), null);
            rep.Show();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FiltrarCliProv();
        }

    }
}

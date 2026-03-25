using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Compra : GRTechnology1._0.Frm_Base_Notas
    {
        OCompraProd ocomp = null;

        public static Frm_Compra frmcomp = null;
        
        ControlUsuario.CntrUsuFactura fact = new ControlUsuario.CntrUsuFactura();
        ControlUsuario.CntrUsuRecibo recib = new ControlUsuario.CntrUsuRecibo();
        ControlUsuario.CntrUsuFactura factgast = new ControlUsuario.CntrUsuFactura();
        ControlUsuario.CntrUsuRecibo recibgast = null;

        private DataTable DTGastos = new DataTable();
        private string CodCompra = string.Empty;
        private decimal TCOficial = (decimal)6.96;

        public Frm_Compra()
        {
            InitializeComponent();

            ocomp = new OCompraProd();
        }

        private void Cargar_Compra()
        {
            try
            {
                lblNro.Visible = true;
                txtNumNota.Visible = true;

                DataSet CompraDS = DListarPersonalizado.ConsultarDS("SELECT * FROM Vista_CompraProd WHERE CodCompraProd='" + txtCodigoNota.Text + "'; " +
                    "SELECT * FROM Vista_Detalle_CompraProd WHERE CodCompraProd='" + txtCodigoNota.Text + "'");

                if (CompraDS.Tables[0].Rows.Count > 0)
                {
                    txtNumNota.Text = CompraDS.Tables[0].Rows[0]["NumCompraProd"].ToString();
                    cboTipoCompraProd.SelectedValue = CompraDS.Tables[0].Rows[0]["TipoCompraID"].ToString();
                    dtFecha.Value = (DateTime)CompraDS.Tables[0].Rows[0]["FechaPago"];
                    Cargar_Proveedor((int)CompraDS.Tables[0].Rows[0]["ProveedorID"], CompraDS.Tables[0].Rows[0]["NomProv"].ToString(), false);
                    txtRef.Text = CompraDS.Tables[0].Rows[0]["Referencia"].ToString();

                    foreach (DataRow item in CompraDS.Tables[1].Rows)
                    {
                        dgvDetalle.Rows.Add(-1, item.Field<int>("ProductoID"), item.Field<string>("NomProd"), item.Field<string>("UnidMedida"),
                            0, item.Field<decimal>("Cantidad"), item.Field<decimal>("PUnitario"), item.Field<decimal>("PUnitario"));
                    }
                    Totales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Nombre_Columnas_Gastos()
        {
            DTGastos.Columns.Clear();
            DTGastos.Columns.Add("GastoAdicID", Type.GetType("System.Int32"));
            DTGastos.Columns.Add("RetencionID", Type.GetType("System.Int32"));
            DTGastos.Columns.Add("ProveedorID", Type.GetType("System.Int32"));
            DTGastos.Columns.Add("TipoGastoID", Type.GetType("System.Int32"));
            DTGastos.Columns.Add("Proveedor", Type.GetType("System.String"));
            DTGastos.Columns.Add("Gasto", Type.GetType("System.String"));
            DTGastos.Columns.Add("MontoBs", Type.GetType("System.Decimal"));
            DTGastos.Columns.Add("MontoSus", Type.GetType("System.Decimal"));
            DTGastos.Columns.Add("TC", Type.GetType("System.Decimal"));
            DTGastos.Columns.Add("Glosa", Type.GetType("System.String"));
            DTGastos.Columns.Add("Fact", Type.GetType("System.Boolean"));
            DTGastos.Columns.Add("CodControl", Type.GetType("System.String"));
            DTGastos.Columns.Add("Autorizacion", Type.GetType("System.String"));
            DTGastos.Columns.Add("ICE", Type.GetType("System.Decimal"));
            DTGastos.Columns.Add("Exentos", Type.GetType("System.Decimal"));
            DTGastos.Columns.Add("NIT", Type.GetType("System.Double"));
            DTGastos.Columns.Add("Nombre", Type.GetType("System.String"));
            DTGastos.Columns.Add("Numero", Type.GetType("System.Int32"));
            DTGastos.Columns.Add("Fecha", Type.GetType("System.String"));
            DTGastos.Columns.Add("Retencion", Type.GetType("System.String"));
            dgvGastos.DataSource = DTGastos;

            dgvGastos.Columns["GastoAdicID"].Visible = false;
            dgvGastos.Columns["RetencionID"].Visible = false;
            dgvGastos.Columns["ProveedorID"].Visible = false;
            dgvGastos.Columns["TipoGastoID"].Visible = false;

            dgvGastos.Columns["Proveedor"].Width = 150;
            dgvGastos.Columns["Gasto"].Width = 150;
            dgvGastos.Columns["MontoBs"].Width = 70;
            dgvGastos.Columns["MontoSus"].Width = 70;
            dgvGastos.Columns["TC"].Width = 50;

            dgvGastos.Columns["MontoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGastos.Columns["MontoSus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGastos.Columns["TC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGastos.Columns["MontoBs"].DefaultCellStyle.Format = "N2";
            dgvGastos.Columns["MontoSus"].DefaultCellStyle.Format = "N2";
            dgvGastos.Columns["TC"].DefaultCellStyle.Format = "N2";
        }

        private void Listar_Tipo_Compra()
        {
            try
            {
                cboTipoCompraProd.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND Tupla='Compra' ORDER BY NomTipo");
                cboTipoCompraProd.DisplayMember = "NomTipo";
                cboTipoCompraProd.ValueMember = "TipoID";
                cboTipoCompraProd.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Tipo_Gastos()
        {
            try
            {
                cboGastos.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo WHERE Estado=1 AND Tupla='Gasto' " +
                    "UNION SELECT -1, '[SELECCIONE UN GASTO]' ORDER BY NomTipo");
                cboGastos.DisplayMember = "NomTipo";
                cboGastos.ValueMember = "TipoID";
                cboGastos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Tipo_Cambio()
        {
            try
            {
                TCOficial = DTipoCambio.ObtenerTC("TCCompra");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Verificar_Gastos()
        {
            if (cboProveedorGasto.ValueMember.ToString() == "-1")
            {
                MessageBox.Show("SELECCIONE UN PROVEEDOR", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProveedorGasto.Focus();
                return false;
            }
            else if (cboGastos.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("SELECCIONE UN TIPO DE GASTO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboGastos.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtGlosaGasto.Text))
            {
                MessageBox.Show("INGRESE LA GLOSA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGlosaGasto.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtMontoGastoBs.Text) <= 0)
            {
                MessageBox.Show("EL MONTO DEL GASTO TIENE QUE SER MAYOR A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMontoGastoBs.Focus();
                txtMontoGastoBs.SelectAll();
                return false;
            }
            else if (Convert.ToDecimal(txtTCGasto.Text) <= 0)
            {
                MessageBox.Show("EL TIPO DE CAMBIO NO PUEDE SER MENOR O IGUAL A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTCGasto.Focus();
                txtTCGasto.SelectAll();
                return false;
            }
            else if (rbFacturaGasto.Checked)
            {
                if (!factgast.Verificar_Factura())
                    return false;
            }
            else if (rbReciboGasto.Checked)
            {
                if (!recibgast.Verificar_Recibo())
                    return false;
            }

            return true;
        }

        private void Agregar_Gastos()
        {
            if (!Verificar_Gastos())
                return;


            DataRow filagasto;
            filagasto = DTGastos.NewRow();
            filagasto["GastoAdicID"] = txtGastoAdicID.Text;
            filagasto["ProveedorID"] = cboProveedorGasto.ValueMember;
            filagasto["TipoGastoID"] = cboGastos.SelectedValue;
            filagasto["Proveedor"] = cboProveedorGasto.Text;
            filagasto["Gasto"] = cboGastos.Text;
            filagasto["MontoBs"] = txtMontoGastoBs.Text;
            filagasto["MontoSus"] = txtMontoGastoSus.Text;
            filagasto["TC"] = txtTCGasto.Text;
            filagasto["Glosa"] = txtGlosaGasto.Text;
            filagasto["Fact"] = rbFacturaGasto.Checked;

            if (rbFacturaGasto.Checked)
            {
                filagasto["CodControl"] = factgast.txtCodControl.Text.Trim();
                filagasto["Autorizacion"] = factgast.txtAutorizacion.Text.Trim();
                filagasto["ICE"] = factgast.txtICE.Text;
                filagasto["Exentos"] = factgast.txtExcentos.Text;
                filagasto["NIT"] = factgast.txtNIT.Text;
                filagasto["Nombre"] = factgast.txtRazonSocial.Text.Trim();
                filagasto["Numero"] = factgast.txtNroFact.Text;
                filagasto["Fecha"] = factgast.dtFechaFact.Value.ToShortDateString();

                filagasto["RetencionID"] = -1;
                filagasto["Retencion"] = "";
            }
            else
            {
                filagasto["CodControl"] = "";
                filagasto["Autorizacion"] = "";
                filagasto["ICE"] = 0;
                filagasto["Exentos"] = 0;
                filagasto["NIT"] = 0;
                filagasto["Nombre"] = "";

                filagasto["Numero"] = recibgast.txtNroRecib.Text;
                filagasto["Fecha"] = recibgast.dtFechaRecib.Value.ToShortDateString();

                if (recibgast.chkRetencion.Checked)
                {
                    filagasto["RetencionID"] = recibgast.cboTipoReten.SelectedValue;
                    filagasto["Retencion"] = recibgast.cboTipoReten.Text;
                }
                else
                {
                    filagasto["RetencionID"] = -1;
                    filagasto["Retencion"] = "";
                }
            }
            DTGastos.Rows.Add(filagasto);
            Totales();

            Borrar_Gastos();
            factgast.Borrar_Factura();
            if (recibgast != null)
                recibgast.Borrar_Recibo();
        }

        private void Modif_Gastos()
        {
            if (dgvGastos.Rows.Count > 0)
            {
                int fila = dgvGastos.CurrentRow.Index;

                Cargar_Proveedor(Convert.ToInt32(dgvGastos["ProveedorID", fila].Value), dgvGastos["Proveedor", fila].Value.ToString(), true);
                txtGastoAdicID.Text = dgvGastos["GastoAdicID", fila].Value.ToString();
                cboGastos.SelectedValue = dgvGastos["TipoGastoID", fila].Value;
                txtMontoGastoBs.Text = dgvGastos["MontoBs", fila].Value.ToString();
                txtMontoGastoSus.Text = dgvGastos["MontoSus", fila].Value.ToString();
                txtTCGasto.Text = dgvGastos["TC", fila].Value.ToString();
                txtGlosaGasto.Text = dgvGastos["Glosa", fila].Value.ToString();
                rbFacturaGasto.Checked = (bool)dgvGastos["Fact", fila].Value;
                rbReciboGasto.Checked = !rbFacturaGasto.Checked;

                if ((bool)dgvGastos["Fact", fila].Value)
                {
                    factgast.txtCodControl.Text = dgvGastos["Control", fila].Value.ToString();
                    factgast.txtAutorizacion.Text = dgvGastos["Autorizacion", fila].Value.ToString();
                    factgast.txtICE.Text = dgvGastos["ICE", fila].Value.ToString();
                    factgast.txtExcentos.Text = dgvGastos["Exentos", fila].Value.ToString();
                    factgast.txtNIT.Text = dgvGastos["NIT", fila].Value.ToString();
                    factgast.txtRazonSocial.Text = dgvGastos["Nombre", fila].Value.ToString();
                    factgast.txtNroFact.Text = dgvGastos["Numero", fila].Value.ToString();
                    factgast.dtFechaFact.Text = dgvGastos["Fecha", fila].Value.ToString();
                }
                else
                {
                    recibgast.txtNroRecib.Text = dgvGastos["Numero", fila].Value.ToString();
                    recibgast.dtFechaRecib.Text = dgvGastos["Fecha", fila].Value.ToString();
                    recibgast.cboTipoReten.SelectedValue = dgvGastos["RetencionID", fila].Value.ToString();
                    //recib.chkRetencion.Checked = ((int)dgvGastos["RetencionID", fila].Value > 0);
                }

                DTGastos.Rows[fila].Delete();
                Totales();
            }
        }

        private void Elim_Gastos()
        {
            if (dgvGastos.Rows.Count > 0)
            {
                DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA ELIMINAR EL GASTO?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    if (Convert.ToInt32(dgvGastos["GastoAdicID", dgvGastos.CurrentRow.Index].Value) > 0)
                        dgvGastos["Estado", dgvGastos.CurrentRow.Index].Value = 0;
                    else
                        DTGastos.Rows[dgvGastos.CurrentRow.Index].Delete();
                }

                Totales();
            }
        }

        private void Cargar_Proveedor(int provid, string nom, bool provgasto)
        {
            if (provgasto)
            {
                cboProveedorGasto.Items.Clear();
                cboProveedorGasto.Items.Add(nom);
                cboProveedorGasto.ValueMember = provid.ToString();
                cboProveedorGasto.Text = nom;
            }
            else
            {
                cboProveedor.Items.Clear();
                cboProveedor.Items.Add(nom);
                cboProveedor.ValueMember = provid.ToString();
                cboProveedor.Text = nom;

                if (nom != "[SELECCIONE UN PROVEEDOR]")
                    txtRef.Text = nom;
            }
        }

        private void Borrar_Gastos()
        {
            txtGastoAdicID.Text = "-1";
            Cargar_Proveedor(-1, "[SELECCIONE UN PROVEEDOR]", true);
            cboGastos.SelectedValue = -1;
            txtGlosaGasto.Clear();
            txtMontoGastoBs.Text = "0.00";
            txtMontoGastoSus.Text = "0.00";
            txtTCGasto.Text = string.Format("{0:#,##0.00}", TCOficial);
            rbFacturaGasto.Checked = true;
        }

        public override void Borrar()
        {
            txtNumNota.Clear();
            txtRef.Clear();
            dtFecha.Value = DateTime.Now;
            txtObs.Clear();
            lblFecha.Text = "FECHA: " + DateTime.Now.ToShortDateString();
            Cargar_Proveedor(-1, "[SELECCIONE UN PROVEEDOR]", true);
            Cargar_Proveedor(-1, "[SELECCIONE UN PROVEEDOR]", false);
            cboTipoCompraProd.Text = "CONTADO";
            dgvDetalle.Rows.Clear();

            txtTCGasto.Text = string.Format("{0:#,##0.00}", TCOficial);
            txtTC.Text = string.Format("{0:#,##0.00}", TCOficial);

            Borrar_Gastos();
            DTGastos.Rows.Clear();
            fact.Borrar_Factura();
            if (recib != null)
                recib.Borrar_Recibo();

            txtTotImporteBs.Text = "0.00";
            txtTotImporteSus.Text = "0.00";
            txtTotRecagargoBs.Text = "0.00";
            txtTotRecagargoSus.Text = "0.00";
            txtTotCompraBs.Text = "0.00";
            txtTotCompraSus.Text = "0.00";
            txtTotCantidad.Text = "0.00";
            txtTotProd.Text = "0";
        }

        public override void Totales()
        {
            if (!Cargado)
                return;

            Cargado = false;

            //Totales Detalle Compra
            decimal cant, prec, dscto, canttot = 0;
            decimal montototal = 0;
            for (int i = 0; i < dgvDetalle.Rows.Count - 1; i++)
            {
                if (dgvDetalle["Cantidad", i].Value == null)
                    dgvDetalle["Cantidad", i].Value = 0;
                if (dgvDetalle["Precio", i].Value == null)
                    dgvDetalle["Precio", i].Value = 0;
                if (dgvDetalle["Dscto", i].Value == null)
                    dgvDetalle["Dscto", i].Value = 0;

                decimal.TryParse(dgvDetalle["Cantidad", i].Value.ToString(), out cant);
                decimal.TryParse(dgvDetalle["Precio", i].Value.ToString(), out prec);
                decimal.TryParse(dgvDetalle["Dscto", i].Value.ToString(), out dscto);

                dgvDetalle["Importe", i].Value = (cant * prec) - dscto;
                montototal += (cant * prec) - dscto;
                canttot += cant;
            }

            //Total Importe
            txtTotImporteBs.Text = string.Format("{0:#,##0.00}", montototal);
            txtTotImporteSus.Text = string.Format("{0:#,##0.00}", montototal / Convert.ToDecimal(txtTC.Text));

            //Total Recibo/Factura
            fact.txtMontoFact.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(montototal));
            if (recib != null)
                recib.txtMontoRecib.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(montototal));

            object montobs, montosus;
            if (DTGastos.Rows.Count > 0)
            {
                montobs = DTGastos.Compute("SUM(MontoBs)", "");
                montosus = DTGastos.Compute("SUM(MontoSus)", "");
            }
            else
            {
                montobs = 0;
                montosus = 0;
            }

            //Total
            txtTotProd.Text = (dgvDetalle.Rows.Count - 1).ToString();
            txtTotCantidad.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(canttot));

            //Total Recargos
            txtTotRecagargoBs.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(montobs));
            txtTotRecagargoSus.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(montosus));

            //Total Compra
            txtTotCompraBs.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotImporteBs.Text) + Convert.ToDecimal(txtTotRecagargoBs.Text));
            txtTotCompraSus.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotImporteSus.Text) + Convert.ToDecimal(txtTotRecagargoSus.Text));

            Cargado = true;
        }

        private bool Verificar_Compra()
        {
            if (cboProveedor.ValueMember == "-1")
            {
                MessageBox.Show("SELECCIONE UN PROVEEDOR", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProveedor.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtRef.Text))
            {
                MessageBox.Show("INGRESE LA REFERENCIA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRef.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtObs.Text))
            {
                MessageBox.Show("INGRESE LA GLOSA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtObs.Focus();
                return false;
            }
            else if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("INGRESE POR LO MENOS UN PRODUCTO EN LA LISTA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDetalle.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtTotImporteBs.Text) <= 0)
            {
                MessageBox.Show("EL IMPORTE TOTAL TIENE QUE SER MAYOR A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDetalle.Focus();
                return false;
            }
            else if (rbFactura.Checked)
            {
                if (!fact.Verificar_Factura())
                    return false;
            }
            else if (rbRecibo.Checked)
            {
                if (!recib.Verificar_Recibo())
                    return false;
            }

            for (int i = 0; i < dgvDetalle.Rows.Count - 1; i++)
            {
                if (dgvDetalle["ProductoID", i].Value == null)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1).ToString() + ", INGRESE UN PRODUCTO VÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(dgvDetalle["Producto", i].Value.ToString()))
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1).ToString() + ", INGRESE UN PRODUCTO VÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Cantidad", i].Value) <= 0)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1).ToString() + ", LA CANTIDAD NO PUEDE SER MENOR O IGUAL A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Precio", i].Value) <= 0)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1).ToString() + ", EL COSTO NO PUEDE SER MENOR O IGUAL A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;
        }

        private DataTable DetalleGastosDT()
        {
            DataRow Fila;
            DataTable DetGastDT = new DataTable();
            DetGastDT.Columns.Add("GastoAdicID", Type.GetType("System.Int32"));
            DetGastDT.Columns.Add("RetencionID", Type.GetType("System.Int32"));
            DetGastDT.Columns.Add("ProveedorID", Type.GetType("System.Int32"));
            DetGastDT.Columns.Add("TipoGastoID", Type.GetType("System.Int32"));
            DetGastDT.Columns.Add("MontoBs", Type.GetType("System.Double"));
            DetGastDT.Columns.Add("TC", Type.GetType("System.Double"));
            DetGastDT.Columns.Add("Glosa", Type.GetType("System.String"));
            DetGastDT.Columns.Add("Fact", Type.GetType("System.Boolean"));
            DetGastDT.Columns.Add("CodControl", Type.GetType("System.String"));
            DetGastDT.Columns.Add("Autorizacion", Type.GetType("System.String"));
            DetGastDT.Columns.Add("ICE", Type.GetType("System.Decimal"));
            DetGastDT.Columns.Add("Exentos", Type.GetType("System.Decimal"));
            DetGastDT.Columns.Add("NIT", Type.GetType("System.Double"));
            DetGastDT.Columns.Add("Nombre", Type.GetType("System.String"));
            DetGastDT.Columns.Add("Numero", Type.GetType("System.Int32"));
            DetGastDT.Columns.Add("Fecha", Type.GetType("System.String"));

            foreach (DataRow item in DTGastos.Rows)
            {
                Fila = DetGastDT.NewRow();
                Fila["GastoAdicID"] = item["GastoAdicID"];
                Fila["RetencionID"] = item["RetencionID"];
                Fila["ProveedorID"] = item["ProveedorID"];
                Fila["TipoGastoID"] = item["TipoGastoID"];
                Fila["MontoBs"] = item["MontoBs"];
                Fila["TC"] = item["TC"];
                Fila["Glosa"] = item["Glosa"];
                Fila["Fact"] = item["Fact"];
                Fila["CodControl"] = item["CodControl"];
                Fila["Autorizacion"] = item["Autorizacion"];
                Fila["ICE"] = item["ICE"];
                Fila["Exentos"] = item["Exentos"];
                Fila["NIT"] = item["NIT"];
                Fila["Nombre"] = item["Nombre"];
                Fila["Numero"] = item["Numero"];
                Fila["Fecha"] = item["Fecha"];

                DetGastDT.Rows.Add(Fila);
            }

            return DetGastDT;
        }

        public override void InsertModifNota()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            try
            {
                if (!Verificar_Compra())
                    return;
                
                string DetaModif = string.Empty;
                if (CodCompra != string.Empty)
                {
                    Frm_DetaModifAnul modif = new Frm_DetaModifAnul("MODIFICAR");
                    modif.ShowDialog();

                    if (!modif.Cancelado)
                        DetaModif = modif.DetaModAnul();
                    else
                    {
                        modif.Dispose();
                        throw new Exception("CANCELADO POR EL USUARIO");
                    }
                }

                DialogResult dialogo = MessageBox.Show("¿DESEA QUE INGRESE TODOS ESTOS PRODUCTOS A SU INVENTARIO?", "INGRESO DIRECTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.Yes)
                {
                    dialogo = MessageBox.Show("SELECCIONÓ QUE VA A INGRESAR TODOS LOS PRODUCTOS A SU INVENTARIO", "INGRESO DIRECTO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.Cancel)
                        return;
                }                
                
                ocomp.IngresoDirecto = dialogo == DialogResult.Yes;                
                ocomp.CodCompraProd = "";
                ocomp.Detalle = txtObs.Text.Trim();
                ocomp.Facturado = rbFactura.Checked;
                ocomp.TC = Convert.ToDecimal(txtTC.Text);
                ocomp.MontoBs = Convert.ToDecimal(txtTotImporteBs.Text);
                ocomp.ProveedorID = Convert.ToInt32(cboProveedor.ValueMember);
                ocomp.TipoCompraID = Convert.ToInt32(cboTipoCompraProd.SelectedValue);
                ocomp.SucursalID = OConexionGlobal.SucursalID;
                ocomp.Referencia = txtRef.Text.Trim();

                //Factura de la Compra
                ocomp.Detalle_FacturaDT = fact.FacturaDT(rbFactura.Checked);

                //Recibo de la Compra
                ocomp.Detalle_ReciboDT = recib.ReciboDT(rbRecibo.Checked);

                //Detalle de gastos
                ocomp.Detalle_GastosDT = DetalleGastosDT();

                //Detalle de compra
                ocomp.Detalle_CompraDT = InsertDetalle();
                
                string resp = DCompraProd.DInsertModifCompraProd(ocomp, OInmode.DTInmode("", (CodCompra == string.Empty ? "NUEVO" : "MODIFICAR"), DetaModif));
                
                if (resp != "-1")
                {
                    if (DConstantes.Imprimir.Nota_Compra.IMP_NOTA_COMPRA)
                    {
                        List<string> consulta = new List<string>() 
                             { 
                                "SELECT * FROM Vista_CompraProd WHERE CodCompraProd='" + resp + "'",
                               "SELECT * FROM Vista_Detalle_CompraProd WHERE CodCompraProd='" + resp + "'",
                            };
                        List<string> nomconsulta = new List<string>() { "Lista_Compra", "Detalle_Compra", };

                        Imprimir(consulta, nomconsulta, "NOTA DE COMPRA ",
                                 DConstantes.Imprimir.Nota_Compra.NOM_REPORTE_NOTA_COMPRA,
                                 DConstantes.Imprimir.Nota_Compra.IMPAUTOMATIC_NOTA_COMPRA,
                                 DConstantes.Imprimir.Nota_Compra.VISUALIZAR_NOTA_COMPRA,
                                 DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_IMP,
                                 DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_COPIAR,
                                 DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_EXPORT,
                                 DConstantes.Imprimir.Nota_Compra.MOSTRAR_ARBOL);
                    }
                    else
                        MessageBox.Show(DConstantes.Mensajes.MensajeExito, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (ocomp.IngresoDirecto)
                        ListarProductos();

                    Borrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void AbrirCerrarPanelGastos()
        {
            if (panelGastos.Width == 451)
            {
                panelGastos.Width = 41;
                panelGastos.BackColor = panelSup.BackColor;
                btnCerrarGastos.Text = "<<<";

                if (rbFacturaGasto.Checked)
                    factgast.Visible = false;
                else
                    recibgast.Visible = false;

                dgvGastos.Visible = false;
                groupBox1.Visible = false;
                tableLayoutPanel4.Visible = false;
            }
            else
            {
                panelGastos.Width = 451;
                panelGastos.BackColor = Control.DefaultBackColor;
                btnCerrarGastos.Text = ">>>";

                if (rbFacturaGasto.Checked)
                    factgast.Visible = true;
                else
                    recibgast.Visible = true;

                dgvGastos.Visible = true;
                groupBox1.Visible = true;
                tableLayoutPanel4.Visible = true;
            }
        }

        private void btnCerrarGastos_Click(object sender, EventArgs e)
        {
            AbrirCerrarPanelGastos();
        }

        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            AbrirCerrarPanelBusqProd();
            AbrirCerrarPanelGastos();
            
            Nombre_Columnas_Gastos();
            
            //Obtenemos el Tipo de Cambio Oficial
            Cargar_Tipo_Cambio();
            Listar_Tipo_Compra();
            Borrar();

            Listar_Tipo_Gastos();

            panelFactRecib.Controls.Add(fact);
            tableLayoutPanel2.Controls.Add(factgast, 0, 2);
            fact.txtMontoFact.ReadOnly = true;
            factgast.txtMontoFact.ReadOnly = true;
            dgvDetalle.Columns["Stock"].Visible = false;

            if (txtCodigoNota.Text != "-1")
                Cargar_Compra();

            Cargado = true;
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRecibo.Checked)
            {
                if (recib == null)
                    recib = new ControlUsuario.CntrUsuRecibo();

                panelFactRecib.Controls.Remove(fact);
                panelFactRecib.Controls.Add(recib);
                recib.txtMontoRecib.ReadOnly = true;
            }
            else
            {
                panelFactRecib.Controls.Remove(recib);
                panelFactRecib.Controls.Add(fact);
                fact.txtMontoFact.ReadOnly = true;
            }

            Totales();
        }
    
        private void rbReciboGasto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReciboGasto.Checked)
            {
                if (recibgast == null)
                    recibgast = new ControlUsuario.CntrUsuRecibo();

                tableLayoutPanel2.Controls.Remove(factgast);
                tableLayoutPanel2.Controls.Add(recibgast, 0, 2);
                recibgast.txtMontoRecib.ReadOnly = true;
                recibgast.txtMontoRecib.Text = txtMontoGastoBs.Text;
            }
            else
            {
                tableLayoutPanel2.Controls.Remove(recibgast);
                tableLayoutPanel2.Controls.Add(factgast, 0, 2);
                factgast.txtMontoFact.ReadOnly = true;
            }
        }

        private void BtnAgregarGasto_Click(object sender, EventArgs e)
        {
            Agregar_Gastos();
        }

        private void btnModifGasto_Click(object sender, EventArgs e)
        {
            Modif_Gastos();
        }

        private void btnElimGasto_Click(object sender, EventArgs e)
        {
            Elim_Gastos();
        }

        private void btnBusqProvGasto_Click(object sender, EventArgs e)
        {
            Frm_Proveedor prov = new Frm_Proveedor();
            prov.ShowDialog();
            prov.Dispose();

            if (prov.Seleccionado)
                Cargar_Proveedor(Convert.ToInt32(prov.txtProvID.Text), prov.txtNombre.Text, true);

            prov.Dispose();
        }

        private void btnBusqGastos_Click(object sender, EventArgs e)
        {
            Frm_Tipo tipogast = new Frm_Tipo("Gasto");
            tipogast.ShowDialog();
            Listar_Tipo_Gastos();
            tipogast.Dispose();
        }

        private void btnBusqProv_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bprov = new Buscadores.Buscador();
            bprov.Opcion = "Proveedor";
            bprov.ShowDialog();

            if (bprov.Seleccionado)
                Cargar_Proveedor(Convert.ToInt32(bprov.dgvDatos["ID", bprov.dgvDatos.CurrentRow.Index].Value),
                bprov.dgvDatos["Nombre", bprov.dgvDatos.CurrentRow.Index].Value.ToString(), false);

            bprov.Dispose();

            //Frm_Proveedor prov = new Frm_Proveedor();
            //prov.ShowDialog();
            //prov.Dispose();

            //if (prov.Seleccionado)
            //    Cargar_Proveedor(Convert.ToInt32(prov.txtProvID.Text), prov.txtNombre.Text, false);

            //prov.Dispose();
        }

        private void txtMontoGasto_TextChanged(object sender, EventArgs e)
        {
            if (!Cargado)
                return;


            Cargado = false;
            decimal valor;
            if (!decimal.TryParse(txtTCGasto.Text, out valor))
            {
                txtTCGasto.Text = string.Format("{0:#,##0.00}", TCOficial);
                txtTCGasto.SelectAll();
            }


            if (txtMontoGastoBs.Focused || txtTCGasto.Focused)
            {
                if (!decimal.TryParse(txtMontoGastoBs.Text, out valor))
                {
                    txtMontoGastoBs.Text = "0.00";
                    txtMontoGastoSus.Text = "0.00";
                    txtMontoGastoBs.SelectAll();
                    Cargado = true;
                    return;
                }

                txtMontoGastoSus.Text = string.Format("{0:#,##0.00}", Math.Round(valor / Convert.ToDecimal(txtTCGasto.Text), 4));
            }
            else if (txtMontoGastoSus.Focused)
            {
                if (!decimal.TryParse(txtMontoGastoSus.Text, out valor))
                {
                    txtMontoGastoBs.Text = "0.00";
                    txtMontoGastoSus.Text = "0.00";
                    txtMontoGastoSus.SelectAll();
                    Cargado = true;
                    return;
                }

                txtMontoGastoBs.Text = string.Format("{0:#,##0.00}", Math.Round(valor * Convert.ToDecimal(txtTCGasto.Text), 4));
            }

            factgast.txtMontoFact.Text = txtMontoGastoBs.Text;
            if (recibgast != null)
                recibgast.txtMontoRecib.Text = txtMontoGastoBs.Text;

            Cargado = true;
        }

        private void Frm_Compra_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmcomp.Dispose();
            frmcomp = null;
        }
    }
}

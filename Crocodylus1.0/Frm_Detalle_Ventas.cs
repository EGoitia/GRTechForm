using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Objetos;
using Datos;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Ventas : Frm_Base_Detalles
    {
        public static Frm_Detalle_Ventas detven = null;
            
        private string Consulta = string.Empty;
        private string ConsultaDetalle = string.Empty;
        private bool ImpAnulado = false;

        public Frm_Detalle_Ventas()
        {
            InitializeComponent();
        }

        private void HabilitarDesabilControl()
        {
            OpcionFormularios.HabilitarCont(gbxFiltro, 60);
            OpcionFormularios.HabilitarCont(gbxBotones, 60);
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodVenta"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;
            dgvDetalle.Columns["FacturaID"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;
          
            dgvDetalle.Columns["NumVenta"].HeaderText = "Nº Venta";
            dgvDetalle.Columns["NumFactura"].HeaderText = "Nº Factura";
            dgvDetalle.Columns["TipoVenta"].HeaderText = "Tipo Venta";
            dgvDetalle.Columns["MontoBs"].HeaderText = "Monto Total";
            dgvDetalle.Columns["DsctoBs"].HeaderText = "Dscto.";
            dgvDetalle.Columns["SubtotalBs"].HeaderText = "Subtotal";
            dgvDetalle.Columns["AnticipoBs"].HeaderText = "Anticipo";
            dgvDetalle.Columns["NomClien"].HeaderText = "Cliente";
            dgvDetalle.Columns["NomVendedor"].HeaderText = "Vendedor";
            dgvDetalle.Columns["NomSuc"].HeaderText = "Almacen";
            dgvDetalle.Columns["Detalle"].HeaderText = "Detalle";

            dgvDetalle.Columns["NumVenta"].FillWeight = 60;
            dgvDetalle.Columns["NumFactura"].FillWeight = 60;
            dgvDetalle.Columns["TipoVenta"].FillWeight = 70;
            dgvDetalle.Columns["MontoBs"].FillWeight = 70;
            dgvDetalle.Columns["MontoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["MontoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["DsctoBs"].FillWeight = 40;
            dgvDetalle.Columns["DsctoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["DsctoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["SubtotalBs"].FillWeight = 70;
            dgvDetalle.Columns["SubtotalBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["SubtotalBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["AnticipoBs"].FillWeight = 70;
            dgvDetalle.Columns["AnticipoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["AnticipoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["NomClien"].FillWeight = 150;
            dgvDetalle.Columns["NomVendedor"].FillWeight = 100;
            dgvDetalle.Columns["Detalle"].FillWeight = 250;
        }

        public override void Buscar()
        {
            try
            {
                Consulta = string.Format("SELECT CodVenta, CodInmode, NumVenta, FacturaID, NumFactura, Fecha, TipoVenta, " +
                    "CASE WHEN Referencia<>NomClien THEN (Referencia + ' - ' + NomClien) ELSE NomClien END NomClien, " +
                    "(MontoBs + DsctoBs) SubtotalBs, DsctoBs, MontoBs, AnticipoBs, " +
                    "SucursalID, NomSuc, NomVendedor, Estado, Detalle FROM Vista_Ventas WHERE Referencia LIKE '%{0}%'", txtCliente.Text.Trim());

                ConsultaDetalle = string.Format("SELECT CodVenta FROM Vista_Ventas WHERE Referencia LIKE '%{0}%'", txtCliente.Text.Trim());

                if (chkFechas.Checked)
                {
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
                    ConsultaDetalle += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
                }

                if (chkTipoVenta.Checked)
                {
                    Consulta += " AND TipoVenta='" + cboTipoVenta.Text + "'";
                    ConsultaDetalle += " AND TipoVenta='" + cboTipoVenta.Text + "'";
                }

                if (!string.IsNullOrEmpty(txtVendedor.Text))
                {
                    Consulta += " AND NomVendedor LIKE '%" + txtVendedor.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NomVendedor LIKE '%" + txtVendedor.Text.Trim() + "%'";
                }

                if (!string.IsNullOrWhiteSpace(txtNroVenta.Text))
                {
                    Consulta += " AND NumVenta LIKE '%" + txtNroVenta.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NumVenta LIKE '%" + txtNroVenta.Text.Trim() + "%'";
                }

                if (!string.IsNullOrWhiteSpace(txtNroFactura.Text))
                {
                    Consulta += " AND NumFactura LIKE '%" + txtNroFactura.Text + "%'";
                    ConsultaDetalle += " AND NumFactura LIKE '%" + txtNroFactura.Text + "%'";
                }

                if (chkSucursal.Checked)
                {
                    Consulta += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();
                    ConsultaDetalle += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();
                }
                
                Consulta += " AND Estado='" + (!chkAnulado.Checked).ToString() + "'";
                ConsultaDetalle += " AND Estado='" + (!chkAnulado.Checked).ToString() + "'";
                ImpAnulado = chkAnulado.Checked;

                Consulta += " ORDER BY Fecha ASC";
                
                dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);
                
                //Totales
                decimal val;
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(MontoBs)", "TipoVenta<>'ANTICIPADO'").ToString(), out val);
                                txtMontoTot.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(AnticipoBs)", "").ToString(), out val);
                txtMontoAnticipo.Text = string.Format("{0:#,##0.00}", val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Seleccionamos la ultima fila
                if (dgvDetalle.Rows.Count > 0)
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[2];
            }
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count == 0)
                return;
                        
            Frm_Reporte rep = new Frm_Reporte();
            rep.Dts.Clear();
            rep.Llenar_Tabla("SELECT * FROM Vista_Ventas WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Venta");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Venta");
            rep.Llenar_Tabla("SELECT * FROM Vista_Pagos WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Vista_Pagos");
            rep.Cargar(DConstantes.Imprimir.Nota_Venta.NOM_REPORTE_NOTA_VENTA,
                       DConstantes.Imprimir.Nota_Venta.IMPAUTOMATIC_NOTA_VENTA,
                       DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_Venta.MOSTRAR_ARBOL,
                       (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
            rep.Show();
        }

        private void ListarSucursales()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 ORDER BY NomSuc");
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;
                cboSucursal.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoVenta()
        {
            try
            {
                List<OTipoVenta> LTVen = new List<OTipoVenta>();
                OTipoVenta tven = null;


                //if (op.HabilitarOpc(cboTipoVenta, "5.01", "Contado"))
                //{
                tven = new OTipoVenta();
                tven.NomTipoVenta = "CONTADO";
                tven.Estado = true;
                LTVen.Add(tven);
                //}

                //if (op.HabilitarOpc(cboTipoVenta, "5.01", "Credito"))
                //{
                tven = new OTipoVenta();
                tven.NomTipoVenta = "CREDITO";
                tven.Estado = true;
                LTVen.Add(tven);
                //}

                //if (op.HabilitarOpc(cboTipoVenta, "5.01", "Anticipado"))
                //{
                //tven = new OTipoVenta();
                //tven.NomTipoVenta = "ANTICIPADO";
                //tven.Estado = true;
                //LTVen.Add(tven);
                //}

                cboTipoVenta.DataSource = LTVen;
                cboTipoVenta.DisplayMember = "NomTipoVenta";
                cboTipoVenta.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Detalle_Ventas_Load(object sender, EventArgs e)
        {
            HabilitarDesabilControl();
            ListarSucursales();
            ListarTipoVenta();
            Buscar();
            NombreColumnas();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("Venta", "LA VENTA Nº " + dgvDetalle["NumVenta", dgvDetalle.CurrentRow.Index].Value.ToString());
        }

        private void Frm_Detalle_Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            detven.Dispose();
            detven = null;
        }

        private void chkTipoVenta_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoVenta.Enabled = chkTipoVenta.Checked;
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFecIni.Enabled = chkFechas.Checked;
            dtFecFin.Enabled = chkFechas.Checked;
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable=string.Empty;
            if (chkFechas.Checked)
                Variable ="Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Venta";
            base.ImprLista(sql, nomtabla, "LISTA DE VENTAS" + (ImpAnulado ? " ANULADAS" : ""), Variable,
                DConstantes.Imprimir.Lista_Venta.NOM_REPORTE_LISTA_VENTA, DConstantes.Imprimir.Lista_Venta.MOSTRAR_BTN_IMP, 
                DConstantes.Imprimir.Lista_Venta.MOSTRAR_BTN_COPIAR, DConstantes.Imprimir.Lista_Venta.MOSTRAR_BTN_EXPORT, 
                DConstantes.Imprimir.Lista_Venta.MOSTRAR_ARBOL);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            if (dgvDetalle["TipoVenta", dgvDetalle.CurrentRow.Index].Value.ToString() == "ANTICIPADO")
            {
                if (!(bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value)
                {
                    MessageBox.Show("ESTA NOTA ESTÁ ANULADA", "ANULADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DataTable dt = DListarPersonalizado.ConsultarDT("SELECT NumVenta FROM Venta WHERE NumRegul='" +
                    dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("ESTA NOTA YA ESTÁ REGULARIZADA EN LA NOTA Nº " + dt.Rows[0]["NumVenta"].ToString(), "MENSAJE",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Frm_Venta.frmventa = new Frm_Venta();
                Frm_Venta.frmventa.TipoRegul = "PagoAnticip";
                Frm_Venta.frmventa.txtCodigoNota.Text = dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
                Frm_Venta.frmventa.txtNumNota.Text = dgvDetalle["NumVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
                Frm_Venta.frmventa.WindowState = FormWindowState.Maximized;
                Frm_Venta.frmventa.ShowDialog();

                Buscar();
            }
            else
                MessageBox.Show("SELECCIONE UNA NOTA DE PAGO ANTICIPADO PARA REGULARIZAR", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;
            else if (!(bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value)
            {
                MessageBox.Show("ESTA NOTA ESTÁ ANULADA", "ANULADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if ((int)DListarPersonalizado.Dato("SELECT COUNT(FacturaID) FROM Vista_Ventas Where FacturaID>0 AND CodVenta='" +
                dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value + "'") > 0)
            {
                MessageBox.Show("ESTA NOTA YA ESTÁ FACTURADO", "FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Frm_Factura_Manual frmfact = new Frm_Factura_Manual((int)dgvDetalle["FacturaID", dgvDetalle.CurrentRow.Index].Value);
            frmfact.Monto = Convert.ToDecimal(dgvDetalle["MontoBs", dgvDetalle.CurrentRow.Index].Value);
            frmfact.CodNota = dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
            frmfact.Tupla = "VENTA";
            frmfact.ShowDialog();

            if (frmfact.Guardado)
                Buscar();

            frmfact.Dispose();
        }

        private void btnImpListaDetallada_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[2];
            string[] nomtabla = new string[2];
            sql[0] = Consulta;
            sql[1] = "SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta IN(" + ConsultaDetalle + ")";
            nomtabla[0] = "Lista_Venta";
            nomtabla[1] = "Detalle_Venta";
            base.ImprLista(sql, nomtabla, "LISTA DE VENTAS DETALLADO" + (ImpAnulado ? " ANULADAS" : ""), Variable,
                DConstantes.Imprimir.Lista_Venta_Detallado.NOM_REPORTE_LISTA_VENTA_DETALLADO, 
                DConstantes.Imprimir.Lista_Venta_Detallado.MOSTRAR_BTN_IMP,
                DConstantes.Imprimir.Lista_Venta_Detallado.MOSTRAR_BTN_COPIAR, 
                DConstantes.Imprimir.Lista_Venta_Detallado.MOSTRAR_BTN_EXPORT,
                DConstantes.Imprimir.Lista_Venta_Detallado.MOSTRAR_ARBOL);
        }
    }
}

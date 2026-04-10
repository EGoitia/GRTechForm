using Datos;
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
    public partial class Frm_Detalle_VentaPOS : Form
    {
        public static Frm_Detalle_VentaPOS detven = null;

        private string Consulta = string.Empty;
        private string ConsultaDetalle = string.Empty;
        private bool ImpAnulado = false;

        public Frm_Detalle_VentaPOS()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodVenta"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;
            dgvDetalle.Columns["ClienteID"].Visible = false;
            dgvDetalle.Columns["FacturaID"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;
            dgvDetalle.Columns["Detalle"].Visible = false;
            dgvDetalle.Columns["NumFactura"].Visible = false;
            dgvDetalle.Columns["TipoVenta"].Visible = false;
            dgvDetalle.Columns["SubtotalBs"].Visible = false;
            dgvDetalle.Columns["DsctoBs"].Visible = false;
            dgvDetalle.Columns["AnticipoBs"].Visible = false;

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
            dgvDetalle.Columns["Pagos"].FillWeight = 200;
        }

        public void Buscar()
        {
            try
            {
                Consulta = string.Format("SELECT v.CodVenta, v.CodInmode, NumVenta, FacturaID, NumFactura, Fecha, TipoVenta, " +
                    "CASE WHEN Referencia<>NomClien THEN (Referencia + ' - ' + NomClien) ELSE NomClien END NomClien, ClienteID, " +
                    "(MontoBs + DsctoBs) SubtotalBs, DsctoBs, MontoBs, AnticipoBs, " +
                    "SucursalID, NomSuc, NomVendedor, v.Estado, Detalle, ISNULL(STRING_AGG(tip.NomTipo, ','), '') AS Pagos " +
                    "FROM Vista_Ventas v LEFT JOIN Pago pa ON v.CodVenta=pa.CodVenta " +
                    "LEFT JOIN Tipo_Sistema_Fijo tip ON pa.TipoPagoID=tip.TipoID " +
                    "WHERE v.Referencia LIKE '%{0}%'", txtCliente.Text.Trim());

                ConsultaDetalle = string.Format("SELECT CodVenta FROM Vista_Ventas WHERE Referencia LIKE '%{0}%'", txtCliente.Text.Trim());

                if (chkFechas.Checked)
                {
                    Consulta += " AND CONVERT(DATE, v.Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
                    ConsultaDetalle += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
                }

                if (chkTipoVenta.Checked)
                {
                    Consulta += " AND TipoVenta='" + cboTipoVenta.Text + "'";
                    ConsultaDetalle += " AND TipoVenta='" + cboTipoVenta.Text + "'";
                }

                if (chkTipoPago.Checked)
                {
                    Consulta += " AND EXISTS (SELECT 1 FROM Pago pa2 INNER JOIN Tipo_Sistema_Fijo tip2 " +
                                "ON pa2.TipoPagoID = tip2.TipoID WHERE pa2.CodVenta = v.CodVenta " +
                                "AND tip2.NomTipo = '" + cboTipoPago.Text + "') ";
                    ConsultaDetalle += " AND EXISTS (SELECT 1 FROM Pago pa2 INNER JOIN Tipo_Sistema_Fijo tip2 " +
                                "ON pa2.TipoPagoID = tip2.TipoID WHERE pa2.CodVenta = v.CodVenta " +
                                "AND tip2.NomTipo = '" + cboTipoPago.Text + "') ";
                }

                if (!string.IsNullOrEmpty(txtVendedor.Text))
                {
                    Consulta += " AND v.NomVendedor LIKE '%" + txtVendedor.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NomVendedor LIKE '%" + txtVendedor.Text.Trim() + "%'";
                }

                if (!string.IsNullOrWhiteSpace(txtNroVenta.Text))
                {
                    Consulta += " AND v.NumVenta LIKE '%" + txtNroVenta.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NumVenta LIKE '%" + txtNroVenta.Text.Trim() + "%'";
                }

                if (chkSucursal.Checked)
                {
                    Consulta += " AND v.SucursalID=" + cboSucursal.SelectedValue.ToString();
                    ConsultaDetalle += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();
                }

                Consulta += " AND v.Estado=1";
                ConsultaDetalle += " AND Estado=1";
                ImpAnulado = false;

                Consulta += " GROUP BY v.CodVenta, v.CodInmode, NumVenta, FacturaID, NumFactura, Fecha, TipoVenta, NomClien, ClienteID, " +
                            "DsctoBs, MontoBs, AnticipoBs, Referencia, SucursalID, NomSuc, NomVendedor, v.Estado, Detalle " +
                            "ORDER BY Fecha ASC";

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

        public void ImprNota()
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

        private void ListarTipoPago()
        {
            try
            {
                cboTipoPago.DataSource = DListarPersonalizado.ConsultarLocalDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo " +
                    "WHERE Estado=1 AND Tupla='PAGO' ORDER BY NomTipo");
                cboTipoPago.DisplayMember = "NomTipo";
                cboTipoPago.ValueMember = "TipoID";
                cboTipoPago.SelectedValue = OConstantes.Tipo_Pago_EFECTIVO;  //por defecto pago Efectivo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Detalle_VentaPOS_Load(object sender, EventArgs e)
        {
            ListarSucursales();
            ListarTipoVenta();
            ListarTipoPago();
            Buscar();
            NombreColumnas();
        }

        private void Frm_Detalle_VentaPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            detven.Dispose();
            detven = null;
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            ImprNota();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte();
            rep.Dts.Clear();
            rep.Llenar_Tabla("SELECT * FROM Vista_Ventas WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Venta");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Venta");
            rep.Llenar_Tabla("SELECT * FROM Vista_Pagos WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Vista_Pagos");
            rep.ExportarPDF(DConstantes.Imprimir.Nota_Venta.NOM_REPORTE_NOTA_VENTA, true, (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFecIni.Enabled = chkFechas.Checked;
            dtFecFin.Enabled = chkFechas.Checked;
        }

        private void chkTipoVenta_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoVenta.Enabled = chkTipoVenta.Checked;
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void chkTipoPago_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoPago.Enabled = chkTipoPago.Checked;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("DESEA SALIR",
                               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
                this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                //verificamos is la venta tiene saldo
                var dato = DListarPersonalizado.Dato("SELECT 1 FROM Vista_Saldos_Ventas " +
                        "WHERE (Monto - Abonado) > 0 AND CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'");
                if(dato != null)
                {
                    Frm_AbonosPOS abon = new Frm_AbonosPOS(true);
                    abon.CargarCliente(Convert.ToInt32(dgvDetalle["ClienteID", dgvDetalle.CurrentRow.Index].Value),
                                       dgvDetalle["NomClien", dgvDetalle.CurrentRow.Index].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Esta venta no tiene saldo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

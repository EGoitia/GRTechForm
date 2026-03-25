using Datos;
using Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Cotizacion : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Cotizacion frmdetcotiz = null;

        private string Consulta = string.Empty;

        public Frm_Detalle_Cotizacion()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodCotizacion"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["NumCotizacion"].HeaderText = "Nº Nota";
            dgvDetalle.Columns["Monto"].HeaderText = "Monto";
            dgvDetalle.Columns["NomClien"].HeaderText = "Cliente";
            dgvDetalle.Columns["NomVendedor"].HeaderText = "Vendedor";

            dgvDetalle.Columns["NumCotizacion"].FillWeight = 60;
            dgvDetalle.Columns["Referencia"].FillWeight = 150;
            dgvDetalle.Columns["Monto"].FillWeight = 70;
            dgvDetalle.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Monto"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["NomClien"].FillWeight = 200;
            dgvDetalle.Columns["NomVendedor"].FillWeight = 130;
        }

        public override void Buscar()
        {
            try
            {
                Consulta = "SELECT CodCotizacion, CodInmode, NumCotizacion, Fecha, NomClien, Referencia, Monto, NomSuc Sucursal, " +
                "NomVendedor, Estado FROM Vista_Cotizacion WHERE Referencia LIKE '%" + txtCliente.Text.Trim() + "%'";

                if (chkFechas.Checked)
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";

                if (!string.IsNullOrEmpty(txtVendedor.Text))
                    Consulta += " AND NomVendedor LIKE '%" + txtVendedor.Text.Trim() + "%'";

                if (!string.IsNullOrWhiteSpace(txtNroVenta.Text))
                    Consulta += " AND NumCotizacion LIKE '%" + txtNroVenta.Text.Trim() + "%'";

                if (chkSucursal.Checked)
                    Consulta += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();


                Consulta += " ORDER BY Fecha ASC";
                DataTable VentasDT = DListarPersonalizado.ConsultarDT(Consulta);
                dgvDetalle.DataSource = VentasDT;
                NombreColumnas();

                //Totales
                decimal val;
                decimal.TryParse(VentasDT.Compute("SUM(Monto)", "Estado=1").ToString(), out val);
                txtMontoTot.Text = string.Format("{0:#,##0.00}", val);
            }
            catch (Exception ex)
            {
                txtMontoTot.Text = "0.00";
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Frm_Reporte rep = new Frm_Reporte();
            rep.Dts.Clear();
            rep.Llenar_Tabla("SELECT * FROM Vista_Cotizacion WHERE CodCotizacion='" + dgvDetalle["CodCotizacion", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Cotizacion");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Cotizacion WHERE CodCotizacion='" + dgvDetalle["CodCotizacion", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Cotizacion");
            rep.Cargar("RepNotaCotizacion", false);
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

        private void Frm_Detalle_Cotizacion_Load(object sender, EventArgs e)
        {
            ListarSucursales();
            Buscar();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["CodCotizacion", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("Cotizacion", "LA COTIZACIÓN Nº " + dgvDetalle["NumCotizacion", dgvDetalle.CurrentRow.Index].Value.ToString());
        }

        private void Frm_Detalle_Cotizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmdetcotiz.Dispose();
            frmdetcotiz = null;
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFecIni.Enabled = chkFechas.Checked;
            dtFecFin.Enabled = chkFechas.Checked;
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Cotizacion";
            base.ImprLista(sql, nomtabla, "LISTA CONTIZACIÓN", Variable, "RptListaCotizacion", false);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            if (!(bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value)
            {
                MessageBox.Show("ESTA NOTA ESTÁ ANULADA", "ANULADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dt = DListarPersonalizado.ConsultarDT("SELECT NumVenta FROM Venta WHERE CodCotizacion='" +
                dgvDetalle["CodCotizacion", dgvDetalle.CurrentRow.Index].Value.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("ESTA NOTA YA ESTÁ CONFIRMADA EN LA NOTA DE VENTA Nº " + dt.Rows[0]["NumVenta"].ToString(), "MENSAJE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Frm_Cotizacion.frmcotiz = new Frm_Cotizacion();
            Frm_Cotizacion.frmcotiz.txtCodigoNota.Text = dgvDetalle["CodCotizacion", dgvDetalle.CurrentRow.Index].Value.ToString();
            Frm_Cotizacion.frmcotiz.txtNumNota.Text = dgvDetalle["NumCotizacion", dgvDetalle.CurrentRow.Index].Value.ToString();
            Frm_Cotizacion.frmcotiz.WindowState = FormWindowState.Maximized;
            Frm_Cotizacion.frmcotiz.ShowDialog();

            Buscar();
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }
    }
}

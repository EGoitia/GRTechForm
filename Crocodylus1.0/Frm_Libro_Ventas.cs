using Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Libro_Ventas : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Libro_Ventas libven = null;
        private string Consulta = string.Empty;

        public Frm_Libro_Ventas()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["FacturaID"].Visible = false;
            dgvDetalle.Columns["CodVenta"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["Numero"].HeaderText = "Nº Factura";
            dgvDetalle.Columns["Monto"].HeaderText = "Monto";
            dgvDetalle.Columns["Dscto"].HeaderText = "Descuento";
            dgvDetalle.Columns["RazonSocial"].HeaderText = "Razon Social";
            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDetalle.Columns["Codigo_Control"].HeaderText = "Código Control";
            dgvDetalle.Columns["TipoFactura"].HeaderText = "Tipo Factura";

            dgvDetalle.Columns["Numero"].FillWeight = 50;
            dgvDetalle.Columns["Monto"].FillWeight = 60;
            dgvDetalle.Columns["Dscto"].FillWeight = 60;
            dgvDetalle.Columns["IVA"].FillWeight = 60;
            dgvDetalle.Columns["ICE"].FillWeight = 60;
            dgvDetalle.Columns["Exentos"].FillWeight = 60;
            dgvDetalle.Columns["Total"].FillWeight = 60;
            dgvDetalle.Columns["RazonSocial"].FillWeight = 200;
            dgvDetalle.Columns["Codigo_Control"].FillWeight = 100;
            dgvDetalle.Columns["TipoFactura"].FillWeight = 60;
            
            dgvDetalle.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Monto"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Dscto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Dscto"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["IVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["IVA"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["ICE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["ICE"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Exentos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Exentos"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void Listar_Sucursales()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal " +
                    "WHERE Estado=1 UNION SELECT -1, '[TODAS]'");
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Tipo_Factura()
        {
            try
            {
                cboTipoFactura.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo " +
                    "WHERE Estado=1 AND Tupla='FACTURA' UNION SELECT -1, '[TODAS]'");
                cboTipoFactura.DisplayMember = "NomTipo";
                cboTipoFactura.ValueMember = "TipoID";
                cboTipoFactura.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Tipo_Actividad()
        {
            try
            {
                cboActividad.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo " +
                    "WHERE Estado=1 AND Tupla='Actividad' UNION SELECT -1, '[TODAS]'");
                cboActividad.DisplayMember = "NomTipo";
                cboActividad.ValueMember = "TipoID";
                cboActividad.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            try
            {
                Consulta = string.Format("SELECT FacturaID, CodVenta, CodInmode, Numero, Fecha, RazonSocial, " +
                    "NIT, Codigo_Control, Monto, Dscto, IVA, ICE, Exentos, Total, Autorizacion, SucursalID, " +
                    "NomSuc, TipoFactura, Actividad, Estado " +
                    "FROM Vista_Factura_Venta WHERE RazonSocial LIKE '%{0}%'", txtNombre.Text.Trim().Replace("'", ""));

                if (chkFechas.Checked)
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() + "' AND '" + dtFechaFin.Value.ToShortDateString() + "'";

                if (chkNumeros.Checked)
                    Consulta += " AND Numero BETWEEN " + txtNumIni.Value + " AND " + txtNumFin.Value;

                if (cboSucursal.SelectedValue.ToString() != "-1")
                    Consulta += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();

                if (cboTipoFactura.SelectedValue.ToString() != "-1")
                    Consulta += " AND TipoFacturaID=" + cboTipoFactura.SelectedValue.ToString();

                if (cboActividad.SelectedValue.ToString() != "-1")
                    Consulta += " AND ActividadID=" + cboActividad.SelectedValue.ToString();

                if (!string.IsNullOrWhiteSpace(txtAutorizacion.Text))
                    Consulta += " AND Autorizacion=" + txtAutorizacion.Text.Trim();

                if (!string.IsNullOrWhiteSpace(txtNIT.Text))
                    Consulta += " AND NIT=" + txtNIT.Text;

                Consulta += " ORDER BY Fecha ASC";

                dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);

                //Totales
                decimal val;
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(Monto)", "").ToString(), out val);
                txtMontoTot.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(Dscto)", "").ToString(), out val);
                txtDsctoTot.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(IVA)", "").ToString(), out val);
                txtIVATot.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(ICE)", "").ToString(), out val);
                txtICETot.Text = string.Format("{0:#,##0.00}", val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Seleccionamos la ultima fila
                if (dgvDetalle.Rows.Count > 0)
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[3];
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
            rep.Cargar(DConstantes.Imprimir.Nota_Factura.NOM_REPORTE_FACTURA,
                       DConstantes.Imprimir.Nota_Factura.IMPAUTOMATIC_FACTURA,
                       DConstantes.Imprimir.Nota_Factura.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_Factura.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_Factura.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_Factura.MOSTRAR_ARBOL,
                       (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
            rep.Show();
        }
        
        private void Frm_Libro_Ventas_Load(object sender, EventArgs e)
        {
            Listar_Sucursales();
            Listar_Tipo_Factura();
            Listar_Tipo_Actividad();
            
            Buscar();
            NombreColumnas();
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFechaIni.Enabled = chkFechas.Checked;
            dtFechaFin.Enabled = chkFechas.Checked;
        }

        private void chkNumeros_CheckedChanged(object sender, EventArgs e)
        {
            txtNumIni.Enabled = chkNumeros.Checked;
            txtNumFin.Enabled = chkNumeros.Checked;
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFechaIni.Value.ToShortDateString() + " Al " + dtFechaFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Libro_Venta";
            base.ImprLista(sql, nomtabla, "LIBRO DE VENTAS", Variable,
                DConstantes.Imprimir.Lista_Libro_Venta.NOM_REPORTE_LIBRO_VENTA, DConstantes.Imprimir.Lista_Libro_Venta.MOSTRAR_BTN_IMP,
                DConstantes.Imprimir.Lista_Libro_Venta.MOSTRAR_BTN_COPIAR, DConstantes.Imprimir.Lista_Libro_Venta.MOSTRAR_BTN_EXPORT,
                DConstantes.Imprimir.Lista_Libro_Venta.MOSTRAR_ARBOL);
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["FacturaID", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("Factura", "LA FACTURA Nº " + dgvDetalle["Numero", dgvDetalle.CurrentRow.Index].Value.ToString());
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }
    }
}

using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Libro_Compras : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Libro_Compras libcom = null;
        private string Consulta = string.Empty;

        public Frm_Libro_Compras()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["FacturaID"].Visible = false;
            dgvDetalle.Columns["CodCompra"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["CodGasto"].Visible = false;
            dgvDetalle.Columns["CodIngrEgre"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["Numero"].HeaderText = "Nº Factura";
            dgvDetalle.Columns["Monto"].HeaderText = "Monto";
            dgvDetalle.Columns["Dscto"].HeaderText = "Dscto.";
            dgvDetalle.Columns["RazonSocial"].HeaderText = "Razon Social";
            dgvDetalle.Columns["Codigo_Control"].HeaderText = "Código Control";

            dgvDetalle.Columns["Numero"].FillWeight = 50;
            dgvDetalle.Columns["Monto"].FillWeight = 60;
            dgvDetalle.Columns["Fecha"].FillWeight = 60;
            dgvDetalle.Columns["Dscto"].FillWeight = 60;
            dgvDetalle.Columns["ICE"].FillWeight = 60;
            dgvDetalle.Columns["Exentos"].FillWeight = 60;
            dgvDetalle.Columns["Total"].FillWeight = 60;
            dgvDetalle.Columns["RazonSocial"].FillWeight = 200;
            dgvDetalle.Columns["Codigo_Control"].FillWeight = 100;
            dgvDetalle.Columns["Tipo"].FillWeight = 60;

            dgvDetalle.Columns["Fecha"].DefaultCellStyle.Format = "d";
            dgvDetalle.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Monto"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Dscto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Dscto"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["ICE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["ICE"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Exentos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Exentos"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        public override void Buscar()
        {
            try
            {
                Consulta = string.Format("SELECT FacturaID, CodInmode, CodCompra, CodGasto, CodIngrEgre, Numero, Fecha, RazonSocial, " +
                    "NIT, Codigo_Control, Monto, Dscto, ICE, Exentos, Total, Autorizacion, Tipo, Estado " +
                    "FROM Vista_Factura_Compra WHERE RazonSocial LIKE '%{0}%'", txtNombre.Text.Trim().Replace("'", ""));

                if (chkFechas.Checked)
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() + "' AND '" + dtFechaFin.Value.ToShortDateString() + "'";

                if (!string.IsNullOrWhiteSpace(txtAutorizacion.Text))
                    Consulta += " AND Autorizacion=" + txtAutorizacion.Text.Trim();

                if (!string.IsNullOrWhiteSpace(txtNIT.Text))
                    Consulta += " AND NIT=" + txtNIT.Text;

                if (!string.IsNullOrWhiteSpace(txtNumero.Text))
                    Consulta += " AND Numero=" + txtNumero.Text;

                Consulta += " ORDER BY Fecha ASC";

                dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);

                //Totales
                decimal val;
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(Monto)", "").ToString(), out val);
                txtMontoTot.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(Dscto)", "").ToString(), out val);
                txtDsctoTot.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(ICE)", "").ToString(), out val);
                txtICETot.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(Exentos)", "").ToString(), out val);
                txtExentoTot.Text = string.Format("{0:#,##0.00}", val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Seleccionamos la ultima fila
                if (dgvDetalle.Rows.Count > 0)
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[5];
            }
        }

        public override void ImprNota()
        {
            //if (dgvDetalle.Rows.Count == 0)
            //    return;

            //Frm_Reporte rep = new Frm_Reporte();
            //rep.Dts.Clear();
            //rep.Llenar_Tabla("SELECT * FROM Vista_Ventas WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Venta");
            //rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Venta");
            //rep.Cargar(DConstantes.Imprimir.Nota_Factura.NOM_REPORTE_FACTURA,
            //           DConstantes.Imprimir.Nota_Factura.IMPAUTOMATIC_FACTURA,
            //           DConstantes.Imprimir.Nota_Factura.MOSTRAR_BTN_IMP,
            //           DConstantes.Imprimir.Nota_Factura.MOSTRAR_BTN_COPIAR,
            //           DConstantes.Imprimir.Nota_Factura.MOSTRAR_BTN_EXPORT,
            //           DConstantes.Imprimir.Nota_Factura.MOSTRAR_ARBOL,
            //           (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
            //rep.Show();
        }

        private void Frm_Libro_Compras_Load(object sender, EventArgs e)
        {
            Buscar();
            NombreColumnas();
        }

        private void Frm_Libro_Compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            libcom.Dispose();
            libcom = null;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Frm_Factura_Manual fact = new Frm_Factura_Manual(1);
            fact.ShowDialog();
        }

    }
}

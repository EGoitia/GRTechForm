using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Lote : Form
    {
        public DataTable ListaProdDT = null;
        public DataTable LotesSeriesDT = new DataTable();
        public bool Cancelado = true;
        private bool Cargado = false;

        public Frm_Lote()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            LotesSeriesDT.Columns.Add("ProductoID");
            LotesSeriesDT.Columns.Add("NomProd");
            LotesSeriesDT.Columns.Add("NumLoteSerie");
            LotesSeriesDT.Columns.Add("Cantidad", Type.GetType("System.Decimal"));
            LotesSeriesDT.Columns.Add("Fecha_Elab");
            LotesSeriesDT.Columns.Add("Fecha_Venc");
            LotesSeriesDT.Columns.Add("EsLote");

            dgvLotesSeries.DataSource = LotesSeriesDT;
            dgvLotesSeries.Columns["ProductoID"].Visible = false;
            dgvLotesSeries.Columns["EsLote"].Visible = false;

            dgvLotesSeries.Columns["NomProd"].HeaderText = "Producto";
            dgvLotesSeries.Columns["NumLoteSerie"].HeaderText = "Nº Lote";
            dgvLotesSeries.Columns["Fecha_Elab"].HeaderText = "Fecha Elab.";
            dgvLotesSeries.Columns["Fecha_Venc"].HeaderText = "Fecha Venc.";

            dgvLotesSeries.Columns["NomProd"].FillWeight = 150;
            dgvLotesSeries.Columns["NumLoteSerie"].FillWeight = 80;
            dgvLotesSeries.Columns["Cantidad"].FillWeight = 70;
            dgvLotesSeries.Columns["Fecha_Elab"].FillWeight = 90;
            dgvLotesSeries.Columns["Fecha_Venc"].FillWeight = 90;

            dgvLotesSeries.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLotesSeries.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
        }

        private bool VerificarRegistrar()
        {
            if (string.IsNullOrWhiteSpace(txtNumLote.Text))
            {
                MessageBox.Show("INGRESE EL LOTE", "LOTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumLote.Focus();
                return false;
            }
            decimal valor;
            if (!decimal.TryParse(txtCantidad.Text, out valor))
            {
                MessageBox.Show("INGRESE UNA CANTIDAD VÁLIDA", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                txtCantidad.SelectAll();
                return false;
            }
            if (valor <= 0)
            {
                MessageBox.Show("LA CANTIDAD TIENE QUE SER MAYOR QUE CERO", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                txtCantidad.SelectAll();
                return false;
            }
            DateTime fecha;
            if (!DateTime.TryParse(txtFechaVenc.Text, out fecha))
            {
                MessageBox.Show("LA FECHA ES INCORRECTA", "FECHA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                txtFechaVenc.Focus();
                txtFechaVenc.SelectAll();
                return false;
            }
            if (txtFecElab.Text.Trim() != "/  /")
            {
                if (!DateTime.TryParse(txtFecElab.Text, out fecha))
                {
                    MessageBox.Show("LA FECHA ES INCORRECTA", "FECHA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFecElab.Focus();
                    txtFecElab.SelectAll();
                    return false;
                }
            }

            dgvDetalle.Focus();
            object cantingre = LotesSeriesDT.Compute("SUM(Cantidad)", "ProductoID=" + dgvDetalle["ProductoID", dgvDetalle.CurrentRow.Index].Value.ToString());
            if (cantingre != DBNull.Value)
            {
                if ((Convert.ToDecimal(cantingre) + Convert.ToDecimal(txtCantidad.Text)) > Convert.ToDecimal(dgvDetalle["Cantidad", dgvDetalle.CurrentRow.Index].Value))
                {
                    MessageBox.Show("LAS SUMAS DE LAS CANTIDADES NO PUEDE SER MAYOR QUE " + string.Format("{0:#,##0.00}", dgvDetalle["Cantidad", dgvDetalle.CurrentRow.Index].Value));
                    txtCantidad.Focus();
                    txtCantidad.SelectAll();
                    return false;
                }
            }
            else if (Convert.ToDecimal(txtCantidad.Text) > Convert.ToDecimal(dgvDetalle["Cantidad", dgvDetalle.CurrentRow.Index].Value))
            {
                MessageBox.Show("LAS SUMAS DE LAS CANTIDADES NO PUEDE SER MAYOR QUE " + string.Format("{0:#,##0.00}", dgvDetalle["Cantidad", dgvDetalle.CurrentRow.Index].Value));
                txtCantidad.Focus();
                txtCantidad.SelectAll();
                return false;
            }

            return true;
        }

        private void Totales()
        {
            if (!Cargado)
                return;

            Cargado = false;

            dgvDetalle.Focus();
            object cantingre = LotesSeriesDT.Compute("SUM(Cantidad)", "ProductoID=" + dgvDetalle["ProductoID", dgvDetalle.CurrentRow.Index].Value.ToString());
            if (cantingre != DBNull.Value)
            {
                if (Convert.ToDecimal(cantingre) == Convert.ToDecimal(dgvDetalle["Cantidad", dgvDetalle.CurrentRow.Index].Value))
                    ListaProdDT.Rows[dgvDetalle.CurrentRow.Index]["Estado"] = false;
            }

            Cargado = true;
        }

        private void BorrarLote()
        {
            txtCantidad.Clear();
            txtNumLote.Clear();
            txtFecElab.Clear();
            txtFechaVenc.Clear();
        }

        private void Frm_Lote_Load(object sender, EventArgs e)
        {
            NombreColumnas();

            dgvDetalle.DataSource = ListaProdDT;
            dgvDetalle.Columns["ProductoID"].Visible = false;
            dgvDetalle.Columns["EsLote"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;
            
            dgvDetalle.Columns["NomProd"].HeaderText = "Producto";
            dgvDetalle.Columns["UnidMedida"].HeaderText = "Medida";

            dgvDetalle.Columns["NomProd"].FillWeight = 200;
            dgvDetalle.Columns["UnidMedida"].FillWeight = 60;

            Cargado = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cancelado = false;
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!VerificarRegistrar())
                return;


            dgvDetalle.Focus();
            DataRow fila = LotesSeriesDT.NewRow();
            fila["ProductoID"] = Convert.ToInt32(dgvDetalle["ProductoID", dgvDetalle.CurrentRow.Index].Value);
            fila["NomProd"] = dgvDetalle["NomProd", dgvDetalle.CurrentRow.Index].Value.ToString();
            fila["NumLoteSerie"] = txtNumLote.Text.Trim();
            fila["Cantidad"] = decimal.Parse(txtCantidad.Text);
            fila["Fecha_Elab"] = ((txtFecElab.Text.Trim() == "/  /") ? null : txtFecElab.Text);
            fila["Fecha_Venc"] = txtFechaVenc.Text;
            fila["EsLote"] = dgvDetalle["EsLote", dgvDetalle.CurrentRow.Index].Value;
            LotesSeriesDT.Rows.Add(fila);
            Totales();
            BorrarLote();

            txtNumLote.Focus();
        }

        private void Frm_Lote_Serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNumLote.Focused)
                    txtCantidad.Focus();
                else if (txtCantidad.Focused)
                    txtFecElab.Focus();
                else if (txtFecElab.Focused)
                    txtFechaVenc.Focus();
                else if (txtFechaVenc.Focused)
                    btnRegistrar.Focus();
            }
        }

        private void Frm_Lote_Serial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Cancelado)
                return;

            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
                e.Cancel = true;
        }

        private void dgvLotesSeries_KeyDown(object sender, KeyEventArgs e)
        {
            if (LotesSeriesDT.Rows.Count == 0)
                return;

            if (e.KeyCode == Keys.Delete) // para eliminar la fila
            {
                DialogResult result = MessageBox.Show("ESTÁ SEGURO QUE DESEA ELIMINAR ESTA FILA?", "ELIMINAR FILA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    string prodid = dgvLotesSeries["ProductoID", dgvLotesSeries.CurrentRow.Index].Value.ToString();

                    DataRow[] lprod = ListaProdDT.Select("ProductoID=" + prodid);
                    lprod[0]["Estado"] = true;

                    //eliminamos la fila seleccionada
                    LotesSeriesDT.Rows[dgvLotesSeries.CurrentRow.Index].Delete();

                    txtNumLote.Focus();
                    txtNumLote.SelectAll();
                }
            }
        }

        private void dgvDetalle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (!(bool)dgvDetalle["Estado", e.RowIndex].Value)
            {
                dgvDetalle.CurrentCell = null;
                dgvDetalle.Rows[e.RowIndex].Visible = false;
            }
            else
                dgvDetalle.Rows[e.RowIndex].Visible = true;
        }

    }
}

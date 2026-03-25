using System;
using System.Data;
using System.Windows.Forms;
using Negocio;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Productos : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Productos detprod = null;
        private string Consulta = string.Empty;

        public Frm_Detalle_Productos()
        {
            InitializeComponent();
        }

        public override void Buscar()
        {
            Consulta = "SELECT TOP 100 ProductoID, CodInmode, CodFabrica, NomProd, Descripcion, UnidMedida, Moneda, Marca, " +
                       "NomGrupo, NomSubGrupo, Estado FROM Vista_Productos WHERE NomProd LIKE '%" + txtProducto.Text.Trim() + "%' " +
                       " AND Estado='" + !chkAnulado.Checked + "'";

            if (!string.IsNullOrWhiteSpace(txtCodFab.Text))
                Consulta += " AND CodFabrica LIKE '%" + txtCodFab.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
                Consulta += " AND NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtSubgrupo.Text))
                Consulta += " AND NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtMarca.Text))
                Consulta += " AND Marca LIKE '%" + txtMarca.Text.Trim() + "%'";

            Consulta += " ORDER BY NomProd DESC";

            try
            {
                DataTable ProdDT = NListarPersonalizado.ConsultarDT(Consulta);
                dgvDetalle.DataSource = ProdDT;
                NombreColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["ProductoID"].HeaderText = "ID";
            dgvDetalle.Columns["ProductoID"].FillWeight = 50;

            dgvDetalle.Columns["CodFabrica"].HeaderText = "Código";
            dgvDetalle.Columns["CodFabrica"].FillWeight = 80;

            dgvDetalle.Columns["NomProd"].HeaderText = "Producto";
            dgvDetalle.Columns["NomProd"].FillWeight = 200;

            dgvDetalle.Columns["Descripcion"].HeaderText = "Descripción";
            dgvDetalle.Columns["Descripcion"].FillWeight = 200;

            dgvDetalle.Columns["UnidMedida"].HeaderText = "U.M.";
            dgvDetalle.Columns["UnidMedida"].FillWeight = 50;

            dgvDetalle.Columns["NomGrupo"].HeaderText = "Grupo";
            dgvDetalle.Columns["NomSubGrupo"].HeaderText = "SubGrupo";

            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;
        }

        private void Frm_Detalle_Productos_Load(object sender, EventArgs e)
        {
            btnImpNota.Visible = false;
            Buscar();
        }

        private void Frm_Detalle_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            detprod.Dispose();
            detprod = null;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Modificar("Producto");
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.RowCount > 0)
            {
                base.ID = dgvDetalle["ProductoID", dgvDetalle.CurrentRow.Index].Value.ToString();
                base.Estado = (bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value;

                base.Anular("Producto", "EL PRODUCTO " + dgvDetalle["NomProd", dgvDetalle.CurrentRow.Index].Value.ToString());
            }
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Productos";

            base.ImprLista(sql, nomtabla, "LISTA DE PRODUCTOS", "ListProd", "RptListaProductos", false);
        }

    }
}

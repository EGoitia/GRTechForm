using Datos;
using Objetos;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Catalogo_Producto : Form
    {
        public static Frm_Catalogo_Producto frmcatprod = null;
        private bool Cargado = false;

        public Frm_Catalogo_Producto()
        {
            InitializeComponent();
        }

        public void ListarSucursal()
        {
            try
            {
                cboSucursal.DataSource = DSucursal.DListarSucursales();
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            string Consulta;
            Consulta = "SELECT TOP 50 vp.ProductoID, vp.NomProd, vp.UnidMedida, vp.Marca, vp.NomGrupo, vp.NomSubGrupo, vp.Descripcion, " +
                "vp.PVentaMenorEmp, vp.PVentaMayorEmp, suc.SucursalID, suc.NomSuc, s.StockAlmacen, vp.Img FROM Vista_Productos vp " +
                "INNER JOIN Stock_Prod s ON s.ProductoID=vp.ProductoID INNER JOIN Sucursal suc ON suc.SucursalID=s.AlmacenID " +
                "WHERE vp.Estado=1 AND s.AlmacenID=" + cboSucursal.SelectedValue;
 
            if (!string.IsNullOrWhiteSpace(txtProducto.Text))
                Consulta += " AND vp.NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtCodFab.Text))
                Consulta += " AND vp.CodFabrica LIKE '%" + txtCodFab.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
                Consulta += " AND vp.NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtSubgrupo.Text))
                Consulta += " AND vp.NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtMarca.Text))
                Consulta += " AND vp.Marca LIKE '%" + txtMarca.Text.Trim() + "%'";
            if(!string.IsNullOrWhiteSpace(txtDescrip.Text))
                Consulta += " AND vp.Descripcion LIKE '%" + txtDescrip.Text.Trim() + "%'";
            if (chkStock.Checked)
                Consulta += " AND s.StockAlmacen>0";

            Consulta += " ORDER BY vp.Marca, vp.NomGrupo, vp.NomSubGrupo, vp.NomProd";

            try
            {
                dgvListProd.Rows.Clear();
                foreach (DataRow item in DListarPersonalizado.ConsultarDT(Consulta).Rows)
                {
                    byte[] Img = null;
                    if (item["Img"] != DBNull.Value)
                        Img = (byte[])item["Img"];
                    
                    dgvListProd.Rows.Add(item.Field<int>("ProductoID"), item.Field<string>("NomProd"), item.Field<string>("UnidMedida"), item.Field<string>("Marca"),
                        item.Field<decimal>("PVentaMayorEmp"), item.Field<decimal>("PVentaMenorEmp"), item.Field<decimal>("StockAlmacen"), item.Field<string>("NomProd"), Img);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Seleccionar(int fila)
        {
            if (!Cargado)
                return;

            txtDesc.Text = dgvListProd["Descripcion", fila].Value.ToString();
            if (dgvListProd["Img", fila].Value != null)
            {
                MemoryStream m_MemoryStream = new MemoryStream((byte[])dgvListProd["Img", fila].Value);
                pbxImagen.BackgroundImage = new System.Drawing.Bitmap(m_MemoryStream);
            }
            else
                pbxImagen.BackgroundImage = null;          
            
        }

        private void Frm_Catalogo_Producto_Load(object sender, EventArgs e)
        {
            ListarSucursal();
            Buscar();
            Cargado = true;
        }

        private void Frm_Catalogo_Producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmcatprod.Dispose();
            frmcatprod = null;
        }

        private void dgvListProd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar(e.RowIndex);
        }

        private void dgvListProd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvListProd.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            } 
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

    }
}

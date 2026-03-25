using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroProductos : UserControl
    {
        public CntrlUsuFiltroProductos()
        {
            InitializeComponent();
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT vp.ProductoID, vp.CodInmode, vp.Estado, vp.NomProd, vp.UnidMedida, vp.Marca, vp.NomGrupo, vp.NomSubGrupo, " +
                "vp.PCostoEmp, vp.PVentaMenorEmp, vp.PVentaMayorEmp, suc.SucursalID, suc.NomSuc, s.StockAlmacen FROM Vista_Productos vp " +
                "INNER JOIN Stock_Prod s ON s.ProductoID=vp.ProductoID INNER JOIN Sucursal suc ON suc.SucursalID=s.AlmacenID WHERE s.StockAlmacen<>0";

            if (chkSucursal.Checked)
                Consulta += " AND s.AlmacenID=" + cboSucursal.SelectedValue;
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

            Consulta += " ORDER BY vp.Marca, vp.NomGrupo, vp.NomSubGrupo, vp.NomProd";

            return Consulta;
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
        
        private void chkSucursal_CheckedChanged(object sender, System.EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }
    }
}

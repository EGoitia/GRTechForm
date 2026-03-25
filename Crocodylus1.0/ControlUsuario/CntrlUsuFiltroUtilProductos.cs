using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroUtilProductos : UserControl
    {
        public CntrlUsuFiltroUtilProductos()
        {
            InitializeComponent();
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT * FROM Vista_Detalle_Ventas_Util WHERE CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() +
                       "' AND '" + dtFecFin.Value.ToShortDateString() + "'";

            if (chkSucursal.Checked)
                Consulta += " AND AlmacenID=" + cboSucursal.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtProducto.Text))
                Consulta += " AND NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtCodFab.Text))
                Consulta += " AND CodFabrica LIKE '%" + txtCodFab.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
                Consulta += " AND NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtSubgrupo.Text))
                Consulta += " AND NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtMarca.Text))
                Consulta += " AND Marca LIKE '%" + txtMarca.Text.Trim() + "%'";
            if(!string.IsNullOrWhiteSpace(txtCliente.Text))
                Consulta += " AND NomClien LIKE '%" + txtCliente.Text.Trim() + "%'";

            Consulta += " ORDER BY Fecha, Marca, NomGrupo, NomSubGrupo, NomProd";

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

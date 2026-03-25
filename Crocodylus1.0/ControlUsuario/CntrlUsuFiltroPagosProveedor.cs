using System.Windows.Forms;
using Objetos;
using Datos;
using System.Data;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroPagosProveedor : UserControl
    {
        public CntrlUsuFiltroPagosProveedor()
        {
            InitializeComponent();
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT * From Vista_Abonos WHERE Estado=1 AND TipoAbono='Proveedor'";

            if (chkTipoProv.Checked)
                Consulta += " AND TipoProvID=" + cboTipoProv.SelectedValue;
            if (chkSucursal.Checked)
                Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtProveedor.Text))
                Consulta += " AND NomProv LIKE '%" + txtProveedor.Text.Trim() + "%'";

            Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() + "' AND '" + dtFechaFin.Value.ToShortDateString() + "'";

            return Consulta;
        }

        private void ListarDatos()
        {
            try
            {
                DataSet DSDatos = DListarPersonalizado.ConsultarDS("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc;" +
                    "SELECT TipoID, NomTipo FROM Tipo WHERE Estado=1 AND Tupla='Proveedor' ORDER BY NomTipo");

                cboSucursal.DataSource = DSDatos.Tables[0];
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;

                cboTipoProv.DataSource = DSDatos.Tables[1];
                cboTipoProv.DisplayMember = "NomTipo";
                cboTipoProv.ValueMember = "TipoID";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTipoClien_CheckedChanged(object sender, System.EventArgs e)
        {
            cboTipoProv.Enabled = chkTipoProv.Checked;
        }

        private void chkSucursal_CheckedChanged(object sender, System.EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void CntrlUsuFiltroCuentasXCobrar_Load(object sender, System.EventArgs e)
        {
            ListarDatos();
        }
    }
}

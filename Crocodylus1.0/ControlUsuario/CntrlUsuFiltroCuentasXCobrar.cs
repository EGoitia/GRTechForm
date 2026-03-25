using System.Windows.Forms;
using Objetos;
using Datos;
using System.Data;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroCuentasXCobrar : UserControl
    {
        public CntrlUsuFiltroCuentasXCobrar()
        {
            InitializeComponent();
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT * From Vista_Saldos_Ventas WHERE (Monto-Abonado) > 0 AND TipoVenta IN('CREDITO', 'DEUDA')";

            if (chkTipoClien.Checked)
                Consulta += " AND TipoClienteID=" + cboTipoClien.SelectedValue;
            if (chkSucursal.Checked)
                Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;
            if (chkVendedor.Checked)
                Consulta += " AND VendedorID=" + cboVendedor.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
                Consulta += " AND NomClien LIKE '%" + txtCliente.Text.Trim() + "%'";

            return Consulta;
        }

        private void ListarDatos()
        {
            try
            {
                DataSet DSDatos = DListarPersonalizado.ConsultarDS("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc;" +
                    "SELECT TipoID, NomTipo FROM Tipo WHERE Estado=1 AND Tupla='Cliente' ORDER BY NomTipo;" + 
                    "SELECT PersonalID, NomPer FROM Personal WHERE CargoID IN(2, 3) ORDER BY NomPer");

                cboSucursal.DataSource = DSDatos.Tables[0];
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;

                cboTipoClien.DataSource = DSDatos.Tables[1];
                cboTipoClien.DisplayMember = "NomTipo";
                cboTipoClien.ValueMember = "TipoID";

                cboVendedor.DataSource = DSDatos.Tables[2];
                cboVendedor.DisplayMember = "NomPer";
                cboVendedor.ValueMember = "PersonalID";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTipoClien_CheckedChanged(object sender, System.EventArgs e)
        {
            cboTipoClien.Enabled = chkTipoClien.Checked;
        }

        private void chkSucursal_CheckedChanged(object sender, System.EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void chkVendedor_CheckedChanged(object sender, System.EventArgs e)
        {
            cboVendedor.Enabled = chkVendedor.Checked;
        }

        private void CntrlUsuFiltroCuentasXCobrar_Load(object sender, System.EventArgs e)
        {
            ListarDatos();
        }
    }
}

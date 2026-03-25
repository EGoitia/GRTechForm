using System.Windows.Forms;
using Objetos;
using Datos;
using System.Data;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroAbonoCliente : UserControl
    {
        public CntrlUsuFiltroAbonoCliente()
        {
            InitializeComponent();
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT * From Vista_Abonos WHERE Estado=1 AND TipoAbono='Cliente'";

            if (chkTipoCli.Checked)
                Consulta += " AND TipoClienteID=" + cboTipoClien.SelectedValue;
            if (chkSucursal.Checked)
                Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
                Consulta += " AND NomClien LIKE '%" + txtCliente.Text.Trim() + "%'";

            Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() + "' AND '" + dtFechaFin.Value.ToShortDateString() + "'";

            return Consulta;
        }

        private void ListarDatos()
        {
            try
            {
                DataSet DSDatos = DListarPersonalizado.ConsultarDS("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc;" +
                    "SELECT TipoID, NomTipo FROM Tipo WHERE Estado=1 AND Tupla='Cliente' ORDER BY NomTipo");

                cboSucursal.DataSource = DSDatos.Tables[0];
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;

                cboTipoClien.DataSource = DSDatos.Tables[1];
                cboTipoClien.DisplayMember = "NomTipo";
                cboTipoClien.ValueMember = "TipoID";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTipoClien_CheckedChanged(object sender, System.EventArgs e)
        {
            cboTipoClien.Enabled = chkTipoCli.Checked;
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

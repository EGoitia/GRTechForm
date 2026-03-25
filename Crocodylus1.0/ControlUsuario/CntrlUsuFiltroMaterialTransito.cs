using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroMaterialTransito : UserControl
    {
        public CntrlUsuFiltroMaterialTransito()
        {
            InitializeComponent();
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT * From Vista_Material_Transito WHERE (Cantidad-CantidadIngreso) > 0";

            if (chkTipoProv.Checked)
                Consulta += " AND TipoProvID=" + cboTipoProv.SelectedValue;
            if (chkSucursal.Checked)
                Consulta += " AND AlmacenID=" + cboSucursal.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtProv.Text))
                Consulta += " AND NomProv LIKE '%" + txtProv.Text.Trim() + "%'";

            return Consulta;
        }

        private void ListarDatos()
        {
            try
            {
                DataSet DSDatos = DListarPersonalizado.ConsultarDS("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc;" +
                    "SELECT TipoID, NomTipo FROM Tipo WHERE Estado=1 AND Tupla='Proveedor' ORDER BY NomTipo;");

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

        private void chkTipoProv_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoProv.Enabled = chkTipoProv.Checked;
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void CntrlUsuFiltroMaterialTransito_Load(object sender, EventArgs e)
        {
            ListarDatos();
        }

      
    }
}

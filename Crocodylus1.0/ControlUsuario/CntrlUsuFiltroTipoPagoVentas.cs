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
    public partial class CntrlUsuFiltroTipoPagoVentas : UserControl
    {
        public CntrlUsuFiltroTipoPagoVentas()
        {
            InitializeComponent();
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT * From Vista_Tipo_Pago_Ventas WHERE CONVERT(DATE, FechaReg) BETWEEN '" + dtFechaIni.Value.ToShortDateString() + "' AND '" + dtFechaFin.Value.ToShortDateString() + "'";

            if (chkTipoPago.Checked)
                Consulta += " AND TipoPagoID=" + cboTipoPago.SelectedValue;
            if (chkSucursal.Checked)
                Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtCliProv.Text))
                Consulta += " AND NomProv LIKE '%" + txtCliProv.Text.Trim() + "%'";

            return Consulta;
        }

        private void ListarDatos()
        {
            try
            {
                DataSet DSDatos = DListarPersonalizado.ConsultarDS("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc;" +
                    "SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND Tupla='Pago' ORDER BY NomTipo");

                cboSucursal.DataSource = DSDatos.Tables[0];
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;

                cboTipoPago.DataSource = DSDatos.Tables[1];
                cboTipoPago.DisplayMember = "NomTipo";
                cboTipoPago.ValueMember = "TipoID";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTipoPago_CheckedChanged(object sender, System.EventArgs e)
        {
            cboTipoPago.Enabled = chkTipoPago.Checked;
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

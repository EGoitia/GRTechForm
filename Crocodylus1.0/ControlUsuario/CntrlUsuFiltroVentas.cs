using System;
using System.Data;
using System.Windows.Forms;
using Objetos;
using Datos;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroVentas : UserControl
    {
        public CntrlUsuFiltroVentas()
        {
            InitializeComponent();
        }

        public void ListarTipoReporte()
        {
            try
            {
                cboTipoRep.DataSource = DListarPersonalizado.ConsultarDT("SELECT Descrip, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND Tupla='REPVENTA' ORDER BY NomTipo");
                cboTipoRep.DisplayMember = "NomTipo";
                cboTipoRep.ValueMember = "Descrip";
                cboTipoRep.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarSucursal()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc");
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarVendedor()
        {
            try
            {
                DataTable VendDT = DListarPersonalizado.ConsultarDT("SELECT PersonalID, NomPer FROM Personal WHERE CargoID IN(2, 3) ORDER BY NomPer");
                cboVendedor.DataSource = VendDT;
                cboVendedor.DisplayMember = "NomPer";
                cboVendedor.ValueMember = "PersonalID";
                cboVendedor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoVenta()
        {
            try
            {
                cboTipVenta.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND Tupla='VENTA' ORDER BY NomTipo");
                cboTipVenta.DisplayMember = "NomTipo";
                cboTipVenta.ValueMember = "TipoID";
                cboTipVenta.SelectedValue = 4; //por defecto 4=CONTADO
                cboTipVenta.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT * From Vista_Ventas WHERE Estado=1";

            if (chkSucursal.Checked)
                Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;
            if (chkVendedor.Checked)
                Consulta += " AND VendedorID=" + cboVendedor.SelectedValue;
            if (chkTipoVenta.Checked)
                Consulta += " AND TipoVentaID=" + cboTipVenta.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtCliente.Text))
                Consulta += " AND NomClien LIKE '% " + txtCliente.Text.Trim() + "%'";

            Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFIni.Value.ToShortDateString() + "' AND '" + dtFFin.Value.ToShortDateString() + "'";

            return Consulta;
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void chkVendedor_CheckedChanged(object sender, EventArgs e)
        {
            cboVendedor.Enabled = chkVendedor.Checked;

            if (cboVendedor.DataSource == null)
                ListarVendedor();
        }

        private void chkTipoVenta_CheckedChanged(object sender, EventArgs e)
        {
            cboTipVenta.Enabled = chkTipoVenta.Checked;

            if (cboTipVenta.DataSource == null)
                ListarTipoVenta();
        }

    }
}

using System;
using System.Windows.Forms;
using Datos;
using System.Data;


namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrUsuRecibo : UserControl
    {
        public CntrUsuRecibo()
        {
            InitializeComponent();
        }

        private void Listar_Tipo_Retencion()
        {
            try
            {
                cboTipoReten.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Tupla='RETENCION'");
                cboTipoReten.DisplayMember = "NomTipo";
                cboTipoReten.ValueMember = "TipoID";
                cboTipoReten.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Verificar_Recibo()
        {
            if (string.IsNullOrWhiteSpace(txtNroRecib.Text))
            {
                MessageBox.Show("INGRESE EL NÚMERO DEL RECIBO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNroRecib.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtMontoRecib.Text))
            {
                MessageBox.Show("INGRESE EL MONTO DEL RECIBO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMontoRecib.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtMontoRecib.Text) <= 0)
            {
                MessageBox.Show("EL MONTO TIENE QUE SER MAYOR A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMontoRecib.Focus();
                return false;
            }
            
            return true;
        }

        public void Borrar_Recibo()
        {
            txtNroRecib.Clear();
            dtFechaRecib.Value = DateTime.Now;
            chkRetencion.Checked = false;
        }

        public DataTable ReciboDT(bool selec)
        {
            DataRow fila;
            DataTable recibdt = new DataTable();
            recibdt.Columns.Add("ReciboID");
            recibdt.Columns.Add("Numero");
            recibdt.Columns.Add("Fecha");
            recibdt.Columns.Add("Retencion");
            recibdt.Columns.Add("RetencionID");
            recibdt.Columns.Add("Monto");

            if (selec)
            {
                fila = recibdt.NewRow();
                fila["ReciboID"] = -1;
                fila["Numero"] = Convert.ToInt32(txtNroRecib.Text);
                fila["Fecha"] = dtFechaRecib.Value;
                fila["Retencion"] = chkRetencion.Checked;
                fila["RetencionID"] = (chkRetencion.Checked ? (int)cboTipoReten.SelectedValue : -1);
                fila["Monto"] = Convert.ToDecimal(txtMontoRecib.Text);
                recibdt.Rows.Add(fila);
            }

            return recibdt;
        }

        private void chkRetencion_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoReten.Enabled = chkRetencion.Checked;
        }

        private void CntrUsuRecibo_Load(object sender, EventArgs e)
        {
            Listar_Tipo_Retencion();
        }
    }
}

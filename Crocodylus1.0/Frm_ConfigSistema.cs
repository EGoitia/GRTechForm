using Datos;
using System;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_ConfigSistema : Form
    {
        public Frm_ConfigSistema()
        {
            InitializeComponent();
        }

        private void btnGuardarConfigVenta_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.myColor = Color.AliceBlue; 
            ConfigGRTech.Default["Formato_Impr_Nota_Venta"] = cboImprNotaVenta.SelectedValue.ToString();
            ConfigGRTech.Default["Impr_Aut_Nota_Venta"] = chkImpAutNotaVenta.Checked;
            ConfigGRTech.Default.Save();
        }

        private void btnGuardarActualizador_Click(object sender, EventArgs e)
        {
            //ConfigGRTech.Default["Ubicación_Sistem_Actualizador"] = txtUbicActualizador.Text;
            //ConfigGRTech.Default.Save();

            try
            {
                if (ConfigService.ModificarValor("RutaSistemaActualizador", txtUbicActualizador.Text.Trim()))
                    MessageBox.Show(DConstantes.Mensajes.MensajeExito, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(DConstantes.Mensajes.MensajeError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_ConfigSistema_Load(object sender, EventArgs e)
        {
            try
            {
                DbContext.Up();
                txtUbicActualizador.Text = ConfigService.ObtenerValor("RutaSistemaActualizador");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

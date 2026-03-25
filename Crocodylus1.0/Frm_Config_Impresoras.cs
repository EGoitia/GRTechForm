using GRTechnology1._0.Properties;
using System;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Config_Impresoras : Form
    {
        public Frm_Config_Impresoras()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Settings.Default.ImpPredeterminada = txtNomImp.Text;
            Settings.Default.Save();   
        }

        private void Frm_Config_Impresoras_Load(object sender, EventArgs e)
        {
            txtNomImp.Text = Settings.Default.ImpPredeterminada;
        }
    }
}

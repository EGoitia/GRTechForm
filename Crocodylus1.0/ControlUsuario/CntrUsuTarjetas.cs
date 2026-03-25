using System.Windows.Forms;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrUsuTarjetas : UserControl
    {
        public CntrUsuTarjetas()
        {
            InitializeComponent();
        }

        public bool verificar_Tarjeta()
        {
            if (string.IsNullOrWhiteSpace(txtbancoTar.Text))
            {
                txtbancoTar.Focus();
                MessageBox.Show("EL CAMPO BANCO NO PUEDE ESTAR VACÍO");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtRefTar.Text))
            {
                txtRefTar.Focus();
                MessageBox.Show("EL Nº DE REF. NO PUEDE ESTAR VACÍO");
                return false;
            }

            return true;
        }

        public void BorrarTarjeta()
        {
            txtbancoTar.Clear();
            txtRefTar.Clear();
        }
    }
}

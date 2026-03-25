using System.Windows.Forms;

namespace TransportNET
{
    public partial class CntrUsuTarjeta : UserControl
    {
        public CntrUsuTarjeta()
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

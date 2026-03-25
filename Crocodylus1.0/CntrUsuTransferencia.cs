using System.Windows.Forms;

namespace TransportNET
{
    public partial class CntrUsuTransferencia : UserControl
    {
        public CntrUsuTransferencia()
        {
            InitializeComponent();
        }

        public bool Verificar_Transferencia()
        {
            if (string.IsNullOrWhiteSpace(txtBancoDestino.Text))
            {
                txtBancoDestino.Focus();
                MessageBox.Show("EL BANCO DE DESTINO NO PUEDE ESTAR VACÍO");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtBancoOrigen.Text))
            {
                txtBancoOrigen.Focus();
                MessageBox.Show("EL BANCO DE ORÍGEN NO PUEDE ESTAR VACÍO");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCtaDestino.Text))
            {
                txtCtaDestino.Focus();
                MessageBox.Show("EL Nº DE CTA. DE DESTINO NO PUEDE ESTAR VACÍO");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtctaOrigen.Text))
            {
                txtctaOrigen.Focus();
                MessageBox.Show("EL Nº DE CTA. DE ORÍGEN NO PUEDE ESTAR VACÍO");
                return false;
            }
            return true;
        }

        public void BorrarTransf()
        {
            txtBancoDestino.Clear();
            txtBancoOrigen.Clear();
            txtCtaDestino.Clear();
            txtctaOrigen.Clear();
        }
    }
}

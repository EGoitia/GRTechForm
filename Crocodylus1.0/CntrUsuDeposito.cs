using System;
using System.Windows.Forms;

namespace TransportNET
{
    public partial class CntrUsuDeposito : UserControl
    {
        public CntrUsuDeposito()
        {
            InitializeComponent();
        }

        public bool Verificar_Deposito()
        {
            if (string.IsNullOrWhiteSpace(txtBancoDep.Text))
            {
                txtBancoDep.Focus();
                MessageBox.Show("EL CAMPO BANCO NO PUEDE ESTAR VACÍO");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCuentaDep.Text))
            {
                txtCuentaDep.Focus();
                MessageBox.Show("EL Nº DE CUENTA NO PUEDE ESTAR VACÍO");
                return false;
            }

            return true;
        }

        public void BorrarDeposito()
        {
            txtBancoDep.Clear();
            txtCuentaDep.Clear();
            DtFecCobroDep.Value = DateTime.Now;
        }
    }
}

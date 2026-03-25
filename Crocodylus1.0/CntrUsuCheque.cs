using System;
using System.Windows.Forms;

namespace TransportNET
{
    public partial class CntrUsuCheque : UserControl
    {
        public CntrUsuCheque()
        {
            InitializeComponent();
        }

        public bool Verificar_cheque()
        {
            if (string.IsNullOrWhiteSpace(txtBancoCheque.Text))
            {
                txtBancoCheque.Focus();
                MessageBox.Show("EL CAMPO BANCO NO PUEDE ESTAR VACÍO");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(TxtCheque.Text))
            {
                TxtCheque.Focus();
                MessageBox.Show("EL Nº DE CHEQUE NO PUEDE ESTAR VACÍO");
                return false;
            }

            return true;
        }

        public void BorrarCheque()
        {
            txtBancoCheque.Clear();
            TxtCheque.Clear();
            txtFechaChequeCobro.Value = DateTime.Now;
            txtFechaChequeEmi.Value = DateTime.Now;
        }
    }
}

using Datos;
using Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrUsuTransferencia : UserControl
    {
        public CntrUsuTransferencia()
        {
            InitializeComponent();
        }

        private void ListarBancos()
        {
            try
            {
                DataTable CajaUsuDT = DListarPersonalizado.ConsultarLocalDT("SELECT CajaID, NomCaja FROM Caja " +
                    "WHERE TipoCajaID in(" + OConstantes.Tipo_Caja_BANCO + "," + OConstantes.Tipo_Caja_TARJETA + ") " +
                    "ORDER BY NomCaja");
                cboBanco.DataSource = CajaUsuDT;
                cboBanco.DisplayMember = "NomCaja";
                cboBanco.ValueMember = "CajaID";
                cboBanco.Refresh();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Verificar_Transferencia()
        {
            if (string.IsNullOrWhiteSpace(txtBancoDestino.Text))
            {
                txtBancoDestino.Focus();
                MessageBox.Show("EL BANCO DE DESTINO NO PUEDE ESTAR VACÍO");
                return false;
            }
            //else if (string.IsNullOrWhiteSpace(txtBancoOrigen.Text))
            //{
            //    txtBancoOrigen.Focus();
            //    MessageBox.Show("EL BANCO DE ORÍGEN NO PUEDE ESTAR VACÍO");
            //    return false;
            //}
            else if (string.IsNullOrWhiteSpace(txtCtaDestino.Text))
            {
                txtCtaDestino.Focus();
                MessageBox.Show("EL Nº DE CTA. DE DESTINO NO PUEDE ESTAR VACÍO");
                return false;
            }
            //else if (string.IsNullOrWhiteSpace(txtctaOrigen.Text))
            //{
            //    txtctaOrigen.Focus();
            //    MessageBox.Show("EL Nº DE CTA. DE ORÍGEN NO PUEDE ESTAR VACÍO");
            //    return false;
            //}

            return true;
        }

        public void BorrarTransf()
        {
            txtBancoDestino.Clear();            
            txtCtaDestino.Clear();
            txtCuentaDep.Clear();
            DtFecCobroTransf.Value = DateTime.Now;
        }

        private void CntrUsuTransferencia_Load(object sender, System.EventArgs e)
        {
            ListarBancos();
        }
    }
}

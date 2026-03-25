using System;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_ValidacionFactura : Form
    {
        public Frm_ValidacionFactura()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            CodigoControl.CodigoControl cod = new CodigoControl.CodigoControl();
            cod.Autorizacion = txtAutorizacion.Value;
            cod.Factura = txtNumFactura.Value.ToString();
            cod.Nit = txtNIT.Value.ToString();
            cod.fecha = Convert.ToDateTime(dtFecha.Value.ToShortDateString());
            cod.llave = txtLlave.Text;
            cod.monto = txtMonto.Value.ToString();
            cod.CalculoCodigoControl();

            if (cod.Resultado == null)
                txtCodigoControl.Text = "0";
            else
                txtCodigoControl.Text = cod.Resultado.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtLlave.Clear();
            txtCodigoControl.Clear();
            txtAutorizacion.Value = 0;
            txtMonto.Value = 0;
            txtNIT.Value = 0;
            txtNumFactura.Value = 0;
        }
    }
}

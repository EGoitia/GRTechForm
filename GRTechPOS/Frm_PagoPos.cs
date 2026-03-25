using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRTechPOS
{
    public partial class Frm_PagoPos : Form
    {
        public DataTable DTTipoPago = null;
        public bool Guardar = false;


        private int TipoPagoSelecID = 1; //Efectivo
        public string PagadoEfec = string.Empty;
        private string PagadoTarj = string.Empty;
        private string PagadoQR = string.Empty;

        public Frm_PagoPos()
        {
            InitializeComponent();
        }

        private bool VerificarPago()
        {
            if (txtTotPagado.Value <= 0)
            {
                MessageBox.Show("EL MONTO PAGADO NO PUEDE SER MENOR O IGUAL A CERO", "TIPO PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if ((txtTotPagado.Value - txtTotCambio.Value != txtTotImporte.Value))
            {
                MessageBox.Show("EL MONTO PAGADO NO PUEDE SER MAYOR IMPORTE TOTAL", "TIPO PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private bool VerificarGuardar()
        {
            if (txtTotImporte.Value > txtTotPagado.Value)
            {
                MessageBox.Show("TIENE QUE COMPLETAR EL PAGO", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtQR.Value + txtTarj.Value >= txtTotImporte.Value)
            {
                if (txtEfec.Value > 0)
                {
                    MessageBox.Show("LA SUMATORIA DE LOS PAGOS QR, TARJETA Y EFECTIVO NO PUEDE SER MAYOR AL IMPORTE A PAGAR", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;
        }

        private void Totales()
        {
            txtTotPagado.Value = txtEfec.Value + txtTarj.Value + txtQR.Value;
            txtTotCambio.Value = txtTotPagado.Value - txtTotImporte.Value;
        }

        public void BorrarTodo()
        {
            Guardar = false;
            txtTotImporte.Value = 0;
            txtTotPagado.Value = 0;
            txtTotCambio.Value = 0;

            txtTarj.Value = 0;
            txtQR.Value = 0;
            txtEfec.Value = 0;

            PagadoEfec = string.Empty;
            PagadoQR = string.Empty;
            PagadoTarj = string.Empty;
            TipoPagoSelecID = 1;

            txtEfec.Focus();
            txtEfec.Select();

            btnEfec.BackColor = System.Drawing.Color.Gold;
            btnQR.BackColor = System.Drawing.Color.Crimson;
            btnTar.BackColor = System.Drawing.Color.Crimson;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "<<<")
            {
                if (PagadoEfec.Length > 0 && TipoPagoSelecID == 1)
                {
                    PagadoEfec = "0";
                    txtEfec.Value = Convert.ToDecimal((!string.IsNullOrEmpty(PagadoEfec) ? PagadoEfec : "0"));
                }

                else if (PagadoTarj.Length > 0 && TipoPagoSelecID == 2)
                {
                    PagadoTarj = "0";
                    txtTarj.Value = Convert.ToDecimal((!string.IsNullOrEmpty(PagadoTarj) ? PagadoTarj : "0"));
                }
                else if (PagadoQR.Length > 0 && TipoPagoSelecID == 3)
                {
                    PagadoQR = "0";
                    txtQR.Value = Convert.ToDecimal((!string.IsNullOrEmpty(PagadoQR) ? PagadoQR : "0"));
                }
            }
            else
            {
                if (TipoPagoSelecID == 1)
                {
                    if (btn.Text == "." && PagadoEfec.Contains("."))
                        return;

                    PagadoEfec += btn.Text;

                    if (PagadoEfec == ".")
                        PagadoEfec = "0.";

                    if (Convert.ToDecimal((!string.IsNullOrEmpty(PagadoEfec) ? PagadoEfec : "0")) > txtEfec.Maximum)
                        PagadoEfec = PagadoEfec.Substring(0, PagadoEfec.Length - 1);

                    int pos_punto = PagadoEfec.IndexOf(".");
                    if (pos_punto > 0)
                    {
                        if (PagadoEfec.Substring(pos_punto - 1, PagadoEfec.Length - pos_punto).Count() > 3)
                            if (PagadoEfec.Substring(pos_punto - 1, PagadoEfec.Length - pos_punto).Count() > 3)
                                if (PagadoEfec.Substring(pos_punto - 1, PagadoEfec.Length - pos_punto).Count() > 3)
                                    PagadoEfec = PagadoEfec.Substring(0, PagadoEfec.Length - 1);
                    }

                    txtEfec.Value = Convert.ToDecimal((!string.IsNullOrEmpty(PagadoEfec) ? PagadoEfec : "0"));
                }
                else if (TipoPagoSelecID == 2)
                {
                    if (btn.Text == "." && PagadoTarj.Contains("."))
                        return;

                    PagadoTarj += btn.Text;

                    if (PagadoTarj == ".")
                        PagadoTarj = "0.";

                    if (Convert.ToDecimal((!string.IsNullOrEmpty(PagadoTarj) ? PagadoTarj : "0")) > txtTarj.Maximum)
                        PagadoTarj = PagadoTarj.Substring(0, PagadoTarj.Length - 1);

                    int pos_punto = PagadoTarj.IndexOf(".");
                    if (pos_punto > 0)
                    {
                        if (PagadoTarj.Substring(pos_punto - 1, PagadoTarj.Length - pos_punto).Count() > 3)
                            if (PagadoTarj.Substring(pos_punto - 1, PagadoTarj.Length - pos_punto).Count() > 3)
                                if (PagadoTarj.Substring(pos_punto - 1, PagadoTarj.Length - pos_punto).Count() > 3)
                                    PagadoTarj = PagadoTarj.Substring(0, PagadoEfec.Length - 1);
                    }

                    txtTarj.Value = Convert.ToDecimal((!string.IsNullOrEmpty(PagadoTarj) ? PagadoTarj : "0"));
                }
                else if (TipoPagoSelecID == 3)
                {
                    if (btn.Text == "." && PagadoQR.Contains("."))
                        return;

                    PagadoQR += btn.Text;

                    if (PagadoQR == ".")
                        PagadoQR = "0.";

                    if (Convert.ToDecimal((!string.IsNullOrEmpty(PagadoQR) ? PagadoQR : "0")) > txtQR.Maximum)
                        PagadoQR = PagadoQR.Substring(0, PagadoQR.Length - 1);

                    int pos_punto = PagadoQR.IndexOf(".");
                    if (pos_punto > 0)
                    {
                        if (PagadoQR.Substring(pos_punto - 1, PagadoQR.Length - pos_punto).Count() > 3)
                            if (PagadoQR.Substring(pos_punto - 1, PagadoQR.Length - pos_punto).Count() > 3)
                                if (PagadoQR.Substring(pos_punto - 1, PagadoQR.Length - pos_punto).Count() > 3)
                                    PagadoQR = PagadoQR.Substring(0, PagadoEfec.Length - 1);
                    }

                    txtQR.Value = Convert.ToDecimal((!string.IsNullOrEmpty(PagadoQR) ? PagadoQR : "0"));
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (TipoPagoSelecID == 1)
            {
                PagadoEfec = string.Empty;
                txtEfec.Value = 0;
            }
            else if (TipoPagoSelecID == 2)
            {
                PagadoTarj = string.Empty;
                txtTarj.Value = 0;
            }
            else
            {
                PagadoQR = string.Empty;
                txtQR.Value = 0;
            }
        }

        private void btnEfec_Click(object sender, EventArgs e)
        {
            TipoPagoSelecID = 1;
            txtEfec.Focus();
            txtEfec.Select();

            btnEfec.BackColor = System.Drawing.Color.Gold;
            btnQR.BackColor = System.Drawing.Color.Crimson;
            btnTar.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnTar_Click(object sender, EventArgs e)
        {
            TipoPagoSelecID = 2;

            btnQR.BackColor = System.Drawing.Color.Gold;
            txtTarj.Focus();

            btnEfec.BackColor = System.Drawing.Color.Crimson;
            btnQR.BackColor = System.Drawing.Color.Crimson;
            btnTar.BackColor = System.Drawing.Color.Gold;
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            TipoPagoSelecID = 3;
            txtQR.Focus();
            txtQR.Select();

            btnEfec.BackColor = System.Drawing.Color.Crimson;
            btnQR.BackColor = System.Drawing.Color.Gold;
            btnTar.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Guardar = false;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarGuardar())
            {
                Guardar = true;
                this.Close();
            }
        }

        private void txt_ValueChanged(object sender, EventArgs e)
        {
            Totales();
        }
    }
}

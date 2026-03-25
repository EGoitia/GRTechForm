using GRTechnology1._0.Clases;
using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_PagoPos : Form
    {
        TextBox txtActivo;

        public DataTable DTTipoPago = null;
        public bool Guardar = false;

        decimal efec, tarj, qr;

        public Frm_PagoPos()
        {
            InitializeComponent();
        }

        private bool VerificarGuardar()
        {
            if (txtTotImporte.Value > txtTotPagado.Value)
            {
                MessageBox.Show("TIENE QUE COMPLETAR EL PAGO", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtTotPagado.Value > txtTotImporte.Value)
            {
                if (efec > 0 && (qr > 0 || tarj > 0))
                {
                    MessageBox.Show("LA SUMATORIA DE LOS PAGOS QR, TARJETA Y EFECTIVO NO PUEDE SER MAYOR AL IMPORTE A PAGAR", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (qr > 0 || tarj > 0)
                {
                    MessageBox.Show("LA SUMATORIA DE LOS PAGOS QR, TARJETA Y EFECTIVO NO PUEDE SER MAYOR AL IMPORTE A PAGAR", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else if (txtTotPagado.Value <= 0)
            {
                MessageBox.Show("EL MONTO PAGADO NO PUEDE SER MENOR O IGUAL A CERO", "TIPO PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if ((txtTotPagado.Value - txtTotCambio.Value != txtTotImporte.Value))
            {
                MessageBox.Show("EL MONTO PAGADO NO PUEDE SER MAYOR IMPORTE TOTAL", "TIPO PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void ProcTotales()
        {
            decimal.TryParse(txtEfec.Text, out efec);
            decimal.TryParse(txtPagDesp.Text, out tarj);
            decimal.TryParse(txtQR.Text, out qr);

            txtTotPagado.Value = efec + tarj + qr;
            txtTotCambio.Value = txtTotPagado.Value - txtTotImporte.Value;

            if (Properties.Settings.Default.Display_Habil)
                CustomerDisplay.Instance.MostrarCambio(txtTotCambio.Value);
        }

        public void BorrarTodo()
        {
            if (txtActivo != null)
                txtActivo.BackColor = Color.White;

            txtActivo = txtEfec;
            txtActivo.BackColor = Color.DodgerBlue;
            Guardar = false;
            txtTotImporte.Value = 0;
            txtTotPagado.Value = 0;
            txtTotCambio.Value = 0;

            txtPagDesp.Text = "0";
            txtQR.Text = "0";
            txtEfec.Text = "0";
            //TipoPagoSelecID = OConstantes.Tipo_Pago_EFECTIVO;

            txtEfec.Focus();
            txtEfec.Select();

            btnEfec.BackColor = System.Drawing.Color.Gold;
            btnQR.BackColor = System.Drawing.Color.Crimson;
            btnTar.BackColor = System.Drawing.Color.Crimson;
        }

        private void PresionarPunto()
        {
            if (txtActivo == null)
                return;

            if (!txtActivo.Text.Contains("."))
            {
                if (txtActivo.Text == "")
                    txtActivo.Text = "0.";

                else
                    txtActivo.Text += ".";
            }
        }

        private void PresionarNumero(string numero)
        {
            if (txtActivo == null)
                return;

            if (txtActivo.Text == "0")
                txtActivo.Text = numero;
            else
                txtActivo.Text += numero;

            ProcTotales();
        }

        private void BorrarNumero()
        {
            if (txtActivo == null)
                return;

            if (txtActivo.Text.Length > 0)
                txtActivo.Text = txtActivo.Text.Substring(0, txtActivo.Text.Length - 1);

            if (txtActivo.Text == "")
                txtActivo.Text = "0";
        }

        private void PresionarEnter()
        {
            txtActivo.BackColor = Color.White;

            if (txtActivo == txtEfec)
                txtActivo = txtQR;

            else if (txtActivo == txtQR)
                txtActivo = txtPagDesp;

            else if (txtActivo == txtPagDesp)
                txtActivo = txtEfec;

            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void btnNro_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            PresionarNumero(btn.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtActivo.Text = "0";
            ProcTotales();
        }

        private void btnEfec_Click(object sender, EventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtEfec;
            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void btnTar_Click(object sender, EventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtPagDesp;
            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtQR;
            txtActivo.BackColor = Color.DodgerBlue;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            PresionarEnter();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarNumero();
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            PresionarPunto();
        }

        private void txtEfec_MouseClick(object sender, MouseEventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtEfec;
            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void txtPagDesp_MouseClick(object sender, MouseEventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtPagDesp;
            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void txtQR_MouseClick(object sender, MouseEventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtQR;
            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void Frm_PagoPos_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Display_Habil)
                CustomerDisplay.Instance.MostrarCobrar(txtTotImporte.Value);
        }
    }
}

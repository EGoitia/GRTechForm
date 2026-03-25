using GRTechnology1._0.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_SelectProductoPOS : Form
    {
        public bool Seleccionado = false;
        public Decimal Stock = 0;

        TextBox txtActivo;

        public Frm_SelectProductoPOS()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Seleccionado = false;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Verificar())
                return;

            Seleccionado = true;
            this.Close();
        }

        private void btnNro_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            PresionarNumero(btn.Text);
        }

        public void Borrar()
        {
            if (txtActivo != null)
                txtActivo.BackColor = Color.White;

            txtActivo = txtCantidad;
            txtActivo.BackColor = Color.DodgerBlue;
            Seleccionado = false;
            Stock = 0;
            txtProducto.Clear();
            txtCantidad.Text = "0";
            txtPrecio.Text = "0";
            txtTotal.Text = "0";
        }

        private bool Verificar()
        {
            decimal valor;
            if (!decimal.TryParse(txtCantidad.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Ingrese un peso válido");
                return false;
            }
            else if (!decimal.TryParse(txtPrecio.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Ingrese un precio válido");
                return false;
            }            
            else if (Convert.ToDecimal(txtTotal.Text) <= 0)
            {
                MessageBox.Show("el monto total no puede ser menor o igual a cero");
                return false;
            }

            return true;
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

            txtActivo.Focus();
            ProcTotales();

            //en pantalla del display imprimimos la cantidad
            if (Properties.Settings.Default.Display_Habil)
                CustomerDisplay.Instance.MostrarCantidad(txtActivo.Text);
        }

        private void BorrarNumero()
        {
            if (txtActivo == null)
                return;

            if (txtActivo.Text.Length > 0)
                txtActivo.Text = txtActivo.Text.Substring(0, txtActivo.Text.Length - 1);

            if (txtActivo.Text == "")
                txtActivo.Text = "0";

            ProcTotales();
        }

        private void PresionarEnter()
        {
            txtActivo.BackColor = Color.White;

            if (txtActivo == txtCantidad)
                txtActivo = txtPrecio;
                
            else if (txtActivo == txtPrecio)
                txtActivo = txtCantidad;
                
            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void ProcTotales()
        {
            decimal cant, prec;
            decimal.TryParse(txtCantidad.Text, out cant);
            decimal.TryParse(txtPrecio.Text, out prec);

            txtTotal.Text = (cant * prec).ToString("N2");
        }     

        private void btnComa_Click(object sender, EventArgs e)
        {
            PresionarPunto();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarNumero();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PresionarEnter();
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtActivo.Text = "0";
            ProcTotales();
        }

        private void txtPrecio_MouseClick(object sender, MouseEventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtPrecio;
            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void txtCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtCantidad;
            txtActivo.BackColor = Color.DodgerBlue;
        }

        private void Frm_SelectProductoPOS_KeyDown(object sender, KeyEventArgs e)
        {
            // Números (teclado superior y numérico)
            bool esNumero =
                (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);

            // Punto (teclado normal y numérico)
            bool esPunto =
                e.KeyCode == Keys.OemPeriod ||
                e.KeyCode == Keys.Decimal;

            // Enter
            bool esEnter = e.KeyCode == Keys.Enter;

            if (esNumero)
            {
                string numero = ObtenerNumeroDesdeKey(e);
                if (numero != null)
                {
                    PresionarNumero(numero);
                }
            }
            else if (esPunto)
            {
                PresionarPunto();
            }
            else if (esEnter)
            {
                PresionarEnter();
            }
        }

        private string ObtenerNumeroDesdeKey(KeyEventArgs e)
        {
            // Teclado superior
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                return (e.KeyCode - Keys.D0).ToString();
            }

            // Teclado numérico
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                return (e.KeyCode - Keys.NumPad0).ToString();
            }

            return null;
        }

    }
}

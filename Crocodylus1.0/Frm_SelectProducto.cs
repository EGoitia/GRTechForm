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
    public partial class Frm_SelectProducto : Form
    {
        public bool Cancelado = false;

        public Frm_SelectProducto()
        {
            InitializeComponent();
        }

        private void Frm_SelectProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                SendKeys.Send("+{TAB}");
            }
        }

        private void Frm_SelectProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ent;
            ent = Convert.ToChar(Keys.Enter);

            if (e.KeyChar == ent)
            {
                if (btnCancelar.Focused)
                {
                    this.Close();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                    e.Handled = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelado = true;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (txtDetAnul.Text != string.Empty)
            //{
                this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("El Detalle no puede estar Vacio", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    //txtDetAnul.Focus();
            //}
        }

        private void Frm_SelectProducto_Load(object sender, EventArgs e)
        {

        }

        private void GetTotal()
        {
            txtTotal.Value = Math.Round((txtCantidad.Value * txtPrecio.Value) - txtDscto.Value, 2);
        }

        private void txt_ValueChanged(object sender, EventArgs e)
        {
            GetTotal();
        }
    }
}

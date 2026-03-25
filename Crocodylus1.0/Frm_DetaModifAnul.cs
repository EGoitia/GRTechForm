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
    public partial class Frm_DetaModifAnul : Form
    {
        string Op = string.Empty;
        public bool Cancelado = false;

        public Frm_DetaModifAnul(string op)
        {
            InitializeComponent();

            Op = op;
        }

        private void DetaModifAnul_Load(object sender, EventArgs e)
        {
            this.Text = Op;
            btnAnular.Text = Op;
            //ponemos el foco en el txt
            txtDetAnul.Focus();
        }

        public string DetaModAnul()
        {
            return this.txtDetAnul.Text;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (txtDetAnul.Text != string.Empty)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("El Detalle no puede estar Vacio", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDetAnul.Focus();
            }
        }

        private void DetaModifAnul_KeyDown(object sender, KeyEventArgs e)
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

        private void DetaModifAnul_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ent;
            ent = Convert.ToChar(Keys.Enter);

            if (e.KeyChar == ent)
            {
                if (btnAnular.Focused)
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
    }
}

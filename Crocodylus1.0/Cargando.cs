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
    public partial class Cargando : Form
    {
        public Cargando()
        {
            InitializeComponent();
        }

        public void Mensaje(string msje)
        {
            lblMensaje.Text = msje;
            this.Show();
            Application.DoEvents();
        }

    }
}

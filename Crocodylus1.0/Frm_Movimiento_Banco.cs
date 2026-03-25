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
    public partial class Frm_Movimiento_Banco : Form
    {
        public bool Guardado = false;
        public int? BancoId = null;
        public string NomBanco = string.Empty;

        public Frm_Movimiento_Banco()
        {
            InitializeComponent();
        }

        private void btnBusqBanco_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bbanco = new Buscadores.Buscador();
            bbanco.Owner = this;
            bbanco.Opcion = "Banco";
            bbanco.ShowDialog();

            if (bbanco.Seleccionado)
            {
                txtID.Text = bbanco.dgvDatos["ID", bbanco.dgvDatos.CurrentRow.Index].Value.ToString();
                txtNombre.Text = bbanco.dgvDatos["Nombre", bbanco.dgvDatos.CurrentRow.Index].Value.ToString();
            }

            bbanco.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Movimiento_Banco_Load(object sender, EventArgs e)
        {
            if (BancoId != null && NomBanco != string.Empty)
            {
                txtID.Text = BancoId.ToString();
                txtNombre.Text = NomBanco;
            }
        }
    }
}

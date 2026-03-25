using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Negocio;
using Datos;

namespace GRTechnology1._0
{
    public partial class Frm_Inmode : Form
    {
        List<OInmode> LInm = null;
        string CodInmode = string.Empty;

        public Frm_Inmode(string codinmode)
        {
            InitializeComponent();

            CodInmode = codinmode;
        }

        private void NombreColumnas()
        {
            dgvInmode.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Usuario";
            c1.Width = 150;
            c1.Visible = false;
            dgvInmode.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Personal";
            c2.Width = 180;
            dgvInmode.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Tipo";
            c3.Width = 90;
            dgvInmode.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Fecha";
            c4.Width = 90;
            dgvInmode.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Hora";
            c5.Width = 60;
            dgvInmode.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Detalle";
            c6.Width = 300;
            dgvInmode.Columns.Add(c6);
        }

        private void CargarInmode()
        {
            try
            {
                NombreColumnas();

                LInm = NInmode.NListarInmode(CodInmode);
                foreach (var item in LInm)
                {
                    dgvInmode.Rows.Add(item.NomUsu, item.NomInmode, item.TipoInmode, item.FechaInmode.ToShortDateString(), 
                                       item.FechaInmode.ToShortTimeString(), item.DetalleInmode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                NombreColumnas();
            }
        }

        private void Llenar_Inmode()
        {
            try
            {
                dgvInmode.DataSource = DListarPersonalizado.ConsultarDT("SELECT * FROM Vista_Inmode WHERE CodInmode='" + CodInmode + "'");

                dgvInmode.Columns["CodInmode"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Inmode_Load(object sender, EventArgs e)
        {
            Llenar_Inmode();
            //CargarInmode();
        }
       
    }
}

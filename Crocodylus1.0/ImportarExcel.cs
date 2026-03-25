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
    public partial class ImportarExcel : Form
    {
        public bool Cancelado = true;

        public ImportarExcel()
        {
            InitializeComponent();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //     'Instanciamos nuestro cuadro de dialogo
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivos Excel (*.xlsx)|*.xlsx|(*.xls)|*.xls";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtDireccion.Text = archivo.FileName;    
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                MessageBox.Show("SELECCIONE LA DIRECCION DEL ARCHIVO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (string.IsNullOrWhiteSpace(txtHoja.Text))
                MessageBox.Show("INTRODUZCA EL NOMBRE DE LA HOJA DE LA QUE SE EXPORTARAN LOS DATOS", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Cancelado = false;
                this.Close();
            }
        }
    }
}

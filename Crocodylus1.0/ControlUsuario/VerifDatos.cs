using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Negocio;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class VerifDatos : UserControl
    {
        OpcionFormularios op = new OpcionFormularios();

        public VerifDatos()
        {
            InitializeComponent();
        }

        private void VerificarCajasCerradas()
        {
            try
            {
                op.AbrirCargando("Verificando Cajas.....");

                lblResp.Text = "CAJAS CERRADAS CORRECTAMENTE";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                op.CerrarCargando();
            }
        }

        private void VerifDatos_Load(object sender, EventArgs e)
        {
            VerificarCajasCerradas();
        }
    }
}

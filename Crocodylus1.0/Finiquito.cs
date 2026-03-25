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

namespace GRTechnology1._0
{
    public partial class Finiquito : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OPersonal> LPer = null;

        public Finiquito()
        {
            InitializeComponent();
        }

        #region Conexion Capa Negocio

        private void ListarPer()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("Personal", -1);

                cboPer.DataSource = LPer;
                cboPer.DisplayMember = "NomPer";
                cboPer.ValueMember = "PersonalID";
                cboPer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void Finiquito_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarPer();

            op.CerrarCargando();
        }
    }
}

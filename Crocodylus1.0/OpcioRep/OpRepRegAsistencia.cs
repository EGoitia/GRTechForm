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

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepRegAsistencia : Form
    {
        public OpRepRegAsistencia()
        {
            InitializeComponent();
        }

        #region Conexion Capa de Negocio

        private void ListarPer()
        {
            try
            {

                List<OPersonal> LPer = NPersonal.NListarPersonales("Personal", -1).OrderBy(x => x.NomPer).ToList();
                
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

        private void Procesar()
        {
            try
            {
                string delal= "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();
            
            int perid;
            if (ckbxTodoPer.Checked)
                perid = -1;
            else
                perid = Convert.ToInt32(cboPer.SelectedValue);

            switch(cboTipoRep.Text)
            {
                case "Marcaciones":
                    List<OMarcaciones> lmarc = NMarcaciones.NBuscarMarcaciones(perid, dtFecIni.Value, dtFecFin.Value).OrderBy(x=>x.NomPer).ToList();
                    Reportes.RepMarcaciones rmarc = new Reportes.RepMarcaciones(lmarc, delal);
                    rmarc.Show();
                    break;
                case "Tardanzas":
                    break;
                case "Faltas":
                    break;
                case "Horas Extraordinarias":
                    break;
                case "Faltas Justificadas/Vacaciones":
                    break;
                case "Asistencia":
                    break;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepRegAsistencia_Load(object sender, EventArgs e)
        {
            cboTipoRep.Text = "Asistencia";
            ListarPer();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpRepRegAsistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ckbxTodoPer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxTodoPer.Checked)
                cboPer.Enabled = false;
            else
                cboPer.Enabled = true;
        }

        #endregion
    }
}

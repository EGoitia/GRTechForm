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
    public partial class AperturaMes : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        private OAperturaCierreMes OAperCieMes = null;
        private int AperturaMesID = -1;
        private bool Estado = false;

        public AperturaMes()
        {
            InitializeComponent();
        }

        #region Config Formulario

        private void HabilitarCont()
        {            
            dtFecNota.Enabled = true;
            btnDetApertura.Enabled = true;
            btnDetCierre.Enabled = true;
            
            //Desabilitar
            txtObsApertura.ReadOnly = true;
            txtObsCierre.ReadOnly = true;
        }

        #endregion

        private void ProcAperturaMes()
        {
            try
            {
                OAperturaCierreMes apmes = new OAperturaCierreMes();
                apmes.AperturaMesID = -1;
                apmes.FechaAperturaMes = dtFecApertura.Value;
                apmes.FechaPlazoCierreMes = new DateTime(dtFecPlazoCierre.Value.Year, dtFecPlazoCierre.Value.Month, dtFecPlazoCierre.Value.Day,
                                                        dtHrPlazoCierre.Value.Hour, dtHrPlazoCierre.Value.Minute, dtHrPlazoCierre.Value.Second);
                apmes.ObsApertura = txtObsApertura.Text;

                OInmode inm = new OInmode();
                inm.CodInmode = string.Empty;
                inm.TipoInmode = "Apertura Mes";
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                int resp = NAperturaMes.DInsertAperturaMes(apmes, inm);
                if(resp > 0)
                {
                    MessageBox.Show("La apertura de mes se realizo correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DateTime FirstDayOfMonthFromDateTime(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public DateTime LastDayOfMonthFromDateTime(DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void AperturaMes_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void AperturaMes_Load(object sender, EventArgs e)
        {
            dtFecPlazoCierre.Value = LastDayOfMonthFromDateTime(DateTime.Now);
            dtHrPlazoCierre.Text = "23:59:00";
        }

        private void btnAperturaMes_Click(object sender, EventArgs e)
        {

        }

        private void btnCierreMes_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void dtFecNota_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDetApertura_Click(object sender, EventArgs e)
        {

        }

        private void btnDetCierre_Click(object sender, EventArgs e)
        {

        }

    }
}

using GRTechnology1._0.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_ConfigDisplay : Form
    {
        public Frm_ConfigDisplay()
        {
            InitializeComponent();
        }

        private void Frm_ConfigDisplay_Load(object sender, EventArgs e)
        {
            CargarPuertos();
            CargarConfig();
        }

        private void CargarPuertos()
        {
            foreach (var puerto in SerialPort.GetPortNames())
            {
                cmbPuertos.Items.Add(puerto);
            }

            if (cmbPuertos.Items.Count > 0)
                cmbPuertos.SelectedIndex = 0;
        }

        private void CargarConfig()
        {
            try
            {
                chkHabilitar.Checked = Properties.Settings.Default.Display_Habil;
                cmbPuertos.Text = Properties.Settings.Default.Display_COM;
                cmbBaudRate.Text = Properties.Settings.Default.Display_BaudRate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDisplay.Instance.Limpiar();
                CustomerDisplay.Instance.Mostrar(txtMonto.Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Display_COM = cmbPuertos.Text;
            Properties.Settings.Default.Display_BaudRate = cmbBaudRate.Text;
            Properties.Settings.Default.Display_Habil = chkHabilitar.Checked;
            Properties.Settings.Default.Save();
        }
    }
}

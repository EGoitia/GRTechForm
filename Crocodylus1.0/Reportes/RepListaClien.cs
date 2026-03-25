using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Microsoft.Reporting.WinForms;

namespace GRTechnology1._0.Reportes
{
    public partial class RepListaClien : Form
    {
        List<OCliente> LCli = null;
        string NomRep = string.Empty;

        public RepListaClien(List<OCliente> lcli, string nomrep)
        {
            InitializeComponent();

            LCli = lcli;
            NomRep = nomrep;
        }

        private void RepListaClien_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[2];
                //Establecemos el valor de los parámetros

                parameters[1] = new ReportParameter("NomRep", NomRep);
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                OClienteBindingSource.DataSource = LCli;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}

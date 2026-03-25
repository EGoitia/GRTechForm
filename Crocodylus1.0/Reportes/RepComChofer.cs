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
    public partial class RepComChofer : Form
    {
        List<OConformidad> LConf = null;

        string NomSuc = string.Empty;
        string NomRep = string.Empty;
        string NomChof = string.Empty;
        string Fechas = string.Empty;

        public RepComChofer(List<OConformidad> lconf, string nomsuc, string fechas, string nomrep, string nomchof)
        {
            InitializeComponent();

            LConf = lconf;

            NomSuc = nomsuc;
            NomRep = nomrep;
            NomChof = nomchof;
            Fechas = fechas;
        }

        private void RepComChofer_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[5];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("NomEmp", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("NomSuc", NomSuc);
                parameters[2] = new ReportParameter("ParamFechas", Fechas);
                parameters[3] = new ReportParameter("NomRep", NomRep);
                parameters[4] = new ReportParameter("NomChof", NomChof);

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Lista de conformidad
                OConformidadBindingSource.DataSource = LConf;
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

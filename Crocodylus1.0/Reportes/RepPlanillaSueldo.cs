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
    public partial class RepPlanillaSueldo : Form
    {
        string Mes = string.Empty;
        decimal LiqPag = 0;
        List<ODetallePlanillaSueldo> LDPla = null;

        public RepPlanillaSueldo(decimal liqpag, string mes, List<ODetallePlanillaSueldo> ldpla)
        {
            InitializeComponent();

            LiqPag = liqpag;
            Mes = mes;
            LDPla = ldpla;
        }

        private void RepPlanillaSueldo_Load(object sender, EventArgs e)
        {
            try
            {
                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[2];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("MesGestion", Mes);
                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 100;

                ODetallePlanillaSueldoBindingSource.DataSource = LDPla;
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

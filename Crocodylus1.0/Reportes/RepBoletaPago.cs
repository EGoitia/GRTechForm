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
    public partial class RepBoletaPago : Form
    {
        List<ODetallePlanillaSueldo> LDPla = null;
        string Fecha = string.Empty;

        public RepBoletaPago(List<ODetallePlanillaSueldo> ldpla, string fecha)
        {
            InitializeComponent();

            LDPla = ldpla;
            Fecha = fecha;
        }

        private void Cargar()
        {
            //try
            //{
            //    // crystalReportsViewer1.owner = this;
            //    Objetos.Reportes.Ejemplo mireporte = new Objetos.Reportes.Ejemplo();
            //    //CrystalReport1 mireporte = new CrystalReport1();
            //    crystalReportViewer1.ReportSource = mireporte;
            //    mireporte.SetDataSource(LDPla);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void RepBoletaPago_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[1];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Fecha", Fecha);
                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

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

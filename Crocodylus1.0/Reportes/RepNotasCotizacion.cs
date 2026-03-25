using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;

using Objetos;

namespace GRTechnology1._0.Reportes
{
    public partial class RepNotasCotizacion : Form
    {
        OCotizacion Cot = null;
        List<ODetalleCotizacion> LDCot = null;

        public RepNotasCotizacion(OCotizacion cot, List<ODetalleCotizacion> ldcot)
        {
            InitializeComponent();

            Cot = cot;
            LDCot = ldcot;
        }

        private void Cargar()
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[4];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Sucursal", OConexionGlobal.NomSuc);
                parameters[2] = new ReportParameter("Direccion", OConexionGlobal.Direccion);
                parameters[3] = new ReportParameter("Telf", OConexionGlobal.Telf);
                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Cargamos los Datos
                OCotizacionBindingSource.DataSource = Cot;
                ListaDetalleCotizacionBindingSource.DataSource = LDCot;
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

        private void RepNotasCotizacion_Load(object sender, EventArgs e)
        {
            Cargar();
            this.reportViewer1.RefreshReport();
        }
    }
}

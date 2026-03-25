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
    public partial class RepNotasTraspaso : Form
    {
        OTraspaso Trasp = null;
        List<ODetalleTraspaso> LDTrasp = null;

        public RepNotasTraspaso(OTraspaso trasp, List<ODetalleTraspaso> ldtras)
        {
            InitializeComponent();

            Trasp = trasp;
            LDTrasp = ldtras;
        }

        private void RepNotasTraspaso_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
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
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Almacen", OConexionGlobal.NomSuc);

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Cargamos datos Traspaso
                OTraspasoBindingSource.DataSource = Trasp;
                ListaDetalleTraspasoBindingSource.DataSource = LDTrasp;
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

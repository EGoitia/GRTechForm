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
    public partial class RepNotasProyeccion : Form
    {
        OProyecciones Proy = null;
        List<ODetalleProyecciones> LDProy = null;

        public RepNotasProyeccion(OProyecciones proy, List<ODetalleProyecciones> ldproy)
        {
            InitializeComponent();

            Proy = proy;
            LDProy = ldproy;
        }

        private void RepNotasProyeccion_Load(object sender, EventArgs e)
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
                ReportParameter[] parameters = new ReportParameter[1];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Cargamos datos Traspaso
                OProyeccionesBindingSource.DataSource = Proy;
                ListaDetalleProyeccionesBindingSource.DataSource = LDProy;
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

using System;
using System.Windows.Forms;

using Objetos;
using Negocio;
using Microsoft.Reporting.WinForms;

namespace GRTechnology1._0.Reportes
{
    public partial class RepLibroMayor : Form
    {
        public RepLibroMayor()
        {
            InitializeComponent();
        }

        private void ListarLibroMayor()
        {
            try
            {
                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[2];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("NomEmp", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Fechas", "Del: " + dtFecIni.Value.ToShortDateString() + " Al: " + dtFecFin.Value.ToShortDateString());

                if(cboTipoRep.Text == "Resumido")
                {
                    reportViewerLibroDiarioDet.Visible = false;
                    reportViewerLibMayor.Visible = true;

                    reportViewerLibMayor.SetDisplayMode(DisplayMode.PrintLayout);
                    reportViewerLibMayor.ZoomMode = ZoomMode.Percent;
                    //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                    reportViewerLibMayor.ZoomPercent = 130;

                    //Pasamos el array de los parámetros al ReportViewer
                    this.reportViewerLibMayor.LocalReport.SetParameters(parameters);    
                }
                else
                {
                    reportViewerLibMayor.Visible = false;
                    reportViewerLibroDiarioDet.Visible = true;

                    reportViewerLibroDiarioDet.SetDisplayMode(DisplayMode.PrintLayout);
                    reportViewerLibroDiarioDet.ZoomMode = ZoomMode.Percent;
                    //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                    reportViewerLibroDiarioDet.ZoomPercent = 130;

                    //Pasamos el array de los parámetros al ReportViewer
                    this.reportViewerLibroDiarioDet.LocalReport.SetParameters(parameters);
                }

                OLibroMayorBindingSource.DataSource = NLibroMayor.DListarLibroMayor(dtFecIni.Value, dtFecFin.Value, cboTipoLibro.Text, cboTipoRep.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cboTipoRep.Text == "Resumido")
                    this.reportViewerLibMayor.RefreshReport();
                else
                    this.reportViewerLibroDiarioDet.RefreshReport();
            }
        }

        private void RepLibroMayorDetallado_Load(object sender, EventArgs e)
        {
            cboTipoLibro.Text = "EGRESO";
            cboTipoRep.Text = "Resumido";
            ListarLibroMayor();
            this.reportViewerLibroDiarioDet.RefreshReport();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            ListarLibroMayor();
        }
    }
}

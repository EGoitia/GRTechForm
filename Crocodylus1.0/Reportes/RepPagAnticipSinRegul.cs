using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Objetos;
using Microsoft.Reporting.WinForms;

namespace GRTechnology1._0.Reportes
{
    public partial class RepPagAnticipSinRegul : Form
    {
        List<OVenta> LVen = null;

        public RepPagAnticipSinRegul(List<OVenta> lven)
        {
            InitializeComponent();

            LVen = lven;
        }

        private void RepPagAnticipSinRegul_Load(object sender, EventArgs e)
        {
            try
            {

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                ReportParameter[] parameters = new ReportParameter[3];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Sucursal", OConexionGlobal.NomSuc);
                parameters[2] = new ReportParameter("Fecha", "Fecha Corte: " + DateTime.Now.ToShortDateString());

                this.reportViewer1.LocalReport.SetParameters(parameters);

                OVentaBindingSource.DataSource = LVen;
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

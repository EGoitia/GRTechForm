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
    public partial class RepNotasReciboIngEgr : Form
    {
        OIngresoEgreso RIngEgr = null;

        public RepNotasReciboIngEgr(OIngresoEgreso ringegr)
        {
            InitializeComponent();

            RIngEgr = ringegr;
        }

        private void RepNotasReciboIngEgr_Load(object sender, EventArgs e)
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
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Sucursal", OConexionGlobal.NomSuc);
                parameters[2] = new ReportParameter("Direccion", OConexionGlobal.Direccion);
                parameters[3] = new ReportParameter("Telefono", OConexionGlobal.Telf);
                //parameters[4] = new ReportParameter("NomRep", "RECIBO DE CAJA " + RIngEgr.TipoRecibo.ToUpper());

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                OReciboIngEgrBindingSource.DataSource = RIngEgr;
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

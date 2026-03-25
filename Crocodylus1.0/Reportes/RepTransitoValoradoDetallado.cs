using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Negocio;
using Microsoft.Reporting.WinForms;

namespace GRTechnology1._0.Reportes
{
    public partial class RepTransitoValoradoDetallado : Form
    {
        string Opcion = string.Empty;
        int DescOpcion = -1;
        string NomDescOpcion = string.Empty;
        string Lugar = string.Empty;
        int DescLugar = -1;
        string NomDescLugar = string.Empty;
        DateTime FecIni = DateTime.Now;
        DateTime FecFin = DateTime.Now;

        public RepTransitoValoradoDetallado(string opcion, int descopcion, string nomdescopcion, string lugar, int desclugar,
                                               string nomdesclugar, DateTime fecini, DateTime fecfin)
        {
            InitializeComponent();

            Opcion = opcion;
            DescOpcion = descopcion;
            NomDescOpcion = nomdescopcion;
            Lugar = lugar;
            DescLugar = desclugar;
            NomDescLugar = nomdesclugar;
            FecIni = fecini;
            FecFin = fecfin;
        }

        private void RepTransitoValoradoDetallado_Load(object sender, EventArgs e)
        {
            try
            {
                string Suc = string.Empty;
                string NomRep = "MATERIAL EN TRANSITO DETALLADO";
                string FecCorte = "Del " + FecIni.ToShortDateString() + " Al " + FecFin.ToShortDateString();

                if (Lugar != "Empresa")
                    Suc = NomDescLugar;

                if (Opcion == "TOTALES")
                    NomDescOpcion = string.Empty;
                else
                    NomDescOpcion = "PROVEEDOR: " + NomDescOpcion;

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[5];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Sucursal", Suc);
                parameters[2] = new ReportParameter("NomRep", NomRep);
                parameters[3] = new ReportParameter("Fecha", FecCorte);
                parameters[4] = new ReportParameter("Proveedor", NomDescOpcion);

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Buscamos en la Base de Datos                
                OTransitoDetalladoBindingSource.DataSource = NTransitoDetallado.NBuscarTransitoDetallado(Opcion, DescOpcion, Lugar, DescLugar, FecIni, FecFin);
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

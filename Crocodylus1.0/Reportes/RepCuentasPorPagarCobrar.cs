using Microsoft.Reporting.WinForms;
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

namespace GRTechnology1._0.Reportes
{
    public partial class RepCuentasPorPagarCobrar : Form
    {
        string Lugar = string.Empty;
        string NomDescLugar = string.Empty;
        string Opcion = string.Empty;

        int DescOpcion = -1;
        int DescLugar = -1;
        DateTime Fecha = DateTime.Now;

        public RepCuentasPorPagarCobrar(string opcion, string lugar, int desclugar, string nomdesclugar, DateTime fecha)
        {
            InitializeComponent();

            Opcion = opcion;
            Lugar = lugar;
            NomDescLugar = nomdesclugar;
            DescLugar = desclugar;
            Fecha = fecha;
        }

        private void RepCuentasPorPagar_Load(object sender, EventArgs e)
        {
            try
            {
                //Nombre del Reporte
                string nomrep = string.Empty;
                if(Opcion == "Proveedor")
                    nomrep = "CUENTAS POR PAGAR ";
                else
                    nomrep = "CUENTAS POR COBRAR ";
                
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("NomRep", nomrep);
                parameters[1] = new ReportParameter("Fecha", "Fecha Corte: " + Fecha.ToShortDateString());

                if (Lugar == "Sucursal")
                    parameters[2] = new ReportParameter("NomEmpSuc", NomDescLugar);
                else
                    parameters[2] = new ReportParameter("NomEmpSuc", OConexionGlobal.NomEmp);
                parameters[3] = new ReportParameter("Opcion", Opcion);

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                TimeSpan ts = DateTime.Now - Fecha;
                int difdias = ts.Days;
                string tipo = string.Empty;
                if (difdias == 0)
                    tipo = "Fecha";

                OCuentasXCobrarPagarBindingSource.DataSource = NCuentaXCobrarPagar.NBuscarCuentaXCobPag(Opcion, Lugar, DescLugar, Fecha);
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

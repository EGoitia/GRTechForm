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
    public partial class RepGastosIngresos : Form
    {
        string BusqX = string.Empty;
        string NomOpcion = string.Empty;
        string BusqEn = string.Empty;
        string NomOpcionBusq = string.Empty;

        DateTime FIni = DateTime.Now;
        DateTime FFin = DateTime.Now;

        int Opcion = -1;
        int OpcionBusq = -1;

        public RepGastosIngresos(string busqX, int opcion, string nomOpcion, string busqEn, int opcionBusq,
                                 string nomOpcionBusq, DateTime fini, DateTime ffin)
        {
            InitializeComponent();

            BusqX = busqX;
            NomOpcion = nomOpcion;
            BusqEn = busqEn;
            NomOpcionBusq = nomOpcionBusq;
            FIni = fini;
            FFin = ffin;

            Opcion = opcion;
            OpcionBusq = opcionBusq;
        }

        private void RepGastosIngresos_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                string cajasuc = string.Empty;
                if(BusqEn != "EMPRESA")
                    cajasuc = BusqEn + ": " + NomOpcionBusq;

                string nomrep = "REPORTE DE ";
                if (BusqX == "TOTALES")
                    nomrep += "EGRESOS / INGRESOS DE CAJA";
                else
                    nomrep += BusqX + " DE CAJA";

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[4];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Caja", cajasuc);
                parameters[2] = new ReportParameter("NomReporte", nomrep);
                parameters[3] = new ReportParameter("Fechas", "Del " + FIni.ToShortDateString() + " Al " + FFin.ToShortDateString());

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Verificamos en la DB
                //OReciboIngEgrBindingSource.DataSource = NReciboIngEgr.NBuscarRepReciboIngEgr(BusqX, Opcion, BusqEn, OpcionBusq, FIni, FFin); 
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

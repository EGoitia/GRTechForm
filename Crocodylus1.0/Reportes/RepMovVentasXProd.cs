using Microsoft.Reporting.WinForms;
using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0.Reportes
{
    public partial class RepMovVentasXProd : Form
    {
        string Opcion = string.Empty;
        int DescOpcion = -1;
        string NomDescOpcion = string.Empty;
        string Lugar = string.Empty;
        int DescLugar = -1;
        string NomDescLugar = string.Empty;
        DateTime FecIni = DateTime.Now;
        DateTime FecFin = DateTime.Now;
        string Ordenado = string.Empty;

        public RepMovVentasXProd(string opcion, int descopcion, string nomdescopcion, string lugar, int desclugar,
                                 string nomdesclugar, DateTime fecini, DateTime fecfin, string ordenado)
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
            Ordenado = ordenado;
        }

        private void RepMovVentasXProd_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //empresaa sucursal o caja
                string EmpSucCaj=string.Empty;
                if (Lugar == "Empresa")
                    EmpSucCaj = OConexionGlobal.NomEmp;
                else if (Lugar == "Sucursal")
                {
                    //if (NomDescLugar == "DOBLE VIA")
                    //{
                    //    EmpSucCaj = "DECORALIA";
                    //}
                    //else
                        EmpSucCaj = NomDescLugar;
                }
                    

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[3];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("NomRep", "MOVIMIENTO DE VENTAS POR PRODUCTO");
                parameters[1] = new ReportParameter("Fechas", "Del " + FecIni.ToShortDateString() + " Al " + FecFin.ToShortDateString());
                parameters[2] = new ReportParameter("EmpSucCaj", EmpSucCaj);

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Cargamos los datos de la db
                //OKardexProdBindingSource.DataSource = NKardexProd.NBuscarMovVentaProd(Opcion, DescOpcion, Lugar, DescLugar, FecIni, FecFin, Ordenado);
                OMovVentasXProdBindingSource.DataSource = NMovVentasXProd.DListarMovVenXProd(Opcion, DescOpcion, Lugar, DescLugar, FecIni, FecFin, Ordenado);
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

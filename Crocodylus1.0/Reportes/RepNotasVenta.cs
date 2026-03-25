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
    public partial class RepNotasVenta : Form
    {
        DataTable Ven = null;
        DataTable LDVen = null;
        public RepNotasVenta(DataTable ven, DataTable ldven)
        {
            InitializeComponent();

            Ven = ven;
            LDVen = ldven;
        }

        private void Cargar()
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                string nomrep=string.Empty;
                if((Ven.Rows[0]["TipoVenta"].ToString() == "CONTADO") || (Ven.Rows[0]["TipoVenta"].ToString() == "CREDITO"))
                    nomrep="NOTA DE VENTA";
                else if (Ven.Rows[0]["TipoVenta"].ToString() == "ANTICIPADO")
                    nomrep = "PAGO ANTICIPADO";
                //else if ((Ven.TipoVenta == "Devol. Contado") || (Ven.TipoVenta == "Devol. Credito"))
                //    nomrep = "DEVOLUCION DE MERCADERIA";

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[5];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Sucursal", OConexionGlobal.NomSuc);
                parameters[2] = new ReportParameter("Direccion", OConexionGlobal.Direccion);
                parameters[3] = new ReportParameter("Telf", OConexionGlobal.Telf);
                parameters[4] = new ReportParameter("NomReporte", nomrep);
                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Cargamos los Datos
                OVentaBindingSource.DataSource = Ven;
                ODetalleVentaBindingSource.DataSource = LDVen;
                ListaDetalleVentaBindingSource.DataSource = LDVen;
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

        private void RepNotasVenta_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}

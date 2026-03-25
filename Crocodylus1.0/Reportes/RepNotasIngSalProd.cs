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
    public partial class RepNotasIngSalProd : Form
    {
        OIngSalProducto IngSalProd = null;
        List<ODetalleIngSalProducto> LDetIngSalProd = null;
        bool Admin = false;

        public RepNotasIngSalProd(OIngSalProducto ingsalprod, List<ODetalleIngSalProducto> ldetingsal, bool admin)
        {
            InitializeComponent();

            IngSalProd = ingsalprod;
            LDetIngSalProd = ldetingsal;
            Admin = admin;
        }

        private void RepNotasIngSalProd_Load(object sender, EventArgs e)
        {
            try
            {
                //this.Text = IngSalProd.TipoIngSalProducto + " de Mercaderia";

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[4];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Almacen", OConexionGlobal.NomSuc);
                parameters[2] = new ReportParameter("NomRep", "NOTAS DE "); //IngSalProd.TipoIngSalProducto.ToUpper());
                parameters[3] = new ReportParameter("Admin", Admin.ToString());
                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                OIngSalProductoBindingSource.DataSource = IngSalProd;
                ODetalleIngSalProductoBindingSource.DataSource = LDetIngSalProd;
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

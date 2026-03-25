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
    public partial class RepListaProd : Form
    {
        List<OProducto> LProd = null;
        
        string NomRep = string.Empty;
        string Opcion = string.Empty;
        int IDOpcion = -1;
        bool ImgQR = false;
        bool Img = false;

        public RepListaProd(string nomrep, int idopcion, bool imgqr, bool img)
        {
            InitializeComponent();

            NomRep = nomrep;
            IDOpcion = idopcion;
            ImgQR = imgqr;
            Img = img;
        }

        private void RepListaProd_Load(object sender, EventArgs e)
        {
            try
            {
                if(NomRep == "CATALOGO DE ITEMS")
                    Opcion="Totales";
                else if (NomRep == "CATALOGO DE ITEMS HABILITADOS")
                    Opcion = "Totales Habil";
                else if (NomRep == "CATALOGO DE ITEMS DESABILITADOS")
                    Opcion = "Totales Desabil";
                else if (NomRep == "CATALOGO DE ITEMS FUERA DE LINEA")
                    Opcion = "Totales FueraLinea";
                else if (NomRep == "CATALOGO DE ITEMS POR RUBRO")
                    Opcion = "Rubro";
                else if (NomRep == "CATALOGO DE ITEMS HABILITADO POR RUBRO")
                    Opcion = "Rubro Habil";
                else if (NomRep == "CATALOGO DE ITEMS DESABILITADOS POR RUBRO")
                    Opcion = "Rubro Desabil";
                else if (NomRep == "CATALOGO DE ITEMS FUERA DE LINEA POR RUBRO")
                    Opcion = "Rubro FueraLinea";
                else if (NomRep == "CATALOGO DE ITEMS POR SUB-RUBRO")
                    Opcion = "Subrubro";
                else if (NomRep == "CATALOGO DE ITEMS HABILITADO POR SUB-RUBRO")
                    Opcion = "Subrubro Habil";
                else if (NomRep == "CATALOGO DE ITEMS DESABILITADOS POR SUB-RUBRO")
                    Opcion = "Subrubro Desabil";
                else if (NomRep == "CATALOGO DE ITEMS FUERA DE LINEA POR SUB-RUBRO")
                    Opcion = "Subrubro FueraLinea";

                LProd = null;//NProducto.NListarProductos(Opcion, IDOpcion);  

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[4];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("NomRep", NomRep);
                parameters[1] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[2] = new ReportParameter("ImgQR", ImgQR.ToString());
                parameters[3] = new ReportParameter("Img", Img.ToString());
                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                OProductoBindingSource.DataSource = LProd;
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

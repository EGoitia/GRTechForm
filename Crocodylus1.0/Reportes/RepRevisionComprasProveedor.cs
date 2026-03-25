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
    public partial class RepRevisionComprasProveedor : Form
    {
        List<OCompraProd> LCom = null;

        string Suc = string.Empty;
        string Prov = string.Empty;
        string NomRep = string.Empty;
        string FecCorte = string.Empty;

        public RepRevisionComprasProveedor(List<OCompraProd> lcom, string suc, string nomrep, string feccorte, string prov)
        {
            InitializeComponent();

            LCom = lcom;

            Suc = suc;
            Prov = prov;
            NomRep = nomrep;
            FecCorte = feccorte;
        }

        private void RepRevisionComprasProveedor_Load(object sender, EventArgs e)
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
                parameters[1] = new ReportParameter("Sucursal", Suc);
                parameters[2] = new ReportParameter("NomRep", NomRep);
                parameters[3] = new ReportParameter("FechaCorte", FecCorte);
                parameters[4] = new ReportParameter("Proveedor", Prov);

                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);

                OCompraProdBindingSource.DataSource = LCom;
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

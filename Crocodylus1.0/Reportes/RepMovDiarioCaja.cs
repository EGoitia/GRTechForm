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
    public partial class RepMovDiarioCaja : Form
    {
        string MovPor = string.Empty;
        string Opc = string.Empty;
        int IDOpc = -1;
        DateTime FecDel = DateTime.Now;
        DateTime FecAl = DateTime.Now;

        public RepMovDiarioCaja(string movpor, string opc, int idopc, DateTime fecdel, DateTime fecal)
        {
            InitializeComponent();

            MovPor = movpor;
            Opc = opc;
            IDOpc = idopc;
            FecDel = fecdel;
            FecAl = fecal;
        }

        private void RepMovDiarioCaja_Load(object sender, EventArgs e)
        {
            try
            {
                //Enviamos Nombre de Empresa y Sucursal por Parametros
                ReportParameter[] parameters = new ReportParameter[5];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("Empresa", OConexionGlobal.NomEmp);
                parameters[1] = new ReportParameter("Sucursal", "");
                parameters[2] = new ReportParameter("Caja", Opc);
                parameters[3] = new ReportParameter("NomRep", "ARQUEO DE CAJA " + MovPor.ToUpper() + (MovPor == "Empresa" ? "" : " " + Opc.ToUpper()));
                parameters[4] = new ReportParameter("Fecha", "Del " + FecDel.ToShortDateString() +
                                                             " Al " + FecAl.ToShortDateString());
                //Pasamos el array de los parámetros al ReportViewer
                this.reportViewer1.LocalReport.SetParameters(parameters);


                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 100;

                List<OVentasPorFecha> LVenXFecha = NVenta.NBuscarVentasXFecha(IDOpc, FecDel, FecAl);

                try
                {
                    OVentasPorFechaBindingSource.DataSource = LVenXFecha.FindAll(x => x.TipoVenta == "CONTADO" || x.TipoVenta == "ANTICIPADO");
                }
                catch (Exception)
                {   }

                //try
                //{
                //    oVentasPorFechaBindingSource1.DataSource = LVenXFecha.FindAll(x => x.TipoVenta == "Anticipado");
                //}
                //catch (Exception)
                //{   }
                
                //OAbonoPorFechaBindingSource.DataSource = NAbono.NBuscarAbonoXFecha(IDOpc, FecDel, FecAl, "Cliente");
                //OReciboIngEgrBindingSource.DataSource = NReciboIngEgr.NBuscarReciboIngEgrXFecha(IDOpc, FecDel, FecAl);
                //OGastoPersonalBindingSource.DataSource = NGastoPersonal.NListarGastoPerXFecha(IDOpc, FecDel, FecAl);
                OCompraPorFechaBindingSource.DataSource = NCompraProd.NBuscarCompraProdXFecha(IDOpc, FecDel, FecAl);
                //OAperturaCajaBindingSource.DataSource = NAperturaCaja.NBuscarAperCajaXFecha(IDOpc, FecDel, FecAl);
                //ODepositoBancoBindingSource.DataSource = NDepositoBanco.NBuscarDepBancoxFecha(IDOpc, FecDel, FecAl);
                //oTraspasoCajaBindingSource.DataSource = NTraspasoCaja.NBuscarTraspCajaXFechas(IDOpc, FecDel, FecAl);
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

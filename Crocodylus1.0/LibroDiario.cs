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
using System.Xml;

namespace GRTechnology1._0
{
    public partial class LibroDiario : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        public LibroDiario()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnas()
        {
            dgvAsientos.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Fecha";
            c1.Width = 90;
            dgvAsientos.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Detalle";
            c2.Width = 200;
            dgvAsientos.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Debe";
            c3.Width = 60;
            dgvAsientos.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Haber";
            c4.Width = 60;
            dgvAsientos.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Concepto";
            c5.Width = 150;
            dgvAsientos.Columns.Add(c5);
        }

        #endregion

        #region Conexion Capa de Negocio

        private void ListarLibroDiario()
        {
            try
            {
                XmlDocument[] datosxml = new XmlDocument[1];
                datosxml = NLibroDiario.NListarLibroDiario(dtFecha.Value);

                XmlDocument dat = datosxml[0];
                CargarLibroDiario(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnas();
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarLibroDiario(XmlDocument dat)
        {
            NombreColumnas();

            XmlNodeList elemList = dat.GetElementsByTagName("DLibro");
            XmlNodeList nNodo;

            string codasiento = string.Empty;
            foreach (XmlElement nodo in elemList)
            {
                nNodo = nodo.GetElementsByTagName("CodAsiento");
                string codasi = nNodo[0].InnerText;
                nNodo = nodo.GetElementsByTagName("Fecha");
                DateTime fec = Convert.ToDateTime(nNodo[0].InnerText);
                nNodo = nodo.GetElementsByTagName("TC");
                decimal tc = Convert.ToDecimal(nNodo[0].InnerText);
                nNodo = nodo.GetElementsByTagName("Glosa");
                string det = nNodo[0].InnerText;
                nNodo = nodo.GetElementsByTagName("NomCuenta");
                string nomcu = nNodo[0].InnerText;
                nNodo = nodo.GetElementsByTagName("Debe");
                decimal debe = Convert.ToDecimal(nNodo[0].InnerText);
                nNodo = nodo.GetElementsByTagName("Haber");
                decimal haber = Convert.ToDecimal(nNodo[0].InnerText);
                nNodo = nodo.GetElementsByTagName("Concepto");
                string concep = nNodo[0].InnerText;

                if(codasi != codasiento)
                {
                    dgvAsientos.Rows.Add(fec.ToShortDateString(), "------" + codasi + "-----", "", "", "");
                    dgvAsientos.Rows.Add("", nomcu, string.Format("{0:#,##0.00}", debe),
                                                             string.Format("{0:#,##0.00}", haber), concep);
                    codasiento = codasi;
                }
                else
                {
                    dgvAsientos.Rows.Add("", nomcu, string.Format("{0:#,##0.00}", debe), string.Format("{0:#,##0.00}", haber), concep);
                } 
            }
        }
        
        #endregion

        #region Eventos Formulario

        private void LibroDiario_Load(object sender, EventArgs e)
        {
            ListarLibroDiario();
        }

        private void LibroDiario_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            ListarLibroDiario();
        }

        #endregion
    }
}

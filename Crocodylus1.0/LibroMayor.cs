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
    public partial class LibroMayor : Form, IAgregaCuentaCont
    {
        OpcionFormularios op = new OpcionFormularios();

        #region IAgregaCuentaCont

        public void AgregaCuentaCont(string cod, string nomcuenta)
        {
            cboCuenta.Items.Add(nomcuenta);
            cboCuenta.ValueMember = cod;
            cboCuenta.Text = nomcuenta;
        }

        #endregion

        public LibroMayor()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnas()
        {
            dgvMayor.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "Fecha";
            c0.Width = 90;
            dgvMayor.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Concepto";
            c1.Width = 200;
            dgvMayor.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Nº";
            c2.Width = 100;
            dgvMayor.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Debe";
            c3.Width = 60;
            dgvMayor.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Haber";
            c4.Width = 60;
            dgvMayor.Columns.Add(c4);
        }

        #endregion

        #region Conexion Capa de Negocios

        private void Procesar()
        {
            try
            {
                XmlDocument[] datosxml = new XmlDocument[1];
                if(ckbxTodo.Checked)
                {
                    datosxml = NLibroDiario.NListarLibroMayor(string.Empty, dtFecIni.Value, dtFecFin.Value);
                }
                else
                {
                    if(cboCuenta.Text != string.Empty)
                        datosxml = NLibroDiario.NListarLibroMayor(cboCuenta.ValueMember, dtFecIni.Value, dtFecFin.Value);
                }
                
                XmlDocument dat = datosxml[0];
                CargarLibroMayor(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnas();
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarLibroMayor(XmlDocument dat)
        {
            NombreColumnas();

            XmlNodeList elemList = dat.GetElementsByTagName("DLibro");
            XmlNodeList nNodo;

            string codcuenta = string.Empty;
            foreach (XmlElement nodo in elemList)
            {
                nNodo = nodo.GetElementsByTagName("CodAsiento");
                string codasi = nNodo[0].InnerText;
                nNodo = nodo.GetElementsByTagName("CodCuenta");
                string codcu = nNodo[0].InnerText;
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

                if (codcu != codcuenta)
                {
                    dgvMayor.Rows.Add("", "------" + nomcu + "-----", "", "", "");
                    dgvMayor.Rows.Add(fec.ToShortDateString(), concep, codasi, string.Format("{0:#,##0.00}", debe),
                                      string.Format("{0:#,##0.00}", haber));
                    codcuenta = codcu;
                }
                else
                {
                    dgvMayor.Rows.Add(fec.ToShortDateString(), concep, codasi, string.Format("{0:#,##0.00}", debe),
                                      string.Format("{0:#,##0.00}", haber));
                } 

            }
        }

        #endregion

        #region Eventos Formulario

        private void btnBusqCuenta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LibroMayor_Load(object sender, EventArgs e)
        {
            NombreColumnas();
        }

        private void LibroMayor_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ckbxTodo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbxTodo.Checked)
            {
                cboCuenta.Enabled = false;
                btnBusqCuenta.Enabled = false;
            }
            else
            {
                cboCuenta.Enabled = true;
                btnBusqCuenta.Enabled = true;
            }
        }

        #endregion
    }
}

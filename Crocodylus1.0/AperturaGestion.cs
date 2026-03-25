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
    public partial class AperturaGestion : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", 
                           "Octubre", "Noviembre", "Diciembre" };

        public AperturaGestion()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvBalIni.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Visible = false;
            dgvBalIni.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Descripcion";
            c2.Width = 200;
            c2.ReadOnly = true;
            dgvBalIni.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Monto Bs";
            c3.Width = 100;
            dgvBalIni.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Monto Total";
            c4.Width = 100;
            c4.ReadOnly = true;
            dgvBalIni.Columns.Add(c4);
        }

        #region Conexion Capa de Negocio

        private void ListarCuentas()
        {
            try
            {
                op.AbrirCargando("Cargando.....");

                XmlDocument[] datosxml = new XmlDocument[1];
                datosxml = NBalanceGeneral.NCargarCuentBalanceInicial();

                XmlDocument dat = datosxml[0];
                CargarCuentas(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnas();
            }
            finally
            {
                op.CerrarCargando();
            }
        }

        private void InsertBalanceInicial()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarCuentas(XmlDocument dat)
        {
            NombreColumnas();

            XmlNodeList elemList = dat.GetElementsByTagName("Cuentas");
            XmlNodeList nNodo;

            string codasiento = string.Empty;
            foreach (XmlElement nodo in elemList)
            {
                nNodo = nodo.GetElementsByTagName("Codigo");
                string cod = nNodo[0].InnerText;
                nNodo = nodo.GetElementsByTagName("Descripcion");
                string desc = nNodo[0].InnerText;
                nNodo = nodo.GetElementsByTagName("Monto Bs");
                decimal montobs = Convert.ToDecimal(nNodo[0].InnerText);
                nNodo = nodo.GetElementsByTagName("Monto Total");
                decimal montotot = Convert.ToDecimal(nNodo[0].InnerText);

                dgvBalIni.Rows.Add(cod, desc, string.Format("{0:#,##0.00}", montobs), string.Format("{0:#,##0.00}", montotot));
            }
        }

        #endregion

        private void AperturaGestion_Load(object sender, EventArgs e)
        {
            lblDatosEmp.Text = OConexionGlobal.NomEmp + "\n" + OConexionGlobal.Direccion + "\n" + OConexionGlobal.Ciudad + " - Bolivia";
            lblNomRep.Text = "BALANCE INICIAL AL " + DateTime.Now.Day + " DE " + meses[DateTime.Now.Month - 1].ToUpper() +
                             " DE " + DateTime.Now.Year;

            ListarCuentas();
        }
    }
}

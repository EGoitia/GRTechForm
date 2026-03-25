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

namespace GRTechnology1._0
{
    public partial class CuentaContable : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        string Opcion = string.Empty;

        List<OCuentaCont> LCCont = null;

        public CuentaContable()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnas()
        {
            dgvCuentCont.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 100;
            dgvCuentCont.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Cuenta Contable";
            c2.Width = 200;
            dgvCuentCont.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 150;
            c3.Name = "Tipo Cuenta";
            dgvCuentCont.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Detalle";
            c4.Width = 200;
            dgvCuentCont.Columns.Add(c4);
        }


        #endregion

        #region Conexion Capa Negocios

        public void ListarCuentasCont()
        {
            try
            {
                LCCont = NCuentaCont.NListarCuentasCont();
                
                SeleccionarPestaña();
            }
            catch (Exception ex)
            {
                //NombreColumnas();
                MessageBox.Show(ex.Message);
                tvCuentas.Nodes.Clear();
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarCuentasCont(List<OCuentaCont> lccont)
        {
            try
            {
                NombreColumnas();

                int cont = 0;
                foreach (var item in lccont)
                {
                    dgvCuentCont.Rows.Add(item.CodCuenta, item.NomCuenta, item.TipoCuenta, item.Detalle);

                    if(item.TipoCuenta == "Analitica")
                        dgvCuentCont.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
                    if (!item.Estado)
                        dgvCuentCont.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    cont++;
                }
                dgvCuentCont.Refresh();
            }
            catch(Exception)
            {
                NombreColumnas();
            }
        }

        private void BuscarCuentasCont()
        {
            if (LCCont != null)
            {
                if (txtBuscar.Text != string.Empty)
                {
                    List<OCuentaCont> lbusqcod = LCCont.FindAll(x => x.CodCuenta.Contains(txtBuscar.Text));
                    List<OCuentaCont> lbusqnom = LCCont.FindAll(x => x.NomCuenta.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                    //concatenamos las dos
                    List<OCuentaCont> lbusqresult = lbusqcod.Concat(lbusqnom).ToList();
                    CargarCuentasCont(lbusqresult);
                }
                else
                {
                    CargarCuentasCont(LCCont);
                }
            }
        }

        private void SeleccionarPestaña()
        {
            switch (tabControlCCont.SelectedIndex)
            {
                case 0:
                    CrearNodosDelPadre("0", null);
                    break;
                case 1:
                    CargarCuentasCont(LCCont);
                    break;
            }
        }

        #endregion

        #region Funciones

        private List<OCuentaCont> hijos(string indice)
        {
            List<OCuentaCont> desc = new List<OCuentaCont>();

            foreach (var cuenta in LCCont)
            {
                if (cuenta.PadreCuenta == indice)
                    desc.Add(cuenta);
            }
            return desc;
        }

        private void CrearNodosDelPadre(string indicePadre, TreeNode nodePadre)
        {
            List<OCuentaCont> listaHijos = hijos(indicePadre);

            // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
            try
            {
                foreach (OCuentaCont cuenta in listaHijos)
                {
                    TreeNode nuevoNodo = new TreeNode();
                    nuevoNodo.Text = cuenta.CodCuenta + " " + cuenta.NomCuenta;

                    if (cuenta.TipoCuenta == "Analitica")
                    {
                        nuevoNodo.ForeColor = Color.Green;
                    }

                    // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                    // del primer nivel que no dependen de otro nodo.
                    if (nodePadre == null)
                    {
                        tvCuentas.Nodes.Add(nuevoNodo);
                    }
                    // se añade el nuevo nodo al nodo padre.
                    else
                    {
                        nodePadre.Nodes.Add(nuevoNodo);
                    }

                    // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
                    CrearNodosDelPadre(cuenta.CodCuenta, nuevoNodo);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Eventos Formulario

        private void CuentaContable_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            ListarCuentasCont();

            op.CerrarCargando();
        }

        private void CuentaContable_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarCuentasCont();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            string cod = dgvCuentCont["Codigo", dgvCuentCont.CurrentRow.Index].Value.ToString();

            OCuentaCont ccont = LCCont.Find(x => x.CodCuenta == cod);
            if(ccont != null)
            {
                InserModifCuentaContable insertmodifccon = new InserModifCuentaContable("Modificar", ccont);
                insertmodifccon.Owner = this;
                insertmodifccon.ShowDialog();
            }
            ListarCuentasCont();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InserModifCuentaContable insertmodifccon = new InserModifCuentaContable("Nuevo", null);
            insertmodifccon.Owner = this;
            insertmodifccon.ShowDialog();

            ListarCuentasCont();
        }

        private void ckDesplegar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDesplegar.Checked)
            {
                for (int i = 0; i < tvCuentas.Nodes.Count; i++)
                {
                    tvCuentas.Nodes[i].ExpandAll();
                }
            }
            else
            {
                for (int i = 0; i < tvCuentas.Nodes.Count; i++)
                {
                    tvCuentas.Nodes[i].Collapse();
                }
            }
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Reportes.RepCuentasContables rccont = new Reportes.RepCuentasContables(LCCont);
            rccont.Show();
        }

        private void ckCodigo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControlCCont_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarPestaña();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando...");

            ListarCuentasCont();

            op.CerrarCargando();
        }

        #endregion
    }
}

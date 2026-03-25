using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using Objetos;
using Datos;

namespace GRTechnology1._0
{
    public partial class Frm_TipoUsuario : Form
    {
        string ID = string.Empty;
        string CodInmode = string.Empty;
        string Opcion = string.Empty;
        bool Estado = false;
        bool Cargado = false;

        DataSet DSTipoUsu = null;
        DataTable DTMenu = null;
        DataTable DTDetRol = null;

        IEnumerable<DataRow> DRTipo = null;
        IEnumerable<DataRow> DRMenu = null;

        public Frm_TipoUsuario()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void HabilitarCont()
        {
            //habilitamos segun la DB, por parametro el nombre del groupbox donde se encuentran los botones y el codigo del padre 1.4
            //op.HabilitarCont(gbxBotones, "2.06");
            
            btnNuevo.Enabled = true;
            btnModif.Enabled = true;
            btnBloquear.Enabled = true;
            btnAct.Enabled = true;
            btnReg.Enabled = true;
            
            //desabilitamos
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNomTipoUsu.ReadOnly = true;
        }

        private void DesabilitarCon()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnBloquear.Enabled = false;
            btnRest.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            txtBuscador.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNomTipoUsu.ReadOnly = false;
        }

        #endregion

        #region Conexion Capa de Negocio

        private void ListarMenu()
        {
            try
            {
                DTMenu = DListarPersonalizado.ConsultarDT("SELECT * FROM Menu WHERE Estado=1 AND TipoSistema='" + cboTipoSistema.Text + "'");
                DRMenu = (from mnu in DTMenu.AsEnumerable() select mnu);
                tvMenu.Nodes.Clear();
                CargarMenu(0, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoUsuario()
        {
            try
            {
                DSTipoUsu = DListarPersonalizado.ConsultarDS("SELECT * FROM Rol_Usuario WHERE Estado=1; " +
                                                             "SELECT * FROM Detalle_Rol_Usuario");

                DRTipo = from Tipo in DSTipoUsu.Tables[0].AsEnumerable()
                         select Tipo;

                CargarTipo(DRTipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable InsertDetalle_Rol()
        {
            DTDetRol = new DataTable();
            DTDetRol.Columns.Add("ID");
            DTDetRol.Columns.Add("PadreID");
            DTDetRol.Columns.Add("RolID");
            DTDetRol.Columns.Add("NomMenu");
            DTDetRol.Columns.Add("Tipo");
            DTDetRol.Columns.Add("TextoMenu");
            DTDetRol.Columns.Add("Descripcion");
            DTDetRol.Columns.Add("Estado");

            Marcar_Desmarcar_Menu("GUARDAR", tvMenu.Nodes);

            if (DTDetRol.Rows.Count == 0)
                throw new Exception("SELECCIONE POR LO MENOS UN ROL");

            return DTDetRol;
        }
        
        private void InsertModifTipoUsu()
        {
            if (string.IsNullOrWhiteSpace(txtNomTipoUsu.Text))
            {
                txtNomTipoUsu.Focus();
                MessageBox.Show("EL NOMBRE NO PUEDE ESTAR VACÍO", "NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                string DetInm = string.Empty;
                ORol_Usuario rol = new ORol_Usuario();

                if (Opcion == "Nuevo")
                   rol.RolID = -1;
                else
                {
                    rol.RolID = Convert.ToInt32(ID);

                    Frm_DetaModifAnul modif = new Frm_DetaModifAnul("MODIFICAR");
                    modif.ShowDialog();
                    if (!modif.Cancelado)
                        DetInm = modif.DetaModAnul();
                    else
                        throw new Exception("CANCELADO POR EL USUARIO");
                }

                rol.NomRol = txtNomTipoUsu.Text.Trim();
                rol.TipoSistema = cboTipoSistema.Text;
                rol.DetalleRolDT = InsertDetalle_Rol();

                int resp = DRol_Usuario.InsertModif_RolUsu(rol, OInmode.DTInmode(CodInmode, Opcion, DetInm));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Opcion = string.Empty;
                    BorrarCampos();
                    HabilitarCont();
                    ListarTipoUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bloquear_Desbloquear_TipoUsu(string opc, bool est)
        {
            DialogResult dialogo = MessageBox.Show("¿DESEA " + opc +  " A TODOS LOS USUARIOS QUE TIENEN ASGINADO EL TIPO DE USUARIO " + txtNomTipoUsu.Text + "?", 
                opc, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                try
                {
                    Frm_DetaModifAnul anul = new Frm_DetaModifAnul(opc);
                    anul.ShowDialog();
                    string DetInm = string.Empty;
                    if (!anul.Cancelado)
                        DetInm = anul.DetaModAnul();
                    else
                        throw new Exception("CANCELADO POR EL USUARIO");

                    bool resp = DListarPersonalizado.AnulRestau(ID.ToString(), "Tipo", CodInmode, DetInm, opc, est);
                    if (resp)
                    {
                        MessageBox.Show("SE BLOQUEÓ CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarTipoUsuario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarTipo(IEnumerable<DataRow> drtusu)
        {
            dgvTipoUsu.Rows.Clear();

            if (drtusu != null)
            {
                int cont = 0;
                foreach (DataRow item in drtusu)
                {
                    dgvTipoUsu.Rows.Add(item.Field<int>("RolID"), item.Field<string>("NomRol"), item.Field<bool>("Estado"));

                    if (!item.Field<bool>("Estado"))
                        dgvTipoUsu.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
            }
        }

        public void Seleccionar(int fila)
        {
            if (dgvTipoUsu.Rows.Count == 0 || fila == -1 || !Cargado)
                return;

            BorrarCampos();
            ID = dgvTipoUsu["C1", fila].Value.ToString();
            IEnumerable<DataRow> TipoQuery = DRTipo.Where(p => p.Field<int>("RolID").ToString() == ID);

            foreach (var item in TipoQuery)
            {
                CodInmode = item.Field<string>("CodInmode");
                Estado = item.Field<bool>("Estado");
                txtNomTipoUsu.Text = item.Field<string>("NomRol");

                Marcar_Desmarcar_Menu("SELEC", tvMenu.Nodes);
            }
        }

        public void Buscar()
        {
            if (txtNomTipoUsu.Text != string.Empty)
            {
                IEnumerable<DataRow> TipoQuery = (from Caja in DSTipoUsu.Tables[0].AsEnumerable()
                                                  select Caja).Where(p => p.Field<string>("NomTipo").ToUpper().Contains(txtBuscador.Text.ToUpper()));

                CargarTipo(TipoQuery);
            }
            else
                CargarTipo(DRTipo);
        }


        #endregion

        #region Funciones
                
        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                HabilitarCont();
                CargarTipo(DRTipo);
            }
        }

        private void BorrarCampos()
        {
            ID = string.Empty;
            txtNomTipoUsu.Clear();
            CodInmode = string.Empty;
            Marcar_Desmarcar_Menu("BORRAR", tvMenu.Nodes);
            Estado = false;                
        }
        
        private void CargarMenu(int padreid, TreeNode nodePadre)
        {
            IEnumerable<DataRow> fila = DRMenu.Where(x => x.Field<int>("PadreID") == padreid);
            foreach (DataRow item in fila)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = item["TextoMenu"].ToString().ToUpper();
                nuevoNodo.Tag = item["MenuID"].ToString();
                
                if (nodePadre == null)
                    tvMenu.Nodes.Add(nuevoNodo);
                else
                    nodePadre.Nodes.Add(nuevoNodo);

                CargarMenu((int)item["MenuID"], nuevoNodo);
            }
        }

        private void Marcar_Desmarcar_Menu(string opc, TreeNodeCollection nodo)
        {
            bool estadomarc;
            
            foreach (TreeNode item in nodo)
            {
                object obj = item.Tag;
                if (opc == "SELEC")
                {                    
                    IEnumerable<DataRow> fila = (from mnu in DSTipoUsu.Tables[1].AsEnumerable() select mnu)
                        .Where(x => x.Field<int>("MenuID") == Convert.ToInt32(obj))
                        .Where(x => x.Field<bool>("Estado") == true)
                        .Where(x => x.Field<int>("RolID") == int.Parse(ID));
                    estadomarc = (fila.Count() > 0 ? true : false);
                    item.Checked = estadomarc;
                }
                else if(opc == "GUARDAR")
                {
                    if(item.Checked)
                    {
                        DataRow dr = DTDetRol.NewRow();
                        dr["ID"] = Convert.ToInt32(obj);
                        dr["Estado"] = item.Checked;
                        DTDetRol.Rows.Add(dr);
                    }
                }
                else if (opc == "BORRAR")
                {
                    item.Checked = false;
                }
                
                Marcar_Desmarcar_Menu(opc, item.Nodes);
            }
        }

        //private List<OMenu> hijos(string indice)
        //{
        //    List<OMenu> desc = new List<OMenu>();

        //    foreach (var item in DRMenu)
        //    {
        //        if (item.Field<string>("CodPadre") == indice)
        //        {
        //            OMenu men = new OMenu();
        //            men.CodMenu = item.Field<string>("CodMenu");
        //            men.CodPadre = item.Field<string>("CodPadre");
        //            men.Descripcion = item.Field<string>("Descripcion");
        //            men.NomMenu = item.Field<string>("NomMenu");
        //            men.TextoMenu = item.Field<string>("TextoMenu");
        //            men.Tipo = item.Field<string>("Tipo");
        //            men.Estado = item.Field<bool>("Estado");

        //            desc.Add(men);
        //        }

        //    }
        //    return desc;
        //}

        //private void CrearNodosDelPadre(string indicePadre, TreeNode nodePadre)
        //{
        //    List<OMenu> listaHijos = hijos(indicePadre);

        //    // Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
        //    try
        //    {
        //        foreach (OMenu menu in listaHijos)
        //        {
        //            TreeNode nuevoNodo = new TreeNode();
        //            nuevoNodo.Text = menu.CodMenu + " " + menu.TextoMenu;
        //            nuevoNodo.Checked = menu.Estado;

        //            // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
        //            // del primer nivel que no dependen de otro nodo.
        //            if (nodePadre == null)
        //                tvMenu.Nodes.Add(nuevoNodo);
        //            // se añade el nuevo nodo al nodo padre.
        //            else
        //                nodePadre.Nodes.Add(nuevoNodo);

        //            // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
        //            CrearNodosDelPadre(menu.CodMenu, nuevoNodo);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void PrintRecursive(TreeNode treeNode)
        //{
        //    // Print the node.
        //    System.Diagnostics.Debug.WriteLine(treeNode.Text);

        //    //separamos el codigo
        //    String value = treeNode.Text;
        //    Char delimiter = ' ';
        //    String[] substrings = value.Split(delimiter);

        //    //agregamos al objeto
        //    OMenu menu = new OMenu();
        //    menu.CodMenu = substrings[0];
        //    menu.Estado = treeNode.Checked;
        //    LMenu.Add(menu);

        //    // Print each node recursively.
        //    foreach (TreeNode tn in treeNode.Nodes)
        //    {
        //        PrintRecursive(tn);
        //    }
        //}

        //private void CallRecursive(TreeView treeView)
        //{
        //    // Print each node recursively.
        //    TreeNodeCollection nodes = treeView.Nodes;
        //    foreach (TreeNode n in nodes)
        //    {
        //        PrintRecursive(n);
        //    }
        //}

        //private void DestiquearNodos(TreeNodeCollection nodos)
        //{
        //    foreach (TreeNode nodo in nodos)
        //    {
        //        nodo.Checked = false;
        //        DestiquearNodos(nodo.Nodes);
        //    }
        //}

        #endregion

        #region Eventos Formulario

        private void TipoUsuario_Load(object sender, EventArgs e)
        {
            cboTipoSistema.Text = "FORM";
            HabilitarCont();
            ListarMenu();
            ListarTipoUsuario();

            Cargado = true;
            Seleccionar(0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Opcion = "Nuevo";
            BorrarCampos();
            DesabilitarCon();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Opcion = "Modificar";
            DesabilitarCon();
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            Bloquear_Desbloquear_TipoUsu("BLOQUEAR", false);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Bloquear_Desbloquear_TipoUsu("DESBLOQUEAR", true);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            Cargado = false;
            ListarTipoUsuario();
            Cargado = true;
            Seleccionar(0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifTipoUsu();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (ID != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        private void dgvTipoUsu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar(e.RowIndex);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        
        private void cboTipoSistema_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListarMenu();
            Seleccionar(dgvTipoUsu.CurrentRow.Index);
        }

        #endregion
    }
}

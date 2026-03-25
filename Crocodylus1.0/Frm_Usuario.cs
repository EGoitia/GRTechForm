using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Datos;

namespace GRTechnology1._0
{
    public partial class Frm_Usuario : Form
    {
        private DataSet DSUsu = null;
        private bool Cargado = false;
        private int ID = -1;

        public Frm_Usuario()
        {
            InitializeComponent();
        }

        private void HabilDesab_Control(bool opc)
        {
            btnNuevo.Enabled = opc;
            btnModif.Enabled = opc;
            btnBloquear.Enabled = opc;

            btnGuardar.Enabled = !opc;
            btnCancelar.Enabled = !opc;
            gbxDatos.Enabled = !opc;
            dgvSucursal.ReadOnly = opc;
            dgvCajas.ReadOnly = opc;
        }

        private void Borrar()
        {
            ID = -1;
            txtContras.Clear();
            txtContras2.Clear();
            txtNom.Clear();
            txtNomPer.Clear();
            cboPersonal.SelectedValue = -1;
            cboTipoUsu.SelectedValue = -1;

            for (int i = 0; i < dgvSucursal.Rows.Count; i++)
            {
                dgvSucursal["Selec", i].Value = false;
            }
        }

        private void Seleccionar(int fila)
        {
            if (Cargado && !gbxDatos.Enabled)
            {
                Borrar();

                if (fila >= 0 && dgvUsuarios.Rows.Count > 0)
                {
                    ID = Convert.ToInt32(dgvUsuarios["UsuarioID", fila].Value);
                    txtNomPer.Text = dgvUsuarios["NombreCompleto", fila].Value.ToString();
                    txtNom.Text = dgvUsuarios["NomUsu", fila].Value.ToString();
                    cboTipoUsu.SelectedValue = dgvUsuarios["RolID", fila].Value.ToString();
                    cboPersonal.SelectedValue = dgvUsuarios["PersonalID", fila].Value.ToString();
                    ckbxEstado.Checked = Convert.ToBoolean(dgvUsuarios["RolID", fila].Value);

                    //Seleccionamos las Cajas del usuario
                    for (int i = 0; i < dgvCajas.Rows.Count; i++)
                    {
                        //Sucursal del usuario
                        IEnumerable<DataRow> drcajausu = DSUsu.Tables[2].Select("UsuarioID=" + ID).Where(x => x.Field<int>("CajaID") == Convert.ToInt32(dgvCajas["CajaID", i].Value));
                        if (drcajausu.Count() > 0)
                            dgvCajas["Selec", i].Value = true;
                        else
                            dgvCajas["Selec", i].Value = false;
                    }

                    //Seleccionamos las Sucursales del usuario
                    for (int i = 0; i < dgvSucursal.Rows.Count; i++)
                    {
                        //Sucursal del usuario
                        IEnumerable<DataRow> drsucusu = DSUsu.Tables[1].Select("UsuarioID=" + ID).Where(x => x.Field<int>("SucursalID") == Convert.ToInt32(dgvSucursal["SucursalID", i].Value));
                        if (drsucusu.Count() > 0)
                            dgvSucursal["Selec", i].Value = true;
                        else
                            dgvSucursal["Selec", i].Value = false;
                    }
                }                
            }
        }

        private void NombreColumnas()
        {
            dgvUsuarios.Columns["UsuarioID"].HeaderText = "ID";
            dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
            dgvUsuarios.Columns["NomUsu"].HeaderText = "Nombre Usuario";
            dgvUsuarios.Columns["Estado"].HeaderText = "Cuenta Habilitada";
            dgvUsuarios.Columns["NomRol"].HeaderText = "Tipo Usuario";

            dgvUsuarios.Columns["UsuarioID"].FillWeight = 50;
            dgvUsuarios.Columns["NombreCompleto"].FillWeight = 150;
            dgvUsuarios.Columns["NomUsu"].FillWeight = 150;
            dgvUsuarios.Columns["NomRol"].FillWeight = 150;
            dgvUsuarios.Columns["Estado"].FillWeight = 90;

            dgvUsuarios.Columns["CodInmode"].Visible = false;
            dgvUsuarios.Columns["PersonalID"].Visible = false;
            dgvUsuarios.Columns["Contrasenia"].Visible = false;
            dgvUsuarios.Columns["RolID"].Visible = false;
            dgvUsuarios.Columns["NomPer"].Visible = false;
        }

        private void Listar_Tipo_Usuario()
        {
            try
            {
                cboTipoUsu.DataSource = DListarPersonalizado.ConsultarDT("SELECT RolID, NomRol FROM Rol_Usuario WHERE Estado=1 " +
                    (OConexionGlobal.UsuarioID != 1 ? "AND RolID>1" : "") +
                    "UNION SELECT -1, '[SELECCIONE UN ROL]' ORDER BY NomRol");
                cboTipoUsu.DisplayMember = "NomRol";
                cboTipoUsu.ValueMember = "RolID";
                cboTipoUsu.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Personal()
        {
            try
            {
                cboPersonal.DataSource = DListarPersonalizado.ConsultarDT("SELECT PersonalID, NomPer FROM Vista_Personal WHERE Estado=1 " +
                        "UNION SELECT -1, '' ORDER BY NomPer");
                cboPersonal.DisplayMember = "NomPer";
                cboPersonal.ValueMember = "PersonalID";
                cboPersonal.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Sucursal()
        {
            try
            {
                dgvSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc, CONVERT(BIT, 0)Selec FROM Sucursal " +
                                                                          "WHERE Estado=1 ORDER BY NomSuc");
                dgvSucursal.Columns["SucursalID"].Visible = false;
                dgvSucursal.Columns["NomSuc"].HeaderText = "Sucursal";
                dgvSucursal.Columns["Selec"].HeaderText = "Selec.";
                dgvSucursal.Columns["NomSuc"].FillWeight = 120;
                dgvSucursal.Columns["Selec"].FillWeight = 50;
                dgvSucursal.Columns["NomSuc"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Cajas()
        {
            try
            {
               dgvCajas.DataSource = DListarPersonalizado.ConsultarDT("SELECT CajaID, NomCaja, CONVERT(BIT, 0)Selec FROM Caja " +
                                                                          "WHERE Estado=1 ORDER BY NomCaja");
               dgvCajas.Columns["CajaID"].Visible = false;
               dgvCajas.Columns["NomCaja"].HeaderText = "Caja";
               dgvCajas.Columns["Selec"].HeaderText = "Selec.";
               dgvCajas.Columns["NomCaja"].FillWeight = 120;
               dgvCajas.Columns["Selec"].FillWeight = 50;
               dgvCajas.Columns["NomCaja"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Usuario()
        {
            try
            {
                DSUsu = DListarPersonalizado.ConsultarDS("SELECT * FROM Vista_Usuarios " +
                    (OConexionGlobal.UsuarioID != 1 ? "WHERE UsuarioID>1 " : "") +
                    "ORDER BY UsuarioID DESC; " +
                    "SELECT * FROM Usuario_Sucursal " +
                    (OConexionGlobal.UsuarioID != 1 ? "WHERE UsuarioID>1 " : "") +
                    "; SELECT * FROM Usuario_Caja " + 
                    (OConexionGlobal.UsuarioID != 1 ? "WHERE UsuarioID>1 " : ""));
                Cargar_Usuarios(DSUsu.Tables[0]);
                NombreColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Verificar_Usuario()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("INGRESE EL NOMBRE DE USUARIO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNom.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtNomPer.Text))
            {
                MessageBox.Show("INGRESE UN NOMBRE COMPLETO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomPer.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtContras.Text))
            {
                MessageBox.Show("INGRESE UN UNA CONTRASEÑA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContras.Focus();
                return false;
            }
            else if (txtContras.Text != txtContras2.Text)
            {
                MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContras.Focus();
                return false;
            }
            else if (cboTipoUsu.SelectedValue == null)
            {
                MessageBox.Show("SELECCIONE UN TIPO DE USUARIO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContras.Focus();
                return false;
            }
            else if (cboTipoUsu.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("SELECCIONE UN TIPO DE USUARIO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContras.Focus();
                return false;
            }

            bool verifselecsucursal = false;
            for (int i = 0; i < dgvSucursal.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSucursal["Selec", i].Value))
                {
                    verifselecsucursal = true;
                    break;
                }
            }

            if (!verifselecsucursal)
            {
                MessageBox.Show("SELECCIONE UNA SUCURSAL", "SUCURSAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvSucursal.Focus();
                return false;
            }

            bool verficarcaja = false;
            for (int i = 0; i < dgvCajas.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvCajas["Selec", i].Value))
                {
                    verficarcaja = true;
                    break;
                }
            }

            if (!verficarcaja)
            {
                DialogResult dialogo = MessageBox.Show("NO HA SELECCIONADO NINGUNA CAJA PARA ESTE USUARIO, " +
                    "¿DESEA GUARDAR DE TODAS MANERAS SIN ASIGNARLE NINGUNA CAJA?", "CAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.No)
                {
                    dgvCajas.Focus();
                    return false;
                }
            }

            //Verificamos que el usuario no este registrado en la DB
            var valor = DListarPersonalizado.Dato("SELECT 1 FROM Usuario WHERE NomUsu='" + txtNom.Text + "'" +
                (ID > 0 ? " AND UsuarioID<>" + ID.ToString() : ""));
            if (valor != null)
            {
                MessageBox.Show("EL NOMBRE DE USUARIO YA ESTÁ REGISTRADO EN LA BASE DE DATOS", "NOMBRE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNom.Focus();
                return false;
            }

            return true;
        }

        private DataTable Usuario_CajasDT()
        {
            //agregamos las sucursales del usuario
            DataTable dtusuario_cajas = new DataTable();
            DataRow drusuario_caja;
            dtusuario_cajas.Columns.Add("SucursalID");
            for (int i = 0; i < dgvCajas.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvCajas["Selec", i].Value))
                {
                    drusuario_caja = dtusuario_cajas.NewRow();
                    drusuario_caja["SucursalID"] = Convert.ToInt32(dgvCajas["CajaID", i].Value);
                    dtusuario_cajas.Rows.Add(drusuario_caja);
                }
            }

            return dtusuario_cajas;
        }

        private DataTable Usuario_SucursalesDT()
        {
            //agregamos las sucursales del usuario
            DataTable dtusuario_sucursal = new DataTable();
            DataRow drusuario_sucursal;
            dtusuario_sucursal.Columns.Add("SucursalID");
            for (int i = 0; i < dgvSucursal.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSucursal["Selec", i].Value))
                {
                    drusuario_sucursal = dtusuario_sucursal.NewRow();
                    drusuario_sucursal["SucursalID"] = Convert.ToInt32(dgvSucursal["SucursalID", i].Value);
                    dtusuario_sucursal.Rows.Add(drusuario_sucursal);
                }
            }

            return dtusuario_sucursal;
        }

        private void Insert_Modif_Usuario()
        {
            if (!Verificar_Usuario())
                return;

            try
            {
                string detamodif = "CREACIÓN DE USUARIO";
                if (ID > 0)
                {
                    Frm_DetaModifAnul dmofi = new Frm_DetaModifAnul("MODIFICAR");
                    dmofi.ShowDialog();
                    if (dmofi.Cancelado)
                        throw new Exception("CANCELADO POR EL USUARIO");
                    else
                        detamodif = dmofi.DetaModAnul();
                    dmofi.Dispose();
                }

                OUsuario usu = new OUsuario();
                Encriptar enc = new Encriptar(txtContras.Text);
                usu.UsuarioID = ID;
                usu.NomPer = txtNomPer.Text.Trim();
                usu.NomUsu = txtNom.Text.Trim();
                usu.TipoUsuario = Convert.ToInt32(cboTipoUsu.SelectedValue);
                usu.PersonalID = Convert.ToInt32(cboPersonal.SelectedValue);
                usu.Contrasenia = enc.Encriptador();
                usu.Estado = ckbxEstado.Checked;
                usu.CajasDT = Usuario_CajasDT();
                usu.SucursalesDT = Usuario_SucursalesDT();                

                int resp = DUsuario.DInsertModifUsu(usu, OInmode.DTInmode("", (ID == -1 ? "MODIFICAR" : "NUEVO"), detamodif));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilDesab_Control(true);
                    Listar_Usuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Usuarios(DataTable dtusuario)
        {
            dgvUsuarios.DataSource = dtusuario;
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            HabilDesab_Control(true);
            Listar_Tipo_Usuario();
            Listar_Cajas();
            Listar_Sucursal();
            Listar_Personal();
            Listar_Usuario();
            Cargado = true;
            Seleccionar(0);
        }

        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar(e.RowIndex);
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IEnumerable<DataRow> drusu = DSUsu.Tables[0].Select("NombreCompleto LIKE '%" + txtBuscador.Text.Trim() + "%' OR " +
                                                          "NomUsu LIKE '%" + txtBuscador.Text.Trim() + "%'");
                if (drusu.Count() > 0)
                    Cargar_Usuarios(drusu.CopyToDataTable());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilDesab_Control(false);
            Borrar();            
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            HabilDesab_Control(false);
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA BLOQUEAR AL USUARIO " + txtNom.Text +"?", "BLOQUEAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    bool resp;
                    Frm_DetaModifAnul anul = new Frm_DetaModifAnul("BLOQUEAR");
                    try
                    {
                        anul.ShowDialog();

                        if (!anul.Cancelado)
                            resp = DListarPersonalizado.AnulRestau(ID.ToString(), "Usuario", anul.DetaModAnul(), "", "BLOQUEAR", false);
                        else
                            throw new Exception("CANCELADO POR EL USUARIO");

                        if (resp)
                        {
                            MessageBox.Show("SE BLOQUEÓ CORRECTAMENTE AL USUARIO " + txtNom.Text, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Listar_Usuario();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        anul.Dispose();
                    }
                }
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Insert_Modif_Usuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                Cargar_Usuarios(DSUsu.Tables[0]);
                HabilDesab_Control(true);
            }
        }

        private void dgvUsuarios_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvUsuarios.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }

            if (dgvUsuarios.Rows.Count > 0)
            {
                DataGridViewRow dgvr = dgvUsuarios.Rows[e.RowIndex];

                if (!(bool)dgvr.Cells["Estado"].Value)
                    dgvr.DefaultCellStyle.BackColor = Color.Red;
            }   
        }
    }
}

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
    public partial class TipoPermisos : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        bool Estado = false;

        List<OTipoPermiso> LTPer = null;
        OTipoPermiso TPer = null;

        public TipoPermisos()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnas()
        {
            dgvTipoPermisos.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 90;
            dgvTipoPermisos.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Nom. Permiso";
            c2.Width = 200;
            dgvTipoPermisos.Columns.Add(c2);

            DataGridViewCheckBoxColumn c3 = new DataGridViewCheckBoxColumn();
            c3.Name = "";
            c3.Width = 50;
            dgvTipoPermisos.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Desc";
            c4.Width = 200;
            dgvTipoPermisos.Columns.Add(c4);
        }

        private void HabilitarCont()
        {
            //Habilitamos segun los privilegios en la DB
            //op.HabilitarCont(gbxBotones, "2.06");

            //DEsabilitamos
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNomTipo.ReadOnly = true;
            txtDesc.ReadOnly = true;
            ckbxAfectVac.Enabled = false;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNomTipo.ReadOnly = false;
            txtDesc.ReadOnly = false;
            ckbxAfectVac.Enabled = true;
        }

        #endregion

        #region Conexion Capa Negocios

        private void ListarTipoPer()
        {
            try
            {
                LTPer = NTipoPermiso.NListarTPer();
                CargarTipoPer(LTPer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnas();
            }
        }

        private void InsertModifTipoPer()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.TipoInmode = Opcion;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                TPer = new OTipoPermiso();
                if(Opcion == "Nuevo")
                {
                    TPer.TipoPermisoID = -1;
                }
                else
                {
                    TPer.TipoPermisoID = Convert.ToInt32(txtCod.Text);
                    //detalle modificado
                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("Modificar");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();
                    inm.DetalleInmode = dmodanul.DetaModAnul();
                }

                TPer.NomTipoPermiso = txtNomTipo.Text;
                TPer.Descripcion = txtDesc.Text;
                TPer.AfectaVac = ckbxAfectVac.Checked;

                int resp = NTipoPermiso.NInsertModifTipoPer(TPer, inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los Datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando....");

                    Opcion = string.Empty;
                    ListarTipoPer();
                    HabilitarCont();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                op.CerrarCargando();
            }
        }

        private void AnulRestauTipoPermiso(string opc, int estado)
        {
            if (txtCod.Text != string.Empty)
            {
                DialogResult dialogo = MessageBox.Show("¿Seguro que desea " + opc + " " + txtNomTipo.Text + "?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogo == DialogResult.Yes)
                {
                    try
                    {
                        OInmode inm = new OInmode();
                        inm.CodInmode = CodInmode;
                        inm.UsuarioID = OConexionGlobal.UsuarioID;
                        inm.NomInmode = OConexionGlobal.NomPer;
                        inm.TipoInmode = opc;
                        inm.IPInmode = op.SaberIP();
                        inm.MacInmode = op.SaberMac();
                        inm.MaquinaInmode = op.SaberNomMaquina();
                        inm.SistOperInmode = op.SaberSistemOper();

                        //detalle modif-restau
                        Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(opc);
                        dmodanul.Owner = this;
                        dmodanul.ShowDialog();
                        inm.DetalleInmode = dmodanul.DetaModAnul();

                        int resp = NTipoPermiso.NAnulRestauTipoPer(txtCod.Text, "TipoPermiso", estado, inm);
                        {
                            MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            op.AbrirCargando("Cargando....");

                            ListarTipoPer();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        op.CerrarCargando();
                    }
                }
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarTipoPer(List<OTipoPermiso> ltper)
        {
            if(ltper != null)
            {
                NombreColumnas();

                int cont = 0;
                foreach (var item in ltper)
                {
                    dgvTipoPermisos.Rows.Add(item.TipoPermisoID, item.NomTipoPermiso, item.AfectaVac, item.Descripcion);

                    if (!item.Estado)
                        dgvTipoPermisos.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvTipoPermisos.Refresh();
            }
            else
            {
                NombreColumnas();
            }
        }

        private void BuscarTipoPer()
        {
            if(LTPer != null)
            {
                if(txtBusq.Text != string.Empty)
                {
                    List<OTipoPermiso> lbusqtper = LTPer.FindAll(x => x.NomTipoPermiso.ToUpper().Contains(txtBusq.Text.ToUpper()));
                    CargarTipoPer(lbusqtper);
                }
                else
                {
                    CargarTipoPer(LTPer);
                }
            }
        }

        private void SeleccionarTPer(DataGridViewCellEventArgs e)
        {
            if((e.RowIndex > -1) && (Opcion == string.Empty))
            {
                try
                {
                    BorrarCampos();

                    txtCod.Text = dgvTipoPermisos["Codigo", e.RowIndex].Value.ToString();

                    TPer = LTPer.Find(x => x.TipoPermisoID.ToString() == txtCod.Text);
                    if(TPer != null)
                    {
                        txtNomTipo.Text = TPer.NomTipoPermiso;
                        txtDesc.Text = TPer.Descripcion;
                        ckbxAfectVac.Checked = TPer.AfectaVac;
                        
                        Estado = TPer.Estado;
                        CodInmode = TPer.CodInmode;
                    }
                }
                catch (Exception)
                {    }
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos()
        {
            txtCod.Clear();
            txtNomTipo.Clear();
            txtDesc.Clear();
            ckbxAfectVac.Checked = true;
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            BorrarCampos();
            DesabilitarCont();
        }

        private void Modif()
        {
            if(txtCod.Text != string.Empty)
            {
                Opcion = "Modificar";
                DesabilitarCont();
            }
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Cancelar?", "Tipo Permiso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                HabilitarCont();
                BorrarCampos();
                CargarTipoPer(LTPer);
            }
        }

        private void Registro()
        {
            if(txtCod.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos Formulario

        private void TipoPermisos_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            HabilitarCont();
            ListarTipoPer();

            op.CerrarCargando();
        }

        private void dgvTipoPermisos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarTPer(e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Modif();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (Estado)
                AnulRestauTipoPermiso("Anular", 0);
            else
                MessageBox.Show("Ya esta Anulado", "Anulado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarTipoPer();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifTipoPer();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void txtBusq_TextChanged(object sender, EventArgs e)
        {
            BuscarTipoPer();
        }

        private void TipoPermisos_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #endregion
    }
}

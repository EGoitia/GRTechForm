using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Objetos;
using Negocio;

namespace GRTechnology1._0
{
    public partial class Frm_RubroSubRubro : Form
    {
        OpcionFormularios opc = new OpcionFormularios();

        string CodInmode = string.Empty;
        string Opcion = string.Empty;
        bool Estado = false;

        List<ORubroSubRubro> LRSRub = null;

        public Frm_RubroSubRubro()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombresColumnas()
        {
            this.dgvRubSRub.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 100;
            c1.Name = "Codigo";
            dgvRubSRub.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 265;
            c2.Name = "Nombre";
            dgvRubSRub.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 100;
            c3.Name = "Tipo";
            dgvRubSRub.Columns.Add(c3);
        }

        private void HabilitarCont()
        {
            btnNuevo.Enabled = true;
            btnModif.Enabled = true;
            btnAnul.Enabled = true;
            btnAct.Enabled = true;
            btnReg.Enabled = true;
            txtBuscar.Enabled = true;

            //opc.HabilitarCont(gbxBotones, "3.01");

            //DESABILITAMOS
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNom.ReadOnly = true;
            cboTipo.Enabled = false;
        }

        private void DesabilitarCont()
        {
            //desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            txtBuscar.Enabled = false;

            //habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNom.ReadOnly = false;
            cboTipo.Enabled = true;
        }

        #endregion

        #region Cargar Datos

        private void BuscarRSRub()
        {
            if (LRSRub != null)
            {
                NombresColumnas();

                int val = 0;
                if (int.TryParse(txtBuscar.Text, out val))
                {
                    //Buscamos por codigo del Tipo de Producto
                    ORubroSubRubro objrsrub = LRSRub.Find(x => x.RubroSubRubroID == Convert.ToInt32(txtBuscar.Text));
                    if (objrsrub != null)
                    {
                        dgvRubSRub.Rows.Add(objrsrub.RubroSubRubroID, objrsrub.NomRubroSubRubro, objrsrub.Tipo);
                        if (!objrsrub.Estado)
                        {
                            dgvRubSRub.Rows[0].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        }
                    }
                }
                else
                {
                    //Buscamos por Nombre del Tipo de Producto
                    List<ORubroSubRubro> lbusrsrub = LRSRub.FindAll(c => c.NomRubroSubRubro.ToUpper().Contains(txtBuscar.Text.ToUpper()));

                    int cont = 0;
                    foreach (var item in lbusrsrub)
                    {
                        dgvRubSRub.Rows.Add(item.RubroSubRubroID, item.NomRubroSubRubro, item.Tipo);
                        if (!item.Estado)
                        {
                            dgvRubSRub.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        }
                        cont++;
                    }
                }
                dgvRubSRub.Refresh();
            }
        }

        private void CargarRSRub()
        {
            if (LRSRub != null)
            {
                NombresColumnas();
                dgvRubSRub.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;

                int cont = 0;
                foreach (var item in LRSRub)
                {
                    dgvRubSRub.Rows.Add(item.RubroSubRubroID, item.NomRubroSubRubro, item.Tipo);
                    if (!item.Estado)
                    {
                        dgvRubSRub.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    cont++;
                }
            }
            else
            {
                NombresColumnas();
            }
        }

        #endregion

        #region Conexion capa negocio

        private void ListarRubSubRub()
        {
            try
            {
                LRSRub = NRubroSubRubro.NListarRubroSubRubro();
                CargarRSRub();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombresColumnas();
            }
        }

        private void InsertModif()
        {
            try
            {
                //Inmode
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.TipoInmode = Opcion;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.IPInmode = opc.SaberIP();
                inm.MacInmode = opc.SaberMac();
                inm.MaquinaInmode = opc.SaberNomMaquina();
                inm.SistOperInmode = opc.SaberSistemOper();

                //Rubro-Subrubro
                ORubroSubRubro rsrub = new ORubroSubRubro();
                if (Opcion == "Nuevo")
                {
                    rsrub.RubroSubRubroID = -1;
                }
                else
                {
                    rsrub.RubroSubRubroID = int.Parse(txtRubroSubRubroID.Text);

                    //Cargamos Detalle Modificado
                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("Modificar Rubro-Subrubro");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();
                    inm.DetalleInmode = dmodanul.DetaModAnul();
                }
                rsrub.NomRubroSubRubro = txtNom.Text;
                rsrub.Tipo = cboTipo.Text;

                int resp = NRubroSubRubro.NInsertModifRubroSubRubro(rsrub, inm);
                if (resp > 0)
                {
                    MessageBox.Show("Los datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //abrimos cargando....
                    AbrirCargando("Cargando.....");
                    
                    Opcion = string.Empty;
                    HabilitarCont();
                    ListarRubSubRub();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //CErramos cargando
                CerrarCargando();
            }
        }

        private void AnulRestau(string op, bool estado)
        {
            if(txtRubroSubRubroID.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Desea " + op + " " + txtNom.Text + "?", op + " Subrubro", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string DetalleInmode;
                        Frm_DetaModifAnul anul = new Frm_DetaModifAnul("Anular");
                        anul.Owner = this;
                        anul.ShowDialog();
                        DetalleInmode = anul.DetaModAnul();
                        anul.Dispose();

                        bool resp = NListarPersonalizado.AnulRestau(txtRubroSubRubroID.Text, "RSRub", "", DetalleInmode, op, estado);

                        if (resp)
                        {
                            MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Abrimos cargando
                            AbrirCargando("Cargando.....");

                            ListarRubSubRub();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //cerramos cargando.....
                        CerrarCargando();
                    }
                }
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos(GroupBox gbx, string param)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, param);
        }

        private void Seleccionar(DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (Opcion == string.Empty))
            {
                try
                {
                    txtRubroSubRubroID.Text = dgvRubSRub["Codigo", e.RowIndex].Value.ToString();

                    ORubroSubRubro objrsrub = LRSRub.Find(x => x.RubroSubRubroID == Convert.ToInt32(txtRubroSubRubroID.Text));
                    if (objrsrub != null)
                    {
                        txtNom.Text = objrsrub.NomRubroSubRubro;
                        cboTipo.Text = objrsrub.Tipo;
                        CodInmode = objrsrub.CodInmode;
                        Estado = objrsrub.Estado;
                    }
                }
                catch (Exception)
                { }
            }
        }

        private void AbrirCargando(string msje)
        {
        }

        private void CerrarCargando()
        {
        }

        private void Nuevo()
        {
            BorrarCampos(gbRSRub, "");
            Opcion = "Nuevo";
            DesabilitarCont();
        }

        private void Modif()
        {
            if (txtRubroSubRubroID.Text != string.Empty)
            {
                if(Estado)
                {
                    Opcion = "Modificar";
                    DesabilitarCont();
                }
                else
                {
                    MessageBox.Show("No se puede modificar porque ya esta anulado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Cancelar()
        {
            DialogResult result = MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                HabilitarCont();
                CargarRSRub();
            }
        }

        private void Registro()
        {
            if(txtRubroSubRubroID.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos Formulario

        private void dgvRubSRub_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar(e);
        }

        private void cboTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipo.Text == "Rubro")
                this.BackColor = System.Drawing.Color.LightSeaGreen;
            else
                this.BackColor = System.Drawing.Color.Plum;
        }

        private void RubroSubRubro_Load(object sender, EventArgs e)
        {
            //abrimos cargando....
            AbrirCargando("Cargando....");

            ListarRubSubRub();
            HabilitarCont();

            //cerramos cargando
            CerrarCargando();
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
            if(txtRubroSubRubroID.Text != string.Empty)
            {
                if (Estado)
                    AnulRestau("Anular", false);
                else
                    MessageBox.Show(txtNom.Text + " ya esta Anulado", "Rubro-Subrubro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            //cargamos cargando...
            AbrirCargando("Cargando.....");

            ListarRubSubRub();

            //cerramos cargando
            CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModif();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarRSRub();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        #endregion
    }
}

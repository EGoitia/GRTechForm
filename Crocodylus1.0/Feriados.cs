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
    public partial class Feriados : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        string CodInmode = string.Empty;
        string Opcion = string.Empty;
        bool Estado = false;

        List<OFeriados> LFer = null;

        public Feriados()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnas()
        {
            dgvFeriados.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 70;
            dgvFeriados.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Feriado";
            c2.Width = 250;
            dgvFeriados.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 100;
            dgvFeriados.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Duracion";
            c4.Width = 60;
            dgvFeriados.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Descripcion";
            c5.Width = 250;
            dgvFeriados.Columns.Add(c5);
        }

        private void HabilitarCont()
        {
            //Habilitamos los Controles
            //op.HabilitarCont(gbxBotones, "1.08");

            txtNomFeriado.ReadOnly = true;
            txtDesc.ReadOnly = true;
            dtFecha.Enabled = false;
            NunUpDwDuracion.Enabled = false;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos los Controles
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            
            //Habilitar Controles
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNomFeriado.ReadOnly = false;
            txtDesc.ReadOnly = false;
            dtFecha.Enabled = true;
            NunUpDwDuracion.Enabled = true;
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarFeriados()
        {
            try
            {
                LFer = NFeriados.NListarFeriados();
                CargarFeriados(LFer);
            }
            catch (Exception)
            {
                NombreColumnas();
            }
        }

        private void InsertModifFeriado()
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

                OFeriados fer = new OFeriados();
                if (Opcion == "Nuevo")
                {
                    fer.FeriadoID = -1;
                }
                else
                {
                    fer.FeriadoID = Convert.ToInt32(txtFeriadoID.Text);

                    Frm_DetaModifAnul dmodan = new Frm_DetaModifAnul("Modificar");
                    dmodan.Owner = this;
                    dmodan.ShowDialog();
                    inm.DetalleInmode = dmodan.DetaModAnul();
                }
                
                fer.NomFeriado = txtNomFeriado.Text;
                fer.Descripcion = txtDesc.Text;
                fer.Fecha = dtFecha.Value;
                fer.Duracion = NunUpDwDuracion.Value;

                int resp = NFeriados.NInsertModifFeriados(fer, inm);
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");
                    
                    Opcion = string.Empty;
                    HabilitarCont();
                    ListarFeriados();
                }
                else
                {
                    MessageBox.Show("Error al Guardar los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AnulRestauFeriado(string codigo, string tupla, int estado, string o)
        {
            try
            {
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.TipoInmode = o;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                //Cargamos Detalle Anulado
                Frm_DetaModifAnul anul = new Frm_DetaModifAnul(o + " Feriado");
                anul.Owner = this;
                anul.ShowDialog();
                inm.DetalleInmode = anul.DetaModAnul();

                int resp = NFeriados.NAnulRestauFeriado(codigo, tupla, estado, inm);
                if (resp > 0)
                {
                    MessageBox.Show("Los datos se Actualizaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    ListarFeriados();
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

        #endregion

        #region Cargar Datos

        private void CargarFeriados(List<OFeriados> lfer)
        {
            if (lfer != null)
            {
                NombreColumnas();

                int cont = 0;
                foreach (var item in lfer)
                {
                    dgvFeriados.Rows.Add(item.FeriadoID, item.NomFeriado, item.Fecha.ToShortDateString(),
                                         string.Format("{0:#,##0.00}", item.Duracion), item.Descripcion);

                    if (!item.Estado)
                        dgvFeriados.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
            }
            else
            {
                NombreColumnas();
            }
        }

        private void SeleccionarFeriado(DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (Opcion == string.Empty))
            {
                try
                {
                    int ferid = Convert.ToInt32(dgvFeriados["Codigo", e.RowIndex].Value);
                    OFeriados objfer = LFer.Find(x => x.FeriadoID == ferid);

                    if (objfer != null)
                    {
                        CodInmode = objfer.CodInmode;
                        txtFeriadoID.Text = ferid.ToString();
                        txtNomFeriado.Text = objfer.NomFeriado;
                        txtDesc.Text = objfer.Descripcion;
                        dtFecha.Text = objfer.Fecha.ToString();
                        NunUpDwDuracion.Value = objfer.Duracion;
                        Estado = objfer.Estado;
                    }
                }
                catch (Exception)
                { }
            }
        }

        private void BuscarFeriado()
        {
            if(txtBuscar.Text != string.Empty)
            {
                //Buscamos por Nombre de Feriado
                List<OFeriados> lbusqfer = LFer.FindAll(c => c.NomFeriado.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                CargarFeriados(lbusqfer);
            }
            else
            {
                CargarFeriados(LFer);
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos()
        {
            txtFeriadoID.Clear();
            txtNomFeriado.Clear();
            txtDesc.Clear();
            dtFecha.Text = DateTime.Now.ToString();
            NunUpDwDuracion.Value = 1;
        }

        private void OpcionAnulRestau(string op, int es)
        {
            if (((es == 0) && (Estado)) || ((es == 1) && (!Estado)))
            {
                DialogResult result = MessageBox.Show("¿Desea " + op + " el Feriado " + txtNomFeriado.Text + "?", op + " Feriado", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                    AnulRestauFeriado(txtFeriadoID.Text, "Feriado", es, op);
            }
            else
            {
                MessageBox.Show("Opcion no Valida, el Feriado no se puede " + op, "Feriado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            txtBuscar.Clear();
            BorrarCampos();
            DesabilitarCont();
        }

        private void Modif()
        {
            if(txtFeriadoID.Text != string.Empty)
            {
                Opcion = "Modificar";
                txtBuscar.Clear();
                DesabilitarCont();
            }
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            if(dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                HabilitarCont();
                CargarFeriados(LFer);
            }
        }

        private void Registro()
        {
            if(txtFeriadoID.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos Formulario

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
            if (txtFeriadoID.Text != string.Empty)
            {
                if (Estado)
                    OpcionAnulRestau("Anular", 0);
                else
                    MessageBox.Show("Ya esta Anulado", "Anulado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRestau_Click(object sender, EventArgs e)
        {
            if(txtFeriadoID.Text != string.Empty)
            {
                if (!Estado)
                    OpcionAnulRestau("Restaurar", 1);
                else
                    MessageBox.Show("Ya esta Habilitado", "Habilitado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando...");

            ListarFeriados();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifFeriado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void dgvFeriados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFeriado(e);
        }

        private void Feriados_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            HabilitarCont();
            ListarFeriados();

            op.CerrarCargando();
        }

        private void Feriados_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarFeriado();
        }

        #endregion
    }
}

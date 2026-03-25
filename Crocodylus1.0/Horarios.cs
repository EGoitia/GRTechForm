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
    public partial class Horarios : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OHorario> LHor = new List<OHorario>();

        string Opcion = string.Empty;
        string CodInmode = string.Empty;

        bool Estado = false;

        public Horarios()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnas()
        {
            dgvHorarios.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 60;
            dgvHorarios.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Nombre Horario";
            c2.Width = 200;
            dgvHorarios.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Hr. Entrada";
            c3.Width = 80;
            dgvHorarios.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Hr. Salida";
            c4.Width = 80;
            dgvHorarios.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Color";
            c5.Width = 50;
            dgvHorarios.Columns.Add(c5);
        }

        private void HabilitarCon()
        {
            //op.HabilitarCont(gbxBotones, "2.09");

            txtNomHr.ReadOnly = true;
            dtHrEnt.Enabled = false;
            dtHrSal.Enabled = false;
            dtHrInicEnt.Enabled = false;
            dtHrFinEnt.Enabled = false;
            dtHrIniSal.Enabled = false;
            dtHrFinSal.Enabled = false;
            numUpDownMintolerEnt.Enabled = false;
            numUpDownMinTolerSal.Enabled = false;
            numUpDownValorDia.Enabled = false;
            btncolor.Enabled = false;
        }

        private void DesabilitarCon()
        {
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;

            btnGuardar.Enabled = true;
            btnCancel.Enabled = true;

            txtNomHr.ReadOnly = false;
            dtHrEnt.Enabled = true;
            dtHrSal.Enabled = true;
            dtHrInicEnt.Enabled = true;
            dtHrFinEnt.Enabled = true;
            dtHrIniSal.Enabled = true;
            dtHrFinSal.Enabled = true;
            numUpDownMintolerEnt.Enabled = true;
            numUpDownMinTolerSal.Enabled = true;
            numUpDownValorDia.Enabled = true;
            btncolor.Enabled = true;
        }

        #endregion

        #region Conexion Capa de Negocios

        private void ListarHorarios()
        {
            try
            {
                LHor = NHorario.NListarHorario();
                CargarHorarios(LHor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnas();
            }
        }

        private void InsertModifHorario()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.TipoInmode = Opcion;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                OHorario hor = new OHorario();
                if(Opcion == "Nuevo")
                {
                    hor.HorarioID = -1;
                }
                else
                {
                    hor.HorarioID = Convert.ToInt32(txtCodigo.Text);

                    Frm_DetaModifAnul dmodif = new Frm_DetaModifAnul("Modificar Horario");
                    dmodif.Owner = this;
                    dmodif.ShowDialog();
                    inm.DetalleInmode = dmodif.DetaModAnul();
                }

                hor.NomHorario = txtNomHr.Text;
                hor.HrEntrada = dtHrEnt.Value;
                hor.HrSalida = dtHrSal.Value;
                hor.InicioEntr = dtHrInicEnt.Value;
                hor.FinEntr = dtHrFinEnt.Value;
                hor.InicioSal = dtHrIniSal.Value;
                hor.FinSal = dtHrFinSal.Value;
                hor.MinTolerEnt = Convert.ToInt32(numUpDownMintolerEnt.Value);
                hor.MinTolerSal = Convert.ToInt32(numUpDownMinTolerSal.Value);
                hor.ValorDiaTrab = Convert.ToInt32(numUpDownValorDia.Value);
                hor.Color = txtColor.BackColor.Name;

                int resp = NHorario.NInsertModifHorario(hor, inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando....");

                    Opcion=string.Empty;
                    BorrarCampos();
                    ListarHorarios();
                    HabilitarCon();
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

        private void AnulRestauHorario(string opc, int estado)
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea " + opc + " el Horario " + txtNomHr.Text + "?", opc + " Horario", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                try
                {
                    OInmode inm = new OInmode();
                    inm.UsuarioID = OConexionGlobal.UsuarioID;
                    inm.NomInmode = OConexionGlobal.NomPer;
                    inm.TipoInmode = opc;
                    inm.IPInmode = op.SaberIP();
                    inm.MacInmode = op.SaberMac();
                    inm.MaquinaInmode = op.SaberNomMaquina();
                    inm.SistOperInmode = op.SaberSistemOper();

                    Frm_DetaModifAnul anul = new Frm_DetaModifAnul("Anular");
                    anul.Owner = this;
                    anul.ShowDialog();
                    inm.DetalleInmode = anul.DetaModAnul();

                    int resp = NHorario.NAnulRestauHorario(txtCodigo.Text, "Horario", estado, inm);
                    if(resp> 0)
                    {
                        MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando....");

                        ListarHorarios();
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

        #endregion

        #region Cargar Datos

        private void CargarHorarios(List<OHorario> lhor)
        {
            if(lhor != null)
            {
                NombreColumnas();

                int cont=0;
                foreach (var item in lhor)
                {
                    dgvHorarios.Rows.Add(item.HorarioID, item.NomHorario, item.HrEntrada.ToShortTimeString(), item.HrSalida.ToShortTimeString(), "");
                    
                    if (!item.Estado)
                        dgvHorarios.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    dgvHorarios["Color", cont].Style.BackColor = System.Drawing.Color.FromName(item.Color);

                    cont++;
                }
                dgvHorarios.Refresh();
            }
            else
            {
                NombreColumnas();
            }
        }

        private void BuscarHorario()
        {
            if(LHor != null)
            {
                if(txtBuscar.Text != string.Empty)
                {
                    List<OHorario> lbusqhor = LHor.FindAll(x => x.NomHorario.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                    CargarHorarios(lbusqhor);
                }
                else
                {
                    CargarHorarios(LHor);
                }
            }
        }

        private void SeleccionarHorario(DataGridViewCellEventArgs e)
        {
            if((e.RowIndex > -1) && (Opcion == string.Empty))
            {
                try
                {
                    txtCodigo.Text = dgvHorarios["Codigo", e.RowIndex].Value.ToString();
                    
                    OHorario hor = LHor.Find(x => x.HorarioID.ToString() == txtCodigo.Text);
                    if(hor != null)
                    {
                        txtNomHr.Text = hor.NomHorario;
                        dtHrEnt.Value = hor.HrEntrada;
                        dtHrSal.Value = hor.HrSalida;
                        dtHrInicEnt.Value = hor.InicioEntr;
                        dtHrFinEnt.Value = hor.FinEntr;
                        dtHrIniSal.Value = hor.InicioSal;
                        dtHrFinSal.Value = hor.FinSal;
                        numUpDownMintolerEnt.Value = hor.MinTolerEnt;
                        numUpDownMinTolerSal.Value = hor.MinTolerSal;
                        numUpDownValorDia.Value = hor.ValorDiaTrab;
                        txtColor.BackColor = System.Drawing.Color.FromName(hor.Color);

                        CodInmode = hor.CodInmode;
                        Estado = hor.Estado;
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
            txtCodigo.Clear();
            txtNomHr.Clear();
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            BorrarCampos();
            DesabilitarCon();
        }

        private void Modif()
        {
            Opcion = "Modificar";
            DesabilitarCon();
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                CargarHorarios(LHor);
                HabilitarCon();
            }

        }

        private void Registro()
        {
            if(txtCodigo.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos Formulario

        private void btncolor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                txtColor.BackColor = colorDialog.Color;
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarHorarios();
            HabilitarCon();

            op.CerrarCargando();
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
            if(txtCodigo.Text != string.Empty)
            {
                if (Estado)
                    AnulRestauHorario("Anular", 0);
                else
                    MessageBox.Show("El Horario ya esta Anulado", "Anulado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando.....");

            ListarHorarios();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifHorario();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void dgvHorarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarHorario(e);
        }

        private void Horarios_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarHorario();
        }

        #endregion
    }
}

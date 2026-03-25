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
    public partial class PermisosVacaciones : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OPersonal> LPer = null;
        List<OTipoPermiso> LTPer = null;
        List<OPermisoVacacion> LPerVac = null;
        List<OPermisoVacacion> LBusqPerVac = null;

        OPermisoVacacion PerVac = null;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        bool Estado = false;

        public PermisosVacaciones()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnas()
        {
            dgvNotas.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 60;
            dgvNotas.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Personal";
            c2.Width = 100;
            dgvNotas.Columns.Add(c2);
        }

        private void HabilitarCont()
        {
            //Habilitamos Conbtroles segun la DB
            //op.HabilitarCont(gbxBotones, "2.07");

            dtFecNota.Enabled=true;

            //DEsabilitamos
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            cboPersonal.Enabled = false;
            cboTipoLic.Enabled = false;
            txtObs.ReadOnly = true;
            dtFecIni.Enabled = false;
            dtFecFin.Enabled = false;
            dtHrIni.Enabled = false;
            dtHrFin.Enabled = false;
            numUpDownTotDias.Enabled = false;
            numUpDownTotHrs.Enabled = false;
        }
        
        private void DesabilitarCont()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;

            txtBuscar.Enabled = false;
            cboOpBusq.Enabled = false;

            dtFecNota.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            cboPersonal.Enabled = true;
            cboTipoLic.Enabled = true;
            txtObs.ReadOnly = false;
            dtFecIni.Enabled = true;
            dtFecFin.Enabled = true;
            dtHrIni.Enabled = true;
            dtHrFin.Enabled = true;
            numUpDownTotDias.Enabled = true;
            numUpDownTotHrs.Enabled = true;
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarPersonal()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("Personal", -1).OrderBy(x => x.NomPer).ToList();
                CargarPersonal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoPermiso()
        {
            try
            {
                LTPer = NTipoPermiso.NListarTPer().OrderBy(x => x.NomTipoPermiso).ToList();
                CargarTipoPermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPermisoVacacion()
        {
            try
            {
                LPerVac = NPermisoVacacion.NListarPermisoVacacion(dtFecNota.Value);
                CargarPermisoVacacion(LPerVac);
            }
            catch (Exception)
            {
                NombreColumnas();
            }
        }

        private void InsertModifPermisoVacacion()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.TipoInmode = Opcion;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                PerVac = new OPermisoVacacion();
                if(Opcion == "Nuevo")
                {
                    PerVac.PermVacaID = -1;
                }
                else
                {
                    PerVac.PermVacaID = Convert.ToInt32(txtCodigo.Text);

                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("Modificar");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();
                    inm.DetalleInmode = dmodanul.DetaModAnul();
                }

                PerVac.PersonalID = Convert.ToInt32(cboPersonal.SelectedValue);
                PerVac.TipoPermisoID = Convert.ToInt32(cboTipoLic.SelectedValue);
                PerVac.Observacion = txtObs.Text;
                PerVac.FechaPermisoInic = Convert.ToDateTime(dtFecIni.Value.ToShortDateString() + " " + dtHrIni.Value.ToShortTimeString());
                PerVac.FechaPermisoFin = Convert.ToDateTime(dtFecFin.Value.ToShortDateString() + " " + dtHrFin.Value.ToShortTimeString());
                PerVac.TotDias = Convert.ToInt32(numUpDownTotDias.Value);
                PerVac.TotHrs = numUpDownTotHrs.Value;

                int resp = NPermisoVacacion.NInsertModifPermisoVacacion(PerVac, inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando....");

                    Opcion = string.Empty;
                    BorrarCampos();

                    CargarPersonal();
                    CargarTipoPermiso();
                    ListarPermisoVacacion();
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

        private void AnulRestauPermisoVacacion(string o, int estado)
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea " + o + "?", o, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                try
                {
                    OInmode inm = new OInmode();
                    inm.CodInmode = CodInmode;
                    inm.TipoInmode = o;
                    inm.UsuarioID = OConexionGlobal.UsuarioID;
                    inm.NomInmode = OConexionGlobal.NomPer;
                    inm.IPInmode = op.SaberIP();
                    inm.MacInmode = op.SaberMac();
                    inm.MaquinaInmode = op.SaberNomMaquina();
                    inm.SistOperInmode = op.SaberSistemOper();

                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(o);
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();
                    inm.DetalleInmode = dmodanul.DetaModAnul();

                    int resp = NPermisoVacacion.NAnulRestauPermisoVacacion(txtCodigo.Text, "PermisoVacacion", estado, inm);
                    if(resp > 0)
                    {
                        MessageBox.Show("Se Anulo Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando....");

                        ListarPermisoVacacion();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    op.CerrarCargando();
                }
            }
        }

        private void BuscarPermisoVacacion()
        {
            try
            {
                LBusqPerVac = NPermisoVacacion.NBuscarPermisoVacacion(txtBuscar.Text, cboOpBusq.Text, dtFecNota.Value);
                CargarPermisoVacacion(LBusqPerVac);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnas();
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarPersonal()
        {
            if(LPer != null)
            {
                cboPersonal.DataSource = LPer;
                cboPersonal.DisplayMember = "NomPer";
                cboPersonal.ValueMember = "PersonalID";
                cboPersonal.Refresh();
            }
        }

        private void CargarPersonalHabil()
        {
            if (LPer != null)
            {
                List<OPersonal> lper = LPer.Where(x => x.Estado).ToList();
                cboPersonal.DataSource = lper;
                cboPersonal.DisplayMember = "NomPer";
                cboPersonal.ValueMember = "PersonalID";
                cboPersonal.Refresh();
            }
        }

        private void CargarTipoPermiso()
        {
            if(LTPer != null)
            {
                cboTipoLic.DataSource = LTPer;
                cboTipoLic.DisplayMember = "NomTipoPermiso";
                cboTipoLic.ValueMember = "TipoPermisoID";
                cboTipoLic.Refresh();
            }
        }

        private void CargarTipoPermisoHabil()
        {
            if (LTPer != null)
            {
                List<OTipoPermiso> ltper = LTPer.Where(x => x.Estado).ToList();

                cboTipoLic.DataSource = ltper;
                cboTipoLic.DisplayMember = "NomTipoPermiso";
                cboTipoLic.ValueMember = "TipoPermisoID";
                cboTipoLic.Refresh();
            }
        }

        private void CargarPermisoVacacion(List<OPermisoVacacion> lpervac)
        {
            if(lpervac != null)
            {
                NombreColumnas();

                int cont = 0;
                foreach (var item in lpervac)
                {
                    dgvNotas.Rows.Add(item.PermVacaID, item.NomPer);

                    if (!item.Estado)
                        dgvNotas.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvNotas.Refresh();
            }
            else
            {
                NombreColumnas();
            }
        }

        private void SeleccionarPermisoVacacion(DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex > -1) && (Opcion == string.Empty))
                {
                    txtCodigo.Text = dgvNotas["Codigo", e.RowIndex].Value.ToString();

                    if (txtBuscar.Text == string.Empty)
                        PerVac = LPerVac.Find(x => x.PermVacaID.ToString() == txtCodigo.Text);
                    else
                        PerVac = LBusqPerVac.Find(x => x.PermVacaID.ToString() == txtCodigo.Text);

                    if (PerVac != null)
                    {
                        cboPersonal.Text = PerVac.NomPer;
                        cboTipoLic.Text = PerVac.NomTipoPermiso;
                        txtObs.Text = PerVac.Observacion;
                        dtFecIni.Value = PerVac.FechaPermisoInic;
                        dtFecFin.Value = PerVac.FechaPermisoFin;
                        dtHrIni.Text = PerVac.FechaPermisoInic.ToShortTimeString();
                        dtHrFin.Text = PerVac.FechaPermisoFin.ToShortTimeString();
                        numUpDownTotDias.Value = PerVac.TotDias;
                        numUpDownTotHrs.Value = PerVac.TotHrs;

                        CodInmode = PerVac.CodInmode;
                        Estado = PerVac.Estado;
                    }
                }
            }
            catch (Exception)
            {
                BorrarCampos();
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos()
        {
            txtCodigo.Clear();
            txtObs.Clear();
            dtFecIni.Value = DateTime.Now;
            dtFecFin.Value = DateTime.Now;
            dtHrIni.Text = "00:00:00";
            dtFecFin.Text = "00:00:00";
            numUpDownTotDias.Value = 0;
            numUpDownTotHrs.Value = 0;
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            txtBuscar.Clear();
            BorrarCampos();

            CargarPersonalHabil();
            CargarTipoPermisoHabil();

            DesabilitarCont();
        }

        private void Modif()
        {
            if(txtCodigo.Text != string.Empty)
            {
                Opcion = "Modificar";
                DesabilitarCont();
            }
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo == DialogResult.Yes)
            {
                op.AbrirCargando("Cargando.....");

                Opcion = string.Empty;
                CargarPersonal();
                CargarTipoPermiso();
                CargarPermisoVacacion(LPerVac);

                HabilitarCont();

                op.CerrarCargando();
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

        private void PermisosVacaciones_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            cboOpBusq.Text = "Codigo";
            ListarPersonal();
            ListarTipoPermiso();
            ListarPermisoVacacion();
            HabilitarCont();

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
                    AnulRestauPermisoVacacion("Anular", 0);
                else
                    MessageBox.Show("Esta Nota ya esta Anulado", "Anulado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando.....");

            txtBuscar.Clear();

            ListarPersonal();
            ListarTipoPermiso();
            ListarPermisoVacacion();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifPermisoVacacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
                CargarPermisoVacacion(LPerVac);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarPermisoVacacion();  
        }

        private void dtFecNota_ValueChanged(object sender, EventArgs e)
        {
            ListarPermisoVacacion();
        }

        private void dgvNotas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarPermisoVacacion(e);
        }

        private void PermisosVacaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #endregion
    }
}

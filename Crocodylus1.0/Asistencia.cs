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
using System.Globalization;
using System.Xml.Serialization;

namespace GRTechnology1._0
{
    public partial class Asistencia : Form, IAgregaPer
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OAsistencia> LAsis = null;
        List<ODetalleAsistencia> LDAsis = null;
        List<OPersonal> LPer = null;

        List<OFeriados> LFer = null;
        List<OTurnoPersonal> LTurPer = null;
        List<ODetalleTurno> LDTur = null;

        OAsistencia Asis = null;

        DateTime FecIni = DateTime.Now;
        DateTime FecFin = DateTime.Now;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        string CodAsistencia = string.Empty;

        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", 
                           "Octubre", "Noviembre", "Diciembre" };
        int[] valmes = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        #region IAgregaPer

        public void AgregaPer(string nomper)
        {
            cboPer.Text = nomper;
        }

        #endregion

        public Asistencia()
        {
            InitializeComponent();
        }

        #region Config Formulario

        private void NombreColumnasAsistencia()
        {
            dgvNotas.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Visible = false;
            dgvNotas.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Personal";
            c2.Width = 200;
            dgvNotas.Columns.Add(c2);
        }

        private void NombreColumnasDetAsistencia()
        {
            dgvAsistencia.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Dia";
            c1.Width = 60;
            dgvAsistencia.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Fecha";
            c2.Width = 90;
            dgvAsistencia.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Horario";
            c3.Width = 100;
            dgvAsistencia.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Hr. Entrada";
            c4.Width = 70;
            dgvAsistencia.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Hr. Salida";
            c5.Width = 70;
            dgvAsistencia.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Marc. Entrada";
            c6.Width = 70;
            dgvAsistencia.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Marc. Salida";
            c7.Width = 70;
            dgvAsistencia.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Tardanza";
            c8.Width = 70;
            dgvAsistencia.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "Salio Temp.";
            c9.Width = 70;
            dgvAsistencia.Columns.Add(c9);

            DataGridViewTextBoxColumn c10 = new DataGridViewTextBoxColumn();
            c10.Name = "Hr. Extra";
            c10.Width = 70;
            dgvAsistencia.Columns.Add(c10);

            DataGridViewTextBoxColumn c11 = new DataGridViewTextBoxColumn();
            c11.Name = "Hr. Permiso";
            c11.Width = 70;
            dgvAsistencia.Columns.Add(c11);

            DataGridViewTextBoxColumn c12 = new DataGridViewTextBoxColumn();
            c12.Name = "Hr. Falta";
            c12.Width = 70;
            dgvAsistencia.Columns.Add(c12);

            DataGridViewCheckBoxColumn c13 = new DataGridViewCheckBoxColumn();
            c13.Name = "Vacacion";
            c13.Width = 70;
            dgvAsistencia.Columns.Add(c13);

            DataGridViewCheckBoxColumn c14 = new DataGridViewCheckBoxColumn();
            c14.Name = "Falta";
            c14.Width = 60;
            dgvAsistencia.Columns.Add(c14);

            DataGridViewCheckBoxColumn c15 = new DataGridViewCheckBoxColumn();
            c15.Name = "Feriado";
            c15.Width = 60;
            dgvAsistencia.Columns.Add(c15);

            DataGridViewTextBoxColumn c16 = new DataGridViewTextBoxColumn();
            c16.Name = "Detalle";
            c16.Width = 200;
            dgvAsistencia.Columns.Add(c16);
        }

        private void HabilitarCon()
        {
            //Habilitamos
            //op.HabilitarCont(gbxBotones, "2.15");

            //Desabilitamos
            cboPer.Enabled = false;
            btnBuscPer.Enabled = false;
            cboMes.Enabled = false;
            cboGestion.Enabled = false;
            btnProc.Enabled = false;
        }

        private void DesabilitarCon()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            btnImp.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancel.Enabled = true;

            cboPer.Enabled = true;
            btnBuscPer.Enabled = true;
            cboMes.Enabled = true;
            cboGestion.Enabled = true;
            btnProc.Enabled = true;
        }

        #endregion

        #region Conexion Capa de Negocios

        private void ListarPersonal()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("Personal", -1).OrderBy(x => x.NomPer).ToList();
                CargarPersonal(false); // por parametro false para que me cargue todo el personal
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        private void ListarFeriados()
        {
            try
            {
                DateTime FecIni = DateTime.Now;
                DateTime FecFin = DateTime.Now;

                LFer = NFeriados.NBuscarFeriados(FecIni, FecFin);
            }
            catch (Exception)
            {            }
        }

        private void ListarTurno()
        {
            try
            {
                LTurPer = NTurnoPersonal.NListarTurPer(Convert.ToInt32(cboPer.SelectedValue));
            }
            catch (Exception)
            {

            }
        }

        private void ListarDetTurno()
        {
            try
            {
                
            }
            catch (Exception)
            {
            }
        }

        private void ListarAsistencia()
        {
            try
            {
                LAsis = NAsistencia.NListarAsistencia(-1, dtFecNota.Value.Month, dtFecNota.Value.Year);
                CargarAsistencia(LAsis);
            }
            catch (Exception)
            {
                NombreColumnasAsistencia();
                NombreColumnasDetAsistencia();
            }
        }

        private void BuscarDetAsistencia()
        {
            try
            {
                foreach (var item in NDetalleAsistencia.NBuscarDAsis(CodAsistencia))
                {
                    dgvAsistencia.Rows.Add(item.Fecha.Day, item.Fecha.ToShortDateString(), item.Horario, item.HrEntrada.ToShortTimeString(),
                                           item.HrSalida.ToShortTimeString(), item.MarcEntrada.ToShortTimeString(), item.MarcSalida.ToShortTimeString(),
                                           item.Tardanza.ToString(), item.SalioTemp, item.HrsExtras, item.HrsPermiso, item.HrsFalta, item.Vacacion,
                                           item.Falta, item.Feriado, item.Detalle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnasDetAsistencia();
            }
        }

        private void InsertModifAsistencia()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomUsu;
                inm.TipoInmode = Opcion;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                Asis = new OAsistencia();
                if(Opcion == "Nuevo")
                {
                    Asis.CodAsistencia = string.Empty;
                }
                else
                {
                    Asis.CodAsistencia = CodAsistencia;

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul("Modificar");
                    dmod.Owner = this;
                    dmod.ShowDialog();
                    inm.DetalleInmode = dmod.DetaModAnul();
                }

                Asis.Gestion = Convert.ToInt32(cboGestion.Text);
                Asis.Mes = Convert.ToInt32(cboMes.ValueMember);
                Asis.PersonalID = Convert.ToInt32(cboPer.SelectedValue);
                Asis.TotDiasExtras = Convert.ToInt32(txtDiaExtras.Text);
                Asis.TotDiasFalta = Convert.ToInt32(txtDiaFalta.Text);
                Asis.TotDiasPermiso = Convert.ToInt32(txtDiaPermi.Text);
                Asis.TotDiasTarde = Convert.ToInt32(txtDiaAtrasos.Text);
                Asis.TotDiasTemprano = Convert.ToInt32(txtDiaTempra.Text);
                Asis.TotDiasVacacion = Convert.ToInt32(txtDiaVacacion.Text);
                Asis.TotHrsExtras = Convert.ToDecimal(txtHrExtras.Text);
                Asis.TotHrsFalta = Convert.ToDecimal(txtHrFalta.Text);
                Asis.TotHrsPermiso = Convert.ToDecimal(txtHrPermi.Text);
                Asis.TotHrsTarde = Convert.ToDecimal(txtHrAtrasos.Text);
                Asis.TotHrsTemprano = Convert.ToDecimal(txtHrTempra.Text);

                int resp = NAsistencia.NInsertarModifAsistencia(Asis, InsertDetAsistencia(), inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando....");

                    Opcion = string.Empty;
                    BorrarCampos();
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

        private string InsertDetAsistencia()
        {
            string DAsis = string.Empty;
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(List<ODetalleAsistencia>));

            try
            {
                //Cargamos el Objeto
                List<ODetalleAsistencia> ldasis = new List<ODetalleAsistencia>();
                for (int i = 0; i < dgvAsistencia.Rows.Count - 1; i++)
                {
                    ODetalleAsistencia dtrasp = new ODetalleAsistencia();

                    dtrasp.CodAsistencia = CodAsistencia;
                    dtrasp.Detalle = dgvAsistencia["Detalle", i].Value.ToString();
                    dtrasp.Falta = Convert.ToBoolean(dgvAsistencia["Falta", i].Value);
                    dtrasp.Fecha = Convert.ToDateTime(dgvAsistencia["Fecha", i].Value);
                    dtrasp.Feriado = Convert.ToBoolean(dgvAsistencia["Feriado", i].Value);
                    dtrasp.Horario = dgvAsistencia["Horario", i].Value.ToString();
                    dtrasp.HrEntrada = Convert.ToDateTime(dgvAsistencia["Hr. Entrada", i].Value);
                    dtrasp.HrSalida = Convert.ToDateTime(dgvAsistencia["Hr. Salida", i].Value);
                    dtrasp.HrsExtras = Convert.ToDecimal(dgvAsistencia["Hr. Extra", i].Value);
                    dtrasp.HrsFalta = Convert.ToDecimal(dgvAsistencia["Hr. Falta", i].Value);
                    dtrasp.HrsPermiso = Convert.ToDecimal(dgvAsistencia["Hr. Permiso", i].Value);
                    dtrasp.MarcEntrada = Convert.ToDateTime(dgvAsistencia["Marc. Entrada", i].Value);
                    dtrasp.MarcSalida = Convert.ToDateTime(dgvAsistencia["Marc. Salida", i].Value);
                    dtrasp.SalioTemp = Convert.ToDecimal(dgvAsistencia["Salio Temp.", i].Value);
                    dtrasp.Tardanza = Convert.ToDecimal(dgvAsistencia["Tardanza.", i].Value);
                    dtrasp.Vacacion = Convert.ToBoolean(dgvAsistencia["Vacacion", i].Value);
                    
                    dtrasp.Estado = true;

                    ldasis.Add(dtrasp);
                }
                serializer.Serialize(stringwriter, ldasis);
            }
            catch (System.Xml.XmlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DAsis = stringwriter.ToString();
                DAsis = DAsis.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            }

            return DAsis;
        }

        private void Procesar()
        {
            try
            {
                //Listamos datos de la DB
                ListarFeriados();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarPersonal(bool estado)
        {
            if(estado)
            {
                List<OPersonal> LPerHabil = LPer.Where(x => x.Estado).ToList();

                cboPer.DataSource = LPerHabil;
                cboPer.DisplayMember = "NomPer";
                cboPer.ValueMember = "PersonalID";
                cboPer.Refresh();
            }
            else
            {
                cboPer.DataSource = LPer;
                cboPer.DisplayMember = "NomPer";
                cboPer.ValueMember = "PersonalID";
                cboPer.Refresh();
            }
        }

        private void CargarSelec()
        {
            if(Asis != null)
            {
                cboPer.Text = Asis.NomPer;
                cboMes.Text = Asis.Mes.ToString();
                cboGestion.Text = Asis.Gestion.ToString();
                //dias
                txtDiaAtrasos.Text = string.Format("", Asis.TotDiasTarde);
                txtDiaExtras.Text = string.Format("", Asis.TotDiasExtras);
                txtDiaFalta.Text = string.Format("", Asis.TotDiasFalta);
                txtDiaPermi.Text = string.Format("", Asis.TotDiasPermiso);
                txtDiaTempra.Text = string.Format("", Asis.TotDiasTemprano);
                txtDiaVacacion.Text = string.Format("", Asis.TotDiasVacacion);
                //horas
                txtHrAtrasos.Text = string.Format("", Asis.TotHrsTarde);
                txtHrExtras.Text = string.Format("", Asis.TotHrsExtras);
                txtHrFalta.Text = string.Format("", Asis.TotHrsFalta);
                txtHrPermi.Text = string.Format("", Asis.TotHrsPermiso);
                txtHrTempra.Text = string.Format("", Asis.TotHrsTemprano);
                
            }
        }

        private void CargarAsistencia(List<OAsistencia> lasis)
        {
            if(lasis != null)
            {
                NombreColumnasAsistencia();
                NombreColumnasDetAsistencia();

                foreach (var item in lasis)
                {
                    dgvNotas.Rows.Add(item.CodAsistencia, item.NomPer);
                }
            }
            else
            {
                NombreColumnasAsistencia();
                NombreColumnasDetAsistencia();
            }
        }

        private void SeleccionarNota(DataGridViewCellEventArgs e)
        {
            try
            {
                if(Opcion == string.Empty)
                {
                    CodAsistencia = dgvNotas["Codigo", e.RowIndex].Value.ToString();

                    CargarSelec();
                    BuscarDetAsistencia();
                }
            }
            catch (Exception)
            {
                CodAsistencia = string.Empty;
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos()
        {
            op.BorrarCampos(gbxDias, "0");
            op.BorrarCampos(gbxHrs, "0.00");
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                CargarPersonal(false); //por parametro false para que me cargue todo el personal
                NombreColumnasDetAsistencia();
                HabilitarCon();
            }
        }

        private void Registro()
        {
            if(CodAsistencia == string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos Formulario

        private void Asistencia_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            cboGestion.Text = DateTime.Now.Year.ToString();
            HabilitarCon();

            ListarPersonal();
            ListarAsistencia();
            
            op.CerrarCargando();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Opcion = "Nuevo";
            BorrarCampos();
            CargarPersonal(true); //por parametro true para que me cargue los de estado 1
            DesabilitarCon();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Opcion = "Modificar";
            DesabilitarCon();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarPersonal();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifAsistencia();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void btnBuscPer_Click(object sender, EventArgs e)
        {
           
        }

        private void Asistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dtFecNota_ValueChanged(object sender, EventArgs e)
        {
            ListarAsistencia();
        }

        private void dtNotas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarNota(e);
        }

        private void cboMesPla_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboMes.Items.Count == 12)
            {
                NombreColumnasDetAsistencia();
            }
        }

        private void cboGestionPla_SelectedValueChanged(object sender, EventArgs e)
        {
            NombreColumnasDetAsistencia();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            OpcioRep.OpRepRegAsistencia rasis = new OpcioRep.OpRepRegAsistencia();
            rasis.Owner = this;
            rasis.ShowDialog();
        }

        #endregion
    }
}

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
    public partial class TurnoPersonal : Form, IAgregaTurno
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OPersonal> LPer = null;
        List<OPersonal> LBusqPer = null;
        List<OTurnoPersonal> LTurPer = null;
        List<ODetalleTurno> LDTur = null;

        string CodInmode = string.Empty;
        
        int PersonalID = -1;
        int TurnoID = -1;

        #region IAgregaTurno

        public  void AgregaTurno(int turnoid, string nomturno)
        {
            CargarTurnoCombo(turnoid, nomturno);
        }

        #endregion

        public TurnoPersonal()
        {
            InitializeComponent();
        }

        #region Conf. Formulario

        private void NombreColumnasPersonal()
        {
            dgvPersonal.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "PersonalID";
            c0.Visible = false;
            dgvPersonal.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Personal";
            c1.Width = 150;
            dgvPersonal.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Cargo";
            c2.Width = 100;
            dgvPersonal.Columns.Add(c2);
        }

        private void NombreColumnasTurno()
        {
            dgvTurno.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "TurnoID";
            c1.Visible = false;
            dgvTurno.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Turno";
            c2.Width = 90;
            dgvTurno.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fec. Inicial";
            c3.Width = 90;
            dgvTurno.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Fec. Final";
            c4.Width = 90;
            dgvTurno.Columns.Add(c4);

            DataGridViewCheckBoxColumn c5 = new DataGridViewCheckBoxColumn();
            c5.Name = "Hrs. Extra";
            c5.Width = 50;
            dgvTurno.Columns.Add(c5);
        }

        private void NombreColumnasDetTurno()
        {
            dgvDetTurno.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Dia";
            c1.Width = 90;
            dgvDetTurno.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Horario";
            c2.Width = 150;
            dgvDetTurno.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Hr. Entrada";
            c3.Width = 60;
            dgvDetTurno.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Hr. Salida";
            c4.Width = 60;
            dgvDetTurno.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Valor";
            c5.Width = 50;
            dgvDetTurno.Columns.Add(c5);

            DataGridViewCheckBoxColumn c6 = new DataGridViewCheckBoxColumn();
            c6.Name = "Estado";
            c6.Width = 60;
            dgvDetTurno.Columns.Add(c6);

            //Agregamos las Filas
            dgvDetTurno.Rows.Add("DOM");
            dgvDetTurno.Rows.Add("LUN");
            dgvDetTurno.Rows.Add("MAR");
            dgvDetTurno.Rows.Add("MIÉ");
            dgvDetTurno.Rows.Add("JUE");
            dgvDetTurno.Rows.Add("VIE");
            dgvDetTurno.Rows.Add("SÁB");
        }

        #endregion

        #region Conexion Capa de Negocio

        private void ListarPer()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("Personal", -1).OrderBy(x => x.NomPer).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTurPer()
        {
            try
            {
                LTurPer = NTurnoPersonal.NListarTurPer(-1); //mandamos por parametro -1 para q liste el turno de todo el personal
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                NombreColumnasTurno();
            }
        }

        private void ListarDetTurno()
        {
            try
            {
                LDTur = NDetalleTurno.NBuscarDetTurno(TurnoID);
                CargarDetTurnoPer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModifTurPer()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.TipoInmode = "Nuevo";
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                OTurnoPersonal TurPer = new OTurnoPersonal();
                TurPer.FecInicial = dtFecIni.Value;
                TurPer.FecFinal = dtFecFin.Value;
                TurPer.TurnoID = Convert.ToInt32(cboTurno.ValueMember);
                TurPer.PersonalID = Convert.ToInt32(dgvPersonal["PersonalID", dgvPersonal.CurrentRow.Index].Value);
                TurPer.HrsExt = ckbxHrsExt.Checked;

                int resp = NTurnoPersonal.NInsertModifTurPer(TurPer, inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    ListarTurPer();
                    CargarPersonal(LBusqPer);
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

        private void AnularTurPer()
        {
            try
            {
                string nomturper = dgvTurno["Turno", dgvTurno.CurrentRow.Index].Value.ToString();

                DialogResult dialogo = MessageBox.Show("¿Seguro que desea quitar el Turno " + nomturper + "?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(dialogo == DialogResult.Yes)
                {
                    OInmode inm = new OInmode();
                    inm.CodInmode = CodInmode;
                    inm.TipoInmode = "Nuevo";
                    inm.UsuarioID = OConexionGlobal.UsuarioID;
                    inm.NomInmode = OConexionGlobal.NomPer;
                    inm.IPInmode = op.SaberIP();
                    inm.MacInmode = op.SaberMac();
                    inm.MaquinaInmode = op.SaberNomMaquina();
                    inm.SistOperInmode = op.SaberSistemOper();
                   
                    Frm_DetaModifAnul mod = new Frm_DetaModifAnul("Quitar Turno");
                    mod.Owner = this;
                    mod.ShowDialog();
                    inm.DetalleInmode = mod.DetaModAnul();

                    int perid = Convert.ToInt32(dgvPersonal["PersonalID", dgvPersonal.CurrentRow.Index].Value);
                    int turid = Convert.ToInt32(dgvTurno["TurnoID", dgvTurno.CurrentRow.Index].Value);

                    int resp = NTurnoPersonal.NAnulTurPer(perid, turid, inm);
                    if(resp > 0)
                    {
                        MessageBox.Show("Se anulo correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando");

                        ListarTurPer();
                        CargarPersonal(LBusqPer);
                    }
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

        private void CargarPersonal(List<OPersonal> lper)
        {
            if (lper != null)
            {
                NombreColumnasPersonal();

                int cont = 0;
                foreach (var item in lper)
                {
                    dgvPersonal.Rows.Add(item.PersonalID, item.NomPer, item.NomCargo);

                    if (!item.Estado)
                        dgvPersonal.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
            }
            else
            {
                NombreColumnasPersonal();
            }
        }

        private void CargarDetTurnoPer()
        {
            if(LDTur != null)
            {
                NombreColumnasDetTurno();

                for (int i = 0; i < dgvDetTurno.Rows.Count - 1; i++)
                {
                    string dia = dgvDetTurno["Dia", i].Value.ToString();

                    ODetalleTurno dturn = LDTur.Find(x => x.NomDia == dia);
                    if (dturn != null)
                    {
                        dgvDetTurno["Horario", i].Value = dturn.NomHorario;
                        dgvDetTurno["Hr. Entrada", i].Value = dturn.HrEntrada.ToShortTimeString();
                        dgvDetTurno["Hr. Salida", i].Value = dturn.HrSalida.ToShortTimeString();
                        dgvDetTurno["Valor", i].Value = dturn.ValorDiaTrab;
                        dgvDetTurno["Estado", i].Value = dturn.EstadoDTurno;
                    }
                }
            }
            else
            {
                NombreColumnasDetTurno();
            }
        }

        private void CargarTurnoCombo(int turnoid, string nomturno)
        {
            cboTurno.Items.Clear();
            cboTurno.Items.Add(nomturno);
            cboTurno.ValueMember = turnoid.ToString();
            cboTurno.Text = nomturno;
        }

        private void BuscarTurPer()
        {
            if(txtBuscador.Text != string.Empty)
            {
                if (LPer != null)
                {
                    List<OPersonal> lbusper = LBusqPer.FindAll(x => x.NomPer.ToUpper().Contains(txtBuscador.Text.ToUpper()));
                    CargarPersonal(lbusper);
                }
            }
            else
            {
                CargarPersonal(LBusqPer);
            }
        }

        private void SeleccionarPer(DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex > -1)
                {
                    NombreColumnasTurno();
                    NombreColumnasDetTurno();

                    PersonalID = Convert.ToInt32(dgvPersonal["PersonalID", e.RowIndex].Value);
                    List<OTurnoPersonal> lturper = LTurPer.FindAll(x => x.PersonalID == PersonalID);
                    if(lturper.Count > 0)
                    {
                        foreach (var item in lturper)
                        {
                            dgvTurno.Rows.Add(item.TurnoID, item.NomTurno, item.FecInicial.ToShortDateString(), item.FecFinal.ToShortDateString(), item.HrsExt);    
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se asigno ningun turno a este personal");

                        dtFecIni.Value = DateTime.Now;
                        dtFecFin.Value = DateTime.Now;
                        cboTurno.Items.Clear();
                        ckbxHrsExt.Checked = false;
                    }
                }
            }
            catch (Exception)
            {
                NombreColumnasTurno();
                NombreColumnasDetTurno();
            }
        }

        private void SeleccionarTurnoPer(DataGridViewCellEventArgs e)
        {
            try
            {
                NombreColumnasDetTurno();

                TurnoID = Convert.ToInt32(dgvTurno["TurnoID", e.RowIndex].Value);
                OTurnoPersonal turper = LTurPer.Find(x => (x.PersonalID == PersonalID) && (x.TurnoID == TurnoID));
                if (turper != null)
                {
                    dtFecIni.Value = turper.FecInicial;
                    dtFecFin.Value = turper.FecFinal;
                    ckbxHrsExt.Checked = turper.HrsExt;

                    //cargamos el turno seleccionado
                    CargarTurnoCombo(turper.TurnoID, turper.NomTurno);

                    //buscamos el detalle del turno
                    ListarDetTurno();
                }
                else
                {
                    cboTurno.Items.Clear();
                }
            }
            catch (Exception)
            {
                NombreColumnasDetTurno();
            }
        }

        #endregion

        #region Eventos Formulario

        private void TurnoPersonal_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarPer();
            ListarTurPer();
            cboFiltroPer.Text = "Personal Habilitado";

            op.CerrarCargando();
        }

        private void TurnoPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dgvPersonal_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarPer(e);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarTurPer();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
            catch (Exception)
            { }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarPer();
            ListarTurPer();

            op.CerrarCargando();
        }

        private void btnAsigTur_Click(object sender, EventArgs e)
        {
            InsertModifTurPer();
        }

        private void btnAgrTurno_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvTurno_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarTurnoPer(e);
        }

        private void cboFiltroPer_SelectedValueChanged(object sender, EventArgs e)
        {
            if(LPer != null)
            {
                switch(cboFiltroPer.Text)
                {
                    case "Todo el Personal":
                        LBusqPer = LPer;
                        break;
                    case "Personal Habilitado":
                        LBusqPer = LPer.FindAll(x => x.Estado);
                        break;
                    case "Personal Desabilitado":
                        LBusqPer = LPer.FindAll(x => !x.Estado);
                        break;
                }
               
               CargarPersonal(LBusqPer);
            }
        }

        private void btnQuitarTurno_Click(object sender, EventArgs e)
        {
            AnularTurPer();
        }

        #endregion
    }
}

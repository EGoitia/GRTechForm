using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Objetos;
using Negocio;
using System.Xml.Serialization;

namespace GRTechnology1._0
{
    public partial class Turno : Form, IAgregaHorario
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OTurnos> LTurno = null;
        List<ODetalleTurno> LDTurno = null;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        bool Estado = false;

        #region IAgregaHorario

        public void AgregaHorario(OHorario ohor)
        {
            int fila = dgvDetTurno.CurrentRow.Index;

            dgvDetTurno["HorarioID", fila].Value = ohor.HorarioID;
            dgvDetTurno["Horario", fila].Value = ohor.NomHorario;
            dgvDetTurno["Hr. Entrada", fila].Value = ohor.HrEntrada.ToShortTimeString();
            dgvDetTurno["Hr. Salida", fila].Value = ohor.HrSalida.ToShortTimeString();
            dgvDetTurno["Valor", fila].Value = ohor.ValorDiaTrab;
            dgvDetTurno["Estado", fila].Value = true;
        }

        #endregion

        public Turno()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnasDetTurno()
        {
            dgvDetTurno.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "HorarioID";
            c0.Visible = false;
            dgvDetTurno.Columns.Add(c0);

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
            dgvDetTurno.Rows.Add(-1, "DOM");
            dgvDetTurno.Rows.Add(-1, "LUN");
            dgvDetTurno.Rows.Add(-1, "MAR");
            dgvDetTurno.Rows.Add(-1, "MIÉ");
            dgvDetTurno.Rows.Add(-1, "JUE");
            dgvDetTurno.Rows.Add(-1, "VIE");
            dgvDetTurno.Rows.Add(-1, "SÁB");
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
            c2.Width = 200;
            dgvTurno.Columns.Add(c2);
        }

        private void HabilitarCont()
        {
            //op.HabilitarCont(gbxBotones, "2.10");

            txtNomTurno.ReadOnly = true;
        }

        private void DesabilitarCont()
        {
            //DEsabilitamos controles
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            btnReg.Enabled = false;
            btnAct.Enabled = false;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNomTurno.ReadOnly = false;
        }

        #endregion

        #region Conexion Capa NEgocio

        private void ListarTurnos()
        {
            try
            {
                LTurno = NTurno.NListarTurno();
                CargarTurnos();
            }
            catch (Exception)
            {
                NombreColumnasTurno();
                NombreColumnasDetTurno();
            }
        }

        private void BuscarDetTurno()
        {
            try
            {
                NombreColumnasDetTurno();
                LDTurno = NDetalleTurno.NBuscarDetTurno(Convert.ToInt32(txtTurnoID.Text));

                for (int i = 0; i < dgvDetTurno.Rows.Count -1; i++)
                {
                    string dia = dgvDetTurno["Dia", i].Value.ToString();

                    ODetalleTurno dturn = LDTurno.Find(x => x.NomDia == dia);
                    if(dturn != null)
                    {
                        dgvDetTurno["HorarioID", i].Value = dturn.HorarioID;
                        dgvDetTurno["Horario", i].Value = dturn.NomHorario;
                        dgvDetTurno["Hr. Entrada", i].Value = dturn.HrEntrada.ToShortTimeString();
                        dgvDetTurno["Hr. Salida", i].Value = dturn.HrSalida.ToShortTimeString();
                        dgvDetTurno["Valor", i].Value = dturn.ValorDiaTrab;
                        dgvDetTurno["Estado", i].Value = dturn.EstadoDTurno;
                    }
                }
            }
            catch (Exception)
            {
                NombreColumnasDetTurno();
            }
        }

        private void InsertModifTurno()
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

                OTurnos OTurn = new OTurnos();
                if(Opcion == "Nuevo")
                {
                    OTurn.TurnoID = -1;
                }
                else
                {
                    OTurn.TurnoID = Convert.ToInt32(txtTurnoID.Text);

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul("Modificar");
                    dmod.Owner = this;
                    dmod.ShowDialog();
                    inm.DetalleInmode = dmod.DetaModAnul();
                }

                OTurn.NomTurno = txtNomTurno.Text;
                OTurn.UnidCiclo = "";

                int resp = NTurno.NInsertModifTurno(OTurn, InsertDetTurno(), inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los Datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando....");

                    Opcion = string.Empty;
                    BorrarCampos();
                    ListarTurnos();
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

        private string InsertDetTurno()
        {
            string DTurn = string.Empty;
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(List<ODetalleTurno>));

            try
            {
                //Cargamos el Objeto
                List<ODetalleTurno> ldturn = new List<ODetalleTurno>();
                for (int i = 0; i < dgvDetTurno.Rows.Count - 1; i++)
                {
                    ODetalleTurno dturn = new ODetalleTurno();

                    dturn.HorarioID = Convert.ToInt32(dgvDetTurno["HorarioID", i].Value);
                    dturn.NomDia = dgvDetTurno["Dia", i].Value.ToString();
                    dturn.EstadoDTurno = Convert.ToBoolean(dgvDetTurno["Estado", i].Value);

                    ldturn.Add(dturn);
                }
                serializer.Serialize(stringwriter, ldturn);
            }
            catch (System.Xml.XmlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DTurn = stringwriter.ToString();
                DTurn = DTurn.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            }

            return DTurn;
        }

        private void AnulRestauTurno(string opc, int estado)
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea + " + opc + "?", opc + " Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
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

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul( opc + " Turno");
                    dmod.Owner = this;
                    dmod.ShowDialog();
                    inm.DetalleInmode = dmod.DetaModAnul();

                    int resp = NTurno.NAnulRestauTurno(txtTurnoID.Text, "Turno", estado, inm);
                    if(resp > 0)
                    {
                        MessageBox.Show("El Turno se " + opc + " correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarTurnos();
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

        private void CargarTurnos()
        {
            if(LTurno != null)
            {
                NombreColumnasTurno();

                int cont = 0;
                foreach (var item in LTurno)
                {
                    dgvTurno.Rows.Add(item.TurnoID, item.NomTurno);

                    if (!item.Estado)
                        dgvTurno.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
            }
            else
            {
                NombreColumnasTurno();
                NombreColumnasDetTurno();
            }
        }

        private void SeleccionarTurno(DataGridViewCellEventArgs e)
        {
            if((e.RowIndex > -1) && (Opcion == string.Empty))
            {
                try
                {
                    txtTurnoID.Text = dgvTurno["TurnoID", e.RowIndex].Value.ToString();

                    OTurnos tur = LTurno.Find(x => x.TurnoID.ToString() == txtTurnoID.Text);
                    if(tur != null)
                    {
                        txtNomTurno.Text = tur.NomTurno;
                        
                        CodInmode = tur.CodInmode;
                        Estado = tur.Estado;
                    }
                    
                    BuscarDetTurno();
                }
                catch (Exception)
                {       }
            }
        }

        #endregion

        #region Funciones

        private void BuscarHorarios()
        {
            try
            {
                int fila = dgvDetTurno.CurrentRow.Index;

                if ((Opcion != string.Empty) && (dgvDetTurno["Dia", fila].Value != null) && (fila > -1))
                {
                   
                }
            }
            catch (Exception)
            {    }
            
        }

        private void BorrarCampos()
        {
            txtTurnoID.Clear();
            txtNomTurno.Clear();

            NombreColumnasDetTurno();
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            BorrarCampos();
            DesabilitarCont();
        }

        private void Modif()
        {
            Opcion = "Modificar";
            DesabilitarCont();
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo==DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                CargarTurnos();
                HabilitarCont();
            }
        }

        private void Registro()
        {
            if(txtTurnoID.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos Formulario

        private void Turno_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarTurnos();
            HabilitarCont();

            op.CerrarCargando();
        }

        private void Turno_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dgvTurno_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarTurno(e);
        }

        private void dgvDetTurno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarHorarios();
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
            //if(txtTurnoID.Text != string.Empty)
            //{
            //    if (Estado)
            //        AnulRestauTurno("Anular", 0);
            //    else
            //        MessageBox.Show("El Turno ya esta Anulado", "Anulado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifTurno();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void dgvDetTurno_KeyDown(object sender, KeyEventArgs e)
        {
            if (Opcion != string.Empty)
            {
                if ((e.KeyCode == Keys.Escape) || (e.KeyCode == Keys.Delete))
                {
                    DialogResult result = MessageBox.Show("Esta seguro que desea Borrar esta Fila?", "Borrar Fila",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            int fila = dgvDetTurno.CurrentRow.Index;

                            dgvDetTurno["HorarioID", fila].Value = -1;
                            dgvDetTurno["Horario", fila].Value = "";
                            dgvDetTurno["Hr. Entrada", fila].Value = "";
                            dgvDetTurno["Hr. Salida", fila].Value = "";
                            dgvDetTurno["Valor", fila].Value = "";
                            dgvDetTurno["Estado", fila].Value = false;
                        }
                        catch
                        { }
                    }
                }
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            //if (txtTurnoID.Text != string.Empty)
            //{
            //    if (!Estado)
            //        AnulRestauTurno("Restaurar", 1);
            //    else
            //        MessageBox.Show("El Turno ya esta Habilitado", "Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarTurnos();

            op.CerrarCargando();
        }

        #endregion
    }
}

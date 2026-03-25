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
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace GRTechnology1._0
{
    public partial class Marcaciones : Form, IAgregaPer
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OPersonal> LPer = null;
        List<OMarcaciones> LMarc = null;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;

        #region IAgregaPer

        public void AgregaPer(string nomper)
        {
            cboPersonal.Text = nomper;
        }

        #endregion

        public Marcaciones()
        {
            InitializeComponent();
        }

        #region Config. Formulario

        private void NombreColumnasDetalle()
        {
            dgvMarcaciones.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Personal";
            c1.Width = 150;
            dgvMarcaciones.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Fecha";
            c2.Width = 150;
            dgvMarcaciones.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Tipo Marcacion";
            c3.Width = 90;
            dgvMarcaciones.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Observacion";
            c4.Width = 250;
            dgvMarcaciones.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "CodInmode";
            c5.Visible = false;
            dgvMarcaciones.Columns.Add(c5);
        }

        private void HabilitarCont()
        {
            //op.HabilitarCont(gbxBotones, "2.12");

            dtFecha.Enabled = true;
            ckbxFilPer.Enabled = true;
            ckbxFilPer.Checked = false;

            //Desabilitamos controles
            cboPersonal.Enabled = false;
            btnBusqPer.Enabled = false;
            btnPegar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;

            dtFecha.Enabled = false;
            ckbxFilPer.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            //habilitamos controles
            btnPegar.Enabled = true;
            btnBorrar.Enabled = true;
        }

        #endregion

        #region Conexion Capa de Negocios

        private void ListarPer()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("Personal", -1);
                CargarPer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void ListarMarcaciones()
        {
            try
            {
                LMarc = NMarcaciones.NListarMarcaciones(dtFecha.Value).OrderBy(x => x.NomPer).ToList();
                CargarMarcaciones(LMarc);
            }
            catch (Exception)
            {
                NombreColumnasDetalle();
                LMarc = null;
            }
        }

        private void InsertModifMarcaciones()
        {
            try
            {
                if(dgvMarcaciones.Rows.Count > 1)
                {
                    string Marc = string.Empty;
                    var stringwriter = new System.IO.StringWriter();
                    var serializer = new XmlSerializer(typeof(List<OMarcaciones>));

                    try
                    {
                        //Cargamos el Objeto
                        List<OMarcaciones> lmarc = new List<OMarcaciones>();
                        for (int i = 0; i < dgvMarcaciones.Rows.Count - 1; i++)
                        {
                            OMarcaciones marc = new OMarcaciones();

                            marc.NomPer = dgvMarcaciones["Personal", i].Value.ToString();
                            marc.Fecha = Convert.ToDateTime(dgvMarcaciones["Fecha", i].Value);
                            marc.TipoMarcacion = dgvMarcaciones["Tipo Marcacion", i].Value.ToString();
                            marc.Observacion = dgvMarcaciones["Observacion", i].Value.ToString();
                            marc.Estado = true;

                            lmarc.Add(marc);
                        }
                        serializer.Serialize(stringwriter, lmarc);
                        Marc = stringwriter.ToString();
                        Marc = Marc.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");

                        //Inmode
                        OInmode inm = new OInmode();
                        inm.CodInmode = CodInmode;
                        inm.TipoInmode = Opcion;
                        inm.UsuarioID = OConexionGlobal.UsuarioID;
                        inm.NomInmode = OConexionGlobal.NomPer;
                        inm.IPInmode = op.SaberIP();
                        inm.MacInmode = op.SaberMac();
                        inm.MaquinaInmode = op.SaberNomMaquina();
                        inm.SistOperInmode = op.SaberSistemOper();

                        int resp = NMarcaciones.NInsertModifMarcaciones(Marc, inm);
                        if(resp > 0)
                        {
                            MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            op.AbrirCargando("Cargando....");

                            ListarMarcaciones();
                            HabilitarCont();
                        }
                    }
                    catch(System.Xml.XmlException e)
                    {
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        op.CerrarCargando();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarPer()
        {
            if(LPer !=null)
            {
                List<OPersonal> lper = LPer.OrderBy(x => x.NomPer).ToList();

                cboPersonal.DataSource = lper;
                cboPersonal.DisplayMember = "NomPer";
                cboPersonal.ValueMember = "PersonalID";
                cboPersonal.Refresh();
            }
        }

        private void CargarMarcaciones(List<OMarcaciones> lmarc)
        {
            if (lmarc != null)
            {
                NombreColumnasDetalle();

                int cont = 0;
                foreach (var item in lmarc)
                {
                    dgvMarcaciones.Rows.Add(item.NomPer, item.Fecha, item.TipoMarcacion, item.Observacion, item.CodInmode);

                    if (!item.Estado)
                        dgvMarcaciones.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvMarcaciones.Refresh();
            }
        }

        private void FiltarXPersonal()
        {
            if(LMarc != null)
            {
                List<OMarcaciones> lbusqmarc = LMarc.Where(x => x.PersonalID == Convert.ToInt32(cboPersonal.SelectedValue)).OrderBy(x => x.Fecha).ToList();
                CargarMarcaciones(lbusqmarc);
            }
        }

        #endregion

        #region Funciones

        private void Nuevo()
        {
            Opcion = "Nuevo";
            NombreColumnasDetalle();
            DesabilitarCont();
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo==DialogResult.Yes)
            {
                Opcion = string.Empty;
                HabilitarCont();
                NombreColumnasDetalle();
                CargarMarcaciones(LMarc);
            }
        }

        private void Pegar()
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                int rowOfInterest = dgvMarcaciones.CurrentCell.RowIndex;
                string[] selectedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");

                if (selectedRows == null || selectedRows.Length == 0)
                    return;

                foreach (string row in selectedRows)
                {
                    if (rowOfInterest >= dgvMarcaciones.Rows.Count)
                        break;

                    try
                    {
                        dgvMarcaciones.Rows.Add("", "", "", "");

                        string[] data = Regex.Split(row, "\t");
                        int col = dgvMarcaciones.CurrentCell.ColumnIndex;

                        foreach (string ob in data)
                        {
                            if (col >= dgvMarcaciones.Columns.Count)
                                break;
                            if (ob != null)
                                dgvMarcaciones[col, rowOfInterest].Value = Convert.ChangeType(ob, dgvMarcaciones[col, rowOfInterest].ValueType);
                            col++;
                        }
                    }
                    catch (Exception)
                    {
                        //do something here 
                    }
                    rowOfInterest++;
                }
            }
        }

        private void Registro()
        {
            if(CodInmode != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos Formulario

        private void Marcaciones_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            NombreColumnasDetalle();
            ListarPer();
            ListarMarcaciones();
            HabilitarCont();

            op.CerrarCargando();
        }

        private void Marcaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarPer();
            ListarMarcaciones();

            if (ckbxFilPer.Checked)
                FiltarXPersonal();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifMarcaciones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnBusqPer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            Pegar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            NombreColumnasDetalle();
            dgvMarcaciones.Focus();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void ckbxFilPer_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbxFilPer.Checked)
            {
                cboPersonal.Enabled = true;
                btnBusqPer.Enabled = true;

                FiltarXPersonal();
            }
            else
            {
                cboPersonal.Enabled = false;
                btnBusqPer.Enabled = false;

                CargarMarcaciones(LMarc);
            }
        }

        private void cboPersonal_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltarXPersonal();
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            ListarMarcaciones();

            if (ckbxFilPer.Checked)
                FiltarXPersonal();
        }

        private void dgvMarcaciones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CodInmode = dgvMarcaciones["CodInmode", e.RowIndex].Value.ToString();
            }
            catch (Exception)
            {
                CodInmode = string.Empty;
            }
        }

        #endregion
    }
}

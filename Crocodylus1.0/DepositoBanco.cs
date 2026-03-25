using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Objetos;
using Negocio;
using System.IO;

namespace GRTechnology1._0
{
    public partial class DepositoBanco : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OBanco> LBan = null;
        List<OCaja> LCaj = null;
        List<ODepositoBanco> LDepBan = null;
        List<ODepositoBanco> LBusqDepBan = null;

        ODepositoBanco ODepBan = null;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        string CodAsiento = string.Empty;
        bool Estado = false;

        public DepositoBanco()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnas()
        {
            dgvDepBanco.Columns.Clear();

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Codigo";
            c2.Width = 60;
            dgvDepBanco.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 100;
            dgvDepBanco.Columns.Add(c3);
        }

        private void HabilitarCont()
        {
            //habilitamos segun la DB
            //op.HabilitarCont(gbxBotones, "8.08");
            //op.HabilitarCont(gbxCajas, "8.08");

            dtFecNota.Enabled = true;

            //Desabilitamos
            btnCargarImg.Enabled = false;
            btnBorrarImg.Enabled = false;

            txtDepositante.ReadOnly = true;
            txtDet.ReadOnly = true;
            txtNoComp.ReadOnly = true;
            cboBanco.Enabled = false;
            
            numUpDownMontoBs.Enabled = false;
            numUpDownMontoSus.Enabled = false;
            numUpDownTC.Enabled = false;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            btnAsiento.Enabled = false;

            txtBuscar.Enabled = false;
            cboTipoBusq.Enabled = false;

            cboCaja.Enabled = false;
            btnProc.Enabled = false;

            dtFecNota.Enabled = false;

            //habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            btnCargarImg.Enabled = true;
            btnBorrarImg.Enabled = true;

            cboBanco.Enabled = true;
            numUpDownMontoBs.Enabled = true;
            numUpDownMontoSus.Enabled = true;
            numUpDownTC.Enabled = true;
            txtDepositante.ReadOnly = false;
            txtNoComp.ReadOnly = false;
            txtDet.ReadOnly = false;
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarBancos()
        {
            try
            {
                LBan = NBanco.NListarBancos();

                cboBanco.DataSource = LBan;
                cboBanco.DisplayMember = "NomBanco";
                cboBanco.ValueMember = "BancoID";
                cboBanco.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCajas()
        {
            //try
            //{
            //    LCaj = NCaja.NListarCaja(OConexionGlobal.SucursalID, OConexionGlobal.UsuarioID, "Cajas Usuario");

            //    cboCaja.DataSource = LCaj;
            //    cboCaja.DisplayMember = "NomCaja";
            //    cboCaja.ValueMember = "CajaID";
            //    cboCaja.Refresh();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void ListarDepBanco()
        {
            try
            {
                LDepBan = NDepositoBanco.NListarDepBanco(Convert.ToInt32(cboCaja.SelectedValue), dtFecNota.Value);
                CargarDepBanco(LDepBan);
            }
            catch (Exception)
            {
                NombreColumnas();
            }
        }

        private void BuscarDepBanco()
        {
            try
            {
                if(txtBuscar.Text != string.Empty)
                {
                    LBusqDepBan = NDepositoBanco.NBuscarDepBanco(txtBuscar.Text, cboTipoBusq.Text, dtFecNota.Value, Convert.ToInt32(cboCaja.SelectedValue));
                    CargarDepBanco(LBusqDepBan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnularDepBanco()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Anular el Deposito " + txtCodigo.Text + "?", "Anular", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
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

                    Frm_DetaModifAnul anul = new Frm_DetaModifAnul("Anular");
                    anul.Owner = this;
                    anul.ShowDialog();
                    inm.DetalleInmode = anul.DetaModAnul();

                    int resp = NDepositoBanco.NAnulRestauDepBanco(txtCodigo.Text, "DepositoBanco", 0, inm);
                    if(resp > 0)
                    {
                        MessageBox.Show("Los Datos se Anularon Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando....");

                        ListarDepBanco();
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

        private void InsertModifDepBanco()
        {
            try
            {
                if((numUpDownMontoBs.Value > 0) || (numUpDownMontoSus.Value > 0))
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

                    ODepBan = new ODepositoBanco();
                    if (Opcion == "Nuevo")
                    {
                        ODepBan.DepBancoID = -1;
                    }
                    else
                    {
                        ODepBan.DepBancoID = Convert.ToInt32(txtCodigo.Text);

                        Frm_DetaModifAnul modif = new Frm_DetaModifAnul("Modificar");
                        modif.Owner = this;
                        modif.ShowDialog();
                        inm.DetalleInmode = modif.DetaModAnul();
                    }

                    ODepBan.BancoID = Convert.ToInt32(cboBanco.SelectedValue);
                    ODepBan.CajaSalID = Convert.ToInt32(cboCaja.SelectedValue);
                    ODepBan.Detalle = txtDet.Text;
                    ODepBan.NumComprobante = txtNoComp.Text;
                    ODepBan.Depositante = txtDepositante.Text;
                    ODepBan.MontoBs = numUpDownMontoBs.Value;
                    ODepBan.MontoSus = numUpDownMontoSus.Value;
                    ODepBan.TC = numUpDownTC.Value;

                    //Cargamos la Imagen
                    MemoryStream m_MemoryStream = new MemoryStream();
                    pbxImg.Image.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ODepBan.Img = m_MemoryStream.ToArray();

                    int resp = NDepositoBanco.NInsertModifDepBanco(ODepBan, inm);
                    if (resp > 0)
                    {
                        MessageBox.Show("Lis datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando.....");

                        Opcion = string.Empty;
                        BorrarCampos();
                        ListarDepBanco();
                        HabilitarCont();
                    }
                }
                else
                {
                    MessageBox.Show("El Monto en Bs o en Sus tiene que ser mayor a cero", "Deposito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void CargarDepBanco(List<ODepositoBanco> ldban)
        {
            if(ldban != null)
            {
                NombreColumnas();

                int cont = 0;
                foreach (var item in ldban)
                {
                    dgvDepBanco.Rows.Add(item.DepBancoID, item.Fecha.ToShortDateString());

                    if (!item.Estado)
                        dgvDepBanco.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
            }
            else
            {
                NombreColumnas();
            }
        }

        private void SeleccionarDepBanco(DataGridViewCellEventArgs e)
        {
            if(LDepBan != null)
            {
                if((e.RowIndex > -1) && (Opcion == string.Empty))
                {
                    try
                    {
                        txtCodigo.Text = dgvDepBanco["Codigo", e.RowIndex].Value.ToString();

                        if(txtBuscar.Text == string.Empty)
                            ODepBan = LDepBan.Find(x => x.DepBancoID.ToString() == txtCodigo.Text);
                        else
                            ODepBan = LBusqDepBan.Find(x => x.DepBancoID.ToString() == txtCodigo.Text);

                        if (ODepBan != null)
                        {
                            cboBanco.Text = ODepBan.NomBanco;
                            numUpDownMontoBs.Value = ODepBan.MontoBs;
                            numUpDownMontoSus.Value = ODepBan.MontoSus;
                            numUpDownTC.Value = ODepBan.TC;
                            txtDet.Text = ODepBan.Detalle;
                            txtDepositante.Text = ODepBan.Depositante;
                            txtNoComp.Text = ODepBan.NumComprobante;

                            CodInmode = ODepBan.CodInmode;
                            CodAsiento = ODepBan.CodAsiento;
                            Estado = ODepBan.Estado;

                            //cargamos la imagen al picturebox
                            MemoryStream m_MemoryStream = new MemoryStream(ODepBan.Img);
                            pbxImg.Image = new System.Drawing.Bitmap(m_MemoryStream);
                        }
                    }
                    catch(Exception)
                    {
                        CargarImgDefecto();
                    }
                }
            }
        }

        #endregion

        #region Funciones

        private void ExaminarImg()
        {
            try
            {
                openFileDialog.Title = "Seleccionar una Documento";
                openFileDialog.FileName = "";
                openFileDialog.Filter = "JPG|*.jpg||*.jpg";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    pbxImg.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarImgDefecto();
            }
        }

        private void CargarImgDefecto()
        {
            try
            {
                //cargamos imagen sin foto
                pbxImg.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\sinimagen.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbxImg.Image = null;
            }
        }

        private void BorrarCampos()
        {
            txtCodigo.Clear();
            txtDet.Clear();
            txtDepositante.Clear();
            txtNoComp.Clear();
            numUpDownMontoBs.Value = 0;
            numUpDownMontoSus.Value = 0;
            numUpDownTC.Value = 1;

            CargarImgDefecto();
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            BorrarCampos();
            DesabilitarCont();
            numUpDownTC.Value = 1;
        }

        private void Modif()
        {
            Opcion = "Modificar";
            DesabilitarCont();
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                CargarDepBanco(LDepBan);
                HabilitarCont();
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

        private void DepositoBanco_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            cboTipoBusq.Text = "No. Comprobante";

            ListarBancos();
            ListarCajas();
            ListarDepBanco();

            HabilitarCont();

            op.CerrarCargando();
        }

        private void dgvDepBanco_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarDepBanco(e);
        }

        private void DepositoBanco_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                AnularDepBanco();
            else
                MessageBox.Show("El deposito ya esta anulado", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifDepBanco();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarBancos();
            ListarCajas();
            ListarDepBanco();

            op.CerrarCargando();
        }

        private void btnAsiento_Click(object sender, EventArgs e)
        {
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            ListarDepBanco();
        }

        private void dtFecNota_ValueChanged(object sender, EventArgs e)
        {
            ListarDepBanco();
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            ExaminarImg();
        }

        private void btnBorrarImg_Click(object sender, EventArgs e)
        {
            CargarImgDefecto();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
                CargarDepBanco(LDepBan);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                BuscarDepBanco();
        }

        private void pbxImg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Imagen img = new Imagen(ODepBan.Img);
                img.Owner = this;
                img.ShowDialog();
            }
            catch (Exception)
            {   }
        }

        #endregion
    }
}

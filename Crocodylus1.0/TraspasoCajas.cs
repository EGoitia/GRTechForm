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
    public partial class TraspasoCajas : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OTraspasoCaja> LTCaj = null;
        List<OTraspasoCaja> LTAMiCaj = null;
        List<OTraspasoCaja> LBusqTCaj = null;

        OTraspasoCaja TCaj = null;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        bool Estado = false;

        public TraspasoCajas()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnas()
        {
            dgvTraspCaj.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Visible = false;
            dgvTraspCaj.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Numero";
            c2.Width = 80;
            dgvTraspCaj.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 100;
            dgvTraspCaj.Columns.Add(c3);
        }

        private void HabilitarCont()
        {
            //habilitamos segun la DB
            //op.HabilitarCont(gbxBotones, "8.05");

            dtFecNota.Enabled = true;

            //Desabilitamos
            cboCajaDel.Enabled = false;
            cboCajaAl.Enabled = false;
            numUpDownMontoBs.Enabled = false;
            numUpDownMontoSus.Enabled = false;
            txtDet.ReadOnly = true;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnImp.Enabled = false;
            btnReg.Enabled = false;
            btnAct.Enabled = false;


            ckbxMiCaja.Enabled = false;
            txtBuscar.Enabled = false;
            cboTipoBusq.Enabled = false;

            dtFecNota.Enabled = false;

            //habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            //op.HabilitarCampo(cboCajaDel, "8.05");
            cboCajaAl.Enabled = true;
            numUpDownMontoBs.Enabled = true;
            numUpDownMontoSus.Enabled = true;
            txtDet.ReadOnly = false;
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarCaja()
        {
            try
            {
                //List<OCaja> LCajDel = NCaja.NListarCaja(-1, -1, "Totales").OrderBy(x => x.NomCaja).ToList();
                //List<OCaja> LCajAl = NCaja.NListarCaja(-1, -1, "Totales").OrderBy(x => x.NomCaja).ToList();

                //CargarCajaDel(LCajDel);
                //CargarCajaAl(LCajAl);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTraspasoCaja()
        {
            try
            {
                txtBuscar.Clear();
                NombreColumnas();

                char AMiCaja = (ckbxMiCaja.Checked == true ? '1' : '0');
                if (ckbxMiCaja.Checked)
                {
                    LTAMiCaj = NTraspasoCaja.NListarTraspCaja(Convert.ToInt32(cboCajaDel.SelectedValue), dtFecNota.Value, ckbxMiCaja.Checked);
                    CargarTraspasoCaja(LTAMiCaj);
                }
                else
                {
                    LTCaj = NTraspasoCaja.NListarTraspCaja(Convert.ToInt32(cboCajaDel.SelectedValue), dtFecNota.Value, ckbxMiCaja.Checked);
                    CargarTraspasoCaja(LTCaj);
                }
            }
            catch (Exception)
            {
                NombreColumnas();
            }
        }

        private void BuscarTraspasoCaja()
        {
            try
            {
                if (txtBuscar.Text != string.Empty)
                {
                    LBusqTCaj = NTraspasoCaja.NBuscarTraspCaja(txtBuscar.Text, cboTipoBusq.Text, dtFecNota.Value,
                                        Convert.ToInt32(cboCajaDel.SelectedValue), ckbxMiCaja.Checked);
                    CargarTraspasoCaja(LBusqTCaj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModifTraspCaja()
        {
            try
            {
                Verificar();

                OInmode inm = new OInmode();
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.TipoInmode = Opcion;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                TCaj = new OTraspasoCaja();
                if(Opcion == "Nuevo")
                {
                    TCaj.TraspasoCajaID = -1;
                }
                else
                {
                    TCaj.TraspasoCajaID = Convert.ToInt32(txtCodigo.Text);

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul("Modificar");
                    dmod.Owner = this;
                    dmod.ShowDialog();
                    inm.DetalleInmode = dmod.DetaModAnul();
                }

                TCaj.CajaIDDel = Convert.ToInt32(cboCajaDel.SelectedValue);
                TCaj.CajaIDAl = Convert.ToInt32(cboCajaAl.SelectedValue);
                TCaj.Detalle = txtDet.Text;
                TCaj.MontoBs = numUpDownMontoBs.Value;
                TCaj.MontoSus = numUpDownMontoSus.Value;

                int rep = NTraspasoCaja.NInsertModifTraspCaja(TCaj, inm);
                if(rep > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    BorrarCampos();
                    ListarTraspasoCaja();
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

        private void AnulTrapCaja()
        {
            if(txtCodigo.Text != string.Empty)
            {
                DialogResult dialogo = MessageBox.Show("¿Seguro que desea Anular el Codigo " + txtCodigo.Text + "?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(dialogo == DialogResult.Yes)
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

                        Frm_DetaModifAnul danul = new Frm_DetaModifAnul("Anular");
                        danul.Owner = this;
                        danul.ShowDialog();
                        inm.DetalleInmode = danul.DetaModAnul();

                        int resp = NTraspasoCaja.NAnulRestauTraspCaja(txtCodigo.Text, "TraspasoCaja", 0, inm);
                        if (resp > 0)
                        {
                            MessageBox.Show("El Traspaso se anulo correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            op.AbrirCargando("Cargando.....");

                            ListarTraspasoCaja();
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

        #region CargarDatos

        private void CargarCajaDel(List<OCaja> lcajdel)
        {
            cboCajaDel.DataSource = lcajdel;
            cboCajaDel.DisplayMember = "NomCaja";
            cboCajaDel.ValueMember = "CajaID";
            cboCajaDel.Refresh();
        }

        private void CargarCajaAl(List<OCaja> lcajal)
        {
            cboCajaAl.DataSource = lcajal;
            cboCajaAl.DisplayMember = "NomCaja";
            cboCajaAl.ValueMember = "CajaID";
            cboCajaAl.Refresh();
        }

        private void CargarTraspasoCaja(List<OTraspasoCaja> ltcaj)
        {
            if(ltcaj != null)
            {
                NombreColumnas();

                foreach (var item in ltcaj)
                {
                    dgvTraspCaj.Rows.Add(item.TraspasoCajaID, item.NumTraspCaja, item.Fecha.ToShortDateString());
                }
            }
            else
            {
                NombreColumnas();
            }
        }

        private void SeleccionarTraspasoCaja(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    string codigo = dgvTraspCaj["Codigo", e.RowIndex].Value.ToString();
                    
                    if(txtBuscar.Text == string.Empty)
                        TCaj = LTCaj.Find(x => x.TraspasoCajaID.ToString().Contains(codigo));
                    else
                        TCaj = LBusqTCaj.Find(x => x.TraspasoCajaID.ToString().Contains(codigo));

                    if(TCaj != null)
                    {
                        CodInmode = TCaj.CodInmode;
                        Estado = TCaj.Estado;
                        txtCodigo.Text = TCaj.NumTraspCaja;
                        cboCajaDel.Text = TCaj.NomCajaDel;
                        cboCajaAl.Text = TCaj.NomCajaAl;
                        txtDet.Text = TCaj.Detalle;
                        numUpDownMontoBs.Value = TCaj.MontoBs;
                        numUpDownMontoSus.Value = TCaj.MontoSus;
                    }
                }
                catch (Exception)
                {
                    BorrarCampos();
                }
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos()
        {
            txtCodigo.Clear();
            txtDet.Clear();
            numUpDownMontoBs.Value = 0;
            numUpDownMontoSus.Value = 0;
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            BorrarCampos();
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
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                CargarTraspasoCaja(LTCaj);
                HabilitarCont();
            }
        }

        private void Registro()
        {
            if (txtCodigo.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        private void Imprimir()
        {
            if (txtCodigo.Text != string.Empty)
            {
                Reportes.RepTraspasoCajas reptcaj = new Reportes.RepTraspasoCajas(TCaj);
                reptcaj.Show();
            }
        }

        private void Verificar()
        {
            //que no sea la misma caja
            if (cboCajaDel.Text == cboCajaAl.Text)
                throw new Exception("La caja Saliente no puede ser igual a la Caja Entrante");
            else if ((numUpDownMontoBs.Value <= 0) && (numUpDownMontoSus.Value <= 0))
                throw new Exception("Tiene que ingresar un monto mayor a cero");
        }

        #endregion

        #region Eventos Formulario

        private void TraspasoCajas_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            cboTipoBusq.Text = "Codigo";
            ListarCaja();
            ListarTraspasoCaja();
            HabilitarCont();

            op.CerrarCargando();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Modif();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            AnulTrapCaja();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifTraspCaja();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        
        private void TraspasoCajas_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            ListarCaja();
            ListarTraspasoCaja();

            op.CerrarCargando();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void ckbxMiCaja_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxMiCaja.Checked)
            {
                if (LTAMiCaj == null)
                    ListarTraspasoCaja();
                else
                    CargarTraspasoCaja(LTAMiCaj);
            }
            else
            {
                CargarTraspasoCaja(LTCaj);
            }

            txtBuscar.Text = string.Empty;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
                CargarTraspasoCaja(LTCaj);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarTraspasoCaja();
        }

        private void dgvTraspCaj_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarTraspasoCaja(e);
        }

        #endregion
    }
}

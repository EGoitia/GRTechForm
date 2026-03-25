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
    public partial class PrestamoProveedor : Form, IAgregaProv
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OPrestamoProv> LPresProv = null;
        List<OPrestamoProv> LBusqPresProv = null;
        List<OProveedor> LProv = null;
        OPrestamoProv PresProv = null;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        string CodPago = string.Empty;
        string CodAsiento = string.Empty;

        bool Estado = false;

        #region IAgregaProv

        public void AgregaProv(string nomprov)
        {
            cboProv.Text = nomprov;
        }

        #endregion

        public PrestamoProveedor()
        {
            InitializeComponent();
        }

        #region Config. Formulario

        private void NombreColumnasNota()
        {
            dgvNota.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "PrestamoID";
            c1.Visible = false;
            dgvNota.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Num. Contrato";
            c2.Width = 100;
            dgvNota.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 100;
            dgvNota.Columns.Add(c3);
        }

        private void HabilitarCont()
        {
            //Habilitamos botones
            //op.HabilitarCont(gbxBotones, "6.22");
            //op.HabilitarCont(gbxBuscador, "6.22");

            dtFechaNota.Enabled = true;

            //Desabilitamos campos
            txtNumCont.ReadOnly = true;
            txtDetalle.ReadOnly = true;
            cboProv.Enabled = false;
            btnBusqProv.Enabled = false;
            ckbxDocto.Enabled = false;
            numUpDownContrato.Enabled = false;
            numUpDownInteres.Enabled = false;
            numUpDownPlazoMes.Enabled = false;
            numUpDownPrestamo.Enabled = false;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos controles
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnReg.Enabled = false;
            btnAct.Enabled = false;
            btnAsi.Enabled = false;
            btnImp.Enabled = false;

            txtBuscar.Enabled = false;
            cboTipoBusq.Enabled = false;

            dtFechaNota.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            //Habilitamos campos
            txtNumCont.ReadOnly = false;
            txtDetalle.ReadOnly = false;
            cboProv.Enabled = true;
            btnBusqProv.Enabled = true;
            ckbxDocto.Enabled = true;
            numUpDownContrato.Enabled = true;
            numUpDownInteres.Enabled = true;
            numUpDownPlazoMes.Enabled = true;
            numUpDownPrestamo.Enabled = true;
        }

        #endregion

        #region Conexion Capa de Negocios

        private void ListarProv()
        {
            try
            {
                LProv = NProveedor.NListarProv().OrderBy(x => x.NomProv).ToList(); //opcion 3, solo proveedores financieros
                CargarProv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPrestamoProv()
        {
            try
            {
                LPresProv = NPrestamoProv.NListarPresProv(dtFechaNota.Value);
                CargarPrestamoProv(LPresProv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnasNota();
            }
        }

        private void BuscarPrestamoProv()
        {
            if (txtBuscar.Text != string.Empty)
            {
                try
                {
                    op.AbrirCargando("Buscando....");

                    LBusqPresProv = NPrestamoProv.NBuscarPresProv(cboTipoBusq.Text, txtBuscar.Text, dtFechaNota.Value);
                    CargarPrestamoProv(LBusqPresProv);
                }
                catch (Exception)
                { }
                finally
                {
                    op.CerrarCargando();
                }
            }
        }

        private void InsertModifPrestamoProv()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomUsu = OConexionGlobal.NomPer;
                inm.TipoInmode = Opcion;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                PresProv = new OPrestamoProv();
                if(Opcion == "Nuevo")
                {
                    PresProv.PrestamoID = -1;
                }
                else
                {
                    PresProv.PrestamoID = Convert.ToInt32(txtCodigo.Text);

                    Frm_DetaModifAnul mod = new Frm_DetaModifAnul("Modificar");
                    mod.Owner = this;
                    mod.ShowDialog();
                    inm.DetalleInmode = mod.DetaModAnul();
                }

                PresProv.ContratoBs = numUpDownContrato.Value;
                PresProv.Detalle = txtDetalle.Text;
                PresProv.Documento = ckbxDocto.Checked;
                PresProv.InteresPorcent = numUpDownInteres.Value;
                PresProv.NumContrato = txtNumCont.Text;
                PresProv.PlazoMeses = Convert.ToInt32(numUpDownPlazoMes.Value);
                PresProv.ProveedorID = Convert.ToInt32(cboProv.SelectedValue);
                PresProv.TotalPrestamoBs = numUpDownPrestamo.Value;
                //Pago    
                OPago pag = new OPago();
                pag.CodPago = CodPago;
                pag.TC = 1;
                pag.TotalPagadoBs = 0;

                int resp = NPrestamoProv.NInsertModifPresProv(PresProv, pag, "", inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    BorrarCampos();
                    ListarPrestamoProv();
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

        private void AnulPrestamoProv()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Anular el codigo " + txtCodigo.Text + "?", "Anular",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                try
                {
                    OInmode inm = new OInmode();
                    inm.CodInmode = CodInmode;
                    inm.UsuarioID = OConexionGlobal.UsuarioID;
                    inm.NomUsu = OConexionGlobal.NomPer;
                    inm.TipoInmode = "Anular";
                    inm.IPInmode = op.SaberIP();
                    inm.MacInmode = op.SaberMac();
                    inm.MaquinaInmode = op.SaberNomMaquina();
                    inm.SistOperInmode = op.SaberSistemOper();

                    Frm_DetaModifAnul mod = new Frm_DetaModifAnul("Modificar");
                    mod.Owner = this;
                    mod.ShowDialog();
                    inm.DetalleInmode = mod.DetaModAnul();

                    int resp = NPrestamoProv.NAnulRestauPresProv(txtCodigo.Text, "PrestamoProv", 0, inm);
                    if(resp > 0)
                    {
                        MessageBox.Show("La nota se anulo correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando.....");
                        ListarPrestamoProv();
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

        private void CargarProv()
        {
            if(LProv != null)
            {
                cboProv.DataSource = LProv;
                cboProv.DisplayMember = "NomProv";
                cboProv.ValueMember = "ProveedorID";
                cboProv.Refresh();
            }
        }

        private void CargarPrestamoProv(List<OPrestamoProv> lpresprov)
        {
            if(lpresprov != null)
            {
                NombreColumnasNota();

                int cont = 0;
                foreach (var item in lpresprov)
                {
                    dgvNota.Rows.Add(item.PrestamoID, item.NumContrato, item.Fecha.ToShortDateString());

                    if (!Estado)
                        dgvNota.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
            }
            else
            {
                NombreColumnasNota();
            }
        }

        private void SeleccionarPrestamoProv(DataGridViewCellEventArgs e)
        {
            if((e.RowIndex > -1) && (Opcion == string.Empty))
            {
                try
                {
                    txtCodigo.Text = dgvDoctos["PrestamoID", e.RowIndex].Value.ToString();

                    if (txtBuscar.Text == string.Empty)
                    {
                        PresProv = LPresProv.Find(x => x.PrestamoID.ToString() == txtCodigo.Text);
                    }
                    else
                    {
                        PresProv = LBusqPresProv.Find(x => x.PrestamoID.ToString() == txtCodigo.Text);
                    }

                    if (PresProv != null)
                    {
                        BorrarCampos();

                        CodAsiento = PresProv.CodAsiento;
                        CodPago = PresProv.CodPago;
                        CodInmode = PresProv.CodInmode;
                        Estado = PresProv.Estado;

                        dtFecha.Value = PresProv.Fecha;
                        txtNumCont.Text = PresProv.NumContrato;
                        cboProv.Text = PresProv.NomProv;
                        ckbxDocto.Checked = PresProv.Documento;
                        txtDetalle.Text = PresProv.Detalle;
                        numUpDownContrato.Value = PresProv.ContratoBs;
                        numUpDownInteres.Value = PresProv.InteresPorcent;
                        numUpDownPlazoMes.Value = PresProv.PlazoMeses;
                        numUpDownPrestamo.Value = PresProv.TotalPrestamoBs;
                    }
                }
                catch
                {
                    CodAsiento = string.Empty;
                    CodPago = string.Empty;
                    CodInmode = string.Empty;
                    BorrarCampos();
                }
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos()
        {
            txtCodigo.Clear();
            dtFecha.Value = DateTime.Now;
            txtNumCont.Clear();
            ckbxDocto.Checked = false;
            numUpDownContrato.Value = 0;
            numUpDownInteres.Value = 0;
            numUpDownPrestamo.Value = 0;
            numUpDownPlazoMes.Value = 0;
            txtDetalle.Clear();
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
            if(dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                CargarPrestamoProv(LPresProv);
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

        private void Asiento()
        {
           
        }

        private void Imprimir()
        {
            if((txtCodigo.Text != string.Empty) && (LPresProv != null))
            {
                Reportes.RepNotaPrestamoProveedor reppresprov = new Reportes.RepNotaPrestamoProveedor(PresProv);
                reppresprov.Show();
            }
        }

        #endregion

        #region Eventos Formulario

        private void PrestamoProveedor_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            HabilitarCont();

            ListarProv();
            ListarPrestamoProv();

            op.CerrarCargando();
        }

        private void PrestamoProveedor_FormClosing(object sender, FormClosingEventArgs e)
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
            AnulPrestamoProv();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifPrestamoProv();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarProv();
            ListarPrestamoProv();

            op.CerrarCargando();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnAsi_Click(object sender, EventArgs e)
        {
            Asiento();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
                CargarPrestamoProv(LPresProv);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarPrestamoProv();
        }

        private void dtFechaNota_ValueChanged(object sender, EventArgs e)
        {
            ListarPrestamoProv();
        }

        private void dgvNota_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarPrestamoProv(e);
        }

        private void btnBusqProv_Click(object sender, EventArgs e)
        {
        }

        #endregion
    }
}

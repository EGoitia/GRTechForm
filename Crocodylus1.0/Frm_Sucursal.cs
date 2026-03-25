using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Datos;
using System.Xml.Serialization;

namespace GRTechnology1._0
{
    public partial class Frm_Sucursal : Form
    {
        public static Frm_Sucursal frmsuc = null;

        List<OSucursal> LSuc = null;
        
        OSucursal OSuc = null;
        OUbicacion OUbic = null;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        string CodUbic = string.Empty;

        bool Estado = false;

        public Frm_Sucursal()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombresColumnas()
        {
            dgvSuc.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.FillWeight = 80;
            c1.Name = "Codigo";
            dgvSuc.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.FillWeight = 250;
            c2.Name = "Sucursal";
            dgvSuc.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.FillWeight = 200;
            c3.Name = "Encargado";
            dgvSuc.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.FillWeight = 200;
            c4.Name = "Telf.";
            dgvSuc.Columns.Add(c4);
            
            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.FillWeight = 250;
            c5.Name = "Dirección";
            dgvSuc.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.FillWeight = 100;
            c6.Name = "Ciudad";
            dgvSuc.Columns.Add(c6);
        }

        private void HabilitarContr()
        {
            //Habilitamos los controles 
            btnNuevo.Enabled = true;
            btnModif.Enabled = true;
            btnAnul.Enabled = true;
            btnRest.Enabled = true;
            txtBuscar.Enabled = true;
            btnAct.Enabled = true;
            btnReg.Enabled = true;
            //desabilitamos controles secundarios
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            //desabilitamos los formilarios
            txtNomSuc.ReadOnly = true;
            txtNomEnc.ReadOnly = true;
            txtTelf.ReadOnly = true;

            cboCiudad.Enabled = false;
            txtDpto.ReadOnly = true;
            txtZona.ReadOnly = true;
            txtBarrio.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtLatitud.ReadOnly = true;
            txtLongitud.ReadOnly = true;
        }

        private void DesabilitarContr()
        {
            //Desabilitamos controles primarios
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            txtBuscar.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            //habilitamos controles secundarios
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            //habilitamos formularios
            txtNomSuc.ReadOnly = false;
            txtNomEnc.ReadOnly = false;
            txtTelf.ReadOnly = false;
            //txtFax.ReadOnly = false;

            cboCiudad.Enabled = true;
            txtDpto.ReadOnly = false;
            txtZona.ReadOnly = false;
            txtBarrio.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtLatitud.ReadOnly = false;
            txtLongitud.ReadOnly = false;
        }

        #endregion

        #region Conexion Capa de NEgocios

        private void AnulRestSuc(string o, int opc)
        {
            if (txtSucID.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿DESEA " + o + " LA SUCURSAL " + txtNomSuc.Text + "?", o + " SUCURSAL", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    string DetalleInmode = string.Empty;
                    try
                    {
                        //Cargamos Detalle Anulado
                        Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(o + " SUCURSAL");
                        dmodanul.Owner = this;
                        dmodanul.ShowDialog();
                        DetalleInmode = dmodanul.DetaModAnul();

                        bool resp = DListarPersonalizado.AnulRestau(txtSucID.Text, "Sucursal", "", DetalleInmode, o, false);
                        if (resp)
                        {
                            MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ListarSuc();
                            HabilitarContr();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void InsertModifSuc()
        {
            string DetalleInmode = string.Empty;
            try
            {
                //objeto sucursal
                OSucursal suc = new OSucursal();

                if (Opcion == "Nuevo")
                    suc.SucursalID = -1;
                else
                {
                    suc.SucursalID = Convert.ToInt32(txtSucID.Text);

                    //llamamos al detalle modificado
                    Frm_DetaModifAnul det = new Frm_DetaModifAnul("Modificar Sucursal");
                    det.Owner = this;
                    det.ShowDialog();
                    DetalleInmode = det.DetaModAnul();
                }

                suc.NomSuc = txtNomSuc.Text;
                suc.NomEncSuc = txtNomEnc.Text;
                suc.Telf = txtTelf.Text;

                //objeto ubicacion
                OUbicacion ubic = new OUbicacion();
                ubic.CodUbicacion = CodUbic;
                ubic.PaisID = 1;    //Convert.ToInt32(cboPais.SelectedValue);
                ubic.DptoEstado = txtDpto.Text;
                ubic.Ciudad = cboCiudad.Text;
                ubic.Zona = txtZona.Text;
                ubic.Barrio = txtBarrio.Text;
                ubic.Direccion = txtDireccion.Text;
                ubic.Latitud = txtLatitud.Text;
                ubic.Longitud = txtLongitud.Text;

                int resp = DSucursal.DInsertModifSucursal(suc, ubic, OInmode.DTInmode("", Opcion.ToUpper(), DetalleInmode));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Opcion = string.Empty;
                    ListarSuc();
                    HabilitarContr();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarSuc()
        {
            try
            {
                LSuc = DSucursal.DListarSucursales();
                CargarSuc(LSuc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombresColumnas();
            }
        }

        private void ListarPais()
        {
            try
            {
                cboPais.DataSource = DListarPersonalizado.ConsultarDT("SELECT PaisID, NomPais FROM Pais ORDER BY NomPais");
                cboPais.DisplayMember = "NomPais";
                cboPais.ValueMember = "PaisID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarUbicacion()
        {
            try
            {
                OUbic = DUbicacion.DBuscarUbicacion(CodUbic, "Ubicacion");
                if (OUbic != null)
                {
                    cboPais.Text = OUbic.NomPais;
                    txtDpto.Text = OUbic.DptoEstado;
                    cboCiudad.Text = OUbic.Ciudad;
                    txtZona.Text = OUbic.Zona;
                    txtBarrio.Text = OUbic.Barrio;
                    txtDireccion.Text = OUbic.Direccion;
                    txtLatitud.Text = OUbic.Latitud;
                    txtLongitud.Text = OUbic.Longitud;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CargarDatos

        private void CargarSuc(List<OSucursal> lsuc)
        {
            if (lsuc != null)
            {
                NombresColumnas();
                int cont = 0;
                foreach (var item in lsuc)
                {
                    dgvSuc.Rows.Add(item.SucursalID, item.NomSuc, item.NomEncSuc, item.Telf);

                    if (!item.Estado)
                        dgvSuc.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }

                dgvSuc.Refresh();
            }
            else
            {
                NombresColumnas();
            }
        }

        private void BuscarSuc()
        {
            if (LSuc != null)
            {
                List<OSucursal> lbusqsuc = new List<OSucursal>();

                NombresColumnas();
                int val = 0;
                if (int.TryParse(txtBuscar.Text, out val))
                {
                    //Buscamos por codigo de Sucursal
                    OSucursal objsuc = LSuc.Find(x => x.SucursalID == Convert.ToInt32(txtBuscar.Text));
                    lbusqsuc = new List<OSucursal>();
                    lbusqsuc.Add(objsuc);
                    CargarSuc(lbusqsuc);

                }
                else
                {
                    //Buscamos por Nombre de Proveedor
                    lbusqsuc = LSuc.FindAll(c => c.NomSuc.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                    CargarSuc(lbusqsuc);
                }
            }
        }

        private void SeleccionarListSuc(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    txtSucID.Text = dgvSuc["Codigo", e.RowIndex].Value.ToString();

                    OSuc = LSuc.Find(x => x.SucursalID == Convert.ToInt32(txtSucID.Text));
                    if (OSuc != null)
                    {
                        txtSucID.Text = OSuc.SucursalID.ToString();
                        CodInmode = OSuc.CodInmode;
                        CodUbic = OSuc.CodUbicacion;
                        txtNomSuc.Text = OSuc.NomSuc;
                        txtNomEnc.Text = OSuc.NomEncSuc;
                        txtTelf.Text = OSuc.Telf;
                        Estado = OSuc.Estado;

                        BuscarUbicacion();
                    }
                }
                catch
                { }
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos(GroupBox gbx, string param)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, param);
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            BorrarCampos(gbxCod, "");
            BorrarCampos(gbxDatos, "");
            BorrarCampos(gbxUbicacion, "");
            //el nombre de la ciudad por defecto
            cboPais.Text = "Bolivia";
            cboCiudad.Text = OConexionGlobal.Ciudad;
            //desabilitamos los controles
            DesabilitarContr();
        }

        private void Modificar()
        {
            Opcion = "Modificar";
            DesabilitarContr();
        }

        private void Cancelar()
        {
            DialogResult result = MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                BorrarCampos(gbxCod, "");
                BorrarCampos(gbxDatos, "");
                BorrarCampos(gbxUbicacion, "");
                HabilitarContr();
                CargarSuc(LSuc);
                Opcion = string.Empty;
            }
        }

        private void Registro()
        {
            if (txtSucID.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos Formulario

        private void Sucursal_Load(object sender, EventArgs e)
        {
            cboPais.Text = "Bolivia";
            HabilitarContr();
            ListarPais();
            ListarSuc();
        }
        
        private void dgvSuc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListSuc(e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            AnulRestSuc("Anular", 0); 
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            AnulRestSuc("Restaurar", 1);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ListarSuc();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                BuscarSuc();
            }
            else
            {
                CargarSuc(LSuc);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifSuc();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void Sucursal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmsuc.Dispose();
            frmsuc = null;
        }

        #endregion
    }
}

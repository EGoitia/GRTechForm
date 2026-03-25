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
    public partial class Almacen : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        string CodInmode = string.Empty;
        string CodUbicacion = string.Empty;
        string Opcion = string.Empty;

        bool Estado = false;

        List<OSucursal> LSuc = null;
        List<OAlmacen> LAlm = null;
        OAlmacen OAlm = null;
        OUbicacion OUbic = null;

        public Almacen()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void HabilitarCont()
        {
            //habilitamos segun la DB, por parametro el nombre del groupbox donde se encuentran los botones y el codigo del padre 1.3
            //op.HabilitarCont(gbxBotones, "1.03");

            //desabilitamos
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            txtAlmacen.ReadOnly = true;
            txtEncargado.ReadOnly = true;
            cboSuc.Enabled = false;

            txtZona.ReadOnly = true;
            txtBarrio.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtLatitud.ReadOnly = true;
            txtLongitud.ReadOnly = true;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            //txtBuscar.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtAlmacen.ReadOnly = false;
            txtEncargado.ReadOnly = false;
            cboSuc.Enabled = true;

            txtZona.ReadOnly = false;
            txtBarrio.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtLatitud.ReadOnly = false;
            txtLongitud.ReadOnly = false;
        }

        private void NombreColumnas()
        {
            dgvAlmacen.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 90;
            c1.Name = "Codigo";
            dgvAlmacen.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 250;
            c2.Name = "Almacen";
            dgvAlmacen.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 200;
            c3.Name = "Encargado";
            dgvAlmacen.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Width = 200;
            c4.Name = "Sucursal";
            dgvAlmacen.Columns.Add(c4);
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarAlm()
        {
            try
            {
                LAlm = NAlmacen.NListarAlmacenes(-1);
                CargarAlmacen(LAlm);
            }
            catch (Exception)
            {
                NombreColumnas();
            }
        }

        private void ListarSuc()
        {
            try
            {
                LSuc = NSucursal.NListarSucursales();
                List<OSucursal> lsuc = LSuc.OrderBy(x => x.NomSuc).ToList();

                cboSuc.DataSource = lsuc;
                cboSuc.DisplayMember = "NomSuc";
                cboSuc.ValueMember = "SucursalID";
                cboSuc.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void BuscarUbicacion()
        {
            try
            {
                OUbic = NUbicacion.NBuscarUbic(CodUbicacion, "Ubicacion");
                if (OUbic != null)
                {
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

        private void InsertModifAlm()
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

                OAlmacen alm = new OAlmacen();
                if (Opcion == "Nuevo")
                {
                    alm.AlmacenID = -1;
                }
                else
                {
                    alm.AlmacenID = Convert.ToInt32(txtCodigo.Text);

                    //Cargamos Detalle MOdificado
                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("Modificar Caja");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();
                    inm.DetalleInmode = dmodanul.DetaModAnul();
                }

                alm.SucursalID = Convert.ToInt32(cboSuc.SelectedValue);
                alm.NomAlmacen = txtAlmacen.Text;
                alm.NomEncAlmacen = txtEncargado.Text;

                //Ubicacion
                OUbicacion ubic = new OUbicacion();
                ubic.CodUbicacion = CodUbicacion;
                ubic.Zona = txtZona.Text;
                ubic.Barrio = txtBarrio.Text;
                ubic.Direccion = txtDireccion.Text;
                ubic.Latitud = txtLatitud.Text;
                ubic.Longitud = txtLongitud.Text;

                int resp = NAlmacen.NInsertModifAlmacen(alm, ubic, inm);
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    txtBuscar.Clear();

                    Opcion = string.Empty;
                    txtBuscar.Clear();
                    HabilitarCont();
                    ListarAlm();
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

        private void AnulRestauAlm(string o, int opc)
        {
            if (txtCodigo.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Desea " + o + " el Almacen " + txtAlmacen.Text + "?", o + " Almacen", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        //Cargamos Detalle Anulado
                        Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(o + " Caja");
                        dmodanul.Owner = this;
                        dmodanul.ShowDialog();

                        bool resp = NListarPersonalizado.AnulRestau(txtCodigo.Text, "Almacen", "", dmodanul.DetaModAnul(), "Anular", false);
                        if (resp)
                        {
                            MessageBox.Show("Los Datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            op.AbrirCargando("Cargando....");

                            Opcion = string.Empty;
                            txtBuscar.Clear();
                            ListarAlm();
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

        #region Cargar Datos

        private void CargarAlmacen(List<OAlmacen> lalm)
        {
            if (lalm != null)
            {
                NombreColumnas();

                int cont = 0;
                foreach (var item in lalm)
                {
                    dgvAlmacen.Rows.Add(item.AlmacenID, item.NomAlmacen, item.NomEncAlmacen, item.NomSuc);

                    if (!item.Estado)
                        dgvAlmacen.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvAlmacen.Refresh();
            }
            else
            {
                NombreColumnas();
            }
        }

        private void SeleccionarListAlmacen(DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > -1) && (Opcion == string.Empty))
            {
                try
                {
                    //Borramos los campos
                    BorrarCampos(gbxDatosAlm);
                    BorrarCampos(gbxUbicacion);

                    //Datos
                    txtCodigo.Text = dgvAlmacen["Codigo", e.RowIndex].Value.ToString();
                    OAlm = LAlm.Find(x => x.AlmacenID == Convert.ToInt32(txtCodigo.Text));
                    if(OAlm !=null)
                    {
                        CodInmode = OAlm.CodInmode;
                        CodUbicacion = OAlm.CodUbicacion;
                        Estado = OAlm.Estado;

                        txtAlmacen.Text = OAlm.NomAlmacen;
                        txtEncargado.Text = OAlm.NomEncAlmacen;
                        cboSuc.Text = OAlm.NomSuc;

                        //Buscamos la Ubicacion
                        BuscarUbicacion();
                    }
                }
                catch
                { }
            }
        }

        private void BuscarAlmacen()
        {
            if(txtBuscar.Text != string.Empty)
            {
                List<OAlmacen> lalm = LAlm.FindAll(x => x.NomAlmacen.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                CargarAlmacen(lalm);
            }
            else
            {
                CargarAlmacen(LAlm);
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos(GroupBox gbx)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, "");
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            txtAlmacen.Focus();

            BorrarCampos(gbxDatosAlm);
            BorrarCampos(gbxUbicacion);
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

        private void Registro()
        {
            if(txtCodigo.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        private void Cancelar()
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Opcion = string.Empty;
                txtBuscar.Clear();
                BorrarCampos(gbxDatosAlm);
                BorrarCampos(gbxUbicacion);

                HabilitarCont();
                CargarAlmacen(LAlm);
            }
        }

        #endregion

        #region €ventos Formulario

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
                AnulRestauAlm("Anular", 0);
            else
                MessageBox.Show("Ya está Anulado", "Almacen Anulado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (!Estado)
                AnulRestauAlm("Restaurar", 1);
            else
                MessageBox.Show("Ya está Habilitado", "Almacen Habilitado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            txtBuscar.Clear();
            ListarSuc();
            ListarAlm();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifAlm();
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
            BuscarAlmacen();
        }

        private void dgvAlmacen_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListAlmacen(e);
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            ListarSuc();
            ListarAlm();
            HabilitarCont();

            op.CerrarCargando();
        }

        private void Almacen_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Objetos;
using Negocio;
using System.IO;
using System.Data;

namespace GRTechnology1._0
{
    public partial class Frm_Clientes : Form
    {
        public static Frm_Clientes frmcli = null;

        OpcionFormularios op = new OpcionFormularios();

        string CodInmodeCli = string.Empty;
        string CodInmodeUbic = string.Empty;
        string CodInmodeContac = string.Empty;
        string CodInmodeRedSoc = string.Empty;
        string CodInmodeNomFact = string.Empty;
        string CodInmodeDocto = string.Empty;
        string CodInmodeUsuCli = string.Empty;

        string Opcion = string.Empty;
        string RutaDocto = string.Empty;
        
        bool EstadoCli = false;
        bool EstadoContac = false;
        bool EstadoRedSoc = false;
        bool EstadoNomFact = false;
        bool EstadoDocto = false;
        bool EstadoUsuCli = false;

        DataTable LCli = null;
        List<ORedesSociales> LRedSoc = null;
        

        public Frm_Clientes()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnasCli()
        {
            dgvClientes.Columns["ClienteID"].HeaderText = "ID";
            dgvClientes.Columns["NomClien"].HeaderText = "Cliente";
            dgvClientes.Columns["NomVendedor"].HeaderText = "Vendedor";
            dgvClientes.Columns["TipoClien"].HeaderText = "Tipo";
            dgvClientes.Columns["LimiteCredito"].HeaderText = "Límite Crédito";
            dgvClientes.Columns["PlazoPago"].HeaderText = "Plazo Pago";

            dgvClientes.Columns["ClienteID"].FillWeight = 50;
            dgvClientes.Columns["NomClien"].FillWeight = 200;
            dgvClientes.Columns["NomVendedor"].FillWeight = 100;
            dgvClientes.Columns["TipoClien"].FillWeight = 150;
            dgvClientes.Columns["PlazoPago"].FillWeight = 80;

            dgvClientes.Columns["LimiteCredito"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvClientes.Columns["LimiteCredito"].DefaultCellStyle.Format = "N2";

            dgvClientes.Columns["CodInmode"].Visible = false;
            dgvClientes.Columns["VendedorID"].Visible = false;
            dgvClientes.Columns["TipoClienteID"].Visible = false;
            dgvClientes.Columns["EstadoLimCredit"].Visible = false;
            dgvClientes.Columns["EstadoFactMorosas"].Visible = false;
            dgvClientes.Columns["PagWeb"].Visible = false;
            dgvClientes.Columns["Correo"].Visible = false;
            dgvClientes.Columns["Altura"].Visible = false;
            dgvClientes.Columns["Barrio"].Visible = false;
            dgvClientes.Columns["Barrio"].Visible = false;
            dgvClientes.Columns["DptoEstado"].Visible = false;
            dgvClientes.Columns["PaisID"].Visible = false;
            dgvClientes.Columns["Direccion"].Visible = false;
            dgvClientes.Columns["Zona"].Visible = false;
            dgvClientes.Columns["Estado"].Visible = false;
        }

        private void NombreColumnasContac()
        {
            dgvContactos.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Visible = false;
            dgvContactos.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 200;
            c2.Name = "Nombre";
            dgvContactos.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 150;
            c3.Name = "Cargo";
            dgvContactos.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Width = 100;
            c4.Name = "Dpto.";
            dgvContactos.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Width = 100;
            c5.Name = "Telf";
            dgvContactos.Columns.Add(c5);


            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Width = 100;
            c6.Name = "Celular";
            dgvContactos.Columns.Add(c6);

            DataGridViewTextBoxColumn c7= new DataGridViewTextBoxColumn();
            c7.Visible = false;
            c7.Name = "Web";
            dgvContactos.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Width = 100;
            c8.Name = "Correo";
            dgvContactos.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Visible = false;
            c9.Name = "Estado";
            dgvContactos.Columns.Add(c9);
        }

        private void NombreColumnasRedesSoc()
        {
            dgvRedesSoc.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Visible = false;
            dgvRedesSoc.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Link";
            c2.Width = 400;
            dgvRedesSoc.Columns.Add(c2);
        }

        private void NombreColumnasNomFact()
        {
            dgvNomFact.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Visible = false;
            c1.Name = "Codigo";
            dgvNomFact.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 130;
            c2.Name = "Nombre";
            dgvNomFact.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 120;
            c3.Name = "NIT";
            dgvNomFact.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Visible = false;
            c4.Name = "Estado";
            dgvNomFact.Columns.Add(c4);
        }

        private void NombreColumnasDocto()
        {
            dgvDoctos.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Visible = false;
            dgvDoctos.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Nombre";
            c2.Width = 250;
            dgvDoctos.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Formato";
            c3.Width = 90;
            dgvDoctos.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Tipo Docto.";
            c4.Width = 90;
            dgvDoctos.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Desc.";
            c5.Width = 300;
            dgvDoctos.Columns.Add(c5);
        }

        private void NombreColumnasUsuCli()
        {
            dgvUsuariosCli.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "ID";
            c1.Visible = false;
            dgvUsuariosCli.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Usuario";
            c2.Width = 250;
            dgvUsuariosCli.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Contraseña";
            c3.Width = 200;
            dgvUsuariosCli.Columns.Add(c3);

            DataGridViewCheckBoxColumn c4 = new DataGridViewCheckBoxColumn();
            c4.Name = "Estado";
            c4.Width = 60;
            dgvUsuariosCli.Columns.Add(c4);
        }

        private void HabilitarBotones()
        {
            btnNuevo.Enabled = true;
            btnModif.Enabled = true;
            btnAnul.Enabled = true;
            btnAct.Enabled = true;
            btnReg.Enabled = true;
            btnRest.Enabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            //Habilitamos botones segun la DB
            //op.HabilitarCont(gbxBotones, "1.14");
        }

        private void HabilitarCli()
        {
            //Habilitamos Cliente
            txtNomCli.ReadOnly = false;
            cboTipoCli.Enabled = true;
            cboVendedor.Enabled = true;
            btnBusqVendedor.Enabled = true;
            txtTelf.ReadOnly = false;
            txtPagWeb.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            numUpDownLimCred.Enabled = true;
            numUpDownPlazo.Enabled = true;
            ckbxEstLimCred.Enabled = true;
            ckbxFactMorosas.Enabled = true;
        }

        private void HabilitarUbic()
        {
            //Habilitamos Ubicacion
            txtDpto.ReadOnly = false;
            cboPais.Enabled = true;
            cboCiudad.Enabled = true;
            txtZona.ReadOnly = false;
            txtBarrio.ReadOnly = false;
            txtDireccion.ReadOnly = false;
        }

        private void HabilitarContac()
        {
            txtNomContact.ReadOnly = false;
            txtCargoContact.ReadOnly = false;
            txtDptoContact.ReadOnly = false;
            txtTelfContact.ReadOnly = false;
            txtCelularContact.ReadOnly = false;
            txtPagWebContact.ReadOnly = false;
            txtEmailContact.ReadOnly = false;
        }

        private void HabilitarRedSoc()
        {
            txtLink.ReadOnly = false;
        }

        private void HabilitarNomFact()
        {
            txtNomFact.ReadOnly = false;
            txtNIT.ReadOnly = false;
        }

        private void HabilitarDocto()
        {
            cboTipoDoc.Enabled = true;
            txtPalClave.ReadOnly = false;
            txtDesc.ReadOnly = false;
        }

        private void HabilitarUsuaCli()
        {
            txtUsua.ReadOnly = false;
            txtPass.ReadOnly = false;
            chkHabil.Enabled = true;
        }

        private void DesabilitarBotones()
        {
            //Desabilitamos 
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            txtBuscar.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void DesabilitarCli()
        {
            //Desabilitamos Cliente
            txtNomCli.ReadOnly = true;
            cboTipoCli.Enabled = false;
            cboVendedor.Enabled = false;
            btnBusqVendedor.Enabled = false;
            txtTelf.ReadOnly = true;
            txtPagWeb.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            numUpDownLimCred.Enabled = false;
            numUpDownPlazo.Enabled = false;
            ckbxEstLimCred.Enabled = false;
            ckbxFactMorosas.Enabled = false;
        }
        
        private void DesabilitarUbic()
        {
            //Desabilitamos Ubicacion
            txtDpto.ReadOnly = true;
            cboPais.Enabled = false;
            cboCiudad.Enabled = false;
            txtZona.ReadOnly = true;
            txtBarrio.ReadOnly = true;
            txtDireccion.ReadOnly = true;
        }

        private void DesabilitarUsuCli()
        {
            //Desabilitamos Usuario Clientes
            txtUsua.ReadOnly = true;
            txtPass.ReadOnly = true;
            chkHabil.Enabled = false;
        }

        private void DesabilitarContac()
        {
            txtNomContact.ReadOnly = true;
            txtCargoContact.ReadOnly = true;
            txtDptoContact.ReadOnly = true;
            txtTelfContact.ReadOnly = true;
            txtCelularContact.ReadOnly = true;
            txtPagWebContact.ReadOnly = true;
            txtEmailContact.ReadOnly = true;
        }

        private void DesabilitarRedSoc()
        {
            txtLink.ReadOnly = true;
        }

        private void DesabilitarNomFact()
        {
            txtNomFact.ReadOnly = true;
            txtNIT.ReadOnly = true;
        }

        private void DesabilitarDocto()
        {
            cboTipoDoc.Enabled = false;
            txtPalClave.ReadOnly = true;
            txtDesc.ReadOnly = true;
        }

        #endregion

        #region Conexion Capa Negocios

        private void ListarTipoCliente()
        {
            try
            {
                cboTipoCli.DataSource = NListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo WHERE Tupla='Cliente' AND Estado=1 ORDER BY NomTipo");
                cboTipoCli.DisplayMember = "NomTipo";
                cboTipoCli.ValueMember = "TipoID";
                cboTipoCli.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPais()
        {
            try
            {
                cboPais.DataSource = NListarPersonalizado.ConsultarDT("SELECT PaisID, NomPais FROM Pais ORDER BY NomPais");
                cboPais.DisplayMember = "NomPais";
                cboPais.ValueMember = "PaisID";
                cboPais.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarClientes()
        {
            try
            {
                //Enviamos por parametros -1 para que cargue todos los clientes
                LCli = NListarPersonalizado.ConsultarDT("SELECT TOP 100 * FROM Vista_Clientes WHERE ClienteID<>1 " +
                            "AND NomClien LIKE '%" + txtBuscar.Text.Trim() + "%' ORDER BY ClienteID DESC");
                dgvClientes.DataSource = LCli;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListarVendedor()
        {
            try
            {
                cboVendedor.DataSource = NListarPersonalizado.ConsultarDT("SELECT PersonalID, NomPer FROM Personal WHERE CargoID=2 AND Estado=1 " +
                            "UNION SELECT -1, ''");
                cboVendedor.DisplayMember = "NomPer";
                cboVendedor.ValueMember = "PersonalID";
                cboVendedor.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarContactos()
        {
            try
            {
                //mandamos por parametro proveedor y el codigo del proveedor
                CargarContactos(NContacto.NListarContacto("Cliente", int.Parse(txtClienteID.Text)));
            }
            catch (Exception)
            {
                NombreColumnasContac();
                BorrarCampos(gbxDatosContact, "");
            }
        }

        private void ListarRedesSoc()
        {
            try
            {
                LRedSoc = NRedesSociales.NListarRedSoc(Convert.ToInt32(txtClienteID.Text), "Cliente");
                CargarRedesSoc(LRedSoc);
            }
            catch (Exception)
            {
                NombreColumnasRedesSoc();
                BorrarCampos(gbxRedSoc, "");
            }
        }

        private void ListarNombreFactura()
        {
            try
            {
                CargarNomFact(NNombreFactura.NListarNomFact("Cliente", Convert.ToInt32(txtClienteID.Text)));
            }
            catch (Exception)
            {
                NombreColumnasNomFact();
                BorrarCampos(gbxNomFact, "");
            }
        }

        private void ListarDocumentos()
        {
            try
            {
                CargarDocto(NDocumento.NListarDoc("Cliente", txtClienteID.Text));
            }
            catch
            {
                NombreColumnasDocto();
                BorrarCampos(gbxDoctos, "");
            }
        }

        private void ListarUsuariosCli()
        {
            try
            {
                CargarUsuCli(NClienteUsuario.DListarCliUsu(Convert.ToInt32(txtClienteID.Text)));
            }
            catch
            {
                NombreColumnasUsuCli();
                BorrarCampos(gbxUsuaCli, "");
            }
        }

        private bool VerificarCli()
        {
            if (string.IsNullOrWhiteSpace(txtNomCli.Text))
            {
                MessageBox.Show("INGRESE EL NOMBRE DEL CLIENTE", "NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomCli.Focus();
                return false;
            }
            else if ((int)cboTipoCli.SelectedValue == -1)
            {
                MessageBox.Show("SELECCIONE EL TIPO DE CLIENTE", "TIPO DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoCli.Focus();
                return false;
            }
            else if (cboPais.Text == "")
            {
                MessageBox.Show("SELECCIONE UN PAÍS VÁLIDO", "PAÍS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPais.Focus();
                return false;
            }

            return true;
        }

        private void InsertModifCli()
        {
            if (!VerificarCli())
                return;

            OCliente cli = null;
            OUbicacion ubic = null;

            try
            {
                btnGuardar.Enabled = false;

                string DetalleInmode=string.Empty;
                cli = new OCliente();
                if (Opcion == "Nuevo")
                    cli.ClienteID = -1;
                else
                {
                    cli.ClienteID = int.Parse(txtClienteID.Text);

                    //Cargamos Detalle Anulado
                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("Modificar");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();
                    DetalleInmode = dmodanul.DetaModAnul();
                }

                cli.NomClien = txtNomCli.Text.ToUpper();
                cli.TipoClienteID = (int)cboTipoCli.SelectedValue;
                cli.VendedorID = Convert.ToInt32(cboVendedor.SelectedValue);
                cli.Telf = txtTelf.Text;
                cli.PagWeb = txtPagWeb.Text;
                cli.Correo = txtCorreo.Text;
                cli.LimiteCredito = numUpDownLimCred.Value;
                cli.PlazoPago = Convert.ToInt32(numUpDownPlazo.Value);
                cli.EstadoLimCredit = ckbxEstLimCred.Checked;
                cli.EstadoFactMorosas = ckbxFactMorosas.Checked;

                //Ubicaion
                ubic = new OUbicacion();
                ubic.Ciudad = cboCiudad.Text;
                ubic.Direccion = txtDireccion.Text.Trim();
                ubic.DptoEstado = txtDpto.Text;
                ubic.PaisID = (int)cboPais.SelectedValue;
                ubic.Zona = txtZona.Text.Trim();
                ubic.Barrio = txtBarrio.Text.Trim();

                int resp = NCliente.NInsertModifCli(cli, ubic, OInmode.DTInmode("", Opcion, DetalleInmode));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Abrimos cargando....
                    op.AbrirCargando("CARGANDO.....");

                    Opcion = string.Empty;
                    cli = null;
                    ubic = null;
                    BorrarCampos(gbxDatosBasic, "");
                    BorrarCampos(gbxDatos, "");
                    BorrarCampos(gbxPagos, "");

                    HabilitarBotones();
                    DesabilitarCli();
                    ListarClientes();
                }
            }
            catch (Exception ex)
            {
                btnGuardar.Enabled = true;
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cli != null)
                    cli = null;
                if (ubic != null)
                    ubic = null;

                //Cerramos Cargando
                op.CerrarCargando();
            }
        }

        private void InsertModifContac()
        {
            try
            {
                //Objeto Contacto
                OContacto contact = new OContacto();
                if (Opcion == "Nuevo Contacto")
                    contact.ContactoID = -1;
                else
                    contact.ContactoID = Convert.ToInt32(txtContactID.Text);

                contact.NomContact = txtNomContact.Text;
                contact.Cargo = txtCargoContact.Text;
                contact.Dpto = txtDptoContact.Text;
                contact.Telf = txtTelfContact.Text;
                contact.Celular = txtCelularContact.Text;
                contact.PagWeb = txtPagWebContact.Text;
                contact.Correo = txtEmailContact.Text;

                int resp = NContacto.NInsertModifContacto(int.Parse(txtClienteID.Text), "Cliente", contact, InsertInnmode("Contactos"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando...
                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    BorrarCampos(gbxDatosContact, "");

                    //HabilitarBotones();
                    DesabilitarContac();

                    ListarContactos();
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

        private void InsertModifRedSoc()
        {
            try
            {
                //Objeto Red Social
                ORedesSociales redsoc = new ORedesSociales();
                if (Opcion == "Nueva Red Social")
                    redsoc.RedSocialID = -1;
                else
                    redsoc.RedSocialID = Convert.ToInt32(txtRedSocID.Text);

                redsoc.Link = txtLink.Text;

                int resp = NRedesSociales.NInsertModifRedSoc(redsoc, InsertInnmode("Red Social"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando.....
                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    BorrarCampos(gbxRedSoc, "");

                    //HabilitarBotones();
                    DesabilitarRedSoc();

                    ListarRedesSoc();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModifNomFact()
        {
            try
            {
                //Objeto NomFact
                ONombreFactura nfact = new ONombreFactura();
                if (Opcion == "Nuevo NIT")
                    nfact.NomFactID = -1;
                else
                    nfact.NomFactID = Convert.ToInt32(txtNomFactID.Text);

                nfact.ClienteID = Convert.ToInt32(cboPais.SelectedValue);
                nfact.NIT = txtNIT.Text;
                nfact.NomFact = txtNomFact.Text;
                nfact.ClienteID = Convert.ToInt32(txtClienteID.Text);;
                nfact.ProveedorID = -1; 

                int resp = NNombreFactura.NInsertModifNomFact(nfact, InsertInnmode("Facturas"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando....
                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    BorrarCampos(gbxNomFact, "");

                    //HabilitarBotones();
                    DesabilitarNomFact();

                    ListarNombreFactura();
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

        private void InsertModifDocto()
        {
            try
            {
                if ((Opcion == "Nuevo Documento") && (RutaDocto == string.Empty))
                    throw new Exception("Tiene que cargar un Documento");

                ODocumento d = new ODocumento();
                d.CodDocumento = txtCodDoc.Text;
                d.NomDcto = txtNomDoc.Text;
                d.PalClave = txtPalClave.Text;
                d.TipoDcto = cboTipoDoc.Text;
                d.Formato = txtFormato.Text;
                d.Descripcion = txtDesc.Text;


                FileStream fs = new FileStream(RutaDocto, FileMode.Open);
                //Creamos un array de bytes para almacenar los datos leídos por fs.
                byte[] Docto = new byte[fs.Length];
                //Y guardamos los datos en el array Docto
                fs.Read(Docto, 0, Convert.ToInt32(fs.Length));
                d.Doc = Docto;
                fs.Close();

                //mandamos por parametro 
                int resp = NDocumento.NInsertModifDoc(d, "Cliente", txtClienteID.Text, InsertInnmode("Documentos"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando
                    op.AbrirCargando("Cargando....");

                    Opcion = string.Empty;
                    RutaDocto = string.Empty;
                    BorrarCampos(gbxDoctos, "");

                    //HabilitarBotones();
                    DesabilitarDocto();

                    ListarDocumentos();
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

        private void InsertModifUsuCli()
        {
            try
            {
                if ((Opcion == "Nuevo Usuario Cliente") &&
                    ((txtUsua.Text == string.Empty) || (txtPass.Text == string.Empty)))
                    throw new Exception("Ingrese un usuario y contraseña válido");

                OClienteUsuario cu = new OClienteUsuario();
                Encriptar enc = new Encriptar(txtPass.Text);

                if (txtUsuCliID.Text == string.Empty)
                    cu.ClienteUsuarioID = -1;
                else
                    cu.ClienteUsuarioID = Convert.ToInt32(txtUsuCliID.Text);

                cu.ClienteID = Convert.ToInt32(txtClienteID.Text);
                cu.NomUsuCli = txtUsua.Text;
                cu.Contrasenia = enc.Encriptador();
                cu.Estado = chkHabil.Checked;
                
                //mandamos por parametro 
                int resp = NClienteUsuario.NInsertModifCliUsu(cu, InsertInnmode("UsuCli"));
                if (resp > 0)
                {
                    MessageBox.Show("Los datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando
                    op.AbrirCargando("Cargando....");

                    Opcion = string.Empty;
                    BorrarCampos(gbxUsuaCli, "");

                    //HabilitarBotones();
                    DesabilitarUsuCli();

                    ListarUsuariosCli();
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

        private DataTable InsertInnmode(string opc)
        {
            string CodInmode = string.Empty;
            string DetalleInmode = string.Empty;

            switch (opc)
            {
                case "Cliente":
                    CodInmode = CodInmodeCli;
                    break;
                case "Contactos":
                    CodInmode = CodInmodeContac;
                    break;
                case "Ubicacion":
                    CodInmode = CodInmodeUbic;
                    break;
                case "Facturas":
                    CodInmode = CodInmodeNomFact;
                    break;
                case "Documentos":
                    CodInmode = CodInmodeDocto;
                    break;
                case "Red Social":
                    CodInmode = CodInmodeRedSoc;
                    break;
                case "UsuCli":
                    CodInmode = CodInmodeUsuCli;
                    break;
            }

            if ((Opcion != "Nuevo") && (Opcion != "Nuevo Contacto") && (Opcion != "Nueva Ubicacion") && (Opcion != "Nuevo NIT") &&
                (Opcion != "Nuevo Documento") && (Opcion != "Nueva Red Social") && (Opcion != "Nuevo Usuario Cliente"))
            {
                //Cargamos Detalle Modificar
                Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(opc);
                dmodanul.Owner = this;
                dmodanul.ShowDialog();
                DetalleInmode = dmodanul.DetaModAnul();
            }

            return OInmode.DTInmode(CodInmode, Opcion.Substring(0, 5), DetalleInmode);
        }

        private void AnulRestau(string codigo, string tupla, int estado, string o)
        {
            try
            {
                OpcionFormularios ofor = new OpcionFormularios();
                OInmode inm = new OInmode();

                if (tupla == "Cliente")
                    inm.CodInmode = CodInmodeCli;
                else if (tupla == "Contactos")
                    inm.CodInmode = CodInmodeContac;
                else if (tupla == "Ubicacion")
                    inm.CodInmode = CodInmodeUbic;
                else if (tupla == "Redes Sociales")
                    inm.CodInmode = CodInmodeRedSoc;
                else if (tupla == "Nombre Factura")
                    inm.CodInmode = CodInmodeNomFact;
                else if (tupla == "Documentos")
                    inm.CodInmode = CodInmodeDocto;

                inm.TipoInmode = o;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                //Cargamos Detalle Anulado
                Frm_DetaModifAnul anul = new Frm_DetaModifAnul("Anular " + tupla);
                anul.Owner = this;
                anul.ShowDialog();
                inm.DetalleInmode = anul.DetaModAnul();

                bool resp = NListarPersonalizado.AnulRestau(codigo, tupla, "", "", "Anular", false);  //NCliente.NAnulRestauCli(codigo, tupla, estado, inm);
                if (resp)
                {
                    MessageBox.Show("Los datos se Actualizaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando.....
                    op.AbrirCargando("Cargando.....");

                    switch (tabClientes.SelectedIndex)
                    {
                        case 0:
                            ListarClientes();
                            break;
                        case 1:
                            ListarContactos();
                            break;
                        case 2:
                            ListarRedesSoc();
                            break;
                        case 3:
                            ListarNombreFactura();
                            break;
                        case 4:
                            ListarDocumentos();
                            break;
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

        
        private void CargarContactos(List<OContacto> lcontact)
        {
            if (lcontact != null)
            {
                NombreColumnasContac();

                int cont = 0;
                foreach (var item in lcontact)
                {
                    dgvContactos.Rows.Add(item.ContactoID, item.NomContact, item.Cargo, item.Dpto, item.Telf, item.Celular,
                                         item.PagWeb, item.Correo, item.Estado);
                    if (!item.Estado)
                    {
                        dgvContactos.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    cont++;
                }
            }
            else
                NombreColumnasContac();
        }

        private void CargarRedesSoc(List<ORedesSociales> lredsoc)
        {
            if (lredsoc != null)
            {
                NombreColumnasRedesSoc();
                int cont = 0;
                foreach (var item in lredsoc)
                {
                    dgvRedesSoc.Rows.Add(item.RedSocialID, item.Link);

                    if (!item.Estado)
                        dgvRedesSoc.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvRedesSoc.Refresh();
            }
            else
                NombreColumnasRedesSoc();
        }

        private void CargarNomFact(List<ONombreFactura> lnomfact)
        {
            if (lnomfact != null)
            {
                NombreColumnasNomFact();
                int cont = 0;
                foreach (var item in lnomfact)
                {
                    dgvNomFact.Rows.Add(item.NomFactID, item.NomFact, item.NIT, item.Estado);

                    if (!item.Estado)
                        dgvNomFact.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
            }
            else
                NombreColumnasNomFact();
        }

        private void CargarDocto(List<ODocumento> ldoc)
        {
            try
            {
                NombreColumnasDocto();

                int cont = 0;
                foreach (var item in ldoc)
                {
                    dgvDoctos.Rows.Add(item.CodDocumento, item.NomDcto, item.Formato, item.TipoDcto, item.Descripcion);

                    if (!item.Estado)
                        dgvDoctos.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvDoctos.Refresh();
            }
            catch (Exception)
            {
                NombreColumnasDocto();
            }
        }

        private void CargarUsuCli(List<OClienteUsuario> lusucli)
        {
            try
            {
                //NombreColumnas
                NombreColumnasUsuCli();

                int cont = 0;
                foreach (var item in lusucli)
                {
                    dgvUsuariosCli.Rows.Add(item.ClienteUsuarioID, item.NomUsuCli, item.Contrasenia, item.Estado);

                    if (!item.Estado)
                        dgvUsuariosCli.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvUsuariosCli.Refresh();
            }
            catch (Exception)
            {
                NombreColumnasUsuCli();
            }
        }

        private void BuscarCli()
        {
            if (LCli.Rows.Count > 0)
            {
                if (txtBuscar.Text != string.Empty)
                {
                    DataRow[] lclibusq = LCli.Select("NomClien LIKE '%" + txtBuscar.Text.Trim() + "%'");
                    dgvClientes.DataSource = lclibusq.CopyToDataTable();
                }
            }
        }

        private void SeleccionarListCli(DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows.Count == 0)
                return;

            if(Opcion == string.Empty)
            {
                BorrarCampos(gbxDatosBasic, "");
                BorrarCampos(gbxDatos, "");
                BorrarCampos(gbxPagos, "");
                BorrarCampos(gbxUbicacion, "");
                BorrarCampos(gbxUsuaCli, "");

                CodInmodeCli = dgvClientes["CodInmode", e.RowIndex].Value.ToString();
                EstadoCli = Convert.ToBoolean(dgvClientes["Estado", e.RowIndex].Value);
                txtClienteID.Text = dgvClientes["ClienteID", e.RowIndex].Value.ToString();
                txtNomCli.Text = dgvClientes["NomClien", e.RowIndex].Value.ToString();
                cboTipoCli.Text = dgvClientes["TipoClien", e.RowIndex].Value.ToString();
                cboVendedor.Text = dgvClientes["NomVendedor", e.RowIndex].Value.ToString();
                txtTelf.Text = dgvClientes["Telf", e.RowIndex].Value.ToString();
                txtPagWeb.Text = dgvClientes["PagWeb", e.RowIndex].Value.ToString();
                txtCorreo.Text = dgvClientes["Correo", e.RowIndex].Value.ToString();
                numUpDownLimCred.Value = Convert.ToDecimal(dgvClientes["LimiteCredito", e.RowIndex].Value);
                numUpDownPlazo.Value = Convert.ToDecimal(dgvClientes["PlazoPago", e.RowIndex].Value);
                ckbxEstLimCred.Checked = Convert.ToBoolean(dgvClientes["EstadoLimCredit", e.RowIndex].Value);
                ckbxFactMorosas.Checked = Convert.ToBoolean(dgvClientes["EstadoFactMorosas", e.RowIndex].Value);  

                //Ubicacion
                cboPais.SelectedValue = dgvClientes["PaisID", e.RowIndex].Value.ToString();
                txtDpto.Text = dgvClientes["DptoEstado", e.RowIndex].Value.ToString();
                cboCiudad.Text = dgvClientes["Ciudad", e.RowIndex].Value.ToString();
                txtZona.Text = dgvClientes["Zona", e.RowIndex].Value.ToString();
                txtBarrio.Text = dgvClientes["Barrio", e.RowIndex].Value.ToString();
                txtDireccion.Text = dgvClientes["Direccion", e.RowIndex].Value.ToString();
            }
        }

        private void SeleccionarListContac(DataGridViewCellEventArgs e)
        {
            if(Opcion == string.Empty)
            {
                BorrarCampos(gbxDatosContact, "");
                try
                {
                    txtContactID.Text = dgvContactos["Codigo", e.RowIndex].Value.ToString();

                    //Buscamos por codigo de Contacto
                    OContacto objcon = NContacto.NSeleccionarContacto(txtContactID.Text);
                    if (objcon != null)
                    {
                        CodInmodeContac = objcon.CodInmode;
                        EstadoContac = objcon.Estado;

                        txtNomContact.Text = objcon.NomContact;
                        txtCargoContact.Text = objcon.Cargo;
                        txtDptoContact.Text = objcon.Dpto;
                        txtTelfContact.Text = objcon.Telf;
                        txtCelularContact.Text = objcon.Celular;
                        txtPagWebContact.Text = objcon.PagWeb;
                        txtEmailContact.Text = objcon.Correo;
                    }
                }
                catch
                {
                    BorrarCampos(gbxDatosContact, "");
                }
            }
        }

        private void SeleccionarListRedeSoc(DataGridViewCellEventArgs e)
        {
            if(Opcion == string.Empty)
            {
                BorrarCampos(gbxRedSoc, "");

                try
                {
                    int codredsoc = Convert.ToInt32(dgvRedesSoc["Codigo", e.RowIndex].Value.ToString());

                    ORedesSociales oredsoc = LRedSoc.Find(x => x.RedSocialID == codredsoc);
                    if (oredsoc != null)
                    {
                        txtRedSocID.Text = oredsoc.RedSocialID.ToString();
                        txtLink.Text = oredsoc.Link;
                    }
                }
                catch (Exception)
                {
                    BorrarCampos(gbxRedSoc, "");
                }
            }
        }

        private void SeleccionarListNomFact(DataGridViewCellEventArgs e)
        {
            if (Opcion == string.Empty)
            {
                try
                {
                    BorrarCampos(gbxNomFact, "");
                    txtNomFactID.Text = dgvNomFact["Codigo", e.RowIndex].Value.ToString();

                    //Buscamos por codigo de Nombre Facturas
                    ONombreFactura objnomfact = NNombreFactura.NSeleccionarNomFact(txtNomFactID.Text);

                    if (objnomfact != null)
                    {
                        CodInmodeNomFact = objnomfact.CodInmode;
                        EstadoNomFact = objnomfact.Estado;

                        txtNomFact.Text = objnomfact.NomFact;
                        txtNIT.Text = objnomfact.NIT;
                    }
                }
                catch (Exception)
                {
                    BorrarCampos(gbxNomFact, "");
                }
            }
        }

        private void SeleccionarListDoctos(DataGridViewCellEventArgs e)
        {
            if(Opcion == string.Empty)
            {
                BorrarCampos(gbxDoctos, "");
                try
                {
                    txtCodDoc.Text = dgvDoctos["Codigo", e.RowIndex].Value.ToString();

                    //Buscamos por codigo de Documento
                    ODocumento objdocto = NDocumento.NSeleccionarDocto(txtCodDoc.Text, "Cliente");

                    if (objdocto != null)
                    {
                        CodInmodeDocto = objdocto.CodInmode;
                        EstadoDocto = objdocto.Estado;

                        txtNomDoc.Text = objdocto.NomDcto;
                        cboTipoDoc.Text = objdocto.TipoDcto;
                        txtFormato.Text = objdocto.Formato;
                        txtPalClave.Text = objdocto.PalClave;
                        txtDesc.Text = objdocto.Descripcion;
                    }
                }
                catch (Exception)
                {
                    BorrarCampos(gbxDoctos, ""); 
                }
            }
        }

        private void SeleccionarListCliUsu(DataGridViewCellEventArgs e)
        {
            if (Opcion == string.Empty)
            {
                BorrarCampos(gbxUsuaCli, "");
                try
                {
                    txtUsuCliID.Text = dgvUsuariosCli["ID", e.RowIndex].Value.ToString();

                    //Buscamos por codigo de Documento
                    OClienteUsuario objcliusu = NClienteUsuario.NSeleccionarCliUsu(txtUsuCliID.Text);

                    if (objcliusu != null)
                    {
                        CodInmodeUsuCli = objcliusu.CodInmode;
                        EstadoUsuCli = objcliusu.Estado;

                        txtUsua.Text = objcliusu.NomUsuCli;
                        txtPass.Text = objcliusu.Contrasenia;
                        chkHabil.Checked = objcliusu.Estado;
                    }
                }
                catch (Exception)
                {
                    BorrarCampos(gbxUsuaCli, "");
                }
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
            switch(tabClientes.SelectedIndex)
            {
                case 0:
                    BorrarCampos(gbxDatosBasic, "");
                    BorrarCampos(gbxDatos, "");
                    BorrarCampos(gbxPagos, "0.00");
                    BorrarCampos(gbxUbicacion, "");
                    numUpDownLimCred.Value = 20000;
                    numUpDownPlazo.Value = 30;

                    DesabilitarBotones();
                    HabilitarCli();
                    HabilitarUbic();
                    
                    Opcion = "Nuevo";
                    break;
                case 1:
                    BorrarCampos(gbxDatosContact, "");
                    DesabilitarBotones();
                    HabilitarContac();
                    Opcion = "Nuevo Contacto";
                    break;               
                case 2:
                    BorrarCampos(gbxRedSoc, "");
                    DesabilitarBotones();
                    HabilitarRedSoc();
                    Opcion = "Nueva Red Social";
                    break;
                case 3:
                    BorrarCampos(gbxNomFact, "");
                    DesabilitarBotones();
                    HabilitarNomFact();
                    Opcion = "Nuevo NIT";
                    break;
                case 4:
                    BorrarCampos(gbxDoctos, "");
                    DesabilitarBotones();
                    HabilitarDocto();
                    Opcion = "Nuevo Documento";
                    break;
                case 5: //contraseña cliente
                    BorrarCampos(gbxUsuaCli, "");
                    DesabilitarBotones();
                    HabilitarUsuaCli();
                    Opcion = "Nuevo Usuario Cliente";
                    break;
            }            
        }

        private void Modif()
        {
            switch(tabClientes.SelectedIndex)
            {
                case 0:
                    if (txtClienteID.Text != string.Empty)
                    {
                        DesabilitarBotones();
                        HabilitarCli();
                        HabilitarUbic();
                        Opcion = "Modificar";
                    }
                    break;
                case 1:
                    if (txtContactID.Text != string.Empty)
                    {
                        DesabilitarBotones();
                        HabilitarContac();
                        Opcion = "Modificar Contacto";
                    }
                    break;
                case 2:
                    if (txtRedSocID.Text != string.Empty)
                    {
                        DesabilitarBotones();
                        HabilitarRedSoc();
                        Opcion = "Modificar Red Social";
                    }
                    break;
                case 3:
                    if (txtNomFactID.Text != string.Empty)
                    {
                        DesabilitarBotones();
                        HabilitarNomFact();
                        Opcion = "Modificar Nombre Factura";
                    }
                    break;
                case 4:
                    if (txtCodDoc.Text != string.Empty)
                    {
                        DesabilitarBotones();
                        HabilitarDocto();
                        Opcion = "Modificar Documneto";
                    }
                    break;
                case 5:
                    if (txtUsua.Text != string.Empty)
                    {
                        DesabilitarBotones();
                        HabilitarUsuaCli();
                        Opcion = "Modificar Usuario Cliente";
                    }
                    break;
            }
        }

        private void Cancelar()
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Opcion = string.Empty;
                RutaDocto = string.Empty;

                //Borramos datos
                BorrarCampos(gbxDatos, "");
                BorrarCampos(gbxDatosBasic, "");
                BorrarCampos(gbxDatosContact, "");
                BorrarCampos(gbxDoctos, "");
                BorrarCampos(gbxNomFact, "");
                BorrarCampos(gbxPagos, "");
                BorrarCampos(gbxRedSoc, "");
                BorrarCampos(gbxUbicacion, "");
                BorrarCampos(gbxUsuaCli, "");

                //desabilitar
                DesabilitarCli();
                DesabilitarContac();
                DesabilitarDocto();
                DesabilitarNomFact();
                DesabilitarRedSoc();
                DesabilitarUbic();
                DesabilitarUsuCli();
                HabilitarBotones();
                
                //cargar datos
                CargarContactos(NContacto.NCargarContacto());
                CargarNomFact(NNombreFactura.NCargarNomFact());
                CargarDocto(NDocumento.NCargarDoc("Cliente"));
                CargarUsuCli(NClienteUsuario.NCargarCliUsu());
                CargarRedesSoc(LRedSoc);
            }
        }

        private void Registro()
        {
            Frm_Inmode inm = null;

            switch(tabClientes.SelectedIndex)
            {
                case 0:
                    if (txtClienteID.Text != string.Empty)
                    {
                        inm = new Frm_Inmode(CodInmodeCli);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 1:
                    if (txtContactID.Text != string.Empty)
                    {
                        inm = new Frm_Inmode(CodInmodeContac);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 2:
                    if (txtRedSocID.Text != string.Empty)
                    {
                        inm = new Frm_Inmode(CodInmodeRedSoc);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 3:
                    if (txtNomFactID.Text != string.Empty)
                    {
                        inm = new Frm_Inmode(CodInmodeNomFact);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 4:
                    if (txtCodDoc.Text != string.Empty)
                    {
                        inm = new Frm_Inmode(CodInmodeDocto);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 5:
                    if (txtUsuCliID.Text != string.Empty)
                    {
                        inm = new Frm_Inmode(CodInmodeUsuCli);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
            }
        }

        private void ExaminarDoc()
        {
            try
            {
                if (Opcion != string.Empty)
                {
                    openFileDialog.Title = "Seleccionar una Documento";
                    openFileDialog.FileName = "";

                    if (cboTipoDoc.Text == "PDF (.pdf)")
                        openFileDialog.Filter = "PDF|*.pdf";
                    else if (cboTipoDoc.Text == "WORD (.doc, .docx, .docm, .dotx, .dotm)")
                        openFileDialog.Filter = "docx|*.docx|doc|*.doc";
                    else if (cboTipoDoc.Text == "EXCEL (.xlsx, .xls, .xlsm, .xlsb, .xlam)")
                        openFileDialog.Filter = "xlsx|*.xlsx|xls|*.xls|xlsm|*.xlsm|xlsb|*.xlsb|xlam|*.xlam";
                    else if (cboTipoDoc.Text == "POWER POINT (.ppt, .pptx, .pptm, .potx, .potm, .ppam, .ppsx, .ppsm, .sldx, .sldm, .thmx)")
                        openFileDialog.Filter = "pptx|*.pptx|ppt|*.ppt|pptm|*.pptm|potx|*.potx|potm|*.potm|ppam|*.ppam|ppsx|*.ppsx|ppsm|*.ppsm|sldx|*.sldx|sldm|*.sldm|thmx|*.thmx";
                    else if (cboTipoDoc.Text == "TEXTO (.txt, .xml)")
                        openFileDialog.Filter = "txt|*.txt|xml|*.xml";
                    else if (cboTipoDoc.Text == "IMAGEN (.jpg, .png, .gif, .bmp)")
                        openFileDialog.Filter = "jpg|*.jpg|png|*.png|gif|*.gif|bmp|*.bmp";
                    else if (cboTipoDoc.Text == "AUDIO")
                        openFileDialog.Filter = "mp3|*.mp3";
                    else if (cboTipoDoc.Text == "VIDEO")
                        openFileDialog.Filter = "avi|*.avi|jpeg|*.jpeg|mp4|*.mp4";
                    else if (cboTipoDoc.Text == "COMPRIMIDO (.zip)")
                        openFileDialog.Filter = "ZIP|*.zip";

                    openFileDialog.ShowDialog();

                    if (openFileDialog.FileName != "")
                    {
                        RutaDocto = openFileDialog.FileName;
                        txtNomDoc.Text = Path.GetFileName(openFileDialog.FileName);
                        txtFormato.Text = Path.GetExtension(openFileDialog.FileName);
                    }
                }
                else
                {
                    if (txtCodDoc.Text != string.Empty)
                    {
                        //abrimos cargando
                        op.AbrirCargando("Cargando.....");

                        //buscamos el docto en la db
                        string sFile = Application.StartupPath;
                        RutaDocto = NDocumento.NGenerarDoc(txtCodDoc.Text, sFile, txtFormato.Text);
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

        private void SeleccionarVentana()
        {
            op.AbrirCargando("Cargando....");

            switch (tabClientes.SelectedIndex)
            {
                case 1:
                    ListarContactos();
                    break;
                case 2:
                    ListarRedesSoc();
                    break;
                case 3:
                    ListarNombreFactura();
                    break;
                case 4:
                    ListarDocumentos();
                    break;
                case 5:
                    ListarUsuariosCli();
                    break;
            }

            op.CerrarCargando();
        }

        private void OpcionInsertModif()
        {
            if ((Opcion == "Nuevo") || (Opcion == "Modificar"))
                InsertModifCli();
            else if ((Opcion == "Nuevo Contacto") || (Opcion == "Modificar Contacto"))
                InsertModifContac();
            else if ((Opcion == "Nueva Red Social") || (Opcion == "Modificar Red Social"))
                InsertModifRedSoc();
            else if ((Opcion == "Nuevo NIT") || (Opcion == "Modificar Nombre Factura"))
                InsertModifNomFact();
            else if ((Opcion == "Nuevo Documento") || (Opcion == "Modificar Documento")) //documento
                InsertModifDocto();
            else if ((Opcion == "Nuevo Usuario Cliente") || (Opcion == "Modificar Usuario Cliente"))
                InsertModifUsuCli();
        }

        private void OpcionAnularRestau(string op, int es)
        {
            if (txtClienteID.Text != string.Empty)
            {
                DialogResult result;
                switch (tabClientes.SelectedIndex)
                {
                    case 0:
                        if (((es == 0) && (EstadoCli)) || ((es == 1) && (!EstadoCli)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " al Cliente " + txtClienteID.Text + "?", op + " Cliente", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                                AnulRestau(txtClienteID.Text, "Cliente", es, op);
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el Cliente no se puede " + op, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 1:
                        if (((es == 0) && (EstadoContac)) || ((es == 1) && (!EstadoContac)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " al Contacto" + txtNomContact.Text + "?", op + " Contacto", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                AnulRestau(txtContactID.Text, "Contacto", es, op);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el Contacto no se puede " + op, "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 2:
                        if (((es == 0) && (EstadoRedSoc)) || ((es == 1) && (!EstadoRedSoc)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " el Link " + txtLink.Text + "?", op + " Redes Sociales", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                AnulRestau(txtNomFactID.Text, "Redes Sociales", es, op);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el Nombre de Factura no se puede " + op, "Nombre Factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 3:
                        if (((es == 0) && (EstadoNomFact)) || ((es == 1) && (!EstadoNomFact)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " el Nombre de Factura " + txtNomFact.Text + "?", op + " Nombre Factura", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                AnulRestau(txtNomFactID.Text, "Nombre Factura", es, op);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el Nombre de Factura no se puede " + op, "Nombre Factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 4:
                        if (((es == 0) && (EstadoDocto)) || ((es == 1) && (!EstadoDocto)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " el Documento " + txtNomDoc.Text + "?", op + " Documento", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                AnulRestau(txtNomFactID.Text, "Documento", es, op);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el Documento no se puede " + op, "Documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 5:
                        if (((es == 0) && (EstadoUsuCli)) || ((es == 1) && (!EstadoUsuCli)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " el usuario " + txtUsua.Text + "?", op + " Usuario", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                AnulRestau(txtUsuCliID.Text, "UsuCli", es, op);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el usuario no se puede " + op, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("No puede " + op + " porque no hay un Proveedor seleccionado", op, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Eventos Formulario

        private void Cliente_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            cboTipoDoc.Text = "PDF (.pdf)";
            cboCiudad.Text = OConexionGlobal.Ciudad;

            ListarTipoCliente();
            ListarPais();
            ListarVendedor();
            ListarClientes();
            NombreColumnasCli();

            //HabilitarBotones();
            DesabilitarCli();

            if (frmcli != null)
            {
                DesabilitarContac();
                DesabilitarDocto();
                DesabilitarNomFact();
                DesabilitarRedSoc();
                DesabilitarUbic();
                DesabilitarUsuCli();
                HabilitarBotones();
            }
            else
            {
                tabPage3.Parent = null;
                tabPage4.Parent = null;
                tabPage5.Parent = null;
                tabPage6.Parent = null;
            }

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
            OpcionAnularRestau("Anular", 0);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            OpcionAnularRestau("Restaurar", 1);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            ListarVendedor();
            ListarClientes();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            OpcionInsertModif();
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
                ListarClientes(); //dgvClientes.DataSource = LCli;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (txtBuscar.Text != string.Empty)
                    ListarClientes(); //BuscarCli();
        }

        private void dgvClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListCli(e);
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmcli != null)
            {
                frmcli.Dispose();
                frmcli = null;
            }            
        }

        private void tabClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarVentana();
        }

        private void dgvRedesSoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListRedeSoc(e);
        }

        private void dgvContactos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListContac(e);
        }

        private void dgvNomFact_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListNomFact(e);
        }

        private void dgvDoctos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListDoctos(e);
        }

        private void btnBusDoc_Click(object sender, EventArgs e)
        {
            ExaminarDoc();
        }

        private void dgvUsuariosCli_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListCliUsu(e);
        }

        #endregion

    }
}

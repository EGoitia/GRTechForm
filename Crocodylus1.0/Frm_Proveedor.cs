using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Printing;
using System.Reflection;
using System.IO;

using Objetos;
using Negocio;
using System.Configuration;
using Datos;

namespace GRTechnology1._0
{
    public partial class Frm_Proveedor : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        public static Frm_Proveedor prov = null;
        public bool Seleccionado = false;

        bool EstadoProv = false;
        bool EstadoContac = false;
        bool EstadoUbic = false;
        bool EstadoNomFact = false;
        bool EstadoDocto = false;
        bool EstadoRedSoc = false;

        string CodInmodeProv = string.Empty;
        string CodInmodeContac = string.Empty;
        string CodInmodeUbic = string.Empty;
        string CodInmodeNomFact = string.Empty;
        string CodInmodeDocto = string.Empty;
        string CodInmodeRedSoc = string.Empty;
        string CodUbic = string.Empty;
        string Opcion = string.Empty;
        string RutaDocto = string.Empty;

        DataTable LPais = null;

        public Frm_Proveedor()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnasListProv()
        {
            dgvProveedores.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 50;
            c1.Name = "Codigo";
            dgvProveedores.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 150;
            c2.Name = "Nombre";
            dgvProveedores.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 100;
            c3.Name = "Tipo";
            dgvProveedores.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Width = 150;
            c4.Name = "Nota";
            dgvProveedores.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Width = 100;
            c5.Name = "Telf";
            dgvProveedores.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Width = 100;
            c6.Name = "Fax";
            dgvProveedores.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Width = 100;
            c7.Name = "Web";
            dgvProveedores.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Width = 100;
            c8.Name = "Correo";
            dgvProveedores.Columns.Add(c8);
        }

        private void NombreColumnasListContac()
        {
            dgvContactos.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 50;
            c1.Name = "Codigo";
            dgvContactos.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 150;
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

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
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

        private void NombreColumnasListUbic()
        {
            dgvUbicacion.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 50;
            c1.Name = "Codigo";
            dgvUbicacion.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 90;
            c2.Name = "Pais";
            dgvUbicacion.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 130;
            c3.Name = "Dpto.";
            dgvUbicacion.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Width = 150;
            c4.Name = "Ciudad";
            dgvUbicacion.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Width = 300;
            c5.Name = "Direccion";
            dgvUbicacion.Columns.Add(c5);
        }

        private void NombreColumnasListNomFact()
        {
            dgvNomFact.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 50;
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

        private void NombreColumnasListDocto()
        {
            dgvDoctos.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 90;
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

        private void HabilitarBotones()
        {
            //Habilitamos
            btnNuevo.Enabled = true;
            btnModif.Enabled = true;
            btnAnul.Enabled = true;
            btnRest.Enabled = true;
            txtBuscar.Enabled = true;
            btnAct.Enabled = true;
            btnReg.Enabled = true;
            btnImp.Enabled = true;
            //Desabilitamos
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void HabilitarContProv()
        {
            txtNombre.ReadOnly = false;
            txtNota.ReadOnly = false;
            txtTelf.ReadOnly = false;
            txtFax.ReadOnly = false;
            txtPagWeb.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cboTipoProv.Enabled = true;
        }

        private void HabilitarContContac()
        {
            txtNomContact.ReadOnly = false;
            txtCargoContact.ReadOnly = false;
            txtDptoContact.ReadOnly = false;
            txtTelfContact.ReadOnly = false;
            txtFaxContact.ReadOnly = false;
            txtCelularContact.ReadOnly = false;
            txtPagWebContact.ReadOnly = false;
            txtEmailContact.ReadOnly = false;
        }

        private void HabilitarContUbic()
        {
            txtDpto.ReadOnly = false;
            txtZona.ReadOnly = false;
            txtBarrio.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtLatitud.ReadOnly = false;
            txtLongitud.ReadOnly = false;
            cboPais.Enabled = true;
            cboCiudad.Enabled = true;
        }

        private void HabilitarContNomFact()
        {
            txtNomFact.ReadOnly = false;
            txtNIT.ReadOnly = false;
        }

        private void HabilitarContDocto()
        {
            cboTipoDoc.Enabled = true;
            txtPalClave.ReadOnly = false;
            txtDesc.ReadOnly = false;
        }

        private void DesabilitarBotones()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            txtBuscar.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            btnImp.Enabled = false;
            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void DesabilitarContProv()
        {
            txtNombre.ReadOnly = true;
            txtNota.ReadOnly = true;
            txtTelf.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtPagWeb.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cboTipoProv.Enabled = false;
        }

        private void DesabilitarContContac()
        {
            txtNomContact.ReadOnly = true;
            txtCargoContact.ReadOnly = true;
            txtDptoContact.ReadOnly = true;
            txtTelfContact.ReadOnly = true;
            txtFaxContact.ReadOnly = true;
            txtCelularContact.ReadOnly = true;
            txtPagWebContact.ReadOnly = true;
            txtEmailContact.ReadOnly = true;
        }

        private void DesabilitarContUbic()
        {
            txtDpto.ReadOnly = true;
            txtZona.ReadOnly = true;
            txtBarrio.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtLatitud.ReadOnly = true;
            txtLongitud.ReadOnly = true;
            cboPais.Enabled = false;
            cboCiudad.Enabled = false;
        }

        private void DesabilitarContNomFact()
        {
            txtNomFact.ReadOnly = true;
            txtNIT.ReadOnly = true;
        }

        private void DesabilitarContDocto()
        {
            cboTipoDoc.Enabled = false;
            txtPalClave.ReadOnly = true;
            txtDesc.ReadOnly = true;
        }

        #endregion

        #region Conexion Capa Negocio
        
        private void ListarPais()
        {
            try
            {
                LPais = DListarPersonalizado.ConsultarDT("SELECT PaisID, NomPais FROM Pais ORDER BY NomPais");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoProveedor()
        {
            try
            {
                cboTipoProv.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo WHERE Tupla='Proveedor' " +
                    "UNION SELECT -1, '[SELECCIONE EL TIPO...]' ORDER BY NomTipo");
                cboTipoProv.ValueMember = "TipoID";
                cboTipoProv.DisplayMember = "NomTipo";
                cboTipoProv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarProveedor()
        {
            try
            {
                //mandamos por parametro 1 para que nos cargue todos los proveedores
                CargarProveedor(NProveedor.NListarProv());
            }
            catch (Exception)
            {
                NombreColumnasListProv();
                BorrarCampos(gbxBasico);
                BorrarCampos(gbxDatosProv);
            }
        }

        private void ListarContactos()
        {
            try
            {
                //mandamos por parametro proveedor y el codigo del proveedor
                CargarContactos(NContacto.NListarContacto("Proveedor", int.Parse(txtProvID.Text)));
            }
            catch (Exception)
            {
                NombreColumnasListContac();
                BorrarCampos(gbxDatosContact);
            }
        }

        private void ListarUbicacion()
        {
            try
            {
                CargarUbicacion(NUbicacion.NListarUbic(txtProvID.Text, "Proveedor"));
            }
            catch (Exception)
            {
                NombreColumnasListUbic();
                BorrarCampos(gbxUbicacion);
            }
        }

        private void ListarNombreFactura()
        {
            try
            {
                CargarNomFact(NNombreFactura.NListarNomFact("Proveedor", Convert.ToInt32(txtProvID.Text)));
            }
            catch (Exception)
            {
                NombreColumnasListNomFact();
                BorrarCampos(gbxNomFact);
            }
        }

        private void ListarDocumentos()
        {
            try
            {
                CargarDocto(NDocumento.NListarDoc("Proveedor", txtProvID.Text));
            }
            catch
            {
                NombreColumnasListDocto();
                BorrarCampos(gbxDoctos);
            }
        }

        private bool VerificarProv()
        {
            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("INGRESE EL NOMBRE DEL PROVEEDOR", "NOMBRE", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }
            else if ((int)cboTipoProv.SelectedValue == -1)
            {
                MessageBox.Show("SELECCIONE EL TIPO DE PROVEEDOR", "TIPO PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoProv.Focus();
                return false;
            }

            return true;
        }

        private void InsertModifProv()
        {
            if (!VerificarProv())
                return;

            try
            {
                OProveedor prov = new OProveedor();
                if (Opcion == "NuevoProv")
                    prov.ProveedorID = -1;
                else
                    prov.ProveedorID = Convert.ToInt32(txtProvID.Text);

                prov.NomProv = txtNombre.Text.Trim();
                prov.TipoProvID = (int)cboTipoProv.SelectedValue;
                prov.Nota = txtNota.Text.TrimEnd();
                prov.Telf = txtTelf.Text;
                prov.Fax = txtFax.Text;
                prov.PagWeb = txtPagWeb.Text;
                prov.Correo = txtEmail.Text;

                int resp = NProveedor.NInsertModifProveedor(prov, InsertInnmode("Proveedor"));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Abrimos cargando.....
                    //op.AbrirCargando("Cargando.....");

                    HabilitarBotones();
                    DesabilitarContProv();
                    Opcion = string.Empty;
                    ListarProveedor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModifContac()
        {
            try
            {
                //Objeto Contacto
                OContacto contact = new OContacto();
                if (Opcion == "NuevoContac")
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

                int resp = NContacto.NInsertModifContacto(int.Parse(txtProvID.Text), "Proveedor", contact, InsertInnmode("Contactos"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Opcion = string.Empty;
                    HabilitarBotones();
                    DesabilitarContContac();
                    ListarContactos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModifUbic()
        {
            try
            {
                //Objeto ubicacion
                OUbicacion ubic = new OUbicacion();
                if (Opcion == "NuevaUbic")
                    ubic.CodUbicacion = "";
                else
                    ubic.CodUbicacion = CodUbic;

                ubic.PaisID = Convert.ToInt32(cboPais.SelectedValue);
                ubic.DptoEstado = txtDpto.Text;
                ubic.Ciudad = cboCiudad.Text;
                ubic.Zona = txtZona.Text;
                ubic.Barrio = txtBarrio.Text;
                ubic.Direccion = txtDireccion.Text;
                ubic.Latitud = txtLatitud.Text;
                ubic.Longitud = txtLongitud.Text;

                int resp = NUbicacion.NInsertModifUbic(int.Parse(txtProvID.Text), "Proveedor", ubic, InsertInnmode("Ubicacion"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Opcion = string.Empty;
                    HabilitarBotones();
                    DesabilitarContUbic();
                    ListarUbicacion();
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
                if (Opcion == "NuevoNomFact")
                    nfact.NomFactID = -1;
                else
                    nfact.NomFactID = Convert.ToInt32(txtNomFactID.Text);

                nfact.ClienteID = Convert.ToInt32(cboPais.SelectedValue);
                nfact.NIT = txtNIT.Text;
                nfact.NomFact = txtNomFact.Text;
                nfact.ClienteID = -1;
                nfact.ProveedorID = Convert.ToInt32(txtProvID.Text);

                int resp = NNombreFactura.NInsertModifNomFact(nfact, InsertInnmode("Facturas"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Opcion = string.Empty;
                    HabilitarBotones();
                    DesabilitarContNomFact();
                    ListarNombreFactura();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModifDocto()
        {
            try
            {
                if ((Opcion == "NuevoDoc") && (RutaDocto == string.Empty))
                    throw new Exception("Tiene que cargar un Documento");

                ODocumento d = new ODocumento();
                d.CodDocumento = txtCodDoc.Text;
                d.NomDcto = txtNomDoc.Text;
                d.PalClave = txtPalClave.Text.TrimEnd();
                d.TipoDcto = cboTipoDoc.Text;
                d.Formato = txtFormato.Text;
                d.Descripcion = txtDesc.Text.TrimEnd();


                FileStream fs = new FileStream(RutaDocto, FileMode.Open);
                //Creamos un array de bytes para almacenar los datos leídos por fs.
                byte[] Docto = new byte[fs.Length];
                //Y guardamos los datos en el array Docto
                fs.Read(Docto, 0, Convert.ToInt32(fs.Length));
                d.Doc = Docto;
                fs.Close();

                //mandamos por parametro 
                int resp = NDocumento.NInsertModifDoc(d, "Proveedor", txtProvID.Text, InsertInnmode("Documentos"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Opcion = string.Empty;
                    RutaDocto = string.Empty;
                    DesabilitarContDocto();
                    HabilitarBotones();
                    ListarDocumentos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable InsertInnmode(string opc)
        {
            string CodInmode = string.Empty;
            string DetalleInmode = string.Empty;

            switch (opc)
            {
                case "Proveedor":
                    CodInmode = CodInmodeProv;
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
            }

            if ((Opcion != "NuevoProv") && (Opcion != "NuevoContac") && (Opcion != "NuevaUbic") && (Opcion != "NuevoNomFact") && (Opcion != "NuevoDocto"))
            {
                //Cargamos Detalle Modificar
                Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(opc);
                dmodanul.Owner = this;
                dmodanul.ShowDialog();
                DetalleInmode = dmodanul.DetaModAnul();
            }

            return OInmode.DTInmode(CodInmode, Opcion, DetalleInmode);
        }

        private void AnulRestau(string codigo, string tupla, int estado, string o)
        {
            try
            {
                OpcionFormularios ofor = new OpcionFormularios();
                OInmode inm = new OInmode();

                if (tupla == "Proveedor")
                    inm.CodInmode = CodInmodeProv;
                else if (tupla == "Contacto")
                    inm.CodInmode = CodInmodeContac;
                else if (tupla == "Ubicacion")
                    inm.CodInmode = CodInmodeUbic;
                else if (tupla == "Nombre Factura")
                    inm.CodInmode = CodInmodeNomFact;

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

                bool resp = DListarPersonalizado.AnulRestau(codigo, tupla, "", inm.DetalleInmode, "Anular", false);
                if (resp)
                {
                    MessageBox.Show("Los datos se Actualizaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando.....
                    op.AbrirCargando("Cargando.....");

                    switch(tcProveedor.SelectedIndex)
                    {
                        case 0:
                            ListarProveedor();
                            break;
                        case 1:
                            ListarContactos();
                            break;
                        case 2:
                            ListarUbicacion();
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

        #region CargarDatos

        private void CargarPais()
        {
            if(LPais != null)
            {
                cboPais.DataSource = LPais;
                cboPais.DisplayMember = "NomPais";
                cboPais.ValueMember = "PaisID";
                cboPais.Refresh();
            }
        }

        private void CargarProveedor(List<OProveedor> lprov)
        {
            try
            {
                NombreColumnasListProv();

                int cont = 0;
                foreach (var item in lprov)
                {
                    dgvProveedores.Rows.Add(item.ProveedorID, item.NomProv, item.TipoProv, item.Nota,
                                           item.Telf, item.Fax, item.PagWeb, item.Correo);
                    if (!item.Estado)
                    {
                        dgvProveedores.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    cont++;
                }
                dgvProveedores.Refresh();
            }
            catch (Exception)
            {
                NombreColumnasListProv();
            }
        }

        private void CargarContactos(List<OContacto> lcontact)
        {
            if (lcontact != null)
            {
                NombreColumnasListContac();
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
                NombreColumnasListContac();
        }

        private void CargarUbicacion(List<OUbicacion> lubic)
        {
            if (lubic != null)
            {
                NombreColumnasListUbic();
                int cont = 0;
                foreach (var item in lubic)
                {
                    dgvUbicacion.Rows.Add(item.CodUbicacion, item.NomPais, item.DptoEstado, item.Ciudad, item.Direccion);

                    if (!item.Estado)
                    {
                        dgvUbicacion.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }

                    cont++;
                }
            }
            else
            {
                NombreColumnasListUbic();
                cboPais.Text = "Bolivia";
            }
        }

        private void CargarNomFact(List<ONombreFactura> lnomfact)
        {
            if (lnomfact != null)
            {
                NombreColumnasListNomFact();
                int cont = 0;
                foreach (var item in lnomfact)
                {
                    dgvNomFact.Rows.Add(item.NomFactID, item.NomFact, item.NIT, item.Estado);

                    if (!item.Estado)
                    {
                        dgvNomFact.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    cont++;
                }
            }
            else
                NombreColumnasListNomFact();
        }

        private void CargarDocto(List<ODocumento> ldoc)
        {
            try
            {
                NombreColumnasListDocto();

                int cont = 0;
                foreach (var item in ldoc)
                {
                    dgvDoctos.Rows.Add(item.CodDocumento, item.NomDcto, item.Formato, item.TipoDcto, item.Descripcion);

                    if (!item.Estado)
                    {
                        dgvDoctos.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }

                    cont++;
                }
                dgvDoctos.Refresh();
            }
            catch (Exception)
            {
                NombreColumnasListDocto();
            }
        }

        private void BuscarProveedor()
        {
            CargarProveedor(NProveedor.NBuscarProv(txtBuscar.Text));
        }

        private void BuscarContacto()
        {
            CargarContactos(NContacto.NBuscarContacto(txtBuscar.Text));
        }

        private void BuscarUbicacion()
        {
            CargarUbicacion(NUbicacion.NBuscarUbicLista(txtBuscar.Text));
        }

        private void BuscarNomFact()
        {
            CargarUbicacion(NUbicacion.NBuscarUbicLista(txtBuscar.Text));
        }

        private void BuscarDocto()
        {
            CargarDocto(NDocumento.NBuscarDoc(txtBuscar.Text, "Proveedor"));
        }

        private void SeleccionarListProv(DataGridViewCellEventArgs e)
        {
            if(Opcion == string.Empty)
            {
                try
                {
                    BorrarCampos(gbxDatosProv);
                    BorrarCampos(gbxBasico);

                    txtProvID.Text = dgvProveedores["Codigo", e.RowIndex].Value.ToString();

                    //Buscamos por codigo de Proveedor
                    OProveedor objprov = NProveedor.NSeleccionarProv(txtProvID.Text);
                    if (objprov != null)
                    {
                        CodInmodeProv = objprov.CodInmode;
                        EstadoProv = objprov.Estado;
                       
                        txtNombre.Text = objprov.NomProv;
                        cboTipoProv.Text = objprov.TipoProv;
                        txtNota.Text = objprov.Nota;
                        txtTelf.Text = objprov.Telf;
                        txtFax.Text = objprov.Fax;
                        txtPagWeb.Text = objprov.PagWeb;
                        txtEmail.Text = objprov.Correo;
                    }
                }
                catch(Exception)
                {
                    BorrarCampos(gbxDatosProv);
                    BorrarCampos(gbxBasico);  
                }
            }
        }

        private void SeleccionarListContac(DataGridViewCellEventArgs e)
        {
            if(Opcion == string.Empty)
            {
                try
                {
                    BorrarCampos(gbxDatosContact);

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
                    BorrarCampos(gbxDatosContact);
                }
            }
        }

        private void SeleccionarListUbicacion(DataGridViewCellEventArgs e)
        {
            if (Opcion == string.Empty)
            {
                try
                {
                    BorrarCampos(gbxUbicacion);

                    CodUbic = dgvContactos["Codigo", e.RowIndex].Value.ToString();

                    //Buscamos por codigo de Ubicacion
                    OUbicacion objubic = NUbicacion.NSeleccionarUbic(CodUbic);

                    if (objubic != null)
                    {
                        CodInmodeUbic = objubic.CodInmodeUbic;
                        EstadoUbic = objubic.Estado;
                        
                        cboPais.Text = objubic.NomPais;
                        txtDpto.Text = objubic.DptoEstado;
                        cboCiudad.Text = objubic.Ciudad;
                        txtZona.Text = objubic.Zona;
                        txtBarrio.Text = objubic.Barrio;
                        txtDireccion.Text = objubic.Direccion;
                        txtLatitud.Text = objubic.Latitud;
                        txtLongitud.Text = objubic.Longitud;
                    }
                }
                catch (Exception)
                {
                    BorrarCampos(gbxUbicacion);
                }
            }
        }

        private void SeleccionarListNomFact(DataGridViewCellEventArgs e)
        {
            if (Opcion == string.Empty)
            {
                try
                {
                    BorrarCampos(gbxNomFact);

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
                    BorrarCampos(gbxNomFact);
                }
            }
        }

        private void SeleccionarListDoctos(DataGridViewCellEventArgs e)
        {
            if(Opcion == string.Empty)
            {
                try
                {
                    BorrarCampos(gbxDoctos);
                    txtCodDoc.Text = dgvDoctos["Codigo", e.RowIndex].Value.ToString();

                    //Buscamos por codigo de Documento
                    ODocumento objdocto = NDocumento.NSeleccionarDocto(txtCodDoc.Text, "Proveedor");

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
                    BorrarCampos(gbxDoctos);
                }
            }
        }

        #endregion

        #region Funciones

        private bool VerificarOpcionNuevo()
        {
            bool resp = true;

            if ((txtProvID.Text == string.Empty) && (tcProveedor.SelectedIndex != 0))
            {
                switch (tcProveedor.SelectedIndex)
                {
                    case 1:
                        MessageBox.Show("No hay un Proveedor Seleccionado, no puede crear un nuevo Contacto", "Nuevo",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resp = false;
                        break;
                    case 2:
                        MessageBox.Show("No hay un Proveedor Seleccionado, no puede crear una nueva Ubicacion", "Nuevo",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resp = false;
                        break;
                    case 3:
                        MessageBox.Show("No hay un Proveedor Seleccionado, no puede crear un nuevo NIT", "Nuevo",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resp = false;
                        break;
                }
            }

            return resp;
        }

        private void OpcionNuevo()
        {
            if (VerificarOpcionNuevo())
            {
                switch (tcProveedor.SelectedIndex)
                {
                    case 0:
                        Opcion = "NuevoProv";
                        cboTipoProv.SelectedValue = -1;
                        BorrarCampos(gbxDatosProv);
                        BorrarCampos(gbxBasico);
                        HabilitarContProv();
                        DesabilitarBotones();
                        break;
                    case 1:
                        Opcion = "NuevoContac";
                        BorrarCampos(gbxDatosContact);
                        HabilitarContContac();
                        DesabilitarBotones();
                        break;
                    case 2:
                        Opcion = "NuevaUbic";
                        BorrarCampos(gbxUbicacion);
                        HabilitarContUbic();
                        break;
                    case 3:
                        Opcion = "NuevoNomFact";
                        BorrarCampos(gbxNomFact);
                        HabilitarContNomFact();
                        break;
                    case 4:
                        Opcion = "NuevoDocto";
                        BorrarCampos(gbxDoctos);
                        HabilitarContDocto();
                        break;
                }
                DesabilitarBotones();
            }
        }

        private void OpcionModificar()
        {
            if (txtProvID.Text != string.Empty)
            {
                switch (tcProveedor.SelectedIndex)
                {
                    case 0:
                        Opcion = "ModifProv";
                        HabilitarContProv();
                        break;
                    case 1:
                        if(txtContactID.Text != string.Empty)
                        {
                            Opcion = "ModifContac";
                            HabilitarContContac();
                        }
                        break;
                    case 2:
                        if(CodUbic != string.Empty)
                        {
                            Opcion = "ModifUbic";
                            HabilitarContUbic();
                        }
                        break;
                    case 3:
                        if(txtNomFactID.Text != string.Empty)
                        {
                            Opcion = "ModifNomFact";
                            HabilitarContNomFact();
                        }
                        break;
                    case 4:
                        if(!string.IsNullOrEmpty(txtCodDoc.Text))
                        {
                            Opcion = "ModifDocto";
                            HabilitarContDocto();
                        }
                        break;
                }
                DesabilitarBotones();
            }
        }

        private void OpcionInsertModif()
        {
            if ((Opcion == "NuevoProv") || (Opcion == "ModifProv"))
                InsertModifProv();
            else if ((Opcion == "NuevoContac") || (Opcion == "ModifContac"))
                InsertModifContac();
            else if ((Opcion == "NuevaUbic") || (Opcion == "ModifUbic"))
                InsertModifUbic();
            else if ((Opcion == "NuevoNomFact") || (Opcion == "ModifNomFact"))
                InsertModifNomFact();
            else if ((Opcion == "NuevoDocto") || (Opcion == "ModifDocto"))
                InsertModifDocto();            
        }

        private void OpcionImpr() 
        {
            //if (LProv != null)
            //{
            //    //OpcionRep.ReporteProv rprov = new OpcionRep.ReporteProv(LProv);
            //    //rprov.Owner = this;
            //    //rprov.ShowDialog();

            //    //ReportesCrystalReport.Form1 f1 = new ReportesCrystalReport.Form1(LProv);
            //    //f1.Owner = this;
            //    //f1.Show();
            //    //f1.BringToFront();
            //}
        }

        private void OpcionInmode()
        {
            if (VerifInmode())
            {
                Frm_Inmode inm = null;
                switch (tcProveedor.SelectedIndex)
                {
                    case 0:
                        inm = new Frm_Inmode(CodInmodeProv);
                        break;
                    case 1:
                        inm = new Frm_Inmode(CodInmodeContac);
                        break;
                    case 2:
                        inm = new Frm_Inmode(CodInmodeUbic);
                        break;
                    case 3:
                        inm = new Frm_Inmode(CodInmodeNomFact);
                        break;
                    case 4:
                        inm = new Frm_Inmode(CodInmodeDocto);
                        break;
                    case 5:
                        inm = new Frm_Inmode(CodInmodeRedSoc);
                        break;
                }
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        private void OpcionBuscar()
        {
            if (txtBuscar.Text != string.Empty)
            {
                switch (tcProveedor.SelectedIndex)
                {
                    case 0:
                        this.BuscarProveedor();
                        break;
                    case 1:
                        this.BuscarContacto();
                        break;
                    case 2:
                        this.BuscarUbicacion();
                        break;
                    case 3:
                        this.BuscarNomFact();
                        break;
                    case 4:
                        this.BuscarDocto();
                        break;
                }
            }
            else
            {
                switch (tcProveedor.SelectedIndex)
                {
                    case 0:
                        CargarProveedor(NProveedor.NCargarProv());
                        break;
                    case 1:
                        CargarContactos(NContacto.NCargarContacto());
                        break;
                    case 2:
                        CargarUbicacion(NUbicacion.NCargarUbic());
                        break;
                    case 3:
                        CargarNomFact(NNombreFactura.NCargarNomFact());
                        break;
                    case 4:
                        CargarDocto(NDocumento.NCargarDoc("Proveedor"));
                        break;
                }
            }
        }

        private void OpcionAnularRestau(string op, int es)
        {
            if (txtProvID.Text != string.Empty)
            {
                DialogResult result;
                switch (tcProveedor.SelectedIndex)
                {
                    case 0:
                        if (((es == 0) && (EstadoProv)) || ((es == 1) && (!EstadoProv)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " al Proveedor " + txtNombre.Text + "?", op + " Proveedor", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                                AnulRestau(txtProvID.Text, "Proveedor", es, op);
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el Proveedor no se puede " + op, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        if (((es == 0) && (EstadoUbic)) || ((es == 1) && (!EstadoUbic)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " la Direccion " + txtDireccion.Text + "?", op + " Ubicacion", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                AnulRestau(CodUbic, "Ubicacion", es, op);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, la Ubicacion no se puede " + op, "Ubicacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                }
            }
            else
            {
                MessageBox.Show("No puede " + op + " porque no hay un Proveedor seleccionado", op, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OpcionActualizar()
        {
            switch (tcProveedor.SelectedIndex)
            {
                case 0:
                    ListarProveedor();
                    break;
                case 1:
                    ListarContactos();
                    break;
                case 2:
                    ListarPais();
                    ListarUbicacion();
                    break;
                case 3:
                    ListarNombreFactura();                    
                    break;
                case 4:
                    ListarDocumentos();
                    break;
            }
        }

        private void ColorTipoProv()
        {
            switch (cboTipoProv.Text)
            {
                case "Comercial":
                    this.BackColor = System.Drawing.Color.LightSeaGreen;
                    tabDatGral.BackColor = System.Drawing.Color.LightSeaGreen;
                    break;
                case "Financiero":
                    this.BackColor = System.Drawing.Color.LightSalmon;
                    tabDatGral.BackColor = System.Drawing.Color.LightSalmon;
                    break;
                case "Servicios Basicos":
                    this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    tabDatGral.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    break;
                case "Activos Fijos":
                    this.BackColor = System.Drawing.Color.LightGray;
                    tabDatGral.BackColor = System.Drawing.Color.LightGray;
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
                BorrarCampos(gbxBasico);
                BorrarCampos(gbxDatosContact);
                BorrarCampos(gbxDatosProv);
                BorrarCampos(gbxDoctos);
                BorrarCampos(gbxNomFact);
                BorrarCampos(gbxUbicacion);

                //desabilitamos
                DesabilitarContProv();
                DesabilitarContContac();
                DesabilitarContUbic();
                DesabilitarContNomFact();
                DesabilitarContDocto();
                HabilitarBotones();
                //volvemos a cargar todos los datos de las listas respectivas
                CargarProveedor(NProveedor.NCargarProv());
                CargarContactos(NContacto.NCargarContacto());
                CargarUbicacion(NUbicacion.NCargarUbic());
                CargarNomFact(NNombreFactura.NCargarNomFact());
                CargarDocto(NDocumento.NCargarDoc("Proveedor"));
            }
        }

        private void BorrarCampos(GroupBox gbx)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, "");
        }

        private bool VerifInmode()
        {
            bool resp = true;

            switch (tcProveedor.SelectedIndex)
            {
                case 0:
                    if (CodInmodeProv == string.Empty)
                        resp = false;
                    break;
                case 1:
                    if (CodInmodeContac == string.Empty)
                        resp = false;
                    break;
                case 2:
                    if (CodInmodeUbic == string.Empty)
                        resp = false;
                    break;
                case 3:
                    if (CodInmodeNomFact == string.Empty)
                        resp = false;
                    break;
                case 4:
                    if (CodInmodeDocto == string.Empty)
                        resp = false;
                    break;
            }
            return resp;
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

            switch (tcProveedor.SelectedIndex)
            {
                case 1:
                    ListarContactos();
                    break;
                case 2:
                    CargarPais();
                    ListarUbicacion();
                    break;
                case 3:
                    ListarNombreFactura();
                    break;
                case 4:
                    ListarDocumentos();
                    break;
                    
            }

            op.CerrarCargando();
        }

        #endregion

        #region Eventos formulario

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OpcionNuevo();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            OpcionModificar();
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
            op.AbrirCargando("Actualizando.....");

            OpcionActualizar();

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

        private void btnImp_Click(object sender, EventArgs e)
        {
            OpcionImpr();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            OpcionInmode();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            OpcionBuscar();
        }

        private void cboTipoProv_SelectedValueChanged(object sender, EventArgs e)
        {
            ColorTipoProv();
        }

        private void dgvProveedores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListProv(e);
        }

        private void dgvContactos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListContac(e);
        }

        private void dgvUbicacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListUbicacion(e);
        }

        private void dgvNomFact_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListNomFact(e);
        }

        private void dgvDoctos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListDoctos(e);
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            //abrimos cargando....
            //op.AbrirCargando("Cargando.....");

            //por defecto el pais=Bolivia y ciudad en la que entro el usuario

            if (prov == null)
            {
                tabContactos.Parent = null;
                tabUbic.Parent = null;
                tabNomNIT.Parent = null;
                tabDoctos.Parent = null;
            }
            else
            {
                cboTipoDoc.Text = "PDF (.pdf)";
                cboPais.Text = "Bolivia";
                cboCiudad.Text = OConexionGlobal.Ciudad;

                DesabilitarContContac();
                DesabilitarContUbic();
                DesabilitarContNomFact();
                DesabilitarContDocto();

                ListarPais();
            }

            HabilitarBotones();
            DesabilitarContProv();
            ListarTipoProveedor();
            ListarProveedor();

            //Cerramos Cargando....
            //op.CerrarCargando();
        }

        private void Proveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (prov != null)
            {
                prov.Dispose();
                prov = null;
            }            
        }

        private void btnBusDoc_Click(object sender, EventArgs e)
        {
            ExaminarDoc();
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            Mapa map = new Mapa();
            map.Show();
        }

        private void tcProveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SeleccionarVentana();
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((prov == null) && (dgvProveedores.Rows.Count > 0))
            {
                Seleccionado = true;
                this.Close();            
            }
        }

        #endregion
    }
}

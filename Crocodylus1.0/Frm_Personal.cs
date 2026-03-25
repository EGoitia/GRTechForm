using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.IO;

using Objetos;
using Negocio;
using System.Data;

namespace GRTechnology1._0
{
    public partial class Frm_Personal : Form
    {
        public static Frm_Personal per = null;
        OpcionFormularios op = new OpcionFormularios();

        string CodInmodePer = string.Empty;
        string CodInmodeDetPer = string.Empty;
        string CodInmodeRefPer = string.Empty;
        string CodInmodeDocto = string.Empty;
        string CodInmodeComision = string.Empty;

        string CodUbicacionPer = string.Empty;
        string CodUbicacionRefPer = string.Empty;

        string Opcion = string.Empty;
        string RutaDocto = string.Empty;

        byte[] Imagen;

        bool EstadoPer = false;
        bool EstadoRefer = false;
        bool EstadoDoc = false;

        List<OPersonal> LPer = null;
        List<OReferenciaPersonal> LRefPer = null;

        OUbicacion OUbic = null;
        OPersonal OPer = null;
        OReferenciaPersonal ORefPer = null;
        ODetallePersonal ODetPer = null;
        OComision OCom = null;

        public Frm_Personal()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void HabilitarBotones()
        {
            btnNuevo.Enabled = true;
            btnModif.Enabled = true;
            btnAnul.Enabled = true;
            btnReg.Enabled = true;
            btnAct.Enabled = true;
            btnRest.Enabled = true;
            btnImp.Enabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            //Habilitamos
            //op.HabilitarCont(gbxBotones, "2.02");

            //Desabilitamos
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void HabilitarContPer()
        {
            txtNombre.ReadOnly = false;
            txtCI.ReadOnly = false;
            dtFecIng.Enabled = true;
            cboCargo.Enabled = true;
            cboSuc.Enabled = true;
            nUpDwHaberBasico.Enabled = true;
            txttelf.ReadOnly = false;
            txtEmail.ReadOnly = false;
            dtFecNac.Enabled = true;
            cboECivil.Enabled = true;
            cboSexo.Enabled = true;
            txtNacionalidad.ReadOnly = false;
            //botones img
            lblCargImg.Enabled = true;
            lblBorrarImg.Enabled = true;
            //Ubicacion
            cboCiudad.Enabled = true;
            txtDir.ReadOnly = false;
            txtLatitud.ReadOnly = false;
            txtLongitud.ReadOnly = false;
        }

        private void HabilitarContDetPer()
        {
            cboForma.Enabled = true;
            txtBanco.ReadOnly = false;
            txtPagElect.ReadOnly = false;
            txtCuentCorr.ReadOnly = false;

            cboAFP.Enabled = true;

            cboTipoTrab.Enabled = true;
            cboTipoContr.Enabled = true;
            txtNumContr.ReadOnly = false;

            txtNomSeguro.ReadOnly = false;
            txtCodAfil.ReadOnly = false;
            txtExCodAfil.ReadOnly = false;
            NumSimp.Enabled = true;
            NumMater.Enabled = true;
            NumInval.Enabled = true;
        }

        private void HabilitarContRefer()
        {
            txtNomRefer.ReadOnly = false;
            txtParentesco.ReadOnly = false;
            txtTelfRefer.ReadOnly = false;
            txtCelRefer.ReadOnly = false;

            cboCiudadRef.Enabled = true;
            txtDirRef.ReadOnly = false;
            txtZonaRef.ReadOnly = false;
            txtBarrioRef.ReadOnly = false;
            txtLatitudRef.ReadOnly = false;
            txtLonngitudRef.ReadOnly = false;
        }

        private void HabilitarContDocto()
        {
            cboTipoDoc.Enabled = true;
            txtPalClave.ReadOnly = false;
            txtDesc.ReadOnly = false;
        }

        private void HabilitarComision()
        {
            cboCom.Enabled = true;
            numUpDownBolsa.Enabled = true;
            numUpDownPieza.Enabled = true;
            numUpDownTotCom.Enabled = true;
        }

        private void DesabilitarBotones()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            btnAct.Enabled = false;
            txtBuscar.Enabled = false;
            btnReg.Enabled = false;
            btnImp.Enabled = false;
            //Desabilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void DesabilitarContPer()
        {
            txtNombre.ReadOnly = true;
            txtCI.ReadOnly = true;
            dtFecIng.Enabled = false;
            cboCargo.Enabled = false;
            cboSuc.Enabled = false;
            nUpDwHaberBasico.Enabled = false;
            txttelf.ReadOnly = true;
            txtEmail.ReadOnly = true;
            dtFecNac.Enabled = false;
            cboECivil.Enabled = false;
            cboSexo.Enabled = false;
            txtNacionalidad.ReadOnly = true;
            //botones img
            lblCargImg.Enabled = false;
            lblBorrarImg.Enabled = false;
            //Ubicacion
            cboCiudad.Enabled = false;
            txtDir.ReadOnly = true;
            txtLatitud.ReadOnly = true;
            txtLongitud.ReadOnly = true;
        }

        private void DesabilitarContDetPer()
        {
            cboForma.Enabled = false;
            txtBanco.ReadOnly = true;
            txtPagElect.ReadOnly = true;
            txtCuentCorr.ReadOnly = true;

            cboAFP.Enabled = false;

            cboTipoTrab.Enabled = false;
            cboTipoContr.Enabled = false;
            txtNumContr.ReadOnly = true;

            txtNomSeguro.ReadOnly = true;
            txtCodAfil.ReadOnly = true;
            txtExCodAfil.ReadOnly = true;
            NumSimp.Enabled = false;
            NumMater.Enabled = false;
            NumInval.Enabled = false;
        }

        private void DesabilitarContRefer()
        {
            txtNomRefer.ReadOnly = true;
            txtParentesco.ReadOnly = true;
            txtTelfRefer.ReadOnly = true;
            txtCelRefer.ReadOnly = true;

            cboCiudadRef.Enabled = false;
            txtDirRef.ReadOnly = true;
            txtZonaRef.ReadOnly = true;
            txtBarrioRef.ReadOnly = true;
            txtLatitudRef.ReadOnly = true;
            txtLonngitudRef.ReadOnly = true;
        }

        private void DesabilitarContDocto()
        {
            cboTipoDoc.Enabled = false;
            txtPalClave.ReadOnly = true;
            txtDesc.ReadOnly = true;
        }

        private void DesabilitarComision()
        {
            cboCom.Enabled = false;
            numUpDownBolsa.Enabled = false;
            numUpDownPieza.Enabled = false;
            numUpDownTotCom.Enabled = false;
        }

        private void NombresColumnasPer()
        {
            dgvPersonal.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 60;
            c1.Name = "Codigo";
            dgvPersonal.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 150;
            c2.Name = "Nombre";
            dgvPersonal.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 90;
            c3.Name = "Cargo";
            dgvPersonal.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Width = 100;
            c4.Name = "Sucursal";
            dgvPersonal.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Width = 80;
            c5.Name = "CI";
            dgvPersonal.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Width = 90;
            c6.Name = "Telf.";
            dgvPersonal.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Width = 90;
            c7.Name = "Ingreso";
            dgvPersonal.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Width = 100;
            c8.Name = "Email";
            dgvPersonal.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Width = 90;
            c9.Name = "Est. Civil";
            dgvPersonal.Columns.Add(c9);

            DataGridViewTextBoxColumn c10 = new DataGridViewTextBoxColumn();
            c10.Width = 80;
            c10.Name = "Sexo";
            dgvPersonal.Columns.Add(c10);
        }

        private void NombresColumnasRefPer()
        {
            dgvRefer.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 60;
            dgvRefer.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Nombre";
            c2.Width = 250;
            dgvRefer.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Telf.";
            c3.Width = 100;
            dgvRefer.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Cel.";
            c4.Width = 100;
            dgvRefer.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Zona";
            c5.Width = 100;
            dgvRefer.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Barrio";
            c6.Width = 100;
            dgvRefer.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Direccion";
            c7.Width = 200;
            dgvRefer.Columns.Add(c7);
        }

        private void NombreColumnasDocto()
        {
            dgvDoctos.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 70;
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
            c5.Width = 350;
            dgvDoctos.Columns.Add(c5);
        }

        #endregion

        #region Conexion Capa Negocio

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

        private void ListarPersonal()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("Personal", -1);
                CargarPersonal(LPer);
            }
            catch (Exception)
            {
                NombresColumnasPer();
            }
        }

        private void ListarDetallePersonal()
        {
            try
            {
                ODetPer = NDetallePersonal.NBuscarDetPer(Convert.ToInt32(txtPersonalID.Text));
                CargarDetallePersonal();
            }
            catch (Exception)
            { }
        }

        private void ListarReferencia()
        {
            try
            {
                LRefPer = NReferenciaPersonal.NListarReferPer(Convert.ToInt32(txtReferPerID.Text));
                CargarReferencia(LRefPer);
            }
            catch (Exception)
            {
                NombresColumnasRefPer();
            }
        }

        private void ListarDocumentos()
        {
            try
            {
                CargarDocto(NDocumento.NListarDoc("Personal", txtPersonalID.Text));
            }
            catch
            {
                NombreColumnasDocto();
            }
        }

        private void ListarSucursal()
        {
            try
            {
                List<OSucursal> lsuc = NSucursal.NListarSucursales().OrderBy(x => x.NomSuc).ToList();

                cboSuc.DataSource = lsuc;
                cboSuc.DisplayMember = "NomSuc";
                cboSuc.ValueMember = "SucursalID";
                cboSuc.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarCargos()
        {
            try
            {
                List<OCargo> lcar = NCargo.NListarCargos().OrderBy(x => x.NomCargo).ToList();

                cboCargo.DataSource = lcar;
                cboCargo.DisplayMember = "NomCargo";
                cboCargo.ValueMember = "CargoID";
                cboCargo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarComision()
        {
            try
            {
                OCom = NComision.NListarComision(Convert.ToInt32(txtPersonalID.Text));
                CargarComision();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                CodInmodeComision = string.Empty;
            }
        }

        private void BuscarUbicacion()
        {
            try
            {
                OUbic = NUbicacion.NBuscarUbic(txtPersonalID.Text, "UbicPerson");
                if (OUbic != null)
                {
                    cboPais.Text = OUbic.NomPais;
                    cboCiudad.Text = OUbic.Ciudad;
                    txtDir.Text = OUbic.Direccion;
                    txtLatitud.Text = OUbic.Latitud;
                    txtLongitud.Text = OUbic.Longitud;
                }
            }
            catch (Exception)
            { }
        }

        private DataTable InsertInnmode(string opc)
        {
            string CodInmode = string.Empty;
            string DetalleInmode = string.Empty;

            switch (opc)
            {
                case "Personal":
                    CodInmode = CodInmodePer;
                    break;
                case "Detalle":
                    CodInmode = CodInmodeDetPer;
                    break;
                case "Referencia":
                    CodInmode = CodInmodeRefPer;
                    break;
                case "Documentos":
                    CodInmode = CodInmodeDocto;
                    break;
                case "Comision":
                    CodInmode = CodInmodeComision;
                    break;
            }

            if ((Opcion != "NuevoPer") && (Opcion != "NuevoDet") && (Opcion != "NuevaRef") && (Opcion != "NuevoDoc") && (Opcion != "NuevaCom"))
            {
                //Cargamos Detalle Modificar
                Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(opc);
                dmodanul.Owner = this;
                dmodanul.ShowDialog();
                DetalleInmode = dmodanul.DetaModAnul();
            }

            return OInmode.DTInmode(CodInmode, Opcion, DetalleInmode);
        }

        private void InsertModifPer()
        {
            try
            {
                OPersonal per = new OPersonal();
                if (Opcion == "NuevoPer")
                    per.PersonalID = -1;
                else
                    per.PersonalID = int.Parse(txtPersonalID.Text);

                per.NomPer = txtNombre.Text;
                per.CI = txtCI.Text;
                per.FecIngreso = dtFecIng.Value;
                per.CargoID = Convert.ToInt32(cboCargo.SelectedValue);
                per.SucursalID = Convert.ToInt32(cboSuc.SelectedValue);
                per.HaberBasico = nUpDwHaberBasico.Value;
                per.Telf = txttelf.Text;
                per.Email = txtEmail.Text;
                per.EstCivil = cboECivil.Text;
                per.Sexo = cboSexo.Text;
                per.Nacionalidad = txtNacionalidad.Text;
                per.FecNac = dtFecNac.Value;

                //Cargamos la Imagen
                MemoryStream m_MemoryStream = new MemoryStream();
                pbxImagen.Image.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = m_MemoryStream.ToArray();
                per.Img = Imagen;

                OUbicacion ubic = new OUbicacion();
                ubic.CodUbicacion = CodUbicacionPer;
                ubic.PaisID = 32;//Convert.ToInt32(cboPais.ValueMember);
                ubic.Direccion = txtDir.Text;
                ubic.Ciudad = cboCiudad.Text;
                ubic.DptoEstado = cboCiudad.Text;
                ubic.Latitud = txtLatitud.Text;
                ubic.Longitud = txtLongitud.Text;

                //mandamos por parametro objetopesonal, objeto ubicacion y objeto inmode
                int resp = NPersonal.NInsertModifPer(per, ubic, InsertInnmode("Personal"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando....
                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    BorrarCampos(gbxBasico);
                    BorrarCampos(gbxInf);
                    BorrarCampos(gbxDirec);
                    HabilitarBotones();
                    DesabilitarContPer();
                    ListarPersonal();
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

        private void InsertModifDetPer()
        {
            try
            {
                ODetallePersonal dper = new ODetallePersonal();
                dper.PersonalID = Convert.ToInt32(txtPersonalID.Text);
                dper.Banco = txtBanco.Text;
                //faltan mas campos
                int result = NDetallePersonal.NInsertModifDetPer(dper, InsertInnmode("Detalle"));
                if (result > 0)
                {
                    MessageBox.Show("Los Datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    BorrarCampos(gbxPago);
                    BorrarCampos(gbxContrato);
                    BorrarCampos(gbxSeguro);
                    HabilitarBotones();
                    DesabilitarContDetPer();
                    ListarDetallePersonal();
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

        private void InsertModfRefer()
        {
            try
            {
                //objeto referencia
                OReferenciaPersonal rper = new OReferenciaPersonal();
                rper.RefPersonalID = Convert.ToInt32(txtReferPerID.Text);
                rper.NomRefer = txtNomRefer.Text;
                rper.ParentescoRefer = txtParentesco.Text;
                rper.TelfRefer = txtTelfRefer.Text;
                rper.CelRefer = txtCelRefer.Text;
                //objeto ubicacion
                OUbicacion ubic = new OUbicacion();
                ubic.CodUbicacion = CodUbicacionRefPer;
                ubic.PaisID = 32; // por defecto le mandamos 32 que es el id de Bolivia
                ubic.Ciudad = cboCiudadRef.Text;
                ubic.Direccion = txtDir.Text;
                ubic.Latitud = txtLatitudRef.Text;
                ubic.Longitud = txtLonngitudRef.Text;

                int result = NReferenciaPersonal.NInsertModifReferPer(rper, ubic, InsertInnmode("Referencia"));
                if (result > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    BorrarCampos(gbxRefer);
                    BorrarCampos(gbxDirRef);
                    HabilitarBotones();
                    DesabilitarContRefer();
                    ListarReferencia();
                }
                else
                {
                    MessageBox.Show("Error al guardar en la Base de Datos, informe al Administrador del Sistema sobre este Error", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if ((Opcion == "NuevoDoc") && (RutaDocto == string.Empty))
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
                int resp = NDocumento.NInsertModifDoc(d, "Personal", txtPersonalID.Text, InsertInnmode("Documentos"));
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando
                    op.AbrirCargando("Cargando....");

                    Opcion = string.Empty;
                    RutaDocto = string.Empty;
                    BorrarCampos(gbxDoctos);
                    HabilitarBotones();
                    DesabilitarContDocto();
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

        private void InsertModifComision()
        {
            try
            {
                //Objeto Comision
                OCom = new OComision();
                OCom.PersonalID = Convert.ToInt32(txtPersonalID.Text);
                OCom.Comision = cboCom.Text;

                if (cboCom.Text == "Ventas")
                    OCom.TotVentas = numUpDownTotCom.Value;
                else
                {
                    OCom.TotMetros = numUpDownTotCom.Value;
                    OCom.TotPiezas = numUpDownPieza.Value;
                    OCom.TotBolsas = numUpDownBolsa.Value;
                }

                int result = NComision.NInsertModifComision(OCom, InsertInnmode("Comision"));
                if (result > 0)
                {
                    MessageBox.Show("Los Datos se Guardaron Correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    HabilitarBotones();
                    DesabilitarComision();
                }
                else
                {
                    MessageBox.Show("Error al guardar en la Base de Datos, informe al Administrador del Sistema sobre este Error", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AnulRestau(string codigo, string tupla, int estado, string opc)
        {
            try
            {
                OInmode inm = new OInmode();

                if (tupla == "Personal")
                    inm.CodInmode = CodInmodePer;
                else if (tupla == "Referencia")
                    inm.CodInmode = CodInmodeRefPer;
                else if (tupla == "Documento")
                    inm.CodInmode = CodInmodeDocto;

                inm.TipoInmode = opc;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                //Cargamos Detalle Anulado
                string DetalleInmode = string.Empty;
                Frm_DetaModifAnul anul = new Frm_DetaModifAnul(opc + " " + tupla);
                anul.Owner = this;
                anul.ShowDialog();
                DetalleInmode = anul.DetaModAnul();

                bool resp = NListarPersonalizado.AnulRestau(codigo, tupla, "", DetalleInmode, "Anular", false);
                if (resp)
                {
                    MessageBox.Show("Los datos se Actualizaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //abrimos cargando.....
                    op.AbrirCargando("Cargando.....");

                    switch (tcPer.SelectedIndex)
                    {
                        case 0:
                            ListarPersonal();
                            break;
                        case 2:
                            ListarReferencia();
                            break;
                        case 3:
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

        private void CargarPersonal(List<OPersonal> lper)
        {
            try
            {
                NombresColumnasPer();

                int cont = 0;
                foreach (var item in lper)
                {
                    dgvPersonal.Rows.Add(item.PersonalID, item.NomPer, item.NomCargo, item.NomSuc, item.CI, item.Telf,
                                         item.FecIngreso, item.Email, item.EstCivil, item.Sexo);

                    if (!item.Estado)
                        dgvPersonal.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvPersonal.Refresh();
            }
            catch (Exception)
            {
                NombresColumnasPer();
            }
        }

        private void CargarDetallePersonal()
        {
            if (ODetPer != null)
            {
                CodInmodeDetPer = ODetPer.CodInmode;
                cboAFP.Text = ODetPer.NomAFP;

                cboTipoContr.Text = ODetPer.TipoContrato;
                cboTipoTrab.Text = ODetPer.TipoTrabajador;
                txtNumContr.Text = ODetPer.NumContrato;


                txtNomSeguro.Text = ODetPer.NomSeguro;
                txtCodAfil.Text = ODetPer.CodAfiliacion;
                txtExCodAfil.Text = ODetPer.ExCodAfiliacion;
                NumSimp.Value = ODetPer.SeguroSimples;
                NumMater.Value = ODetPer.SeguroMaternales;
                NumInval.Value = ODetPer.SeguroInvalidez;
            }
        }

        private void CargarReferencia(List<OReferenciaPersonal> lrefper)
        {
            try
            {
                NombresColumnasRefPer();

                int cont = 0;
                foreach (var item in lrefper)
                {
                    dgvRefer.Rows.Add(item.RefPersonalID, item.NomRefer, item.TelfRefer, item.CelRefer, item.Zona, item.Barrio, item.Direccion);

                    if (!item.Estado)
                        dgvRefer.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    
                    cont++;
                }
                dgvRefer.Refresh();
            }
            catch (Exception)
            {
                NombresColumnasRefPer();
            }
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

        private void CargarComision()
        {
            try
            {
                cboCom.Text = OCom.Comision;
                CodInmodeComision = OCom.CodInmode;

                if (OCom.Comision == "Ventas")
                    numUpDownTotCom.Value = OCom.TotVentas;
                else
                {
                    numUpDownTotCom.Value = OCom.TotMetros;
                    numUpDownBolsa.Value = OCom.TotBolsas;
                    numUpDownPieza.Value = OCom.TotPiezas;
                }
            }
            catch (Exception)
            {     }
        }

        private void BuscarPer()
        {
            List<OPersonal> lbusqper = new List<OPersonal>();

            NombresColumnasPer();

            int val = 0;
            if (int.TryParse(txtBuscar.Text, out val))
            {
                //Buscamos por codigo de Personal
                OPersonal objper = LPer.Find(x => x.PersonalID == Convert.ToInt32(txtBuscar.Text));
                lbusqper.Add(objper);
            }
            else
            {
                //Buscamos por Nombre de Personal
                lbusqper = LPer.FindAll(c => c.NomPer.ToUpper().Contains(txtBuscar.Text.ToUpper()));
            }
            CargarPersonal(lbusqper);
        }

        private void BuscarRef()
        {
            try
            {
                List<OReferenciaPersonal> lbusqrefper = new List<OReferenciaPersonal>();

                NombresColumnasRefPer();

                int val = 0;
                if (int.TryParse(txtBuscar.Text, out val))
                {
                    //Buscamos por codigo de Referencia
                    OReferenciaPersonal objrefper = LRefPer.Find(x => x.RefPersonalID == Convert.ToInt32(txtBuscar.Text));
                    lbusqrefper.Add(objrefper);
                }
                else
                {
                    //Buscamos por Nombre de Personal
                    lbusqrefper = LRefPer.FindAll(c => c.NomRefer.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                }
                CargarReferencia(lbusqrefper);
            }
            catch(Exception )
            {     }
        }

        private void BuscarDoc()
        {
            try
            {
                CargarDocto(NDocumento.NBuscarDoc(txtBuscar.Text, "Personal"));
            }
            catch (Exception)
            {  }
            
        }

        private void SeleccionarListPer(DataGridViewCellEventArgs e)
        {
            if(Opcion == string.Empty)
            {
                BorrarCampos(gbxBasico);
                BorrarCampos(gbxInf);
                BorrarCampos(gbxDirec);
                pbxImagen.Image = null;

                try
                {
                    txtPersonalID.Text = dgvPersonal["Codigo", e.RowIndex].Value.ToString();

                    OPer = LPer.Find(x => x.PersonalID == Convert.ToInt32(txtPersonalID.Text));
                    if (OPer != null)
                    {
                        EstadoPer = OPer.Estado;
                        CodInmodePer = OPer.CodInmode;
                        CodUbicacionPer = OPer.CodUbicacion;
                        txtNombre.Text = OPer.NomPer;
                        txtCI.Text = OPer.CI;
                        dtFecIng.Value = OPer.FecIngreso;
                        cboCargo.Text = OPer.NomCargo;
                        cboSuc.Text = OPer.NomSuc;
                        txttelf.Text = OPer.Telf;
                        txtEmail.Text = OPer.Email;
                        cboECivil.Text = OPer.EstCivil;
                        cboSexo.Text = OPer.Sexo;
                        txtNacionalidad.Text = OPer.Nacionalidad;
                        nUpDwHaberBasico.Value = OPer.HaberBasico;
                        dtFecNac.Value = OPer.FecNac;

                        //Buscamos la ubicacion del Personal
                        BuscarUbicacion();

                        //cargamos la imagen al picturebox
                        MemoryStream m_MemoryStream = new MemoryStream(OPer.Img);
                        pbxImagen.Image = new System.Drawing.Bitmap(m_MemoryStream);
                    }
                }
                catch
                {
                    CargarImgDefecto();
                }
            }
        }

        private void SeleccionarListRefPer(DataGridViewCellEventArgs e)
        {
            if (Opcion == string.Empty)
            {
                BorrarCampos(gbxRefer);
                BorrarCampos(gbxDirRef);

                try
                {
                    txtReferPerID.Text = dgvRefer["Codigo", e.RowIndex].Value.ToString();

                    ORefPer = LRefPer.Find(x => x.RefPersonalID == Convert.ToInt32(txtReferPerID.Text));
                    if (ORefPer != null)
                    {
                        CodInmodeRefPer = ORefPer.CodInmode;
                        CodUbicacionRefPer = ORefPer.CodUbicacion;
                        txtNomRefer.Text = ORefPer.NomRefer;
                        txtParentesco.Text = ORefPer.ParentescoRefer;
                        txtTelfRefer.Text = ORefPer.TelfRefer;
                        txtCelRefer.Text = ORefPer.CelRefer;

                        //ubicacion
                        cboCiudad.Text = ORefPer.Ciudad;
                        txtLatitud.Text = ORefPer.Latitud;
                        txtLongitud.Text = ORefPer.Longitud;
                        txtDirRef.Text = ORefPer.Direccion;
                        txtZonaRef.Text = ORefPer.Zona;
                        txtBarrioRef.Text = ORefPer.Barrio;
                    }
                }
                catch
                {
                    BorrarCampos(gbxRefer);
                    BorrarCampos(gbxDirRef);
                }
            }
        }

        private void SeleccionarListDoctos(DataGridViewCellEventArgs e)
        {
            if (Opcion == string.Empty)
            {
                BorrarCampos(gbxDoctos);

                try
                {   
                    txtCodDoc.Text = dgvDoctos["Codigo", e.RowIndex].Value.ToString();

                    //Buscamos por codigo de Documento
                    ODocumento objdocto = NDocumento.NSeleccionarDocto(txtCodDoc.Text, "Personal");

                    if (objdocto != null)
                    {
                        CodInmodeDocto = objdocto.CodInmode;
                        EstadoDoc = objdocto.Estado;
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
                    pbxImagen.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                    RutaDocto = openFileDialog.FileName;
                    txtNomDoc.Text = Path.GetFileName(openFileDialog.FileName);
                    txtFormato.Text = Path.GetExtension(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarImgDefecto();
            }
        }

        private void BorrarCampos(GroupBox gbx)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, "");
        }

        private void SeleccionarVentana()
        {
            op.AbrirCargando("Cargando....");

            switch (tcPer.SelectedIndex)
            {
                //case 0:
                //    ListarPersonal();
                //    break;
                case 1:
                    ListarDetallePersonal();
                    break;
                case 2:
                    ListarReferencia();
                    break;
                case 3:
                    ListarDocumentos();
                    break;
                case 4:
                    ListarComision();
                    break;
            }

            op.CerrarCargando();
        }

        private void CargarImgDefecto()
        {
            try
            {
                //cargamos imagen sin foto
                pbxImagen.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\sinimagen.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbxImagen.Image = null;
            }
        }

        private void OpcionNuevo()
        {
            switch (tcPer.SelectedIndex)
            {
                case 0:
                    Opcion = "NuevoPer";
                    BorrarCampos(gbxBasico);
                    BorrarCampos(gbxInf);
                    BorrarCampos(gbxDirec);
                    CargarImgDefecto();
                    HabilitarContPer();
                    break;
                case 1:
                    Opcion = "NuevoDet";
                    BorrarCampos(gbxPago);
                    BorrarCampos(gbxBasico);
                    HabilitarContDetPer();
                    break;
                case 2:
                    Opcion = "NuevaRef";
                    BorrarCampos(gbxRefer);
                    HabilitarContRefer();
                    break;
                case 3:
                    Opcion = "NuevoDoc";
                    BorrarCampos(gbxDoctos);
                    HabilitarContDocto();
                    break;
                case 4:
                    Opcion = "NuevaCom";
                    BorrarCampos(gbxCom);
                    HabilitarComision();
                    break;
            }
            DesabilitarBotones();
        }

        private void OpcionModif()
        {
            DesabilitarBotones();

            switch (tcPer.SelectedIndex)
            {
                case 0:
                    if (EstadoPer)
                    {
                        Opcion = "ModifPer";
                        DesabilitarBotones();
                        HabilitarContPer();
                    }
                    else
                    {
                        MessageBox.Show("no se puede Modificar porque ya esta Anulado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case 1:
                    Opcion = "ModifDet";
                    DesabilitarBotones();
                    HabilitarContDetPer();
                    break;
                case 2:
                    if (EstadoRefer)
                    {
                        Opcion = "ModifRef";
                        DesabilitarBotones();
                        HabilitarContRefer();
                    }
                    else
                    {
                        MessageBox.Show("no se puede Modificar porque ya esta Anulado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case 3:
                    if (EstadoDoc)
                    {
                        Opcion = "ModifDoc";
                        DesabilitarBotones();
                        HabilitarContDocto();
                    }
                    else
                    {
                        MessageBox.Show("no se puede Modificar porque ya esta Anulado", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case 4:
                    Opcion = "ModifCom";
                    DesabilitarBotones();
                    HabilitarComision();
                    break;
            }
        }

        private void OpcionInsertModif()
        {
            if ((Opcion == "NuevoPer") || (Opcion == "ModifPer"))
                InsertModifPer();
            else if ((Opcion == "NuevoDet") || (Opcion == "ModifDet"))
                InsertModifDetPer();
            else if ((Opcion == "NuevaRef") || (Opcion == "ModifRef"))
                InsertModfRefer();
            else if ((Opcion == "NuevoDoc") || (Opcion == "ModifDoc"))
                InsertModifDocto();
            else if ((Opcion == "NuevaCom") || (Opcion == "ModifCom"))
                InsertModifComision();
        }

        private void OpcionAnulRestau(string op, int es)
        {
            if (txtPersonalID.Text != string.Empty)
            {
                DialogResult result;
                switch (tcPer.SelectedIndex)
                {
                    case 0:
                        if (((es == 0) && (EstadoPer)) || ((es == 1) && (!EstadoPer)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " al Empleado " + txtNombre.Text + "?", op + " Personal", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                                AnulRestau(txtPersonalID.Text, "Personal", es, op);
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el Personal no se puede " + op, "Personal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 2:
                        if (((es == 0) && (EstadoRefer)) || ((es == 1) && (!EstadoRefer)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " a " + txtNomRefer.Text + "?", op + " Referencia", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                AnulRestau(txtReferPerID.Text, "Referencia", es, op);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, la Referencia no se puede " + op, "Referencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    case 3:
                        if (((es == 0) && (EstadoDoc)) || ((es == 1) && (!EstadoDoc)))
                        {
                            result = MessageBox.Show("¿Desea " + op + " el documento " + txtNomDoc.Text + "?", op + " Documento", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                AnulRestau(txtCodDoc.Text, "Documento", es, op);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opcion no Valida, el Documento no se puede " + op, "Documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("No puede " + op + " porque no hay un Personal seleccionado", op, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OpcionActualizar()
        {
            op.AbrirCargando("Cargando....");

            switch (tcPer.SelectedIndex)
            {
                case 0:
                    ListarSucursal();
                    ListarCargos();
                    ListarPersonal();
                    break;
                case 1:
                    ListarDetallePersonal();
                    break;
                case 2:
                    ListarReferencia();
                    break;
                case 3:
                    ListarDocumentos();
                    break;
                case 4:
                    ListarComision();
                    break;
            }

            op.CerrarCargando();
        }

        private void OpcionCancelar()
        {
            DialogResult result = MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                op.AbrirCargando("Cargando.....");

                Opcion = string.Empty;
                RutaDocto = string.Empty;

                HabilitarBotones();
                DesabilitarContPer();
                DesabilitarContDetPer();
                DesabilitarContRefer();
                DesabilitarContDocto();
                DesabilitarComision();

                CargarPersonal(LPer);
                CargarDetallePersonal();
                CargarReferencia(LRefPer);
                CargarDocto(NDocumento.NCargarDoc("Personal"));
                CargarComision();

                op.CerrarCargando();
            }
        }

        private void OpcionBuscar()
        {
            if (txtBuscar.Text != string.Empty)
            {
                switch (tcPer.SelectedIndex)
                {
                    case 0:
                        this.BuscarPer();
                        break;
                    case 1:
                        goto case 0;
                    case 2:
                        this.BuscarRef();
                        break;
                    case 3:
                        this.BuscarDoc();
                        break;
                }
            }
            else
            {
                switch (tcPer.SelectedIndex)
                {
                    case 0:
                        CargarPersonal(LPer);
                        break;
                    case 1:
                        goto case 0;
                    case 2:
                        CargarReferencia(LRefPer);
                        break;
                    case 3:
                        CargarDocto(NDocumento.NCargarDoc("Personal"));
                        break;
                }
            }
        }

        private void OpcionImprimir()
        {

        }

        private void OpcionRegistro()
        {
            switch (tcPer.SelectedIndex)
            {
                case 0:
                    if (txtPersonalID.Text != string.Empty)
                    {
                        Frm_Inmode inm = new Frm_Inmode(CodInmodePer);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 1:
                    if (CodInmodeDetPer != string.Empty)
                    {
                        Frm_Inmode inm = new Frm_Inmode(CodInmodeDetPer);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 2:
                    if (txtReferPerID.Text != string.Empty)
                    {
                        Frm_Inmode inm = new Frm_Inmode(CodInmodeRefPer);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 3:
                    if (txtCodDoc.Text != string.Empty)
                    {
                        Frm_Inmode inm = new Frm_Inmode(CodInmodeDocto);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
                case 4:
                    if(CodInmodeComision != string.Empty)
                    {
                        Frm_Inmode inm = new Frm_Inmode(CodInmodeComision);
                        inm.Owner = this;
                        inm.ShowDialog();
                    }
                    break;
            }

        }

        #endregion

        #region Eventos Formulario

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OpcionNuevo();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            OpcionModif();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            OpcionAnulRestau("Anular", 0);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            OpcionAnulRestau("Restaurar", 1);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            OpcionActualizar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            OpcionInsertModif();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OpcionCancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            OpcionRegistro();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            OpcionImprimir();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            OpcionBuscar();
        }

        private void dgvPersonal_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListPer(e);
        }

        private void Personales_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            //Seleccionamos el Pais y la ciudad por Defecto
            ListarPais();
            cboPaisRef.Text = "Bolivia";
            cboTipoDoc.Text = "PDF (.pdf)";
            cboCom.Text = "Chofer";
            cboCiudad.Text = OConexionGlobal.Ciudad;
            cboCiudadRef.Text = OConexionGlobal.Ciudad;

            ListarSucursal();
            ListarCargos();
            ListarPersonal();

            HabilitarBotones();
            DesabilitarContPer();
            DesabilitarContDetPer();
            DesabilitarContRefer();
            DesabilitarContDocto();
            DesabilitarComision();

            op.CerrarCargando();
        }

        private void Personales_FormClosing(object sender, FormClosingEventArgs e)
        {
            per.Dispose();
            per = null;
        }

        private void lblCargImg_Click(object sender, EventArgs e)
        {
            ExaminarImg();
        }

        private void lblBorrarImg_Click(object sender, EventArgs e)
        {
            CargarImgDefecto();
        }

        private void btnBusDoc_Click(object sender, EventArgs e)
        {
            ExaminarDoc();
        }

        private void tcPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarVentana();
        }

        private void dgvDoctos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListDoctos(e);
        }

        private void cboCom_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboCom.Text == "Ventas")
            {
                lblTotCom.Text = "Total Ventas...............";

                lblBolsa.Visible = false;
                lblPieza.Visible = false;
                numUpDownBolsa.Visible = false;
                numUpDownPieza.Visible = false;
            }
            else
            {
                lblTotCom.Text = "Total Metros...............";

                lblBolsa.Visible = true;
                lblPieza.Visible = true;
                numUpDownBolsa.Visible = true;
                numUpDownPieza.Visible = true;
            }
        }

        #endregion
    }
}

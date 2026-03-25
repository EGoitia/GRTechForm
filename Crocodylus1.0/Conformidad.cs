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

using System.Xml.Serialization;
using System.IO;

namespace GRTechnology1._0
{
    public partial class Conformidad : Form, IAgregaConformidad, IAgregaControlTransp
    {
        public static Conformidad frmconf = null;

        OpcionFormularios op = new OpcionFormularios();

        List<OConformidad> LConf = null;
        List<OConformidad> LBusqConf = null;
        List<ODetalleConformidad> LDConf = null;
        List<OPersonal> LChof = null;
        List<OControlTransporte> LContrTans = null;

        OConformidad OConf = null;

        string Opcion = string.Empty;
        string CodConformidad = string.Empty;
        string CodUbicacion = string.Empty;
        string CodInmode = string.Empty;
        string CodUbic = string.Empty;

        bool Estado = false;

        #region IAgregaConformidad

        public void AgregaConformidad(List<ODetalleConformidad> ldconf)
        {
            try
            {
                foreach (var item in ldconf)
                {
                    if (VerifItemLista(item.ProductoID.ToString(), item.CodNota))
                    {
                        dgvDConf.Rows.Add(item.CodNota, item.Cantidad, item.NumNota, item.ProductoID, string.Format("{0:#,##0.00}", item.Cantidad),
                                          item.NomProd, item.UnidMedida);
                    }
                    else
                    {
                        DialogResult dialogo = MessageBox.Show("El Item " + item.NomProd + " ya se encuentra en la Lista, " +
                                                               "¿Desea seguir agregando a la lista los demas items?", "Items", 
                                                               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogo == DialogResult.No)
                            break;
                    }
                }
            }
            catch
            { }
            finally
            {
                ProcesarDetConf();
            }
        }

        #endregion

        #region IAgregaControlTransp

        public void AgregaControlTransp(Int32 cod, string nomconttrans)
        {
            cboDestino.Text = nomconttrans;
        }

        #endregion

        public Conformidad()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnasNota()
        {
            dgvNotas.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Num.";
            c1.Width = 70;
            c1.SortMode = DataGridViewColumnSortMode.NotSortable;
            c1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotas.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Fecha";
            c2.Width = 90;
            c2.SortMode = DataGridViewColumnSortMode.NotSortable;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotas.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "CodNota";
            c3.Visible = false;
            dgvNotas.Columns.Add(c3);
        }

        private void NombreColumnasDetConf()
        {
            dgvDConf.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "CodNota";
            c0.Visible = false;
            dgvDConf.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "CantTot";
            c1.Visible = false;
            dgvDConf.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Num. Nota";
            c2.Width = 150;
            c2.ReadOnly = true;
            dgvDConf.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "ProductoID";
            c3.Visible = false;
            dgvDConf.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Cantidad";
            c4.Width = 70;
            c4.MaxInputLength = 10;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDConf.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Detalle";
            c5.Width = 300;
            c5.ReadOnly = true;
            dgvDConf.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Unid.";
            c6.Width = 80;
            c6.ReadOnly = true;
            c6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDConf.Columns.Add(c6);
        }

        private void HabilitarCont()
        {
            //Habilitamos segun la DB
            //op.HabilitarCont(gbxBotones, "3.10");

            //Desabilitamos Botones
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            //
            cboOrigen.Enabled = false;
            cboDestino.Enabled = false;
            btnBuscDest.Enabled = false;
            cboChofer.Enabled = false;
            txtPlaca.ReadOnly = true;
            txtReferencia.ReadOnly = true;
            txtDetalle.ReadOnly = true;
            //
            txtZona.ReadOnly = true;
            txtBarrio.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtLat.ReadOnly = true;
            txtLong.ReadOnly = true;

            dgvDConf.ReadOnly = true;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            btnImp.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;
            btnValor.Enabled=false;

            txtBuscar.Enabled = false;
            cboTipoBusq.Enabled = false;

            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            //
            cboOrigen.Enabled = true;
            cboDestino.Enabled = true;
            btnBuscDest.Enabled = true;
            cboChofer.Enabled = true;
            txtPlaca.ReadOnly = false;
            txtReferencia.ReadOnly = false;
            txtDetalle.ReadOnly = false;
            //
            txtZona.ReadOnly = false;
            txtBarrio.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtLat.ReadOnly = false;
            txtLong.ReadOnly = false;

            dgvDConf.ReadOnly = false;
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarContrTransp()
        {
            try
            {
                LContrTans = NControlTransporte.NListarContTransp(OConexionGlobal.Ciudad).OrderBy(x => x.NomContTransporte).ToList();

                cboDestino.DataSource = LContrTans;
                cboDestino.DisplayMember = "NomContTransporte";
                cboDestino.ValueMember = "ContTransporteID";
                cboDestino.Refresh();

                cboDestino.Text = "CLIENTES VARIOS";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarChoferes()
        {
            try
            {
                LChof = NPersonal.NListarPersonales("Chofer", -1).OrderBy(x => x.NomPer).ToList();

                cboChofer.DataSource = LChof;
                cboChofer.DisplayMember = "NomPer";
                cboChofer.ValueMember = "PersonalID";
                cboChofer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarConformidad()
        {
            try
            {
                LConf = NConformidad.NListarConformidad(OConexionGlobal.SucursalID, Convert.ToDateTime(dtFechaNota.Text));
                CargarNotas(LConf);
            }
            catch (Exception)
            {
                BorrarCampos(gbxDatos, "");
                BorrarCampos(gbxUbicacion, "");
                BorrarCampos(gbxTotales, "0.00");

                NombreColumnasNota();
                NombreColumnasDetConf();
            }
        }

        private void ListarContrTranspHabil()
        {
            try
            {
                List<OControlTransporte> lcontrtrans = LContrTans.Where(x => x.Estado).OrderBy(x => x.NomContTransporte).ToList();
                
                cboDestino.DataSource = lcontrtrans;
                cboDestino.DisplayMember = "NomContTransporte";
                cboDestino.ValueMember = "ContTransporteID";
                cboDestino.Refresh();

                cboDestino.Text = "CLIENTES VARIOS";
            }
            catch
            { }
        }

        private void ListarChoferesHabil()
        {
            try
            {
                List<OPersonal> lchof = LChof.Where(x => x.Estado).OrderBy(x => x.NomPer).ToList();
                
                cboChofer.DataSource = lchof;
                cboChofer.DisplayMember = "NomPer";
                cboChofer.ValueMember = "PersonalID";
                cboChofer.Refresh();
            }
            catch
            {
                MessageBox.Show("Problemas al cargar los nombres del Personal", "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarDetNota()
        {
            try
            {
                LDConf = NDetalleConformidad.NBuscarDConf(CodConformidad);
                CargarDetalleNota(LDConf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnasDetConf();
            }
        }

        private void BuscarConformidad()
        {
            try
            {
                if (txtBuscar.Text != string.Empty)
                {
                    LBusqConf = NConformidad.NBuscarConf(cboTipoBusq.Text, txtBuscar.Text, OConexionGlobal.SucursalID, dtFechaNota.Value);
                    CargarNotas(LBusqConf);
                }
            }
            catch (Exception)
            {
                NombreColumnasNota();
                NombreColumnasDetConf();
            }
        }

        private void InsertModifConf()
        {
            try
            {
                if (dgvDConf.Rows.Count > 1)
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

                    OConformidad conf = new OConformidad();
                    OUbicacion ubic = new OUbicacion();
                    if (Opcion == "Nuevo")
                    {
                        conf.CodConformidad = "";
                    }
                    else
                    {
                        conf.CodConformidad = CodConformidad;

                        //Cargamos Detalle Modificado
                        Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("Modificar Conformidad");
                        dmodanul.Owner = this;
                        dmodanul.ShowDialog();
                        inm.DetalleInmode = dmodanul.DetaModAnul();
                    }

                    conf.SucursalID = OConexionGlobal.SucursalID;
                    conf.DestinoID = Convert.ToInt32(cboDestino.SelectedValue);
                    conf.ChoferID = Convert.ToInt32(cboChofer.SelectedValue);
                    conf.Fecha = dtFecha.Value;
                    conf.NotSalida = txtNotSalida.Text;
                    conf.Valor = Convert.ToInt32(txtValor.Text);
                    conf.Placa = txtPlaca.Text;
                    conf.Referencia = txtReferencia.Text;
                    conf.Detalle = txtDetalle.Text;
                    conf.Totalm2 = Convert.ToDecimal(txtTotMetros.Text);
                    conf.TotalPzas = Convert.ToDecimal(txtTotPzas.Text);
                    conf.TotalBolsa = Convert.ToDecimal(txtTotBolsas.Text);

                    //Ubicacion
                    ubic.CodUbicacion = CodUbicacion;
                    ubic.PaisID = 32;
                    ubic.DptoEstado = OConexionGlobal.NomSuc;
                    ubic.Ciudad = cboCiudad.Text;
                    ubic.Zona = txtZona.Text;
                    ubic.Barrio = txtBarrio.Text;
                    ubic.Direccion = txtDireccion.Text;
                    ubic.Latitud = txtLat.Text;
                    ubic.Longitud = txtLong.Text;

                    //Detalle del Conformidad
                    string dconf = InsertDetConf();

                    int resp = NConformidad.NInsertarModifConf(conf, dconf, ubic, inm);
                    if (resp > 0)
                    {
                        MessageBox.Show("Los Datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando.....");

                        Opcion = string.Empty;
                        HabilitarCont();
                        ListarConformidad();
                    }
                }
                else
                {
                    MessageBox.Show("Falta Ingresar el Detalle de la Conformidad", "Detalle Conformidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private string InsertDetConf()
        {
            string DConf = string.Empty;
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(List<ODetalleConformidad>));

            try
            {
                //Cargamos el Objeto
                List<ODetalleConformidad> ldconf = new List<ODetalleConformidad>();
                for (int i = 0; i < dgvDConf.Rows.Count - 1; i++)
                {
                    ODetalleConformidad dconf = new ODetalleConformidad();

                    dconf.CodNota = dgvDConf["CodNota", i].Value.ToString();
                    dconf.ProductoID = Convert.ToInt32(dgvDConf["ProductoID", i].Value);
                    dconf.NumNota = dgvDConf["Num. Nota", i].Value.ToString();
                    dconf.Cantidad = Convert.ToDecimal(dgvDConf["Cantidad", i].Value);
                    dconf.Estado = true;

                    ldconf.Add(dconf);
                }

                serializer.Serialize(stringwriter, ldconf);
            }
            catch (System.Xml.XmlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DConf = stringwriter.ToString();
                DConf = DConf.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
                //DCot = DCot.Replace(" - ", "");
            }

            return DConf;
        }

        private void AnulRestauConf(string o, int est)
        {
            if (txtNumConf.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("¿Desea " + o + " la Nota " + txtNumConf.Text + "?", o + " Conformidad", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        OInmode inm = new OInmode();
                        inm.CodInmode = CodInmode;
                        inm.TipoInmode = o;
                        inm.UsuarioID = OConexionGlobal.UsuarioID;
                        inm.NomInmode = OConexionGlobal.NomPer;
                        inm.IPInmode = op.SaberIP();
                        inm.MacInmode = op.SaberMac();
                        inm.MaquinaInmode = op.SaberNomMaquina();
                        inm.SistOperInmode = op.SaberSistemOper();

                        //Cargamos Detalle Anulado
                        Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(o + " Conformidad");
                        dmodanul.Owner = this;
                        dmodanul.ShowDialog();
                        inm.DetalleInmode = dmodanul.DetaModAnul();

                        int resp = NConformidad.NAnulRestauConf(CodConformidad, "Conformidad", est, inm);
                        if (resp > 0)
                        {
                            MessageBox.Show("Los Datos se Guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            op.AbrirCargando("Cargando.....");
                            
                            ListarConformidad();
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

        private void CargarNotas(List<OConformidad> lconf)
        {
            if (lconf != null)
            {
                NombreColumnasNota();

                int cont = 0;
                foreach (var item in lconf)
                {
                    dgvNotas.Rows.Add(item.NumConform, item.Fecha.ToShortDateString(), item.CodConformidad);

                    if (!item.Estado)
                        dgvNotas.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvNotas.Refresh();
            }
            else
            {
                NombreColumnasNota();
                NombreColumnasDetConf();

                BorrarCampos(gbxDatos, "");
                BorrarCampos(gbxUbicacion, "");
                BorrarCampos(gbxTotales, "0.00");

                CodConformidad = string.Empty;
                CodInmode = string.Empty;
            }
        }

        private void CargarDatosNotas()
        {
            if (OConf != null)
            {
                CodConformidad = OConf.CodConformidad;
                CodInmode = OConf.CodInmode;
                CodUbicacion = OConf.CodUbicacion;
                Estado = OConf.Estado;

                txtNumConf.Text = OConf.NumConform;
                dtFecha.Value = OConf.Fecha;
                cboOrigen.Text = OConf.NomSuc;
                cboChofer.Text = OConf.NomChofer;
                txtNotSalida.Text = OConf.NotSalida;
                txtValor.Text = OConf.Valor.ToString();
                txtPlaca.Text = OConf.Placa;
                cboChofer.Text = OConf.NomChofer;
                cboDestino.Text = OConf.NomContTransporte;
                txtReferencia.Text = OConf.Referencia;
                txtDetalle.Text = OConf.Detalle;

                //totales
                txtTotMetros.Text = string.Format("{0:#,##0.00}", OConf.Totalm2);
                txtTotPzas.Text = string.Format("{0:#,##0.00}", OConf.TotalPzas);
                txtTotBolsas.Text = string.Format("{0:#,##0.00}",OConf.TotalBolsa);
                
                //codigo QR = codigo conformidad + numero conformidad + fecha + sucursalid + choferid + valor
                qrCodeImg.Text = "Conf" + "|" + OConf.CodConformidad + "|" + OConf.NumConform + "|" + OConf.Fecha + "|" + OConf.SucursalID + "|" +
                                 OConf.ChoferID + "|" + OConf.Valor.ToString();
                
                //Ubicacion
                cboCiudad.Text = OConf.Ciudad;
                txtZona.Text = OConf.Zona;
                txtBarrio.Text = OConf.Barrio;
                txtDireccion.Text = OConf.Direccion;
                txtLat.Text = OConf.Latitud;
                txtLong.Text = OConf.Longitud;
            }
        }

        private void CargarDetalleNota(List<ODetalleConformidad> ldconf)
        {
            if (ldconf != null)
            {
                //decimal totmetro = 0;
                //decimal totpieza = 0;
                //decimal totbolsa = 0;

                NombreColumnasDetConf();

                foreach (var item in ldconf)
                {
                    dgvDConf.Rows.Add(item.CodNota, 0, item.NumNota, item.ProductoID, string.Format("{0:#,##0.00}", item.Cantidad),
                                      item.NomProd, item.UnidMedida.Trim());

                    //switch (item.UnidMedida.ToString().Trim())
                    //{
                    //    case "Mtr.":
                    //        totmetro += item.Cantidad;
                    //        break;
                    //    case "Pieza":
                    //        totpieza += item.Cantidad;
                    //        break;
                    //    case "Bolsa":
                    //        totbolsa += item.Cantidad;
                    //        break;
                    //}
                }
                //Totales
                //txtTotMetros.Text = string.Format("{0:#,##0.00}", totmetro);
                //txtTotBolsas.Text = string.Format("{0:#,##0.00}", totbolsa);
                //txtTotPzas.Text = string.Format("{0:#,##0.00}", totpieza);
            }
            else
            {
                NombreColumnasDetConf();
            }
        }

        private void CargarOrigen(Int32 cod, string nomorig)
        {
            cboOrigen.Items.Clear();
            cboOrigen.Items.Add(nomorig);
            cboOrigen.ValueMember = cod.ToString();
            cboOrigen.Text = nomorig;
        }

        private void SeleccionarNota(DataGridViewCellEventArgs e)
        {
            if(Opcion == string.Empty)
            {
                try
                {
                    BorrarCampos(gbxDatos, "");
                    BorrarCampos(gbxUbicacion, "");
                    BorrarCampos(gbxTotales, "0.00");

                    CodConformidad = dgvNotas["CodNota", e.RowIndex].Value.ToString();
                    
                    if (txtBuscar.Text == string.Empty)
                        OConf = LConf.Find(x => x.CodConformidad == CodConformidad);
                    else
                        OConf = LBusqConf.Find(x => x.CodConformidad == CodConformidad);

                    if (OConf != null)
                    {
                        CargarDatosNotas();
                        BuscarDetNota();
                    }
                }
                catch (Exception)
                {
                    BorrarCampos(gbxDatos, "");
                    BorrarCampos(gbxUbicacion, "");
                    BorrarCampos(gbxTotales, "0.00");

                    CodConformidad = string.Empty;
                    CodInmode = string.Empty;
                }
            }
        }

        #endregion

        #region Funciones

        private void SeleccionarNotas()
        {
            if (Opcion != string.Empty)
            {
                Buscadores.BusqNotas bnot = new Buscadores.BusqNotas();
                bnot.Owner = this;
                bnot.ShowDialog();
            }
        }

        private void ProcesarDetConf()
        {
            if (Opcion != string.Empty)
            {
                decimal totm2 = 0;
                decimal totpza = 0;
                decimal totbolsa = 0;
                string notsal = string.Empty;
                string notsaltot = string.Empty;

                for (int i = 0; i < dgvDConf.Rows.Count - 1; i++)
                {
                    try
                    {
                        if (dgvDConf["Unid.", i].Value.ToString().Trim() == "Mtr.")
                            totm2 += Convert.ToDecimal(dgvDConf["Cantidad", i].Value);
                        else if (dgvDConf["Unid.", i].Value.ToString().Trim() == "Pieza")
                            totpza += Convert.ToDecimal(dgvDConf["Cantidad", i].Value);
                        else if (dgvDConf["Unid.", i].Value.ToString().Trim() == "Bolsa")
                            totbolsa += Convert.ToDecimal(dgvDConf["Cantidad", i].Value);

                        if (notsal != dgvDConf["Num. Nota", i].Value.ToString())
                        {
                            notsaltot += dgvDConf["Num. Nota", i].Value.ToString() + ";";
                            notsal = dgvDConf["Num. Nota", i].Value.ToString();
                        }
                    }
                    catch (Exception)
                    { }
                }

                txtTotMetros.Text = string.Format("{0:#,##0.00}", totm2);
                txtTotBolsas.Text = string.Format("{0:#,##0.00}", totbolsa);
                txtTotPzas.Text = string.Format("{0:#,##0.00}", totpza);
                txtNotSalida.Text = notsaltot;
            }
        }

        private void Nuevo()
        {
            ListarChoferesHabil();
            ListarContrTranspHabil();
            
            Opcion = "Nuevo";
            cboCiudad.Text = OConexionGlobal.Ciudad;
            
            BorrarCampos(gbxDatos, "");
            BorrarCampos(gbxUbicacion, "");
            BorrarCampos(gbxTotales, "0.00");
            txtValor.Text = "1";
            NombreColumnasDetConf();
            DesabilitarCont();
        }

        private void Modificar()
        {
            if (txtNumConf.Text != string.Empty)
            {
                Opcion = "Modificar";
                DesabilitarCont();
            }
        }

        private void Imprimir()
        {
            if (txtNumConf.Text != string.Empty)
            {
                //agregamos el codigo qr por parametro
                MemoryStream m_MemoryStream = new MemoryStream();
                qrCodeImg.Image.Save(m_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imgqr = m_MemoryStream.ToArray();
                OConf.ImgQR = imgqr;

                Reportes.RepNotasConformidad rconf = new Reportes.RepNotasConformidad(OConf, LDConf);
                rconf.Show();
            }
        }

        private void Actualizar()
        {
            ListarContrTransp();
            ListarChoferes();
            ListarConformidad();
        }

        private void Cancelar()
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Opcion = string.Empty;
                CodInmode = string.Empty;
                CodUbicacion = string.Empty;
                CodConformidad = string.Empty;
                
                BorrarCampos(gbxDatos, "");
                BorrarCampos(gbxUbicacion, "");
                BorrarCampos(gbxTotales, "0.00");
                txtValor.Text = "1";
                NombreColumnasDetConf();
                CargarNotas(LConf);

                HabilitarCont();
            }
        }

        private void Registro()
        {
            if (txtNumConf.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        private void ValorConf()
        {
            if ((txtNumConf.Text != string.Empty) && (Estado))
            {
                OpcioRep.OpRepValorConformidad vconf = new OpcioRep.OpRepValorConformidad(LDConf, CodConformidad, cboChofer.Text, txtValor.Text);
                vconf.Owner = this;
                vconf.ShowDialog();
            }
        }

        private bool VerifItemLista(string coditem, string codnota)
        {
            bool resp = true;

            for (int i = 0; i < dgvDConf.Rows.Count - 1; i++)
            {
                try
                {
                    if ((dgvDConf["ProductoID", i].Value.ToString() == coditem) && (dgvDConf["CodNota", i].Value.ToString() == codnota))
                    {
                        resp = false;
                        break;
                    }
                }
                catch { }
            }

            return resp;
        }

        private void BorrarCampos(GroupBox gbx, string valor)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, valor);
        }

        #endregion

        #region Eventos Formulario

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
            if (txtNumConf.Text != string.Empty)
            {
                if (Estado)
                    AnulRestauConf("Anular", 0);
                else
                    MessageBox.Show("La Nota de Conformidad ya está Anulado", "Conformidad Anulado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (txtNumConf.Text != string.Empty)
            {
                if (!Estado)
                    AnulRestauConf("Restaurar", 1);
                else
                    MessageBox.Show("La Nota de Conformidad ya está Habilitado", "Conformidad Habilitado",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            Actualizar();

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifConf();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            ValorConf();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
                CargarNotas(LConf);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarConformidad();
        }

        private void dtFechaNota_ValueChanged(object sender, EventArgs e)
        {
            ListarConformidad();
        }

        private void dgvNotas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarNota(e);
        }

        private void Conformida_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            //habilitamos Controles
            HabilitarCont();

            //Agregamos el Nombre de la Sucursal como Origen
            CargarOrigen(OConexionGlobal.SucursalID, OConexionGlobal.NomSuc);

            //cargamos Busqueda de Nota de Conformidad por Defecto
            cboTipoBusq.Text = "Nota Conformidad";
            //txtBuscar.WatermarkText = "Buscar Nota Conformidad";
            cboCiudad.Text = OConexionGlobal.Ciudad;

            ListarContrTransp();
            ListarChoferes();
            ListarConformidad();

            op.CerrarCargando();
        }

        private void Conformida_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dgvDConf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarNotas();
        }

        private void dgvDConf_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDConf.CurrentCell.ColumnIndex == 4)
                {
                    decimal cant = Convert.ToDecimal(dgvDConf["Cantidad", e.RowIndex].Value);
                    decimal canttot = Convert.ToDecimal(dgvDConf["CantTot", e.RowIndex].Value);
                    
                    if (cant > canttot)
                    {
                        MessageBox.Show("La Cantidad que esta modificando no puede ser mayor", "Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvDConf["Cantidad", e.RowIndex].Value = canttot;
                    }
                    else
                        ProcesarDetConf();
                }
            }
            catch
            { }
        }

        private void dgvDConf_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int Col = dgvDConf.CurrentCell.ColumnIndex;

            if(Col == 4)
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dgvDConf_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dgvDConf_KeyPress);
                }
            }
        }

        private void dgvDConf_KeyPress(object sender, KeyPressEventArgs e)
        {
            int Col = dgvDConf.CurrentCell.ColumnIndex;

            if (Col == 4)
            {

                if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnBuscDest_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvDConf_KeyDown(object sender, KeyEventArgs e)
        {
            if (Opcion != string.Empty)
            {
                if ((e.KeyCode == Keys.Escape) || (e.KeyCode == Keys.Delete)) // para eliminar la fila
                {
                    DialogResult result = MessageBox.Show("Esta seguro que desea Eliminar esta Fila?", "Eliminar Fila",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            //eliminamos la fila seleccionada
                            dgvDConf.Rows.RemoveAt(dgvDConf.CurrentRow.Index);

                            ProcesarDetConf();
                        }
                        catch
                        { }
                    }
                }
            }
        }

        private void cboDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                OControlTransporte ocontrans = LContrTans.Find(x => x.NomContTransporte == cboDestino.Text);
                txtValor.Text = ocontrans.Valor.ToString();
            }
            catch (Exception)
            {    }
        }

        #endregion
    }
}

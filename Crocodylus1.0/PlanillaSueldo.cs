using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;

using Objetos;
using Negocio;
using System.Xml.Serialization;

namespace GRTechnology1._0
{
    public partial class PlanillaSueldo : Form, IAgregaPerCompleto, IAgregaDetPlanilla
    {
        OpcionFormularios op = new OpcionFormularios();

        string Opcion = string.Empty;
        string CodPlanilla = string.Empty;
        string CodInmode = string.Empty;

        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", 
                           "Octubre", "Noviembre", "Diciembre" };
        int[] valmes = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            
        List<OSucursal> LSuc = null;
        List<OPersonal> LPer = null;
        List<ODetallePlanillaSueldo> LDPla = null;

        OPlanillaSueldo Pla = null;
        ODetallePlanillaSueldo DPla = null;

        #region IAgregaPerCompleto

        public void AgregaPerCompleto(OPersonal Per)
        {
            if(VerifListaPersonal(Per.PersonalID.ToString()))
            {
                try
                {

                }
                catch (Exception)
                {   }
            }
            else
            {
                MessageBox.Show("El Personal ya se encuentra en la Planilla de Sueldo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region IAgregaDetPlanilla

        public void AgregaDetPlanilla(ODetallePlanillaSueldo dpla)
        {
            for (int i = 0; i < dgvPlanilla.Rows.Count; i++)
            {
                if(dpla.PersonalID.ToString() == dgvPlanilla["PersonalID", i].Value.ToString())
                {
                    //Ingresos
                    dgvPlanilla["Haber Basico", i].Value = string.Format("{0:#,##0.00}", dpla.HaberBasico);
                    dgvPlanilla["Dias Trabaj.", i].Value = string.Format("{0:#,##0.00}", dpla.DiasTrabaj);
                    dgvPlanilla["Haber Ganado", i].Value = string.Format("{0:#,##0.00}", dpla.HaberGanado);
                    dgvPlanilla["Bono Antiguedad", i].Value = string.Format("{0:#,##0.00}", dpla.BonoAntig);
                    dgvPlanilla["Bono H. Ext.", i].Value = string.Format("{0:#,##0.00}", dpla.BonoHrExtr);
                    dgvPlanilla["Comision S/Ventas", i].Value = string.Format("{0:#,##0.00}", dpla.ComisionSVentas);
                    dgvPlanilla["Incremento", i].Value = string.Format("{0:#,##0.00}", dpla.Incremento);
                    dgvPlanilla["Otros Bonos", i].Value = string.Format("{0:#,##0.00}", dpla.OtrosBonos);
                    dgvPlanilla["TOTAL Ganado", i].Value = string.Format("{0:#,##0.00}", dpla.TotalGanado);
                    //descuentos
                    dgvPlanilla["Anticipo Sueldo", i].Value = string.Format("{0:#,##0.00}", dpla.AnticipSueldo);
                    dgvPlanilla["Anticipo Almuerzo", i].Value = string.Format("{0:#,##0.00}", dpla.AnticipAlmuerzo);
                    dgvPlanilla["Prestamos", i].Value = string.Format("{0:#,##0.00}", dpla.Prestamos);
                    dgvPlanilla["Celular Corpo.", i].Value = string.Format("{0:#,##0.00}", dpla.CelCorpo);
                    dgvPlanilla["DSCTOS. Falt. Inv.", i].Value = string.Format("{0:#,##0.00}", dpla.DsctoFaltInv);
                    dgvPlanilla["Multas y Sanciones", i].Value = string.Format("{0:#,##0.00}", dpla.MultasSanciones);
                    dgvPlanilla["TOTAL Dscto.", i].Value = string.Format("{0:#,##0.00}", dpla.TotalDscto);
                    dgvPlanilla["LIQUIDO PAGABLE", i].Value = string.Format("{0:#,##0.00}", dpla.LiquidoPagable);

                    break;
                }
            }
            GenerarTotales();
        }

        #endregion

        public PlanillaSueldo()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void CargarNombresColumnas()
        {
            dgvPlanilla.Columns.Clear();

            DataGridViewTextBoxColumn c00 = new DataGridViewTextBoxColumn();
            c00.Name = "Estado";
            c00.Visible = false;
            dgvPlanilla.Columns.Add(c00);

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "N°";
            c0.Width = 35;
            c0.ReadOnly = true;
            c0.SortMode = DataGridViewColumnSortMode.NotSortable;
            c0.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanilla.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "PersonalID";
            c1.Visible = false;
            dgvPlanilla.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Nombre y Apellidos";
            c2.Width = 200;
            c2.ReadOnly = true;
            c2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPlanilla.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fec. Ingreso";
            c3.Width = 80;
            c3.ReadOnly = true;
            c3.SortMode = DataGridViewColumnSortMode.NotSortable;
            c3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanilla.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "CI";
            c4.Width = 90;
            c4.ReadOnly = true;
            c4.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPlanilla.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Cargo";
            c5.Width = 100;
            c5.ReadOnly = true;
            c5.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvPlanilla.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Haber Basico";
            c6.Width = 90;
            c6.ReadOnly = true;
            c6.SortMode = DataGridViewColumnSortMode.NotSortable;
            c6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Dias Trabaj.";
            c7.Width = 65;
            c7.MaxInputLength = 4;
            c7.SortMode = DataGridViewColumnSortMode.NotSortable;
            c7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPlanilla.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Haber Ganado";
            c8.Width = 90;
            c8.ReadOnly = true;
            c8.MaxInputLength = 10;
            c8.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            c8.SortMode = DataGridViewColumnSortMode.NotSortable;
            c8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "Bono Antiguedad";
            c9.Width = 90;
            c9.MaxInputLength = 10;
            c9.SortMode = DataGridViewColumnSortMode.NotSortable;
            c9.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c9);

            DataGridViewTextBoxColumn c10 = new DataGridViewTextBoxColumn();
            c10.Name = "Bono H. Ext.";
            c10.Width = 90;
            c10.MaxInputLength = 10;
            c10.SortMode = DataGridViewColumnSortMode.NotSortable;
            c10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c10);

            DataGridViewTextBoxColumn c11 = new DataGridViewTextBoxColumn();
            c11.Name = "Comision S/Ventas";
            c11.Width = 90;
            c11.MaxInputLength = 10;
            c11.SortMode = DataGridViewColumnSortMode.NotSortable;
            c11.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c11);

            DataGridViewTextBoxColumn c12 = new DataGridViewTextBoxColumn();
            c12.Name = "Incremento";
            c12.Width = 90;
            c12.ReadOnly = true;
            c12.MaxInputLength = 10;
            c12.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            c12.SortMode = DataGridViewColumnSortMode.NotSortable;
            c12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c12);

            DataGridViewTextBoxColumn c13 = new DataGridViewTextBoxColumn();
            c13.Name = "Otros Bonos";
            c13.Width = 90;
            c13.ReadOnly = true;
            c13.MaxInputLength = 10;
            c13.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            c13.SortMode = DataGridViewColumnSortMode.NotSortable;
            c13.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c13);

            DataGridViewTextBoxColumn c14 = new DataGridViewTextBoxColumn();
            c14.Name = "TOTAL Ganado";
            c14.Width = 90;
            c14.ReadOnly = true;
            c14.MaxInputLength = 10;
            c14.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            c14.SortMode = DataGridViewColumnSortMode.NotSortable;
            c14.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c14);

            DataGridViewTextBoxColumn c15 = new DataGridViewTextBoxColumn();
            c15.Name = "Anticipo Sueldo";
            c15.Width = 90;
            c15.MaxInputLength = 10;
            c15.SortMode = DataGridViewColumnSortMode.NotSortable;
            c15.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c15);

            DataGridViewTextBoxColumn c16 = new DataGridViewTextBoxColumn();
            c16.Name = "Anticipo Almuerzo";
            c16.Width = 90;
            c16.MaxInputLength = 10;
            c16.SortMode = DataGridViewColumnSortMode.NotSortable;
            c16.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c16);

            DataGridViewTextBoxColumn c17 = new DataGridViewTextBoxColumn();
            c17.Name = "Prestamos";
            c17.Width = 90;
            c17.MaxInputLength = 10;
            c17.SortMode = DataGridViewColumnSortMode.NotSortable;
            c17.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c17);

            DataGridViewTextBoxColumn c18 = new DataGridViewTextBoxColumn();
            c18.Name = "Celular Corpo.";
            c18.Width = 90;
            c18.MaxInputLength = 10;
            c18.SortMode = DataGridViewColumnSortMode.NotSortable;
            c18.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c18);

            DataGridViewTextBoxColumn c19 = new DataGridViewTextBoxColumn();
            c19.Name = "DSCTOS. Falt. Inv.";
            c19.Width = 90;
            c19.MaxInputLength = 10;
            c19.SortMode = DataGridViewColumnSortMode.NotSortable;
            c19.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c19);

            DataGridViewTextBoxColumn c20 = new DataGridViewTextBoxColumn();
            c20.Name = "Multas y Sanciones";
            c20.Width = 90;
            c20.MaxInputLength = 10;
            c20.SortMode = DataGridViewColumnSortMode.NotSortable;
            c20.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c20);

            DataGridViewTextBoxColumn c21 = new DataGridViewTextBoxColumn();
            c21.Name = "TOTAL Dscto.";
            c21.Width = 90;
            c21.ReadOnly = true;
            c21.MaxInputLength = 10;
            c21.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            c21.SortMode = DataGridViewColumnSortMode.NotSortable;
            c21.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c21);

            DataGridViewTextBoxColumn c22 = new DataGridViewTextBoxColumn();
            c22.Name = "LIQUIDO PAGABLE";
            c22.Width = 90;
            c22.ReadOnly = true;
            c22.MaxInputLength = 10;
            c22.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            c22.SortMode = DataGridViewColumnSortMode.NotSortable;
            c22.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPlanilla.Columns.Add(c22);
        }

        private void HabilitarCont()
        {
            //habilitamos controles primarios
            //op.HabilitarCont(gbxBotones, "6.01");
            dtFechaPla.Enabled = true;

            //Desabilitamos
            cboGestionPla.Enabled = false;
            cboMesPla.Enabled = false;
            txtObs.ReadOnly = true;

            btnImpBoleta.Enabled = true;

            btnProcesar.Enabled = false;
            btnElimFila.Enabled = false;
            btnAgrFila.Enabled = false;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos controles primarios
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnImp.Enabled = false;
            btnAct.Enabled = false;
            dtFechaPla.Enabled = false;

            //Habilitamos controles primarios
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            cboGestionPla.Enabled = true;
            cboMesPla.Enabled = true;
            txtObs.ReadOnly = false;

            btnImpBoleta.Enabled = false;

            btnProcesar.Enabled = true;
            btnElimFila.Enabled = true;
            btnAgrFila.Enabled = true;
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarPersonal()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("Personal", -1).Where(x => x.Estado).OrderBy(x => x.NomPer).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarSucursal()
        {
            try
            {
                LSuc = NSucursal.NListarSucursales().Where(x => x.Estado).OrderBy(x => x.NomSuc).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPlanillaSueldo()
        {
            try
            {
                XmlDocument[] datosxml = new XmlDocument[1];
                datosxml = NPlanillaSueldo.NListarPlanillaSueldo(dtFechaPla.Value);

                XmlDocument pla = datosxml[0];
                XmlDocument dpla = datosxml[1];

                //cargamos datos de la planilla de sueldo
                CargarPlanilla(pla);
                CargarDPlanilla(dpla);

                //CargarDPlanilla(dpla);
                //CargarDPlanilla(dpla.OuterXml);
            }
            catch (Exception)
            {
                CargarNombresColumnas();
            }
        }

        private void InsertModifPlanillaSueldo()
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

                OPlanillaSueldo pla = new OPlanillaSueldo();
                if(Opcion == "Nuevo")
                {
                    pla.CodPlanilla = string.Empty;
                }
                else
                {
                    pla.CodPlanilla = CodPlanilla;

                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("Modificar");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();
                    inm.DetalleInmode = dmodanul.DetaModAnul();
                }
                pla.Gestion = Convert.ToInt32(cboGestionPla.Text);
                pla.Mes = Convert.ToInt32(cboMesPla.ValueMember);
                pla.Observacion = txtObs.Text;
                pla.LiquidoPagable = Convert.ToDecimal(txtLiquidoPag.Text);

                int resp = NPlanillaSueldo.NInsertModifPlanillaSueldo(pla, InsertDetPlanillaSueldo(), inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    ListarPlanillaSueldo();
                    HabilitarCont();
                    btnCancel.Enabled = false;
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

        private string InsertDetPlanillaSueldo()
        {
            string DPlaSueld = string.Empty;
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(typeof(List<ODetallePlanillaSueldo>));

            //Cargamos el Objeto
            List<ODetallePlanillaSueldo> ldpla = new List<ODetallePlanillaSueldo>();
            for (int i = 0; i < dgvPlanilla.Rows.Count; i++)
            {
                ODetallePlanillaSueldo dplasuel = new ODetallePlanillaSueldo();

                dplasuel.CodPlanilla = CodPlanilla;

                if (dgvPlanilla["Estado", i].Value.ToString() == "0")
                    dplasuel.SucursalID = Convert.ToInt32(dgvPlanilla["PersonalID", i].Value);
                else
                    dplasuel.PersonalID = Convert.ToInt32(dgvPlanilla["PersonalID", i].Value);

                dplasuel.NumOrden = i;
                dplasuel.Estado = Convert.ToBoolean(dgvPlanilla["Estado", i].Value);
                dplasuel.Nro = dgvPlanilla["N°", i].Value.ToString();
                //Datos Personal
                dplasuel.Cargo = dgvPlanilla["Cargo", i].Value.ToString();
                dplasuel.HaberBasico = Convert.ToDecimal(dgvPlanilla["Haber Basico", i].Value);

                if (!string.IsNullOrEmpty(dgvPlanilla["Fec. Ingreso", i].Value.ToString()))
                {
                    int dia = Convert.ToInt32(dgvPlanilla["Fec. Ingreso", i].Value.ToString().Substring(0, 2));
                    int mes = Convert.ToInt32(dgvPlanilla["Fec. Ingreso", i].Value.ToString().Substring(3, 2));
                    int anio = Convert.ToInt32(dgvPlanilla["Fec. Ingreso", i].Value.ToString().Substring(6, 4));

                    DateTime fecing = new DateTime(anio, mes, dia);
                    dplasuel.FecIng = fecing;
                }

                dplasuel.CI = dgvPlanilla["CI", i].Value.ToString();
                dplasuel.NomPer = dgvPlanilla["Nombre y Apellidos", i].Value.ToString();

                int c = 0;
                if (i == dgvPlanilla.Rows.Count - 4)
                    c = i;

                dplasuel.HaberGanado = Convert.ToDecimal(dgvPlanilla["Haber Ganado", i].Value);

                try
                {
                    if (!string.IsNullOrEmpty(dgvPlanilla["Dias Trabaj.", i].Value.ToString()))
                        dplasuel.DiasTrabaj = Convert.ToDecimal(dgvPlanilla["Dias Trabaj.", i].Value);
                }
                catch (Exception)
                {      }

                try
                {
                    //Ingresos Personal
                    if (!string.IsNullOrEmpty(dgvPlanilla["Bono Antiguedad", i].Value.ToString()))
                        dplasuel.BonoAntig = Convert.ToDecimal(dgvPlanilla["Bono Antiguedad", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["Bono H. Ext.", i].Value.ToString()))
                        dplasuel.BonoHrExtr = Convert.ToDecimal(dgvPlanilla["Bono H. Ext.", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["Comision S/Ventas", i].Value.ToString()))
                        dplasuel.ComisionSVentas = Convert.ToDecimal(dgvPlanilla["Comision S/Ventas", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["Incremento", i].Value.ToString()))
                        dplasuel.Incremento = Convert.ToDecimal(dgvPlanilla["Incremento", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["Otros Bonos", i].Value.ToString()))
                        dplasuel.OtrosBonos = Convert.ToDecimal(dgvPlanilla["Otros Bonos", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["TOTAL Ganado", i].Value.ToString()))
                        dplasuel.TotalGanado = Convert.ToDecimal(dgvPlanilla["TOTAL Ganado", i].Value);

                    //Descuentos PErsonal
                    if (!string.IsNullOrEmpty(dgvPlanilla["Anticipo Sueldo", i].Value.ToString()))
                        dplasuel.AnticipSueldo = Convert.ToDecimal(dgvPlanilla["Anticipo Sueldo", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["Anticipo Almuerzo", i].Value.ToString()))
                        dplasuel.AnticipAlmuerzo = Convert.ToDecimal(dgvPlanilla["Anticipo Almuerzo", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["Prestamos", i].Value.ToString()))
                        dplasuel.Prestamos = Convert.ToDecimal(dgvPlanilla["Prestamos", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["Celular Corpo.", i].Value.ToString()))
                        dplasuel.CelCorpo = Convert.ToDecimal(dgvPlanilla["Celular Corpo.", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["DSCTOS. Falt. Inv.", i].Value.ToString()))
                        dplasuel.DsctoFaltInv = Convert.ToDecimal(dgvPlanilla["DSCTOS. Falt. Inv.", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["Multas y Sanciones", i].Value.ToString()))
                        dplasuel.MultasSanciones = Convert.ToDecimal(dgvPlanilla["Multas y Sanciones", i].Value);

                    if (!string.IsNullOrEmpty(dgvPlanilla["TOTAL Dscto.", i].Value.ToString()))
                        dplasuel.TotalDscto = Convert.ToDecimal(dgvPlanilla["TOTAL Dscto.", i].Value);

                    //Total Ganado
                    if (!string.IsNullOrEmpty(dgvPlanilla["LIQUIDO PAGABLE", i].Value.ToString()))
                        dplasuel.LiquidoPagable = Convert.ToDecimal(dgvPlanilla["LIQUIDO PAGABLE", i].Value);
                }
                catch (Exception)
                {   }

                ldpla.Add(dplasuel);
            }
            //serializamos la lista
            serializer.Serialize(stringwriter, ldpla);
            DPlaSueld = stringwriter.ToString();
            DPlaSueld = DPlaSueld.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");

            return DPlaSueld;
        }

        #endregion

        #region Cargar Datos

        private void CargarPlanilla(XmlDocument pla)
        {
            XmlNodeList elemList = pla.GetElementsByTagName("Planilla");
            XmlNodeList nNodo;

            foreach (XmlElement nodo in elemList)
            {
                nNodo = nodo.GetElementsByTagName("CodPlanilla");
                CodPlanilla = nNodo[0].InnerText;

                nNodo = nodo.GetElementsByTagName("CodInmode");
                CodInmode = nNodo[0].InnerText;

                nNodo = nodo.GetElementsByTagName("Gestion");
                cboGestionPla.Text = nNodo[0].InnerText;

                nNodo = nodo.GetElementsByTagName("Mes");
                cboMesPla.Text = meses[Convert.ToInt32(nNodo[0].InnerText) - 1];

                nNodo = nodo.GetElementsByTagName("LiquidoPagableBs");
                txtLiquidoPag.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = nodo.GetElementsByTagName("Observacion");
                txtObs.Text = nNodo[0].InnerText;

                ///////------------
                nNodo = nodo.GetElementsByTagName("Pagado");
                if (Convert.ToInt32(nNodo[0].InnerText) == 1)
                    ckbxPag.Checked = true;
                else
                    ckbxPag.Checked = false;
                ////-----------------
                nNodo = nodo.GetElementsByTagName("Autorizado");
                if (Convert.ToInt32(nNodo[0].InnerText) == 1)
                    ckbxAutoriz.Checked = true;
                else
                    ckbxAutoriz.Checked = false;
            }
        }

        private void CargarDPlanilla(XmlDocument dpla)
        {
            CargarNombresColumnas();

            XmlNodeList elemList = dpla.GetElementsByTagName("DPlanilla");
            XmlNodeList nNodo;

            int cont = 0;
            dgvPlanilla.Rows.Add(elemList.Count - 1);

            foreach (XmlElement item in elemList)
            {
                nNodo = item.GetElementsByTagName("Estado");
                dgvPlanilla["Estado", cont].Value = Convert.ToInt32(nNodo[0].InnerText);

                if (nNodo[0].InnerText == "1")
                {
                    nNodo = item.GetElementsByTagName("Nro");
                    dgvPlanilla["N°", cont].Value = nNodo[0].InnerText;

                    nNodo = item.GetElementsByTagName("FecIng");
                    dgvPlanilla["Fec. Ingreso", cont].Value = Convert.ToDateTime(nNodo[0].InnerText).ToShortDateString();

                    nNodo = item.GetElementsByTagName("CI");
                    dgvPlanilla["CI", cont].Value = nNodo[0].InnerText;

                    nNodo = item.GetElementsByTagName("Cargo");
                    dgvPlanilla["Cargo", cont].Value = nNodo[0].InnerText;

                    nNodo = item.GetElementsByTagName("DiasTrabaj");
                    dgvPlanilla["Dias Trabaj.", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));
                }
                else
                {
                    dgvPlanilla["N°", cont].Value = string.Empty;
                    dgvPlanilla["Fec. Ingreso", cont].Value = string.Empty;
                    dgvPlanilla["CI", cont].Value = string.Empty;
                    dgvPlanilla["Cargo", cont].Value = string.Empty;
                    dgvPlanilla["Dias Trabaj.", cont].Value = string.Empty;

                    dgvPlanilla.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
                }
                
                nNodo = item.GetElementsByTagName("PersonalID");
                dgvPlanilla["PersonalID", cont].Value = nNodo[0].InnerText;

                nNodo = item.GetElementsByTagName("NomPer");
                dgvPlanilla["Nombre y Apellidos", cont].Value = nNodo[0].InnerText;

                nNodo = item.GetElementsByTagName("HaberBasico");
                dgvPlanilla["Haber Basico", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("HaberGanado");
                dgvPlanilla["Haber Ganado", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("BonoAntig");
                dgvPlanilla["Bono Antiguedad", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("BonoHrExt");
                dgvPlanilla["Bono H. Ext.", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("ComisionSVentas");
                dgvPlanilla["Comision S/Ventas", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("Incremento");
                dgvPlanilla["Incremento", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("OtrosBonos");
                dgvPlanilla["Otros Bonos", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("TotalGanado");
                dgvPlanilla["TOTAL Ganado", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("AnticipSueldo");
                dgvPlanilla["Anticipo Sueldo", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("AnticipAlmuerzo");
                dgvPlanilla["Anticipo Almuerzo", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("Prestamos");
                dgvPlanilla["Prestamos", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("CelCorpo");
                dgvPlanilla["Celular Corpo.", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("DsctoFaltInv");
                dgvPlanilla["DSCTOS. Falt. Inv.", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("MultasSanciones");
                dgvPlanilla["Multas y Sanciones", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("TotalDscto");
                dgvPlanilla["TOTAL Dscto.", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                nNodo = item.GetElementsByTagName("LiquidoPagable");
                dgvPlanilla["LIQUIDO PAGABLE", cont].Value = string.Format("{0:#,##0.00}", Convert.ToDecimal(nNodo[0].InnerText));

                cont++;
            }
        }

        private void CargarListaDPlanilla(bool suc)
        {
            try
            {
                LDPla = new List<ODetallePlanillaSueldo>();

                for (int i = 0; i < dgvPlanilla.Rows.Count; i++)
                {
                    if (dgvPlanilla["Estado", i].Value.ToString() == "1")
                    {
                        ODetallePlanillaSueldo dpla = new ODetallePlanillaSueldo();

                        dpla.Estado = Convert.ToBoolean(dgvPlanilla["Estado", i].Value);
                        dpla.Nro = dgvPlanilla["N°", i].Value.ToString();
                        dpla.PersonalID = Convert.ToInt32(dgvPlanilla["PersonalID", i].Value);
                        dpla.NomPer = dgvPlanilla["Nombre y Apellidos", i].Value.ToString();
                        dpla.FecIng = Convert.ToDateTime(dgvPlanilla["Fec. Ingreso", i].Value);
                        dpla.CI = dgvPlanilla["CI", i].Value.ToString();
                        dpla.Cargo = dgvPlanilla["Cargo", i].Value.ToString();
                        dpla.HaberBasico = Convert.ToDecimal(dgvPlanilla["Haber Basico", i].Value);
                        dpla.DiasTrabaj = Convert.ToDecimal(dgvPlanilla["Dias Trabaj.", i].Value);
                        dpla.HaberGanado = Convert.ToDecimal(dgvPlanilla["Haber Ganado", i].Value);
                        dpla.BonoAntig = Convert.ToDecimal(dgvPlanilla["Bono Antiguedad", i].Value);
                        dpla.BonoHrExtr = Convert.ToDecimal(dgvPlanilla["Bono H. Ext.", i].Value);
                        dpla.ComisionSVentas = Convert.ToDecimal(dgvPlanilla["Comision S/Ventas", i].Value);
                        dpla.TotalGanado = Convert.ToDecimal(dgvPlanilla["TOTAL Ganado", i].Value);
                        dpla.AnticipSueldo = Convert.ToDecimal(dgvPlanilla["Anticipo Sueldo", i].Value);
                        dpla.AnticipAlmuerzo = Convert.ToDecimal(dgvPlanilla["Anticipo Almuerzo", i].Value);
                        dpla.Prestamos = Convert.ToDecimal(dgvPlanilla["Prestamos", i].Value);
                        dpla.CelCorpo = Convert.ToDecimal(dgvPlanilla["Celular Corpo.", i].Value);
                        dpla.DsctoFaltInv = Convert.ToDecimal(dgvPlanilla["DSCTOS. Falt. Inv.", i].Value);
                        dpla.MultasSanciones = Convert.ToDecimal(dgvPlanilla["Multas y Sanciones", i].Value);
                        dpla.TotalDscto = Convert.ToDecimal(dgvPlanilla["TOTAL Dscto.", i].Value);
                        dpla.LiquidoPagable = Convert.ToDecimal(dgvPlanilla["LIQUIDO PAGABLE", i].Value);

                        try
                        {
                            dpla.Img = NPersonal.NBuscarImgPer(Convert.ToInt32(dgvPlanilla["PersonalID", i].Value));
                        }
                        catch (Exception)
                        {    }
                        
                        LDPla.Add(dpla);
                    }
                    else if((dgvPlanilla["Estado", i].Value.ToString() == "0") && (suc))
                    {
                        ODetallePlanillaSueldo dpla = new ODetallePlanillaSueldo();

                        dpla.Estado = false;
                        dpla.SucursalID = Convert.ToInt32(dgvPlanilla["PersonalID", i].Value);
                        dpla.NomPer = dgvPlanilla["Nombre y Apellidos", i].Value.ToString();
                        dpla.HaberBasico = Convert.ToDecimal(dgvPlanilla["Haber Basico", i].Value);
                        dpla.BonoAntig = Convert.ToDecimal(dgvPlanilla["Bono Antiguedad", i].Value);
                        dpla.BonoHrExtr = Convert.ToDecimal(dgvPlanilla["Bono H. Ext.", i].Value);
                        dpla.ComisionSVentas = Convert.ToDecimal(dgvPlanilla["Comision S/Ventas", i].Value);
                        dpla.TotalGanado = Convert.ToDecimal(dgvPlanilla["TOTAL Ganado", i].Value);
                        dpla.AnticipSueldo = Convert.ToDecimal(dgvPlanilla["Anticipo Sueldo", i].Value);
                        dpla.AnticipAlmuerzo = Convert.ToDecimal(dgvPlanilla["Anticipo Almuerzo", i].Value);
                        dpla.Prestamos = Convert.ToDecimal(dgvPlanilla["Prestamos", i].Value);
                        dpla.CelCorpo = Convert.ToDecimal(dgvPlanilla["Celular Corpo.", i].Value);
                        dpla.DsctoFaltInv = Convert.ToDecimal(dgvPlanilla["DSCTOS. Falt. Inv.", i].Value);
                        dpla.MultasSanciones = Convert.ToDecimal(dgvPlanilla["Multas y Sanciones", i].Value);
                        dpla.TotalDscto = Convert.ToDecimal(dgvPlanilla["TOTAL Dscto.", i].Value);
                        dpla.LiquidoPagable = Convert.ToDecimal(dgvPlanilla["LIQUIDO PAGABLE", i].Value);

                        LDPla.Add(dpla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeleccionarDPlanilla(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)  
                {
                    string personid = dgvPlanilla["PersonalID", e.RowIndex].Value.ToString();
                    if(personid != "-1")
                    {
                        DPla = new ODetallePlanillaSueldo();
                        DPla.Nro = dgvPlanilla["PersonalID", e.RowIndex].Value.ToString();
                        DPla.Estado = true;
                        DPla.Nro = dgvPlanilla["N°", e.RowIndex].Value.ToString();
                        DPla.PersonalID = Convert.ToInt32(dgvPlanilla["PersonalID", e.RowIndex].Value);
                        DPla.NomPer = dgvPlanilla["Nombre y Apellidos", e.RowIndex].Value.ToString();
                        DPla.FecIng = Convert.ToDateTime(dgvPlanilla["Fec. Ingreso", e.RowIndex].Value);
                        DPla.CI = dgvPlanilla["CI", e.RowIndex].Value.ToString();
                        DPla.Cargo = dgvPlanilla["Cargo", e.RowIndex].Value.ToString();
                        DPla.HaberBasico = Convert.ToDecimal(dgvPlanilla["Haber Basico", e.RowIndex].Value);
                        DPla.DiasTrabaj = Convert.ToDecimal(dgvPlanilla["Dias Trabaj.", e.RowIndex].Value);
                        DPla.HaberGanado = Convert.ToDecimal(dgvPlanilla["Haber Ganado", e.RowIndex].Value);
                        DPla.BonoAntig = Convert.ToDecimal(dgvPlanilla["Bono Antiguedad", e.RowIndex].Value);
                        DPla.BonoHrExtr = Convert.ToDecimal(dgvPlanilla["Bono H. Ext.", e.RowIndex].Value);
                        DPla.ComisionSVentas = Convert.ToDecimal(dgvPlanilla["Comision S/Ventas", e.RowIndex].Value);
                        DPla.TotalGanado = Convert.ToDecimal(dgvPlanilla["TOTAL Ganado", e.RowIndex].Value);
                        DPla.AnticipSueldo = Convert.ToDecimal(dgvPlanilla["Anticipo Sueldo", e.RowIndex].Value);
                        DPla.AnticipAlmuerzo = Convert.ToDecimal(dgvPlanilla["Anticipo Almuerzo", e.RowIndex].Value);
                        DPla.Prestamos = Convert.ToDecimal(dgvPlanilla["Prestamos", e.RowIndex].Value);
                        DPla.CelCorpo = Convert.ToDecimal(dgvPlanilla["Celular Corpo.", e.RowIndex].Value);
                        DPla.DsctoFaltInv = Convert.ToDecimal(dgvPlanilla["DSCTOS. Falt. Inv.", e.RowIndex].Value);
                        DPla.MultasSanciones = Convert.ToDecimal(dgvPlanilla["Multas y Sanciones", e.RowIndex].Value);
                        DPla.TotalDscto = Convert.ToDecimal(dgvPlanilla["TOTAL Dscto.", e.RowIndex].Value);
                        DPla.LiquidoPagable = Convert.ToDecimal(dgvPlanilla["LIQUIDO PAGABLE", e.RowIndex].Value);
                    }
                }
            }
            catch (Exception)
            { }
        }

        #endregion

        #region Funciones

        private void BorrarCampos()
        {
            cboMesPla.Text = meses[DateTime.Now.Month - 1]; 
            cboGestionPla.Text = DateTime.Now.Year.ToString();

            txtLiquidoPag.Text = "0.00";
            txtObs.Clear();
            ckbxPag.Checked = false;
            ckbxAutoriz.Checked = false;

            CargarNombresColumnas();
        }

        private bool VerifListaPersonal(string perid)
        {
            bool resp = true;
            for (int i = 0; i < dgvPlanilla.Rows.Count - 1; i++)
            {
                try
                {
                    if (dgvPlanilla["PersonalID", i].Value.ToString() == perid)
                    {
                        resp = false;
                        break;
                    }
                }
                catch { }
            }

            return resp;
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                Opcion = string.Empty;
                BorrarCampos();
                HabilitarCont();
                btnCancel.Enabled = false;
            }
        }

        private void CancelarPlanilla()
        {
            cboGestionPla.Enabled = true;
            cboMesPla.Enabled = true;
            btnCancel.Enabled = false;
            btnProcesar.Enabled = true;
            CargarNombresColumnas();
        }

        private void CargarMeses()
        {
            cboMesPla.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                cboMesPla.Items.Add(meses[i]);
                cboMesPla.ValueMember = valmes[i].ToString();
                cboMesPla.Text = meses[i];
            }
        }

        private void Procesar()
        {
            int contfila = -1;
            int contfilasuc = -1;
            int contper = 1;

            decimal suchaberbasic = 0;
            decimal tothaberbasic = 0;
            try
            {
                CargarNombresColumnas();

                int vmes = 1;
                for (int i = 0; i < 12; i++)
                {
                    if (meses[i] == cboMesPla.Text)
                    {
                        vmes = i + 1;
                        cboMesPla.ValueMember = vmes.ToString();
                        break;
                    }
                }

                foreach (var suc in LSuc)
                {
                    contfila++;
                    contfilasuc = contfila;

                    //insertamos la sucursal
                    dgvPlanilla.Rows.Add(0, "", suc.SucursalID, suc.NomSuc, "", "", "");
                    //cambiamos de color la fila
                    dgvPlanilla.Rows[contfila].DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
                    
                    List<OPersonal> LPerBusq = LPer.FindAll(x => x.SucursalID == suc.SucursalID);
                    foreach (var per in LPerBusq)
                    {
                        dgvPlanilla.Rows.Add(1, contper, per.PersonalID, per.NomPer, per.FecIngreso.ToShortDateString(), per.CI, per.NomCargo, 
                                            string.Format("{0:#,##0.00}", per.HaberBasico));

                        suchaberbasic += per.HaberBasico;
                        tothaberbasic += per.HaberBasico;

                        contfila++;
                        contper++;
                    }
                    dgvPlanilla["Haber Basico", contfilasuc].Value = string.Format("{0:#,##0.00}", suchaberbasic);
                    suchaberbasic = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarNombresColumnas();
            }
            finally
            {
                dgvPlanilla.Rows.Add(0, "", -1, "TOTAL PLANILLA", "", "", "", string.Format("{0:#,##0.00}", tothaberbasic));
                dgvPlanilla.Rows[contfila+1].DefaultCellStyle.BackColor = System.Drawing.Color.Silver;

                dgvPlanilla.AllowUserToAddRows = false;
            }
        }

        private void GenerarTotales()
        {
            int contfila = -1;
            int contfilasuc = 0;

            decimal suchaberbasic = 0;
            decimal suchaberganado = 0;
            decimal sucbonoantig = 0;
            decimal sucbonohrext = 0;
            decimal succomiventas = 0;
            decimal sucincremento = 0;
            decimal sucotrosbonos = 0;
            decimal suctotganado = 0;
            decimal sucanticipsueld=0;
            decimal sucanticipalmuer=0;
            decimal sucprestamos=0;
            decimal succelcorpo=0;
            decimal sucdsctofaltinv=0;
            decimal sucmultasancion=0;
            decimal suctotdscto=0;
            decimal sucliqpagable=0;
            
            decimal tothaberbasic = 0;
            decimal tothaberganado = 0;
            decimal totbonoantig = 0;
            decimal totbonohrext = 0;
            decimal totcomiventas = 0;
            decimal totincremento = 0;
            decimal tototrosbonos = 0;
            decimal tottotganado = 0;
            decimal totanticipsueld = 0;
            decimal totanticipalmuer = 0;
            decimal totprestamos = 0;
            decimal totcelcorpo = 0;
            decimal totdsctofaltinv = 0;
            decimal totmultasancion = 0;
            decimal tottotdscto = 0;
            decimal totliqpagable = 0;
            try
            {
                for (int i = 0; i < dgvPlanilla.Rows.Count; i++)
                {
                    contfila++;
                
                    if(dgvPlanilla["Estado", i].Value.ToString() == "0")
                    {
                        dgvPlanilla["Haber Basico", contfilasuc].Value = string.Format("{0:#,##0.00}", suchaberbasic);
                        dgvPlanilla["Haber Ganado", contfilasuc].Value = string.Format("{0:#,##0.00}", suchaberganado);
                        dgvPlanilla["Bono Antiguedad", contfilasuc].Value = string.Format("{0:#,##0.00}", sucbonoantig);
                        dgvPlanilla["Bono H. Ext.", contfilasuc].Value = string.Format("{0:#,##0.00}", sucbonohrext);
                        dgvPlanilla["Comision S/Ventas", contfilasuc].Value = string.Format("{0:#,##0.00}", succomiventas);
                        dgvPlanilla["Incremento", contfilasuc].Value = string.Format("{0:#,##0.00}", sucincremento);
                        dgvPlanilla["Otros Bonos", contfilasuc].Value = string.Format("{0:#,##0.00}", sucotrosbonos);
                        dgvPlanilla["TOTAL Ganado", contfilasuc].Value = string.Format("{0:#,##0.00}", suctotganado);
                        dgvPlanilla["Anticipo Sueldo", contfilasuc].Value = string.Format("{0:#,##0.00}", sucanticipsueld);
                        dgvPlanilla["Anticipo Almuerzo", contfilasuc].Value = string.Format("{0:#,##0.00}", sucanticipalmuer);
                        dgvPlanilla["Prestamos", contfilasuc].Value = string.Format("{0:#,##0.00}", sucprestamos);
                        dgvPlanilla["Celular Corpo.", contfilasuc].Value = string.Format("{0:#,##0.00}", succelcorpo);
                        dgvPlanilla["DSCTOS. Falt. Inv.", contfilasuc].Value = string.Format("{0:#,##0.00}", sucdsctofaltinv);
                        dgvPlanilla["Multas y Sanciones", contfilasuc].Value = string.Format("{0:#,##0.00}", sucmultasancion);
                        dgvPlanilla["TOTAL Dscto.", contfilasuc].Value = string.Format("{0:#,##0.00}", suctotdscto);
                        dgvPlanilla["LIQUIDO PAGABLE", contfilasuc].Value = string.Format("{0:#,##0.00}", sucliqpagable);

                        tothaberbasic += suchaberbasic;
                        tothaberganado += suchaberganado;
                        totbonoantig += sucbonoantig;
                        totbonohrext += sucbonohrext;
                        totcomiventas += succomiventas;
                        totincremento += sucincremento;
                        tototrosbonos += sucotrosbonos;
                        tottotganado += suctotganado;
                        totanticipsueld += sucanticipsueld;
                        totanticipalmuer += sucanticipalmuer;
                        totprestamos += sucprestamos;
                        totcelcorpo += succelcorpo;
                        totdsctofaltinv += sucdsctofaltinv;
                        tottotdscto += suctotdscto;
                        totmultasancion += sucmultasancion;
                        totliqpagable += sucliqpagable;

                        //variables de sucursal lo volvemos a cero
                        suchaberbasic = 0;
                        suchaberganado = 0;
                        sucbonoantig = 0;
                        sucbonohrext = 0;
                        succomiventas = 0;
                        sucincremento = 0;
                        sucotrosbonos = 0;
                        suctotganado = 0;
                        sucanticipsueld = 0;
                        sucanticipalmuer = 0;
                        sucprestamos = 0;
                        succelcorpo = 0;
                        sucdsctofaltinv = 0;
                        sucmultasancion = 0;
                        suctotdscto = 0;
                        sucliqpagable = 0;

                        //obtenemos la fila de la sucursal
                        contfilasuc = contfila;
                    }
                    else
                    {
                        suchaberbasic += Convert.ToDecimal(dgvPlanilla["Haber Basico", i].Value);
                        suchaberganado += Convert.ToDecimal(dgvPlanilla["Haber Ganado", i].Value);
                        sucbonoantig += Convert.ToDecimal(dgvPlanilla["Bono Antiguedad", i].Value);
                        sucbonohrext += Convert.ToDecimal(dgvPlanilla["Bono H. Ext.", i].Value);
                        succomiventas += Convert.ToDecimal(dgvPlanilla["Comision S/Ventas", i].Value);
                        sucincremento += Convert.ToDecimal(dgvPlanilla["Incremento", i].Value);
                        sucotrosbonos += Convert.ToDecimal(dgvPlanilla["Otros Bonos", i].Value);
                        suctotganado += Convert.ToDecimal(dgvPlanilla["TOTAL Ganado", i].Value);
                        sucanticipsueld += Convert.ToDecimal(dgvPlanilla["Anticipo Sueldo", i].Value);
                        sucanticipalmuer += Convert.ToDecimal(dgvPlanilla["Anticipo Almuerzo", i].Value);
                        sucprestamos += Convert.ToDecimal(dgvPlanilla["Prestamos", i].Value);
                        succelcorpo += Convert.ToDecimal(dgvPlanilla["Celular Corpo.", i].Value);
                        sucdsctofaltinv += Convert.ToDecimal(dgvPlanilla["DSCTOS. Falt. Inv.", i].Value);
                        sucmultasancion += Convert.ToDecimal(dgvPlanilla["Multas y Sanciones", i].Value);
                        suctotdscto += Convert.ToDecimal(dgvPlanilla["TOTAL Dscto.", i].Value);
                        sucliqpagable += Convert.ToDecimal(dgvPlanilla["LIQUIDO PAGABLE", i].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvPlanilla["Haber Basico", contfila].Value = string.Format("{0:#,##0.00}", tothaberbasic);
                dgvPlanilla["Haber Ganado", contfila].Value = string.Format("{0:#,##0.00}", tothaberganado);
                dgvPlanilla["Bono Antiguedad", contfila].Value = string.Format("{0:#,##0.00}", totbonoantig);
                dgvPlanilla["Bono H. Ext.", contfila].Value = string.Format("{0:#,##0.00}", totbonohrext);
                dgvPlanilla["Comision S/Ventas", contfila].Value = string.Format("{0:#,##0.00}", totcomiventas);
                dgvPlanilla["Incremento", contfila].Value = string.Format("{0:#,##0.00}", totincremento);
                dgvPlanilla["Otros Bonos", contfila].Value = string.Format("{0:#,##0.00}", tototrosbonos);
                dgvPlanilla["TOTAL Ganado", contfila].Value = string.Format("{0:#,##0.00}", tottotganado);
                dgvPlanilla["Anticipo Sueldo", contfila].Value = string.Format("{0:#,##0.00}", totanticipsueld);
                dgvPlanilla["Anticipo Almuerzo", contfila].Value = string.Format("{0:#,##0.00}", totanticipalmuer);
                dgvPlanilla["Prestamos", contfila].Value = string.Format("{0:#,##0.00}", totprestamos);
                dgvPlanilla["Celular Corpo.", contfila].Value = string.Format("{0:#,##0.00}", totcelcorpo);
                dgvPlanilla["DSCTOS. Falt. Inv.", contfila].Value = string.Format("{0:#,##0.00}", totdsctofaltinv);
                dgvPlanilla["Multas y Sanciones", contfila].Value = string.Format("{0:#,##0.00}", totmultasancion);
                dgvPlanilla["TOTAL Dscto.", contfila].Value = string.Format("{0:#,##0.00}", tottotdscto);
                dgvPlanilla["LIQUIDO PAGABLE", contfila].Value = string.Format("{0:#,##0.00}", totliqpagable);

                txtLiquidoPag.Text = string.Format("{0:#,##0.00}", totliqpagable);
            }
        }

        private void VerBoletasPago(int fila)
        {
            if(dgvPlanilla["Estado", fila].Value.ToString() == "1")
            {
                int vmes = 1;
                for (int i = 0; i < 12; i++)
                {
                    if (meses[i] == cboMesPla.Text)
                    {
                        vmes = i + 1;
                        break;
                    }
                }

                BoletasPagoPlanilla bol = new BoletasPagoPlanilla(DPla, vmes, Convert.ToInt32(cboGestionPla.Text), cboMesPla.Text, Opcion);
                bol.Owner = this;
                bol.ShowDialog();
            }
        }

        private void ElimFila(int fila)
        {
            if(dgvPlanilla.Rows.Count > 1)
            {
                string nro = dgvPlanilla["N°", fila].Value.ToString();
                string nomper = dgvPlanilla["Nombre y Apellidos", fila].Value.ToString();

                if(nro != string.Empty)
                {
                    DialogResult dialogo = MessageBox.Show("¿Seguro que desea quitar de la planilla al Personal " + nomper + "?", "Eliminar", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if(dialogo == DialogResult.Yes)
                    {

                    }
                }
            }
        }

        private void AgregarFila()
        {
            
        }

        private void AgregarListaDetPlanilla()
        {
            try
            {
                LDPla = new List<ODetallePlanillaSueldo>();

                for (int i = 0; i < dgvPlanilla.Rows.Count; i++)
                {
                    ODetallePlanillaSueldo dpla = new ODetallePlanillaSueldo();
                    dpla.PersonalID = Convert.ToInt32(dgvPlanilla["PersonalID", i].Value);
                    dpla.SucursalID = Convert.ToInt32(dgvPlanilla["SucursalID", i].Value);
                    dpla.NumOrden = i;
                    dpla.Nro = dgvPlanilla["N°", i].Value.ToString();
                    dpla.Cargo = dgvPlanilla["Cargo", i].Value.ToString();
                    dpla.HaberBasico = Convert.ToDecimal(dgvPlanilla["Haber Basico", i].Value.ToString());
                    dpla.FecIng = Convert.ToDateTime(dgvPlanilla["Fec. Ingreso", i].Value.ToString());
                    dpla.NomPer = dgvPlanilla["Nombre y Apellidos", i].Value.ToString();
                    dpla.CI = dgvPlanilla["CI", i].Value.ToString();
                    dpla.DiasTrabaj = Convert.ToDecimal(dgvPlanilla["Dias Trabaj.", i].Value.ToString());
                    dpla.HaberGanado = Convert.ToDecimal(dgvPlanilla["Haber Ganado", i].Value.ToString());
                    dpla.BonoAntig = Convert.ToDecimal(dgvPlanilla["Bono Antiguedad", i].Value.ToString());
                    dpla.BonoHrExtr = Convert.ToDecimal(dgvPlanilla["Bono H. Ext.", i].Value.ToString());
                    dpla.ComisionSVentas = Convert.ToDecimal(dgvPlanilla["Comision S/Ventas", i].Value.ToString());
                    dpla.Incremento = Convert.ToDecimal(dgvPlanilla["Incremento", i].Value.ToString());
                    dpla.OtrosBonos = Convert.ToDecimal(dgvPlanilla["Otros Bonos", i].Value.ToString());
                    dpla.TotalGanado = Convert.ToDecimal(dgvPlanilla["TOTAL Ganado", i].Value.ToString());
                    dpla.Estado = Convert.ToBoolean(dgvPlanilla["Estado", i].Value.ToString());
                }
            }
            catch (Exception)
            {    }
        }

        #endregion

        #region Eventos formulario

        private void PlanillaSueldo_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            CargarMeses();
            cboGestionPla.Text = DateTime.Now.Year.ToString();
            cboMesPla.Text = meses[DateTime.Now.Month - 1];
            cboMesPla.ValueMember = DateTime.Now.Month.ToString();
            HabilitarCont();

            ListarPlanillaSueldo();

            op.CerrarCargando();
        }

        private void PlanillaSueldo_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Procesando.....");

            ListarSucursal();
            ListarPersonal();
            
            Procesar();

            cboGestionPla.Enabled = false;
            cboMesPla.Enabled = false;
            btnCancel.Enabled = true;
            btnProcesar.Enabled = false;

            op.CerrarCargando();
        }

        private void dgvPlanilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VerBoletasPago(e.RowIndex);
        }

        private void btnImpBoleta_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Procesando....");

            CargarListaDPlanilla(false);

            if(LDPla != null)
            {
                string fecha = "Correspondiente al Mes de " + cboMesPla.Text + " de " + cboGestionPla.Text;

                Reportes.RepBoletaPago bolpag = new Reportes.RepBoletaPago(LDPla, fecha.ToUpper());
                bolpag.Show();
            }

            op.CerrarCargando();
        }

        private void btnBoletaPag_Click(object sender, EventArgs e)
        {
            if(dgvPlanilla.Rows.Count > 1)
                VerBoletasPago(dgvPlanilla.CurrentRow.Index);
        }

        private void btnElimFila_Click(object sender, EventArgs e)
        {
            try
            {
                ElimFila(dgvPlanilla.CurrentRow.Index);
            }
            catch (Exception)
            {            }
        }

        private void btnAgrFila_Click(object sender, EventArgs e)
        {
            AgregarFila();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Opcion = "Nuevo";
            BorrarCampos();
            DesabilitarCont();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Opcion = "Modificar";
            DesabilitarCont();

            btnCancel.Enabled = true;
            btnProcesar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifPlanillaSueldo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            if(CodPlanilla != string.Empty)
            {
                try
                {
                    op.AbrirCargando("Procesando....");

                    CargarListaDPlanilla(true);

                    Reportes.RepPlanillaSueldo rpla = new Reportes.RepPlanillaSueldo(Convert.ToDecimal(txtLiquidoPag.Text), cboMesPla.Text + " de " + cboGestionPla.Text, LDPla);
                    rpla.Show();
                }
                catch (Exception)
                {     }
                finally
                {
                    op.CerrarCargando();
                }
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarPersonal();
            ListarPlanillaSueldo();

            op.CerrarCargando();
        }

        private void dgvPlanilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarDPlanilla(e);
        }

        private void dtFechaPla_ValueChanged(object sender, EventArgs e)
        {
            ListarPlanillaSueldo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelarPlanilla();
        }

        #endregion
    }
}

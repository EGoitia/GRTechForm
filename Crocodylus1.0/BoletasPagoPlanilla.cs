using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Globalization;

using Objetos;
using Negocio;
using System.Xml.Serialization;

namespace GRTechnology1._0
{
    public partial class BoletasPagoPlanilla : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OAsistencia> LAsis = null;
        List<ODetalleAsistencia> LDAsis = null;
        List<OConformidad> LConf = null;
        List<OSucursal> LSuc = null;
        List<ODetalleProyecciones> LDProy = null;

        ODetallePlanillaSueldo DPla = null;

        string NomMes = string.Empty;
        string Opc = string.Empty;
        
        int Anio = 2012;
        int Mes = 1;

        DateTime FecIni = DateTime.Now;
        DateTime FecFin = DateTime.Now;


        public BoletasPagoPlanilla(ODetallePlanillaSueldo dpla, int mes, int anio, string nommes, string opc)
        {
            InitializeComponent();

            DPla = dpla;
            Mes = mes;
            Opc = opc;
            Anio = anio;
            NomMes = nommes;

            FecIni = new DateTime(anio, mes, 1);
            FecFin = new DateTime(anio, mes, 1).AddMonths(1).AddDays(-1);
        }

        #region Configuracion Formulario

        private void NombreColumnasDetAsistencia()
        {
            dgvAsistencia.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Dia";
            c1.Width = 60;
            dgvAsistencia.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Fecha";
            c2.Width = 90;
            dgvAsistencia.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Horario";
            c3.Width = 100;
            dgvAsistencia.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Hr. Entrada";
            c4.Width = 70;
            dgvAsistencia.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Hr. Salida";
            c5.Width = 70;
            dgvAsistencia.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Marc. Entrada";
            c6.Width = 70;
            dgvAsistencia.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Marc. Salida";
            c7.Width = 70;
            dgvAsistencia.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Tardanza";
            c8.Width = 70;
            dgvAsistencia.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "Salio Temp.";
            c9.Width = 70;
            dgvAsistencia.Columns.Add(c9);

            DataGridViewTextBoxColumn c10 = new DataGridViewTextBoxColumn();
            c10.Name = "Hr. Extra";
            c10.Width = 70;
            dgvAsistencia.Columns.Add(c10);

            DataGridViewTextBoxColumn c11 = new DataGridViewTextBoxColumn();
            c11.Name = "Hr. Permiso";
            c11.Width = 70;
            dgvAsistencia.Columns.Add(c11);

            DataGridViewTextBoxColumn c12 = new DataGridViewTextBoxColumn();
            c12.Name = "Hr. Falta";
            c12.Width = 70;
            dgvAsistencia.Columns.Add(c12);

            DataGridViewCheckBoxColumn c13 = new DataGridViewCheckBoxColumn();
            c13.Name = "Vacacion";
            c13.Width = 70;
            dgvAsistencia.Columns.Add(c13);

            DataGridViewCheckBoxColumn c14 = new DataGridViewCheckBoxColumn();
            c14.Name = "Falta";
            c14.Width = 60;
            dgvAsistencia.Columns.Add(c14);

            DataGridViewCheckBoxColumn c15 = new DataGridViewCheckBoxColumn();
            c15.Name = "Feriado";
            c15.Width = 60;
            dgvAsistencia.Columns.Add(c15);

            DataGridViewTextBoxColumn c16 = new DataGridViewTextBoxColumn();
            c16.Name = "Detalle";
            c16.Width = 200;
            dgvAsistencia.Columns.Add(c16);
        }

        private void NombreColumnasAnticipos()
        {
            dgvAnticip.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "CodGastoPer";
            c0.Visible = false;
            dgvAnticip.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Sucursal";
            c1.Width = 100;
            dgvAnticip.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Opcion";
            c2.Width = 100;
            dgvAnticip.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Nro. Nota";
            c3.Width = 90;
            dgvAnticip.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Concepto";
            c4.Width = 100;
            dgvAnticip.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Fecha";
            c5.Width = 100;
            dgvAnticip.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Debe";
            c6.Width = 90;
            dgvAnticip.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Haber";
            c7.Width = 90;
            dgvAnticip.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Saldo";
            c8.Width = 90;
            dgvAnticip.Columns.Add(c8);
        }

        private void NombreColumnasIngresos()
        {
            dgvIngresos.Columns.Clear();

            //columnas
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Detalle";
            c1.Width = 120;
            c1.ReadOnly = true;
            c1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvIngresos.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Total";
            c2.Width = 90;
            c2.SortMode = DataGridViewColumnSortMode.NotSortable;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngresos.Columns.Add(c2);

            //Filas Ingresos
            dgvIngresos.Rows.Add("Haber Ganado", "0.00");
            dgvIngresos.Rows.Add("Bono Antiguedad", "0.00");
            dgvIngresos.Rows.Add("Horas Extras", "0.00");
            dgvIngresos.Rows.Add("Comision s/Ventas", "0.00");
            dgvIngresos.Rows.Add("Incremento", "0.00");
            dgvIngresos.Rows.Add("Otros Bonos", "0.00");

            dgvIngresos.AllowUserToAddRows = false;
        }

        private void NombreColumnasEgresos()
        {
            dgvEgresos.Columns.Clear();

            //columnas
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Detalle";
            c1.Width = 120;
            c1.ReadOnly = true;
            c1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvEgresos.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Total";
            c2.Width = 90;
            c2.SortMode = DataGridViewColumnSortMode.NotSortable;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEgresos.Columns.Add(c2);

            //Filas Ingresos
            dgvEgresos.Rows.Add("Anticipo Sueldo", "0.00");
            dgvEgresos.Rows.Add("Anticipo Almuerzo", "0.00");
            dgvEgresos.Rows.Add("Prestamos", "0.00");
            dgvEgresos.Rows.Add("Corporativo", "0.00");
            dgvEgresos.Rows.Add("DSCTOS. Falt. Inv.", "0.00");
            dgvEgresos.Rows.Add("Multas y Sanciones", "0.00");

            dgvEgresos.AllowUserToAddRows = false;
        }

        private void NombreColumnasComchof()
        {
            dgvComChof.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "CodConf";
            c1.Visible = false;
            dgvComChof.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Num. Conf.";
            c2.Width = 60;
            dgvComChof.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 90;
            dgvComChof.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Sucursal";
            c4.Width = 100;
            dgvComChof.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Destino";
            c5.Width = 150;
            dgvComChof.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Valor";
            c6.Width = 60;
            dgvComChof.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Total Mtr.";
            c7.Width = 70;
            dgvComChof.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Total Bolsa";
            c8.Width = 70;
            dgvComChof.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "Total Pza.";
            c9.Width = 70;
            dgvComChof.Columns.Add(c9);
        }

        private void NombreColumnasProy()
        {
            dgvProy.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Dia";
            c1.Width = 60;
            c1.ReadOnly = true;
            c1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Valor Dia";
            c2.Width = 70;
            c2.ReadOnly = true;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            c2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 90;
            c3.ReadOnly = true;
            c3.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Real Acumulado";
            c4.Width = 80;
            c4.ReadOnly = true;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c4.DefaultCellStyle.BackColor = System.Drawing.Color.OliveDrab;
            c4.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "%";
            c5.Width = 80;
            c5.ReadOnly = true;
            c5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c5.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c5);

            DataGridViewCheckBoxColumn c6 = new DataGridViewCheckBoxColumn();
            c6.Name = "Estado";
            c6.Width = 50;
            c6.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Contra";
            c7.Width = 80;
            c7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c7.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Favor";
            c8.Width = 80;
            c8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c8.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "Detalle";
            c9.Width = 150;
            c9.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProy.Columns.Add(c9);
        }

        private void NombreColumnasProyVend()
        {
            dgvProyVend.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Fecha";
            c1.Width = 90;
            c1.ReadOnly = true;
            c1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProyVend.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Acumulado";
            c2.Width = 80;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProyVend.Columns.Add(c2);

            //Cargamos los dias
            DateTime d1 = FecIni;
            DateTime d2 = FecFin;
            TimeSpan ts = d2 - d1;
            DateTime d = DateTime.MinValue + ts;

            for (int i = 0; i < d.Day; i++)
            {
                dgvProyVend.Rows.Add(d1.ToShortDateString(), "0.00");
                d1 = d1.AddDays(1);
            }
        }

        private void HabilitarCont()
        {
            if (Opc == string.Empty)
                gbxBotones.Enabled = false;
            else
                gbxBotones.Enabled = true;       
        }

        #endregion

        #region Conexion Capa Negocios

        private void ListarAsistencia()
        {
            try
            {
                LAsis = NAsistencia.NListarAsistencia(Convert.ToInt32(txtPersonalID.Text), Mes, Anio);
                CargarAsistencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarKardexGastoPer()
        {
            try
            {
                //LKarPer = NKardexPer.NListarKardexPer(Convert.ToInt32(txtPersonalID.Text), FecIni, FecFin);
                CargarKadexPer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                NombreColumnasAnticipos();
            }
        }

        private void ListarSucursal()
        {
            try
            {
                LSuc = NSucursal.NListarSucursales().OrderBy(x => x.NomSuc).ToList();
                cboCaja.DataSource = LSuc;
                cboCaja.DisplayMember = "NomSuc";
                cboCaja.ValueMember = "SucursalID";
                cboCaja.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarComChof()
        {
            try
            {
                op.AbrirCargando("Procesando....");

                LConf = NConformidad.NBuscarConfXChofer(Convert.ToInt32(txtPersonalID.Text), -1, FecIni, FecFin);
                CargarConfChofer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnasComchof();
            }
            finally
            {
                if (dgvComChof.Rows.Count > 1)
                    dgvComChof.Rows[dgvComChof.Rows.Count - 2].Cells[3].Selected = true;

                op.CerrarCargando();
            }
        }

        private void ListarComision()
        {
            try
            {
                OComision com = NComision.NListarComision(Convert.ToInt32(txtPersonalID.Text));

                if(com != null)
                {
                    //Comision del chofer
                    txtComMtr.Text = string.Format("{0:#,##0.00}", com.TotMetros);
                    txtComBolsa.Text = string.Format("{0:#,##0.00}", com.TotBolsas);
                    txtComPza.Text = string.Format("{0:#,##0.00}", com.TotPiezas);

                    //Comision del vendedor
                    txtValComVend.Text = string.Format("{0:#,##0.00}", com.TotVentas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                BorrarCampos(gbxValCom, "0.00");
                BorrarCampos(gbxTotComisionado, "0.00");
            }
        }

        private void ListarProyeccion()
        {
            try
            {
                int sucid = -1;
                int perid = -1;
                if(ckbxProyVend.Checked)
                {
                    sucid = -1;
                    perid= Convert.ToInt32(txtPersonalID.Text);
                }
                else
                {
                    sucid=Convert.ToInt32(cboCaja.SelectedValue);
                    perid=-1;
                }

                LDProy = NDetalleProyeccion.NBuscarDProy(-1, sucid, perid, FecIni, FecFin);
                CargarDetalleProyeccion();
            }
            catch (Exception ex)
            {
                NombreColumnasProy();
            }
        }

        private void InsertModifValConf()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.TipoInmode = "Valor Conformidad";
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();
                
                //Serializamos el valor de conformidad
                string DValConf = string.Empty;
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(List<OValorConformidad>));

                //Cargamos el Objeto
                List<OValorConformidad> lvalconf = new List<OValorConformidad>();
                for (int i = 0; i < dgvComChof.Rows.Count - 3; i++)
                {
                    OValorConformidad vconf = new OValorConformidad();

                    vconf.CodConformidad = dgvComChof["CodConf", i].Value.ToString();
                    vconf.ComxBolsa = Convert.ToDecimal(txtComBolsa.Text);
                    vconf.ComxMetro = Convert.ToDecimal(txtComMtr.Text);
                    vconf.ComxPza = Convert.ToDecimal(txtComPza.Text);

                    lvalconf.Add(vconf);
                }
                serializer.Serialize(stringwriter, lvalconf);
                DValConf = stringwriter.ToString();
                DValConf = DValConf.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");

                int result = NConformidad.NInsertModifValorConformidad(DValConf, inm);
                if (result > 0)
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarDetAsistencia(string cod)
        {
            try
            {
                NombreColumnasDetAsistencia();

                string nomdia = string.Empty;
                CultureInfo ci = new CultureInfo("Es-Es");

                LDAsis = NDetalleAsistencia.NBuscarDAsis(cod);

                foreach (var item in LDAsis)
                {
                    nomdia = ci.DateTimeFormat.GetDayName(item.Fecha.DayOfWeek).ToUpper();

                    dgvAsistencia.Rows.Add(nomdia.Substring(0, 3), item.Fecha.ToShortDateString(), item.Horario, item.HrEntrada.ToShortTimeString(),
                                           item.HrSalida.ToShortTimeString(), item.MarcEntrada.ToShortTimeString(), item.MarcSalida.ToShortTimeString(),
                                           string.Format("{0:##,#0.00}", item.Tardanza), string.Format("{0:##,#0.00}", item.SalioTemp), 
                                           string.Format("{0:##,#0.00}", item.HrsExtras), string.Format("{0:##,#0.00}", item.HrsPermiso), 
                                           string.Format("{0:##,#0.00}", item.HrsFalta), string.Format("{0:##,#0.00}", item.Vacacion), 
                                           string.Format("{0:##,#0.00}", item.Falta), item.Feriado, item.Detalle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnasDetAsistencia();
            }
        }

        #endregion

        #region CargarDatos

        private void CargarAsistencia()
        {
            if(LAsis != null)
            {
                foreach (var item in LAsis)
                {
                    //Horas
                    txtHrAtrasos.Text = string.Format("{0:#,##0.00}", item.TotHrsTarde);
                    txtHrTempra.Text = string.Format("{0:#,##0.00}", item.TotHrsTemprano);
                    txtHrPermi.Text = string.Format("{0:#,##0.00}", item.TotHrsPermiso);
                    txtHrFalta.Text = string.Format("{0:#,##0.00}", item.TotHrsFalta);
                    txtHrExtras.Text = string.Format("{0:#,##0.00}", item.TotHrsExtras);
                    //dias
                    txtDiaAtrasos.Text = item.TotDiasTarde.ToString();
                    txtDiaTempra.Text = item.TotDiasTemprano.ToString();
                    txtDiaPermi.Text = item.TotDiasPermiso.ToString();
                    txtDiaFalta.Text = item.TotDiasFalta.ToString();
                    txtDiaExtras.Text = item.TotDiasExtras.ToString();
                    txtDiaVacacion.Text = item.TotDiasVacacion.ToString();
                    
                    //total dias trabajados
                    txtTotDiasTrab.Text = (30 - (item.TotDiasTarde + item.TotDiasTemprano + item.TotDiasFalta + item.TotDiasPermiso)).ToString();
                    numUpDownDiasTrab.Value = (30 - (item.TotDiasTarde + item.TotDiasTemprano + item.TotDiasFalta + item.TotDiasPermiso));
                    
                    //buscar detalle asistencia
                    BuscarDetAsistencia(item.CodAsistencia);
                }
            }
            else
            {
                NombreColumnasDetAsistencia();
            }
        }

        private void CargarDetallePlanilla()
        {
            if(DPla !=null)
            {
                txtPersonalID.Text = DPla.PersonalID.ToString();
                txtNombre.Text = DPla.NomPer;
                txtCI.Text = DPla.CI;
                dtFecIng.Value = DPla.FecIng;
                txtMes.Text = NomMes;
                txtAnio.Text = Anio.ToString();

                numUpDownSueldoBasic.Value = DPla.HaberBasico;
                numUpDownDiasTrab.Value = DPla.DiasTrabaj;

                //Ingresos
                dgvIngresos["Total", 0].Value = string.Format("{0:#,##0.00}", DPla.HaberGanado); //haber ganado
                dgvIngresos["Total", 1].Value = string.Format("{0:#,##0.00}", DPla.BonoAntig); //bono anti
                dgvIngresos["Total", 2].Value = string.Format("{0:#,##0.00}", DPla.BonoHrExtr); //hr extras
                dgvIngresos["Total", 3].Value = string.Format("{0:#,##0.00}", DPla.ComisionSVentas); //comisiones
                dgvIngresos["Total", 4].Value = string.Format("{0:#,##0.00}", DPla.Incremento); //otros ingr
                dgvIngresos["Total", 5].Value = string.Format("{0:#,##0.00}", DPla.OtrosBonos); //otros ingr
                txtTotIng.Text = string.Format("{0:#,##0.00}", DPla.TotalGanado);
 
                //Egresos
                dgvEgresos["Total", 0].Value = string.Format("{0:#,##0.00}", DPla.AnticipSueldo); //Anticipo Sueldo
                dgvEgresos["Total", 1].Value = string.Format("{0:#,##0.00}", DPla.AnticipAlmuerzo); //Anticipo Almuerzo
                dgvEgresos["Total", 2].Value = string.Format("{0:#,##0.00}", DPla.Prestamos); //Prestamos
                dgvEgresos["Total", 3].Value = string.Format("{0:#,##0.00}", DPla.CelCorpo); //Corporativo
                dgvEgresos["Total", 4].Value = string.Format("{0:#,##0.00}", DPla.DsctoFaltInv); //Faltante de inv.
                dgvEgresos["Total", 5].Value = string.Format("{0:#,##0.00}", DPla.MultasSanciones); //Multas y Sanciones
                //dgvEgresos["Total", 6].Value = string.Format("{0:#,##0.00}", DPla.OtrosDscto); //Otros Dscto
                txtTotEgr.Text = string.Format("{0:#,##0.00}", DPla.TotalDscto);

                //liquido pagable
                txtLiquidoPag.Text = string.Format("{0:#,##0.00}", DPla.LiquidoPagable);
            }
        }

        private void CargarDetalleProyeccion()
        {
            if (LDProy != null)
            {
                NombreColumnasProy();

                int cont = 0;
                foreach (var item in LDProy)
                {
                    dgvProy.Rows.Add(item.Dia, item.ValorDia, item.Fecha, string.Format("{0:#,##0.00}", item.RealAcumulado), 
                                     string.Format("{0:#,##0.00}", item.Porcentaje), item.Estado, string.Format("{0:#,##0.00}", item.Contra), 
                                     string.Format("{0:#,##0.00}", item.Favor), item.Detalle);

                    if(!item.Estado)
                        dgvProy.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Silver;

                    cont++;
                }
            }
            else
                NombreColumnasProy();
        }

        private void CargarConfChofer()
        {
            if(LConf != null)
            {
                NombreColumnasComchof();

                decimal totmtr = 0;
                decimal totbolsa = 0;
                decimal totpza = 0;
                decimal totBs = 0;

                foreach (var item in LConf)
                {
                    dgvComChof.Rows.Add(item.CodConformidad, item.NumConform, item.Fecha, item.NomSuc, item.NomContTransporte, item.Valor,
                                        string.Format("{0:#,##0.00}", item.Totalm2), string.Format("{0:#,##0.00}", item.TotalBolsa),
                                        string.Format("{0:#,##0.00}", item.TotalPzas));

                    totmtr += item.Valor * item.Totalm2;
                    totbolsa += item.Valor * item.TotalBolsa;
                    totpza += item.Valor * item.TotalPzas;
                }
                
                //Totales Cantidades
                dgvComChof.Rows.Add("", "", "", "", "", "TOT. CANT.", string.Format("{0:#,##0.00}", totmtr), string.Format("{0:#,##0.00}", totbolsa),
                                    string.Format("{0:#,##0.00}", totpza));

                //Totales Montos
                dgvComChof.Rows.Add("", "", "", "", "", "TOT. Bs.-", string.Format("{0:#,##0.00}", totmtr * Convert.ToDecimal(txtComMtr.Text)),
                                    string.Format("{0:#,##0.00}", totbolsa * Convert.ToDecimal(txtComBolsa.Text)),
                                    string.Format("{0:#,##0.00}", totpza * Convert.ToDecimal(txtComPza.Text)));

                dgvComChof.Refresh();

                //Calculamos el Total en Bs
                totBs = (totmtr * Convert.ToDecimal(txtComMtr.Text));
                totBs += (totbolsa * Convert.ToDecimal(txtComBolsa.Text));
                totBs += (totpza * Convert.ToDecimal(txtComPza.Text));

                txtTotComChof.Text = string.Format("{0:#,##0.00}", totBs);
            }
            else
            {
                NombreColumnasComchof();
            }
        }

        private void CargarKadexPer()
        {
           
        }
        
        #endregion

        #region Funciones

        private void BorrarCampos(GroupBox gbx, string param)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, param);
        }

        private void AgregarComChofer()
        {
            DialogResult dialogo = MessageBox.Show("¿Desea Agregar estos Valores de Comision a la las Notas de Conformidad?", "Conformidad",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
                InsertModifValConf();

            dgvIngresos["Total", 3].Value = string.Format("{0:#,##0.00}", txtTotComChof.Text); //haber ganado
            ProcesarIngresos();
            tabControlPlaSueld.SelectedIndex = 0;
        }

        private void AgregarComVend()
        {
            //DialogResult dialogo = MessageBox.Show("¿Desea Agregar estos Valores de Comision a este Vendedor?", "Conformidad",
            //                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogo == DialogResult.Yes)
                //InsertModifValConf();

            dgvIngresos["Total", 3].Value = string.Format("{0:#,##0.00}", txtTotComVend.Text); //haber ganado
            ProcesarIngresos();
            tabControlPlaSueld.SelectedIndex = 0;
        }

        private void AgregarAntPresBonoPer()
        {
            dgvEgresos["Total", 0].Value = txtAntSueldo.Text;
            dgvEgresos["Total", 1].Value = txtAntAlm.Text;
            dgvEgresos["Total", 2].Value = txtPrest.Text;

            tabControlPlaSueld.SelectedIndex = 0;
        }

        private void ProcesarIngresos()
        {
            decimal toting = 0;
            try
            {
                for (int i = 0; i < dgvIngresos.Rows.Count; i++)
                {
                    toting += Convert.ToDecimal(dgvIngresos["Total", i].Value);    
                }
            }
            catch (Exception)
            {
                toting = 0;
            }
            finally
            {
                txtTotIng.Text = string.Format("{0:#,##0.00}", toting);
            }
        }

        private void ProcesarEgresos()
        {
            decimal totegr = 0;
            try
            {
                for (int i = 0; i < dgvEgresos.Rows.Count; i++)
                {
                    totegr += Convert.ToDecimal(dgvEgresos["Total", i].Value);
                }
            }
            catch (Exception)
            {
                totegr = 0;
            }
            finally
            {
                txtTotEgr.Text = string.Format("{0:#,##0.00}", totegr);
            }
        }

        private void ProcesarComVend()
        {
            decimal totcom = 0;
            try
            {
                for (int i = 0; i < dgvProyVend.Rows.Count - 1; i++)
                {
                    totcom += Convert.ToDecimal(dgvProyVend["Total", i].Value);
                }
            }
            catch (Exception)
            {
                totcom = 0;
            }
            finally
            {
                txtTotComVend.Text = string.Format("{0:#,##0.00}", totcom * Convert.ToDecimal(txtValComVend.Text));
            }
        }

        private void PasarTotalProyVend()
        {
            try
            {
                for (int i = 0; i < dgvProy.Rows.Count - 1; i++)
                {
                    dgvProyVend["Acumulado", i].Value = string.Format("{0:#,##0.00}", (Convert.ToDecimal(dgvProy["Real Acumulado", i].Value) + 
                                                                                       Convert.ToDecimal(dgvProy["Favor", i].Value) - 
                                                                                       Convert.ToDecimal(dgvProy["Contra", i].Value)));
                }
            }
            catch (Exception)
            {
 
            }
            finally
            {
                ProcesarComVend();
            }
        }

        private void PasarFilaProyVend()
        {
            try
            {
                string fecha = dgvProy["Fecha", dgvProy.CurrentRow.Index].Value.ToString();
                string monto = string.Format("{0:#,##0.00}", (Convert.ToDecimal(dgvProy["Real Acumulado", dgvProy.CurrentRow.Index].Value) +
                                                              Convert.ToDecimal(dgvProy["Favor", dgvProy.CurrentRow.Index].Value) -
                                                              Convert.ToDecimal(dgvProy["Contra", dgvProy.CurrentRow.Index].Value)));
                for (int i = 0; i < dgvProyVend.Rows.Count - 1; i++)
                {
                    if (dgvProyVend["Fecha", i].Value.ToString() == fecha) 
                    {
                        dgvProyVend["Acumulado", i].Value = monto;
                        break;
                    }  
                }
            }
            catch (Exception)
            {    
            }
            finally
            {
                ProcesarComVend();
            }
        }

        private void Exportar()
        {
            try
            {
                DPla.HaberBasico = numUpDownSueldoBasic.Value;
                DPla.DiasTrabaj = numUpDownDiasTrab.Value;
                //Ingresos
                DPla.HaberGanado = Convert.ToDecimal(dgvIngresos["Total", 0].Value);
                DPla.BonoAntig = Convert.ToDecimal(dgvIngresos["Total", 1].Value);
                DPla.BonoHrExtr = Convert.ToDecimal(dgvIngresos["Total", 2].Value);
                DPla.ComisionSVentas = Convert.ToDecimal(dgvIngresos["Total", 3].Value);
                DPla.Incremento = Convert.ToDecimal(dgvIngresos["Total", 4].Value);
                DPla.OtrosBonos = Convert.ToDecimal(dgvIngresos["Total", 5].Value);
                DPla.TotalGanado = Convert.ToDecimal(txtTotIng.Text);
                //Descuentos
                DPla.AnticipSueldo = Convert.ToDecimal(dgvEgresos["Total", 0].Value);
                DPla.AnticipAlmuerzo = Convert.ToDecimal(dgvEgresos["Total", 1].Value);
                DPla.Prestamos = Convert.ToDecimal(dgvEgresos["Total", 2].Value);
                DPla.CelCorpo = Convert.ToDecimal(dgvEgresos["Total", 3].Value);
                DPla.DsctoFaltInv = Convert.ToDecimal(dgvEgresos["Total", 4].Value);
                DPla.MultasSanciones = Convert.ToDecimal(dgvEgresos["Total", 5].Value);
                DPla.TotalDscto = Convert.ToDecimal(txtTotEgr.Text);
                //Liquido pagable
                DPla.LiquidoPagable = Convert.ToDecimal(txtLiquidoPag.Text);

                IAgregaDetPlanilla parent = this.Owner as IAgregaDetPlanilla;
                parent.AgregaDetPlanilla(DPla);

                this.Close();
            }
            catch (Exception)
            {  }
        }

        private void Imprimir()
        {

        }

        private void OpcionActualizar()
        {

        }

        private void SeleccionarVentana()
        {
            switch(tabControlPlaSueld.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    ListarAsistencia();
                    break;
                case 3:
                    if (LSuc == null)
                        ListarSucursal();
                    NombreColumnasProy();
                    NombreColumnasProyVend();
                    break;
                case 4:
                    if (LConf == null)
                        NombreColumnasComchof();
                    break;
            }
        }

        #endregion

        #region Eventos Formulario

        private void BoletasPagoPlanilla_Load(object sender, EventArgs e)
        {
            NombreColumnasIngresos();
            NombreColumnasEgresos();
            NombreColumnasAnticipos();

            CargarDetallePlanilla();

            HabilitarCont();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            OpcionActualizar();

            op.CerrarCargando();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {

        }

        private void btnAgre_Click(object sender, EventArgs e)
        {
            AgregarAntPresBonoPer();
        }

        private void btnAgrComVen_Click(object sender, EventArgs e)
        {
            AgregarComVend();
        }

        private void tabControlPlaSueld_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarVentana();
        }

        private void btnProcComChof_Click(object sender, EventArgs e)
        {
            ListarComision();
            ListarComChof();
        }

        private void btnAgrComChof_Click(object sender, EventArgs e)
        {
            AgregarComChofer();
        }

        private void btnProcComVen_Click(object sender, EventArgs e)
        {
            ListarComision();
            ListarProyeccion();
        }

        private void txtTotIng_TextChanged(object sender, EventArgs e)
        {
            txtLiquidoPag.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotIng.Text) - Convert.ToDecimal(txtTotEgr.Text));
        }

        private void txtTotEgr_TextChanged(object sender, EventArgs e)
        {
            txtLiquidoPag.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotIng.Text) - Convert.ToDecimal(txtTotEgr.Text));
        }

        private void dgvIngresos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProcesarIngresos();
        }

        private void dgvEgresos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProcesarEgresos();
        }

        private void dgvProyVend_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProcesarComVend();
        }

        private void dgvProyVend_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void dgvIngresos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void dgvEgresos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void btnElimTotComVend_Click(object sender, EventArgs e)
        {
            NombreColumnasProyVend();
            ProcesarComVend();
        }

        private void btnAgrTotComVend_Click(object sender, EventArgs e)
        {
            PasarTotalProyVend();
        }

        private void btnAgrComVend_Click(object sender, EventArgs e)
        {
            PasarFilaProyVend();
        }

        private void btnElimComVend_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProyVend["Acumulado", dgvProyVend.CurrentRow.Index].Value = "0.00";
            }
            catch (Exception)
            {    }
            finally
            {
                ProcesarComVend();
            }
        }

        private void ckbxProyVend_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxProyVend.Checked)
                cboCaja.Enabled = false;
            else
                cboCaja.Enabled = true;
        }

        #endregion
    }
}

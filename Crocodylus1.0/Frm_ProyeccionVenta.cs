using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Xml.Serialization;
using System.Globalization;

using Objetos;
using Datos;
using System.Data;

namespace GRTechnology1._0
{
    public partial class Frm_ProyeccionVenta : Form, IAgregaValorProy
    {
        public static Frm_ProyeccionVenta frmproy = null;

        private string SucVend = string.Empty;
        private int dias = 1;
        
        private List<OFeriados> LFer = null;
        private List<OSucursal> LSuc = null;
        private List<OPersonal> LPer = null;
        
        #region IAgregaValorProy

        public void AgregaValorProy(DateTime fec, decimal monto)
        {
            for (int i = 0; i < dgvDetProyec.Rows.Count; i++)
            {
                if (dgvDetProyec["Fecha", i].Value.ToString() == fec.ToShortDateString())
                {
                    dgvDetProyec["Real Sucursal", i].Value = string.Format("{0:#,##0.00}", monto);
                    ProcesarProyeccion();
                    break;
                }
            }
        }

        #endregion

        public Frm_ProyeccionVenta()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnasProy()
        {
            dgvDetProyec.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Dia";
            c1.FillWeight = 60;
            c1.ReadOnly = true;
            c1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDetProyec.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Valor Dia";
            c2.FillWeight = 50;
            c2.ReadOnly = true;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            c2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDetProyec.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.FillWeight = 90;
            c3.ReadOnly = true;
            c3.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDetProyec.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Real Sucursal";
            c4.FillWeight = 80;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c4.DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
            c4.DefaultCellStyle.Format = "N2";
            c4.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDetProyec.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Real Acumulado";
            c5.FillWeight = 80;
            c5.ReadOnly = true;
            c5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c5.SortMode = DataGridViewColumnSortMode.NotSortable;
            c5.DefaultCellStyle.Format = "N2";
            dgvDetProyec.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Proyect. Diario";
            c6.FillWeight = 80;
            c6.ReadOnly = true;
            c6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c6.SortMode = DataGridViewColumnSortMode.NotSortable;
            c6.DefaultCellStyle.Format = "N2";
            dgvDetProyec.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Proyect. Acumulado";
            c7.FillWeight = 80;
            c7.ReadOnly = true;
            c7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c7.SortMode = DataGridViewColumnSortMode.NotSortable;
            c7.DefaultCellStyle.Format = "N2";
            dgvDetProyec.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Diferencia";
            c8.FillWeight = 80;
            c8.ReadOnly = true;
            c8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c8.SortMode = DataGridViewColumnSortMode.NotSortable;
            c8.DefaultCellStyle.Format = "N2";
            dgvDetProyec.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "%";
            c9.FillWeight = 80;
            c9.ReadOnly = true;
            c9.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c9.SortMode = DataGridViewColumnSortMode.NotSortable;
            c9.DefaultCellStyle.Format = "N2";
            dgvDetProyec.Columns.Add(c9);

            DataGridViewCheckBoxColumn c10 = new DataGridViewCheckBoxColumn();
            c10.Name = "Estado";
            c10.FillWeight = 50;
            c10.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDetProyec.Columns.Add(c10);

            DataGridViewTextBoxColumn c11 = new DataGridViewTextBoxColumn();
            c11.Name = "Contra";
            c11.FillWeight = 80;
            c11.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c11.SortMode = DataGridViewColumnSortMode.NotSortable;
            c11.DefaultCellStyle.Format = "N2";
            dgvDetProyec.Columns.Add(c11);

            DataGridViewTextBoxColumn c12 = new DataGridViewTextBoxColumn();
            c12.Name = "Favor";
            c12.FillWeight = 80;
            c12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c12.SortMode = DataGridViewColumnSortMode.NotSortable;
            c12.DefaultCellStyle.Format = "N2";
            dgvDetProyec.Columns.Add(c12);

            DataGridViewTextBoxColumn c13 = new DataGridViewTextBoxColumn();
            c13.Name = "Detalle";
            c13.FillWeight = 200;
            c13.SortMode = DataGridViewColumnSortMode.NotSortable;
            c12.MaxInputLength = 500;
            dgvDetProyec.Columns.Add(c13);
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarSucursal()
        {
            try
            {
                LSuc = DSucursal.DListarSucursales();
                CargarSucursal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarVendedor()
        {
            try
            {
                LPer = DPersonal.DListarPersonales("VentasTotal", -1);
                CargarVendedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarFeriados()
        {
            try
            {
                LFer = DFeriados.DBuscarFeriados(Convert.ToDateTime(dtFecIni.Text), dtFecFin.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarModifProy()
        {
            if (string.IsNullOrWhiteSpace(txtNomProy.Text))
            {
                txtNomProy.Focus();
                MessageBox.Show("INGRESE UN NOMBRE A LA PROYECCIÓN","NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                string DetalleInmode = string.Empty;
                OProyecciones proy = new OProyecciones();
                if (txtNumProy.Text != "-1")
                {
                    //Cargamos Detalle Modificado
                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("MODIFICAR");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();

                    if (!dmodanul.Cancelado)
                        DetalleInmode = dmodanul.DetaModAnul();
                    else
                    {
                        dmodanul.Dispose();
                        throw new Exception("CANCELADO POR EL USUARIO");
                    }
                    dmodanul.Dispose();
                }

                btnGuardar.Enabled = false;

                proy.ProyeccionID = Convert.ToInt32(txtNumProy.Text);
                proy.NomProyeccion = txtNomProy.Text.Trim();
                proy.SucursalID = (rbSucursal.Checked ? (int)cboOpcion.SelectedValue : -1);
                proy.VendedorID = (rbVendedor.Checked ? (int)cboOpcion.SelectedValue : -1);
                proy.FechaIni = dtFecIni.Value;
                proy.FechaFin = dtFecFin.Value;
                proy.DiasLaborales = decimal.Parse(txtTotDias.Text);
                proy.MontoProyectado = numUpDownProyectado.Value;
                proy.MontoEjecutado = decimal.Parse(txtTotEjec.Text);
                proy.PorcentAvance = decimal.Parse(txtTotPorcent.Text);
                proy.DetalleProyeccionDT = InsertDetProy();

                int resp = DProyecciones.DInsertModifProy(proy, OInmode.DTInmode("", "NUEVO", DetalleInmode));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Borrar();

                    if (txtNumProy.Visible)
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private DataTable InsertDetProy()
        {
            DataRow FilaDetalle;
            DataTable DetalleDT = new DataTable();
            DetalleDT.Columns.Add("ValorDia", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("RealSucursal", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("RealAcumulado", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("ProyectDiario", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("ProyectAcumulado", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("Diferencia", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("Porcentaje", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("EnContra", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("AFavor", Type.GetType("System.Double"));
            DetalleDT.Columns.Add("Estado", Type.GetType("System.Boolean"));
            DetalleDT.Columns.Add("Dia", Type.GetType("System.String"));
            DetalleDT.Columns.Add("Fecha", Type.GetType("System.String"));
            DetalleDT.Columns.Add("Detalle", Type.GetType("System.String"));
            DetalleDT.Columns.Add("Habil", Type.GetType("System.Boolean"));                       

            decimal valor;
            for (int i = 0; i < dgvDetProyec.Rows.Count; i++)
            {
                FilaDetalle = DetalleDT.NewRow();

                decimal.TryParse(dgvDetProyec["Valor Dia", i].Value.ToString(), out valor);
                FilaDetalle["ValorDia"] = valor;
                decimal.TryParse(dgvDetProyec["Real Sucursal", i].Value.ToString(), out valor);
                FilaDetalle["RealSucursal"] = valor;
                decimal.TryParse(dgvDetProyec["Real Acumulado", i].Value.ToString(), out valor);
                FilaDetalle["RealAcumulado"] = valor;
                decimal.TryParse(dgvDetProyec["Proyect. Diario", i].Value.ToString(), out valor);
                FilaDetalle["ProyectDiario"] = valor;
                decimal.TryParse(dgvDetProyec["Proyect. Acumulado", i].Value.ToString(), out valor);
                FilaDetalle["ProyectAcumulado"] = valor;
                decimal.TryParse(dgvDetProyec["Diferencia", i].Value.ToString(), out valor);
                FilaDetalle["Diferencia"] = valor;
                decimal.TryParse(dgvDetProyec["%", i].Value.ToString(), out valor);
                FilaDetalle["Porcentaje"] = valor;
                decimal.TryParse(dgvDetProyec["Contra", i].Value.ToString(), out valor);
                FilaDetalle["EnContra"] = valor;
                decimal.TryParse(dgvDetProyec["Favor", i].Value.ToString(), out valor);
                FilaDetalle["AFavor"] = valor;
                FilaDetalle["Estado"] = Convert.ToBoolean(dgvDetProyec["Estado", i].Value);
                FilaDetalle["Dia"] = dgvDetProyec["Dia", i].Value.ToString();
                FilaDetalle["Fecha"] = dgvDetProyec["Fecha", i].Value.ToString();
                FilaDetalle["Detalle"] = dgvDetProyec["Detalle", i].Value.ToString();
                FilaDetalle["Habil"] = true;
                
                DetalleDT.Rows.Add(FilaDetalle);
            }

            return DetalleDT;
        }
        
        private void ListarProyeccion()
        {
            try
            {
                label1.Visible = true;
                txtNumProy.Visible = true;

                DataSet ProyDS = DListarPersonalizado.ConsultarDS("SELECT ProyeccionID, SucursalID, VendedorID, NomProyeccion, Proyectado, " +
                    "DiasLaborales, Ejecutado, PorcentAvance, FecIni, FecFin FROM Proyecciones; SELECT * FROM Detalle_Proyecciones WHERE Habil=1");

                if (ProyDS.Tables[0].Rows.Count > 0)
                {
                    txtNomProy.Text = ProyDS.Tables[0].Rows[0]["NomProyeccion"].ToString();
                    numUpDownProyectado.Value = Convert.ToDecimal(ProyDS.Tables[0].Rows[0]["Proyectado"]);
                    dtFecIni.Value = Convert.ToDateTime(ProyDS.Tables[0].Rows[0]["FecIni"]);
                    dtFecFin.Value = Convert.ToDateTime(ProyDS.Tables[0].Rows[0]["FecFin"]);

                    if (Convert.ToInt32(ProyDS.Tables[0].Rows[0]["SucursalID"]) == -1)
                    {
                        rbVendedor.Checked = true;
                        cboOpcion.SelectedValue = Convert.ToInt32(ProyDS.Tables[0].Rows[0]["VendedorID"]);
                    }
                    else
                    {
                        rbSucursal.Checked = true;
                        cboOpcion.SelectedValue = Convert.ToInt32(ProyDS.Tables[0].Rows[0]["SucursalID"]);
                    }

                    txtTotDias.Text = ProyDS.Tables[0].Rows[0]["DiasLaborales"].ToString();
                    txtTotEjec.Text = ProyDS.Tables[0].Rows[0]["Ejecutado"].ToString();
                }
                else
                    throw new Exception("NO SE ENCONTRÓ LOS DATOS DE LA PROYECCIÓN DE VENTA Nº " + txtNumProy.Text + 
                        ", PUEDE SER QUE HAYAN ELIMINADO ESTA PROYECCIÓN DE VENTA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarSucursal()
        {
            if (LSuc != null)
            {
                List<OSucursal> lsuc = LSuc.Where(x => x.Estado).OrderBy(x => x.NomSuc).ToList();

                cboOpcion.DataSource = lsuc;
                cboOpcion.DisplayMember = "NomSuc";
                cboOpcion.ValueMember = "SucursalID";
                cboOpcion.Refresh();
            }
            else
                cboOpcion.DataSource = null;
        }

        private void CargarVendedor()
        {
            if (LPer != null)
            {
                List<OPersonal> lper = LPer.Where(x => x.Estado).OrderBy(x => x.NomPer).ToList();

                cboOpcion.DataSource = lper;
                cboOpcion.DisplayMember = "NomPer";
                cboOpcion.ValueMember = "PersonalID";
                cboOpcion.Refresh();
            }
            else
                cboOpcion.DataSource = null;
        }

        #endregion

        #region Funciones

        private void Borrar()
        {
            txtNumProy.Text = "-1";
            txtNomProy.Text = string.Empty;
            numUpDownProyectado.Value = 1;
            txtTotDias.Text = "0.00";
            txtTotEjec.Text = "0.00";
            txtTotPorcent.Text = "0.00";
            txtTotProy.Text = "0.00";

            NombreColumnasProy();
        }

        private bool VerifProcesar()
        {
            if (numUpDownProyectado.Text == string.Empty)
            {
                MessageBox.Show("Tiene que Ingresar el Monto Proyectado", "Llenar Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numUpDownProyectado.Focus();
                return false;
            }
            else if (Convert.ToDecimal(numUpDownProyectado.Text) <= 0)
            {
                MessageBox.Show("El Monto Proyectado no puede ser Menor o Igual a Cero", "Llenar Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numUpDownProyectado.Focus();
                return false;
            }
            else if (cboOpcion.Text == string.Empty)
            {
                MessageBox.Show("Tiene que Seleccionar una Sucursal o Vendedor", "Seleccionar Sucursal o Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboOpcion.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ProcesarDias()
        {
            DateTime d1 = Convert.ToDateTime(dtFecIni.Text);
            DateTime d2 = dtFecFin.Value;
            TimeSpan ts = d2 - d1;
            DateTime d = DateTime.MinValue + ts;
            string nomdia = string.Empty;
            CultureInfo ci = new CultureInfo("Es-Es");
            int cont = 0;
            dias = 0;

            for (int i = 0; i < d.Day; i++)
            {
                nomdia = ci.DateTimeFormat.GetDayName(d1.DayOfWeek).ToUpper();

                if((nomdia == "DOMINGO") || (nomdia == "SÁBADO"))
                {
                    dgvDetProyec.Rows.Add(nomdia.Substring(0, 3), "", d1.ToShortDateString(), "", "", "", "", "", "", 0, "", "", "");
                    dgvDetProyec.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
                }
                else
                {
                    if (LFer != null)
                    {
                        OFeriados fer = LFer.Find(c => c.Fecha.ToShortDateString().Contains(d1.ToShortDateString()));
                        if (fer != null)
                        {
                            dgvDetProyec.Rows.Add(nomdia.Substring(0, 3), "", d1.ToShortDateString(), "", "", "", "", "", "", 0, "", "", fer.NomFeriado);
                            dgvDetProyec.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
                        }
                        else
                        {
                            dgvDetProyec.Rows.Add(nomdia.Substring(0, 3), "1", d1.ToShortDateString(), "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", 1, "0.00", "0.00", "");
                            dias++;
                        }
                    }
                    else
                    {
                        dgvDetProyec.Rows.Add(nomdia.Substring(0, 3), "1", d1.ToShortDateString(), "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", 1, "0.00", "0.00", "");
                        dias++;
                    }
                }

                d1 = d1.AddDays(1);
                cont++;
            }
            
            txtTotDias.Text = dias.ToString();
        }

        private void ProcesarProyeccion()
        {
            if ((dgvDetProyec.Rows.Count > 1) && (numUpDownProyectado.Value > 0))
            {
                decimal proydiaria = numUpDownProyectado.Value / dias;
                decimal proyacum = proydiaria;
                decimal realacum = 0;
                decimal porcentaje = 0;

                try
                {
                    for (int i = 0; i < dgvDetProyec.Rows.Count; i++)
                    {
                        if (dgvDetProyec["Dia", i].Value != null)
                        {
                            if (Convert.ToBoolean(dgvDetProyec["Estado", i].Value))
                            {
                                //real sucursal
                                dgvDetProyec["Real Sucursal", i].Value = string.Format("{0:#,##0.00}", dgvDetProyec["Real Sucursal", i].Value);

                                //actualizamos las filas Real Acumulado
                                realacum += (Convert.ToDecimal(dgvDetProyec["Real Sucursal", i].Value) +
                                             Convert.ToDecimal(dgvDetProyec["Favor", i].Value) -
                                             Convert.ToDecimal(dgvDetProyec["Contra", i].Value));
                                dgvDetProyec["Real Acumulado", i].Value = string.Format("{0:#,##0.00}", realacum);

                                //actualizamos las filas Proyect. Diario
                                dgvDetProyec["Proyect. Diario", i].Value = string.Format("{0:#,##0.00}", proydiaria);

                                //actualizamos las filas Proyect. Acumulado
                                dgvDetProyec["Proyect. Acumulado", i].Value = string.Format("{0:#,##0.00}", proyacum);

                                //actualizamos las filas de %
                                porcentaje = (realacum / proyacum) * 100;
                                dgvDetProyec["%", i].Value = string.Format("{0:#,##0.00}", porcentaje);

                                //Actuaizamos la Diferencia
                                dgvDetProyec["Diferencia", i].Value = string.Format("{0:#,##0.00}", realacum - proyacum);
                                proyacum += proydiaria;
                            }
                        }
                    }
                }
                catch (Exception)
                { }
                finally
                {
                    txtTotEjec.Text = string.Format("{0:#,##0.00}", realacum);
                    txtTotPorcent.Text = string.Format("{0:#,##0.00}", porcentaje);
                    txtTotProy.Text = string.Format("{0:#,##0.00}", numUpDownProyectado.Value);
                }
            }
        }

        private void HabilDesabil(int fila)
        {
            if (dgvDetProyec["Dia", fila].Value != null)
            {
                if ((Convert.ToBoolean(dgvDetProyec["Estado", fila].Value)) &&
                                (dgvDetProyec["Dia", fila].Value.ToString() != ""))
                {
                    dgvDetProyec.Rows[fila].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    dgvDetProyec.Rows[fila].Cells[3].Style.BackColor = System.Drawing.Color.SteelBlue;

                    if (dgvDetProyec["Real Sucursal", fila].Value.ToString() == string.Empty)
                    {
                        dgvDetProyec["Valor Dia", fila].Value = "1";
                        dgvDetProyec["Real Sucursal", fila].Value = "0.00";
                        dgvDetProyec["Real Acumulado", fila].Value = "0.00";
                        dgvDetProyec["Favor", fila].Value = "0.00";
                        dgvDetProyec["Contra", fila].Value = "0.00";

                        dias++;
                    }
                }
                else if ((!Convert.ToBoolean(dgvDetProyec["Estado", fila].Value)) &&
                                    (dgvDetProyec["Dia", fila].Value.ToString() != ""))
                {
                    //Cambiamos el Color de la Fila
                    dgvDetProyec.Rows[fila].DefaultCellStyle.BackColor = System.Drawing.Color.Silver;

                    //borramos toda la fila
                    if (dgvDetProyec["Real Sucursal", fila].Value.ToString() != string.Empty)
                    {
                        dgvDetProyec["Valor Dia", fila].Value = "";
                        dgvDetProyec["Real Sucursal", fila].Value = "";
                        dgvDetProyec["Real Acumulado", fila].Value = "";
                        dgvDetProyec["Proyect. Diario", fila].Value = "";
                        dgvDetProyec["Proyect. Acumulado", fila].Value = "";
                        dgvDetProyec["Diferencia", fila].Value = "";
                        dgvDetProyec["%", fila].Value = "";
                        dgvDetProyec["Favor", fila].Value = "";
                        dgvDetProyec["Contra", fila].Value = "";

                        dias--;
                    }
                }
                txtTotDias.Text = dias.ToString();
            }
        }

        private void CargarArqueoCaja(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (Convert.ToBoolean(dgvDetProyec["Estado", e.RowIndex].Value))
                {
                    if ((dgvDetProyec.CurrentCell.ColumnIndex == 3) && (dgvDetProyec["Dia", e.RowIndex].Value != null))
                    {
                        DateTime fec = Convert.ToDateTime(dgvDetProyec["Fecha", dgvDetProyec.CurrentRow.Index].Value);
                        string o = string.Empty;
                        if (rbSucursal.Checked)
                            o = "Sucursal";
                        else
                            o = "Personal";

                        //Buscadores.BusqVentas bven = new Buscadores.BusqVentas(o, Convert.ToInt32(cboOpcion.SelectedValue), fec);
                        //bven.Owner = this;
                        //bven.ShowDialog();
                    }
                }
            }
        }

        private void Cancelar()
        {
            DialogResult result = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                Borrar();
        }

        #endregion

        #region Eventos Formulario

        private void Proyecciones_Load(object sender, EventArgs e)
        {
            NombreColumnasProy();
            ListarVendedor();
            ListarSucursal();

            if (txtNumProy.Text != "-1")
                ListarProyeccion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarModifProy();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void rbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            lblOpcion.Text = (rbVendedor.Checked ? "Vendedor:" : "Sucursal:");
            if (rbVendedor.Checked)
                CargarVendedor();
            else
                CargarSucursal();
        }

        private void Proyecciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmproy.Dispose();
            frmproy = null;
        }

        private void dgvDetProyec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarArqueoCaja(e);
        }

        private void dgvDetProyec_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int Col = dgvDetProyec.CurrentCell.ColumnIndex;

            if ((Col == 1) || (Col == 3) || (Col == 9) || (Col == 10) || (Col == 11) || (Col == 12))
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dgvDetProyec_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dgvDetProyec_KeyPress);
                }
            }
        }

        private void dgvDetProyec_KeyPress(object sender, KeyPressEventArgs e)
        {
            int Col = dgvDetProyec.CurrentCell.ColumnIndex;
            int Fil = dgvDetProyec.CurrentCell.RowIndex;

            if (dgvDetProyec["Dia", Fil].Value != null)
            {
                if (((Col == 1) || (Col == 3) || (Col == 9) || (Col == 10) || (Col == 11)) &&
                    (dgvDetProyec["Valor Dia", Fil].Value.ToString() != string.Empty))
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
                else if((Col == 12) && (dgvDetProyec["Valor Dia", Fil].Value.ToString() != string.Empty))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void numUpDownProyectado_ValueChanged(object sender, EventArgs e)
        {
            ProcesarProyeccion();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (VerifProcesar())
            {
                try
                {
                    dgvDetProyec.ReadOnly = false;
                    SucVend = cboOpcion.Text; //nombre de la sucursal o del vendedor
                    NombreColumnasProy();
                    //ListarFeriados();
                    ProcesarDias();
                    ProcesarProyeccion();
                }
                catch (Exception ex)
                {
                    //Ventanas.cargando.Close();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDetProyec_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Verificamos si se Habilita el estado
            if (dgvDetProyec.CurrentCell.ColumnIndex == 9)
                HabilDesabil(e.RowIndex);

            //Procesamos nuevamente a Proyeccion
            ProcesarProyeccion();
        }

        private void dgvDetProyec_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDetProyec.IsCurrentCellDirty)
                dgvDetProyec.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        #endregion
    }
}

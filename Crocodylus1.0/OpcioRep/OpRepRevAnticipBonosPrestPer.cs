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

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepRevAnticipBonosPrestPer : Form, IAgregaPer
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OPersonal> LPer = null;
        List<OGastoPersonal> LGasPer = null;
        OGastoPersonal GasPer = null;

        #region IAgregaPer

        public void AgregaPer(string nomper)
        {
            cboPer.Text = nomper;
        }

        #endregion

        public OpRepRevAnticipBonosPrestPer()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void CargarNombresDetalle()
        {
            dgvDetalle.Columns.Clear();

            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.Width = 60;
            c.Name = "CodGastoPer";
            c.Visible = false;
            dgvDetalle.Columns.Add(c);

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Width = 100;
            c0.Name = "Caja";
            c0.ReadOnly = true;
            c0.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 70;
            c1.Name = "Nro.";
            c1.ReadOnly = true;
            c1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 100;
            c2.Name = "Fecha";
            c2.ReadOnly = true;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 90;
            c3.Name = "Importe Bs";
            c3.ReadOnly = true;
            c3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Width = 90;
            c4.Name = "Saldo Bs";
            c4.ReadOnly = true;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Width = 200;
            c5.Name = "Tipo";
            c5.ReadOnly = true;
            c5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetalle.Columns.Add(c5);
        }

        #endregion

        #region Conexion Capa Negocios

        private void ListarSuc()
        {
            try
            {
                List<OSucursal> lsuc = NSucursal.NListarSucursales().OrderBy(x => x.NomSuc).ToList();

                cboSucursal.DataSource = lsuc;
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.Text = OConexionGlobal.NomSuc;
                cboSucursal.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ListarPer()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("Personal", -1).OrderBy(x => x.NomPer).ToList();

                cboPer.DataSource = LPer;
                cboPer.DisplayMember = "NomPer";
                cboPer.ValueMember = "PersonalID";
                cboPer.Text = OConexionGlobal.NomPer;
                cboPer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Procesar()
        {
            if (Verif())
            {
                CargarNombresDetalle();

                int cont = 0;
                decimal prestamo = 0;
                decimal almuerzo = 0;
                decimal anticipo = 0;
                decimal bonos = 0;
                decimal subsidio = 0;
                decimal otros = 0;

                try
                {
                    op.AbrirCargando("Procesando.....");

                    int suc = -1;
                    
                    if (cboBusqEn.Text == "Sucursal")
                        suc = Convert.ToInt32(cboSucursal.SelectedValue);

                    LGasPer = NGastoPersonal.NListarRevGastoXPersonal(suc, Convert.ToInt32(cboPer.SelectedValue), cboTipoRep.Text, dtIni.Value, dtFin.Value);

                    foreach (var item in LGasPer)
                    {
                        dgvDetalle.Rows.Add(item.CodGastoPer, item.NomCaja, item.NumGastoPer, item.Fecha.ToShortDateString(), string.Format("{0:#,##0.00}", item.MontoBs),
                                            string.Format("{0:#,##0.00}", item.TotalSaldoBs), item.Opcion);


                        if (item.Opcion == "Prestamos al Personal")
                            prestamo += item.MontoBs + (item.MontoSus * item.TC);
                        else if (item.Opcion == "Anticipo Almuerzo")
                            almuerzo += item.MontoBs + (item.MontoSus * item.TC);
                        else if (item.Opcion == "Anticipo al Personal")
                            anticipo += item.MontoBs + (item.MontoSus * item.TC);
                        else if (item.Opcion == "Bonos al Personal")
                            bonos += item.MontoBs + (item.MontoSus * item.TC);
                        else if (item.Opcion == "Pago de Subsidio")
                            subsidio += item.MontoBs + (item.MontoSus * item.TC);
                        else
                            otros += item.MontoBs + (item.MontoSus * item.TC);

                        if (item.TotalSaldoBs > 0)
                            dgvDetalle.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Plum;
                        
                        cont++;
                    }
                }
                catch
                {
                    CargarNombresDetalle();
                }
                finally
                {
                    if (dgvDetalle.Rows.Count > 1)
                        dgvDetalle.Rows[dgvDetalle.Rows.Count - 2].Cells[1].Selected = true;

                    txtTotPrestamo.Text = string.Format("{0:#,##0.00}", prestamo);
                    txtTotAnticipo.Text = string.Format("{0:#,##0.00}", anticipo);
                    txtTotAlmuerzo.Text = string.Format("{0:#,##0.00}", almuerzo);
                    txtTotBonos.Text = string.Format("{0:#,##0.00}", bonos);
                    txtTotSubsidio.Text = string.Format("{0:#,##0.00}", subsidio);
                    txtTotOtros.Text = string.Format("{0:#,##0.00}", otros);

                    op.CerrarCargando();
                }
            }
        }

        #endregion

        #region Cargar Datos

        private void SeleccionarNota(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    string CodGastoPer = dgvDetalle["CodGastoPer", e.RowIndex].Value.ToString();
                    GasPer = LGasPer.Find(x => x.CodGastoPer == CodGastoPer);
                }
                catch (Exception)
                { }
            }
        }

        #endregion

        #region Funciones

        private bool Verif()
        {
            if (cboPer.Text == string.Empty)
            {
                MessageBox.Show("No existe Clientes en la Lista", "Crear Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPer.Focus();
                return false;
            }
            else if (DateTime.Compare(dtFin.Value, dtIni.Value) < 0)
            {
                MessageBox.Show("La Fecha Inicial no puede ser mayor a la Fecha Final", "Error Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtIni.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        
        #endregion

        #region Eventos Formulario

        private void OpRepRevAnticipBonosPrestPer_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarPer();
            ListarSuc();

            CargarNombresDetalle();
            cboTipoRep.Text = "Totales";
            cboBusqEn.Text = "Empresa";
            dtIni.MaxDate = DateTime.Now;
            dtFin.MaxDate = DateTime.Now;

            op.CerrarCargando();
        }

        private void cboTipoRep_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarNombresDetalle();

            if (cboTipoRep.Text == "-----------------------")
            {
                MessageBox.Show("Seleccione un opcion valida", "Tipo Reporte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoRep.Text = "Totales";
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprExtracto_Click(object sender, EventArgs e)
        {

        }

        private void btnImprSaldos_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarPer();
            ListarSuc();

            op.CerrarCargando();
        }

        private void btnPag_Click(object sender, EventArgs e)
        {
            if (GasPer != null)
            {
                Buscadores.BusqDetallePagos bdpag = new Buscadores.BusqDetallePagos(GasPer.CodGastoPer, "Personal");
                bdpag.Owner = this;
                bdpag.ShowDialog();
            }
        }

        private void btnImpr_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes.RepNotasGastoPersonal rgasper = new Reportes.RepNotasGastoPersonal(GasPer);
                rgasper.Show();
            }
            catch (Exception)
            {    }
        }

        private void dgvDetalle_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarNota(e);
        }

        private void btnBuscPer_Click(object sender, EventArgs e)
        {
           
        }

        private void cboBusqEn_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarNombresDetalle();

            if (cboBusqEn.Text == "Empresa")
                cboSucursal.Enabled = false;
            else
                cboSucursal.Enabled = true;
        }

        private void cboPer_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarNombresDetalle();
        }

        #endregion
    }
}

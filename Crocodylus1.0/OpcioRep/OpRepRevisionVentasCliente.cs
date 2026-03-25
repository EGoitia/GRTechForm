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
    public partial class OpRepRevisionVentasCliente : Form, IAgregaClien
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OVenta> LVen = null;
        OVenta OVen = null;

        #region IAgragaClien

        public void AgregaClien(Int32 cod, string nomcli)
        {
            cboCliente.Text = nomcli;
        }

        #endregion

        public OpRepRevisionVentasCliente()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void CargarNombresDetalle()
        {
            dgvDetalle.Columns.Clear();

            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.Width = 60;
            c.Name = "CodVenta";
            c.Visible = false;
            dgvDetalle.Columns.Add(c);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 60;
            c1.Name = "Nro.";
            c1.ReadOnly = true;
            c1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 80;
            c2.Name = "Fecha";
            c2.ReadOnly = true;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 80;
            c3.Name = "Importe";
            c3.ReadOnly = true;
            c3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Width = 80;
            c4.Name = "Saldo";
            c4.ReadOnly = true;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Width = 230;
            c5.Name = "Referencia";
            c5.ReadOnly = true;
            c5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetalle.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Width = 90;
            c6.Name = "Tipo Venta";
            c6.ReadOnly = true;
            c6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetalle.Columns.Add(c6);
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

        private void ListarCli()
        {
            try
            {
                List<OCliente> lcli = NCliente.NListarClientes(OConexionGlobal.SucursalID).OrderBy(x => x.NomClien).ToList();

                cboCliente.DataSource = lcli;
                cboCliente.DisplayMember = "NomClien";
                cboCliente.ValueMember = "ClienteID";
                cboCliente.Text = "Clientes Varios";
                cboCliente.Refresh();
            }
            catch(Exception ex)
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
                decimal saldo = 0;
                decimal saldoanticip = 0;
                decimal importe = 0;
                decimal anticip = 0;

                try
                {
                    op.AbrirCargando("PROCESANDO.....");

                    int suc = -1;

                    if(cboBusqEn.Text == "Sucursal")
                        suc = Convert.ToInt32(cboSucursal.SelectedValue);

                    LVen = NVenta.NListarRevVentasXCliente(suc, Convert.ToInt32(cboCliente.SelectedValue), dtIni.Value, dtFin.Value);

                    foreach (var item in LVen)
                    {
                        //dgvDetalle.Rows.Add(item.CodVenta, item.NumVenta, item.Fecha.ToShortDateString(), string.Format("{0:#,##0.00}", item.MontoBs),
                        //                    string.Format("{0:#,##0.00}", item.TotalSaldoBs), item.Referencia, item.TipoVenta);

                        //if(item.TipoVenta == "ANTICIPADO")
                        //{
                        //    saldoanticip += item.TotalSaldoBs;
                        //    anticip += item.MontoBs;
                        //}
                        //else
                        //{
                        //    saldo += item.TotalSaldoBs;
                        //    importe += item.MontoBs;
                        //}


                        //if ((item.TipoVenta == "ANTICIPADO") && (item.TotalSaldoBs > 0))
                        //{ dgvDetalle.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Plum; }
                        //if ((item.TipoVenta == "CREDITO") && (item.TotalSaldoBs > 0))
                        //{ dgvDetalle.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen; }

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
                    {
                        dgvDetalle.Rows[dgvDetalle.Rows.Count - 2].Cells[1].Selected = true;
                    }

                    txtSaldo.Text = string.Format("{0:#,##0.00}", saldo);
                    txtSaldoAnticip.Text = string.Format("{0:#,##0.00}", saldoanticip);
                    txtImporte.Text = string.Format("{0:#,##0.00}", importe);
                    txtAnticip.Text = string.Format("{0:#,##0.00}", anticip);

                    op.CerrarCargando();
                }
            }
        }

        #endregion

        #region Cargar Datos



        #endregion

        #region Funciones

        private bool Verif()
        {
            if (cboCliente.Text == string.Empty)
            {
                MessageBox.Show("No existe Clientes en la Lista", "Crear Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCliente.Focus();
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

        private void SeleccionarNota(DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                try
                {
                    string CodVenta = dgvDetalle["CodVenta", e.RowIndex].Value.ToString();
                    OVen = LVen.Find(x => x.CodVenta == CodVenta);
                }
                catch (Exception)
                {       }
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepRevisionVentasCliente_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            CargarNombresDetalle();
            cboBusqEn.Text = "Sucursal";
            
            dtIni.MaxDate = DateTime.Now;
            dtFin.MaxDate = DateTime.Now;

            ListarCli();
            ListarSuc();

            op.CerrarCargando();
        }

        private void OpRepRevisionVentasCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            try
            {
                if (LVen != null)
                {
                    string nomrep = "REVISION DE VENTAS POR CLIENTE";
                    string suc = string.Empty;
                    string feccorte = "Del " + dtIni.Value.ToShortDateString() + " Al " + dtFin.Value.ToShortDateString();

                    if (cboBusqEn.Text == "Sucursal")
                    {
                        suc = cboSucursal.Text;
                        nomrep += " POR SUCURSAL";
                    }
                    else
                    {
                        nomrep += " POR EMPRESA";
                    }

                    Reportes.RepRevisionVentasCliente rvencli = new Reportes.RepRevisionVentasCliente(LVen, suc, nomrep, feccorte, cboCliente.Text);
                    rvencli.Show();
                }
            }
            catch (Exception)
            { }
        }

        private void btnImprSaldos_Click(object sender, EventArgs e)
        {
            try
            {
                if(LVen != null)
                {
                    string nomrep = "SALDO DE CLIENTE";
                    string suc = string.Empty;
                    string feccorte = "Del " + dtIni.Value.ToShortDateString() + " Al " + dtFin.Value.ToShortDateString();

                    if (cboBusqEn.Text == "Sucursal")
                    {
                        suc = cboSucursal.Text;
                        nomrep += " POR SUCURSAL";
                    }
                    else
                    {
                        nomrep += " POR EMPRESA";
                    }

                    //List<OVenta> lsaldos = LVen.Where(x => x.TotalSaldoBs > 0).ToList();
                    //Reportes.RepRevisionVentasCliente rvencli = new Reportes.RepRevisionVentasCliente(lsaldos, suc, nomrep, feccorte, cboCliente.Text);
                    //rvencli.Show();
                }
            }
            catch (Exception)
            {       }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando.....");

            ListarCli();
            ListarSuc();

            op.CerrarCargando();
        }

        private void btnBuscClient_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bcli = new Buscadores.Buscador();
            bcli.Owner = this;
            bcli.ShowDialog();
        }

        private void cboBusqEn_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBusqEn.Text == "Empresa")
                cboSucursal.Enabled = false;
            else
                cboSucursal.Enabled = true;

            CargarNombresDetalle();
        }

        private void GridDetalle_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarNota(e);   
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            if (OVen != null)
            {
                OpcioRep.OpRepVerProdNotas verprod = new OpRepVerProdNotas(OVen.CodVenta, "Venta");
                verprod.Owner = this;
                verprod.ShowDialog();
            }
        }

        private void btnPag_Click(object sender, EventArgs e)
        {
            if (OVen != null)
            {
                Buscadores.BusqDetallePagos bdpag = new Buscadores.BusqDetallePagos(OVen.CodVenta, "Cliente");
                bdpag.Owner = this;
                bdpag.ShowDialog();
            }
        }

        private void btnImpr_Click(object sender, EventArgs e)
        {
            try
            {
                //List<ODetalleVenta> LDVen = NDetalleVenta.NBuscarDVen(OVen.CodVenta);

                //Reportes.RepNotasVenta rven = new Reportes.RepNotasVenta(OVen, LDVen);
                //rven.Show();
            }
            catch (Exception)
            {       }
        }

        private void cboCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarNombresDetalle();
        }

        private void cboSucursal_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarNombresDetalle();
        }

        #endregion
    }
}

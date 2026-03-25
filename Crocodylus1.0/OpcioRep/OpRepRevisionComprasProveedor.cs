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
    public partial class OpRepRevisionComprasProveedor : Form, IAgregaProv
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OCompraProd> LCom = null;
        OCompraProd OCom = null;

        #region IagregaProv

        public void AgregaProv(string nomprov)
        {
            cboProv.Text = nomprov;
        }

        #endregion

        public OpRepRevisionComprasProveedor()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void CargarNombresDetalle()
        {
            dgvDetalle.Columns.Clear();

            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.Width = 60;
            c.Name = "CodCompra";
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
            c6.Name = "Tipo Compra";
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

        private void ListarProv()
        {
            try
            {
                List<OProveedor> lprov = NProveedor.NListarProv().OrderBy(x => x.NomProv).ToList();

                cboProv.DataSource = lprov;
                cboProv.DisplayMember = "NomProv";
                cboProv.ValueMember = "ProveedorID";
                cboProv.Refresh();
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
                decimal saldo = 0;
                decimal saldoanticip = 0;
                decimal importe = 0;
                decimal anticip = 0;

                try
                {
                    op.AbrirCargando("Procesando.....");

                    int suc = -1;

                    if (cboBusqEn.Text == "Sucursal")
                        suc = Convert.ToInt32(cboSucursal.SelectedValue);

                    LCom = NCompraProd.NListarRevComProv(suc, Convert.ToInt32(cboProv.SelectedValue), dtIni.Value, dtFin.Value);

                    foreach (var item in LCom)
                    {
                        //dgvDetalle.Rows.Add(item.CodCompraProd, item.NumCompraProd, item.FechaCompra.ToShortDateString(), string.Format("{0:#,##0.00}", item.MontoBs),
                        //                    string.Format("{0:#,##0.00}", item.SaldoBs), item.Referencia, item.TipoCompraProd);

                        //if (item.TipoCompraProd == "Pagos Anticipado a Prov.")
                        //{
                        //    saldoanticip += item.SaldoBs;
                        //    anticip += item.MontoBs;
                        //}
                        //else
                        //{
                        //    saldo += item.SaldoBs;
                        //    importe += item.MontoBs;
                        //}


                        //if ((item.TipoCompraProd == "Pagos Anticipado a Prov.") && (item.SaldoBs > 0))
                        //    dgvDetalle.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Plum;
                        //if ((item.TipoCompraProd == "Compras Credito") && (item.SaldoBs > 0))
                        //    dgvDetalle.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;

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
            if (cboProv.Text == string.Empty)
            {
                MessageBox.Show("No existe Proveedores en la Lista", "Crear Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProv.Focus();
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
            if (e.RowIndex > -1)
            {
                try
                {
                    string CodCompra = dgvDetalle["CodCompra", e.RowIndex].Value.ToString();
                    OCom = LCom.Find(x => x.CodCompraProd == CodCompra);
                }
                catch (Exception)
                { }
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepRevisionComprasProveedor_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarSuc();
            ListarProv();
            cboBusqEn.Text = "Empresa";

            op.CerrarCargando();
        }

        private void OpRepRevisionComprasProveedor_FormClosing(object sender, FormClosingEventArgs e)
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
                if (LCom != null)
                {
                    string nomrep = "REVISION DE COMPRAS AL PROVEEDOR";
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

                    Reportes.RepRevisionComprasProveedor rcomprov = new Reportes.RepRevisionComprasProveedor(LCom, suc, nomrep, feccorte, cboProv.Text);
                    rcomprov.Show();
                }
            }
            catch (Exception)
            { }
        }

        private void btnImprSaldos_Click(object sender, EventArgs e)
        {
            try
            {
                if (LCom != null)
                {
                    string nomrep = "SALDO DE PROVEEDOR";
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

                    //List<OCompraProd> lsaldos = LCom.Where(x => x.SaldoBs > 0).ToList();
                    //Reportes.RepRevisionComprasProveedor rcomprov = new Reportes.RepRevisionComprasProveedor(lsaldos, suc, nomrep, feccorte, cboProv.Text);
                    //rcomprov.Show();
                }
            }
            catch (Exception)
            { }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarSuc();
            ListarProv();

            op.CerrarCargando();
        }

        private void btnBuscProv_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            if (OCom != null)
            {
                OpcioRep.OpRepVerProdNotas verprod = new OpRepVerProdNotas(OCom.CodCompraProd, "Compra");
                verprod.Owner = this;
                verprod.ShowDialog();
            }
        }

        private void btnPag_Click(object sender, EventArgs e)
        {
            if (OCom != null)
            {
                Buscadores.BusqDetallePagos bdpag = new Buscadores.BusqDetallePagos(OCom.CodCompraProd, "Proveedor");
                bdpag.Owner = this;
                bdpag.ShowDialog();
            }
        }

        private void btnImpr_Click(object sender, EventArgs e)
        {
            try
            {
                List<ODetalleCompraProd> LDCom = NDetalleCompraProd.NBuscarDCompraProd(OCom.CodCompraProd);

                Reportes.RepNotasCompra rcom = new Reportes.RepNotasCompra(OCom, LDCom);
                rcom.Show();
            }
            catch (Exception)
            { }
        }

        private void cboBusqEn_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBusqEn.Text == "Empresa")
                cboSucursal.Enabled = false;
            else
                cboSucursal.Enabled = true;
        }

        private void dgvDetalle_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarNota(e);
        }

        #endregion
    }
}

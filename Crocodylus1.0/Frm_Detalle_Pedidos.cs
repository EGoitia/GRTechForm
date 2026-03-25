using Datos;
using Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Pedidos : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Pedidos frmdetped = null;

        private string Consulta = string.Empty;
        private string ConsultaDetalle = string.Empty;
        private bool ImpAnulado = false;

        public Frm_Detalle_Pedidos()
        {
            InitializeComponent();
        }

        private void HabilitarDesabilControl()
        {
            OpcionFormularios.HabilitarCont(gbxFiltro, 60);
            OpcionFormularios.HabilitarCont(gbxBotones, 60);
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodVenta"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["NumVenta"].HeaderText = "Nº Venta";
            dgvDetalle.Columns["SubtotalBs"].HeaderText = "Subtotal";
            dgvDetalle.Columns["DsctoBs"].HeaderText = "Dscto.";
            dgvDetalle.Columns["MontoBs"].HeaderText = "Monto";
            dgvDetalle.Columns["AnticipoBs"].HeaderText = "Anticipo";
            dgvDetalle.Columns["NomClien"].HeaderText = "Cliente";
            dgvDetalle.Columns["NomVendedor"].HeaderText = "Vendedor";
            dgvDetalle.Columns["Regul"].HeaderText = "Regul.";

            dgvDetalle.Columns["NumVenta"].FillWeight = 60;
            dgvDetalle.Columns["Referencia"].FillWeight = 150;
            dgvDetalle.Columns["NomClien"].FillWeight = 200;
            dgvDetalle.Columns["NomVendedor"].FillWeight = 130;
            dgvDetalle.Columns["SubtotalBs"].FillWeight = 70;
            dgvDetalle.Columns["DsctoBs"].FillWeight = 50;
            dgvDetalle.Columns["MontoBs"].FillWeight = 70;
            dgvDetalle.Columns["AnticipoBs"].FillWeight = 70;
            dgvDetalle.Columns["Saldo"].FillWeight = 70;
            dgvDetalle.Columns["Regul"].FillWeight = 50;

            dgvDetalle.Columns["SubtotalBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["DsctoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["MontoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["AnticipoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDetalle.Columns["SubtotalBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["DsctoBs"].DefaultCellStyle.Format = "N2";         
            dgvDetalle.Columns["MontoBs"].DefaultCellStyle.Format = "N2";         
            dgvDetalle.Columns["AnticipoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Saldo"].DefaultCellStyle.Format = "N2";
        }

        public override void Buscar()
        {
            try
            {
                Consulta = "SELECT CodVenta, CodInmode, NumVenta, Fecha, NomClien, Referencia, (MontoBs + DsctoBs) SubtotalBs, " +
                    "DsctoBs, MontoBs, AnticipoBs, (MontoBs - AnticipoBs) Saldo, NomSuc Almacen, NomVendedor, Estado, Regul " +
                    "FROM Vista_Pedidos WHERE CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + 
                    "' AND '" + dtFecFin.Value.ToShortDateString() + "'";

                ConsultaDetalle = "SELECT CodVenta FROM Vista_Pedidos WHERE CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() +
                    "' AND '" + dtFecFin.Value.ToShortDateString() + "'";

                if (!string.IsNullOrEmpty(txtCliente.Text.Trim()))
                {
                    Consulta += " AND Referencia LIKE '%" + txtCliente.Text.Trim() + "%'";
                    ConsultaDetalle += " AND Referencia LIKE '%" + txtCliente.Text.Trim() + "%'";
                }

                if (!string.IsNullOrEmpty(txtVendedor.Text))
                {
                    Consulta += " AND NomVendedor LIKE '%" + txtVendedor.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NomVendedor LIKE '%" + txtVendedor.Text.Trim() + "%'";
                }

                if (!string.IsNullOrWhiteSpace(txtNroVenta.Text))
                {
                    Consulta += " AND NumVenta LIKE '%" + txtNroVenta.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NumVenta LIKE '%" + txtNroVenta.Text.Trim() + "%'";
                }                

                if (cboSucursal.SelectedValue.ToString() != "-1")
                {
                    Consulta += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();
                    ConsultaDetalle += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();
                }

                Consulta += " AND Estado='" + (!chkAnulado.Checked).ToString() + "'";
                ConsultaDetalle += " AND Estado='" + (!chkAnulado.Checked).ToString() + "'";

                Consulta += " ORDER BY Fecha ASC";

                ImpAnulado = chkAnulado.Checked;

                dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);

                //Totales
                decimal val;
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(MontoBs)", "").ToString(), out val);
                txtMontoTot.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(AnticipoBs)", "").ToString(), out val);
                txtMontoAnticipo.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(Saldo)", "").ToString(), out val);
                txtMontoSaldo.Text = string.Format("{0:#,##0.00}", val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Seleccionamos la ultima fila
                if (dgvDetalle.Rows.Count > 0)
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[2];
            }
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Frm_Reporte rep = new Frm_Reporte();
            rep.Dts.Clear();
            rep.Titulo = DConstantes.Imprimir.Nota_Pedido.NOM_TITULO_NOTA_PEDIDO;
            rep.Llenar_Tabla("SELECT * FROM Vista_Pedidos WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Venta");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Pedidos WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Venta");
            rep.Cargar(DConstantes.Imprimir.Nota_Pedido.NOM_REPORTE_NOTA_PEDIDO, false,
                       DConstantes.Imprimir.Nota_Pedido.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_Pedido.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_Pedido.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_Pedido.MOSTRAR_ARBOL,
                       (int)rep.Dts.Tables["Lista_Venta"].Rows[0]["SucursalID"]);
            rep.Show();
        }

        private void ListarSucursales()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 UNION SELECT -1, '[TODAS]' ORDER BY NomSuc");
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;
                cboSucursal.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDetalle_Pedidos_Load(object sender, EventArgs e)
        {
            HabilitarDesabilControl();
            ListarSucursales();
            Buscar();
            NombreColumnas();
        }

        private void FrmDetalle_Pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmdetped.Dispose();
            frmdetped = null;
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("Pedido", "EL PEDIDO Nº " + dgvDetalle["NumVenta", dgvDetalle.CurrentRow.Index].Value.ToString());
        }
        
        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            
            Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Venta";
            base.ImprLista(sql, nomtabla, "LISTA DE PEDIDOS" + (ImpAnulado ? " ANULADAS" : ""), Variable,
                    DConstantes.Imprimir.Lista_Pedido.NOM_REPORTE_LISTA_PEDIDO, false,
                    DConstantes.Imprimir.Lista_Pedido.MOSTRAR_BTN_IMP,
                    DConstantes.Imprimir.Lista_Pedido.MOSTRAR_BTN_EXPORT,
                    DConstantes.Imprimir.Lista_Pedido.MOSTRAR_ARBOL);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            if (!(bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value)
            {
                MessageBox.Show("ESTA NOTA ESTÁ ANULADA", "ANULADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            object obj = DListarPersonalizado.Dato("SELECT NumVenta FROM Venta WHERE Estado=1 AND CodPedido='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'");
            if (obj != null)
            {
                MessageBox.Show("ESTA NOTA YA ESTÁ REGULARIZADA EN LA NOTA DE VENTA Nº " + obj.ToString(), "MENSAJE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Frm_Pedidos.frmpedido = new Frm_Pedidos();
            Frm_Pedidos.frmpedido.txtCodigoNota.Text = dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
            Frm_Pedidos.frmpedido.txtNumNota.Text = dgvDetalle["NumVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
            Frm_Pedidos.frmpedido.WindowState = FormWindowState.Maximized;
            Frm_Pedidos.frmpedido.ShowDialog();

            Buscar();
        }

        private void btnRegul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            if (!(bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value)
            {
                MessageBox.Show("ESTA NOTA ESTÁ ANULADA", "ANULADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            object obj = DListarPersonalizado.Dato("SELECT NumVenta FROM Venta WHERE Estado=1 AND CodPedido='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'");
            if (obj != null)
            {
                MessageBox.Show("ESTA NOTA YA ESTÁ REGULARIZADA EN LA NOTA DE VENTA Nº " + obj.ToString(), "MENSAJE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Frm_Venta.frmventa = new Frm_Venta();
            Frm_Venta.frmventa.TipoRegul = "Pedido";
            Frm_Venta.frmventa.txtCodigoNota.Text = dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
            Frm_Venta.frmventa.txtNumNota.Text = dgvDetalle["NumVenta", dgvDetalle.CurrentRow.Index].Value.ToString();
            Frm_Venta.frmventa.WindowState = FormWindowState.Maximized;
            Frm_Venta.frmventa.ShowDialog();

            Buscar();
        }

        private void btnImpListaDetallada_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;

            Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[2];
            string[] nomtabla = new string[2];
            sql[0] = Consulta;
            sql[1] = "SELECT * FROM Vista_Detalle_Pedidos WHERE CodVenta IN(" + ConsultaDetalle + ")";
            nomtabla[0] = "Lista_Venta";
            nomtabla[1] = "Detalle_Venta";
            base.ImprLista(sql, nomtabla, "LISTA DE PEDIDOS DETALLADO" + (ImpAnulado ? " ANULADOS" : ""), Variable,
                    DConstantes.Imprimir.Lista_Pedido_Detallado.NOM_REPORTE_LISTA_PEDIDO_DETALLADO, false,
                    DConstantes.Imprimir.Lista_Pedido_Detallado.MOSTRAR_BTN_IMP,
                    DConstantes.Imprimir.Lista_Pedido_Detallado.MOSTRAR_BTN_EXPORT,
                    DConstantes.Imprimir.Lista_Pedido_Detallado.MOSTRAR_ARBOL);
        }
    }
}

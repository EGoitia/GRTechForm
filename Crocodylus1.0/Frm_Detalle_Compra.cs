using Datos;
using Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Compra : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Compra detcom = null;
        
        private string ConsultaSql;
        private bool ImpAnulado = false;

        public Frm_Detalle_Compra()
        {
            InitializeComponent();
        }

        private void HabilitarDesabilControl()
        {
            OpcionFormularios.HabilitarCont(gbxFiltro, 52);
            OpcionFormularios.HabilitarCont(gbxBotones, 52);
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodCompraProd"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["ProveedorID"].Visible = false;
            dgvDetalle.Columns["TipoCompraID"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;

            dgvDetalle.Columns["NumCompraProd"].HeaderText = "Nº Compra";
            dgvDetalle.Columns["NumCompraProd"].FillWeight = 50;

            dgvDetalle.Columns["FechaCompra"].HeaderText = "Fecha";
            dgvDetalle.Columns["FechaCompra"].FillWeight = 90;

            dgvDetalle.Columns["NomProv"].HeaderText = "Proveedor";
            dgvDetalle.Columns["NomProv"].FillWeight = 150;

            dgvDetalle.Columns["Referencia"].HeaderText = "Referencia";
            dgvDetalle.Columns["Referencia"].FillWeight = 150;

            dgvDetalle.Columns["NomTipo"].HeaderText = "Tipo Compra";
            dgvDetalle.Columns["NomTipo"].FillWeight = 70;

            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDetalle.Columns["NomSuc"].FillWeight = 120;

            dgvDetalle.Columns["Detalle"].HeaderText = "Detalle";
            dgvDetalle.Columns["Detalle"].FillWeight = 200;

            dgvDetalle.Columns["Monto"].HeaderText = "Monto";
            dgvDetalle.Columns["Monto"].FillWeight = 50;
            dgvDetalle.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Monto"].DefaultCellStyle.Format = "N2";
        }

        public override void Buscar()
        {
            decimal val = 0;
            try
            {
                ConsultaSql = "SELECT CodCompraProd, CodInmode, ProveedorID, TipoCompraID, SucursalID, Estado, NumCompraProd, FechaCompra, NomProv, " +
                          "Referencia, NomTipo, Monto, NomSuc, Detalle FROM Vista_CompraProd WHERE Estado='" + (!chkAnulado.Checked).ToString() + "'";

                if (!string.IsNullOrWhiteSpace(txtProv.Text))
                    ConsultaSql += " AND NomProv LIKE '%" + txtProv.Text.Trim() + "%'";
                if (!string.IsNullOrWhiteSpace(txtNumCompra.Text))
                    ConsultaSql += " AND NumCompraProd LIKE '%" + txtNumCompra.Text.Trim() + "%'";
                if (chkTipoCompra.Checked)
                    ConsultaSql += " AND TipoCompraID=" + cboTipoCompra.SelectedValue;
                if (chkFechas.Checked)
                    ConsultaSql += " AND CONVERT(DATE, FechaCompra) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
                if (chkSucursal.Checked)
                    ConsultaSql += " AND SucursalID=" + cboSucursal.SelectedValue;

                ImpAnulado = chkAnulado.Checked;
                dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(ConsultaSql);

                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(Monto)", "").ToString(), out val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMontoTot.Text = string.Format("{0:#,##0.00}", val);

                //Seleccionamos la ultima fila
                if (dgvDetalle.Rows.Count > 0)
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[6];
            }
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Frm_Reporte rep = new Frm_Reporte();
            rep.Llenar_Tabla("SELECT * FROM Vista_CompraProd WHERE CodCompraProd='" + dgvDetalle["CodCompraProd", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Compra");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_CompraProd WHERE CodCompraProd='" + dgvDetalle["CodCompraProd", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Compra");
            rep.Cargar(DConstantes.Imprimir.Nota_Compra.NOM_REPORTE_NOTA_COMPRA, false,
                       DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_Compra.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_Compra.MOSTRAR_ARBOL,
                       (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
            rep.Show();
        }

        private void ListarSucursal()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc");
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoCompra()
        {
            try
            {
                cboTipoCompra.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Tupla='COMPRA' AND Estado=1");
                cboTipoCompra.DisplayMember = "NomTipo";
                cboTipoCompra.ValueMember = "TipoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTipoCompra_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoCompra.Enabled = chkTipoCompra.Checked;
        }

        private void Frm_Detalle_Compra_Load(object sender, EventArgs e)
        {
            HabilitarDesabilControl();
            ListarTipoCompra();
            ListarSucursal();
            Buscar();
            NombreColumnas();
        }

        private void Frm_Detalle_Compra_FormClosing(object sender, FormClosingEventArgs e)
        {
            detcom.Dispose();
            detcom = null;            
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;
            
            Object resp = DListarPersonalizado.Dato("SELECT COUNT(CodIngSalProd) CantIngr FROM IngSalProducto WHERE Estado=1 AND CodCompraProd='" +
                dgvDetalle["CodCompraProd", dgvDetalle.CurrentRow.Index].Value.ToString() + "'");
            if ((int)resp > 0)
            {
                MessageBox.Show("NO SE PUEDE ANULAR ESTA COMPRA PORQUE YA TIENE " + resp.ToString() + " NOTA" + ((int)resp > 1 ? "S" : "") + " DE INGRESO",
                    "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ID = dgvDetalle["CodCompraProd", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("Compra", "LA COMPRA Nº " + dgvDetalle["NumCompraProd", dgvDetalle.CurrentRow.Index].Value.ToString());
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = ConsultaSql;
            nomtabla[0] = "Lista_Compra";
            base.ImprLista(sql, nomtabla, "LISTA DE COMPRAS" + (ImpAnulado ? " ANULADAS" : ""), Variable,
                    DConstantes.Imprimir.Lista_Compra.NOM_REPORTE_LISTA_COMPRA,
                    DConstantes.Imprimir.Lista_Compra.MOSTRAR_BTN_IMP,
                    DConstantes.Imprimir.Lista_Compra.MOSTRAR_BTN_COPIAR,
                    DConstantes.Imprimir.Lista_Compra.MOSTRAR_BTN_EXPORT,
                    DConstantes.Imprimir.Lista_Compra.MOSTRAR_ARBOL);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Object resp = DListarPersonalizado.Dato("SELECT COUNT(CodIngSalProd) CantIngr FROM IngSalProducto WHERE Estado=1 AND CodCompraProd='" +
                dgvDetalle["CodCompraProd", dgvDetalle.CurrentRow.Index].Value.ToString() + "'");
            if ((int)resp > 0)
            {
                MessageBox.Show("NO SE PUEDE MODIFICAR ESTA COMPRA PORQUE YA TIENE " + resp.ToString() + " NOTA" + ((int)resp > 1 ? "S" : "") + " DE INGRESO",
                    "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Modificar("Compra");
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFecIni.Enabled = chkFechas.Checked;
            dtFecFin.Enabled = chkFechas.Checked;
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void btnRegul_Click(object sender, EventArgs e)
        {
            if(dgvDetalle.Rows.Count>0)
            {
                if (!(bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value)
                {
                    MessageBox.Show("!ESTA NOTA ESTÁ ANULADO!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Convert.ToDecimal(DListarPersonalizado.Dato("SELECT SUM(Cantidad-Cantidad_Ingr) FROM Vista_Saldo_Detalle_CompraProd " +
                                    "WHERE CodCompraProd='" + dgvDetalle["CodCompraProd", dgvDetalle.CurrentRow.Index].Value + "'")) > 0)
                {
                    Frm_IngSalProducto.frmingprod = new Frm_IngSalProducto();
                    Frm_IngSalProducto.frmingprod.TipoNota = "IngSalProd";
                    Frm_IngSalProducto.frmingprod.Tupla = "INGRESO";
                    Frm_IngSalProducto.frmingprod.txtCodCompraProd.Text = dgvDetalle["CodCompraProd", dgvDetalle.CurrentRow.Index].Value.ToString();
                    Frm_IngSalProducto.frmingprod.ShowDialog();

                    Buscar();
                }
                else
                    MessageBox.Show("ESTA NOTA DE COMPRA YA FUÉ REGULARIZADA", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}

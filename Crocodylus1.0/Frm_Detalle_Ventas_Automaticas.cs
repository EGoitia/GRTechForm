using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Ventas_Automaticas : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Ventas_Automaticas detvenaut = null;

        private string Consulta = string.Empty;

        public Frm_Detalle_Ventas_Automaticas()
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
            dgvDetalle.Columns["FacturaID"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;

            dgvDetalle.Columns["NumVenta"].HeaderText = "Nº Venta";
            dgvDetalle.Columns["NumFactura"].HeaderText = "Nº Factura";
            dgvDetalle.Columns["TipoVenta"].HeaderText = "Tipo Venta";
            dgvDetalle.Columns["MontoBs"].HeaderText = "Monto";
            dgvDetalle.Columns["AnticipoBs"].HeaderText = "Anticipo";
            dgvDetalle.Columns["NomClien"].HeaderText = "Cliente";
            dgvDetalle.Columns["NomVendedor"].HeaderText = "Vendedor";
            dgvDetalle.Columns["NomSuc"].HeaderText = "Almacen";

            dgvDetalle.Columns["NumVenta"].FillWeight = 60;
            dgvDetalle.Columns["NumFactura"].FillWeight = 60;
            dgvDetalle.Columns["Referencia"].FillWeight = 150;
            dgvDetalle.Columns["TipoVenta"].FillWeight = 70;
            dgvDetalle.Columns["MontoBs"].FillWeight = 70;
            dgvDetalle.Columns["MontoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["MontoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["AnticipoBs"].FillWeight = 70;
            dgvDetalle.Columns["AnticipoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["AnticipoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["NomClien"].FillWeight = 200;
            dgvDetalle.Columns["NomVendedor"].FillWeight = 130;
        }

        public override void Buscar()
        {
            try
            {
                Consulta = string.Format("SELECT CodVenta, CodInmode, NumVenta, FacturaID, NumFactura, Fecha, TipoVenta, " +
                    "NomClien, Referencia, MontoBs, AnticipoBs, SucursalID, NomSuc, NomVendedor, Estado " +
                    "FROM Vista_Ventas WHERE Referencia LIKE '%{0}%'", txtCliente.Text.Trim());

                if (chkFechas.Checked)
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";

                if (chkTipoVenta.Checked)
                    Consulta += " AND TipoVenta='" + cboTipoVenta.Text + "'";

                if (!string.IsNullOrEmpty(txtVendedor.Text))
                    Consulta += " AND NomVendedor LIKE '%" + txtVendedor.Text.Trim() + "%'";

                if (!string.IsNullOrWhiteSpace(txtNroVenta.Text))
                    Consulta += " AND NumVenta LIKE '%" + txtNroVenta.Text.Trim() + "%'";

                if (!string.IsNullOrWhiteSpace(txtNroFactura.Text))
                    Consulta += " AND NumFactura LIKE '%" + txtNroFactura.Text + "%'";

                if (chkSucursal.Checked)
                    Consulta += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();

                Consulta += " AND Estado='" + (!chkAnulado.Checked).ToString() + "'";

                Consulta += " ORDER BY Fecha ASC";

                dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);
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
            rep.Llenar_Tabla("SELECT * FROM Vista_Ventas WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Venta");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + dgvDetalle["CodVenta", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Venta");
            rep.Cargar(DConstantes.Imprimir.Nota_Venta.NOM_REPORTE_NOTA_VENTA,
                       DConstantes.Imprimir.Nota_Venta.IMPAUTOMATIC_NOTA_VENTA,
                       DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_Venta.MOSTRAR_ARBOL,
                       (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
            rep.Show();
        }

        private void ListarSucursales()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 ORDER BY NomSuc");
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

        private void ListarTipoVenta()
        {
            try
            {
                List<OTipoVenta> LTVen = new List<OTipoVenta>();
                OTipoVenta tven = null;


                //if (op.HabilitarOpc(cboTipoVenta, "5.01", "Contado"))
                //{
                tven = new OTipoVenta();
                tven.NomTipoVenta = "CONTADO";
                tven.Estado = true;
                LTVen.Add(tven);
                //}

                //if (op.HabilitarOpc(cboTipoVenta, "5.01", "Credito"))
                //{
                tven = new OTipoVenta();
                tven.NomTipoVenta = "CREDITO";
                tven.Estado = true;
                LTVen.Add(tven);
                //}

                //if (op.HabilitarOpc(cboTipoVenta, "5.01", "Anticipado"))
                //{
                //tven = new OTipoVenta();
                //tven.NomTipoVenta = "ANTICIPADO";
                //tven.Estado = true;
                //LTVen.Add(tven);
                //}

                cboTipoVenta.DataSource = LTVen;
                cboTipoVenta.DisplayMember = "NomTipoVenta";
                cboTipoVenta.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

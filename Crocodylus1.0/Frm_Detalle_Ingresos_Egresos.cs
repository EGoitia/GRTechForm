using Datos;
using Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Ingresos_Egresos : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Ingresos_Egresos frmdetgastingr = null;
        private string Consulta = string.Empty;

        public Frm_Detalle_Ingresos_Egresos()
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
            dgvDetalle.Columns["CodIngrEgre"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;

            dgvDetalle.Columns["NumIngrEgre"].HeaderText = "Nº Nota";
            dgvDetalle.Columns["TipoIngrEgre"].HeaderText = "Tipo";
            dgvDetalle.Columns["MontoBs"].HeaderText = "Monto";
            dgvDetalle.Columns["TC"].HeaderText = "T.C.";
            dgvDetalle.Columns["NombreCuenta"].HeaderText = "Cuenta";
            dgvDetalle.Columns["NomCaja"].HeaderText = "Caja";
            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";

            dgvDetalle.Columns["NumIngrEgre"].FillWeight = 60;
            dgvDetalle.Columns["NombreCuenta"].FillWeight = 150;
            dgvDetalle.Columns["TipoIngrEgre"].FillWeight = 40;
            dgvDetalle.Columns["MontoBs"].FillWeight = 70;
            dgvDetalle.Columns["MontoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["MontoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["TC"].FillWeight = 50;
            dgvDetalle.Columns["TC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["TC"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["NomCaja"].FillWeight = 150;
            dgvDetalle.Columns["NomSuc"].FillWeight = 150;
        }

        public override void Buscar()
        {
            try
            {
                Consulta = string.Format("SELECT CodIngrEgre, CodInmode, NumIngrEgre, Fecha, TipoIngrEgre, " +
                    "NombreCuenta, NomCaja, SucursalID, NomSuc, MontoBs, TC, Estado " +
                    "FROM Vista_Ingresos_Egresos WHERE Estado<>'{0}'", chkAnulado.Checked.ToString());

                if (chkFechas.Checked)
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";

                if (chkTipo.Checked)
                    Consulta += " AND TipoIngrEgre='" + cboTipo.SelectedValue + "'";

                if (chkCaja.Checked)
                    Consulta += " AND CajaID=" + cboCaja.SelectedValue;

                if (chkSucursal.Checked)
                    Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;

                //if (!string.IsNullOrWhiteSpace(txtNroVenta.Text))
                //    Consulta += " AND NumVenta LIKE '%" + txtNroVenta.Text.Trim() + "%'";

                //if (!string.IsNullOrWhiteSpace(txtNroFactura.Text))
                //    Consulta += " AND NumFactura LIKE '%" + txtNroFactura.Text + "%'";

                Consulta += " ORDER BY Fecha ASC";

                dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);

                //Totales
                decimal val;
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(MontoBs)", "TipoIngrEgre='I'").ToString(), out val);
                txtTotalIngreso.Text = string.Format("{0:#,##0.00}", val);
                decimal.TryParse(((DataTable)dgvDetalle.DataSource).Compute("SUM(MontoBs)", "TipoIngrEgre='E'").ToString(), out val);
                txtTotalEgreso.Text = string.Format("{0:#,##0.00}", val);
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

            rep.Titulo = "NOTAS EGRESO-INGRESO";

            rep.Llenar_Tabla("SELECT * FROM Vista_Ingresos_Egresos WHERE CodIngrEgre='" + dgvDetalle["CodIngrEgre", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_IngrEgre");
            rep.Cargar(DConstantes.Imprimir.Nota_IngrEgre.NOM_REPORTE_NOTA_INGREGRE, false,
                       DConstantes.Imprimir.Nota_IngrEgre.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_IngrEgre.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_IngrEgre.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_IngrEgre.MOSTRAR_ARBOL,
                       (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
            rep.Show();
        }

        private void ListarCajas()
        {
            try
            {
                cboCaja.DataSource = DListarPersonalizado.ConsultarDT("SELECT CajaID, NomCaja FROM Caja WHERE Estado=1 ORDER BY NomCaja");
                cboCaja.DisplayMember = "NomCaja";
                cboCaja.ValueMember = "CajaID";
                cboCaja.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ListarTipoPago()
        {
            try
            {
                cboTipoPago.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo " +
                    "WHERE Tupla='PAGO' AND Estado=1 ORDER BY NomTipo");
                cboTipoPago.DisplayMember = "NomTipo";
                cboTipoPago.ValueMember = "TipoID";
                cboTipoPago.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipo()
        {
            try
            {
                DataTable TipoDT = new DataTable();
                TipoDT.Columns.Add("ID");
                TipoDT.Columns.Add("Nombre");
                DataRow TipoDR = TipoDT.NewRow();

                TipoDR["ID"] = "I";
                TipoDR["Nombre"] = "INGRESO";
                TipoDT.Rows.Add(TipoDR);

                TipoDR = TipoDT.NewRow();
                TipoDR["ID"] = "E";
                TipoDR["Nombre"] = "EGRESO";
                TipoDT.Rows.Add(TipoDR);

                cboTipo.DataSource = TipoDT;
                cboTipo.DisplayMember = "Nombre";
                cboTipo.ValueMember = "ID";
                cboTipo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Detalle_Gastos_Ingresos_Load(object sender, EventArgs e)
        {
            HabilitarDesabilControl();
            ListarTipo();
            ListarTipoPago();
            ListarCajas();
            ListarSucursales();
            Buscar();
            NombreColumnas();
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            string[] consult = new string[1];
            consult[0] = Consulta;

            string[] nomtabla = new string[1];
            nomtabla[0] = "Lista_IngrEgre";

            string variabl = (chkFechas.Checked ? "DEL: " + dtFecIni.Value.ToShortDateString() + " AL: " + dtFecFin.Value.ToShortDateString() : "");

            ImprLista(consult, nomtabla, "LISTA DE INGRESOS/EGRESOS", variabl, 
                    DConstantes.Imprimir.Lista_IngrEgre.NOM_REPORTE_LISTA_INGREGRE,
                    DConstantes.Imprimir.Lista_IngrEgre.MOSTRAR_BTN_IMP,
                    DConstantes.Imprimir.Lista_IngrEgre.MOSTRAR_BTN_COPIAR,
                    DConstantes.Imprimir.Lista_IngrEgre.MOSTRAR_BTN_EXPORT,
                    DConstantes.Imprimir.Lista_IngrEgre.MOSTRAR_ARBOL);
        }

        private void Frm_Detalle_Gastos_Ingresos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmdetgastingr.Dispose();
            frmdetgastingr = null;
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["CodIngrEgre", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("IngresoEgreso", "LA NOTA Nº " + dgvDetalle["NumIngrEgre", dgvDetalle.CurrentRow.Index].Value.ToString());
        }

        private void chkCaja_CheckedChanged(object sender, EventArgs e)
        {
            cboCaja.Enabled = chkCaja.Checked;
        }

        private void chkTipo_CheckedChanged(object sender, EventArgs e)
        {
            cboTipo.Enabled = chkTipo.Checked;
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void chkTipoPago_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoPago.Enabled = chkTipoPago.Checked;
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFecIni.Enabled = chkFechas.Checked;
            dtFecFin.Enabled = chkFechas.Checked;
        }

    }
}

using Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Abonos : Frm_Base_Detalles
    {
        public static Frm_Detalle_Abonos detaboncli = null;
        public static Frm_Detalle_Abonos detabonprov = null;

        private bool AbonCli;
        private string Consulta = string.Empty;

        public Frm_Detalle_Abonos(bool _aboncli)
        {
            InitializeComponent();

            AbonCli = _aboncli;

            if (_aboncli)
                this.Text = "DETALLE DE ABONOS DE CLIENTES";
            else
                this.Text = "DETALLE DE PAGOS A PROVEEDORES";
        }

        private void HabilitarDesabilControl()
        {
            OpcionFormularios.HabilitarCont(gbxFiltro, (AbonCli ? 55 : 70));
            OpcionFormularios.HabilitarCont(gbxBotones, (AbonCli ? 55 : 70));
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodAbono"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["TipoAbono"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["TipoPago"].HeaderText = "Tipo Pago";
            dgvDetalle.Columns["TipoPago"].FillWeight = 90;

            dgvDetalle.Columns["NumAbono"].HeaderText = "Nº Abono";
            dgvDetalle.Columns["NumAbono"].FillWeight = 70;

            if (AbonCli)
            {
                dgvDetalle.Columns["NomClien"].HeaderText = "Cliente";
                dgvDetalle.Columns["NomClien"].FillWeight = 150;
            }
            else
            {
                dgvDetalle.Columns["NomProv"].HeaderText = "Proveedor";
                dgvDetalle.Columns["NomProv"].FillWeight = 150;
            }            

            dgvDetalle.Columns["Referencia"].HeaderText = "Referencia";
            dgvDetalle.Columns["Referencia"].FillWeight = 150;

            dgvDetalle.Columns["PagarCaja"].HeaderText = "Caja";
            dgvDetalle.Columns["PagarCaja"].FillWeight = 50;

            dgvDetalle.Columns["Fecha"].HeaderText = "Fecha";
            dgvDetalle.Columns["Fecha"].FillWeight = 90;

            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDetalle.Columns["NomSuc"].FillWeight = 90;

            dgvDetalle.Columns["Detalle"].HeaderText = "Detalle";
            dgvDetalle.Columns["Detalle"].FillWeight = 300;

            dgvDetalle.Columns["MontoTotalBs"].HeaderText = "Monto";
            dgvDetalle.Columns["MontoTotalBs"].FillWeight = 80;
            dgvDetalle.Columns["MontoTotalBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["MontoTotalBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void Listar_Tipo_Pago()
        {
            try
            {
                cboTipoPago.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND  Tupla='PAGO' ORDER BY NomTipo");
                cboTipoPago.DisplayMember = "NomTipo";
                cboTipoPago.ValueMember = "TipoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Sucursal()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 ORDER BY NomSuc");
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_CliProv()
        {
            try
            {
                string consult = string.Empty;
                if (AbonCli)
                    consult = "SELECT ClienteID ID, NomClien Nom FROM Cliente ORDER BY NomClien";
                else
                    consult = "SELECT ProveedorID ID, NomProv Nom FROM Proveedor ORDER BY NomProv";

                cboCliente.DataSource = DListarPersonalizado.ConsultarDT(consult);
                cboCliente.DisplayMember = "Nom";
                cboCliente.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            decimal totalabono = 0;

            try
            {
                Consulta = "SELECT CodAbono, CodInmode, TipoAbono, NumAbono, TipoPago, Fecha, " + (AbonCli ? "NomClien" : "NomProv") + ", " +
                       "Referencia, Estado, (MontoTotalBs-TotalDsctoBs) MontoTotalBs, NomSuc, PagarCaja, Detalle FROM Vista_Abonos " +
                       "WHERE TipoAbono='" + (AbonCli ? "Cliente" : "Proveedor") + "' AND Estado='" + (!cbxAnuladas.Checked).ToString() + "'";

                if (cbxFechas.Checked)
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
                if (cbxSucursal.Checked)
                    Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;
                if(cbxCliente.Checked)
                    Consulta += " AND ClienteID=" + cboCliente.SelectedValue;
                if (!string.IsNullOrWhiteSpace(txtReferencia.Text))
                    Consulta += " AND Referencia LIKE '%" + txtReferencia.Text.Trim() + "%'";
                if (!string.IsNullOrWhiteSpace(txtNroNota.Text))
                    Consulta += " AND CodAbono IN(Select da.CodAbono From Vista_Detalle_Abonos da Inner Join Abono a On da.CodAbono=a.CodAbono " +
                                "Where da.NumNota='" + txtNroNota.Text.Trim() + "' And a.TipoAbono='" + (AbonCli ? "Cliente" : "Proveedor") + "')";
                if (cbxTipoPago.Checked)
                    Consulta += " AND TipoPagoID=" + cboTipoPago.SelectedValue;

                Consulta += " ORDER BY Fecha";

                DataTable AbonosDT = DListarPersonalizado.ConsultarDT(Consulta);
                dgvDetalle.DataSource = AbonosDT;

                //Totales
                decimal.TryParse(AbonosDT.Compute("SUM(MontoTotalBs)", "").ToString(), out totalabono);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtTotal.Text = string.Format("{0:#,##0.00}", totalabono);

                //Seleccionamos la ultima fila
                if (dgvDetalle.Rows.Count > 0)
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[3];
            }
        }

        private string Consulta_Pago()
        {
            string consultapago;
            consultapago = "SELECT * FROM Vista_Pagos WHERE CodAbono IN(Select CodAbono From Vista_Abonos Where TipoAbono='" + (AbonCli ? "Cliente" : "Proveedor") + "' AND Estado='" + (!cbxAnuladas.Checked).ToString() + "'";

            if (cbxFechas.Checked)
                consultapago += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
            if (cbxSucursal.Checked)
                consultapago += " AND SucursalID=" + cboSucursal.SelectedValue;
            if (cbxCliente.Checked)
                consultapago += " AND ClienteID=" + cboCliente.SelectedValue;
            if (!string.IsNullOrWhiteSpace(txtReferencia.Text))
                consultapago += " AND Referencia LIKE '%" + txtReferencia.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtNroNota.Text))
                consultapago += " AND CodAbono IN(Select da.CodAbono From Vista_Detalle_Abonos da Inner Join Abono a On da.CodAbono=a.CodAbono " +
                            "Where da.NumNota='" + txtNroNota.Text.Trim() + "' And a.TipoAbono='" + (AbonCli ? "Cliente" : "Proveedor") + "')";
            if (cbxTipoPago.Checked)
                consultapago += " AND CodAbono IN(Select CodAbono From Pago Where Estado=1 And TipoPagoID=" + cboTipoPago.SelectedValue + ")";

            return consultapago + ")";
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                Frm_Reporte rep = new Frm_Reporte();
                rep.Titulo = "RECIBO DE PAGO";
                rep.Llenar_Tabla("SELECT * FROM Vista_Abonos WHERE CodAbono='" + dgvDetalle["CodAbono", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Abonos");
                rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Abonos WHERE CodAbono='" + dgvDetalle["CodAbono", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Abonos");
                rep.Cargar("RepNotaAbonos", false);
                rep.Show();
            }
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.RowCount > 0)
            {
                base.ID = dgvDetalle["CodAbono", dgvDetalle.CurrentRow.Index].Value.ToString();
                base.Estado = (bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value;
                
                base.Anular("AbonoCliProv", "LA NOTA DE ABONO Nº " + dgvDetalle["NumAbono", dgvDetalle.CurrentRow.Index].Value.ToString());
            }
        }

        private void Frm_Detalle_Abonos_Load(object sender, EventArgs e)
        {
            cboTipoPago.Text = "EFECTIVO";
            cbxCliente.Text = (AbonCli ? "Cliente:" : "Proveedor:");
            HabilitarDesabilControl();
            Listar_Tipo_Pago();
            Listar_Sucursal();
            Listar_CliProv();            
            Buscar();
            NombreColumnas();
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string variable = string.Empty;

            if (cbxFechas.Checked)
                variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[2];
            string[] nomtabla = new string[2];
            sql[0] = Consulta;
            sql[1] = Consulta_Pago();
            nomtabla[0] = "Lista_Abonos";
            nomtabla[1] = "Vista_Pagos";

            base.ImprLista(sql, nomtabla, (AbonCli ? "LISTA ABONOS DE CLIENTES" : "LISTA PAGOS A PROVEEDORES") + 
                (cbxAnuladas.Checked ? " ANULADAS" : ""), variable, "RptListaAbonos", false);
        }

        private void cbxFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFecIni.Enabled = cbxFechas.Checked;
            dtFecFin.Enabled = cbxFechas.Checked;
        }

        private void cbxSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = cbxSucursal.Checked;
        }

        private void cbxCliente_CheckedChanged(object sender, EventArgs e)
        {
            cboCliente.Enabled = cbxCliente.Checked;
        }

        private void cbxTipoPago_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoPago.Enabled = cbxTipoPago.Checked;
        }

        private void Frm_Detalle_Abonos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (detaboncli != null)
            {
                detaboncli.Dispose();
                detaboncli = null;
            }
            else
            {
                detabonprov.Dispose();
                detabonprov = null;
            }
        }
    }
}

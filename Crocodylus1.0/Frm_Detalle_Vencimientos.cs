using Datos;
using Objetos;
using System;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Vencimientos : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Vencimientos frmdetvenc = null;
        private string Consulta = string.Empty;

        public Frm_Detalle_Vencimientos()
        {
            InitializeComponent();
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

        private void NombreColumnas()
        {
            dgvDetalle.Columns["LoteID"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["ProductoID"].Visible = false;
            dgvDetalle.Columns["NomSuc"].Visible = (chkSucursal.Checked ? false : true);

            dgvDetalle.Columns["Marca"].ReadOnly = true;
            dgvDetalle.Columns["CodFabrica"].ReadOnly = true;
            dgvDetalle.Columns["NumLote"].ReadOnly = true;
            dgvDetalle.Columns["NomProd"].ReadOnly = true;
            dgvDetalle.Columns["UnidMedida"].ReadOnly = true;
            dgvDetalle.Columns["Fecha_Fab"].ReadOnly = true;
            dgvDetalle.Columns["Fecha_Venc"].ReadOnly = true;
            dgvDetalle.Columns["Cantidad"].ReadOnly = true;
            dgvDetalle.Columns["Baja"].ReadOnly = true;
            dgvDetalle.Columns["Vigente"].ReadOnly = true;

            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDetalle.Columns["Marca"].HeaderText = "Marca";
            dgvDetalle.Columns["CodFabrica"].HeaderText = "Código";
            dgvDetalle.Columns["NumLote"].HeaderText = "Nº Lote";
            dgvDetalle.Columns["NomProd"].HeaderText = "Producto";
            dgvDetalle.Columns["UnidMedida"].HeaderText = "Medida";
            dgvDetalle.Columns["Fecha_Fab"].HeaderText = "Fecha Fab.";
            dgvDetalle.Columns["Fecha_Venc"].HeaderText = "Fecha Venc.";
            dgvDetalle.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDetalle.Columns["Baja"].HeaderText = "Cant. Baja";
            dgvDetalle.Columns["Vendido"].HeaderText = "Cant. Vendido";
            dgvDetalle.Columns["Vigente"].HeaderText = "Cant. Vigente";
            dgvDetalle.Columns["CantDarVendido"].HeaderText = "Cant. Vendido";
            dgvDetalle.Columns["CantDarBaja"].HeaderText = "Cant. Baja";
            dgvDetalle.Columns["Modif"].HeaderText = "Modif.";

            dgvDetalle.Columns["Marca"].FillWeight = 100;
            dgvDetalle.Columns["CodFabrica"].FillWeight = 60;
            dgvDetalle.Columns["NumLote"].FillWeight = 60;
            dgvDetalle.Columns["NomProd"].FillWeight = 200;
            dgvDetalle.Columns["UnidMedida"].FillWeight = 50;
            dgvDetalle.Columns["Fecha_Fab"].FillWeight = 90;
            dgvDetalle.Columns["Fecha_Venc"].FillWeight = 90;
            dgvDetalle.Columns["Cantidad"].FillWeight = 70;
            dgvDetalle.Columns["Baja"].FillWeight = 70;
            dgvDetalle.Columns["Vendido"].FillWeight = 70;
            dgvDetalle.Columns["Vigente"].FillWeight = 70;
            dgvDetalle.Columns["CantDarBaja"].FillWeight = 70;
            dgvDetalle.Columns["CantDarVendido"].FillWeight = 70;
            dgvDetalle.Columns["Modif"].FillWeight = 40;

            dgvDetalle.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Baja"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Vendido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Vigente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["CantDarBaja"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["CantDarVendido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDetalle.Columns["Cantidad"].DefaultCellStyle.BackColor = System.Drawing.Color.Aqua;
            dgvDetalle.Columns["Baja"].DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
            dgvDetalle.Columns["Vendido"].DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
            dgvDetalle.Columns["Vigente"].DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            dgvDetalle.Columns["CantDarBaja"].DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            dgvDetalle.Columns["CantDarVendido"].DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
                        
            dgvDetalle.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Baja"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Vendido"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["Vigente"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["CantDarBaja"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["CantDarVendido"].DefaultCellStyle.Format = "N2";
        }

        public override void Buscar()
        {
            Consulta = "SELECT LoteID, CodInmode, ProductoID, NomSuc, Marca, CodFabrica, NomProd, UnidMedida, NumLote, Fecha_Fab, Fecha_Venc, " +
                "Cantidad, Vendido, Baja, Vigente, CONVERT(DECIMAL, 0) CantDarBaja, CONVERT(DECIMAL, 0) CantDarVendido, CONVERT(BIT, 0) Modif " + 
                "FROM Vista_Lotes WHERE NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";

            if (chkSucursal.Checked)
                Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;
            if(chkFechas.Checked)
                Consulta += " AND CONVERT(DATE, Fecha_Fabricacion) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
            if (chkFechaVenc.Checked)
                Consulta += " AND CONVERT(DATE, Fecha_Venc) BETWEEN '" + dtFechaVencFin.Value.ToShortDateString() + "' AND '" + dtFechaVencIni.Value.ToShortDateString() + "'";
            if (!string.IsNullOrWhiteSpace(txtCodFab.Text))
                Consulta += " AND CodFabrica='" + txtCodFab.Text.Trim() + "'";
            if (!string.IsNullOrWhiteSpace(txtNroLote.Text))
                Consulta += " AND Num_Lote='" + txtNroLote.Text.Trim() + "'";
            if (!string.IsNullOrWhiteSpace(txtSubgrupo.Text))
                Consulta += " AND NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
                Consulta += " AND NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtMarca.Text))
                Consulta += " AND Marca LIKE '%" + txtMarca.Text.Trim() + "%'";

            Consulta += " AND Vigente " + (chkCantVigente.Checked ? ">" : "=") + "0";
            
            dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);
        }

        private void Frm_Detalle_Vencimientos_Load(object sender, EventArgs e)
        {
            ListarSucursales();
            Buscar();
            NombreColumnas();
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Vencimiento";
            base.ImprLista(sql, nomtabla, "LISTA DE VENCIMIENTOS", Variable, "RptListaVencimientos", false);
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
            NombreColumnas();
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFecIni.Enabled = chkFechas.Checked;
            dtFecFin.Enabled = chkFechas.Checked;
        }

        private void chkFechaVenc_CheckedChanged(object sender, EventArgs e)
        {
            dtFechaVencIni.Enabled = chkFechaVenc.Checked;
            dtFechaVencFin.Enabled = chkFechaVenc.Checked;
        }

        private void Frm_Detalle_Vencimientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmdetvenc.Dispose();
            frmdetvenc = null;
        }

        private void dgvDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModif_Click(object sender, EventArgs e)
        {

        }
    }
}

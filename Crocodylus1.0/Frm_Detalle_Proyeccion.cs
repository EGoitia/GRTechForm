using System;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Proyeccion : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Proyeccion frmdetproy = null;
        private string Consulta = string.Empty;

        public Frm_Detalle_Proyeccion()
        {
            InitializeComponent();
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

        private void ListarVendedor()
        {
            try
            {
                cboVendedor.DataSource = DListarPersonalizado.ConsultarDT("SELECT PersonalID, NomPer FROM Vista_Personal WHERE CargoID in(2, 3)");
                cboVendedor.DisplayMember = "NomPer";
                cboVendedor.ValueMember = "PersonalID";
                cboVendedor.SelectedValue = OConexionGlobal.PersonalID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;
            dgvDetalle.Columns["VendedorID"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["ProyeccionID"].HeaderText = "Nº";
            dgvDetalle.Columns["NomProyeccion"].HeaderText = "Nombre";
            dgvDetalle.Columns["Proyectado"].HeaderText = "Monto Proyectado";
            dgvDetalle.Columns["DiasLaborales"].HeaderText = "Días Laborales";
            dgvDetalle.Columns["Ejecutado"].HeaderText = "Monto Ejecutado";
            dgvDetalle.Columns["PorcentAvance"].HeaderText = "% Avance";
            dgvDetalle.Columns["FecIni"].HeaderText = "Fecha Inic.";
            dgvDetalle.Columns["FecFin"].HeaderText = "Fecha Fin";
            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDetalle.Columns["NomPer"].HeaderText = "Vendedor";

            dgvDetalle.Columns["ProyeccionID"].FillWeight = 50;
            dgvDetalle.Columns["NomProyeccion"].FillWeight = 200;
            dgvDetalle.Columns["Proyectado"].FillWeight = 70;
            dgvDetalle.Columns["DiasLaborales"].FillWeight = 50;
            dgvDetalle.Columns["Ejecutado"].FillWeight = 70;
            dgvDetalle.Columns["PorcentAvance"].FillWeight = 70;
            dgvDetalle.Columns["FecIni"].FillWeight = 80;
            dgvDetalle.Columns["FecFin"].FillWeight = 80;

            dgvDetalle.Columns["Proyectado"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["DiasLaborales"].DefaultCellStyle.Format = "N0";
            dgvDetalle.Columns["Ejecutado"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["PorcentAvance"].DefaultCellStyle.Format = "N2";

            dgvDetalle.Columns["Proyectado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["DiasLaborales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns["Ejecutado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["PorcentAvance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public override void Buscar()
        {
            Consulta = "SELECT * FROM Vista_Proyeccion WHERE Estado='" + (!chkAnulado.Checked).ToString() + "'";

            if (chkFechas.Checked)
                Consulta += " AND CONVERT(DATE, FecIni) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                Consulta += " AND NomProyeccion LIKE '%" + txtNombre.Text.Trim() + "%'";
            if (numUpDownProyectado.Value > 0)
                Consulta += " AND Proyectado=" + numUpDownProyectado.Value;
            if (chkSucursal.Checked)
                Consulta += " AND SucursalID=" + cboSucursal.SelectedValue;
            if (chkVendedor.Checked)
                Consulta += " AND VendedorID=" + cboVendedor.SelectedValue;

            dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Frm_Reporte rep = new Frm_Reporte();
            rep.Llenar_Tabla("SELECT * FROM Vista_Proyeccion WHERE ProyeccionID='" + dgvDetalle["ProyeccionID", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Proyeccion");
            rep.Llenar_Tabla("SELECT * FROM Detalle_Proyecciones WHERE ProyeccionID='" + dgvDetalle["ProyeccionID", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Proyeccion");
            rep.Cargar(DConstantes.Imprimir.Nota_Proyeccion.NOM_REPORTE_NOTA_PROYECCION, false,
                       DConstantes.Imprimir.Nota_Proyeccion.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_Proyeccion.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_Proyeccion.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_Proyeccion.MOSTRAR_ARBOL,
                       (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
            rep.Show(); 
        }

        private void Frm_Detalle_Proyeccion_Load(object sender, EventArgs e)
        {
            ListarSucursal();
            ListarVendedor();
            Buscar();
            NombreColumnas();
        }

        private void Frm_Detalle_Proyeccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmdetproy.Dispose();
            frmdetproy = null;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Modificar("Proyeccion");
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Proyeccion";
            base.ImprLista(sql, nomtabla, "LISTA DE PROYECCIÓNES" + (chkAnulado.Checked ? " ANULADAS" : ""), Variable, "RptListaProyeccion", false);
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void chkVendedor_CheckedChanged(object sender, EventArgs e)
        {
            cboVendedor.Enabled = chkVendedor.Checked;
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["ProyeccionID", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("Proyeccion", "LA PROYECCIÓN Nº " + ID);
        }
    }
}

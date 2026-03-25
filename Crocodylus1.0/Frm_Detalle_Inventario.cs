using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Inventario : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Inventario frmdetinv = null;

        private string Consulta = string.Empty;

        public Frm_Detalle_Inventario()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["SucursalID"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["InventarioID"].HeaderText = "Nº";
            dgvDetalle.Columns["InventarioID"].FillWeight = 60;

            dgvDetalle.Columns["Fecha"].HeaderText = "Fecha";
            dgvDetalle.Columns["Fecha"].FillWeight = 90;

            dgvDetalle.Columns["Regul"].HeaderText = "Ajuste";
            dgvDetalle.Columns["Regul"].FillWeight = 90;

            dgvDetalle.Columns["Observacion"].HeaderText = "Observación";
            dgvDetalle.Columns["Observacion"].FillWeight = 300;
        }

        public override void Buscar()
        {
            Consulta = "SELECT * FROM Vista_Inventario WHERE Estado=1";

            if (chkFechas.Checked)
                Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
            if (chkAlmacen.Checked)
                Consulta += " AND SucursalID=" + cboAlmacen.SelectedValue;

            dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);
            NombreColumnas();
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            try
            {
                Frm_Reporte rep = new Frm_Reporte();
                rep.Dts.Clear();
                rep.Llenar_Tabla("SELECT * FROM Vista_Inventario WHERE InventarioID='" + dgvDetalle["InventarioID", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Inventario");
                rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Inventario WHERE InventarioID='" + dgvDetalle["InventarioID", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Inventario");
                rep.Cargar(DConstantes.Imprimir.Nota_Inventario.NOM_REPORTE_NOTA_INVENTARIO, false,
                           DConstantes.Imprimir.Nota_Inventario.MOSTRAR_BTN_IMP,
                           DConstantes.Imprimir.Nota_Inventario.MOSTRAR_BTN_COPIAR,
                           DConstantes.Imprimir.Nota_Inventario.MOSTRAR_BTN_EXPORT,
                           DConstantes.Imprimir.Nota_Inventario.MOSTRAR_ARBOL,
                           (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
                rep.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ListarSucursal()
        {
            try
            {
                cboAlmacen.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 ORDER BY NomSuc");
                cboAlmacen.DisplayMember = "NomSuc";
                cboAlmacen.ValueMember = "SucursalID";
                cboAlmacen.SelectedValue = OConexionGlobal.SucursalID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Detalle_Inventario_Load(object sender, EventArgs e)
        {
            ListarSucursal();
            Buscar();
        }
        
        private void chkAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            cboAlmacen.Enabled = chkAlmacen.Checked;
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Inventario";

            base.ImprLista(sql, nomtabla, "LISTA DE INVENTARIO", Variable, "RptListaInventario", false);
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["InventarioID", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("Inventario", "EL INVENTARIO Nº" + dgvDetalle["InventarioID", dgvDetalle.CurrentRow.Index].Value.ToString());
        }

        private void Frm_Detalle_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmdetinv.Dispose();
            frmdetinv = null;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                Frm_Detalle_Ajustes_Productos det_ajus = new Frm_Detalle_Ajustes_Productos((int)dgvDetalle["InventarioID", dgvDetalle.CurrentRow.Index].Value);
                det_ajus.ShowDialog();

                if (det_ajus.Regularizado)
                    Buscar();

                det_ajus.Dispose();
            }
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using Datos;
using Objetos;
using System.Drawing;

namespace GRTechnology1._0
{
    public partial class Frm_Descuento_Promocion : Form
    {
        public static Frm_Descuento_Promocion prec_prom = null;
        private DataTable DTSucursal = null;

        public Frm_Descuento_Promocion()
        {
            InitializeComponent();
        }

        private void BuscarProducto()
        {
            string Consulta = "SELECT TOP 100 ProductoID, CodFabrica, Marca, NomGrupo, NomSubGrupo, NomProd, UnidMedida, PVentaMenorEmp, " +
                          "PVentaMayorEmp FROM Vista_Productos WHERE Estado=1 AND NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";

            if (!string.IsNullOrWhiteSpace(txtCodFab.Text))
                Consulta += " AND CodFabrica LIKE '%" + txtCodFab.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
                Consulta += " AND NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtSubgrupo.Text))
                Consulta += " AND NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtMarca.Text))
                Consulta += " AND Marca LIKE '%" + txtMarca.Text.Trim() + "%'";

            Consulta += " ORDER BY Marca, NomGrupo, NomSubGrupo, NomProd";
            DataTable ProdDT = DListarPersonalizado.ConsultarDT(Consulta);

            dgvProductos.Rows.Clear();
            foreach (DataRow item in ProdDT.Rows)
            {
                dgvProductos.Rows.Add(chkSelecProd.Checked, item["ProductoID"], item["CodFabrica"], item["NomProd"], item["UnidMedida"],
                    item["NomGrupo"], item["NomSubgrupo"], item["Marca"]);
            }
        }

        private void BuscarPromocion()
        {
            string Consulta = "SELECT TOP 100 DescuentoID, CodInmode, ProductoID, CodFabrica, NomProd, UnidMedida, Marca, NomGrupo, NomSubGrupo, Porcentaje, " +
                              "Fecha_Ini, Fecha_Fin, NomSuc FROM Vista_Descuento_Promocional WHERE NomProd LIKE '%" + txtPromProducto.Text.Trim() + "%'";

            if (!string.IsNullOrWhiteSpace(txtPromCodFab.Text))
                Consulta += " AND CodFabrica LIKE '%" + txtPromCodFab.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtPromGrupo.Text))
                Consulta += " AND NomGrupo LIKE '%" + txtPromGrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtPromSubgrupo.Text))
                Consulta += " AND NomSubGrupo LIKE '%" + txtPromSubgrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtPromMarca.Text))
                Consulta += " AND Marca LIKE '%" + txtPromMarca.Text.Trim() + "%'";
            if ((int)cboPromSucursal.SelectedValue != -1)
                Consulta += " AND SucursalID=" + cboPromSucursal.SelectedValue.ToString();

            if (chkVigentes.Checked)
                Consulta += " AND Fecha_Fin >= GETDATE()";
            else
                Consulta += " AND Fecha_Fin < GETDATE()";

            Consulta += " ORDER BY Marca, NomGrupo, NomSubGrupo, NomProd";
            DataTable ProdDsctoDT = DListarPersonalizado.ConsultarDT(Consulta);

            dgvPromociones.Rows.Clear();
            foreach (DataRow item in ProdDsctoDT.Rows)
            {
                dgvPromociones.Rows.Add(item["DescuentoID"], item["CodInmode"], item["ProductoID"], item["CodFabrica"],
                    item["NomProd"], item["UnidMedida"], item["Marca"], item["NomGrupo"], item["NomSubGrupo"],
                     item["Porcentaje"], item["Fecha_Ini"], item["Fecha_Fin"], item["NomSuc"]);
            }
        }

        private void ListarSucursal()
        {
            try
            {
                DTSucursal = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 UNION SELECT -1, '[TODAS]' ORDER BY NomSuc");
                CargarSucursalesCombos();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR EN LA CONEXION CON EL SERVIDOR", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSucursalesCombos()
        {
            DataRow[] dtSucDscto = DTSucursal.Select();
            DataRow[] dtSucBusq = DTSucursal.Select();

            cboSucursal.DataSource = dtSucDscto.CopyToDataTable();
            cboSucursal.ValueMember = "SucursalID";
            cboSucursal.DisplayMember = "NomSuc";
            cboSucursal.Refresh();

            cboPromSucursal.DataSource = dtSucBusq.CopyToDataTable();
            cboPromSucursal.ValueMember = "SucursalID";
            cboPromSucursal.DisplayMember = "NomSuc";
            cboPromSucursal.SelectedValue = OConexionGlobal.SucursalID;
            cboPromSucursal.Refresh();
        }

        private void GuardarPromocion()
        {
            if (!Validar()) return;

            try
            {
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;

                DateTime dtini = new DateTime(dtFecIni.Value.Year, dtFecIni.Value.Month, dtFecIni.Value.Day, dtHrIni.Value.Hour, dtHrIni.Value.Minute, dtHrIni.Value.Second);
                DateTime dtfin = new DateTime(dtFecFin.Value.Year, dtFecFin.Value.Month, dtFecFin.Value.Day, dtHrFin.Value.Hour, dtHrFin.Value.Minute, dtHrFin.Value.Second);

                ODescuento_Promocional dsctoprod = new ODescuento_Promocional();
                dsctoprod.Fecha_Ini = dtini;
                dsctoprod.Fecha_Fin = dtfin;
                dsctoprod.Porcentaje = (float)txtDscto.Value;
                dsctoprod.SucursalID = (int)cboSucursal.SelectedValue;

                bool resp = DDescuento_Promocional.DInsertDescuentoProm(dsctoprod, AgregaDetalleProductos(), OInmode.DTInmode("", "NUEVO", ""));
                if (resp)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void AnularPromocion()
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA ANULAR?", "ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                Frm_DetaModifAnul anul = new Frm_DetaModifAnul("ANULAR");
                anul.ShowDialog();
                string DetInm = anul.DetaModAnul();
                if (anul.Cancelado)
                {
                    MessageBox.Show("CANCELADO POR EL USUARIO", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    for (int i = 0; i < dgvPromociones.Rows.Count; i++)
                    {
                        bool resp = DListarPersonalizado.AnulRestau(dgvPromociones["CPDescuentoID", i].Value.ToString(), "Dscto_Prom", "", DetInm, "ANULAR", false);
                        if (!resp)
                            throw new Exception("ERROR AL ANULAR EN LA FILA " + (i + 1).ToString());
                    }
                    BuscarPromocion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private DataTable AgregaDetalleProductos()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("ProductoID");
            dt.Columns.Add("StockAlmacen");
            dt.Columns.Add("Inventario");
                        
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                if ((bool)dgvProductos["CSeleccionar", i].Value)
                {
                    dr = dt.NewRow();
                    dr["ProductoID"] = dgvProductos["CProductoID", i].Value;
                    dt.Rows.Add(dr);
                }
            }

            if (dt.Rows.Count == 0)
                throw new Exception("SELECCIONE POR LO MENOS UN PRODUCTO DE LA LISTA");

            return dt;
        }

        private bool Validar()
        {
            if (txtDscto.Value <= 0)
            {
                MessageBox.Show("EL % DE DESCUENTO NO PUEDE SER MENOR O IGUAL A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDscto.Focus();
                return false;
            }
            else if (txtDscto.Value > 100)
            {
                MessageBox.Show("EL % DE DESCUENTO NO PUEDE SER MAYOR AL 100 %", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDscto.Focus();
                return false;
            }
            else if (cboSucursal.Text == "")
            {
                MessageBox.Show("SELECCIONE UNA SUCURSAL VÁLIDA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSucursal.Focus();
                return false;
            }
            else if (DateTime.Compare(Convert.ToDateTime(dtFecIni.Value.ToShortDateString()), Convert.ToDateTime(dtFecFin.Value.ToShortDateString())) > 0)
            {
                MessageBox.Show("LA FECHA INICIAL NO PUEDE SER MAYOR A LA FECHA FINAL", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtFecIni.Focus();
                return false;
            }
            else if (Convert.ToDateTime(dtFecIni.Value.ToShortDateString()) < DateTime.Now.Date) 
            {
                MessageBox.Show("LA FECHA INICIAL NO PUEDE SER MENOR AL DÍA DE HOY", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtFecIni.Focus();
                return false;
            }

            return true;
        }

        private void btnBuscarProm_Click(object sender, EventArgs e)
        {
            BuscarPromocion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPromocion();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void Frm_Descuento_Promocion_Load(object sender, EventArgs e)
        {
            ListarSucursal();
            BuscarPromocion();
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AnularPromocion();
        }

        private void chkSelecProd_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                for (int i = 0; i < dgvProductos.Rows.Count; i++)
                {
                    dgvProductos["CSeleccionar", i].Value = chkSelecProd.Checked;
                }
            }
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarProducto();
        }

        private void txtPromProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarPromocion();
        }

        private void dgvPromociones_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvPromociones.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }

        private void Frm_Descuento_Promocion_FormClosing(object sender, FormClosingEventArgs e)
        {
            prec_prom.Dispose();
            prec_prom = null;
        }

    }
}

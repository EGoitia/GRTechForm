using Datos;
using Objetos;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Inventario : Form
    {
        public static Frm_Inventario inv = null;

        private DataTable ProdCreadosDT = null;
        private bool Cargado = false;
        private string ConsultaSQL = string.Empty;

        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void Borrar()
        {
            CboAlmacen.SelectedValue = -1;
            chkInvInic.Checked = false;
            txtObs.Clear();
            ProdCreadosDT.Rows.Clear();
            DgvDetInv.Refresh();

            txtCodigo.Clear();
            txtProducto.Clear();
            txtMarca.Clear();
            txtGrupo.Clear();
            txtSubgrupo.Clear();
        }

        private void ImportarExcel()
        {
            if ((int)CboAlmacen.SelectedValue == -1)
            {
                CboAlmacen.Focus();
                MessageBox.Show("SELECCIONE UNA ALMACÉN", "ALMACEN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ImportarExcel imp = new ImportarExcel();
            imp.ShowDialog();
            
            if (!imp.Cancelado) // 'si le da cancelar salimos de la funcion
            {
                DialogResult dialog = MessageBox.Show("SE VAN A CREAR NUEVOS REGISTROS EN LA BASE DE DATOS, ¿SEGURO QUE DESEA IMPORTAR EL DOCUMENTO EXCEL?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    OleDbConnection con = null;
                    try
                    {
                        string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + imp.txtDireccion.Text.Trim() + "; Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
                        con = new OleDbConnection(constr);
                        OleDbCommand oconn = new OleDbCommand("Select * From [" + imp.txtHoja.Text.Trim() + "$]", con);
                        con.Open();

                        OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                        DataTable data = new DataTable();
                        sda.Fill(data);

                        string resp = DIngSalProducto.DInsertIngInventarioIni((int)CboAlmacen.SelectedValue, data, OInmode.DTInmode("", "NUEVO", "INVENTARIO INICIAL"));
                        if (resp != "-1")
                            MessageBox.Show(DConstantes.Mensajes.MensajeExito + ", EL Nº DE INGRESO ES: " + resp, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

            imp.Dispose();
        }

        private void HabilDesabilControles(bool habil)
        {
            GbxDatos.Enabled = habil;

            GbxBotones.Enabled = !habil;
            gbxFiltro.Enabled = !habil;
            txtObs.ReadOnly = habil;            
        }

        private void ListarSucursal()
        {
            try
            {
                CboAlmacen.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 UNION Select -1, '[SELECCIONE UN ALMACÉN]' ORDER BY NomSuc");
                CboAlmacen.DisplayMember = "NomSuc";
                CboAlmacen.ValueMember = "SucursalID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombreColumnas()
        {
            DgvDetInv.Columns["ProductoID"].HeaderText = "ID";
            DgvDetInv.Columns["ProductoID"].FillWeight = 50;
            DgvDetInv.Columns["ProductoID"].ReadOnly = true;

            DgvDetInv.Columns["CodFabrica"].HeaderText = "Código";
            DgvDetInv.Columns["CodFabrica"].FillWeight = 50;
            DgvDetInv.Columns["CodFabrica"].ReadOnly = true;

            DgvDetInv.Columns["Marca"].HeaderText = "Marca";
            DgvDetInv.Columns["Marca"].FillWeight = 150;
            DgvDetInv.Columns["Marca"].ReadOnly = true;

            DgvDetInv.Columns["NomGrupo"].HeaderText = "Grupo";
            DgvDetInv.Columns["NomGrupo"].FillWeight = 150;
            DgvDetInv.Columns["NomGrupo"].ReadOnly = true;

            DgvDetInv.Columns["NomSubGrupo"].HeaderText = "Subgrupo";
            DgvDetInv.Columns["NomSubGrupo"].FillWeight = 150;
            DgvDetInv.Columns["NomSubGrupo"].ReadOnly = true;

            DgvDetInv.Columns["NomProd"].HeaderText = "Producto";
            DgvDetInv.Columns["NomProd"].FillWeight = 250;
            DgvDetInv.Columns["NomProd"].ReadOnly = true;

            DgvDetInv.Columns["UnidMedida"].HeaderText = "Medida";
            DgvDetInv.Columns["UnidMedida"].FillWeight = 60;
            DgvDetInv.Columns["UnidMedida"].ReadOnly = true;

            DgvDetInv.Columns["StockAlmacen"].HeaderText = "Stock";
            DgvDetInv.Columns["StockAlmacen"].FillWeight = 80;
            DgvDetInv.Columns["StockAlmacen"].ReadOnly = true;
            DgvDetInv.Columns["StockAlmacen"].DefaultCellStyle.Format = "N2";
            DgvDetInv.Columns["StockAlmacen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DgvDetInv.Columns["Modif"].HeaderText = "Modif.";
            DgvDetInv.Columns["Modif"].FillWeight = 50;

            DgvDetInv.Columns["Inventario"].HeaderText = "Inventario";
            DgvDetInv.Columns["Inventario"].FillWeight = 80;
            DgvDetInv.Columns["Inventario"].DefaultCellStyle.Format = "N2";
            DgvDetInv.Columns["Inventario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DgvDetInv.Columns["Diferencia"].HeaderText = "Dif.";
            DgvDetInv.Columns["Diferencia"].FillWeight = 80;
            DgvDetInv.Columns["Diferencia"].ReadOnly = true;
            DgvDetInv.Columns["Diferencia"].DefaultCellStyle.Format = "N2";
            DgvDetInv.Columns["Diferencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void ListarProductos(string porcent)
        {
            try
            {
                ConsultaSQL = "SELECT TOP " + porcent + " PERCENT p.ProductoID, p.CodFabrica, p.Marca, p.NomGrupo, p.NomSubGrupo, p.NomProd, p.UnidMedida, s.StockAlmacen, " +
                    "CONVERT(BIT, 0) Modif, CONVERT(FLOAT, 0) Inventario, CONVERT(FLOAT, 0) Diferencia " +
                    "FROM Vista_Productos p INNER JOIN Stock_Prod s ON p.ProductoID=s.ProductoID WHERE p.Estado=1 AND s.AlmacenID=" + CboAlmacen.SelectedValue;

                //if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
                //    ConsultaSQL += " AND CodFabrica LIKE '%" + txtCodigo.Text.Trim() + "%'";
                //if (!string.IsNullOrWhiteSpace(txtProducto.Text))
                //    ConsultaSQL += " AND NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";
                //if (!string.IsNullOrWhiteSpace(txtMarca.Text))
                //    ConsultaSQL += " AND Marca LIKE '%" + txtMarca.Text.Trim() + "%'";
                //if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
                //    ConsultaSQL += " AND NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%'";
                //if (!string.IsNullOrWhiteSpace(txtSubgrupo.Text))
                //    ConsultaSQL += " AND NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";

                ProdCreadosDT = DListarPersonalizado.ConsultarDT(ConsultaSQL);
                DgvDetInv.DataSource = ProdCreadosDT;
                NombreColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guardar_Inventario()
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA GUARDAR EL INVENTARIO?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
                return;

            try
            {
                OInventario inv = new OInventario();
                inv.InventarioID = -1;
                inv.SucursalID = (int)CboAlmacen.SelectedValue;
                inv.Observacion = txtObs.Text.Trim();
                inv.DetalleInventarioDT = ProdCreadosDT.Select("Modif=1").CopyToDataTable();
                inv.DetalleInventarioDT.Columns.Remove("CodFabrica");
                inv.DetalleInventarioDT.Columns.Remove("Marca");
                inv.DetalleInventarioDT.Columns.Remove("NomGrupo");
                inv.DetalleInventarioDT.Columns.Remove("NomSubGrupo");
                inv.DetalleInventarioDT.Columns.Remove("NomProd");
                inv.DetalleInventarioDT.Columns.Remove("UnidMedida");
                inv.DetalleInventarioDT.Columns.Remove("Modif");
                inv.DetalleInventarioDT.Columns.Remove("Diferencia");

                int resp = DInventario.DInsertModifInventario(inv, OInmode.DTInmode("", "NUEVO", ""));
                if(resp > 0)
                {
                    MessageBox.Show(DConstantes.Mensajes.MensajeExito, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Borrar();
                    HabilDesabilControles(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {
            HabilDesabilControles(true);
            ListarSucursal();
            ListarProductos("0");

            Cargado = true;
        }

        private void CboAlmacen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cargado)
            {
                if ((int)CboAlmacen.SelectedValue > -1 && !chkInvInic.Checked)
                {
                    ListarProductos("100");
                    HabilDesabilControles(false);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                Borrar();
                HabilDesabilControles(true);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar_Inventario();
        }

        private void BtnImpr_Click(object sender, EventArgs e)
        {
            if (ConsultaSQL == string.Empty)
                return;

            Frm_Reporte rep = new Frm_Reporte();
            rep.Dts.Clear();
            rep.Llenar_Tabla(ConsultaSQL, "Lista_Productos");
            rep.Cargar("RepInventario", false);
            rep.Show();
        }

        private void DgvDetInv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDetInv.Rows.Count > 0)
            {
                if (DgvDetInv.Columns[e.ColumnIndex].Name == "Inventario" || DgvDetInv.Columns[e.ColumnIndex].Name == "Modif")
                {
                    if (!Cargado)
                        return;

                    Cargado = false;

                    if (DgvDetInv.Columns[e.ColumnIndex].Name == "Inventario")
                        DgvDetInv["Modif", e.RowIndex].Value = true;


                    if (!Convert.ToBoolean(DgvDetInv["Modif", e.RowIndex].Value))
                    {
                        DgvDetInv["Inventario", e.RowIndex].Value = 0;
                        DgvDetInv["Diferencia", e.RowIndex].Value = 0;
                    }
                    else
                    {
                        double stk, inv = 0;
                        double.TryParse(DgvDetInv["StockAlmacen", e.RowIndex].Value.ToString(), out stk);
                        double.TryParse(DgvDetInv["Inventario", e.RowIndex].Value.ToString(), out inv);
                        DgvDetInv["Diferencia", e.RowIndex].Value = inv - stk;
                    }                    

                    Cargado = true;
                }                 
            }
        }

        private void DgvDetInv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DgvDetInv.IsCurrentCellDirty)
                DgvDetInv.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void txtFiltroProd_TextChanged(object sender, EventArgs e)
        {
            ProdCreadosDT.DefaultView.RowFilter = "CodFabrica LIKE '%" + txtCodigo.Text.Trim() + "%' AND NomProd LIKE '%" + txtProducto.Text.Trim() + "%' " +
                "AND Marca LIKE '%" + txtMarca.Text.Trim() + "%' AND NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%' " +
                "AND NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";
        }

        private void DgvDetInv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void DgvDetInv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(DgvDetInv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }

            DataGridViewRow dgvr = DgvDetInv.Rows[e.RowIndex];
        }

        private void Frm_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            inv.Dispose();
            inv = null;
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            ImportarExcel();
        }

        private void btnFormatoExcel_Click(object sender, EventArgs e)
        {

        }

        private void chkInvInic_CheckedChanged(object sender, EventArgs e)
        {
            btnImportExcel.Enabled = chkInvInic.Checked;
            btnFormatoExcel.Enabled = chkInvInic.Checked;
        }
    }
}

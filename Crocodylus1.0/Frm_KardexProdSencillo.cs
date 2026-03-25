using System;
using System.Windows.Forms;
using Objetos;
using Datos;
using System.Data;
using System.Drawing;

namespace GRTechnology1._0
{
    public partial class Frm_KardexProdSencillo : Form
    {
        public static Frm_KardexProdSencillo kprod = null; 
        OpcionFormularios op = new OpcionFormularios();

        private DataTable LKProd = null;
        private Boolean Cargado = false;

        public Frm_KardexProdSencillo()
        {
            InitializeComponent();
        }


        #region Conexion Capa Negocio

        private void ListarAlmacenes()
        {
            try
            {
                cboAlmacen.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc");
                cboAlmacen.DisplayMember = "NomSuc";
                cboAlmacen.ValueMember = "SucursalID";
                cboAlmacen.SelectedValue = OConexionGlobal.SucursalID;
                cboAlmacen.Refresh();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarKardexProd()
        {
            if (!Cargado)
                return;
            else if (dgvProductos.Rows.Count == 0)
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                txtProductoID.Text = dgvProductos["ProductoID", dgvProductos.CurrentRow.Index].Value.ToString();
                lblNomProd.Text = dgvProductos["Producto", dgvProductos.CurrentRow.Index].Value.ToString();

                if ((int)dgvProductos["ClasificacionID", dgvProductos.CurrentRow.Index].Value != DConstantes.Clasificacion.Combo &&
                   (int)dgvProductos["ClasificacionID", dgvProductos.CurrentRow.Index].Value != DConstantes.Clasificacion.Servicio)
                {
                    CStock.Visible = true;
                    CSaldo.Visible = true;                    
                }
                else
                {
                    CStock.Visible = false;
                    CSaldo.Visible = false;
                }

                Int32 almacenid;
                if (chkAlmacen.Checked)
                    almacenid = (int)cboAlmacen.SelectedValue;
                else
                    almacenid = -1;

                string consulta = "Exec ListarKardexProd";
                if (cboTipoKardex.Text == "PEPS")
                    consulta += "_PEPS";
                consulta += " " + dgvProductos["ProductoID", dgvProductos.CurrentRow.Index].Value + ", " + (chkAlmacen.Checked ? cboAlmacen.SelectedValue : "-1");
                LKProd = DListarPersonalizado.ConsultarDT(consulta);
                CargarKardexProd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvkardexProd.Rows.Clear();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BuscaItem()
        {
            try
            {
                string ConsultaSQL = "SELECT TOP 100 p.ProductoID, p.CodFabrica, p.Marca, p.NomGrupo, p.NomSubGrupo, p.NomProd, p.UnidMedida, s.StockAlmacen, p.ClasificacionID " +
                    "FROM Vista_Productos p INNER JOIN Stock_Prod s ON p.ProductoID=s.ProductoID WHERE p.Estado=1";

                if (rbCodItem.Checked)
                {
                    int valor;
                    if (int.TryParse(txtBuscador.Text, out valor))
                        ConsultaSQL += " AND (p.ProductoID=" + txtBuscador.Text.Trim() + " OR CodFabrica LIKE '%" + txtBuscador.Text.Trim() + "%')";
                    else
                        ConsultaSQL += " AND CodFabrica LIKE '%" + txtBuscador.Text.Trim() + "%'";    
                }
                   
                if(rbNomItem.Checked)
                    ConsultaSQL += " AND NomProd LIKE '%" + txtBuscador.Text.Trim() + "%'";
                if (rbGrupo.Checked)
                    ConsultaSQL += " AND NomGrupo LIKE '%" + txtBuscador.Text.Trim() + "%'";
                if (rbSubgrupo.Checked)
                    ConsultaSQL += " AND NomSubGrupo LIKE '%" + txtBuscador.Text.Trim() + "%'";
                if(chkAlmacen.Checked)
                    ConsultaSQL += " AND s.AlmacenID=" + cboAlmacen.SelectedValue;

                ConsultaSQL += " ORDER BY s.StockAlmacen DESC, p.NomProd, p.NomGrupo, p.NomSubGrupo";

                dgvProductos.Rows.Clear();
                foreach (DataRow item in DListarPersonalizado.ConsultarDT(ConsultaSQL).Rows)
                {
                    dgvProductos.Rows.Add(item["ProductoID"], item["CodFabrica"], item["Marca"], item["NomGrupo"], item["NomSubGrupo"], 
                        item["NomProd"], item["UnidMedida"], item["StockAlmacen"], item["ClasificacionID"]);    
                }

                if (dgvProductos.Rows.Count == 0)
                    MessageBox.Show("NO SE ENCONTRÓ EL PRODUCTO EN LA BASE DE DATOS", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                dgvProductos.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarKardexProd()
        {
            if (LKProd != null)
            {
                dgvkardexProd.Rows.Clear();

                decimal stock = 0, saldo = 0, saldoant = 0, stockant = 0;
                foreach (DataRow item in LKProd.Rows)
                {
                    if (chkFechas.Checked)
                    {
                        int resp = DateTime.Compare(item.Field<DateTime>("Fecha"), dtFecInic.Value);
                        int resp2 = DateTime.Compare(item.Field<DateTime>("Fecha"), dtFecFin.Value);

                        if (resp < 0 && resp2 < 0)
                        {
                            if (rbtnKarProdIngr.Checked)
                            {
                                saldoant += (item.Field<decimal>("Entrada") * item.Field<decimal>("Costo"));
                                stockant += item.Field<decimal>("Entrada");
                            }
                            else if (rbtnKarProdSal.Checked)
                            {
                                saldoant += 0 - (item.Field<decimal>("Salida") * item.Field<decimal>("Costo"));
                                stockant += 0 - item.Field<decimal>("Salida");
                            }
                            else
                            {
                                saldoant += (item.Field<decimal>("Entrada") * item.Field<decimal>("Costo")) - (item.Field<decimal>("Salida") * item.Field<decimal>("Costo"));
                                stockant += item.Field<decimal>("Entrada") - item.Field<decimal>("Salida");
                            }
                            
                            continue;
                        }
                    }

                    if (rbtnKarProdIngr.Checked)
                    {
                        stock += item.Field<decimal>("Entrada");
                        saldo += (item.Field<decimal>("Entrada") * item.Field<decimal>("Costo"));

                        if (item.Field<decimal>("Entrada") == 0)
                            continue;
                    }
                    else if (rbtnKarProdSal.Checked)
                    {
                        stock += 0 - item.Field<decimal>("Salida");
                        saldo += 0 - (item.Field<decimal>("Salida") * item.Field<decimal>("Costo"));

                        if (item.Field<decimal>("Salida") == 0)
                            continue;
                    }
                    else
                    {
                        stock += item.Field<decimal>("Entrada") - item.Field<decimal>("Salida");
                        saldo += (item.Field<decimal>("Entrada") * item.Field<decimal>("Costo")) - (item.Field<decimal>("Salida") * item.Field<decimal>("Costo"));
                    }
                    

                    dgvkardexProd.Rows.Add(item.Field<string>("NomAlmacen"), item.Field<DateTime>("Fecha"), item.Field<string>("TipoDoc"),
                                           item.Field<string>("NroNota"), item.Field<string>("Referencia"), item.Field<decimal>("Entrada"),
                                           item.Field<decimal>("Salida"), (stock + stockant), item.Field<string>("Unidad"), item.Field<decimal>("Costo"),
                                           (item.Field<decimal>("Entrada") * item.Field<decimal>("Costo")), (item.Field<decimal>("Salida") * item.Field<decimal>("Costo")),
                                           (saldo + saldoant), "Impr.", item.Field<string>("CodNota"));
                }
                
                dgvkardexProd.Refresh();
                txtSaldoAnt.Text = string.Format("{0:#,##0.00}", saldoant);
                txtStockAnt.Text = string.Format("{0:#,##0.00}", stockant);

                if (dgvkardexProd.Rows.Count > 1)
                    dgvkardexProd.Rows[dgvkardexProd.Rows.Count - 1].Cells[3].Selected = true;
            }
            else
            {
                dgvkardexProd.Rows.Clear();
            }
        }

        #endregion

        #region Funciones

        private void ImprNota(int fila)
        {
            if (dgvkardexProd.Rows.Count > 0)
            {
                string CodNota = dgvkardexProd["CCodNota", fila].Value.ToString();
                
                Frm_Reporte rep = new Frm_Reporte();
                rep.Dts.Clear();

                switch (dgvkardexProd["CTipo", fila].Value.ToString())
                {
                    case "VENTA":                        
                        rep.Llenar_Tabla("SELECT * FROM Vista_Ventas WHERE CodVenta='" + CodNota + "'", "Lista_Venta");
                        rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + CodNota + "'", "Detalle_Venta");
                        rep.Cargar(DConstantes.Imprimir.Nota_Venta.NOM_REPORTE_NOTA_VENTA, false,
                                DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_IMP,
                                DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_COPIAR,
                                DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_EXPORT,
                                DConstantes.Imprimir.Nota_Venta.MOSTRAR_ARBOL,
                                (int)rep.Dts.Tables["Lista_Venta"].Rows[0]["SucursalID"]);                        
                        break;
                    case "SALIDA":
                    case "INGRESO":
                        rep.Titulo = "NOTA DE " + dgvkardexProd["CTipo", fila].Value.ToString() + " Nº ";
                        rep.Llenar_Tabla("SELECT * FROM Vista_IngSalProd WHERE CodIngSalProd='" + CodNota + "'", "Lista_IngrSal");
                        rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_IngSalProd WHERE CodIngSalProd='" + CodNota + "'", "Detalle_IngSalProd");
                        rep.Cargar(DConstantes.Imprimir.Nota_IngSalProd.NOM_REPORTE_NOTA_INGSALPROD, false,
                                DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_IMP,
                                DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_COPIAR,
                                DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_EXPORT,
                                DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_ARBOL,
                                (int)rep.Dts.Tables["Lista_IngrSal"].Rows[0]["SucursalID"]);
                        break;  
                    case "TRASPASO":
                        rep.Llenar_Tabla("SELECT * FROM Vista_Traspaso WHERE CodTraspaso='" + CodNota + "'", "Lista_Traspaso");
                        rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Traspaso WHERE CodTraspaso='" + CodNota + "'", "Detalle_Traspaso");
                        rep.Cargar(DConstantes.Imprimir.Nota_Traspaso.NOM_REPORTE_NOTA_TRASPASO, false,
                                DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_IMP,
                                DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_COPIAR,
                                DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_EXPORT,
                                DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_ARBOL,
                                (int)rep.Dts.Tables["Lista_Traspaso"].Rows[0]["DelAlmacenID"]);
                        break;
                    default:
                        MessageBox.Show("NO SE PUEDE IMPRIMIR ESTA NOTA", "IMPRIMIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }

                rep.Show();
            }
        }

        private void Imprimir()
        {
            if (dgvkardexProd.Rows.Count > 0)
            {
                DataRow filakardex;
                Frm_Reporte rep = new Frm_Reporte();
                rep.Dts.Clear();

                for (int i = 0; i < dgvkardexProd.Rows.Count; i++)
                {
                    filakardex = rep.Dts.Tables["Kardex_Producto"].NewRow();
                    filakardex["CodNota"] = dgvkardexProd["CCodNota", i].Value;
                    filakardex["Fecha"] = dgvkardexProd["CFecha", i].Value;
                    filakardex["Tipo"] = dgvkardexProd["CTipo", i].Value;
                    filakardex["NumRegistro"] = dgvkardexProd["CNumReg", i].Value;
                    filakardex["Referencia"] = dgvkardexProd["CReferencia", i].Value;
                    filakardex["Ingreso"] = dgvkardexProd["CIngreso", i].Value;
                    filakardex["Salida"] = dgvkardexProd["CSalida", i].Value;
                    filakardex["Stock"] = dgvkardexProd["CStock", i].Value;
                    filakardex["Costo"] = dgvkardexProd["CCosto", i].Value;
                    filakardex["Medida"] = dgvkardexProd["CUnidad", i].Value;
                    filakardex["Debe"] = dgvkardexProd["CDebe", i].Value;
                    filakardex["Haber"] = dgvkardexProd["CHaber", i].Value;
                    filakardex["Saldo"] = dgvkardexProd["CSaldo", i].Value;
                    filakardex["Detalle"] = "";
                    filakardex["ProductoID"] = txtProductoID.Text;
                    filakardex["NomProd"] = lblNomProd.Text;
                    filakardex["NomAlma"] = dgvkardexProd["CAlmacen", i].Value;
                    filakardex["StockAnt"] = txtStockAnt.Text;
                    filakardex["SaldoAnt"] = txtSaldoAnt.Text;

                    rep.Dts.Tables["Kardex_Producto"].Rows.Add(filakardex);
                }

                rep.Titulo = "KARDEX DE PRODUCTO";
                rep.Cargar("RptKardexProd", false);
                rep.Show();
            }
        }

        #endregion

        #region Eventos Formulario

        private void KardexProdSencillo_FormClosing(object sender, FormClosingEventArgs e)
        {
            kprod.Dispose();
            kprod = null;
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscaItem();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            BuscaItem();
        }
        
        private void btnImp_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        
        private void KardexProdSencillo_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            //cargamos datos por defecto
            cboTipoKardex.Text = "KARDEX";
            rbtnKarProd.Checked = true;
            //HabilitarCont();

            //listamos almacenes
            ListarAlmacenes();

            //fecha inicial menos 30 dias
            DateTime ayer = DateTime.Today.AddDays(-30);
            dtFecInic.Text = ayer.ToString();

            //Ponemos el Foco en el Buscador
            txtBuscador.Focus();
            Cargado = true;

            op.CerrarCargando();
        }
        
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarKardexProd();
        }

        private void chkAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            cboAlmacen.Enabled = chkAlmacen.Checked;
            CAlmacen.Visible = !chkAlmacen.Checked;

            BuscarKardexProd();
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            gbxFechas.Enabled = chkFechas.Checked;
            CargarKardexProd();
        }

        private void dtFec_ValueChanged(object sender, EventArgs e)
        {
            CargarKardexProd();
        }

        private void rbtnKarProdIngrSal_CheckedChanged(object sender, EventArgs e)
        {
            CargarKardexProd();
        }

        private void cboTipoKardex_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarKardexProd();
        }
        
        private void dgvkardexProd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvkardexProd.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                
                //Titulo
                hoja_trabajo.Range["A2:M2"].Merge();
                hoja_trabajo.Range["A2:M2"].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                hoja_trabajo.Range["A2:M2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                hoja_trabajo.Cells[2, 1] = "KARDEX DE PRODUCTO";

                //Datos Producto
                hoja_trabajo.Range["A5:D5"].Merge();
                hoja_trabajo.Cells[5, 1] = lblNomProd.Text;
                hoja_trabajo.Range["A5:D5"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                hoja_trabajo.Cells[5, 5] = "STOCK ANT.:";
                hoja_trabajo.Cells[5, 6] = txtStockAnt.Text;
                hoja_trabajo.Range["F5:F5"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                hoja_trabajo.Cells[5, 7] = "SANDO ANT.:";
                hoja_trabajo.Cells[5, 8] = txtSaldoAnt.Text;
                hoja_trabajo.Range["H5:H5"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //Recorremos el DataGridView rellenando la hoja de trabajo
                int fila = 7, columna = 0;
                for (int i = -1; i < dgvkardexProd.Rows.Count - 1; i++)
                {
                    columna = 1;
                    for (int j = 0; j < dgvkardexProd.Columns.Count - 2; j++)
                    {
                        if (!dgvkardexProd.Columns[j].Visible)
                            continue;

                        if (i == -1)
                        {
                            hoja_trabajo.Cells[fila, columna] = dgvkardexProd.Columns[j].HeaderText.ToUpper();
                            //hoja_trabajo.Columns[columna].ColumnWidth = dgvkardexProd.Columns[j].FillWeight - 60;
                        }
                        else
                            hoja_trabajo.Cells[fila, columna] = dgvkardexProd.Rows[i].Cells[j].Value.ToString();

                        columna++;
                    }
                    fila++;
                }

                //Encabezado
                hoja_trabajo.Range["A7:" + (columna == 13 ? "L7" : "M7")].Borders.Color = System.Drawing.Color.Black;
                hoja_trabajo.Range["A7:" + (columna == 13 ? "L7" : "M7")].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void dgvkardexProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13)
                ImprNota(e.RowIndex);
        }

        private void btnImpList_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnExpExcelList_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}

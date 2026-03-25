using System;
using System.Data;
using System.Windows.Forms;
using Objetos;
using Datos;
using System.Drawing;
using System.Speech.Recognition;
using System.Collections.Generic;

namespace GRTechnology1._0
{
    public partial class Frm_Base_Notas : Form
    {
        public bool Cargado = false;
        public string TipoNota = string.Empty;

        public DataTable ListProdLotesSeriesDT;
        private SpeechRecognitionEngine escuchar = null;

        private string bufferCodigo = "";
        private DateTime ultimaTecla = DateTime.Now;

        bool showModalProd = false;

        public Frm_Base_Notas()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public virtual void Totales()
        {

        }

        public virtual void Borrar()
        {
            dgvDetalle.Columns["RegSanitario"].Visible = false;
        }

        public virtual void InsertModifNota()
        { }

        public virtual void Imprimir(List<string> consultadet, List<string> nomconsultadet,
                                     string titulo, string nomrep, bool imp, bool visualizar = true, bool mostrarbtnimp = true,
                                     bool mostrarbtncopiar = true, bool mostrarbtnexport = true, bool mostrararbol = true)
        {
            Frm_Reporte rep = new Frm_Reporte();
            rep.Dts.Clear();
            rep.Titulo = titulo;

            int i = 0;
            foreach (var item in nomconsultadet)
            {
                rep.Llenar_Tabla(consultadet[i], item);
                i++;
            }

            rep.Cargar(nomrep, imp, mostrarbtnimp, mostrarbtncopiar, mostrarbtnexport, mostrararbol);

            if (visualizar)
                rep.ShowDialog();
            else
                rep.Dispose();
        }

        public void NombreColumnasDetalle()
        {
            dgvDetalle.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "CodDetalle";
            c0.Visible = false;
            dgvDetalle.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.FillWeight = 70;
            c1.Name = "ProductoID";
            c1.HeaderText = "Código";
            c1.MaxInputLength = 5;
            c1.SortMode = DataGridViewColumnSortMode.NotSortable;
            c1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.FillWeight = 300;
            c2.Name = "Producto";
            c2.ReadOnly = true;
            c2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDetalle.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.FillWeight = 60;
            c3.Name = "Medida";
            c3.ReadOnly = true;
            c3.SortMode = DataGridViewColumnSortMode.NotSortable;
            c3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.FillWeight = 60;
            c4.Name = "Stock";
            c4.ReadOnly = true;
            c4.SortMode = DataGridViewColumnSortMode.NotSortable;
            c4.DefaultCellStyle.Format = "N2";
            c4.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.FillWeight = 75;
            c5.MaxInputLength = 15;
            c5.Name = "Cantidad";
            c5.DefaultCellStyle.Format = "N2";
            c5.SortMode = DataGridViewColumnSortMode.NotSortable;
            c5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "UltPrecio";
            c6.Visible = false;
            dgvDetalle.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.FillWeight = 80;
            c7.Name = "Precio";
            c7.Visible = (TipoNota == "Traspaso" ? false : true);
            c7.MaxInputLength = 10;
            c7.DefaultCellStyle.Format = "N2";
            c7.SortMode = DataGridViewColumnSortMode.NotSortable;
            c7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Porcent_Dscto";
            c8.HeaderText = "% Dscto.";
            c8.MaxInputLength = 10;
            c8.FillWeight = 60;
            c8.ReadOnly = true;
            c8.DefaultCellStyle.Format = "N2";
            c8.SortMode = DataGridViewColumnSortMode.NotSortable;
            c8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c8.Visible = ((TipoNota == "Traspaso" || TipoNota == "IngSalProd" || TipoNota == "Compra") ? false : true);
            dgvDetalle.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.FillWeight = 60;
            c9.Name = "Dscto";
            c9.HeaderText = "Dscto.";
            c9.MaxInputLength = 10;
            c9.ReadOnly = (TipoNota == "Compra" ? false : true);
            c9.DefaultCellStyle.Format = "N2";
            c9.SortMode = DataGridViewColumnSortMode.NotSortable;
            c9.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            c9.Visible = ((TipoNota == "Traspaso" || TipoNota == "IngSalProd") ? false : true);
            dgvDetalle.Columns.Add(c9);

            DataGridViewTextBoxColumn c10 = new DataGridViewTextBoxColumn();
            c10.FillWeight = 80;
            c10.Name = "Importe";
            c10.ReadOnly = true;
            c10.Visible = (TipoNota == "Traspaso" ? false : true);
            c10.DefaultCellStyle.Format = "N2";
            c10.SortMode = DataGridViewColumnSortMode.NotSortable;
            c10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c10);

            DataGridViewCheckBoxColumn c11 = new DataGridViewCheckBoxColumn();
            c11.Name = "Vencimiento";
            c11.Visible = false;
            dgvDetalle.Columns.Add(c11);

            DataGridViewCheckBoxColumn c12 = new DataGridViewCheckBoxColumn();
            c12.Name = "Serial";
            c12.Visible = false;
            dgvDetalle.Columns.Add(c12);

            DataGridViewTextBoxColumn c13 = new DataGridViewTextBoxColumn();
            c13.Name = "RegSanitario";
            c13.HeaderText = "Reg. Sanitario";
            c13.Visible = false;
            dgvDetalle.Columns.Add(c13);

            DataGridViewTextBoxColumn c14 = new DataGridViewTextBoxColumn();
            c14.Name = "ClasificacionID";
            c14.Visible = false;
            dgvDetalle.Columns.Add(c14);

            DataGridViewTextBoxColumn c15 = new DataGridViewTextBoxColumn();
            c15.Name = "Comodin";
            c15.Visible = false;
            dgvDetalle.Columns.Add(c15);

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Visible = false;
            img.Name = "Imagen";
            dgvDetalle.Columns.Add(img);
        }

        private void NombreColumnasLotes_Series()
        {
            ListProdLotesSeriesDT = new DataTable();
            ListProdLotesSeriesDT.Columns.Add("ProductoID", Type.GetType("System.Int32"));
            ListProdLotesSeriesDT.Columns.Add("NomProd", Type.GetType("System.String"));
            ListProdLotesSeriesDT.Columns.Add("UnidMedida", Type.GetType("System.String"));
            ListProdLotesSeriesDT.Columns.Add("Cantidad", Type.GetType("System.Decimal"));
            ListProdLotesSeriesDT.Columns.Add("EsLote", Type.GetType("System.Boolean"));
            ListProdLotesSeriesDT.Columns.Add("Estado", Type.GetType("System.Boolean"));
            ListProdLotesSeriesDT.Columns["Estado"].DefaultValue = true;
        }

        private void InsertLotes_Series()
        {
            DataTable LotesSeriesDT = null;

            if ((int)ListProdLotesSeriesDT.Compute("COUNT(ProductoID)", "EsLote=1") > 0)
            {
                DataRow[] drs = ListProdLotesSeriesDT.Select("EsLote=1");

                // Crear una tabla nueva manteniendo la estructura de la original
                DataTable dt2 = ListProdLotesSeriesDT.Clone();

                // Importando las filas.
                foreach (DataRow d in drs)
                {
                    dt2.ImportRow(d);
                }

                Frm_Lote lote = new Frm_Lote();
                lote.ListaProdDT = dt2;
                lote.ShowDialog();

                if (lote.Cancelado)
                    throw new Exception("CANCELADO POR EL USUARIO");
                else
                    LotesSeriesDT = lote.LotesSeriesDT;
            }

            if ((int)ListProdLotesSeriesDT.Compute("COUNT(ProductoID)", "EsLote=0") > 0)
            {
                DataRow[] drs = ListProdLotesSeriesDT.Select("EsLote=0");

                // Crear una tabla nueva manteniendo la estructura de la original
                DataTable dt2 = ListProdLotesSeriesDT.Clone();

                // Importando las filas.
                foreach (DataRow d in drs)
                {
                    dt2.ImportRow(d);
                }

                Frm_Series serie = new Frm_Series();
                serie.ListaProdDT = dt2;
                serie.ShowDialog();

                if (serie.Cancelado)
                    throw new Exception("CANCELADO POR EL USUARIO");
                else
                {
                    if (LotesSeriesDT == null)
                        LotesSeriesDT = serie.LotesSeriesDT;
                    else
                    {
                        foreach (DataRow item in serie.LotesSeriesDT.Rows)
                        {
                            LotesSeriesDT.ImportRow(item);
                        }
                    }
                }
            }
        }

        public DataTable InsertDetalle()
        {
            DataTable DetDT = new DataTable();
            DataRow Fila;
            DetDT.Columns.Add("CodDetalle");
            DetDT.Columns.Add("ProductoID");
            DetDT.Columns.Add("DescProd");
            DetDT.Columns.Add("Detalle");
            DetDT.Columns.Add("Cantidad");
            DetDT.Columns.Add("PUnitario");
            DetDT.Columns.Add("Costo_Calc");
            DetDT.Columns.Add("Porcent_Dscto");
            DetDT.Columns.Add("Dscto");
            DetDT.Columns.Add("RegSanitario");
            DetDT.Columns.Add("Estado");

            if (ListProdLotesSeriesDT != null)
                ListProdLotesSeriesDT.Rows.Clear();

            for (int i = 0; i < (dgvDetalle.AllowUserToAddRows ? dgvDetalle.Rows.Count - 1 : dgvDetalle.Rows.Count); i++)
            {
                Fila = DetDT.NewRow();

                Fila["CodDetalle"] = Convert.ToInt64(dgvDetalle["CodDetalle", i].Value);
                Fila["ProductoID"] = Convert.ToInt32(dgvDetalle["ProductoID", i].Value);
                Fila["DescProd"] = dgvDetalle["Producto", i].Value.ToString();
                Fila["Cantidad"] = Convert.ToDecimal(dgvDetalle["Cantidad", i].Value);
                Fila["PUnitario"] = Convert.ToDecimal(dgvDetalle["Precio", i].Value);
                Fila["Porcent_Dscto"] = Convert.ToDecimal(dgvDetalle["Porcent_Dscto", i].Value);
                Fila["Dscto"] = Convert.ToDecimal(dgvDetalle["Dscto", i].Value);
                Fila["RegSanitario"] = dgvDetalle["RegSanitario", i].Value;
                Fila["Estado"] = Convert.ToBoolean(dgvDetalle["Cantidad", i].Visible);
                DetDT.Rows.Add(Fila);

                //if (((bool)dgvDetalle["Vencimiento", i].Value) || ((bool)dgvDetalle["Serial", i].Value))
                //{
                //    if (ListProdLotesSeriesDT == null)
                //        NombreColumnasLotes_Series();

                //    Fila = ListProdLotesSeriesDT.NewRow();
                //    Fila["ProductoID"] = Convert.ToInt32(dgvDetalle["ProductoID", i].Value);
                //    Fila["NomProd"] = dgvDetalle["Producto", i].Value.ToString();
                //    Fila["UnidMedida"] = dgvDetalle["Medida", i].Value.ToString();
                //    Fila["Cantidad"] = Convert.ToDecimal(dgvDetalle["Cantidad", i].Value);
                //    Fila["EsLote"] = ((bool)dgvDetalle["Vencimiento", i].Value ? true : false);
                //    ListProdLotesSeriesDT.Rows.Add(Fila);
                //}
            }

            return DetDT;
        }

        public void Agregar_ProductoDGV(long _cod_deta, int _prodid, string _nom_prod, string _medida, decimal _stk, decimal _cant, decimal _ult_precio,
            decimal _precio, decimal _porcent_dscto, decimal _dscto, int _clasificacionid, bool _venc = false, bool _serial = false, string _regsanit = "",
            Image _img = null, bool _comodin = false)
        {
            int fila_producto_lista = Existe_Prod_Lista(_prodid.ToString(), -1);

            if (fila_producto_lista == 0)
            {
                dgvDetalle.Rows.Add(_cod_deta, _prodid, _nom_prod, _medida, _stk, _cant, _ult_precio, _precio, _porcent_dscto, _dscto, (_cant * _precio) - _dscto, _venc, _serial, _regsanit, _clasificacionid, _comodin, _img);

                if (_venc)
                    dgvDetalle.Columns["RegSanitario"].Visible = true;
            }
            else
                MessageBox.Show("EL PRODUCTO YA SE ENCUENTRA EN LA LISTA, VERIFIQUE LA FILA " + fila_producto_lista.ToString(),
                    "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Totales();
            //dgvDetalle.Focus();
            //dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.CurrentRow.Index].Cells["Cantidad"];
        }

        public void ListarProductos()
        {
            try
            {
                string ConsultaSQL = "SELECT TOP 50 p.ProductoID, p.CodFabrica, p.Marca, p.NomGrupo, p.NomSubGrupo, p.NomProd, p.UnidMedida, " +
                    "s.StockAlmacen, p.PCostoEmp, p.PVentaMenorEmp, p.PVentaMayorEmp, p.Vencimiento, p.Serial, p.Comodin, p.RegSanitario, p.ClasificacionID " +
                    "FROM Vista_Productos p INNER JOIN Stock_Prod s ON p.ProductoID=s.ProductoID WHERE p.Estado=1 AND s.AlmacenID=" + OConexionGlobal.SucursalID;

                if (TipoNota == "IngSalProd" || TipoNota == "Compra")
                    ConsultaSQL += " AND p.ClasificacionID NOT IN(1018, 1020)"; //COMBOS, SERVICIOS

                if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    int prodid;
                    if (int.TryParse(txtCodigo.Text, out prodid))
                        ConsultaSQL += " AND (p.ProductoID=" + txtCodigo.Text.Trim() + " OR p.CodFabrica LIKE '%" + txtCodigo.Text.Trim() + "%')";
                    else
                        ConsultaSQL += " AND p.CodFabrica LIKE '%" + txtCodigo.Text.Trim() + "%'";
                }

                if (!string.IsNullOrWhiteSpace(txtProducto.Text))
                    ConsultaSQL += " AND NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";
                if (!string.IsNullOrWhiteSpace(txtMarca.Text))
                    ConsultaSQL += " AND Marca LIKE '%" + txtMarca.Text.Trim() + "%'";
                if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
                    ConsultaSQL += " AND NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%'";
                if (!string.IsNullOrWhiteSpace(txtSubgrupo.Text))
                    ConsultaSQL += " AND NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";

                ConsultaSQL += "ORDER BY s.StockAlmacen DESC, p.NomGrupo, p.NomSubGrupo, p.NomProd, p.UnidMedida";

                dgvProd.Rows.Clear();
                foreach (DataRow item in DListarPersonalizado.ConsultarDT(ConsultaSQL).Rows)
                {
                    dgvProd.Rows.Add(item["ProductoID"], item["NomProd"], item["UnidMedida"], item["PVentaMenorEmp"], item["PVentaMayorEmp"], item["PCostoEmp"],
                        "Código: " + item["CodFabrica"] + Environment.NewLine + "Marca: " + item["Marca"] + Environment.NewLine +
                        "Grupo: " + item["NomGrupo"] + Environment.NewLine + "Subgrupo: " + item["NomSubGrupo"] + Environment.NewLine +
                        "Produco: " + item["NomProd"] + Environment.NewLine + "Medida: " + item["UnidMedida"] +
                        ((item.Field<bool>("Vencimiento") && (!string.IsNullOrEmpty(item["RegSanitario"].ToString()))) ? Environment.NewLine + "Reg. Sanitario:" + item["RegSanitario"] : ""),
                        item["StockAlmacen"], item["Vencimiento"], item["Serial"], item["Comodin"], item["RegSanitario"], item["ClasificacionID"]);
                }

                if (dgvProd.Rows.Count == 0)
                    MessageBox.Show("NO SE ENCONTRÓ EL PRODUCTO EN LA BASE DE DATOS", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                dgvProd.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AbrirCerrarPanelBusqProd()
        {
            if (panelBusqProd.Width == 317)
            {
                panelBusqProd.Width = 41;
                dgvProd.Visible = false;
                panel2.Visible = false;
                panelBusqProd.BackColor = panelSup.BackColor;
            }
            else
            {
                panelBusqProd.Width = 317;
                dgvProd.Visible = true;
                panel2.Visible = true;
                panelBusqProd.BackColor = Control.DefaultBackColor;
            }

            ListProdStock.FillWeight = 50;
        }

        private void BuscarProdXCod(string cod, int fila)
        {
            int fila_producto_lista = Existe_Prod_Lista(cod, fila);
            if (fila_producto_lista == 0)
            {
                try
                {
                    int valorcodigo;
                    int.TryParse(cod, out valorcodigo);

                    DataTable dtprod = DListarPersonalizado.ConsultarDT("SELECT TOP 1 p.ProductoID, p.CodFabrica, p.NomProd, p.UnidMedida, " +
                        "s.StockAlmacen, p.PCostoEmp, p.PVentaMenorEmp, p.PVentaMayorEmp, p.Vencimiento, p.Serial FROM Vista_Productos p " +
                        "INNER JOIN Stock_Prod s ON p.ProductoID=s.ProductoID WHERE p.Estado=1 AND " + (valorcodigo > 0 ? "p.ProductoID=" + cod : "p.CodFabrica='" + cod + "' ") +
                        "AND s.AlmacenID=" + OConexionGlobal.SucursalID);

                    if (dtprod.Rows.Count > 0)
                    {
                        dgvDetalle["CodDetalle", fila].Value = -1;
                        dgvDetalle["Producto", fila].Value = dtprod.Rows[0]["NomProd"];
                        dgvDetalle["Medida", fila].Value = dtprod.Rows[0]["UnidMedida"];
                        dgvDetalle["Stock", fila].Value = dtprod.Rows[0]["StockAlmacen"];
                        dgvDetalle["Cantidad", fila].Value = "0";
                        dgvDetalle["Vencimiento", fila].Value = dtprod.Rows[0]["Vencimiento"];
                        dgvDetalle["Serial", fila].Value = dtprod.Rows[0]["Serial"];

                        if (TipoNota == "Venta")
                        {
                            try
                            {
                                var resp_porcent_dscto = DListarPersonalizado.Dato("Select Porcentaje From Descuento_Promocional Where Estado=1 And Fecha_Fin >= GETDATE()" +
                                    " And ProductoID=" + cod + " And SucursalID=" + OConexionGlobal.SucursalID);

                                dgvDetalle["Porcent_Dscto", fila].Value = (resp_porcent_dscto == null ? 0 : Convert.ToDecimal(resp_porcent_dscto));
                            }
                            catch (Exception)
                            {
                            }
                        }

                        if (TipoNota != "Venta")
                            dgvDetalle["Precio", fila].Value = dtprod.Rows[0]["PCostoEmp"];
                        else
                        {
                            dgvDetalle["Precio", fila].Value = dtprod.Rows[0]["PVentaMenorEmp"];
                            dgvDetalle["UltPrecio", fila].Value = dtprod.Rows[0]["PVentaMayorEmp"];
                        }

                        dgvDetalle.CurrentCell = dgvDetalle.Rows[fila].Cells["Cantidad"];
                    }
                    else
                    {
                        MessageBox.Show("NO SE ENCONTRÓ NINGÚN PRODUCTO CON ESTE CÓDIGO", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDetalle.Rows.RemoveAt(fila);
                        dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["ProductoID"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("EL PRODUCTO YA SE ENCUENTRA EN LA LISTA, VERIFIQUE LA FILA " + fila_producto_lista.ToString(),
                "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDetalle.Rows.RemoveAt(fila);
                dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells["ProductoID"];
            }
        }

        private void BuscarProdXCodBarra()
        {
            try
            {
                DataTable dtprod = DListarPersonalizado.ConsultarDT("SELECT TOP 1 p.ProductoID, p.CodFabrica, p.NomProd, p.UnidMedida, " +
                    "s.StockAlmacen, p.PCostoEmp, p.PVentaMenorEmp, p.PVentaMayorEmp, p.Vencimiento, p.Serial, p.Comodin, p.ClasificacionID, p.RegSanitario " +
                    "FROM Vista_Productos p INNER JOIN Stock_Prod s ON p.ProductoID=s.ProductoID WHERE p.Estado=1 AND p.CodFabrica='" + txtCodBarra.Text.Trim() + "' " +
                    "AND s.AlmacenID=" + OConexionGlobal.SucursalID);

                if (dtprod.Rows.Count > 0)
                {
                    decimal ultprecio = 0;
                    decimal precio = 0;
                    decimal porcdscto = 0;
                    decimal cantidad = 1;
                    decimal dscto = 0;
                    string nomprod = dtprod.Rows[0]["NomProd"].ToString();

                    if (TipoNota == "Venta")
                    {
                        if (Convert.ToDecimal(dtprod.Rows[0]["StockAlmacen"]) == 0 &&
                            !Convert.ToBoolean(dtprod.Rows[0]["Comodin"]) &&
                            DConstantes.Clasificacion.Combo != Convert.ToInt32(dtprod.Rows[0]["ClasificacionID"]) &&
                            DConstantes.Clasificacion.Servicio != Convert.ToInt32(dtprod.Rows[0]["ClasificacionID"]))
                        {
                            MessageBox.Show("NO TIENE STOCK SUFICIENTE", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        try
                        {
                            var resp_porcent_dscto = DListarPersonalizado.Dato("Select Porcentaje From Descuento_Promocional Where Estado=1 And Fecha_Fin >= GETDATE()" +
                                " And ProductoID=" + dtprod.Rows[0]["ProductoID"].ToString() + " And SucursalID=" + OConexionGlobal.SucursalID);

                            porcdscto = (resp_porcent_dscto == null ? 0 : Convert.ToDecimal(resp_porcent_dscto));
                        }
                        catch (Exception)
                        {
                        }
                    }

                    if (TipoNota != "Venta")
                        precio = Convert.ToDecimal(dtprod.Rows[0]["PCostoEmp"]);
                    else
                    {
                        precio = Convert.ToDecimal(dtprod.Rows[0]["PVentaMenorEmp"]);
                        ultprecio = Convert.ToDecimal(dtprod.Rows[0]["PVentaMayorEmp"]);
                    }

                    if (showModalProd || Convert.ToBoolean(dtprod.Rows[0]["Comodin"]))
                    {
                        Frm_SelectProducto selecprod = new Frm_SelectProducto();
                        selecprod.txtCodigo.Text = txtCodBarra.Text;
                        selecprod.txtProducto.Enabled = Convert.ToBoolean(dtprod.Rows[0]["Comodin"]);
                        selecprod.txtProducto.Text = nomprod;
                        selecprod.txtCantidad.Value = cantidad;
                        selecprod.txtPrecio.Value = precio;
                        selecprod.txtDscto.Enabled = porcdscto == 0;
                        selecprod.txtDscto.Value = (porcdscto == 0 ? 0 : Math.Round(cantidad * precio * porcdscto / 100, 2));
                        selecprod.txtTotal.Value = precio;
                        selecprod.ShowDialog();
                        if (!selecprod.Cancelado)
                        {
                            nomprod = selecprod.txtProducto.Text;
                            cantidad = selecprod.txtCantidad.Value;
                            precio = selecprod.txtPrecio.Value;
                            dscto = selecprod.txtDscto.Value;
                        }
                        else
                        {
                            selecprod.Dispose();
                            //MessageBox.Show("CANCELADO POR EL USUARIO", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        selecprod.Dispose();
                    }

                    Agregar_ProductoDGV(-1, Convert.ToInt32(dtprod.Rows[0]["ProductoID"]), nomprod,
                        dtprod.Rows[0]["UnidMedida"].ToString(), Convert.ToDecimal(dtprod.Rows[0]["StockAlmacen"]), cantidad, ultprecio,
                        precio, porcdscto, dscto, Convert.ToInt32(dtprod.Rows[0]["ClasificacionID"]), Convert.ToBoolean(dtprod.Rows[0]["Vencimiento"]),
                        Convert.ToBoolean(dtprod.Rows[0]["Serial"]), dtprod.Rows[0]["RegSanitario"].ToString(), null, Convert.ToBoolean(dtprod.Rows[0]["Comodin"]));

                    txtCodBarra.Clear();
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRÓ NINGÚN PRODUCTO CON ESTE CÓDIGO", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtCodBarra.Focus();
                txtCodBarra.SelectAll();
            }
        }

        private int Existe_Prod_Lista(string coditem, int fila)
        {
            for (int i = 0; i < dgvDetalle.Rows.Count - 1; i++)
            {
                if ((fila >= 0) && (fila == i))
                    continue;
                if (dgvDetalle["ProductoID", i].Value == null)
                    continue;

                if (dgvDetalle["ProductoID", i].Value.ToString() == coditem)
                    return i + 1;
            }

            return 0;
        }

        private void Frm_Base_Notas_Load(object sender, EventArgs e)
        {
            btnAbriCerrarPanel.PerformClick();

            showModalProd = Convert.ToBoolean(DListarPersonalizado.Dato("SELECT Valor FROM Configuracion WHERE Variable='SHOW_MODAL_ADD_PROD_NOTA'"));

            //AbrirCerrarPanel();
            NombreColumnasDetalle();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            dgvProd.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
            ListarProductos();
            txtCodBarra.Focus();
        }

        private void btnAbriCerrarPanel_Click(object sender, EventArgs e)
        {
            AbrirCerrarPanelBusqProd();
        }

        private void txtBusqProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ListarProductos();
        }

        private void dgvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProd.Rows.Count > 0)
            {
                int fila = dgvProd.CurrentRow.Index;
                decimal ult_prec = Convert.ToDecimal(dgvProd[(TipoNota == "Venta" ? "ListProdPrecio2" : "ListProdCosto"), fila].Value);
                decimal prec = Convert.ToDecimal(dgvProd[(TipoNota == "Venta" ? "ListProdPrecio" : "ListProdCosto"), fila].Value);
                decimal porcent_dscto = 0;
                decimal dscto = 0;
                decimal cantidad = 1;
                string nomprod = dgvProd["ListProdNomProd", fila].Value.ToString();

                if (TipoNota == "Venta")
                {
                    try
                    {
                        var resp_porcent_dscto = DListarPersonalizado.Dato("Select Porcentaje From Descuento_Promocional Where Estado=1 And Fecha_Fin >= GETDATE()" +
                            " And ProductoID=" + dgvProd["ListProdProdID", fila].Value.ToString() +
                            " And SucursalID=" + OConexionGlobal.SucursalID);

                        porcent_dscto = (resp_porcent_dscto == null ? 0 : Convert.ToDecimal(resp_porcent_dscto));
                    }
                    catch (Exception)
                    {
                    }
                }

                if (showModalProd || Convert.ToBoolean(dgvProd["ListProdComodin", fila].Value))
                {
                    Frm_SelectProducto selecprod = new Frm_SelectProducto();
                    selecprod.txtCodigo.Text = dgvProd["ListProdProdID", fila].Value.ToString();
                    selecprod.txtProducto.Enabled = Convert.ToBoolean(dgvProd["ListProdComodin", fila].Value);
                    selecprod.txtProducto.Text = nomprod;
                    selecprod.txtCantidad.Value = cantidad;
                    selecprod.txtPrecio.Value = prec;
                    selecprod.txtDscto.Enabled = porcent_dscto == 0;
                    selecprod.txtDscto.Value = (porcent_dscto == 0 ? 0 : Math.Round(cantidad * prec * porcent_dscto / 100, 2));
                    selecprod.txtTotal.Value = prec;
                    selecprod.ShowDialog();
                    if (!selecprod.Cancelado)
                    {
                        cantidad = selecprod.txtCantidad.Value;
                        prec = selecprod.txtPrecio.Value;
                        dscto = selecprod.txtDscto.Value;
                        nomprod = selecprod.txtProducto.Text;
                    }
                    else
                    {
                        selecprod.Dispose();
                        //MessageBox.Show("CANCELADO POR EL USUARIO", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    selecprod.Dispose();
                }

                Agregar_ProductoDGV(-1, (int)dgvProd["ListProdProdID", fila].Value, nomprod, dgvProd["ListProdUnidad", fila].Value.ToString(),
                    Convert.ToDecimal(dgvProd["ListProdStock", fila].Value), cantidad, ult_prec, prec, porcent_dscto, dscto, Convert.ToInt32(dgvProd["ListProdClasificacion", fila].Value),
                    (bool)dgvProd["ListProdVencimiento", fila].Value, (bool)dgvProd["ListProdSerial", fila].Value, dgvProd["ListProdRegSanitario", fila].Value.ToString(), null,
                    (bool)dgvProd["ListProdComodin", fila].Value);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogo == DialogResult.Yes)
                Borrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifNota();
        }

        private void dgvDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0 && e.RowIndex > -1)
                Totales();
        }

        private void dgvDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDetalle.IsCurrentCellDirty)
                dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            if (e.KeyCode == Keys.Delete) // para eliminar la fila
            {
                DialogResult result = MessageBox.Show("ESTÁ SEGURO QUE DESEA ELIMINAR ESTA FILA?", "ELIMINAR FILA",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    //eliminamos la fila seleccionada
                    dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
                    Totales();
                }
            }
        }

        private void dgvDetalle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvDetalle.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentCell.ColumnIndex == 1)    //Columna ProductoID
            {
                if (dgvDetalle["ProductoID", e.RowIndex].Value != null)
                {
                    BuscarProdXCod(dgvDetalle["ProductoID", dgvDetalle.CurrentRow.Index].Value.ToString(), dgvDetalle.CurrentRow.Index);
                    Totales();
                }
            }
            else if ((dgvDetalle.CurrentCell.ColumnIndex == 7) && (TipoNota == "Venta"))
            {
                if (DConstantes.General.RESTRING_PRECIOS_VENTAS)
                {
                    if (Convert.ToDecimal(dgvDetalle["Precio", dgvDetalle.CurrentRow.Index].Value) < Convert.ToDecimal(dgvDetalle["UltPrecio", dgvDetalle.CurrentRow.Index].Value))
                    {
                        MessageBox.Show("ERROR EN LA FILA " + (dgvDetalle.CurrentRow.Index + 1) + ", EL PRECIO UNITARIO NO PUEDE SER MENOR QUE " + string.Format("{0:#,##0.00}", dgvDetalle["UltPrecio", dgvDetalle.CurrentRow.Index].Value), "PRECIO UNITARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDetalle["Precio", dgvDetalle.CurrentRow.Index].Value = dgvDetalle["UltPrecio", dgvDetalle.CurrentRow.Index].Value;
                    }
                }
            }
        }

        private void dgvDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int Col = dgvDetalle.CurrentCell.ColumnIndex;

            if ((Col == 5) || (Col == 7))   //Cantidad o Precio solo números
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dgvDetalle_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dgvDetalle_KeyPress);
                }
            }
        }

        private void dgvDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            int Col = dgvDetalle.CurrentCell.ColumnIndex;
            if ((Col == 5) || (Col == 7))   //Cantidad o Precio solo números
            {
                if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void btnReconocer_Click(object sender, EventArgs e)
        {
            try
            {
                escuchar = new SpeechRecognitionEngine();
                escuchar.SetInputToDefaultAudioDevice();
                escuchar.LoadGrammar(new DictationGrammar());
                escuchar.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Lector);
                escuchar.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lector(object sender, SpeechRecognizedEventArgs e)
        {
            string pal = string.Empty;
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                if (palabra.Text == "uno")
                    pal = "1";
                else if (palabra.Text == "dos")
                    pal = "2";
                else if (palabra.Text == "tres")
                    pal = "3";
                else if (palabra.Text == "cuatro")
                    pal = "4";
                else if (palabra.Text == "cinco")
                    pal = "5";
                else if (palabra.Text == "seis")
                    pal = "6";
                else if (palabra.Text == "siete")
                    pal = "7";
                else if (palabra.Text == "ocho")
                    pal = "8";
                else if (palabra.Text == "nueve")
                    pal = "9";
                else if (palabra.Text == "cero")
                    pal = "0";
                else
                    pal = palabra.Text;
            }

            txtCodigo.Text += pal;
        }

        private void Frm_Base_Notas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                InsertModifNota();
            else if (e.KeyCode == Keys.F1)
                txtCodBarra.Focus();
        }

        private void dgvDetalle_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProdXCodBarra();
                //Totales();
            }
        }

        private void Frm_Base_Notas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si pasó mucho tiempo entre teclas, se asume que es nuevo código
            if ((DateTime.Now - ultimaTecla).TotalMilliseconds > 100)
            {
                bufferCodigo = "";
            }

            ultimaTecla = DateTime.Now;

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCodBarra.Text = bufferCodigo.Trim();
                bufferCodigo = "";

                if (!string.IsNullOrEmpty(txtCodBarra.Text))
                {
                    //MessageBox.Show("Código leído: " + txtCodBarra.Text);
                    BuscarProdXCodBarra();
                }
            }
            else
            {
                bufferCodigo += e.KeyChar;
            }
        }
    }
}

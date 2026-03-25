using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_IngSalProducto : GRTechnology1._0.Frm_Base_Notas
    {
        public static Frm_IngSalProducto frmingprod = null;
        public static Frm_IngSalProducto frmsalprod = null;
        public string Tupla = string.Empty;

        public Frm_IngSalProducto()
        {
            InitializeComponent();
        }

        private void HabilDesabilCampos()
        {
            if (txtCodCompraProd.Text != "-1")
            {
                cboTipoIng.Enabled = false;
                btnAbriCerrarPanel.Enabled = false;
                btnBusqProv.Enabled = false;
                label2.Visible = true;
                txtNroRegul.Visible = true;
                dgvDetalle.Columns["ProductoID"].ReadOnly = true;
                dgvDetalle.Columns["Precio"].ReadOnly = true;
                dgvDetalle.Columns["Stock"].HeaderText = "Saldo";
                dgvDetalle.AllowUserToAddRows = false;
            }
        }

        private void Cargar_SaldoCompra()
        {
            try
            {
                AbrirCerrarPanelBusqProd();

                DataSet CompraDS = DListarPersonalizado.ConsultarDS("SELECT * FROM Vista_CompraProd WHERE CodCompraProd='" + txtCodCompraProd.Text + "'; " +
                    "SELECT *, (Cantidad-Cantidad_Ingr) Saldo FROM Vista_Saldo_Detalle_CompraProd WHERE CodCompraProd='" + txtCodCompraProd.Text + "' " +
                    "AND (Cantidad-Cantidad_Ingr)>0");

                if(CompraDS.Tables[0].Rows.Count>0)
                {
                    cboTipoIng.SelectedValue = 7; //Compra x defecto
                    txtNroRegul.Text = CompraDS.Tables[0].Rows[0]["NumCompraProd"].ToString();
                    Cargar_Proveedor((int)CompraDS.Tables[0].Rows[0]["ProveedorID"], CompraDS.Tables[0].Rows[0]["NomProv"].ToString());

                    foreach (DataRow item in CompraDS.Tables[1].Rows)
                    {
                        base.Agregar_ProductoDGV(-1, item.Field<int>("ProductoID"), item.Field<string>("NomProd"), item.Field<string>("UnidMedida"),
                            item.Field<decimal>("Saldo"), 0, item.Field<decimal>("PUnitario"), item.Field<decimal>("PUnitario"),
                            0, 0, item.Field<int>("ClasificacionID"), item.Field<bool>("Vencimiento"), item.Field<bool>("Serial"),
                            item.Field<string>("RegSanitario"), null);
                    }
                    Totales();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Cargar_ModifCostos()
        {
            try
            {
                //AbrirCerrarPanelBusqProd();

                DataSet IngresoDS = DListarPersonalizado.ConsultarDS("SELECT * FROM Vista_IngSalProd WHERE CodIngSalProd='" + txtCodigoNota.Text + "'; " +
                    "SELECT * FROM Vista_Detalle_IngSalProd WHERE CodIngSalProd='" + txtCodigoNota.Text + "'");

                if (IngresoDS.Tables[0].Rows.Count > 0)
                {
                    Cargar_Proveedor((int)IngresoDS.Tables[0].Rows[0]["ProveedorID"], IngresoDS.Tables[0].Rows[0]["NomProv"].ToString());
                    cboTipoIng.SelectedValue = IngresoDS.Tables[0].Rows[0]["TipoIngSalProdID"].ToString();
                    txtNumNota.Text = IngresoDS.Tables[0].Rows[0]["NumIngSalProducto"].ToString();
                    txtObs.Text = IngresoDS.Tables[0].Rows[0]["Concepto"].ToString();

                    //imvisibles columnas
                    dgvDetalle.Columns["CodDetalle"].ReadOnly = true;
                    dgvDetalle.Columns["ProductoID"].ReadOnly = true;
                    dgvDetalle.Columns["Cantidad"].ReadOnly = true;
                    dgvDetalle.Columns["Porcent_Dscto"].ReadOnly = true;
                    dgvDetalle.Columns["Dscto"].ReadOnly = true;
                    dgvDetalle.Columns["Stock"].Visible = false;

                    foreach (DataRow item in IngresoDS.Tables[1].Rows)
                    {
                        base.Agregar_ProductoDGV(item.Field<long>("Det_IngSalProd"), item.Field<int>("ProductoID"), item.Field<string>("NomProd"), item.Field<string>("UnidMedida"),
                           0, item.Field<decimal>("Cantidad"), item.Field<decimal>("PUnitario"), item.Field<decimal>("PUnitario"),
                           0, 0, item.Field<int>("ClasificacionID"), item.Field<bool>("Vencimiento"), item.Field<bool>("Serial"),
                           item.Field<string>("RegSanitario"), null);
                    }

                    Totales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public override void InsertModifNota()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            Frm_Lote lote = null;
            Frm_Series serie = null;

            try
            {
                if (!Verificar())
                    return;

                string DetaModif = string.Empty;
                if (txtCodigoNota.Text != "-1")
                {
                    Frm_DetaModifAnul modif = new Frm_DetaModifAnul("MODIFICAR");
                    modif.ShowDialog();

                    if (!modif.Cancelado)
                    {
                        DetaModif = modif.DetaModAnul();
                        modif.Dispose();
                    }
                    else
                    {
                        modif.Dispose();
                        throw new Exception("CANCELADO POR EL USUARIO");
                    }
                }

                OIngSalProducto ingsal = new OIngSalProducto();
                ingsal.AlmacenID = OConexionGlobal.SucursalID;
                ingsal.CodCompraProd = txtCodCompraProd.Text;
                ingsal.CodIngSalProd = txtCodigoNota.Text;
                ingsal.Concepto = txtObs.Text;
                ingsal.ProveedorID = Convert.ToInt32(cboProveedor.ValueMember);
                ingsal.Recibido = txtRecibido.Text.Trim();
                ingsal.TipoIngSalProdID = (int)cboTipoIng.SelectedValue;
                ingsal.DetalleIngSalProd = InsertDetalle();
                ingsal.EsIngreso = (Tupla == "INGRESO" ? true : false);

                //PRODUCTOS CON VENCIMIENTO
                if (ListProdLotesSeriesDT != null && Tupla == "INGRESO")
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

                        lote = new Frm_Lote();
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

                        serie = new Frm_Series();
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

                    if (LotesSeriesDT == null)
                        throw new Exception("VERIFICAR LOTES/SERIES");

                    txtCodigoNota.Text = DIngSalProducto.DInsertModifIngSalProd(ingsal, LotesSeriesDT, OInmode.DTInmode("", (txtCodigoNota.Text == "-1" ? "NUEVO" : "MODIFICAR"), DetaModif));
                }
                else
                    txtCodigoNota.Text = DIngSalProducto.DInsertModifIngSalProd(ingsal, OInmode.DTInmode("", (txtCodigoNota.Text == "-1" ? "NUEVO" : "MODIFICAR"), DetaModif));

                if (txtCodigoNota.Text != "-1")
                {
                    if (txtNroRegul.Visible)
                    {
                        this.Close();
                        return;
                    }

                    ImprimirNota();
                    ListarProductos();
                    Borrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;

                if (lote != null)
                    lote.Dispose();
                if (serie != null)
                    serie.Dispose();
            }
        }

        private void ImprimirNota()
        {
            try
            {
                if (DConstantes.Imprimir.Nota_IngSalProd.IMP_NOTA_INGSALPROD)
                {
                    List<string> consulta = new List<string>() 
                    { 
                                "SELECT * FROM Vista_IngSalProd WHERE CodIngSalProd='" + txtCodigoNota.Text + "'",
                                "SELECT * FROM Vista_Detalle_IngSalProd WHERE CodIngSalProd='" + txtCodigoNota.Text + "'",
                     };
                        List<string> nomconsulta = new List<string>() { "Lista_IngrSal", "Detalle_IngSalProd", };

                        Imprimir(consulta, nomconsulta, "NOTA DE " + Tupla + " Nº ",
                                 DConstantes.Imprimir.Nota_IngSalProd.NOM_REPORTE_NOTA_INGSALPROD,
                                 DConstantes.Imprimir.Nota_IngSalProd.IMPAUTOMATIC_NOTA_INGSALPROD,
                                 DConstantes.Imprimir.Nota_IngSalProd.VISUALIZAR_NOTA_INGSALPROD,
                                 DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_IMP,
                                 DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_COPIAR,
                                 DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_EXPORT,
                                 DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_ARBOL);
                }
                else
                    MessageBox.Show(DConstantes.Mensajes.MensajeExito, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public override void Totales()
        {
            if (!Cargado)
                return;

            Cargado = false;
            decimal cant = 0;
            decimal prec = 0;
            decimal tot = 0;
            for (int i = 0; i < (dgvDetalle.AllowUserToAddRows ? dgvDetalle.Rows.Count - 1 : dgvDetalle.Rows.Count); i++)
            {
                if (dgvDetalle["Cantidad", i].Value == null)
                    dgvDetalle["Cantidad", i].Value = 0;
                if (dgvDetalle["Precio", i].Value == null)
                    dgvDetalle["Precio", i].Value = 0;

                if (!decimal.TryParse(dgvDetalle["Cantidad", i].Value.ToString(), out cant))
                    dgvDetalle["Cantidad", i].Value = 0;

                if (!decimal.TryParse(dgvDetalle["Precio", i].Value.ToString(), out prec))
                    dgvDetalle["Precio", i].Value = 0;

                if (Tupla == "SALIDA")
                {
                    if (Convert.ToDecimal(dgvDetalle["Stock", i].Value) < cant)
                    {
                        MessageBox.Show("LA CANTIDAD NO PUEDE SER MAYOR QUE LA QUE HAY EN STOCK", "STOCK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDetalle["Cantidad", i].Value = dgvDetalle["Stock", i].Value;
                        cant = Convert.ToDecimal(dgvDetalle["Stock", i].Value);
                    }
                }
                else if ((Tupla == "INGRESO") && (txtNroRegul.Visible))
                {
                    if (Convert.ToDecimal(dgvDetalle["Stock", i].Value) < cant)
                    {
                        MessageBox.Show("LA CANTIDAD NO PUEDE SER MAYOR A LA DEL SALDO", "STOCK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDetalle["Cantidad", i].Value = dgvDetalle["Stock", i].Value;
                        cant = Convert.ToDecimal(dgvDetalle["Stock", i].Value);
                    }
                }

                dgvDetalle["Importe", i].Value = cant * prec;
                tot += (cant * prec);
            }

            txtImporteTot.Text = string.Format("{0:#,##0.00}", tot);
            dgvDetalle.Refresh();
            Cargado = true;
        }

        public override void Borrar()
        {
            txtCodigoNota.Text = "-1";
            txtCodCompraProd.Text = "-1";
            panelSup.Visible = false;
            txtNumNota.Clear();
            cboTipoIng.SelectedValue = -1;
            Cargar_Proveedor(-1, "[SELECCIONE UN PROVEEDOR]");
            txtRecibido.Clear();
            txtObs.Clear();
            dgvDetalle.Rows.Clear();
            txtImporteTot.Text = "0.00";

            if (ListProdLotesSeriesDT != null)
                ListProdLotesSeriesDT.Rows.Clear();            
        }

        private bool Verificar()
        {
            if ((int)cboTipoIng.SelectedValue == -1)
            {
                MessageBox.Show("SELECCIONE EL TIPO DE " + Tupla, "TIPO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoIng.Focus();
                return false;
            }
            else if (Convert.ToInt32(cboProveedor.ValueMember) == -1)
            {
                MessageBox.Show("SELECCIONE EL PROVEEDOR", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProveedor.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtObs.Text))
            {
                MessageBox.Show("EL DETALLE NO PUEDE ESTAR VACÍO", "DETALLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtObs.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtRecibido.Text))
            {
                MessageBox.Show("EL CAMPO " + lblRef.Text.ToUpper() + " NO PUEDE ESTAR VACÍO", lblRef.Text.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRecibido.Focus();
                return false;
            }
            else if (dgvDetalle.Rows.Count ==(dgvDetalle.AllowUserToAddRows ? 1 : 0))
            {
                MessageBox.Show("INGRESE POR LO MENOS UN PRODUCTO EN LA LISTA", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDetalle.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtImporteTot.Text) <= 0)
            {
                MessageBox.Show("EL IMPORTE NO PUEDE SER MENOR O IGUAL A CERO", "IMPORTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDetalle.Focus();
                return false;
            }

            for (int i = 0; i < (dgvDetalle.AllowUserToAddRows ? dgvDetalle.Rows.Count - 1 : dgvDetalle.Rows.Count); i++)
            {
                if (dgvDetalle["ProductoID", i].Value == null)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1).ToString() + ", INGRESE UN PRODUCTO VÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(dgvDetalle["Producto", i].Value.ToString()))
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1).ToString() + ", INGRESE UN PRODUCTO VÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Cantidad", i].Value) <= 0)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1).ToString() + ", LA CANTIDAD NO PUEDE SER MENOR O IGUAL A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Precio", i].Value) <= 0)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1).ToString() + ", EL PRECIO NO PUEDE SER MENOR O IGUAL A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Tupla == "SALIDA")
                {
                    //Verificamos el Stock
                    try
                    {
                        var result = DListarPersonalizado.Dato("SELECT 1 FROM Stock_Prod WHERE AlmacenID=" + OConexionGlobal.SucursalID +
                        " AND ProductoID=" + dgvDetalle["ProductoID", i].Value + " AND StockAlmacen<" + dgvDetalle["Cantidad", i].Value);

                        if (result != null)
                        {
                            MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", LA CANTIDAD NO PUEDE SER MAYOR A LA QUE HAY EN STOCK", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR AL CONECTARSE A LA BASE DE DATOS PARA VERIFICAR EL STOCK", "STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private void ListarTipoIngreso()
        {
            try
            {
                cboTipoIng.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo " +
                    "WHERE Estado=1 AND Tupla='" + Tupla + "' " + //(txtCodCompraProd.Text == "-1" ? "' AND TipoID<>7 " : "' ") +
                    "UNION SELECT -1, '[SELECCIONE EL TIPO.....]'");
                cboTipoIng.DisplayMember = "NomTipo";
                cboTipoIng.ValueMember = "TipoID";
                cboTipoIng.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Proveedor(int provid, string nom)
        {
            cboProveedor.Items.Clear();
            cboProveedor.Items.Add(nom);
            cboProveedor.ValueMember = provid.ToString();
            cboProveedor.Text = nom;

            if (nom != "[SELECCIONE UN PROVEEDOR]")
                txtRecibido.Text = nom;
        }

        private void btnBusqProv_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bprov = new Buscadores.Buscador();
            bprov.Opcion = "Proveedor";
            bprov.ShowDialog();
            
            if (bprov.Seleccionado)
                Cargar_Proveedor(Convert.ToInt32(bprov.dgvDatos["ID", bprov.dgvDatos.CurrentRow.Index].Value),
                bprov.dgvDatos["Nombre", bprov.dgvDatos.CurrentRow.Index].Value.ToString());

            bprov.Dispose();
        }

        private void Frm_IngSalProducto_Load(object sender, EventArgs e)
        {
            HabilDesabilCampos();
            this.Text += " DE " + Tupla;
            Cargar_Proveedor(-1, "[SELECCIONE UN PROVEEDOR]");
            lblTipo.Text = (Tupla == "INGRESO" ? "Tipo Ingreso:" : "Tipo Salida:");
            lblRef.Text = (Tupla == "INGRESO" ? "Recibido de:" : "Entregado a:");
            panelSup.BackColor = (Tupla == "INGRESO" ? System.Drawing.Color.LightSeaGreen : System.Drawing.Color.YellowGreen);
            ListarTipoIngreso();

            Cargado = true;

            if (txtCodCompraProd.Text != "-1")
                Cargar_SaldoCompra();
            else if (this.txtCodigoNota.Text != "-1")
                Cargar_ModifCostos();
        }

        private void Frm_IngSalProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmingprod != null)
            {
                frmingprod.Dispose();
                frmingprod = null;
            }
            else if (frmsalprod != null)
            {
                frmsalprod.Dispose();
                frmsalprod = null;
            }
        }

    }
}

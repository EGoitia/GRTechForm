using Datos;
using GRTechnology1._0.Clases;
using GRTechnology1._0.ControlUsuario;
using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Venta2 : Form
    {
        public static Frm_Venta2 frmventa = null;

        DataTable DTProd = null;
        DataTable DTVendedor = null;
        DataTable DTTipoProd = null;
        DataTable DTTipoPago = null;
        IEnumerable<DataRow> DRProd = null;

        Frm_PagoPos FrmPago = null;
        Frm_Reporte FrmRep = null;
        Frm_SelectProductoPOS FrmSelecProd = null;

        OVenta OVen = null;
        List<ODetalleVenta> LDVen = null;
        List<ODetallePago> LDPag = null;

        bool sw = true;
        decimal MontoTotBs = 0;
        int IDTipo = 0;
        int IDVendedor = 0;

        public Frm_Venta2()
        {
            InitializeComponent();
        }

        #region Conexion Datos

        private void InsertModifNota()
        {
            if (!Verificar())
                return;

            try
            {
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnAct.Enabled = false;
                btnConfig.Enabled = false;
                btnBusqCli.Enabled = false;
                panelProductos.Enabled = false;
                panelTipoProd.Enabled = false;

                FrmPago.BorrarTodo();

                if (cmbTipoVenta.Text == "CONTADO")
                {
                    FrmPago.txtTotImporte.Value = MontoTotBs;
                    FrmPago.txtEfec.Text = MontoTotBs.ToString("N2");
                    FrmPago.txtEfec.Select();
                    FrmPago.txtTotPagado.Value = MontoTotBs;
                    FrmPago.ShowDialog();

                    if (!FrmPago.Guardar)
                        return;
                }

                AgregaObjeto();
                string DetModif = string.Empty;
                OVen.CodVenta = "-1";

                string codnota = DVenta.DInsertModifVenta(OVen, OInmode.DTInmode("", "NUEVO", ""));

                if (codnota != "-1")
                {
                    Imp3(codnota);
                    Borrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnAct.Enabled = true;
                btnConfig.Enabled = true;
                btnBusqCli.Enabled = true;
                panelProductos.Enabled = true;
                panelTipoProd.Enabled = true;
            }
        }

        public void ListarTipoProd()
        {
            try
            {
                string ConsultaSQL = "select RubroSubRubroID TipoID, NomRubroSubRubro NomTipo from RubroSubRubro where Estado=1";
                DTTipoProd = DListarPersonalizado.ConsultarLocalDT(ConsultaSQL);
                CargarTipoProd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarProd()
        {
            try
            {
                string ConsultaSQL = "SELECT ProductoID, CodFabrica, RubroID TipoID, NomProd, UnidMedida, " +
                     "StockAlmacen, PVentaMenorEmp Precio, ClasificacionID, Img " +
                     "FROM Producto WHERE Estado=1 AND AlmacenID=" + OConexionGlobal.SucursalID;

                DTProd = DListarPersonalizado.ConsultarLocalDT(ConsultaSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Vendedor()
        {
            try
            {
                //verificamos la configuracion de los vendedores
                //var config = DListarPersonalizado.Dato("select Valor from Configuracion where Variable='VER_SOLO_VENDEDOR'");
                string consultasql = "SELECT PersonalID, NomPer FROM Personal WHERE Estado=1";

                //if (!Convert.ToBoolean(config))
                //    consultasql += "UNION SELECT NULL, '[SIN VENDEDOR]'";

                DTVendedor = DListarPersonalizado.ConsultarLocalDT(consultasql);
                CargarVendedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Actualizar_Offline()
        {
            try
            {
                //Rubro Subrubro
                string ConsultaSQL = "SELECT RubroSubRubroID TipoID, NomRubroSubRubro NomTipo, '' Tupla, Estado FROM RubroSubRubro where Tipo='Rubro'; ";
                //Producto
                ConsultaSQL += "SELECT p.ProductoID, p.CodFabrica, p.RubroID, p.SubRubroID, p.MarcaID, p.NomProd, p.DescripcionCorta, " +
                     "p.UnidMedida, s.StockAlmacen, s.AlmacenID, p.PVentaMenorEmp, p.PVentaMayorEmp, p.ClasificacionID,  p.Img, p.URLImag, " +
                     "p.RegSanitario, p.ModifPrec, p.Vencimiento, p.Serial, p.Comodin, p.Estado " +
                     "FROM Vista_Productos p INNER JOIN Stock_Prod s ON p.ProductoID=s.ProductoID " +
                     "WHERE s.AlmacenID=" + OConexionGlobal.SucursalID + "; ";
                //Personal
                ConsultaSQL += "SELECT PersonalID TipoID, NomPer NomTipo, '' Tupla, Estado FROM Personal WHERE CargoID IN(2, 3);";


                DataSet ds = DListarPersonalizado.ConsultarDS(ConsultaSQL);

                //guardamos los grupos
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DRubroSubRubro.DInsertModifRubroSubRubroLocal(ds.Tables[0]);
                }

                //guardamos los Producto
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
                {
                    DProducto.DInsertModifProdLocal(ds.Tables[1]);
                }

                //guardamos los vendedores
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[2].Rows.Count > 0)
                {
                    DPersonal.DInsertModifPerLocal(ds.Tables[2]);
                }

                ListarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarTipoProd()
        {
            panelTipoProd.Controls.Clear();

            int cont = 0;
            foreach (DataRow item in DTTipoProd.Rows)
            {
                Button btn = new Button();
                IDTipo = item.Field<int>("TipoID");
                btn.BackColor = System.Drawing.Color.Crimson;
                btn.Name = IDTipo.ToString();
                btn.Text = item.Field<string>("NomTipo");
                lblTipoProd.Text = item.Field<string>("NomTipo");
                btn.Top = cont * 90;
                btn.Left = 7;
                btn.Width = 100;
                btn.Height = 90;

                panelTipoProd.Controls.Add(btn);
                cont++;

                btn.Click += new System.EventHandler(this.BotonTipo_Click);
            }

            //cargamos el producto segun el tipo de producto seleccionado
            DRProd = (from Producto in DTProd.AsEnumerable()
                      select Producto).Where(x => x.Field<int>("TipoID") == IDTipo);
            CargarProd();
        }

        private void CargarProd()
        {
            //borramos todos los controles
            panelProductos.Controls.Clear();

            foreach (DataRow item in DRProd)
            {
                CntrUsuBtnProducto btn = new CntrUsuBtnProducto();
                btn.lblDesc.Text = "Precio: " + string.Format("{0:#,##0.00}", item.Field<decimal>("Precio")); //item.Field<string>("NomProd") + "\n Precio: " + string.Format("{0:#,##0.00}", item.Field<decimal>("Precio"));
                btn.lblNomProd.Text = item.Field<string>("NomProd");
                btn.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14);
                btn.ID = item.Field<int>("ProductoID").ToString();
                btn.pbxImg.Name = item.Field<int>("ProductoID").ToString();

                //Cargamos la Imagen
                byte[] imgBytes = item.Field<byte[]>("Img");

                if (imgBytes != null && imgBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        btn.pbxImg.BackgroundImage = new Bitmap(ms);
                    }
                }
                else
                {
                    btn.pbxImg.BackgroundImage = Properties.Resources.sinimagen; // imagen por defecto
                }

                panelProductos.Controls.Add(btn);
                btn.pbxImg.Click += new System.EventHandler(this.BotonProd_Click);
            }
        }

        private void CargarVendedor()
        {
            PanelVendedores.Controls.Clear();

            bool sw = true;
            int cont = 0;
            foreach (DataRow item in DTVendedor.Rows)
            {
                Button btn = new Button();
                IDVendedor = item.Field<int>("PersonalID");
                btn.Name = IDVendedor.ToString();
                btn.Text = item.Field<string>("NomPer");
                lblTipoProd.Text = item.Field<string>("NomPer");
                btn.Width = 100;
                btn.Height = 50;

                if (sw)
                {
                    btn.BackColor = System.Drawing.Color.LightSteelBlue;
                    sw = false;
                }
                else
                    btn.BackColor = System.Drawing.Color.Crimson;

                PanelVendedores.Controls.Add(btn);
                cont++;

                btn.Click += new System.EventHandler(this.BotonVendedor_Click);
            }
        }

        #endregion

        #region Funciones

        private void ListarDatos()
        {
            ListarProd();
            ListarTipoProd();
            Listar_Vendedor();
            Autocompletar();
        }

        private void Autocompletar()
        {
            if (DTProd != null)
            {
                foreach (DataRow item in DTProd.Rows)
                {
                    txtBusqProd.AutoCompleteCustomSource.Add(item.Field<string>("NomProd"));
                }
            }
        }

        private bool Verificar()
        {
            if (!DInicioCaja.TieneInicioCajaUsuarioSucursal())
            {
                MessageBox.Show("TIENE QUE INICIAR CAJA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (dgvPedido.Rows.Count <= 0)
            {
                MessageBox.Show("AGREGUE POR LO MENOS UN PRODUCTO A LA LISTA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (MontoTotBs <= 0)
            {
                MessageBox.Show("EL MONTO NO PUEDE SER MENOR O IGUAL CERO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void AgregaObjeto()
        {
            OVen = new OVenta();
            OVen.Detalle = txtDet.Text;

            if (IDVendedor > 0)
            {
                OVen.VendedorID = IDVendedor;
            }

            OVen.AlmacenID = OConexionGlobal.SucursalID;
            OVen.TipoVentaID = cmbTipoVenta.Text == "CONTADO" ? OConstantes.Tipo_Venta_CONTADO : OConstantes.Tipo_Venta_CREDITO;
            OVen.ClienteID = Convert.ToInt32(txtClienteID.Text);
            OVen.Referencia = (txtRef.Text == string.Empty ? "S/N" : txtRef.Text);
            OVen.Monto = MontoTotBs;
            OVen.Dscto = 0; //Convert.ToDecimal(txtDscto.Text);
            OVen.TC = 6.96M; //Convert.ToDecimal(txtTC.Text);
            OVen.Anticipo = 0; //Convert.ToDecimal(txtAnticipo.Text);

            //detalle del venta
            OVen.DetalleVentaDT = InsertDetVen();
            OVen.DetallePagoDT = InsertDetPagos();
        }

        private DataTable InsertDetVen()
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

            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                Fila = DetDT.NewRow();

                Fila["CodDetalle"] = -1;
                Fila["ProductoID"] = Convert.ToInt32(dgvPedido["cProdID", i].Value);
                Fila["DescProd"] = dgvPedido["cDesc", i].Value.ToString();
                Fila["Cantidad"] = Convert.ToDecimal(dgvPedido["cCantidad", i].Value);
                Fila["PUnitario"] = Convert.ToDecimal(dgvPedido["cPrecio", i].Value);
                Fila["Dscto"] = Convert.ToDecimal(dgvPedido["cDcto", i].Value);
                Fila["Porcent_Dscto"] = 0;
                Fila["Estado"] = true;
                DetDT.Rows.Add(Fila);
            }

            return DetDT;
        }

        private DataTable InsertDetPagos()
        {
            DataTable DetDT = new DataTable();
            DataRow Fila;
            DetDT.Columns.Add("PagoID");
            DetDT.Columns.Add("TipoPagoID");
            DetDT.Columns.Add("BancoID");
            DetDT.Columns.Add("Monto");
            DetDT.Columns.Add("Cambio");
            DetDT.Columns.Add("TC");
            DetDT.Columns.Add("Fecha1");
            DetDT.Columns.Add("Fecha2");
            DetDT.Columns.Add("Numero1");
            DetDT.Columns.Add("Numero2");
            DetDT.Columns.Add("Banco1");
            DetDT.Columns.Add("Banco2");
            DetDT.Columns.Add("Estado");

            //EFECTIVO
            if (Convert.ToDecimal(FrmPago.txtEfec.Text) > 0)
            {
                Fila = DetDT.NewRow();
                Fila["PagoID"] = 0;
                Fila["TipoPagoID"] = OConstantes.Tipo_Pago_EFECTIVO;
                Fila["Monto"] = Convert.ToDecimal(FrmPago.txtEfec.Text);
                Fila["Cambio"] = Convert.ToDecimal(FrmPago.txtTotCambio.Text);
                Fila["TC"] = 6.96;
                Fila["Estado"] = true;
                DetDT.Rows.Add(Fila);
            }
            //TRANSFERENCIA
            if (Convert.ToDecimal(FrmPago.txtQR.Text) > 0)
            {
                Fila = DetDT.NewRow();
                Fila["PagoID"] = 0;
                Fila["TipoPagoID"] = OConstantes.Tipo_Pago_TRANSFERENCIA;
                Fila["Monto"] = Convert.ToDecimal(FrmPago.txtQR.Text);
                Fila["Cambio"] = 0;
                Fila["TC"] = 6.96;
                //Fila["BancoID"] = FrmPago.cmbBancoDeposito.SelectedValue;
                //Fila["Banco1"] = FrmPago.cmbBancoDeposito.Text;
                //Fila["Numero1"] = FrmPago.TxtNroDeposito.Text;
                Fila["Estado"] = true;
                DetDT.Rows.Add(Fila);
            }
            //PAGO POSTERIOR
            //if (Convert.ToDecimal(FrmPago.txtPagDesp.Text) > 0)
            //{
            //    Fila = DetDT.NewRow();
            //    Fila["PagoID"] = 0;
            //    Fila["TipoPagoID"] = OConstantes.Tipo_Pago_POSTERIOR;
            //    Fila["Monto"] = Convert.ToDecimal(FrmPago.txtPagDesp.Text);
            //    Fila["Cambio"] = 0;
            //    Fila["TC"] = 6.96;
            //    //Fila["BancoID"] = pag.CmbTipoTarjeta.SelectedValue;
            //    //Fila["Banco1"] = pag.CmbTipoTarjeta.Text;
            //    //Fila["Numero1"] = pag.TxtNroRef1.Text;
            //    Fila["Estado"] = true;
            //    DetDT.Rows.Add(Fila);
            //}

            return DetDT;
        }

        private void Borrar()
        {
            txtClienteID.Text = "1";
            txtRef.Text = "CLIENTES VARIOS";
            txtDet.Clear();
            txtTotal.Text = "Total Bs.- 0.00";
            MontoTotBs = 0;
            dgvPedido.Rows.Clear();

            if (Properties.Settings.Default.Display_Habil)
                CustomerDisplay.Instance.Limpiar();
        }

        private void Imp3(string codnota)
        {
            try
            {
                List<string> consulta = new List<string>() 
                    { 
                        "SELECT * FROM Vista_Ventas WHERE CodVenta='" + codnota + "'",
                        "SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + codnota + "'",
                        "SELECT * FROM Vista_Pagos WHERE CodVenta='" + codnota + "'",
                    };
                List<string> nomconsulta = new List<string>() { "Lista_Venta", "Detalle_Venta", "Vista_Pagos" };

                if (DConstantes.Imprimir.Nota_Venta.IMP_NOTA_VENTA)
                    Imprimir(consulta, nomconsulta, "NOTA DE VENTA",
                             DConstantes.Imprimir.Nota_Venta.NOM_REPORTE_NOTA_VENTA,
                             DConstantes.Imprimir.Nota_Venta.IMPAUTOMATIC_NOTA_VENTA,
                             DConstantes.Imprimir.Nota_Venta.VISUALIZAR_NOTA_VENTA,
                             DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_IMP,
                             DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_COPIAR,
                             DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_EXPORT,
                             DConstantes.Imprimir.Nota_Venta.MOSTRAR_ARBOL);
                else
                    MessageBox.Show(DConstantes.Mensajes.MensajeExito, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Imprimir(List<string> consultadet, List<string> nomconsultadet,
                                     string titulo, string nomrep, bool imp, bool visualizar = true, bool mostrarbtnimp = true,
                                     bool mostrarbtncopiar = true, bool mostrarbtnexport = true, bool mostrararbol = true)
        {

            FrmRep.Dts.Clear();
            FrmRep.Titulo = titulo;

            int i = 0;
            foreach (var item in nomconsultadet)
            {
                FrmRep.Llenar_Tabla(consultadet[i], item);
                i++;
            }

            FrmRep.Cargar(nomrep, imp, mostrarbtnimp, mostrarbtncopiar, mostrarbtnexport, mostrararbol);

            if (visualizar)
                FrmRep.ShowDialog();
            //else
            //    FrmRep.Dispose();
        }

        private void ProcTotales()
        {
            decimal tot = 0;
            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                tot += Convert.ToDecimal(dgvPedido["cTotal", i].Value);
            }

            MontoTotBs = tot;
            txtTotal.Text = "Total Bs.- " + string.Format("{0:#,##0.00}", tot);

            if (Properties.Settings.Default.Display_Habil)
                CustomerDisplay.Instance.MostrarTotal(MontoTotBs);
        }

        private bool VerifProdLista(int prodid)
        {
            bool resp = true;
            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                if (dgvPedido["cProdID", i].Value.ToString() == prodid.ToString())
                {
                    //MessageBox.Show("El Producto se encuentra en la Fila: " + (int)(i + 1));
                    //MasProd(i);

                    resp = false;
                    break;
                }

            }
            return resp;
        }

        private void ElimProd(int fila)
        {
            dgvPedido.Rows.RemoveAt(fila);
            ProcTotales();
        }

        private void BuscarProd()
        {
            if (txtBusqProd.Text != string.Empty)
            {
                DRProd = (from Producto in DTProd.AsEnumerable()
                          select Producto).Where(x => x.Field<string>("NomProd").ToUpper().Contains(txtBusqProd.Text.ToUpper()));
                CargarProd();
            }
            else
            {
                DRProd = (from Producto in DTProd.AsEnumerable()
                          select Producto).Where(x => x.Field<int>("TipoID") == IDTipo);
                CargarProd();
            }
        }

        #endregion

        private void btnAbrirMenu_Click(object sender, EventArgs e)
        {
            if (sw)
            {
                panelLeft.Width = 40;
                panelTipoProd.Visible = false;
                panelProductos.Visible = false;
                lblBusqProd.Visible = false;
                txtBusqProd.Visible = false;
                sw = false;
            }
            else
            {
                panelLeft.Width = 475;
                panelTipoProd.Visible = true;
                panelProductos.Visible = true;
                lblBusqProd.Visible = true;
                txtBusqProd.Visible = true;
                sw = true;
            }
        }

        private void BotonTipo_Click(object sender, EventArgs e)
        {
            Button aux = (Button)sender; //Hacemos el casting

            //cargamos el producto segun el tipo de producto seleccionado
            DRProd = (from Producto in DTProd.AsEnumerable()
                      select Producto).Where(x => x.Field<int>("TipoID").ToString() == aux.Name);
            lblTipoProd.Text = aux.Text;
            CargarProd();
        }

        private void BotonVendedor_Click(object sender, EventArgs e)
        {
            //recorremos todos los vendedores y le cambiamos el color
            foreach (Button item in PanelVendedores.Controls)
            {
                item.BackColor = System.Drawing.Color.Crimson;
            }

            Button aux = (Button)sender; //Hacemos el casting
            aux.BackColor = Color.LightSteelBlue;
            string valor = aux.Name;
            int.TryParse(valor, out IDVendedor);
        }

        private void BotonProd_Click(object sender, EventArgs e)
        {
            PictureBox pbc = (PictureBox)sender;

            IEnumerable<DataRow> drprod = DTProd.Select("ProductoID='" + Convert.ToInt32(pbc.Name) + "'");

            foreach (var item in drprod)
            {

                if (VerifProdLista(Convert.ToInt32(pbc.Name)))
                {
                    FrmSelecProd.Borrar();
                    FrmSelecProd.txtProducto.Text = item.Field<string>("NomProd").ToString();
                    FrmSelecProd.txtPrecio.Text = item.Field<decimal>("Precio").ToString("N2");
                    FrmSelecProd.txtCantidad.Select();
                    FrmSelecProd.txtCantidad.Focus();
                    FrmSelecProd.ShowDialog();

                    if (FrmSelecProd.Seleccionado)
                    {
                        dgvPedido.Rows.Add(pbc.Name, item.Field<string>("NomProd"),
                            FrmSelecProd.txtCantidad.Text,
                            FrmSelecProd.txtPrecio.Text, 0,
                            FrmSelecProd.txtTotal.Text,
                            item.Field<decimal>("StockAlmacen").ToString("N2"));

                        ProcTotales();
                    }
                }
            }
        }

        private void Frm_Venta2_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerDisplay.Instance.Limpiar();
            CustomerDisplay.Instance.Close();

            frmventa.Dispose();
            frmventa = null;
        }

        private void Frm_Venta2_Load(object sender, EventArgs e)
        {
            panelLeft.Width = 475;
            cmbTipoVenta.Text = "CONTADO";

            FrmPago = new Frm_PagoPos();
            FrmRep = new Frm_Reporte();
            FrmSelecProd = new Frm_SelectProductoPOS();

            ListarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifNota();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("DESEA SALIR",
                                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
                this.Close();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            Actualizar_Offline();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Frm_ConfigDisplay conf = new Frm_ConfigDisplay();
            conf.ShowDialog();
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedido.Columns[e.ColumnIndex].Name == "CElim" && e.RowIndex >= 0)
            {
                // Eliminar la fila
                ElimProd(e.RowIndex);
            }
        }

        private void btnBusqCli_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bcli = new Buscadores.Buscador();
            bcli.Opcion = "Cliente";
            bcli.Owner = this;
            bcli.ShowDialog();

            txtClienteID.Text = bcli.dgvDatos["ID", bcli.dgvDatos.CurrentRow.Index].Value.ToString();
            txtRef.Text = bcli.dgvDatos["Nombre", bcli.dgvDatos.CurrentRow.Index].Value.ToString();
            bcli.Dispose();
        }

    }
}

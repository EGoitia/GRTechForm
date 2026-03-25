using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Objetos;
using System.IO;

namespace GRTechPOS
{
    public partial class Frm_Principal : Form
    {
        DataTable DTProd = null;
        DataTable DTTipoProd = null;
        DataTable DTTipoPago = null;
        IEnumerable<DataRow> DRProd = null;

        Frm_PagoPos FrmPago = null;
        Frm_Reporte FrmRep = null;

        OVenta OVen = null;
        List<ODetalleVenta> LDVen = null;
        List<ODetallePago> LDPag = null;

        int IDTipo = 0;
        decimal MontoTotBs = 0;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void BotonTipo_Click(object sender, EventArgs e)
        {
            Button aux = (Button)sender; //Hacemos el casting

            //cargamos el producto segun el tipo de producto seleccionado
            DRProd = (from Producto in DTProd.AsEnumerable()
                      select Producto).Where(x => x.Field<int>("TipoID").ToString() == aux.Name);
            //lblTipoProd.Text = aux.Text;
            CargarProd();
        }

        private void BotonProd_Click(object sender, EventArgs e)
        {
            //Button aux = (Button)sender; //Hacemos el casting
            //cu_BtnProducto aux = (cu_BtnProducto)sender;
            PictureBox pbc = (PictureBox)sender;

            IEnumerable<DataRow> drprod = DTProd.Select("ProductoID='" + Convert.ToInt32(pbc.Name) + "'");

            foreach (var item in drprod)
            {
                //frm_DetCantProd detprod = new frm_DetCantProd(Convert.ToInt32(aux.Name), item.Field<string>("NomProd"), item.Field<decimal>("Precio"));
                //detprod.ShowDialog();

                if (VerifProdLista(Convert.ToInt32(pbc.Name)))
                {
                    dgvPedido.Rows.Add(pbc.Name, item.Field<string>("NomProd"), 1,
                        item.Field<decimal>("Precio"),
                        item.Field<decimal>("Precio"), 0,
                        item.Field<bool>("ImpCocina"),
                        item.Field<string>("NomImpComanda"));

                    ProcTotales();
                }
            }
        }        

        #region Conexion Datos

        private void InsertModifNota()
        {
            if (!Verificar())
                return;


            FrmPago.BorrarTodo();
            FrmPago.PagadoEfec = MontoTotBs.ToString();
            FrmPago.txtTotImporte.Value = MontoTotBs;

            FrmPago.txtEfec.Value = MontoTotBs;
            FrmPago.txtEfec.Select();

            FrmPago.txtTotPagado.Value = MontoTotBs;
            FrmPago.ShowDialog();

            if (!FrmPago.Guardar)
                return;

            try
            {
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
        }

        public void ListarTipoProd()
        {
            try
            {
                string ConsultaSQL = "select RubroSubRubroID TipoID, NomRubroSubRubro NomTipo from RubroSubRubro where Tipo='Rubro' and Estado=1";
                DTTipoProd = DListarPersonalizado.ConsultarDT(ConsultaSQL);
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
                string ConsultaSQL = "SELECT p.ProductoID, p.CodFabrica, p.RubroID TipoID, p.Marca, p.NomGrupo, p.NomSubGrupo, p.NomProd, p.UnidMedida, " +
                     "s.StockAlmacen, p.PVentaMenorEmp Precio, p.ClasificacionID, p.Img " +
                     "FROM Vista_Productos p INNER JOIN Stock_Prod s ON p.ProductoID=s.ProductoID WHERE p.Estado=1 AND s.AlmacenID=" + OConexionGlobal.SucursalID;

                DTProd = DListarPersonalizado.ConsultarDT(ConsultaSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarTipoProd()
        {
            flowLayoutPanelGrupo.Controls.Clear();

            int cont = 0;
            foreach (DataRow item in DTTipoProd.Rows)
            {
                Button btn = new Button();
                IDTipo = item.Field<int>("TipoID");
                btn.BackColor = System.Drawing.Color.Crimson;
                btn.Name = IDTipo.ToString();
                btn.Text = item.Field<string>("NomTipo");
                //lblTipoProd.Text = item.Field<string>("NomTipo");
                btn.Top = cont * 90;
                btn.Left = 7;
                btn.Width = 100;
                btn.Height = 90;

                flowLayoutPanelGrupo.Controls.Add(btn);
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
            flowLayoutPanelProd.Controls.Clear();

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
                    btn.pbxImg.BackgroundImage = Properties.Resources.sinimg; // imagen por defecto
                }


                flowLayoutPanelProd.Controls.Add(btn);

                btn.pbxImg.Click += new System.EventHandler(this.BotonProd_Click);
            }
        }

        #endregion

        #region Funciones

        private void ListarDatos()
        {
            ListarProd();
            ListarTipoProd();
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
            //OVen.Detalle = txtDet.Text;
            
            OVen.AlmacenID = OConexionGlobal.SucursalID;
            //OVen.Referencia = (txtRef.Text == string.Empty ? "S/N" : txtRef.Text);
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
                Fila["ProductoID"] = Convert.ToInt32(dgvPedido["c1", i].Value);
                Fila["DescProd"] = dgvPedido["c8", i].Value.ToString();
                Fila["Cantidad"] = Convert.ToDecimal(dgvPedido["c3", i].Value);
                Fila["PUnitario"] = Convert.ToDecimal(dgvPedido["c4", i].Value);
                Fila["Porcent_Dscto"] = 0;
                Fila["Dscto"] = 0;
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
            if (FrmPago.txtEfec.Value > 0)
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
            //TARJETA
            if (Convert.ToDecimal(FrmPago.txtTarj.Text) > 0)
            {
                Fila = DetDT.NewRow();
                Fila["PagoID"] = 0;
                Fila["TipoPagoID"] = OConstantes.Tipo_Pago_TARJETA;
                Fila["Monto"] = Convert.ToDecimal(FrmPago.txtTarj.Text);
                Fila["Cambio"] = 0;
                Fila["TC"] = 6.96;
                //Fila["BancoID"] = pag.CmbTipoTarjeta.SelectedValue;
                //Fila["Banco1"] = pag.CmbTipoTarjeta.Text;
                //Fila["Numero1"] = pag.TxtNroRef1.Text;
                Fila["Estado"] = true;
                DetDT.Rows.Add(Fila);
            }

            return DetDT;
        }

        private void Borrar()
        {
            
            //txtRef.Clear();
            //txtDet.Clear();
            //txtTotal.Text = "Total Bs.- 0.00";
            MontoTotBs = 0;
            dgvPedido.Rows.Clear();
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

                Borrar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Imprimir(List<string> consultadet, List<string> nomconsultadet,
                                     string titulo, string nomrep, bool imp, bool visualizar = true, bool mostrarbtnimp = true,
                                     bool mostrarbtncopiar = true, bool mostrarbtnexport = true, bool mostrararbol = true)
        {

            //FrmRep.Dts.Clear();
            //FrmRep.Titulo = titulo;

            //int i = 0;
            //foreach (var item in nomconsultadet)
            //{
            //    FrmRep.Llenar_Tabla(consultadet[i], item);
            //    i++;
            //}

            //FrmRep.Cargar(nomrep, imp, mostrarbtnimp, mostrarbtncopiar, mostrarbtnexport, mostrararbol);

            //if (visualizar)
            //    FrmRep.ShowDialog();
            //else
            //    FrmRep.Dispose();
        }

        private void ProcTotales()
        {
            decimal tot = 0;
            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                tot += Convert.ToDecimal(dgvPedido["c5", i].Value);
            }

            MontoTotBs = tot;
            //txtTotal.Text = "Total Bs.- " + string.Format("{0:#,##0.00}", tot);
        }

        private bool VerifProdLista(int prodid)
        {
            bool resp = true;
            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                if (dgvPedido["c1", i].Value.ToString() == prodid.ToString())
                {
                    //MessageBox.Show("El Producto se encuentra en la Fila: " + (int)(i + 1));
                    MasProd(i);

                    resp = false;
                    break;
                }

            }
            return resp;
        }

        private void MasProd(int fila)
        {
            dgvPedido["c3", fila].Value = Convert.ToDecimal(dgvPedido["c3", fila].Value) + 1;
            dgvPedido["c5", fila].Value = Convert.ToDecimal(dgvPedido["c3", fila].Value) * Convert.ToDecimal(dgvPedido["c4", fila].Value);
            ProcTotales();
        }

        private void MenosProd(int fila)
        {
            if (Convert.ToDecimal(dgvPedido["c3", fila].Value) > 1)
            {
                dgvPedido["c3", fila].Value = Convert.ToDecimal(dgvPedido["c3", fila].Value) - 1;
                dgvPedido["c5", fila].Value = Convert.ToDecimal(dgvPedido["c3", fila].Value) * Convert.ToDecimal(dgvPedido["c4", fila].Value);
                ProcTotales();
            }
        }

        private void ElimProd(int fila)
        {
            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
            ProcTotales();
        }       

        #endregion
    }
}

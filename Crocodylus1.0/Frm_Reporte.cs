//using Negocio;
using Objetos;
using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using Datos;

namespace GRTechnology1._0
{
    public partial class Frm_Reporte : Form
    {
        public string Variable = string.Empty;
        public string Variable2 = string.Empty;
        public string Titulo = string.Empty;

        private ControlUsuario.CntrlUsuFiltroProductos culistprec = null;
        private ControlUsuario.CntrlUsuFiltroCuentasXCobrar cucuencob = null;
        private ControlUsuario.CntrlUsuFiltroCuentasXPagar cucuenpag = null;
        private ControlUsuario.CntrlUsuFiltroMovDiarioCaja movcaja = null;
        private ControlUsuario.CntrlUsuFiltroMovDiarioCaja movingregre = null;
        private ControlUsuario.CntrlUsuFiltroVentas cuventas = null;
        private ControlUsuario.CntrlUsuFiltroUtilProductos cuutilprod = null;
        private ControlUsuario.CntrlUsuFiltroResumIngrEgre curesumingregr = null;
        private ControlUsuario.CntrlUsuFiltroPagosProveedor cupagosprov = null;
        private ControlUsuario.CntrlUsuFiltroAbonoCliente cuaboncli = null;
        private ControlUsuario.CntrlUsuFiltroMaterialTransito cumattran = null;
        private ControlUsuario.CntrlUsuFiltroStockMinimo custkmin = null;

        public Frm_Reporte(bool mostrarfiltro = false)
        {
            InitializeComponent();

            panelFiltros.Visible = mostrarfiltro;
        }

        public void Cargar_Reporte(string opc, string[] param)
        {
            if (opc == "Lista_Precios")
            {
                this.Text = "LISTA DE PRECIOS";
                culistprec = new ControlUsuario.CntrlUsuFiltroProductos();
                panelFiltros.Controls.Add(culistprec);
                panelFiltros.Height = culistprec.Height + 5;
                culistprec.ListarSucursal();
            }
            else if (opc == "Tipo_Pagos_Ventas")
            {
                this.Text = "LISTA DE PAGOS POR VENTA";
                cucuencob = new ControlUsuario.CntrlUsuFiltroCuentasXCobrar();
                panelFiltros.Controls.Add(cucuencob);
                cucuencob.txtCliente.Text = (param != null ? param[0] : "");
                panelFiltros.Height = cucuencob.Height + 5;
            }
            else if (opc == "Cuentas_Cobrar")
            {
                this.Text = "CUENTAS POR COBRAR A CLIENTES";
                cucuencob = new ControlUsuario.CntrlUsuFiltroCuentasXCobrar();
                panelFiltros.Controls.Add(cucuencob);
                cucuencob.txtCliente.Text = (param != null ? param[0] : "");
                panelFiltros.Height = cucuencob.Height + 5;
            }
            else if (opc == "Cuentas_Pagar")
            {
                this.Text = "CUENTAS POR PAGAR A PROVEEDORES";
                cucuenpag = new ControlUsuario.CntrlUsuFiltroCuentasXPagar();
                panelFiltros.Controls.Add(cucuenpag);
                cucuenpag.txtProv.Text = (param != null ? param[0] : "");
                panelFiltros.Height = cucuenpag.Height + 5;
            }
            else if (opc == "Movimiento_Caja")
            {
                movcaja = new ControlUsuario.CntrlUsuFiltroMovDiarioCaja();
                panelFiltros.Controls.Add(movcaja);
                panelFiltros.Height = movcaja.Height + 5;
                movcaja.ListarDatos();
            }
            else if (opc == "Movimiento_Ingr_Egre")
            {
                movingregre = new ControlUsuario.CntrlUsuFiltroMovDiarioCaja();
                panelFiltros.Controls.Add(movingregre);
                panelFiltros.Height = movingregre.Height + 5;
                movingregre.ListarDatos();
            }
            else if (opc == "Ventas")
            {
                this.Text = "REPORTE DE VENTAS";
                cuventas = new ControlUsuario.CntrlUsuFiltroVentas();
                panelFiltros.Controls.Add(cuventas);
                panelFiltros.Height = cuventas.Height + 5;
                cuventas.ListarTipoReporte();
                cuventas.ListarSucursal();
            }
            else if (opc == "Utilidad_Prod")
            {
                this.Text = "MOVIMIENTO DE VENTAS POR PRODUCTO(UTILIDAD)";
                cuutilprod = new ControlUsuario.CntrlUsuFiltroUtilProductos();
                panelFiltros.Controls.Add(cuutilprod);
                panelFiltros.Height = cuutilprod.Height + 5;
                cuutilprod.ListarSucursal();
            }
            else if (opc == "ResumIngrEgre")
            {
                this.Text = "RESÚMEN DE INGRESOS Y EGRESOS";
                curesumingregr = new ControlUsuario.CntrlUsuFiltroResumIngrEgre();
                panelFiltros.Controls.Add(curesumingregr);
                panelFiltros.Height = curesumingregr.Height + 5;
            }
            else if (opc == "Pago_Proveedor")
            {
                this.Text = "PAGO A PROVEEDORES";
                cupagosprov = new ControlUsuario.CntrlUsuFiltroPagosProveedor();
                panelFiltros.Controls.Add(cupagosprov);
                panelFiltros.Height = cupagosprov.Height + 5;
            }
            else if (opc == "Abono_Cliente")
            {
                this.Text = "ABONO DE CLIENTES";
                cuaboncli = new ControlUsuario.CntrlUsuFiltroAbonoCliente();
                panelFiltros.Controls.Add(cuaboncli);
                panelFiltros.Height = cuaboncli.Height + 5;
            }
            else if (opc == "Material_Transito")
            {
                this.Text = "MATERIAL EN TRANSITO";
                cumattran = new ControlUsuario.CntrlUsuFiltroMaterialTransito();
                panelFiltros.Controls.Add(cumattran);
                panelFiltros.Height = cumattran.Height + 5;
            }
            else if (opc == "Stock_Minimo")
            {
                this.Text = "STOCK MINIMO";
                custkmin = new ControlUsuario.CntrlUsuFiltroStockMinimo();
                panelFiltros.Controls.Add(custkmin);
                panelFiltros.Height = custkmin.Height + 5;
                custkmin.ListarSucursal();
            }

            Buscar();
        }

        public void Cargar(string archivo, bool imprautomatic, bool mostrarbtnimp = true, bool mostrarbtncopiar = true,
            bool mostrarbtnexport = true, bool mostrararbol = true, int? sucursalid = null)
        {
            if (Dts.Tables["Datos"].Rows.Count > 0)
                Dts.Tables["Datos"].Rows.Clear();
            
            try
            {
                DataRow dr;
                dr = Dts.Tables["Datos"].NewRow();
                dr["Titulo"] = Titulo;
                dr["Logo"] = OConexionGlobal.LogoEmp;
                dr["Usuario"] = OConexionGlobal.NomUsu;
                dr["Descripcion"] = "hola mundo";
                dr["Variable"] = Variable;
                dr["Moneda"] = "Bolivianos";
                dr["Variable2"] = Variable2;
                dr["MarcaAgua"] = OConexionGlobal.LogoEmp;
                dr["NomEmp"] = OConexionGlobal.NomEmp;
                dr["Email"] = "";

                if (sucursalid == null)
                {
                    dr["NomSuc"] = OConexionGlobal.NomSuc;
                    dr["Ciudad"] = OConexionGlobal.Ciudad + " - " + OConexionGlobal.Pais;
                    dr["Telf"] = OConexionGlobal.Telf;
                    dr["Direccion"] = OConexionGlobal.Direccion;
                   
                }
                else
                {
                    DataTable dtsuc = DListarPersonalizado.ConsultarDT("SELECT NomSuc, Telf, Ciudad, Direccion FROM Vista_Sucursal " + 
                        "WHERE SucursalID=" + sucursalid);

                    dr["NomSuc"] = dtsuc.Rows[0]["NomSuc"].ToString();
                    dr["Ciudad"] = dtsuc.Rows[0]["Ciudad"].ToString() +" - " + OConexionGlobal.Pais;
                    dr["Telf"] = dtsuc.Rows[0]["Telf"].ToString();
                    dr["Direccion"] = dtsuc.Rows[0]["Direccion"].ToString();
                }
                
                Dts.Tables["Datos"].Rows.Add(dr);

                string a = Application.StartupPath + "\\Reportes\\" + archivo + ".rpt";
                Reporte.Load(a);
                Reporte.SetDataSource(Dts);
                Reporte.Refresh();

                Visor.ShowPrintButton = mostrarbtnimp;
                Visor.ShowCopyButton = mostrarbtncopiar;
                Visor.ShowExportButton = mostrarbtnexport;

                if(mostrararbol)
                    Visor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.GroupTree;
                else
                    Visor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                
                Visor.ReportSource = Reporte;

                if (imprautomatic)
                {
                    if (string.IsNullOrWhiteSpace(GRTechnology1._0.Properties.Settings.Default.ImpPredeterminada))
                    {
                        PrinterSettings pr = new PrinterSettings();
                        Reporte.PrintOptions.PrinterName = pr.PrinterName;
                    }                     
                    else
                        Reporte.PrintOptions.PrinterName = GRTechnology1._0.Properties.Settings.Default.ImpPredeterminada;

                    Reporte.PrintToPrinter(1, true, 0, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Llenar_Tabla(string consulta, string tabla)
        {
            try
            {
                Dts.Tables[tabla].Clear();

                foreach (DataRow item in DListarPersonalizado.ConsultarDT(consulta).Rows)
                {
                    Dts.Tables[tabla].ImportRow(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            if (culistprec != null)
            {
                Titulo = "LISTA DE PRECIOS";
                Variable = "ListPrecStock";
                Llenar_Tabla(culistprec.ConsultaSQL(), "Lista_Productos");
                Cargar("RptListaProductos", false);
            }
            else if (cucuencob != null)
            {
                Titulo = "CUENTAS POR COBRAR A CLIENTES";
                Variable = "Totales";
                Llenar_Tabla(cucuencob.ConsultaSQL(), "Vista_Saldos_Ventas");
                Cargar("RepCuentasXCobrar", false);
            }
            else if (cucuenpag != null)
            {
                Titulo = "CUENTAS POR PAGAR A PROVEEDORES";
                Variable = "Totales";
                Llenar_Tabla(cucuenpag.ConsultaSQL(), "Vista_Saldos_Prov");
                Cargar("RepCuentasXPagar", false);
            }
            else if (movcaja != null)
            {
                Titulo = "MOVIMIENTO DIARIO DE CAJA";
                Llenar_Tabla(movcaja.ConsultaSQL(), "Vista_Movimiento_Caja");
                object valoringr = Dts.Tables["Vista_Movimiento_Caja"].Compute("SUM(MontoPago)", "EsIngreso=1");
                object valoregre = Dts.Tables["Vista_Movimiento_Caja"].Compute("SUM(MontoPago)", "EsIngreso=0");
                Variable = string.Format("{0:#,##0.00}", ((valoringr != DBNull.Value ? Convert.ToDecimal(valoringr) : 0)
                    - (valoregre != DBNull.Value ? Convert.ToDecimal(valoregre) : 0)));
                Cargar("RepMovimientoCaja", false);
            }
            else if (movingregre != null)
            {
                Titulo = "INGRESOS/EGRESOS";
                Llenar_Tabla(movingregre.ConsultaSQL_IngrEgre(), "Vista_Movimiento_Caja");
                object valoringr = Dts.Tables["Vista_Movimiento_Caja"].Compute("SUM(MontoBs)", "EsIngreso=1");
                object valoregre = Dts.Tables["Vista_Movimiento_Caja"].Compute("SUM(MontoBs)", "EsIngreso=0");
                Variable = string.Format("{0:#,##0.00}", ((valoringr != DBNull.Value ? Convert.ToDecimal(valoringr) : 0)
                    - (valoregre != DBNull.Value ? Convert.ToDecimal(valoregre) : 0)));
                Cargar("RepMovimientoCaja", false);
            }
            else if (cuventas != null)
            {
                Titulo = cuventas.cboTipoRep.Text;
                Variable = "Del: " + cuventas.dtFIni.Value.ToShortDateString() + "  Al: " + cuventas.dtFFin.Value.ToShortDateString();
                Variable2 = (cuventas.chkTotales.Checked ? "Totales" : "");
                Llenar_Tabla(cuventas.ConsultaSQL(), "Lista_Venta");
                Cargar(cuventas.cboTipoRep.SelectedValue.ToString(), false);
            }
            else if (cuutilprod != null)
            {
                Titulo = "UTILIDAD POR PRODUCTO";
                Variable = "Del:" + cuutilprod.dtFecIni.Value.ToShortDateString() + "  Al:" + cuutilprod.dtFecFin.Value.ToShortDateString();
                Llenar_Tabla(cuutilprod.ConsultaSQL(), "Utilidad_Productos");
                Cargar("RptUtilidadProd", false);
            }
            else if (curesumingregr != null)
            {
                Titulo = "RESÚMEN DE INGRESOS Y EGRESOS";
                Variable = "Del:" + curesumingregr.dtFechaIni.Value.ToShortDateString() + "  Al:" + curesumingregr.dtFechaFin.Value.ToShortDateString();
                Llenar_Tabla(curesumingregr.ConsultaSQL(), "ResumIngrEgre");
                Cargar("RptResumIngrEgre", false);
            }
            else if (cupagosprov != null)
            {
                Titulo = "PAGOS A PROVEEDORES";
                Variable = "Del:" + cupagosprov.dtFechaIni.Value.ToShortDateString() + "  Al:" + cupagosprov.dtFechaFin.Value.ToShortDateString();
                Llenar_Tabla(cupagosprov.ConsultaSQL(), "Lista_Abonos");
                Cargar(DConstantes.Imprimir.Rep_Pagos_Proveedores.NOM_REPORTE_PAGOS_PROV, false,
                       DConstantes.Imprimir.Rep_Pagos_Proveedores.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Rep_Pagos_Proveedores.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Rep_Pagos_Proveedores.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Rep_Pagos_Proveedores.MOSTRAR_ARBOL);
            }
            else if (cuaboncli != null)
            {
                Titulo = "ABONOS DE CLIENTES";
                Variable = "Del:" + cuaboncli.dtFechaIni.Value.ToShortDateString() + "  Al:" + cuaboncli.dtFechaFin.Value.ToShortDateString();
                Llenar_Tabla(cuaboncli.ConsultaSQL(), "Lista_Abonos");
                Cargar(DConstantes.Imprimir.Rep_Abonos_Clientes.NOM_REPORTE_ABONO_CLI, false,
                       DConstantes.Imprimir.Rep_Abonos_Clientes.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Rep_Abonos_Clientes.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Rep_Abonos_Clientes.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Rep_Abonos_Clientes.MOSTRAR_ARBOL);
            }
            else if (cumattran != null)
            {
                Titulo = "MATERIAL EN TRÁNSITO";
                Llenar_Tabla(cumattran.ConsultaSQL(), "Material_Transito");
                Cargar("RptMatTransito", false);
            }
            else if (custkmin != null)
            {
                Titulo = "STOCK MINIMO";
                Variable = "Fecha de Corte " + DateTime.Now.ToShortDateString();
                Llenar_Tabla(custkmin.ConsultaSQL(), "Lista_Productos");
                Cargar("RptListaStockMinimo", false);
            }
        }

        private void Frm_Reporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Frm_Reporte_Load(object sender, EventArgs e)
        {

        }
    }
}

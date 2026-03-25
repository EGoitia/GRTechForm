using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using GRTechnology1._0.Properties;
using Objetos;
using Datos;
using System.Diagnostics;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace GRTechnology1._0
{
    public partial class Frm_Principal : Form, ICargaDatosPrin
    {

        #region ICargarDatosPrin

        public void CargarDatosPrin(string emp)
        {
            //Cargamos la imagen de fondo
            CargarImg(emp);

            //cargamos datos usuario
            CargarDatUsuario();

            //cargamos los roles de los usuarios
            //CargarRoles();
        }

        #endregion

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Crocodylus_Load(object sender, EventArgs e)
        {
            //Cargamos la imagen x defecto
            CargarRoles();
            CargarVersionSistema();
            CargarImg("Defecto");
            CargarDatUsuario();
        }

        private void CargarRoles()
        {
            Recorre_Menu(false, toolStrip1.Items, 0);

            //try
            //{
            //    foreach (ToolStripDropDownButton item in toolStrip1.Items)
            //    {

            //        item.Visible = DDetalleRolUsuario.DRolHabilDesabil(item.Name, "");

            //        foreach (ToolStripItem subitem in item.DropDownItems)
            //        {
            //            subitem.Visible = DDetalleRolUsuario.DRolHabilDesabil(subitem.Name, "");

            //            try
            //            {
            //                foreach (ToolStripItem subitemrep in (subitem as ToolStripMenuItem).DropDownItems)
            //                {
            //                    subitemrep.Visible = DDetalleRolUsuario.NRolHabilDesabil(subitemrep.Name, "");
            //                }
            //                //if ((subitem as ToolStripMenuItem).HasDropDownItems)
            //                //{

            //                //}
            //            }
            //            catch (Exception)
            //            {
            //            }
            //            finally
            //            {
            //                //toolStripDropDownBtnMantenimiento.Visible = true;
            //                //personalToolStripMenuItem.Visible = true;
            //                //sucursalToolStripMenuItem.Visible = true;
            //                //almacenToolStripMenuItem.Visible = true;
            //            }
            //        }


            //        if (item.Name == "toolStripDropDownBtnDesc")
            //            item.Visible = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void CargarDatUsuario()
        {
            try
            {
                BarraUsuario.Text = "   USUARIO: " + OConexionGlobal.NomUsu + "   ";
                BarraPersona.Text = "   NOMBRE: " + OConexionGlobal.NomPer + "   ";
                BarraSucursal.Text = "   SUCURSAL: " + OConexionGlobal.NomSuc + "   ";
                BarraEmpresa.Text = "   EMPRESA: " + OConexionGlobal.NomEmp + "   ";
                BarraCuenta.Text = "   CUENTA: " + OConexionGlobal.TipoUsu + "   ";
                BarraCiudad.Text = "   CIUDAD: " + OConexionGlobal.Ciudad + "   ";
            }
            catch (Exception)
            {
            }

        }

        private void CargarImg(string emp)
        {
            try
            {
                if (emp == "CBonita")
                    this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Imagenes\" + Settings.Default.NomImgFondo1); //
                else if (emp == "Decoralia")
                    this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Imagenes\" + Settings.Default.NomImgFondo2); //
                else if (emp == "Defecto")
                    this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Imagenes\" + Settings.Default.NomImgFondo3); //

                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarVersionSistema()
        {
            try
            {
                string path = Application.StartupPath.ToString() + "\\GRTechnology1.0.exe";
                // Get the creation time of a well-known directory.
                DateTime dt = File.GetLastWriteTime(path);
                DateTime valor = Convert.ToDateTime(DListarPersonalizado.Dato("SELECT CONVERT(datetime, Valor) Valor FROM Configuracion WHERE Variable='VERSION_SISTEMA'"));
                BarraVersion.Text = "VERSIÓN: " + dt.ToString();

                if (dt.ToString() != valor.ToString())
                    BarraVersion.ForeColor = System.Drawing.Color.Red;
                else
                    BarraVersion.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarAlertas()
        {

        }

        private void conformidadtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Conformidad.frmconf == null)
            {
                Conformidad.frmconf = new Conformidad();
                Conformidad.frmconf.MdiParent = this;
            }
            Conformidad.frmconf.Show();
            Conformidad.frmconf.BringToFront();
        }

        private void Desconectarser()
        {
            DialogResult result;
            if (MdiChildren.Length > 0)
                result = MessageBox.Show("¿DESEA CERRAR SESION?, LOS DATOS QUE NO SE HAYAN GUARDADO SE PERDERÁN", "CERRAR SESION", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
            else
                result = MessageBox.Show("¿DESEA CERRAR SESION?", "CERRAR SESION", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);


            if (result == DialogResult.Yes)
            {
                //--------------------------------
                //cerramos las ventanas abiertas
                //--------------------------------
                foreach (var item in MdiChildren)
                {
                    if (item != null)
                        item.Close();
                }

                //--------------------------------
                //eliminamos los documentos creados
                //--------------------------------
                try
                {
                    DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\Documentos");
                    if (di.GetFiles().Length > 0)
                        foreach (var item in di.GetFiles())
                        {
                            File.Delete(Application.StartupPath + @"\Documentos\" + item);
                        }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Cargamos el Fondo por defecto
                CargarImg("Defecto");

                //Borramos el Menu
                foreach (ToolStripDropDownButton item in toolStrip1.Items)
                {
                    item.Visible = false;
                }

                //--------------------------------
                //ventana de login y passsword
                //--------------------------------
                Frm_Login log = new Frm_Login();
                log.Show();

                this.Hide();
            }
        }

        private void traspasotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Traspaso.frmtrasp == null)
            {
                Frm_Traspaso.frmtrasp = new Frm_Traspaso();
                Frm_Traspaso.frmtrasp.TipoNota = "Traspaso";
                Frm_Traspaso.frmtrasp.MdiParent = this;
            }
            Frm_Traspaso.frmtrasp.Show();
            Frm_Traspaso.frmtrasp.BringToFront();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Venta.frmventa == null)
            {
                Frm_Venta.frmventa = new Frm_Venta();
                Frm_Venta.frmventa.TipoNota = "Venta";
                Frm_Venta.frmventa.MdiParent = this;
            }
            Frm_Venta.frmventa.WindowState = FormWindowState.Maximized;
            Frm_Venta.frmventa.Show();
            Frm_Venta.frmventa.BringToFront();
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Cotizacion.frmcotiz == null)
            {
                Frm_Cotizacion.frmcotiz = new Frm_Cotizacion();
                Frm_Cotizacion.frmcotiz.MdiParent = this;
            }
            Frm_Cotizacion.frmcotiz.Show();
            Frm_Cotizacion.frmcotiz.BringToFront();
        }

        private void reciboDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Ingresos_Egresos.frmgastingr == null)
            {
                Frm_Ingresos_Egresos.frmgastingr = new Frm_Ingresos_Egresos();
                Frm_Ingresos_Egresos.frmgastingr.MdiParent = this;
            }
            Frm_Ingresos_Egresos.frmgastingr.Show();
            Frm_Ingresos_Egresos.frmgastingr.BringToFront();
        }

        private void devolucionPagoAnticipadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AperturaCaja aper = new AperturaCaja();
            aper.ShowDialog();
        }

        private void ingresotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_IngSalProducto.frmingprod == null)
            {
                Frm_IngSalProducto.frmingprod = new Frm_IngSalProducto();
                Frm_IngSalProducto.frmingprod.TipoNota = "IngSalProd";
                Frm_IngSalProducto.frmingprod.MdiParent = this;
            }
            Frm_IngSalProducto.frmingprod.Tupla = "INGRESO";
            Frm_IngSalProducto.frmingprod.Show();
            Frm_IngSalProducto.frmingprod.BringToFront();
        }

        private void salidatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_IngSalProducto.frmsalprod == null)
            {
                Frm_IngSalProducto.frmsalprod = new Frm_IngSalProducto();
                Frm_IngSalProducto.frmsalprod.TipoNota = "IngSalProd";
                Frm_IngSalProducto.frmsalprod.MdiParent = this;
            }
            Frm_IngSalProducto.frmsalprod.Tupla = "SALIDA";
            Frm_IngSalProducto.frmsalprod.Show();
            Frm_IngSalProducto.frmsalprod.BringToFront();
        }

        private void proyeccionDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_ProyeccionVenta.frmproy == null)
            {
                Frm_ProyeccionVenta.frmproy = new Frm_ProyeccionVenta();
                Frm_ProyeccionVenta.frmproy.MdiParent = this;
            }
            Frm_ProyeccionVenta.frmproy.Show();
            Frm_ProyeccionVenta.frmproy.BringToFront();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Compra.frmcomp == null)
            {
                Frm_Compra.frmcomp = new Frm_Compra();
                Frm_Compra.frmcomp.TipoNota = "Compra";
                Frm_Compra.frmcomp.MdiParent = this;
            }
            Frm_Compra.frmcomp.Show();
            Frm_Compra.frmcomp.BringToFront();
        }

        private void tcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoCambio tc = new Frm_TipoCambio();
            tc.ShowDialog();
            tc.Dispose();
        }

        private void traspasoCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cierreDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CierreCaja cie = new CierreCaja();
            cie.ShowDialog();
        }

        private void kardexItemToolStripMenuItemSencillo_Click(object sender, EventArgs e)
        {
            if (Frm_KardexProdSencillo.kprod == null)
            {
                Frm_KardexProdSencillo.kprod = new Frm_KardexProdSencillo();
                Frm_KardexProdSencillo.kprod.MdiParent = this;
            }
            Frm_KardexProdSencillo.kprod.Show();
            Frm_KardexProdSencillo.kprod.BringToFront();
        }

        private void empresaToolStripMenuItemEmp_Click(object sender, EventArgs e)
        {
            Frm_Empresa emp = new Frm_Empresa("MODIFICAR");
            emp.ShowDialog();
        }

        private void sucursalToolStripMenuItemSuc_Click(object sender, EventArgs e)
        {
            if (Frm_Sucursal.frmsuc == null)
            {
                Frm_Sucursal.frmsuc = new Frm_Sucursal();
                Frm_Sucursal.frmsuc.MdiParent = this;
            }
            Frm_Sucursal.frmsuc.Show();
            Frm_Sucursal.frmsuc.BringToFront();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cajas caj = new Frm_Cajas();
            caj.ShowDialog();
            caj.Dispose();
        }

        private void Salir_Sistema()
        {
            DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA SALIR DEL SISTEMA?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                //--------------------------------
                //cerramos las ventanas abiertas
                //--------------------------------
                foreach (var item in MdiChildren)
                {
                    if (item != null)
                        item.Close();
                }

                //--------------------------------
                //eliminamos los documentos creados
                //--------------------------------
                try
                {
                    DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\Documentos");
                    if (di.GetFiles().Length > 0)
                    {
                        foreach (var item in di.GetFiles())
                        {
                            File.Delete(Application.StartupPath + @"\Documentos\" + item);
                        }
                    }

                    Application.Exit();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salirSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir_Sistema();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desconectarser();
        }

        private void movimientoDeVentasPorProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Utilidad_Prod", null);
            rep.Show();
        }

        private void migraciónDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MigracionDatos mi = new MigracionDatos();
            mi.ShowDialog();
            mi.Dispose();
        }

        private void configSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConfigSistema confsist = new Frm_ConfigSistema();
            confsist.ShowDialog();
        }

        private void detalleIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_IngrSalProd.detingr == null)
            {
                Frm_Detalle_IngrSalProd.detingr = new Frm_Detalle_IngrSalProd();
                Frm_Detalle_IngrSalProd.detingr.MdiParent = this;
            }
            Frm_Detalle_IngrSalProd.detingr.Tupla = "INGRESO";
            Frm_Detalle_IngrSalProd.detingr.Show();
            Frm_Detalle_IngrSalProd.detingr.BringToFront();
        }

        private void detalleVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Ventas.detven == null)
            {
                Frm_Detalle_Ventas.detven = new Frm_Detalle_Ventas();
                Frm_Detalle_Ventas.detven.MdiParent = this;
            }
            Frm_Detalle_Ventas.detven.Show();
            Frm_Detalle_Ventas.detven.WindowState = FormWindowState.Maximized;
            Frm_Detalle_Ventas.detven.BringToFront();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Proveedor.prov == null)
            {
                Frm_Proveedor.prov = new Frm_Proveedor();
                Frm_Proveedor.prov.MdiParent = this;
            }
            Frm_Proveedor.prov.Show();
            Frm_Proveedor.prov.BringToFront();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Frm_Clientes.frmcli == null)
            {
                Frm_Clientes.frmcli = new Frm_Clientes();
                Frm_Clientes.frmcli.MdiParent = this;
            }
            Frm_Clientes.frmcli.Show();
            Frm_Clientes.frmcli.BringToFront();
        }

        private void cuentasIngresosEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cuenta_Ingreso_Egreso cueningregre = new Frm_Cuenta_Ingreso_Egreso();
            cueningregre.ShowDialog();
            cueningregre.Dispose();
        }

        private void personalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Frm_Personal.per == null)
            {
                Frm_Personal.per = new Frm_Personal();
                Frm_Personal.per.MdiParent = this;
            }
            Frm_Personal.per.Show();
            Frm_Personal.per.BringToFront();
        }

        private void pagosAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Abonos.frmabonprov == null)
            {
                Frm_Abonos.frmabonprov = new Frm_Abonos(false);
                Frm_Abonos.frmabonprov.MdiParent = this;
            }

            Frm_Abonos.frmabonprov.Show();
            Frm_Abonos.frmabonprov.BringToFront();
        }

        private void detallePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Abonos.detabonprov == null)
            {
                Frm_Detalle_Abonos.detabonprov = new Frm_Detalle_Abonos(false);
                Frm_Detalle_Abonos.detabonprov.MdiParent = this;
            }
            Frm_Detalle_Abonos.detabonprov.Show();
            Frm_Detalle_Abonos.detabonprov.BringToFront();
        }

        private void configImpresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Config_Impresoras cimp = new Frm_Config_Impresoras();
            cimp.ShowDialog();
            cimp.Dispose();
        }

        private void abonoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Abonos.frmaboncli == null)
            {
                Frm_Abonos.frmaboncli = new Frm_Abonos(true);
                Frm_Abonos.frmaboncli.MdiParent = this;
            }

            Frm_Abonos.frmaboncli.Show();
            Frm_Abonos.frmaboncli.BringToFront();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Usuario usu = new Frm_Usuario();
            usu.ShowDialog();
        }

        private void tipoUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_TipoUsuario tipusu = new Frm_TipoUsuario();
            tipusu.ShowDialog();
        }

        private void detalleCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Compra.detcom == null)
            {
                Frm_Detalle_Compra.detcom = new Frm_Detalle_Compra();
                Frm_Detalle_Compra.detcom.MdiParent = this;
            }
            Frm_Detalle_Compra.detcom.Show();
            Frm_Detalle_Compra.detcom.BringToFront();
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                btnActSistema.Visible = true;
                btnMenu.Visible = true;
            }

        }

        private void btnActSistema_Click(object sender, EventArgs e)
        {
            try
            {
                DListarPersonalizado.Dato("UPDATE Configuracion SET Valor='" + File.GetLastWriteTime(Application.StartupPath.ToString() + "\\GRTechnology1.0.exe") +
                    "' WHERE Variable='VERSION_SISTEMA'");
                CargarVersionSistema();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tipoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo tip = new Frm_Tipo("Proveedor");
            tip.ShowDialog();
            tip.Dispose();
        }

        private void tipoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo tip = new Frm_Tipo("Cliente");
            tip.ShowDialog();
            tip.Dispose();
        }

        private void kardexClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Frm_KardexCliProv.kcli == null)
            {
                Frm_KardexCliProv.kcli = new Frm_KardexCliProv();
                Frm_KardexCliProv.kcli.MdiParent = this;
            }
            Frm_KardexCliProv.kcli.Show();
            Frm_KardexCliProv.kcli.BringToFront();
        }

        private void detalleSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_IngrSalProd.detsal == null)
            {
                Frm_Detalle_IngrSalProd.detsal = new Frm_Detalle_IngrSalProd();
                Frm_Detalle_IngrSalProd.detsal.MdiParent = this;
            }
            Frm_Detalle_IngrSalProd.detsal.Tupla = "SALIDA";
            Frm_Detalle_IngrSalProd.detsal.Show();
            Frm_Detalle_IngrSalProd.detsal.BringToFront();
        }

        private void detalleAbonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Abonos.detaboncli == null)
            {
                Frm_Detalle_Abonos.detaboncli = new Frm_Detalle_Abonos(true);
                Frm_Detalle_Abonos.detaboncli.MdiParent = this;
            }
            Frm_Detalle_Abonos.detaboncli.Show();
            Frm_Detalle_Abonos.detaboncli.BringToFront();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Frm_Inventario.inv == null)
            {
                Frm_Inventario.inv = new Frm_Inventario();
                Frm_Inventario.inv.MdiParent = this;
            }
            Frm_Inventario.inv.Show();
            Frm_Inventario.inv.BringToFront();
        }

        private void detalleInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Inventario.frmdetinv == null)
            {
                Frm_Detalle_Inventario.frmdetinv = new Frm_Detalle_Inventario();
                Frm_Detalle_Inventario.frmdetinv.MdiParent = this;
            }
            Frm_Detalle_Inventario.frmdetinv.Show();
            Frm_Detalle_Inventario.frmdetinv.BringToFront();
        }

        private void ventasPorVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpcioRep.OpRepProdVenXVendedor rep = new OpcioRep.OpRepProdVenXVendedor("VENDEDOR");
            rep.ShowDialog();
        }

        private void detalleTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Traspaso.frmdettrasp == null)
            {
                Frm_Detalle_Traspaso.frmdettrasp = new Frm_Detalle_Traspaso();
                Frm_Detalle_Traspaso.frmdettrasp.MdiParent = this;
            }
            Frm_Detalle_Traspaso.frmdettrasp.Show();
            Frm_Detalle_Traspaso.frmdettrasp.BringToFront();
        }

        private void saldoInventarioFísicoValoradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpcioRep.OpRepSaldoInvFisicoValorado saldinv = new OpcioRep.OpRepSaldoInvFisicoValorado();
            saldinv.ShowDialog();
        }

        private void grupoSubgrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RubroSubRubro rubsubrub = new Frm_RubroSubRubro();
            rubsubrub.ShowDialog();
            rubsubrub.Dispose();
        }

        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Tipo tmarca = new Frm_Tipo("Marca");
            tmarca.ShowDialog();
            tmarca.Dispose();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Frm_Producto.pr == null)
            {
                Frm_Producto.pr = new Frm_Producto();
                Frm_Producto.pr.MdiParent = this;
            }
            Frm_Producto.pr.Show();
            Frm_Producto.pr.BringToFront();
        }

        private void listaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Productos.detprod == null)
            {
                Frm_Detalle_Productos.detprod = new Frm_Detalle_Productos();
                Frm_Detalle_Productos.detprod.MdiParent = this;
            }
            Frm_Detalle_Productos.detprod.Show();
            Frm_Detalle_Productos.detprod.BringToFront();
        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Lista_Precios.frmlprec == null)
            {
                Frm_Lista_Precios.frmlprec = new Frm_Lista_Precios();
                Frm_Lista_Precios.frmlprec.MdiParent = this;
            }
            Frm_Lista_Precios.frmlprec.Show();
            Frm_Lista_Precios.frmlprec.BringToFront();
        }

        private void ventasDeProductosAClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpcioRep.OpRepProdVenXVendedor rep = new OpcioRep.OpRepProdVenXVendedor("CLIENTES");
            rep.ShowDialog();
        }

        private void comparaciónDeVentasPorVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpcioRep.OpRepComparacionVentasVendedores.compvend == null)
            {
                OpcioRep.OpRepComparacionVentasVendedores.compvend = new OpcioRep.OpRepComparacionVentasVendedores();
                OpcioRep.OpRepComparacionVentasVendedores.compvend.MdiParent = this;
            }
            OpcioRep.OpRepComparacionVentasVendedores.compvend.Show();
            OpcioRep.OpRepComparacionVentasVendedores.compvend.BringToFront();
        }

        private void materialEnTránsitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Material_Transito", null);
            rep.Show();
        }

        private void comparaciónDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detalleCotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Cotizacion.frmdetcotiz == null)
            {
                Frm_Detalle_Cotizacion.frmdetcotiz = new Frm_Detalle_Cotizacion();
                Frm_Detalle_Cotizacion.frmdetcotiz.MdiParent = this;
            }
            Frm_Detalle_Cotizacion.frmdetcotiz.Show();
            Frm_Detalle_Cotizacion.frmdetcotiz.BringToFront();
        }

        private void toolStripDropDownBtnAct_Click(object sender, EventArgs e)
        {
            CargarVersionSistema();

            if (BarraVersion.ForeColor == System.Drawing.Color.Red)
            {
                DialogResult dialogo = MessageBox.Show("SU VERSIÓN ESTÁ DESACTUALIZADA, ¿DESEA ACTUALIZAR EL SISTEMA EN ESTE MOMENTO?",
                    "ACTUALIZAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No)
                    return;

                DbContext.Up();
                ProcessStartInfo p = new ProcessStartInfo(ConfigService.ObtenerValor("RutaSistemaActualizador"));
                Process.Start(p);

                Application.Exit();
            }
            else
                MessageBox.Show("¡SU SISTEMA ESTÁ ACTUALIZADO!", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void movimientoDiarioDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Movimiento_Caja", null);
            rep.Show();
        }

        private void movimientoGastosEIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reportes.RepLibroMayor replibmay = new Reportes.RepLibroMayor();
            //replibmay.Show();

            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Movimiento_Ingr_Egre", null);
            rep.Show();
        }

        private void condiciónComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Condicion_Comercial condcom = new Frm_Condicion_Comercial();
            condcom.ShowDialog();
            condcom.Dispose();
        }

        private void listaDePreciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Lista_Precios", null);
            rep.Show();
        }

        private void Recorre_Menu(bool crearmenu, ToolStripItemCollection mnu, int padreid)
        {
            foreach (ToolStripItem item in mnu)
            {
                if (crearmenu)
                {
                    NumeroID += 1;

                    filadr = MenuDT.NewRow();
                    filadr["ID"] = NumeroID;
                    filadr["PadreID"] = padreid;
                    filadr["RolID"] = 1;
                    filadr["NomMenu"] = item.Name;
                    filadr["Tipo"] = item.GetType().ToString();
                    filadr["TextoMenu"] = item.Text;
                    filadr["Descripcion"] = "";
                    filadr["Estado"] = true;
                    MenuDT.Rows.Add(filadr);
                }
                else
                {
                    if (item.Name == "toolStripDropDownBtnDesconectar")
                        break;

                    IEnumerable<DataRow> DR = (from _menu in OConexionGlobal.Detalle_Rol.AsEnumerable() select _menu)
                        .Where(x => x.Field<string>("NomMenu") == item.Name);
                    item.Visible = (DR.Count() > 0 ? true : false);
                }

                if (item.IsOnDropDown)
                {
                    if (item.GetType().ToString() != "System.Windows.Forms.ToolStripSeparator")
                        Recorre_Menu(crearmenu, (item as ToolStripMenuItem).DropDownItems, NumeroID);
                }
                else
                    Recorre_Menu(crearmenu, (item as ToolStripDropDownButton).DropDownItems, NumeroID);
            }
        }

        DataTable MenuDT = null;
        DataRow filadr;
        int NumeroID = 0;
        private DataTable Crear_Menu()
        {
            MenuDT = new DataTable();
            MenuDT.Columns.Add("ID");
            MenuDT.Columns.Add("PadreID");
            MenuDT.Columns.Add("RolID");
            MenuDT.Columns.Add("NomMenu");
            MenuDT.Columns.Add("Tipo");
            MenuDT.Columns.Add("TextoMenu");
            MenuDT.Columns.Add("Descripcion");
            MenuDT.Columns.Add("Estado");

            NumeroID = 0;
            Recorre_Menu(true, toolStrip1.Items, NumeroID);

            return MenuDT;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                if (DMenu.DInsertModifMenu(Crear_Menu()))
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuentasPorCobrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Cuentas_Cobrar", null);
            rep.Show();
        }

        private void kardexDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_KardexCliProv.kprov == null)
            {
                Frm_KardexCliProv.kprov = new Frm_KardexCliProv();
                Frm_KardexCliProv.kprov.MdiParent = this;
                Frm_KardexCliProv.kprov.EsCliente = false;
            }
            Frm_KardexCliProv.kprov.Show();
            Frm_KardexCliProv.kprov.BringToFront();
        }

        private void cuentasPorPagarAProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Cuentas_Pagar", null);
            rep.Show();
        }

        private void detalleGastosIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Ingresos_Egresos.frmdetgastingr == null)
            {
                Frm_Detalle_Ingresos_Egresos.frmdetgastingr = new Frm_Detalle_Ingresos_Egresos();
                Frm_Detalle_Ingresos_Egresos.frmdetgastingr.MdiParent = this;
            }
            Frm_Detalle_Ingresos_Egresos.frmdetgastingr.Show();
            Frm_Detalle_Ingresos_Egresos.frmdetgastingr.BringToFront();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo tip = new Frm_Tipo("Personal");
            tip.ShowDialog();
            tip.Dispose();
        }

        private void detalleConformidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abonosAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Pago_Proveedor", null);
            rep.Show();
        }

        private void repAbonoDeClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Abono_Cliente", null);
            rep.Show();
        }

        private void detalleProyecciónDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Proyeccion.frmdetproy == null)
            {
                Frm_Detalle_Proyeccion.frmdetproy = new Frm_Detalle_Proyeccion();
                Frm_Detalle_Proyeccion.frmdetproy.MdiParent = this;
            }
            Frm_Detalle_Proyeccion.frmdetproy.Show();
            Frm_Detalle_Proyeccion.frmdetproy.BringToFront();
        }

        private void ventasDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Ventas", null);
            rep.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Pedidos.frmpedido == null)
            {
                Frm_Pedidos.frmpedido = new Frm_Pedidos();
                Frm_Pedidos.frmpedido.TipoNota = "Pedido";
                Frm_Pedidos.frmpedido.MdiParent = this;
            }
            Frm_Pedidos.frmpedido.WindowState = FormWindowState.Maximized;
            Frm_Pedidos.frmpedido.Show();
            Frm_Pedidos.frmpedido.BringToFront();
        }

        private void detallePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Pedidos.frmdetped == null)
            {
                Frm_Detalle_Pedidos.frmdetped = new Frm_Detalle_Pedidos();
                Frm_Detalle_Pedidos.frmdetped.MdiParent = this;
            }
            Frm_Detalle_Pedidos.frmdetped.WindowState = FormWindowState.Maximized;
            Frm_Detalle_Pedidos.frmdetped.Show();
            Frm_Detalle_Pedidos.frmdetped.BringToFront();
        }

        private void resumenDeIngresosYEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("ResumIngrEgre", null);
            rep.Show();
        }

        private void catálogoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Catalogo_Producto.frmcatprod == null)
            {
                Frm_Catalogo_Producto.frmcatprod = new Frm_Catalogo_Producto();
                Frm_Catalogo_Producto.frmcatprod.MdiParent = this;
            }
            Frm_Catalogo_Producto.frmcatprod.WindowState = FormWindowState.Maximized;
            Frm_Catalogo_Producto.frmcatprod.Show();
            Frm_Catalogo_Producto.frmcatprod.BringToFront();
        }

        private void detalleVencimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Vencimientos.frmdetvenc == null)
            {
                Frm_Detalle_Vencimientos.frmdetvenc = new Frm_Detalle_Vencimientos();
                Frm_Detalle_Vencimientos.frmdetvenc.MdiParent = this;
            }
            Frm_Detalle_Vencimientos.frmdetvenc.WindowState = FormWindowState.Maximized;
            Frm_Detalle_Vencimientos.frmdetvenc.Show();
            Frm_Detalle_Vencimientos.frmdetvenc.BringToFront();
        }

        private void detalleTransformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Transformacion.frmtransf == null)
            {
                Frm_Transformacion.frmtransf = new Frm_Transformacion();
                Frm_Transformacion.frmtransf.MdiParent = this;
            }
            Frm_Transformacion.frmtransf.WindowState = FormWindowState.Maximized;
            Frm_Transformacion.frmtransf.Show();
            Frm_Transformacion.frmtransf.BringToFront();
        }

        private void combosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Producto_Combos frmcombo = new Frm_Producto_Combos();
            frmcombo.ShowDialog();
            frmcombo.Dispose();
        }

        private void revisionDeVentasPorClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listaDePreciosPromociónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Descuento_Promocion.prec_prom == null)
            {
                Frm_Descuento_Promocion.prec_prom = new Frm_Descuento_Promocion();
                Frm_Descuento_Promocion.prec_prom.MdiParent = this;
            }
            Frm_Descuento_Promocion.prec_prom.Show();
            Frm_Descuento_Promocion.prec_prom.BringToFront();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo tip = new Frm_Tipo("Actividad");
            tip.ShowDialog();
            tip.Dispose();
        }

        private void dosificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Dosificacion dosif = new Frm_Dosificacion();
            dosif.ShowDialog();
            dosif.Dispose();
        }

        private void listaDosificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Dosificacion.detdosific == null)
            {
                Frm_Detalle_Dosificacion.detdosific = new Frm_Detalle_Dosificacion();
                Frm_Detalle_Dosificacion.detdosific.MdiParent = this;
            }
            Frm_Detalle_Dosificacion.detdosific.Show();
            Frm_Detalle_Dosificacion.detdosific.WindowState = FormWindowState.Maximized;
            Frm_Detalle_Dosificacion.detdosific.BringToFront();
        }

        private void validaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidacionFactura valfact = new Frm_ValidacionFactura();
            valfact.ShowDialog();
            valfact.Dispose();
        }

        private void libroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Libro_Ventas.libven == null)
            {
                Frm_Libro_Ventas.libven = new Frm_Libro_Ventas();
                Frm_Libro_Ventas.libven.MdiParent = this;
            }
            Frm_Libro_Ventas.libven.Show();
            Frm_Libro_Ventas.libven.WindowState = FormWindowState.Maximized;
            Frm_Libro_Ventas.libven.BringToFront();
        }

        private void libroDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Libro_Compras.libcom == null)
            {
                Frm_Libro_Compras.libcom = new Frm_Libro_Compras();
                Frm_Libro_Compras.libcom.MdiParent = this;
            }
            Frm_Libro_Compras.libcom.Show();
            Frm_Libro_Compras.libcom.WindowState = FormWindowState.Maximized;
            Frm_Libro_Compras.libcom.BringToFront();
        }

        private void ventasAutomáticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Venta_Automatica.frmventaaut == null)
            {
                Frm_Venta_Automatica.frmventaaut = new Frm_Venta_Automatica();
                Frm_Venta_Automatica.frmventaaut.TipoNota = "Venta_Automatica";
                Frm_Venta_Automatica.frmventaaut.MdiParent = this;
            }
            Frm_Venta_Automatica.frmventaaut.WindowState = FormWindowState.Maximized;
            Frm_Venta_Automatica.frmventaaut.Show();
            Frm_Venta_Automatica.frmventaaut.BringToFront();
        }

        private void detalleVentasAutomáticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Ventas.detven == null)
            {
                Frm_Detalle_Ventas.detven = new Frm_Detalle_Ventas();
                Frm_Detalle_Ventas.detven.MdiParent = this;
            }
            Frm_Detalle_Ventas.detven.Show();
            Frm_Detalle_Ventas.detven.WindowState = FormWindowState.Maximized;
            Frm_Detalle_Ventas.detven.BringToFront();
        }

        private void stocksMinimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Stock_Minimo", null);
            rep.Show();
        }

        private void detalleCierresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Cierre.frmdetcierre == null)
            {
                Frm_Detalle_Cierre.frmdetcierre = new Frm_Detalle_Cierre();
                Frm_Detalle_Cierre.frmdetcierre.MdiParent = this;
            }
            Frm_Detalle_Cierre.frmdetcierre.Show();
            Frm_Detalle_Cierre.frmdetcierre.BringToFront();
        }

        private void pagosPorVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte rep = new Frm_Reporte(true);
            rep.Cargar_Reporte("Pagos_Ventas", null);
            rep.Show();
        }

        private void movimientoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Detalle_Movimiento_Banco.frmmovbanco == null)
            {
                Frm_Detalle_Movimiento_Banco.frmmovbanco = new Frm_Detalle_Movimiento_Banco();
                Frm_Detalle_Movimiento_Banco.frmmovbanco.MdiParent = this;
            }

            Frm_Detalle_Movimiento_Banco.frmmovbanco.Show();
            Frm_Detalle_Movimiento_Banco.frmmovbanco.BringToFront();
        }

        private void impCódigoDeBarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_ImpCodigoBarra_Producto.frmimpcodbarra == null)
            {
                Frm_ImpCodigoBarra_Producto.frmimpcodbarra = new Frm_ImpCodigoBarra_Producto();
                Frm_ImpCodigoBarra_Producto.frmimpcodbarra.MdiParent = this;
            }

            Frm_ImpCodigoBarra_Producto.frmimpcodbarra.Show();
            Frm_ImpCodigoBarra_Producto.frmimpcodbarra.BringToFront();
        }

        private void ventaPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Venta2.frmventa == null)
            {
                Frm_Venta2.frmventa = new Frm_Venta2();
                Frm_Venta2.frmventa.MdiParent = this;
            }
            Frm_Venta2.frmventa.WindowState = FormWindowState.Maximized;
            Frm_Venta2.frmventa.Show();
            Frm_Venta2.frmventa.BringToFront();
        }

        private void tipoEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo tip = new Frm_Tipo("Egreso");
            tip.ShowDialog();
            tip.Dispose();
        }

        private void ingresosEgresosPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_Ingresos_EgresosPOS.frmgastingr == null)
            {
                Frm_Ingresos_EgresosPOS.frmgastingr = new Frm_Ingresos_EgresosPOS();
                Frm_Ingresos_EgresosPOS.frmgastingr.MdiParent = this;
            }
            Frm_Ingresos_EgresosPOS.frmgastingr.Show();
            Frm_Ingresos_EgresosPOS.frmgastingr.BringToFront();
        }

    }
}

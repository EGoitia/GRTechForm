using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Venta : GRTechnology1._0.Frm_Base_Notas
    {
        OVenta OVen = null;

        public static Frm_Venta frmventa = null;
        public string TipoRegul = string.Empty;
        Frm_Pagos pag = null;

        public Frm_Venta()
        {
            InitializeComponent();
            pag = new Frm_Pagos();
        }
        
        public override void Borrar()
        {
            OVen = null;
            txtCodigoNota.Text = "-1";
            dgvDetalle.Rows.Clear();
            CargarCliente(1, "CLIENTES VARIOS");
            cboVendedor.SelectedValue = -1;
            cboTipoVenta.Text = "Contado";
            txtSubtotal.Text = "0.00";
            txtDscto.Text = "0.00";
            txtTotales.Text = "0.00";
            txtAnticipo.Text = "0.00";
            txtSaldo.Text = "0.00";
            txtRef.Clear();
            txtObs.Clear();

            panelSaldo.Visible = false;
            txtNumNota.Visible = false;
           
        }

        public override void Totales()
        {
            if (!Cargado)
                return;

            Cargado = false;

            decimal cant = 0, precio = 0, dscto = 0, monto = 0;
            for (int i = 0; i < dgvDetalle.Rows.Count - 1; i++)
            {
                if (dgvDetalle["Cantidad", i].Value == null)
                    dgvDetalle["Cantidad", i].Value = 0;
                if (dgvDetalle["Precio", i].Value == null)
                    dgvDetalle["Precio", i].Value = 0;

                if (!decimal.TryParse(dgvDetalle["Cantidad", i].Value.ToString(), out cant))
                    dgvDetalle["Cantidad", i].Value = 0;
                if (!decimal.TryParse(dgvDetalle["Precio", i].Value.ToString(), out precio))
                    dgvDetalle["Precio", i].Value = 0;


                if (dgvDetalle["ClasificacionID", i].Value != null)
                {
                    if (DConstantes.Clasificacion.Combo != (int)dgvDetalle["ClasificacionID", i].Value &&
                        DConstantes.Clasificacion.Servicio != (int)dgvDetalle["ClasificacionID", i].Value &&
                        (bool)dgvDetalle["Comodin", i].Value == false)
                    {
                        if (cant > Convert.ToDecimal(dgvDetalle["Stock", i].Value) && cboTipoVenta.Text != "ANTICIPADO")
                        {
                            MessageBox.Show("LA CANTIDAD NO PUEDE SER MAYOR A LA DE STOCK", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvDetalle["Cantidad", i].Value = dgvDetalle["Stock", i].Value;
                            cant = Convert.ToDecimal(dgvDetalle["Cantidad", i].Value);
                        }
                    }
                }                

                dscto = Math.Round(cant * precio * Convert.ToDecimal(dgvDetalle["Porcent_Dscto", i].Value) / 100, 2);
                dgvDetalle["Dscto", i].Value = Math.Round(dscto, 2);
                dgvDetalle["Importe", i].Value = Math.Round((cant * precio) - dscto, 2);
                monto += (cant * precio) - dscto;
            }

            dgvDetalle.Refresh();

            txtSubtotal.Text = string.Format("{0:#,##0.00}", monto);
            txtTotales.Text = string.Format("{0:#,##0.00}", monto - Convert.ToDecimal(txtDscto.Text));
            txtSaldo.Text = string.Format("{0:#,##0.00}", monto - Convert.ToDecimal(txtDscto.Text) - Convert.ToDecimal(txtAnticipo.Text));

            Cargado = true;
        }

        public override void InsertModifNota()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            try
            {
                if (!Verificar())
                    return;
                                
                if ((int)cboTipoVenta.SelectedValue == OConstantes.Tipo_Venta_CONTADO &&
                    Convert.ToDecimal(txtSaldo.Text) > 0)
                {
                    pag.Borrar();
                    pag.txtMontoBs.Text = string.Format("{0:#,##0.00}", txtTotales.Text);
                    pag.txtMontoSus.Text = string.Format("{0:#,##0.00}", (Convert.ToDecimal(txtTotales.Text) / Convert.ToDecimal(txtTC.Text)));
                    pag.ShowDialog();
                    if (!pag.Aceptado)
                        return;
                }

                string DetaModif = string.Empty;
                if (txtCodigoNota.Text != "-1" && TipoRegul == string.Empty)
                {
                    Frm_DetaModifAnul modif = new Frm_DetaModifAnul("MODIFICAR");
                    modif.ShowDialog();
                    if (!modif.Cancelado)
                        DetaModif = modif.DetaModAnul();
                    else
                    {
                        modif.Dispose();
                        throw new Exception("CANCELADO POR EL USUARIO");
                    }
                    modif.Dispose();
                }

                OVen = new OVenta();
                if (TipoRegul == "Pedido")
                    OVen.CodPedido = txtCodigoNota.Text;
                else if (TipoRegul == "Cotizacion")
                    OVen.CodCotizacion = txtCodigoNota.Text;
                else
                    OVen.CodVenta = txtCodigoNota.Text;

                OVen.TipoVentaID = (int)cboTipoVenta.SelectedValue;
                OVen.ClienteID = Convert.ToInt32(cboCliente.ValueMember);
                OVen.AlmacenID = OConexionGlobal.SucursalID;

                if (cboVendedor.SelectedValue.ToString() != string.Empty)
                    OVen.VendedorID = (int)cboVendedor.SelectedValue;
                
                OVen.Referencia = txtRef.Text;
                OVen.Detalle = txtObs.Text;
                OVen.DetalleVentaDT = InsertDetalle();
                OVen.DetallePagoDT = InsertDetallePago();
                OVen.Monto = Convert.ToDecimal(txtTotales.Text);
                OVen.Dscto = Convert.ToDecimal(txtDscto.Text);
                OVen.TC = Convert.ToDecimal(txtTC.Text);
                OVen.Anticipo = Convert.ToDecimal(txtAnticipo.Text);

                txtCodigoNota.Text = DVenta.DInsertModifVenta(OVen, OInmode.DTInmode("", (txtCodigoNota.Text == "-1" ? "NUEVO" : "MODIFICAR"), DetaModif));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (txtCodigoNota.Text != "-1")
                {
                    List<string> consulta = new List<string>() 
                    { 
                        "SELECT * FROM Vista_Ventas WHERE CodVenta='" + txtCodigoNota.Text + "'",
                        "SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + txtCodigoNota.Text + "'",
                        "SELECT * FROM Vista_Pagos WHERE CodVenta='" + txtCodigoNota.Text + "'",
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

                    ListarProductos();
                    Borrar();
                }

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private DataTable InsertDetallePago()
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

            if ((int)cboTipoVenta.SelectedValue == OConstantes.Tipo_Venta_CONTADO)
            {
                //EFECTIVO
                if (Convert.ToDecimal(pag.txtEfectivoBs.Text) > 0)
                {
                    Fila = DetDT.NewRow();
                    Fila["PagoID"] = 0;
                    Fila["TipoPagoID"] = OConstantes.Tipo_Pago_EFECTIVO;
                    Fila["Monto"] = Convert.ToDecimal(pag.txtEfectivoBs.Text);
                    Fila["Cambio"] = Convert.ToDecimal(pag.txtCambioBs.Text);
                    Fila["TC"] = Convert.ToDecimal(txtTC.Text);
                    Fila["Estado"] = true;
                    DetDT.Rows.Add(Fila);
                }
                //CHEQUE
                if (Convert.ToDecimal(pag.txtCheque.Text) > 0)
                {
                    Fila = DetDT.NewRow();
                    Fila["PagoID"] = 0;
                    Fila["TipoPagoID"] = OConstantes.Tipo_Pago_CHEQUE;
                    Fila["Monto"] = Convert.ToDecimal(pag.txtCheque.Text);
                    Fila["Cambio"] = 0;
                    Fila["TC"] = Convert.ToDecimal(txtTC.Text);
                    Fila["BancoID"] = pag.cmbBancoCheque.SelectedValue;
                    Fila["Banco1"] = pag.cmbBancoCheque.Text;
                    Fila["Numero1"] = pag.TxtNroCheque.Text;
                    Fila["Estado"] = true;
                    DetDT.Rows.Add(Fila);
                }
                //DEPOSITO
                if (Convert.ToDecimal(pag.txtDeposito.Text) > 0)
                {
                    Fila = DetDT.NewRow();
                    Fila["PagoID"] = 0;
                    Fila["TipoPagoID"] = OConstantes.Tipo_Pago_DEPOSITO;
                    Fila["Monto"] = Convert.ToDecimal(pag.txtDeposito.Text);
                    Fila["Cambio"] = 0;
                    Fila["TC"] = Convert.ToDecimal(txtTC.Text);
                    Fila["BancoID"] = pag.cmbBancoDeposito.SelectedValue;
                    Fila["Banco1"] = pag.cmbBancoDeposito.Text;
                    Fila["Numero1"] = pag.TxtNroDeposito.Text;
                    Fila["Estado"] = true;
                    DetDT.Rows.Add(Fila);
                }
                //TRANSFERENCIA
                if (Convert.ToDecimal(pag.txtTranferencia.Text) > 0)
                {
                    Fila = DetDT.NewRow();
                    Fila["PagoID"] = 0;
                    Fila["TipoPagoID"] = OConstantes.Tipo_Pago_TRANSFERENCIA;
                    Fila["Monto"] = Convert.ToDecimal(pag.txtTranferencia.Text);
                    Fila["Cambio"] = 0;
                    Fila["TC"] = Convert.ToDecimal(txtTC.Text);
                    Fila["BancoID"] = pag.cmbBancoTransferencia.SelectedValue;
                    Fila["Banco1"] = pag.cmbBancoTransferencia.Text;
                    Fila["Numero1"] = pag.TxtNroCpte.Text;
                    Fila["Estado"] = true;
                    DetDT.Rows.Add(Fila);
                }
                //TARJETA
                if (Convert.ToDecimal(pag.txtTarjetaBs.Text) > 0)
                {
                    Fila = DetDT.NewRow();
                    Fila["PagoID"] = 0;
                    Fila["TipoPagoID"] = OConstantes.Tipo_Pago_TARJETA;
                    Fila["Monto"] = Convert.ToDecimal(pag.txtTarjetaBs.Text);
                    Fila["Cambio"] = 0;
                    Fila["TC"] = Convert.ToDecimal(txtTC.Text);
                    Fila["BancoID"] = pag.CmbTipoTarjeta.SelectedValue;
                    Fila["Banco1"] = pag.CmbTipoTarjeta.Text;
                    Fila["Numero1"] = pag.TxtNroRef1.Text;
                    Fila["Estado"] = true;
                    DetDT.Rows.Add(Fila);
                }
            }
            
            return DetDT;
        }

        private bool Verificar()
        {
            //-----------------------------------//
            //porque no se puede guardar una nota//
            //----------------------------------//
            //0.- Si tiene iniciado Caja
            //1.- Que la Venta sea al contado y su saldo sea diferente de cero
            //2.- En un Pago Anticipado, no abone nada
            //3.- Que el detalle este vacio
            //4.- Que en el detalle no haya ingresado la cantidad o el precio
            //5.- Que en el detalle no haya ingresado un Item
            //6.- Que en el detalle la cantidad ingresada sea menoy o igual a cero
            //7.- Que la venta al contado, credito y anticipado sea mayor a cero
            //8.- las Devoluciones que sean menor a cero
            //9.- Verificar si es venta a Credito y si el Cliente tiene restriccion por límite de Crédito
            //10.-la cantidad vendida no sea mayor a la de stock

            if (!DInicioCaja.TieneInicioCajaUsuarioSucursal())
            {
                MessageBox.Show("TIENE QUE INICIAR CAJA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (Convert.ToInt32(cboCliente.ValueMember) == 1 && cboTipoVenta.Text == "CREDITO")
            {
                MessageBox.Show("LA VENTA A CRÉDITO NO ESTA HABILITADO PARA CLIENTES VARIOS", "CRÉDITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnBusqClient.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtRef.Text))
            {
                MessageBox.Show("EL CAMPO REFERENCIA NO PUEDE ESTAR VACÍO", "REFERENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRef.Focus();
                return false;
            }
            else if (dgvDetalle.Rows.Count <= 1)
            {
                MessageBox.Show("TIENE QUE INGRESAR POR LO MENOS UN PRODUCTO", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDetalle.Focus();
                return false;
            }
            else if (cboVendedor.SelectedValue.ToString() != string.Empty)
            {
                if (Convert.ToInt32(cboVendedor.SelectedValue) == -1)
                {
                    MessageBox.Show("SELECCIONE UN VENDEDOR", "VENDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboVendedor.Focus();
                    return false;
                }
            }            

            //Verificamos Limite de Credito del Cliente
            if (cboTipoVenta.Text == "CREDITO")
            {
                try
                {
                    var estado = DListarPersonalizado.Dato("select 1 from Cliente where EstadoLimCredit=1 and ClienteID=" + cboCliente.ValueMember);
                    if (estado != null)
                    {
                        var resul = DListarPersonalizado.Dato(string.Format("SELECT DISTINCT 1 FROM Vista_Saldos_Ventas WHERE ClienteID={0} " +
                        "AND LimiteCredito<(SELECT ISNULL(SUM(Monto-Abonado), 0) + {1} FROM Vista_Saldos_Ventas " +
                        "WHERE ClienteID={2})", cboCliente.ValueMember, Convert.ToDecimal(txtTotales.Text), cboCliente.ValueMember));
                        if (resul != null)
                        {
                            MessageBox.Show(string.Format("EL CLIENTE {0}, SOBREPASÓ SU LÍMITE DE CRÉDITO", cboCliente.Text),
                                "LÍMITE DE CRÉDITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboVendedor.Focus();
                            return false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR AL CONSULTAR EL LÍMITE DE CRÉDITO DEL CLIENTE, INTENTE MAS TARDE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }

            //Verificamos todas las filas en busca de errores
            for (int i = 0; i < dgvDetalle.Rows.Count - 1; i++)
            {
                if (dgvDetalle["ProductoID", i].Value == null)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1) + ", TIENE QUE INGRESAR UN PRODUCTO", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["ProductoID"];
                    return false;
                }
                else if (dgvDetalle["Producto", i].Value.ToString() == string.Empty)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1) + ", TIENE QUE INGRESAR UN PRODUCTO");
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["ProductoID"];
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Cantidad", i].Value) <= 0)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1) + ", LA CANTIDAD TIENE QUE SER MAYOR A CERO", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["Cantidad"];
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Precio", i].Value) <= 0)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1) + ", EL PRECIO UNITARIO TIENE QUE SER MAYOR A CERO", "PRECIO UNITARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["Precio"];
                    return false;
                }
                else if ((Convert.ToDecimal(dgvDetalle["Precio", i].Value) < Convert.ToDecimal(dgvDetalle["UltPrecio", i].Value)) && DConstantes.General.RESTRING_PRECIOS_VENTAS)
                {
                    MessageBox.Show("VERIFIQUE LA FILA " + (i + 1) + ", EL PRECIO UNITARIO NO PUEDE SER MENOR QUE " + string.Format("{0:#,##0.00}", dgvDetalle["UltPrecio", i].Value), "PRECIO UNITARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["Precio"];
                    return false;
                }

                //Si el producto es diferente a servicio o combo
                if (DConstantes.Clasificacion.Servicio != Convert.ToInt32(dgvDetalle["ClasificacionID", i].Value) &&
                    DConstantes.Clasificacion.Combo != Convert.ToInt32(dgvDetalle["ClasificacionID", i].Value) &&
                    (bool)dgvDetalle["Comodin", i].Value == false)
                {
                    //Verificamos el Stock
                    try
                    {
                        var result = DListarPersonalizado.Dato("SELECT 1 FROM Stock_Prod WHERE AlmacenID=" + OConexionGlobal.SucursalID +
                        " AND ProductoID=" + dgvDetalle["ProductoID", i].Value + " AND StockAlmacen<" + dgvDetalle["Cantidad", i].Value);

                        if (result != null)
                        {
                            MessageBox.Show("VERIFIQUE LA FILA " + (i + 1) + ", LA CANTIDAD NO PUEDE SER MAYOR A LA QUE HAY EN STOCK", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("VERIFIQUE SU CONEXION, ERROR AL CONECTARSE A LA BASE DE DATOS PARA VERIFICAR EL STOCK", "STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private void ListarTipoCambio()
        {
            try
            {
                var objTC = DListarPersonalizado.Dato("SELECT TOP 1 TCVenta FROM Tipo_Cambio ORDER BY Fecha DESC");
                if (objTC != null)
                {
                    if (!string.IsNullOrEmpty(objTC.ToString()))
                        txtTC.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(objTC));
                    else
                        txtTC.Text = "6.96";
                }
                else
                    txtTC.Text = "6.96";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarTipoVenta()
        {
            try
            {
                cboTipoVenta.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND Tupla='VENTA' ORDER BY NomTipo");
                cboTipoVenta.DisplayMember = "NomTipo";
                cboTipoVenta.ValueMember = "TipoID";
                cboTipoVenta.SelectedValue = 4; //por defecto 4=CONTADO
                cboTipoVenta.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Vendedor()
        {
            try
            {
                //verificamos la configuracion de los vendedores
                var config = DListarPersonalizado.Dato("select Valor from Configuracion where Variable='VER_SOLO_VENDEDOR'");
                string consultasql = "SELECT PersonalID, NomPer FROM Personal WHERE Estado=1 AND CargoID IN(2, 3)";

                if (!Convert.ToBoolean(config))
                    consultasql += "UNION SELECT NULL, '[SIN VENDEDOR]' UNION SELECT -1, '[SELECCIONE UN VENDEDOR...]' ORDER BY NomPer";

                DataTable VendDT = DListarPersonalizado.ConsultarDT(consultasql);
                //llenamos la lista de todo el personal
                cboVendedor.DataSource = VendDT;    //NPersonal.NListarPersonales("Personal", -1).FindAll(x => x.SucursalID == OConexionGlobal.SucursalID).FindAll(y => y.Estado).FindAll(z => (z.CargoID == 2) || (z.CargoID == 3)).OrderBy(z => z.NomPer).ToList();
                cboVendedor.DisplayMember = "NomPer";
                cboVendedor.ValueMember = "PersonalID";
                
                string valor = "PersonalID=" + OConexionGlobal.PersonalID;

                if (VendDT.Select(valor).Length > 0)
                    cboVendedor.SelectedValue = OConexionGlobal.PersonalID;

                cboVendedor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarVenta()
        {
            DataSet VentaDS;
            try
            {
                if (TipoRegul == "Pedido")
                    VentaDS = DListarPersonalizado.ConsultarDS("SELECT * FROM Pedido WHERE CodPedido='" + txtCodigoNota.Text + "'; " +
                    "SELECT * FROM Vista_Detalle_Pedidos WHERE CodVenta='" + txtCodigoNota.Text + "'; " +
                    "SELECT ISNULL(SUM(Monto-Cambio), 0)MontoAbonado FROM Pago WHERE Estado=1 AND CodPedido='" + txtCodigoNota.Text + "'");
                else
                    VentaDS = DListarPersonalizado.ConsultarDS("SELECT * FROM Venta WHERE CodVenta='" + txtCodigoNota.Text + "';" +
                    "SELECT * FROM Listar_Detalle_Venta_Stock WHERE CodVenta='" + txtCodigoNota.Text + "'; " +
                    "SELECT ISNULL(SUM(MontoAbono-DsctoAbono), 0)MontoAbonado FROM Vista_Detalle_Abonos WHERE CodNota='" + txtCodigoNota.Text + "' " +
                    "AND TipoNota='CREDITO'");

                if (VentaDS.Tables[0].Rows.Count > 0)
                {
                    if (TipoRegul == "Pedido")
                    {
                        cboTipoVenta.Text = "CONTADO";
                        cboTipoVenta.Enabled = false;
                        cboCliente.Enabled = false;
                        btnBusqClient.Enabled = false;
                        cboVendedor.Enabled = false;
                        lblFecha.Text = "REGULARIZACIÓN PEDIDO";
                        panelSaldo.Visible = true;
                    }
                    else
                        cboTipoVenta.Text = VentaDS.Tables[0].Rows[0]["TipoVenta"].ToString();


                    object montoabonado = VentaDS.Tables[2].Rows[0]["MontoAbonado"];                    
                    txtRef.Text = VentaDS.Tables[0].Rows[0]["Referencia"].ToString();
                    cboVendedor.SelectedValue = VentaDS.Tables[0].Rows[0]["VendedorID"];
                    txtObs.Text = VentaDS.Tables[0].Rows[0]["Detalle"].ToString();

                    txtDscto.Text = string.Format("{0:#,##0.00}", VentaDS.Tables[0].Rows[0]["DsctoBs"]);
                    txtTotales.Text = string.Format("{0:#,##0.00}", VentaDS.Tables[0].Rows[0]["MontoBs"]);
                    txtSubtotal.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotales.Text) + Convert.ToDecimal(txtDscto.Text));
                    txtAnticipo.Text = string.Format("{0:#,##0.00}", (Convert.ToDecimal(VentaDS.Tables[0].Rows[0]["AnticipoBs"]) +
                        (montoabonado != null ? Convert.ToDecimal(montoabonado) : 0)));
                    txtSaldo.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotales.Text) - Convert.ToDecimal(txtAnticipo.Text));

                    foreach (DataRow item in VentaDS.Tables[1].Rows)
                    {

                        object stk = DListarPersonalizado.Dato("SELECT StockAlmacen FROM Stock_Prod WHERE AlmacenID=" + VentaDS.Tables[0].Rows[0]["SucursalID"].ToString() +
                           " AND ProductoID=" + item["ProductoID"].ToString());

                        if ((Convert.ToDecimal(stk) < Convert.ToDecimal(item["Cantidad"])) &&
                            (int)item["ClasificacionID"] != DConstantes.Clasificacion.Servicio &&
                            (int)item["ClasificacionID"] != DConstantes.Clasificacion.Combo)
                        {
                            DialogResult dialogo = MessageBox.Show("NO PUEDE REGULARIZAR EL PRODUCTO " + item["NomProd"].ToString() +
                                " PORQUE EN STOCK TIENE " + string.Format("{0:#,##0.00}", stk) + " " + item["UnidMedida"].ToString() +
                                " Y UD. NECESITA REGULARIZAR " + string.Format("{0:#,##0.00}", item["Cantidad"]) + " " + item["UnidMedida"].ToString() +
                                " ''!CANTIDAD MAYOR A LA QUE TIENE EN STOCK!'', ¿DESEA DE TODOS MODOS AGREGAR ESTE PRODUCTO A LA LISTA CON CANTIDAD " + string.Format("{0:#,##0.00}", (decimal)stk) + "?",
                                "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dialogo == DialogResult.Yes)
                                base.Agregar_ProductoDGV(-1, (int)item["ProductoID"], item["NomProd"].ToString(), item["UnidMedida"].ToString(),
                                    (decimal)stk, (decimal)stk, (decimal)item["PUnitario"], (decimal)item["PUnitario"], (decimal)item["Porcent_Dscto"], (decimal)item["Dscto"],
                                    (int)item["ClasificacionID"], (bool)item["Vencimiento"], (bool)item["Serial"], item["RegSanitario"].ToString(), null, (bool)item["Comodin"]);
                        }
                        else
                        {
                            Agregar_ProductoDGV(-1, (int)item["ProductoID"], item["NomProd"].ToString(), item["UnidMedida"].ToString(),
                                (decimal)stk, (decimal)item["Cantidad"], (decimal)item["PUnitario"], (decimal)item["PUnitario"], (decimal)item["Porcent_Dscto"],
                                (decimal)item["Dscto"], (int)item["ClasificacionID"], (bool)item["Vencimiento"], (bool)item["Serial"], item["RegSanitario"].ToString(),
                                null, (bool)item["Comodin"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCliente(Int32 cod, string nomcli)
        {
            cboCliente.Items.Clear();
            cboCliente.Items.Add(nomcli);
            cboCliente.ValueMember = cod.ToString();
            cboCliente.Text = nomcli;

            if (cboCliente.Text != "CLIENTES VARIOS")
                txtRef.Text = nomcli;
        }

        private void Frm_Venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmventa.Dispose();
            frmventa = null;
        }

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            btnAbriCerrarPanel.PerformClick();
            ListarTipoCambio();
            ListarTipoVenta();
            Listar_Vendedor();
            CargarCliente(1, "CLIENTES VARIOS");
           
            if (txtCodigoNota.Text != "-1")
                ListarVenta();

            Cargado = true;

            txtCodBarra.Focus();
        }

        private void btnBusqClient_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bcli = new Buscadores.Buscador();
            bcli.Opcion = "Cliente";
            bcli.Owner = this;
            bcli.ShowDialog();

            CargarCliente(Convert.ToInt32(bcli.dgvDatos["ID", bcli.dgvDatos.CurrentRow.Index].Value),
                bcli.dgvDatos["Nombre", bcli.dgvDatos.CurrentRow.Index].Value.ToString());

            bcli.Dispose();
        }

        private void cboTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoVenta.Text == "CONTADO")
                panelSup.BackColor = Color.LightSeaGreen;
            else if (cboTipoVenta.Text == "CREDITO")
                panelSup.BackColor = Color.GreenYellow;
            else if (cboTipoVenta.Text == "ANTICIPADO")
                panelSup.BackColor = Color.LightPink;

            btnAbriCerrarPanel.BackColor = panelSup.BackColor;
            if (panelBusqProd.Width == 41)
                panelBusqProd.BackColor = panelSup.BackColor;
        }

        private void txtDscto_TextChanged(object sender, EventArgs e)
        {
            if (Cargado)
            {
                Cargado = false;

                decimal dscto, subtotal;

                if (!decimal.TryParse(txtDscto.Text, out dscto))
                {
                    txtDscto.Text = "0.00";
                    txtDscto.SelectAll();
                }                   

                subtotal =Convert.ToDecimal(txtSubtotal.Text);
                if (subtotal <= 0)
                {
                    txtDscto.Text = "0.00";
                    dscto = 0;
                    txtDscto.SelectAll();
                }
                else if (dscto >= Convert.ToDecimal(txtSubtotal.Text))
                {
                    dscto = Convert.ToDecimal(txtSubtotal.Text) - 1;
                    txtDscto.Text = string.Format("{0:#,##0.00}", dscto);
                    txtDscto.SelectAll();
                }
                txtTotales.Text = string.Format("{0:#,##0.00}", (Convert.ToDecimal(txtSubtotal.Text) - dscto));

                Cargado = true;
            }
        }
    }
}

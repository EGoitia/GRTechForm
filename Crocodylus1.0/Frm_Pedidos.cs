using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Pedidos : GRTechnology1._0.Frm_Base_Notas
    {
        public static Frm_Pedidos frmpedido = null;
        Frm_Pagos pag = null;

        public Frm_Pedidos()
        {
            InitializeComponent();
            pag = new Frm_Pagos();
        }

        public override void Borrar()
        {
            txtCodigoNota.Text = "-1";
            dgvDetalle.Rows.Clear();
            CargarCliente(1, "CLIENTES VARIOS");
            cboVendedor.SelectedValue = -1;
            txtSubtotal.Text = "0.00";
            txtTotales.Text = "0.00";
            txtRef.Clear();
            txtObs.Clear();

            txtNumNota.Visible = false;

        }

        public override void Totales()
        {
            if (!Cargado)
                return;

            Cargado = false;

            decimal cant = 0, precio = 0, monto = 0;
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

                dgvDetalle["Importe", i].Value = Math.Round(cant * precio, 2);
                monto += (cant * precio);
            }

            dgvDetalle.Refresh();
            txtSubtotal.Text = string.Format("{0:#,##0.00}", monto);
            txtTotales.Text = string.Format("{0:#,##0.00}", monto - Convert.ToDecimal(txtDscto.Text));

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
                
                //Detalle de la modificacion
                string DetaModif = string.Empty;
                decimal Anticipo = 0;
                if (txtCodigoNota.Text != "-1")
                {
                    Frm_DetaModifAnul modif = new Frm_DetaModifAnul("MODIFICAR");
                    modif.ShowDialog();
                    if (!modif.Cancelado)
                        DetaModif = modif.DetaModAnul();

                    modif.Dispose();
                }
                else
                {
                    DialogResult dialogo = MessageBox.Show("¿DESEA DAR UN ANTICIPO?", "ANTICIPO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.Yes)
                    {
                        pag.Borrar();
                        pag.MontoMax = Convert.ToDecimal(txtTotales.Text);
                        pag.txtMontoBs.Text = string.Format("{0:#,##0.00}", txtTotales.Text);
                        pag.txtMontoSus.Text = string.Format("{0:#,##0.00}", (Convert.ToDecimal(txtTotales.Text) / Convert.ToDecimal(txtTC.Text)));
                        pag.ShowDialog();
                        if (!pag.Aceptado)
                            return;


                        //Anticipo
                        //Frm_Pagos pag = new Frm_Pagos();
                        //pag.MontoMax = Convert.ToDecimal(txtTotales.Text);
                        //pag.txtMontoBs.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotales.Text));
                        //pag.ShowDialog();

                        //if (pag.Aceptado)
                        //    Anticipo = Convert.ToDecimal(pag.txtEfectivoBs.Text);

                        //pag.Dispose();
                    }
                }

                OVenta OVen = new OVenta();
                OVen.CodVenta = txtCodigoNota.Text;
                OVen.ClienteID = Convert.ToInt32(cboCliente.ValueMember);
                OVen.AlmacenID = OConexionGlobal.SucursalID;

                if (cboVendedor.SelectedValue.ToString() != string.Empty)
                    OVen.VendedorID = (int)cboVendedor.SelectedValue;

                OVen.Referencia = txtRef.Text;
                OVen.Detalle = txtObs.Text;
                OVen.TC = Convert.ToDecimal(txtTC.Text);
                OVen.Monto = Convert.ToDecimal(txtTotales.Text);
                OVen.Dscto = Convert.ToDecimal(txtDscto.Text);
                OVen.Anticipo = Anticipo;
                OVen.DetalleVentaDT = InsertDetalle();
                OVen.DetallePagoDT = InsertDetallePago();
                OVen.UbicacionDT = InsertUbicacion();

                txtCodigoNota.Text = DVenta.DInsertModifPedido(OVen, OInmode.DTInmode("", (txtCodigoNota.Text == "-1" ? "NUEVO" : "MODIFICAR"), DetaModif));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (txtCodigoNota.Text != "-1")
                {
                    try
                    {
                        if (DConstantes.Imprimir.Nota_Pedido.IMP_NOTA_PEDIDO)
                        {
                            List<string> consulta = new List<string>() 
                             { 
                                "SELECT * FROM Vista_Pedidos WHERE CodVenta='" + txtCodigoNota.Text + "'",
                                "SELECT * FROM Vista_Detalle_Pedidos WHERE CodVenta='" + txtCodigoNota.Text + "'",
                            };
                            List<string> nomconsulta = new List<string>() { "Lista_Venta", "Detalle_Venta", };

                            Imprimir(consulta, nomconsulta, "NOTA DE PEDIDO",
                                DConstantes.Imprimir.Nota_Pedido.NOM_REPORTE_NOTA_PEDIDO,
                                DConstantes.Imprimir.Nota_Pedido.IMPAUTOMATIC_NOTA_PEDIDO,
                                DConstantes.Imprimir.Nota_Pedido.VISUALIZAR_NOTA_PEDIDO,
                                DConstantes.Imprimir.Nota_Pedido.MOSTRAR_BTN_IMP,
                                DConstantes.Imprimir.Nota_Pedido.MOSTRAR_BTN_COPIAR,
                                DConstantes.Imprimir.Nota_Pedido.MOSTRAR_BTN_EXPORT,
                                DConstantes.Imprimir.Nota_Pedido.MOSTRAR_ARBOL);
                        }
                        else
                            MessageBox.Show(DConstantes.Mensajes.MensajeExito, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ListarProductos();
                    Borrar();
                }

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        public DataTable InsertUbicacion()
        {
            DataTable UbicDT = new DataTable();
            UbicDT.Columns.Add("CodUbicacion");
            UbicDT.Columns.Add("PaisID");
            UbicDT.Columns.Add("DptoEstado");
            UbicDT.Columns.Add("Ciudad");
            UbicDT.Columns.Add("Zona");
            UbicDT.Columns.Add("Barrio");
            UbicDT.Columns.Add("Direccion");
            UbicDT.Columns.Add("Descripcion_Direccion");
            UbicDT.Columns.Add("Latitud");
            UbicDT.Columns.Add("Longitud");
            UbicDT.Columns.Add("Altura");
            UbicDT.Columns.Add("Exactitud");
            UbicDT.Columns.Add("Escala");

            return UbicDT;
        }

        public DataTable InsertDetallePago()
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

            return DetDT;
        }

        private bool Verificar()
        {
            //-----------------------------------//
            //porque no se puede guardar una nota//
            //----------------------------------//
            //1.-Que la Venta sea al contado y su saldo sea diferente de cero
            //2.-En un Pago Anticipado, no abone nada
            //3.-Que el detalle este vacio
            //4.-Que en el detalle no haya ingresado la cantidad o el precio
            //5.-Que en el detalle no haya ingresado un Item
            //6.-Que en el detalle la cantidad ingresada sea menoy o igual a cero
            //7.-Que la venta al contado, credito y anticipado sea mayor a cero
            //8.-las Devoluciones que sean menor a cero

            if (string.IsNullOrWhiteSpace(txtRef.Text))
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
                    MessageBox.Show("VERIFIQUE EN LA FILA " + (i + 1) + ", LA CANTIDAD TIENE QUE SER MAYOR A CERO", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["Cantidad"];
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Precio", i].Value) <= 0)
                {
                    MessageBox.Show("VERIFIQUE EN LA FILA " + (i + 1) + ", EL PRECIO UNITARIO TIENE QUE SER MAYOR A CERO", "PRECIO UNITARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["Precio"];
                    return false;
                }
                else if ((Convert.ToDecimal(dgvDetalle["Precio", i].Value) < Convert.ToDecimal(dgvDetalle["UltPrecio", i].Value)) && DConstantes.General.RESTRING_PRECIOS_VENTAS)
                {
                    MessageBox.Show("VERIFIQUE EN LA FILA " + (i + 1) + ", EL PRECIO UNITARIO NO PUEDE SER MENOR QUE " + string.Format("{0:#,##0.00}", dgvDetalle["UltPrecio", i].Value), "PRECIO UNITARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["Precio"];
                    return false;
                }
            }

            return true;
        }

        private void Listar_Vendedor()
        {
            try
            {
                DataTable VendDT = DListarPersonalizado.ConsultarDT("SELECT PersonalID, NomPer FROM Personal WHERE CargoID IN(2, 3) UNION SELECT NULL, '[SIN VENDEDOR]' UNION SELECT -1, '[SELECCIONE UN VENDEDOR...]' ORDER BY NomPer");
                //llenamos la lista de todo el personal
                cboVendedor.DataSource = VendDT;    //NPersonal.NListarPersonales("Personal", -1).FindAll(x => x.SucursalID == OConexionGlobal.SucursalID).FindAll(y => y.Estado).FindAll(z => (z.CargoID == 2) || (z.CargoID == 3)).OrderBy(z => z.NomPer).ToList();
                cboVendedor.DisplayMember = "NomPer";
                cboVendedor.ValueMember = "PersonalID";

                string valor = "PersonalID=" + OConexionGlobal.UsuarioID;

                if (VendDT.Select(valor).Length > 0)
                    cboVendedor.SelectedValue = OConexionGlobal.UsuarioID;

                cboVendedor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarPedido()
        {
            DataSet PedidoDS;
            try
            {
                PedidoDS = DListarPersonalizado.ConsultarDS("SELECT * FROM Vista_Pedidos WHERE CodVenta='" + txtCodigoNota.Text + "'; " +
                    "SELECT * FROM Vista_Detalle_Pedidos WHERE CodVenta='" + txtCodigoNota.Text + "'");

                if (PedidoDS.Tables[0].Rows.Count > 0)
                {
                    CargarCliente(Convert.ToInt32(PedidoDS.Tables[0].Rows[0]["ClienteID"]), PedidoDS.Tables[0].Rows[0]["NomClien"].ToString());
                    txtRef.Text = PedidoDS.Tables[0].Rows[0]["Referencia"].ToString();
                    cboVendedor.SelectedValue = PedidoDS.Tables[0].Rows[0]["VendedorID"];
                    txtObs.Text = PedidoDS.Tables[0].Rows[0]["Detalle"].ToString();

                    txtDscto.Text = string.Format("{0:#,##0.00}", PedidoDS.Tables[0].Rows[0]["DsctoBs"]);
                    txtTotales.Text = string.Format("{0:#,##0.00}", PedidoDS.Tables[0].Rows[0]["MontoBs"]);
                    txtSubtotal.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotales.Text) + Convert.ToDecimal(txtDscto.Text));
                    
                    foreach (DataRow item in PedidoDS.Tables[1].Rows)
                    {

                        object stk = DListarPersonalizado.Dato("SELECT StockAlmacen FROM Stock_Prod WHERE AlmacenID=" + PedidoDS.Tables[0].Rows[0]["SucursalID"].ToString() +
                           " AND ProductoID=" + item["ProductoID"].ToString());

                        Agregar_ProductoDGV(-1, (int)item["ProductoID"], item["NomProd"].ToString(), item["UnidMedida"].ToString(),
                                (decimal)stk, (decimal)item["Cantidad"], (decimal)item["PUnitario"], (decimal)item["PUnitario"], (decimal)item["Porcent_Dscto"],
                                (decimal)item["Dscto"], (int)item["ClasificacionID"], (bool)item["Vencimiento"], (bool)item["Serial"], item["RegSanitario"].ToString(),
                                null, (bool)item["Comodin"]);
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

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            Listar_Vendedor();
            CargarCliente(1, "CLIENTES VARIOS");

            if (txtCodigoNota.Text != "-1")
                ListarPedido();

            Cargado = true;
        }

        private void FrmPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmpedido.Dispose();
            frmpedido = null;
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

                subtotal = Convert.ToDecimal(txtSubtotal.Text);
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

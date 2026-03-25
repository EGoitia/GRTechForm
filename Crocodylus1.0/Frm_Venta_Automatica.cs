using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Venta_Automatica : GRTechnology1._0.Frm_Base_Notas
    {
        public static Frm_Venta_Automatica frmventaaut = null;

        public Frm_Venta_Automatica()
        {
            InitializeComponent();
        }

        public override void Borrar()
        {
            txtCodigoNota.Text = "-1";
            dgvDetalle.Rows.Clear();
            CargarCliente(1, "CLIENTES VARIOS");
            txtSubtotal.Text = "0.00";
            txtDscto.Text = "0.00";
            txtTotales.Text = "0.00";
            txtObs.Clear();

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
                        DConstantes.Clasificacion.Servicio != (int)dgvDetalle["ClasificacionID", i].Value)
                    {
                        if (cant > Convert.ToDecimal(dgvDetalle["Stock", i].Value))
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

            Cargado = true;
        }

        public override void InsertModifNota()
        {
            if (!Verificar())
                return;

            try
            {
                string DetaModif = string.Empty;
                if (txtCodigoNota.Text != "-1")
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

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;

                OVenta OVen = new OVenta();
                OVen.CodVenta = txtCodigoNota.Text;
                OVen.TipoVentaID = 0;
                OVen.ClienteID = Convert.ToInt32(cboCliente.ValueMember);
                OVen.AlmacenID = OConexionGlobal.SucursalID;
                OVen.Detalle = txtObs.Text;
                OVen.DetalleVentaDT = InsertDetalle();
                OVen.Monto = Convert.ToDecimal(txtTotales.Text);
                OVen.Dscto = Convert.ToDecimal(txtDscto.Text);
                OVen.TC = Convert.ToDecimal(txtTC.Text);

                txtCodigoNota.Text = DVenta.DInsertModifVenta(OVen, OInmode.DTInmode("", (txtCodigoNota.Text == "-1" ? "NUEVO" : "MODIFICAR"), DetaModif));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;

                if (txtCodigoNota.Text != "-1")
                {
                    if (DConstantes.Imprimir.Nota_Venta.IMP_NOTA_VENTA)
                    {
                        List<string> consulta = new List<string>() 
                        { 
                            "SELECT * FROM Vista_Ventas WHERE CodVenta='" + txtCodigoNota.Text + "'",
                            "SELECT * FROM Vista_Detalle_Ventas WHERE CodVenta='" + txtCodigoNota.Text + "'",
                        };
                        List<string> nomconsulta = new List<string>() { "Lista_Venta", "Detalle_Venta", };

                        Imprimir(consulta, nomconsulta, "NOTA DE VENTA",
                                 DConstantes.Imprimir.Nota_Venta.NOM_REPORTE_NOTA_VENTA,
                                 DConstantes.Imprimir.Nota_Venta.IMPAUTOMATIC_NOTA_VENTA,
                                 DConstantes.Imprimir.Nota_Venta.VISUALIZAR_NOTA_VENTA,
                                 DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_IMP,
                                 DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_COPIAR,
                                 DConstantes.Imprimir.Nota_Venta.MOSTRAR_BTN_EXPORT,
                                 DConstantes.Imprimir.Nota_Venta.MOSTRAR_ARBOL);
                    }                        
                    else
                        MessageBox.Show(DConstantes.Mensajes.MensajeExito, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarProductos();
                    Borrar();
                }
            }
        }

        private bool Verificar()
        {
            //-----------------------------------//
            //porque no se puede guardar una nota//
            //----------------------------------//
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

            if (Convert.ToInt32(cboCliente.ValueMember) == 1)
            {
                MessageBox.Show("LA VENTA A CRÉDITO NO ESTA HABILITADO PARA CLIENTES VARIOS", "CRÉDITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnBusqClient.Focus();
                return false;
            }
            else if (dgvDetalle.Rows.Count <= 1)
            {
                MessageBox.Show("TIENE QUE INGRESAR POR LO MENOS UN PRODUCTO", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDetalle.Focus();
                return false;
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
                    DConstantes.Clasificacion.Combo != Convert.ToInt32(dgvDetalle["ClasificacionID", i].Value))
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
        
        private void ListarVentaAutomatic()
        {
            DataSet VentaDS;
            try
            {
                VentaDS = DListarPersonalizado.ConsultarDS("SELECT * FROM Venta WHERE CodVenta='" + txtCodigoNota.Text + "';" +
                     "SELECT * FROM Listar_Detalle_Venta_Stock WHERE CodVenta='" + txtCodigoNota.Text + "'; " +
                     "SELECT ISNULL(SUM(MontoAbono-DsctoAbono), 0)MontoAbonado FROM Vista_Detalle_Abonos WHERE CodNota='" + txtCodigoNota.Text + "' " +
                     "AND TipoNota='CREDITO'"); 

                if (VentaDS.Tables[0].Rows.Count > 0)
                {
                    txtObs.Text = VentaDS.Tables[0].Rows[0]["Detalle"].ToString();
                    txtDscto.Text = string.Format("{0:#,##0.00}", VentaDS.Tables[0].Rows[0]["DsctoBs"]);
                    txtTotales.Text = string.Format("{0:#,##0.00}", VentaDS.Tables[0].Rows[0]["MontoBs"]);
                    txtSubtotal.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(txtTotales.Text) + Convert.ToDecimal(txtDscto.Text));
                    
                    foreach (DataRow item in VentaDS.Tables[1].Rows)
                    {

                        object stk = DListarPersonalizado.Dato("SELECT StockAlmacen FROM Stock_Prod WHERE AlmacenID=" + VentaDS.Tables[0].Rows[0]["AlmacenID"].ToString() +
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
                                    (int)item["ClasificacionID"], (bool)item["Vencimiento"], (bool)item["Serial"], item["RegSanitario"].ToString());
                        }
                        else
                        {
                            Agregar_ProductoDGV(-1, (int)item["ProductoID"], item["NomProd"].ToString(), item["UnidMedida"].ToString(),
                                (decimal)stk, (decimal)item["Cantidad"], (decimal)item["PUnitario"], (decimal)item["PUnitario"], (decimal)item["Porcent_Dscto"],
                                (decimal)item["Dscto"], (int)item["ClasificacionID"], (bool)item["Vencimiento"], (bool)item["Serial"], item["RegSanitario"].ToString());
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
        }

        private void Frm_Venta_Automatica_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmventaaut.Dispose();
            frmventaaut = null;
        }

        private void Frm_Venta_Automatica_Load(object sender, EventArgs e)
        {
            CargarCliente(1, "CLIENTES VARIOS");

            Cargado = true;
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

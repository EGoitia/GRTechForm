using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Cotizacion : GRTechnology1._0.Frm_Base_Notas
    {
        public static Frm_Cotizacion frmcotiz = null;

        public Frm_Cotizacion()
        {
            InitializeComponent();
        }

        public override void Borrar()
        {
            txtCodigoNota.Text = "-1";
            dgvDetalle.Rows.Clear();
            CargarCliente(1, "CLIENTES VARIOS");
            cboVendedor.SelectedValue = -1;
            cboCodCom.SelectedValue = -1;
            NumUpDownValidez.Value = 0;
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
            txtTotales.Text = string.Format("{0:#,##0.00}", monto);
            
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

                OCotizacion OCotiz = new OCotizacion();
                OCotiz.CodCotizacion = txtCodigoNota.Text;
                OCotiz.ClienteID = Convert.ToInt32(cboCliente.ValueMember);
                OCotiz.AlmacenID = OConexionGlobal.SucursalID;
                OCotiz.VendedorID = (int)cboVendedor.SelectedValue;
                OCotiz.CondComID = (int)cboCodCom.SelectedValue;
                OCotiz.DiasValidez = (int)NumUpDownValidez.Value;
                OCotiz.Referencia = txtRef.Text;
                OCotiz.Detalle = txtObs.Text;
                OCotiz.DetalleCotizacionDT = InsertDetalle();
                OCotiz.Monto = Convert.ToDecimal(txtTotales.Text);
                OCotiz.Dscto = 0;

                txtCodigoNota.Text = DCotizacion.DInsertModifCotizacion(OCotiz, OInmode.DTInmode("", (txtCodigoNota.Text == "-1" ? "NUEVO" : "MODIFICAR"), DetaModif));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (txtCodigoNota.Text != "-1")
                {
                    if (DConstantes.Imprimir.Nota_Cotizacion.IMP_NOTA_COTIZACION)
                    {
                        List<string> consulta = new List<string>() 
                            { 
                                "SELECT * FROM Vista_Cotizacion WHERE CodCotizacion='" + txtCodigoNota.Text + "'",
                                "SELECT * FROM Vista_Detalle_Cotizacion WHERE CodCotizacion='" + txtCodigoNota.Text + "'",
                            };
                        List<string> nomconsulta = new List<string>() { "Lista_Cotizacion", "Detalle_Cotizacion", };

                        Imprimir(consulta, nomconsulta, "NOTA DE COTIZACIÓN",
                                 DConstantes.Imprimir.Nota_Cotizacion.NOM_REPORTE_NOTA_COTIZACION,
                                 DConstantes.Imprimir.Nota_Cotizacion.IMPAUTOMATIC_NOTA_COTIZACION,
                                 DConstantes.Imprimir.Nota_Cotizacion.VISUALIZAR_NOTA_COTIZACION,
                                 DConstantes.Imprimir.Nota_Cotizacion.MOSTRAR_BTN_IMP,
                                 DConstantes.Imprimir.Nota_Cotizacion.MOSTRAR_BTN_COPIAR,
                                 DConstantes.Imprimir.Nota_Cotizacion.MOSTRAR_BTN_EXPORT,
                                 DConstantes.Imprimir.Nota_Cotizacion.MOSTRAR_ARBOL);
                    }
                    else
                        MessageBox.Show(DConstantes.Mensajes.MensajeExito, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                    ListarProductos();
                    Borrar();

                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                }
            }
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
            else if (Convert.ToInt32(cboVendedor.SelectedValue) == -1)
            {
                MessageBox.Show("SELECCIONE UN VENDEDOR", "VENDEDOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboVendedor.Focus();
                return false;
            }
             else if (Convert.ToInt32(cboCodCom.SelectedValue) == -1)
             {
                 MessageBox.Show("SELECCIONE UNA CONDICIÓN COMERCIAL", "CONDICIÓN COMERCIAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 cboCodCom.Focus();
                 return false;
             }

            //Verificamos todas las filas en busca de errores
            for (int i = 0; i < dgvDetalle.Rows.Count - 1; i++)
            {
                if (dgvDetalle["ProductoID", i].Value.ToString() == null)
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", TIENE QUE INGRESAR UN PRODUCTO", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["ProductoID"];
                    return false;
                }
                else if (dgvDetalle["Producto", i].Value.ToString() == string.Empty)
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", TIENE QUE INGRESAR UN PRODUCTO");
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["ProductoID"];
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Cantidad", i].Value) <= 0)
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", LA CANTIDAD TIENE QUE SER MAYOR A CERO", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["Cantidad"];
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Precio", i].Value) <= 0)
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", EL PRECIO UNITARIO TIENE QUE SER MAYOR A CERO", "PRECIO UNITARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle.Focus();
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[i].Cells["Precio"];
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Precio", i].Value) < Convert.ToDecimal(dgvDetalle["UltPrecio", i].Value))
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", EL PRECIO UNITARIO NO PUEDE SER MENOR QUE " + string.Format("{0:#,##0.00}", dgvDetalle["UltPrecio", i].Value), "PRECIO UNITARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                cboVendedor.DataSource = DListarPersonalizado.ConsultarDT("SELECT PersonalID, NomPer FROM Personal WHERE CargoID IN(2, 3) UNION SELECT -1, '[SELECCIONE UN VENDEDOR]' ORDER BY NomPer");
                cboVendedor.DisplayMember = "NomPer";
                cboVendedor.ValueMember = "PersonalID";
                cboVendedor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Listar_Condicion_Comercial()
        {
            try
            {
                cboCodCom.DataSource = DListarPersonalizado.ConsultarDT("SELECT CondComID, Titulo FROM Condicion_Comercial WHERE Estado=1 UNION SELECT -1, '[SELECCIONE UNA CONDICIÓN COMERCIAL]' ORDER BY Titulo");
                cboCodCom.DisplayMember = "Titulo";
                cboCodCom.ValueMember = "CondComID";
                cboCodCom.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarCotizacion()
        {
            try
            {
                DataSet VentaDS = DListarPersonalizado.ConsultarDS("SELECT * FROM Venta WHERE CodVenta='" + txtCodigoNota.Text + "';" +
                    "SELECT * FROM Listar_Detalle_Venta_Stock WHERE CodVenta='" + txtCodigoNota.Text + "'");

                if (VentaDS.Tables[0].Rows.Count > 0)
                {
                    txtRef.Text = VentaDS.Tables[0].Rows[0]["Referencia"].ToString();
                    cboVendedor.SelectedValue = VentaDS.Tables[0].Rows[0]["VendedorID"].ToString();
                    txtObs.Text = VentaDS.Tables[0].Rows[0]["Detalle"].ToString();
                    txtTotales.Text = string.Format("{0:#,##0.00}", VentaDS.Tables[0].Rows[0]["MontoBs"]);
                    
                    foreach (DataRow item in VentaDS.Tables[1].Rows)
                    {
                        
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

        private void Frm_Cotizacion_Load(object sender, EventArgs e)
        {
            Listar_Condicion_Comercial();
            Listar_Vendedor();
            CargarCliente(1, "CLIENTES VARIOS");

            Cargado = true;

            if (txtCodigoNota.Text != "-1")
                ListarCotizacion();
        }

        private void btnBusqClient_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bcli = new Buscadores.Buscador();
            bcli.Owner = this;
            bcli.ShowDialog();
            bcli.Dispose();
        }

        private void Frm_Cotizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmcotiz.Dispose();
            frmcotiz = null;
        }

        private void btnBusqCondCom_Click(object sender, EventArgs e)
        {
            Frm_Condicion_Comercial condcom = new Frm_Condicion_Comercial();
            condcom.ShowDialog();
            condcom.Dispose();
            Listar_Condicion_Comercial();
        }
    }
}

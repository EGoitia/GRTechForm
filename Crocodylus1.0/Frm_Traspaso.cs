using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Traspaso: GRTechnology1._0.Frm_Base_Notas
    {
        public static Frm_Traspaso frmtrasp = null;

        public Frm_Traspaso()
        {
            InitializeComponent();
        }

        public override void Borrar()
        {
            txtCodigoNota.Text = "-1";
            txtNumNota.Clear();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            cboAlmacenDe.SelectedValue = -1;
            cboAlmacenAl.SelectedValue = -1;
            txtObs.Clear();
            txtCantidad.Text = "0.00";
            dgvDetalle.Rows.Clear();
        }

        public override void Totales()
        {
            if (!Cargado)
                return;

            Cargado = false;

            decimal cant, canttot = 0;
            for (int i = 0; i < dgvDetalle.Rows.Count - 1; i++)
            {
                if (dgvDetalle["Cantidad", i].Value == null)
                    dgvDetalle["Cantidad", i].Value = 0;

                if (!decimal.TryParse(dgvDetalle["Cantidad", i].Value.ToString(), out cant))
                    dgvDetalle["Cantidad", i].Value = 0;

                if (Convert.ToDecimal(dgvDetalle["Stock", i].Value) < cant)
                {
                    MessageBox.Show("LA CANTIDAD NO PUEDE SER MAYOR QUE LA QUE HAY EN STOCK", "STOCK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvDetalle["Cantidad", i].Value = dgvDetalle["Stock", i].Value;
                    cant = Convert.ToDecimal(dgvDetalle["Stock", i].Value);
                }

                canttot += cant;
            }

            txtCantidad.Text = string.Format("{0:#,##0.00}", canttot);
            dgvDetalle.Refresh();

            Cargado = true;
        }

        public override void InsertModifNota()
        {
            try
            {
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;

                if (!Verificar())
                    return;

                string DetalleInmode = string.Empty;
                OTraspaso trasp = new OTraspaso();
                if (txtCodigoNota.Text == "-1")
                    trasp.CodTraspaso = "";
                else
                {
                    trasp.CodTraspaso = txtCodigoNota.Text;

                    //Cargamos Detalle Anulado
                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("MODIFICAR");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();

                    if (!dmodanul.Cancelado)
                        DetalleInmode = dmodanul.DetaModAnul();
                    else
                        throw new Exception("CANCELADO POR EL USUARIO");
                }

                trasp.DelAlmacenID = Convert.ToInt32(cboAlmacenDe.ValueMember);
                trasp.AlAlmacenID = Convert.ToInt32(cboAlmacenAl.SelectedValue);
                trasp.Detalle = txtObs.Text.Trim();
                trasp.DetalleTraspasoDT = InsertDetalle();

                txtCodigoNota.Text = DTraspaso.DInsertModifTrasp(trasp, OInmode.DTInmode("", (txtCodigoNota.Text == "-1" ? "NUEVO" : "MODIFICAR"), DetalleInmode));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (txtCodigoNota.Text != "-1")
                {
                    try
                    {
                        List<string> consulta = new List<string>() 
                        { 
                            "SELECT * FROM Vista_Traspaso WHERE CodTraspaso='" + txtCodigoNota.Text + "'",
                            "SELECT * FROM Vista_Detalle_Traspaso WHERE CodTraspaso='" + txtCodigoNota.Text + "'"
                        };
                        List<string> nomconsulta = new List<string>() { "Lista_Traspaso", "Detalle_Traspaso", };

                        if (DConstantes.Imprimir.Nota_Traspaso.IMP_NOTA_TRASPASO)
                            Imprimir(consulta, nomconsulta, "NOTA DE TRASPASO Nº",
                                     DConstantes.Imprimir.Nota_Traspaso.NOM_REPORTE_NOTA_TRASPASO,
                                     DConstantes.Imprimir.Nota_Traspaso.IMPAUTOMATIC_NOTA_TRASPASO,
                                     DConstantes.Imprimir.Nota_Traspaso.VISUALIZAR_NOTA_TRASPASO,
                                     DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_IMP,
                                     DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_COPIAR,
                                     DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_EXPORT,
                                     DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_ARBOL);
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

        private bool Verificar()
        {
            //-----------------------------------//
            //porque no se puede guardar una nota//
            //----------------------------------//
            //1.-Que el detalle de trasp este vacío
            //2.-Que en el detalle no haya ingresado la cantidad
            //3.-Que en el detalle no haya ingresado un Item
            //4.-Que en el detalle la cantidad ingresada sea menoy o igual a cero
            //5.-Que el traspaso sea al mismo almacen
            //6.-Que haya stock en el Almacen saliente


            if (dgvDetalle.Rows.Count <= 1)
            {
                MessageBox.Show("TIENE QUE INGRESAR POR LO MENOS UN PRODUCTO EN LA LISTA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvDetalle.Focus();
                return false;
            }
            else if ((int)cboAlmacenAl.SelectedValue == -1)
            {
                MessageBox.Show("SELECCIONE EL ALMACÉN DE DESTINO", "TRASPASO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAlmacenAl.Focus();
                return false;
            }
            else if (cboAlmacenDe.Text == cboAlmacenAl.Text)
            {
                MessageBox.Show("NO SE PUEDE HACER TRASPASO AL MISMO ALMACÉN", "TRASPASO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAlmacenAl.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtObs.Text))
            {
                MessageBox.Show("LA OBSERVACIÓN NO PUEDE ESTAR VACÍO", "TRASPASO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboAlmacenAl.Focus();
                return false;
            }

            //Verificamos todas las filas en busca de errores
            for (int i = 0; i < dgvDetalle.Rows.Count - 1; i++)
            {
                if (dgvDetalle["ProductoID", i].Value == null)
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", TIENE QUE INGRESAR UN PRODUCTO EN LA LISTA", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (string.IsNullOrEmpty(dgvDetalle["ProductoID", i].Value.ToString()))
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", TIENE QUE INGRESAR UN PRODUCTO EN LA LISTA", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (dgvDetalle["Producto", i].Value == null)
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", TIENE QUE INGRESAR UN PRODUCTO EN LA LISTA", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (string.IsNullOrEmpty(dgvDetalle["Producto", i].Value.ToString()))
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", TIENE QUE INGRESAR UN PRODUCTO EN LA LISTA", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (Convert.ToDecimal(dgvDetalle["Cantidad", i].Value) <= 0)
                {
                    MessageBox.Show("ERROR EN LA FILA " + (i + 1) + ", LA CANTIDAD TIENE QUE SER MAYOR A CERO", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                
                //Verificamos el Stock
                try
                {
                    var result = DListarPersonalizado.Dato("SELECT 1 FROM Stock_Prod WHERE AlmacenID=" + cboAlmacenDe.ValueMember +
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

            return true;
        }

        private void ListarAlmacen()
        {
            try
            {
                //Almacen de salida
                cboAlmacenDe.Items.Add(OConexionGlobal.NomSuc);
                cboAlmacenDe.ValueMember = OConexionGlobal.SucursalID.ToString();
                cboAlmacenDe.Text = OConexionGlobal.NomSuc;

                //Almacen de destino
                cboAlmacenAl.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 AND SucursalID<>" + OConexionGlobal.SucursalID.ToString() +
                    " UNION SELECT -1, '[SELECCIONE UN ALMACÉN]' ORDER BY NomSuc");
                cboAlmacenAl.DisplayMember = "NomSuc";
                cboAlmacenAl.ValueMember = "SucursalID";
                cboAlmacenAl.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_Traspaso_Load(object sender, EventArgs e)
        {
            ListarAlmacen();

            Cargado = true;
        }

        private void Frm_Traspaso_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmtrasp.Dispose();
            frmtrasp = null;
        }
    }
}

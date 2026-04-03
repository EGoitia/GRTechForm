using Datos;
using GRTechnology1._0.ControlUsuario;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Ingresos_EgresosPOS : Form
    {
        public static Frm_Ingresos_EgresosPOS frmgastingr = null;

        Frm_Reporte FrmRep = null;

        private DataTable DTTipoEgreso;
        private DataTable DTCuentas;
        //private DataTable DTCajas;

        TextBox txtActivo;

        IEnumerable<DataRow> DRCuentas = null;

        bool sw = true;
        int IDTipo = 0;
        int IDCuenta = 0;

        public Frm_Ingresos_EgresosPOS()
        {
            InitializeComponent();
        }

        #region Conexion Datos

        private void InsertModifNota()
        {
            if (!Verificar())
                return;


            OIngresoEgreso rec = null;
            try
            {
                btnGuardar.Enabled = false;

                rec = new OIngresoEgreso();
                rec.CodIngrEgre = string.Empty;
                rec.Concepto = txtConcepto.Text.Trim();
                rec.Detalle = txtDetalle.Text.Trim();
                //rec.TipoIngrEgre = cboTipo.Text;
                rec.VariosPersonActivID = 1; //varios;
                rec.SucursalID = OConexionGlobal.SucursalID;
                rec.CajaID = (int)cboCaja.SelectedValue;
                rec.Cuenta_Ingreso_EgresoID = IDCuenta;
                rec.PersonActivID = -1;
                //rec.Monto = Convert.ToDecimal(txtMontoBs.Text);
                //rec.TC = Convert.ToDecimal(txtTC.Text);                
                //rec.TipoPagoDT = InsertDetallePago();
                //rec.ReciboDT = recib.ReciboDT(rbRecibo.Checked);
                //rec.FacturaDT = fact.FacturaDT(rbFactura.Checked);

                string resp = DIngrEgre.DInsertModifIngrEgre(rec, OInmode.DTInmode("", "NUEVO", ""));
                if (resp != "-1")
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //BorrarCampos(gbxRecib, "");
                    //BorrarCampos(gbxTipPago, "0.00");
                    //txtTC.Text = "6.96";

                    //recib.Borrar_Recibo();
                    //fact.Borrar_Factura();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                rec = null;
                btnGuardar.Enabled = true;
            }
        }

        public void ListarTipoEgreso()
        {
            try
            {
                string ConsultaSQL = "select TipoID, NomTipo from Tipo where Estado=1 and Tupla='Egreso'";
                DTTipoEgreso = DListarPersonalizado.ConsultarLocalDT(ConsultaSQL);
                CargarTipoCuentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarCuentas()
        {
            try
            {
                string ConsultaSQL = "SELECT Cuenta_Ingreso_EgresoID, TipoIngresoEgreso, TipoCuentaID, Nombre " +
                     "FROM Cuenta_Ingresos_Egresos WHERE Estado=1";

                DTCuentas = DListarPersonalizado.ConsultarLocalDT(ConsultaSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_CajasUsuario()
        {
            try
            {
                cboCaja.DataSource = DListarPersonalizado.ConsultarDT("SELECT CajaID, NomCaja FROM Vista_Cajas_Usuario " +
                    "WHERE UsuarioID=" + OConexionGlobal.UsuarioID +
                    "UNION SELECT -1 CajaID, '[SELECCIONE UNA CAJA]' NomCaja ORDER BY NomCaja");
                cboCaja.DisplayMember = "NomCaja";
                cboCaja.ValueMember = "CajaID";
                cboCaja.Refresh();
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
                //Tipo
                string ConsultaSQL = "SELECT TipoID, NomTipo, Tupla, Estado FROM Tipo; ";
                //Cuentas Ingresos Egresos
                ConsultaSQL += "SELECT Cuenta_Ingreso_EgresoID, TipoIngresoEgreso, Nombre, Descripcion, TipoCuentaID, Estado " +
                     "FROM Cuenta_Ingresos_Egresos; ";


                DataSet ds = DListarPersonalizado.ConsultarDS(ConsultaSQL);

                //guardamos los tipos
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DTipo.InsertModif_TipoLocal(ds.Tables[0]);
                }

                //guardamos las cuentas
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
                {
                    DCuenta_Ingreso_Egreso.DInsertModifCuentaIngrEgreLocal(ds.Tables[1]);
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

        private void CargarTipoCuentas()
        {
            panelTipoEgreso.Controls.Clear();

            int cont = 0;
            foreach (DataRow item in DTTipoEgreso.Rows)
            {
                Button btn = new Button();
                IDTipo = item.Field<int>("TipoID");
                btn.BackColor = System.Drawing.Color.Crimson;
                btn.Name = IDTipo.ToString();
                btn.Text = item.Field<string>("NomTipo");
                lblTipoEgreso.Text = item.Field<string>("NomTipo");
                btn.Top = cont * 90;
                btn.Left = 7;
                btn.Width = 100;
                btn.Height = 90;

                panelTipoEgreso.Controls.Add(btn);
                cont++;

                btn.Click += new System.EventHandler(this.BotonTipo_Click);
            }

            //cargamos el producto segun el tipo de producto seleccionado
            DRCuentas = (from cuenta in DTCuentas.AsEnumerable()
                         select cuenta).Where(x => x.Field<int>("TipoCuentaID") == IDTipo);
            CargarCuentas();
        }

        private void CargarCuentas()
        {
            //borramos todos los controles
            panelCuentas.Controls.Clear();

            foreach (DataRow item in DRCuentas)
            {
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.LightGreen;
                btn.Name = item.Field<int>("Cuenta_Ingreso_EgresoID").ToString();
                btn.Text = item.Field<string>("Nombre");                
                btn.Width = 100;
                btn.Height = 90;

                panelCuentas.Controls.Add(btn);
                btn.Click += new System.EventHandler(this.BotonCuenta_Click);
            }
        }
        
        #endregion

        #region Funciones

        private void ListarDatos()
        {
            ListarCuentas();
            ListarTipoEgreso();           
            Listar_CajasUsuario();
            Autocompletar();
        }

        private void Autocompletar()
        {
            if (DTCuentas != null)
            {
                foreach (DataRow item in DTCuentas.Rows)
                {
                    txtBusqProd.AutoCompleteCustomSource.Add(item.Field<string>("Nombre"));
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

            return true;
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

            ////EFECTIVO
            //if (Convert.ToDecimal(FrmPago.txtEfec.Text) > 0)
            //{
            //    Fila = DetDT.NewRow();
            //    Fila["PagoID"] = 0;
            //    Fila["TipoPagoID"] = OConstantes.Tipo_Pago_EFECTIVO;
            //    Fila["Monto"] = Convert.ToDecimal(FrmPago.txtEfec.Text);
            //    Fila["Cambio"] = Convert.ToDecimal(FrmPago.txtTotCambio.Text);
            //    Fila["TC"] = 6.96;
            //    Fila["Estado"] = true;
            //    DetDT.Rows.Add(Fila);
            //}
            ////TRANSFERENCIA
            //if (Convert.ToDecimal(FrmPago.txtQR.Text) > 0)
            //{
            //    Fila = DetDT.NewRow();
            //    Fila["PagoID"] = 0;
            //    Fila["TipoPagoID"] = OConstantes.Tipo_Pago_TRANSFERENCIA;
            //    Fila["Monto"] = Convert.ToDecimal(FrmPago.txtQR.Text);
            //    Fila["Cambio"] = 0;
            //    Fila["TC"] = 6.96;
            //    //Fila["BancoID"] = FrmPago.cmbBancoDeposito.SelectedValue;
            //    //Fila["Banco1"] = FrmPago.cmbBancoDeposito.Text;
            //    //Fila["Numero1"] = FrmPago.TxtNroDeposito.Text;
            //    Fila["Estado"] = true;
            //    DetDT.Rows.Add(Fila);
            //}
           
            return DetDT;
        }

        private void Borrar()
        {
            
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
            else
                FrmRep.Dispose();
        }
               

        #endregion

        private void btnAbrirMenu_Click(object sender, EventArgs e)
        {
            if (sw)
            {
                panelLeft.Width = 40;
                panelTipoEgreso.Visible = false;
                panelCuentas.Visible = false;
                lblBusqProd.Visible = false;
                txtBusqProd.Visible = false;
                sw = false;
            }
            else
            {
                panelLeft.Width = 475;
                panelTipoEgreso.Visible = true;
                panelCuentas.Visible = true;
                lblBusqProd.Visible = true;
                txtBusqProd.Visible = true;
                sw = true;
            }
        }

        private void Frm_Ingresos_EgresosPOS_Load(object sender, EventArgs e)
        {
            panelLeft.Width = 475;
            txtActivo = txtConcepto;
            FrmRep = new Frm_Reporte();

            ListarDatos();
        }

        private void Frm_Ingresos_EgresosPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmgastingr.Dispose();
            frmgastingr = null;
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            Actualizar_Offline();
        }

        private void BotonTipo_Click(object sender, EventArgs e)
        {
            Button aux = (Button)sender; //Hacemos el casting

            //cargamos las cuentas segun el tipo de tipo seleccionado
            DRCuentas = (from cuenta in DTCuentas.AsEnumerable()
                         select cuenta).Where(x => x.Field<int>("TipoCuentaID").ToString() == aux.Name);
            lblTipoEgreso.Text = aux.Text;
            CargarCuentas();
        }

        private void BotonCuenta_Click(object sender, EventArgs e)
        {
            Button pbc = (Button)sender;
            IDCuenta = Convert.ToInt32(pbc.Name);
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
        
        private void txtConcepto_MouseClick(object sender, MouseEventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtConcepto;
            txtActivo.BackColor = Color.DodgerBlue;

            Process.Start(new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe",
                UseShellExecute = true
            });
        }

        private void txtDetalle_MouseClick(object sender, MouseEventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtDetalle;
            txtActivo.BackColor = Color.DodgerBlue;

            Process.Start(new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe",
                UseShellExecute = true
            });
        }

        private void txtMontoBs_MouseClick(object sender, MouseEventArgs e)
        {
            txtActivo.BackColor = Color.White;
            txtActivo = txtMontoBs;
            txtActivo.BackColor = Color.DodgerBlue;

            Process.Start(new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe",
                UseShellExecute = true
            });
        }

        //public static bool EsPantallaTactil()
        //{
        //    try
        //    {
        //        using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity"))
        //        {
        //            return searcher.Get().Cast<ManagementObject>()
        //                .Any(x => x["Name"] != null && x["Name"].ToString().ToLower().Contains("touch"));
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}

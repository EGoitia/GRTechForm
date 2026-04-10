using System;
using System.Windows.Forms;
using Objetos;
using Datos;
using GRTechnology1._0.ControlUsuario;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GRTechnology1._0
{
    public partial class Frm_Ingresos_Egresos : Form
    {
        public static Frm_Ingresos_Egresos frmgastingr = null;

        CntrUsuCheque cheque = null;
        CntrUsuDeposito deposito = null;
        CntrUsuTarjetas tarjeta = null;
        CntrUsuTransferencia transf = null;

        CntrUsuFactura fact = null;
        CntrUsuRecibo recib = null;

        private DataTable CuentaIngrEgreDT = null;
        private bool Cargado = false;

        public Frm_Ingresos_Egresos()
        {
            InitializeComponent();
        }
        
        #region Conexion Capa Negocio

        private void ListarCaja()
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

        private void Listar_TipoPago()
        {
            try
            {
                cboTipoPago.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo Where Estado=1 AND Tupla='PAGO' AND TipoID NOT IN(32) ORDER BY NomTipo");
                cboTipoPago.DisplayMember = "NomTipo";
                cboTipoPago.ValueMember = "TipoID";
                cboTipoPago.SelectedValue = 12;  //por defecto pago Efectivo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listar_CuentasIngresosEgresos()
        {
            try
            {
                CuentaIngrEgreDT = DListarPersonalizado.ConsultarDT("SELECT Cuenta_Ingreso_EgresoID, Nombre, TipoIngresoEgreso FROM Cuenta_Ingresos_Egresos WHERE Estado=1 " +
                    "UNION SELECT -1, '[SELECCIONE UN EGRESO]', 'E' " +
                    "UNION SELECT -1, '[SELECCIONE UN INGRESO]', 'I' ORDER BY Nombre");
                Cargar_CuentasIngresosEgresos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModifIngresoEgreso()
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
                rec.TipoIngrEgre = cboTipo.Text;
                rec.VariosPersonActivID = (rbVarios.Checked ? 1 : (rbPersonal.Checked ? 2 : 3));
                rec.SucursalID = OConexionGlobal.SucursalID;
                rec.CajaID = (int)cboCaja.SelectedValue;
                rec.Cuenta_Ingreso_EgresoID = (int)cboCuentaIngrEgre.SelectedValue;
                rec.Monto = Convert.ToDecimal(txtMontoBs.Text);
                rec.TC = Convert.ToDecimal(txtTC.Text);
                rec.PersonActivID = (panelPerActiv.Visible ? (int)cboPerActiv.SelectedValue : -1);
                rec.TipoPagoDT = InsertDetallePago();
                rec.ReciboDT = recib.ReciboDT(rbRecibo.Checked);
                rec.FacturaDT = fact.FacturaDT(rbFactura.Checked);

                string resp = DIngrEgre.DInsertModifIngrEgre(rec, OInmode.DTInmode("", "NUEVO", ""));
                if (resp != "-1")
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BorrarCampos(gbxRecib, "");
                    BorrarCampos(gbxTipPago, "0.00");
                    txtTC.Text = "6.96";

                    recib.Borrar_Recibo();
                    fact.Borrar_Factura();
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

        private DataTable InsertDetallePago()
        {
            DataTable DetPagoDT = new DataTable();
            DetPagoDT.Columns.Add("PagoID");
            DetPagoDT.Columns.Add("TipoPagoID");
            DetPagoDT.Columns.Add("BancoID");
            DetPagoDT.Columns.Add("Monto");
            DetPagoDT.Columns.Add("Cambio");
            DetPagoDT.Columns.Add("TC");
            DetPagoDT.Columns.Add("Fecha1");
            DetPagoDT.Columns.Add("Fecha2");
            DetPagoDT.Columns.Add("Numero1");
            DetPagoDT.Columns.Add("Numero2");
            DetPagoDT.Columns.Add("Banco1");
            DetPagoDT.Columns.Add("Banco2");
            DetPagoDT.Columns.Add("Estado");

            DataRow fila = DetPagoDT.NewRow();
            fila["PagoID"] = -1;
            fila["TipoPagoID"] = cboTipoPago.SelectedValue;
            fila["Monto"] = decimal.Parse(txtMontoBs.Text);
            fila["TC"] = decimal.Parse(txtTC.Text);
            fila["Cambio"] = 0;
            fila["Estado"] = true;

            switch (cboTipoPago.SelectedValue.ToString())
            {
                case "13":    //TARJETA
                    fila["Banco1"] = tarjeta.txtbancoTar.Text.Trim();
                    fila["Numero1"] = tarjeta.txtRefTar.Text.Trim();
                    break;
                case "14":    //CHEQUE
                    fila["Banco1"] = cheque.txtBancoCheque.Text.Trim();
                    fila["Numero1"] = cheque.TxtCheque.Text.Trim();
                    fila["Fecha1"] = cheque.txtFechaChequeEmi.Value;
                    fila["Fecha2"] = cheque.txtFechaChequeCobro.Value;
                    break;
                case "15":    //DEPOSITO
                    fila["Banco1"] = deposito.txtBancoDep.Text.Trim();
                    fila["Numero1"] = deposito.txtCuentaDep.Text.Trim();
                    fila["Fecha1"] = deposito.DtFecCobroDep.Value;
                    break;
                case "16":    //TRANSFERENCIA
                    fila["BancoID"] = transf.cboBanco.SelectedValue;
                    fila["Banco1"] = transf.cboBanco.Text;
                    fila["Banco2"] = transf.txtBancoDestino.Text.Trim();
                    fila["Numero2"] = transf.txtCtaDestino.Text.Trim();
                    fila["Fecha1"] = transf.DtFecCobroTransf.Value;
                    break;
            }

            DetPagoDT.Rows.Add(fila);

            return DetPagoDT;
        }

        private void Cargar_CuentasIngresosEgresos()
        {
            cboCuentaIngrEgre.DataSource = null;
            IEnumerable<DataRow> ingregredr = (from ingregre in CuentaIngrEgreDT.AsEnumerable() select ingregre).Where(x => x.Field<string>("TipoIngresoEgreso") == cboTipo.Text.Substring(0, 1));

            if (ingregredr.Count() > 0)
            {
                cboCuentaIngrEgre.DataSource = ingregredr.CopyToDataTable();
                cboCuentaIngrEgre.DisplayMember = "Nombre";
                cboCuentaIngrEgre.ValueMember = "Cuenta_Ingreso_EgresoID";
            }
        }

        private void CargarPerActiv(Int32 cod, string nom)
        {
            cboPerActiv.Items.Clear();
            cboPerActiv.Items.Add(nom);
            cboPerActiv.ValueMember = cod.ToString();
            cboPerActiv.Text = nom;
        }

        #endregion

        #region Funciones

        private bool Verificar()
        {
            if (!DInicioCaja.TieneInicioCajaUsuarioSucursal())
            {
                MessageBox.Show("TIENE QUE INICIAR CAJA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (Convert.ToDecimal(txtMontoBs.Text) <= 0)
            {
                MessageBox.Show("EL MONTO DEL " + cboTipo.Text + " TIENE QUE SER MAYOR A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMontoBs.Focus();
                txtMontoBs.SelectAll();
                return false;
            }
            else if (cboCuentaIngrEgre.SelectedValue.ToString() == "-1")
            {
                cboCuentaIngrEgre.Focus();
                MessageBox.Show("SELECCIONE UNA CUENTA DE " + cboTipo.Text, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboCaja.SelectedValue.ToString() == "-1")
            {
                cboCaja.Focus();
                MessageBox.Show("SELECCIONE UNA CAJA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(cboPerActiv.Visible)
            {
                if (cboPerActiv.ValueMember.ToString() == "-1")
                {
                    MessageBox.Show("SELECCIONE UN " + (rbPersonal.Checked ? "PERSONAL" : "ACTIVO FIJO"));
                    btnBusqPerActiv.PerformClick();
                    return false;
                }                  
            }

            if (rbRecibo.Checked)
            {
                if (!recib.Verificar_Recibo())
                    return false;
            }
            else
            {
                if (!fact.Verificar_Factura())
                    return false;
            }

             return true;
        }
        
        private void BorrarCampos(GroupBox gbx, string param)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, param);
        }
        
        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if(dialogo==DialogResult.Yes)
            {
                BorrarCampos(gbxRecib, "");
                BorrarCampos(gbxTipPago, "0.00");
                recib.Borrar_Recibo();
                cboTipoPago.SelectedValue = 12;  //por defecto pago Efectivo

                if (fact != null)
                    fact.Borrar_Factura();

                if (cheque != null)
                    cheque.BorrarCheque();

                if (deposito != null)
                    deposito.BorrarDeposito();

                if (transf != null)
                    transf.BorrarTransf();
            }
        }
        
        private void Imprimir()
        {
        }


        #endregion

        #region Eventos Formulario

        private void ReciboIngEgr_Load(object sender, EventArgs e)
        {
            cboTipo.Text = "EGRESO";
            ListarCaja();
            Listar_TipoPago();
            Listar_CuentasIngresosEgresos();

            //Recibo
            recib = new CntrUsuRecibo();
            fact = new CntrUsuFactura();
            recib.txtMontoRecib.ReadOnly = true;
            panelFacturaRecibo.Controls.Add(recib);

            Cargado = true;
        }

        private void ReciboIngEgr_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmgastingr.Dispose();
            frmgastingr = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifIngresoEgreso();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        
        private void btnBuscaGastoIngre_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador busq = new Buscadores.Buscador();
            busq.Opcion = cboTipo.Text;
            busq.chkTipo.Visible = false;
            busq.cboTipoCli.Visible = false;
            busq.Variable = cboTipo.Text.Substring(0, 1);
            busq.ShowDialog();

            if (busq.Seleccionado)
                cboCuentaIngrEgre.SelectedValue = busq.dgvDatos["ID", busq.dgvDatos.CurrentRow.Index].Value;

            busq.Dispose();
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cargado)
            {
                panelTipPago.Controls.Clear();

                switch (cboTipoPago.SelectedValue.ToString())
                {
                    case "13":  //TARJETA
                        if (tarjeta == null)
                        { tarjeta = new CntrUsuTarjetas(); }
                        panelTipPago.Controls.Add(tarjeta);
                        tarjeta.BorrarTarjeta();
                        break;
                    case "14":  //CHEQUE
                        if (cheque == null)
                        { cheque = new CntrUsuCheque(); }
                        panelTipPago.Controls.Add(cheque);
                        cheque.BorrarCheque();
                        break;
                    case "15": //DEPOSITO
                        if (deposito == null)
                        { deposito = new CntrUsuDeposito(); }
                        panelTipPago.Controls.Add(deposito);
                        deposito.BorrarDeposito();
                        break;
                    case "16": //TRANSFERENCIA
                        if (transf == null)
                        { transf = new CntrUsuTransferencia(); }
                        panelTipPago.Controls.Add(transf);
                        transf.BorrarTransf();
                        break;
                }
            }
        }
        
        private void rbRecibo_CheckedChanged(object sender, EventArgs e)
        {
            panelFacturaRecibo.Controls.Clear();

            if (rbRecibo.Checked)
                panelFacturaRecibo.Controls.Add(recib);
            else
            {
                if (fact == null)
                    fact = new CntrUsuFactura();

                fact.txtMontoFact.ReadOnly = true;
                fact.txtMontoFact.Text = txtMontoBs.Text;
                panelFacturaRecibo.Controls.Add(fact);
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (Cargado)
            {
                Cargado = false;

                decimal tc, bs, sus;
                if (!decimal.TryParse(txtTC.Text, out tc))
                {
                    txtTC.Text = "6.96";
                    txtTC.SelectAll();
                }


                if (txtMontoBs.Focused || txtTC.Focused)
                {
                    decimal.TryParse(txtMontoBs.Text, out bs);
                    txtMontoSus.Text = string.Format("{0:#,##0.00}", Math.Round((tc == 0 ? 0 : bs / tc), 2));

                    if (bs == 0)
                    {
                        txtMontoBs.Text = "0.00";
                        txtMontoBs.SelectAll();
                    }
                }
                else
                {
                    decimal.TryParse(txtMontoSus.Text, out sus);
                    txtMontoBs.Text = string.Format("{0:#,##0.00}", Math.Round(sus * tc, 2));

                    if (sus == 0)
                    {
                        txtMontoSus.Text = "0.00";
                        txtMontoSus.SelectAll();
                    }
                }

                recib.txtMontoRecib.Text = txtMontoBs.Text;
                if (fact != null)
                    fact.txtMontoFact.Text = txtMontoBs.Text;

                Cargado = true;
            }
        }
        
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cargado)
                Cargar_CuentasIngresosEgresos();
        }
        
        private void rbVarios_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            lblNomPerActiv.Text = rb.Text + ":";
            panelPerActiv.Visible = !rbVarios.Checked;
            CargarPerActiv(-1, (rbPersonal.Checked ? "[SELECCIONE A UN PERSONAL...]" : "[SELECCIONE UN ACTIVO...]"));
        }
        
        private void btnBusqPerActiv_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador busq = new Buscadores.Buscador();
            busq.Opcion = (rbPersonal.Checked ? "Personal" : "Activo");
            busq.ShowDialog();

            if (busq.Seleccionado)
                CargarPerActiv((int)busq.dgvDatos["ID", busq.dgvDatos.CurrentRow.Index].Value, 
                    busq.dgvDatos["Nombre", busq.dgvDatos.CurrentRow.Index].Value.ToString());
 
            busq.Dispose();
        }

        #endregion

    }
}

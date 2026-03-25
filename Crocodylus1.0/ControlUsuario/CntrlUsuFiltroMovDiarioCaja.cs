using System;
using System.Data;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroMovDiarioCaja : UserControl
    {
        public CntrlUsuFiltroMovDiarioCaja()
        {
            InitializeComponent();
        }

        public void ListarDatos()
        {
            try
            {
                DataSet DatosDS = DListarPersonalizado.ConsultarDS("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc; " +
                    "SELECT UsuarioID, NomUsu FROM Usuario ORDER BY NomUsu; " +
                    "SELECT TipoID, NomTipo FROM TIPO_SISTEMA_FIJO WHERE Tupla='PAGO' AND Estado=1;");

                cboSucursal.DataSource = DatosDS.Tables[0];
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.SelectedValue = OConexionGlobal.SucursalID;

                cboUsuario.DataSource = DatosDS.Tables[1];
                cboUsuario.DisplayMember = "NomUsu";
                cboUsuario.ValueMember = "UsuarioID";
                cboUsuario.SelectedValue = OConexionGlobal.UsuarioID;

                cboTipoPgo.DataSource = DatosDS.Tables[2];
                cboTipoPgo.DisplayMember = "NomTipo";
                cboTipoPgo.ValueMember = "TipoID";
                cboTipoPgo.SelectedValue = 12;  //EFECTIVO
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ConsultaSQL()
        {
            string Consulta;
            Consulta = "SELECT Codigo, Numero, Descripcion, CajaID, NomCaja, NomSuc, Fecha, " +
                       "Referencia, MontoBs, DsctoBs, MontoPago, Tipo, EsIngreso, NomTipoPago, " +
                       "Numero1, Numero2, Banco1, Banco2, Cambio, Fecha1, Fecha2, UsuarioID " +
                       "FROM Vista_Pagos_Transac WHERE CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
                       "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
                       (chkSucursal.Checked ? " AND SucursalID=" + cboSucursal.SelectedValue : "") +
                       (chkTipoPago.Checked ? " AND TipoPagoID=" + cboTipoPgo.SelectedValue : "") +
                       (chkUsuario.Checked ? " AND UsuarioID=" + cboUsuario.SelectedValue : "");


            //Consulta = "SELECT vv.CodVenta Codigo, vv.NumVenta Numero, vv.NomClien Descripcion, 2 CajaID, '' NomCaja, vv.NomSuc, vv.Fecha, " +
            //           "vv.Referencia, p.Monto, 'VENTA CONTADO' Tipo, CONVERT(BIT, 1) EsIngreso, p.TipoPagoID, tp.NomTipo NomTipoPago " +
            //           "FROM Vista_Ventas vv INNER JOIN Pago p ON vv.CodVenta=p.CodVenta INNER JOIN Tipo_Sistema_Fijo tp ON p.TipoPagoID=tp.TipoID  " +
            //           "WHERE vv.Estado=1 AND p.Estado=1 AND TipoVenta='CONTADO' AND CONVERT(DATE, vv.Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND vv.SucursalID=" + cboSucursal.SelectedValue : "") +
            //           (chkTipoPago.Checked ? "AND p.TipoPagoID=" + cboTipoPgo.SelectedValue : "") +
            //           "UNION " +
            //           "SELECT CAST(AperturaCajaID AS VARCHAR(20)), CAST(AperturaCajaID AS VARCHAR(20)), 'APERTURA CAJA', 2, '', s.NomSuc, ac.FechaApertura, ObsApertura, MontoIniBs, " +
            //           "'APERTURA', CONVERT(BIT, 1) EsIngreso, 12, 'EFECTIVO' FROM AperturaCierre_Caja ac INNER JOIN Sucursal s ON s.SucursalID=ac.SucursalID " +
            //           "WHERE ac.Estado=1 AND CONVERT(DATE, FechaApertura) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' AND ac.SucursalID=" + cboSucursal.SelectedValue +
            //           " UNION " +
            //           "SELECT va.CodAbono, va.NumAbono, va.NomClien, 2, '', va.NomSuc, va.Fecha, va.Detalle, p.Monto, 'ABONO CLIENTE', 1, p.TipoPagoID, tp.NomTipo NomTipoPago " +
            //           "FROM Vista_Abonos va INNER JOIN Pago p ON va.CodAbono=p.CodAbono INNER JOIN Tipo_Sistema_Fijo tp ON p.TipoPagoID=tp.TipoID " +
            //           "WHERE va.Estado=1 AND va.TipoAbono='Cliente' AND CONVERT(DATE, va.Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND va.SucursalID=" + cboSucursal.SelectedValue : "") +
            //           (chkTipoPago.Checked ? "AND p.TipoPagoID=" + cboTipoPgo.SelectedValue : "") +
            //           " UNION " +
            //           "SELECT va.CodAbono, va.NumAbono, va.NomProv, 2, '', va.NomSuc, va.Fecha, va.Detalle, p.Monto, 'PAGO PROVEEDOR', 0,  p.TipoPagoID, tp.NomTipo NomTipoPago " +
            //           "FROM Vista_Abonos va INNER JOIN Pago p ON va.CodAbono=p.CodAbono INNER JOIN Tipo_Sistema_Fijo tp ON p.TipoPagoID=tp.TipoID " +
            //           "WHERE va.Estado=1 AND va.PagarCaja=1 AND va.TipoAbono='Proveedor' AND CONVERT(DATE, va.Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND va.SucursalID=" + cboSucursal.SelectedValue : "") +
            //           (chkTipoPago.Checked ? "AND p.TipoPagoID=" + cboTipoPgo.SelectedValue : "") +
            //           " UNION " +
            //           "SELECT CodIngrEgre, NumIngrEgre, NombreCuenta, CajaID, NomCaja, NomSuc, Fecha, Concepto, MontoBs, 'INGRESOS', 1, 12, 'EFECTIVO' " +
            //           "FROM Vista_Ingresos_Egresos WHERE Estado=1 AND TipoIngrEgre='I' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //          " UNION " +
            //          "SELECT CodIngrEgre, NumIngrEgre, NombreCuenta, CajaID, NomCaja, NomSuc, Fecha, Concepto, MontoBs, 'EGRESOS', 0, 12, 'EFECTIVO' " +
            //          "FROM Vista_Ingresos_Egresos WHERE Estado=1 AND TipoIngrEgre='E' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //          "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //          (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //          " ORDER BY Fecha";

            //Consulta = "SELECT CodVenta Codigo, NumVenta Numero, NomClien Descripcion, 2 CajaID, '' NomCaja, NomSuc, Fecha, " +
            //           "Referencia, (MontoBs-AnticipoBs) Monto, 'VENTA CONTADO' Tipo, CONVERT(BIT, 1) EsIngreso " +
            //           "FROM Vista_Ventas WHERE Estado=1 AND TipoVenta='CONTADO' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //           "UNION " +
            //           "SELECT CAST(AperturaCajaID AS VARCHAR(20)), CAST(AperturaCajaID AS VARCHAR(20)), 'APERTURA CAJA', 2, '', s.NomSuc, ac.FechaApertura, ObsApertura, MontoIniBs, " + 
            //           "'APERTURA', CONVERT(BIT, 1) EsIngreso FROM AperturaCierre_Caja ac INNER JOIN Sucursal s ON s.SucursalID=ac.SucursalID " +
            //           "WHERE ac.Estado=1 AND CONVERT(DATE, FechaApertura) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' AND ac.SucursalID=" + cboSucursal.SelectedValue + 
            //           " UNION " +
            //           "SELECT CodVenta Codigo, NumVenta Numero, NomClien Descripcion, 2 CajaID, '' NomCaja, NomSuc, Fecha, " +
            //           "Referencia, 0 Monto, 'VENTA CRÉDITO' Tipo, CONVERT(BIT, 1) EsIngreso " +
            //           "FROM Vista_Ventas WHERE Estado=1 AND TipoVenta='CREDITO' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //           " UNION " +
            //           "SELECT CodVenta, NumVenta, NomClien, 2, '', NomSuc, Fecha, Referencia, AnticipoBs, 'ANTICIPOS', 1 " +
            //           "FROM Vista_Pedidos WHERE Estado=1 AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //           " UNION " +
            //           "SELECT CodAbono, NumAbono, NomClien, 2, '', NomSuc, Fecha, Detalle, MontoTotalBs, 'ABONO CLIENTE', 1 " +
            //           "FROM Vista_Abonos WHERE Estado=1 AND TipoAbono='Cliente' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //           " UNION " +
            //           "SELECT CodAbono, NumAbono, NomProv, 2, '', NomSuc, Fecha, Detalle, MontoTotalBs, 'PAGO PROVEEDOR', 0 " +
            //           "FROM Vista_Abonos WHERE Estado=1 AND PagarCaja=1 AND TipoAbono='Proveedor' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //           " UNION " +
            //           "SELECT CodIngrEgre, NumIngrEgre, NombreCuenta, CajaID, NomCaja, NomSuc, Fecha, Concepto, MontoBs, 'INGRESOS', 1 " +
            //           "FROM Vista_Ingresos_Egresos WHERE Estado=1 AND TipoIngrEgre='I' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //           " UNION " +
            //           "SELECT CodIngrEgre, NumIngrEgre, NombreCuenta, CajaID, NomCaja, NomSuc, Fecha, Concepto, MontoBs, 'EGRESOS', 0 " +
            //           "FROM Vista_Ingresos_Egresos WHERE Estado=1 AND TipoIngrEgre='E' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
            //           "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
            //           (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
            //           " ORDER BY Fecha";

            return Consulta;
        }

        public string ConsultaSQL_IngrEgre()
        {
            string Consulta;
            Consulta = "SELECT CodIngrEgre Codigo, NumIngrEgre Numero, NombreCuenta Descripcion, CajaID, NomCaja, NomSuc, Fecha, " +
                       "Concepto Referencia, MontoBs, 'INGRESOS' Tipo, CONVERT(BIT, 1) EsIngreso " +
                       "FROM Vista_Ingresos_Egresos WHERE Estado=1 AND TipoIngrEgre='I' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
                       "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
                       (chkSucursal.Checked ? " AND SucursalID=" + cboSucursal.SelectedValue : "") +
                       (chkUsuario.Checked ? " AND UsuarioID=" + cboUsuario.SelectedValue : "") +
                       " UNION " +
                       "SELECT CodIngrEgre, NumIngrEgre, NombreCuenta, CajaID, NomCaja, NomSuc, Fecha, Concepto, MontoBs, 'EGRESOS', 0 " +
                       "FROM Vista_Ingresos_Egresos WHERE Estado=1 AND TipoIngrEgre='E' AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() +
                       "' AND '" + dtFechaFin.Value.ToShortDateString() + "' " +
                       (chkSucursal.Checked ? "AND SucursalID=" + cboSucursal.SelectedValue : "") +
                       (chkUsuario.Checked ? " AND UsuarioID=" + cboUsuario.SelectedValue : "") +
                       " ORDER BY Fecha";

            return Consulta;
        }

        private void chkCaja_CheckedChanged(object sender, EventArgs e)
        {
            cboSucursal.Enabled = chkSucursal.Checked;
        }

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            cboUsuario.Enabled = chkUsuario.Checked;
        }

        private void chkTipoPago_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoPgo.Enabled = chkTipoPago.Checked;
        }
    }
}

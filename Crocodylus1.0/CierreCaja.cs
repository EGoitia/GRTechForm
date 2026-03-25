using System;
using System.Data;
using System.Windows.Forms;

using Objetos;
using Datos;

namespace GRTechnology1._0
{
    public partial class CierreCaja : Form
    {

        OInicioCaja ini;
        OCierreCaja cie;

        DataTable DTInicio;

        public CierreCaja()
        {
            InitializeComponent();

            ini = new OInicioCaja();
            cie = new OCierreCaja();
        }


        private void VerificarInicioCajaUsuario()
        {
            try
            {
                DTInicio = DInicioCaja.ObtenerIniCajaUsuarioSucursal();
                if (DTInicio.Rows.Count > 0)
                {
                    btnGuardar.Visible = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void ListarTipoPagos()
        {
            try
            {
                DataTable dtTipoPago = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Tupla='PAGO' AND Estado=1");
                if (dtTipoPago != null)
                {
                    //verificamos si esta habilitado el pago en efectivo
                    var valorefec = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_EFECTIVO.ToString());
                    if (valorefec.Length == 0)
                    {
                        panelEfectivo.Visible = false;
                        this.Height -= panelEfectivo.Height;
                    }
                    var valortarj = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_TARJETA.ToString());
                    if (valortarj.Length == 0)
                    {
                        panelTarjeta.Visible = false;
                        this.Height -= panelTarjeta.Height;
                    }
                    var valordep = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_DEPOSITO.ToString());
                    if (valordep.Length == 0)
                    {
                        panelDeposito.Visible = false;
                        this.Height -= panelDeposito.Height;
                    }
                    var valortrans = dtTipoPago.Select("TipoID=" + OConstantes.Tipo_Pago_TRANSFERENCIA.ToString());
                    if (valortrans.Length == 0)
                    {
                        panelTransferencia.Visible = false;
                        this.Height -= panelTransferencia.Height;
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY NINGUN TIPO DE PAGO HABILITADO", "TIPO PAGO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void InsertCierreCaja()
        {
            try
            {
                VerificarInicioCajaUsuario();

                if (DTInicio.Rows.Count == 0)
                {
                    MessageBox.Show("HAGA INICIO DE CAJA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cie.InicioID = Convert.ToInt32(DTInicio.Rows[0]["InicioID"]);
                cie.EntregEfectivoBs = txtEfectivo.Value;
                cie.EntregEfectivoSus = txtEfectivoSus.Value;
                cie.EntregTarjetaBs = txtTarjeta.Value;
                cie.EntregTransfBs = txtQR.Value;
                cie.EntregDeposBs = txtDeposito.Value;
                cie.Observaciones = txtObs.Text.Trim();

                int resp = DCierreCaja.Insert_CierreCaja(OInmode.DTInmode("", "Nuevo", ""), cie);
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ImpCierreCaja(resp);

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImpCierreCaja(int id)
        {
            try
            {
                Frm_Reporte rep = new Frm_Reporte(false);
                rep.Dts.Clear();
                rep.Llenar_Tabla("SELECT * FROM Vi_InicioCierre WHERE CierreID=" + id.ToString(), "Cierre_Caja");
                rep.Cargar(DConstantes.Imprimir.Nota_CierreCaja.NOM_REPORTE_NOTA_CIERRECAJA, false,
                       DConstantes.Imprimir.Nota_CierreCaja.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_CierreCaja.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_CierreCaja.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_CierreCaja.MOSTRAR_ARBOL,
                       OConexionGlobal.SucursalID);
                rep.ShowDialog();
                rep.Dispose();
            }
            catch (Exception eeee)
            {
                MessageBox.Show(eeee.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertCierreCaja();
        }

        private void frm_CierreCaja_Load(object sender, EventArgs e)
        {
            VerificarInicioCajaUsuario();
            ListarTipoPagos();
        }
    }
}

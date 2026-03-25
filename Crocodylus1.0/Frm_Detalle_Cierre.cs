using Datos;
using Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Cierre : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Cierre frmdetcierre = null;

        private string Consulta;

        public Frm_Detalle_Cierre()
        {
            InitializeComponent();
        }

        #region Metodos

        private void NombreColumnas()
        {
            dgvDetalle.Columns["ID"].HeaderText = "Nº";
            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDetalle.Columns["NomPer"].HeaderText = "Cajero(a)";
            dgvDetalle.Columns["FechaInicio"].HeaderText = "Fec. Inicio";
            dgvDetalle.Columns["FechaCierre"].HeaderText = "Fec. Cierre";
            dgvDetalle.Columns["MontoInicio"].HeaderText = "Monto Ini.";
            dgvDetalle.Columns["EfectivoBs"].HeaderText = "Efectivo";
            dgvDetalle.Columns["TransferenciaBs"].HeaderText = "Transf.";
            dgvDetalle.Columns["EntregEfectivoBs"].HeaderText = "Entreg. Efectivo Bs.";
            dgvDetalle.Columns["EntregEfectivoSus"].HeaderText = "Entreg. Efectivo $us.";

            dgvDetalle.Columns["ID"].Width = 50;
            dgvDetalle.Columns["NomSuc"].Width = 120;
            dgvDetalle.Columns["NomPer"].Width = 150;

            dgvDetalle.Columns["MontoInicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["MontoInicio"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["EfectivoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["EfectivoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["TransferenciaBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["TransferenciaBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["EntregEfectivoBs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["EntregEfectivoBs"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["EntregEfectivoSus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["EntregEfectivoSus"].DefaultCellStyle.Format = "N2";

            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;
            dgvDetalle.Columns["UsuarioID"].Visible = false;
        }

        private void ListarUsuario()
        {
            try
            {
                cmbCajero.DataSource = DListarPersonalizado.ConsultarDT(@"SELECT UsuarioID, ISNULL(p.NomPer, u.NomPer) NomPer 
                                                                          FROM Usuario u LEFT JOIN Personal p
                                                                          ON u.PersonalID=p.PersonalID
                                                                          ORDER BY ISNULL(p.NomPer, u.NomPer)");
                cmbCajero.DisplayMember = "NomPer";
                cmbCajero.ValueMember = "UsuarioID";
                cmbCajero.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public override void Buscar()
        {
            Consulta = "SELECT CierreID ID, SucursalID, NomSuc, UsuarioID, NomPer, FechaInicio, FechaCierre, MontoInicio, EfectivoBs, TransferenciaBs, " +
                       "EntregEfectivoBs, EntregEfectivoSus, EntregTransfBs, Observaciones, TotalVentasCreditoBs, TotalVentasContadoBs, " +
                       "TotalEgresosBs, TotalIngresosBs, TotalAbonosCliBs, TotalPagosProvBs, CodInmode FROM Vi_InicioCierre WHERE Estado=" + (chkAnulado.Checked ? 0 : 1);

            if (chkCajero.Checked)
                Consulta += " AND UsuarioID=" + cmbCajero.SelectedValue;

            //Consulta += " AND CONVERT(DATE, FechaCierre) BETWEEN '" + dtFechaIni.Value.ToShortDateString() + "' AND '" + dtFechaFin.Value.ToShortDateString() + "'";
            Consulta += " AND CONVERT(DATE, FechaCierre) BETWEEN '" + dtFechaIni.Value.Year + "-" + dtFechaIni.Value.Month + "-" + dtFechaIni.Value.Day +
                        "' AND '" + dtFechaFin.Value.Year + "-" + dtFechaFin.Value.Month + "-" + dtFechaFin.Value.Day + "'";
            Consulta += " ORDER BY FechaCierre";

            dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);
        }

        public override void ImprLista(string[] ConsultaSql, string[] NomTabla, string TituloRep, string Variable, string NomRep, bool mostrarbtnimp = true, bool mostrarbtncopiar = true, bool mostrarbtnexport = true, bool mostrararbol = true)
        {
            base.ImprLista(ConsultaSql, NomTabla, TituloRep, Variable, NomRep, mostrarbtnimp, mostrarbtncopiar, mostrarbtnexport, mostrararbol);
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                try
                {
                    Frm_Reporte rep = new Frm_Reporte(false);
                    rep.Dts.Clear();
                    rep.Llenar_Tabla("SELECT * FROM Vi_InicioCierre WHERE CierreID=" + dgvDetalle["ID", dgvDetalle.CurrentRow.Index].Value.ToString(), "Cierre_Caja");
                    rep.Cargar(DConstantes.Imprimir.Nota_CierreCaja.NOM_REPORTE_NOTA_CIERRECAJA, false,
                           DConstantes.Imprimir.Nota_CierreCaja.MOSTRAR_BTN_IMP,
                           DConstantes.Imprimir.Nota_CierreCaja.MOSTRAR_BTN_COPIAR,
                           DConstantes.Imprimir.Nota_CierreCaja.MOSTRAR_BTN_EXPORT,
                           DConstantes.Imprimir.Nota_CierreCaja.MOSTRAR_ARBOL,
                           Convert.ToInt32(dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value));
                    rep.ShowDialog();
                    rep.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        private void chkCajero_CheckedChanged(object sender, EventArgs e)
        {
            cmbCajero.Enabled = chkCajero.Checked;
        }

        private void Frm_Detalle_Cierre_Load(object sender, EventArgs e)
        {
            ListarUsuario();
            Buscar();
            NombreColumnas();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["ID", dgvDetalle.CurrentRow.Index].Value.ToString();
            int sucid = Convert.ToInt32(dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value.ToString());
            int usuid = Convert.ToInt32(dgvDetalle["UsuarioID", dgvDetalle.CurrentRow.Index].Value.ToString());

            //VERIFICAMOS SI ES EL ULTIMO CIERRE, SINO NO DEJAMOS ANULAR EL CIERRE
            var resul = DListarPersonalizado.Dato(string.Format(@"select 1 from Vi_InicioCierre
                                                                  where Estado=1 and CierreID > {0}
                                                                  and SucursalID={1} and UsuarioID={2}", ID, sucid, usuid));
            if (resul != null)
            {
                MessageBox.Show(string.Format("NO SE PUEDE ANULAR EL CIERRE DE CAJA NRO. {0}", ID),
                    "ANULAR CIERRE DE CAJA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

           
            Anular("CierreCaja", "EL CIERRE DE CAJA Nº " + dgvDetalle["ID", dgvDetalle.CurrentRow.Index].Value.ToString());
        }

        private void Frm_Detalle_Cierre_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmdetcierre.Dispose();
            frmdetcierre = null;            
        }

    }
}

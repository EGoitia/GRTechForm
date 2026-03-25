using System;
using System.Windows.Forms;
using Datos;
using Objetos;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Traspaso : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Traspaso frmdettrasp = null;

        private string Consulta = string.Empty;
        private string ConsultaDetalle = string.Empty;
        private bool ImpAnulado = false;

        public Frm_Detalle_Traspaso()
        {
            InitializeComponent();
        }

        private void HabilitarDesabilControl()
        {
            OpcionFormularios.HabilitarCont(gbxFiltro, 43);
            OpcionFormularios.HabilitarCont(gbxBotones, 43);
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodTraspaso"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["DelAlmacenID"].Visible = false;
            dgvDetalle.Columns["AlAlmacenID"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["NumTraspaso"].HeaderText = "Nº Traspaso";
            dgvDetalle.Columns["NumTraspaso"].FillWeight = 60;

            dgvDetalle.Columns["Fecha"].HeaderText = "Fecha";
            dgvDetalle.Columns["Fecha"].FillWeight = 90;

            dgvDetalle.Columns["Detalle"].HeaderText = "Detalle";
            dgvDetalle.Columns["Detalle"].FillWeight = 300;

            dgvDetalle.Columns["Origen"].HeaderText = "Orígen";
            dgvDetalle.Columns["Origen"].FillWeight = 150;

            dgvDetalle.Columns["Destino"].HeaderText = "Destino";
            dgvDetalle.Columns["Destino"].FillWeight = 150;

            dgvDetalle.Columns["Confirmado"].HeaderText = "Conf.";
            dgvDetalle.Columns["Confirmado"].FillWeight = 40;
        }

        private void ListarSucursales()
        {
            try
            {
                cboOrigen.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc");
                cboOrigen.DisplayMember = "NomSuc";
                cboOrigen.ValueMember = "SucursalID";
                cboOrigen.SelectedValue = OConexionGlobal.SucursalID;

                cboDestino.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc");
                cboDestino.DisplayMember = "NomSuc";
                cboDestino.ValueMember = "SucursalID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            try
            {
                Consulta = "SELECT CodTraspaso, CodInmode, DelAlmacenID, AlAlmacenID, NumTraspaso, Fecha, Origen, Destino, Detalle, Confirmado, " +
               "Estado FROM Vista_Traspaso WHERE Estado='" + (!chkAnulada.Checked).ToString() + "' AND Confirmado='" + chkConfirmada.Checked + "'";

                ConsultaDetalle = "SELECT CodTraspaso FROM Vista_Traspaso WHERE Estado='" + (!chkAnulada.Checked).ToString() + "' AND Confirmado='" + chkConfirmada.Checked + "'";

                if (chkFechas.Checked)
                {
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
                    ConsultaDetalle += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";
                }

                if (chkOrigen.Checked)
                {
                    Consulta += " AND DelAlmacenID=" + cboOrigen.SelectedValue;
                    ConsultaDetalle += " AND DelAlmacenID=" + cboOrigen.SelectedValue;
                }

                if (chkDestino.Checked)
                {
                    Consulta += " AND AlAlmacenID=" + cboDestino.SelectedValue;
                    ConsultaDetalle += " AND AlAlmacenID=" + cboDestino.SelectedValue;
                }

                if (!string.IsNullOrWhiteSpace(txtDetalle.Text))
                {
                    Consulta += " AND Detalle LIKE '" + txtDetalle.Text.Trim() + "'";
                    ConsultaDetalle += " AND Detalle LIKE '" + txtDetalle.Text.Trim() + "'";
                }

                ImpAnulado = chkAnulada.Checked;
                dgvDetalle.DataSource = DListarPersonalizado.ConsultarDT(Consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Seleccionamos la ultima fila
                if (dgvDetalle.Rows.Count > 0)
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[4];
            }
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Frm_Reporte rep = new Frm_Reporte();
            rep.Dts.Clear();
            rep.Llenar_Tabla("SELECT * FROM Vista_Traspaso WHERE CodTraspaso='" + dgvDetalle["CodTraspaso", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_Traspaso");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_Traspaso WHERE CodTraspaso='" + dgvDetalle["CodTraspaso", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_Traspaso");
            rep.Cargar(DConstantes.Imprimir.Nota_Traspaso.NOM_REPORTE_NOTA_TRASPASO, false,
                       DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_Traspaso.MOSTRAR_ARBOL,
                       (int)dgvDetalle["DelAlmacenID", dgvDetalle.CurrentRow.Index].Value);
            rep.Show();
        }

        private void Frm_Detalle_Traspaso_Load(object sender, EventArgs e)
        {
            HabilitarDesabilControl();
            ListarSucursales();
            Buscar();
            NombreColumnas();
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Traspaso";
            base.ImprLista(sql, nomtabla, "LISTA DE TRASPASOS" + (ImpAnulado ? " ANULADOS" : ""), Variable, DConstantes.Imprimir.Lista_Traspaso.NOM_REPORTE_LISTA_TRASPASO,
                        DConstantes.Imprimir.Lista_Traspaso.MOSTRAR_BTN_IMP,
                        DConstantes.Imprimir.Lista_Traspaso.MOSTRAR_BTN_COPIAR,
                        DConstantes.Imprimir.Lista_Traspaso.MOSTRAR_BTN_EXPORT,
                        DConstantes.Imprimir.Lista_Traspaso.MOSTRAR_ARBOL);
        }

        private void chkDestino_CheckedChanged(object sender, EventArgs e)
        {
            cboDestino.Enabled = chkDestino.Checked;
        }

        private void chkOrigen_CheckedChanged(object sender, EventArgs e)
        {
            cboOrigen.Enabled = chkOrigen.Checked;
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            dtFecIni.Enabled = chkFechas.Checked;
            dtFecFin.Enabled = chkFechas.Checked;
        }

        private void Frm_Detalle_Traspaso_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmdettrasp.Dispose();
            frmdettrasp = null;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                if (Convert.ToBoolean(dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value))
                {
                    var confirm = DListarPersonalizado.Dato("SELECT 1 FROM TrasAlmacenes WHERE CodTraspaso='" + dgvDetalle["CodTraspaso", dgvDetalle.CurrentRow.Index].Value + 
                        "' AND Confirmado=0");
                    if (confirm != null)
                    {
                        bool resp = DTraspaso.DConfirmarTrasp(dgvDetalle["CodTraspaso", dgvDetalle.CurrentRow.Index].Value.ToString(), 
                            OInmode.DTInmode("", "Confirmar", ""));
                        if(resp)
                            MessageBox.Show("LA NOTA FUE CONFIRMADA CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("LA NOTA YA ESTÁ CONFIRMADA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("LA NOTA ESTÁ ANULADA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                base.ID = dgvDetalle["CodTraspaso", dgvDetalle.CurrentRow.Index].Value.ToString();
                base.Anular("Traspaso", "EL TRASPASO Nº " + dgvDetalle["NumTraspaso", dgvDetalle.CurrentRow.Index].Value.ToString() + "?");             
            }               
        }

        private void btnImpListaDetallada_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFechas.Checked)
                Variable = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();
            else
                Variable = "Fecha Corte: " + DateTime.Now.ToShortDateString();

            string[] sql = new string[2];
            string[] nomtabla = new string[2];
            sql[0] = Consulta;
            sql[1] = "SELECT * FROM Vista_Detalle_Traspaso WHERE CodTraspaso IN(" + ConsultaDetalle + ")";
            nomtabla[0] = "Lista_Traspaso";
            nomtabla[1] = "Detalle_Traspaso";
            base.ImprLista(sql, nomtabla, "LISTA DE TRASPASOS DETALLADO" + (ImpAnulado ? " ANULADOS" : ""), Variable, 
                        DConstantes.Imprimir.Lista_Traspaso_Detallado.NOM_REPORTE_LISTA_TRASPASO_DETALLADO,
                        DConstantes.Imprimir.Lista_Traspaso_Detallado.MOSTRAR_BTN_IMP,
                        DConstantes.Imprimir.Lista_Traspaso_Detallado.MOSTRAR_BTN_COPIAR,
                        DConstantes.Imprimir.Lista_Traspaso_Detallado.MOSTRAR_BTN_EXPORT,
                        DConstantes.Imprimir.Lista_Traspaso_Detallado.MOSTRAR_ARBOL);
        }
    }
}

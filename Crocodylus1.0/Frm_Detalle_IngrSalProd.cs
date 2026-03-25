using Datos;
using Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_IngrSalProd : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_IngrSalProd detingr = null;
        public static Frm_Detalle_IngrSalProd detsal = null;
        public string Tupla = string.Empty;

        private string Consulta;
        private string ConsultaDetalle;
        private bool ImpAnulado = false;

        public Frm_Detalle_IngrSalProd()
        {
            InitializeComponent();
        }

        private void HabilitarDesabilControl()
        {
            OpcionFormularios.HabilitarCont(gbxFiltro, (Tupla == "INGRESO" ? 39 : 41));
            OpcionFormularios.HabilitarCont(gbxBotones, (Tupla == "INGRESO" ? 39 : 41));

            if (Tupla == "INGRESO")
            {
                lblNroCompra.Visible = true;
                txtNroCompra.Visible = true;
            }
        }

        private void ListarTipoIngreso()
        {
            try
            {
                cmbTipo.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND Tupla='" + Tupla + "'");
                cmbTipo.DisplayMember = "NomTipo";
                cmbTipo.ValueMember = "TipoID";
                cmbTipo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarSucursal()
        {
            try
            {
                cmbAlmacen.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal ORDER BY NomSuc");
                cmbAlmacen.DisplayMember = "NomSuc";
                cmbAlmacen.ValueMember = "SucursalID";

                cmbAlmacen.SelectedValue = OConexionGlobal.SucursalID;

                cmbAlmacen.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodIngSalProd"].Visible = false;
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;
            dgvDetalle.Columns["SucursalID"].Visible = false;

            dgvDetalle.Columns["NumIngSalProducto"].HeaderText = (Tupla == "INGRESO" ? "Nº Ingreso" : "Nº Salida");
            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDetalle.Columns["NomProv"].HeaderText = "Proveedor";
            dgvDetalle.Columns["NomTipo"].HeaderText = "Tipo";
            dgvDetalle.Columns["Concepto"].HeaderText = "Detalle";
            dgvDetalle.Columns["Recibido"].HeaderText = (Tupla == "INGRESO" ? "Recibido" : "Entregado");

            dgvDetalle.Columns["NumIngSalProducto"].FillWeight = 70;
            dgvDetalle.Columns["NomSuc"].FillWeight = 150;
            dgvDetalle.Columns["NomProv"].FillWeight = 150;
            dgvDetalle.Columns["NomTipo"].FillWeight = 100;
            dgvDetalle.Columns["Concepto"].FillWeight = 300;
        }

        public override void Buscar()
        {
            try
            {
                Consulta = "SELECT CodIngSalProd, CodInmode, NumIngSalProducto, Fecha, NomTipo, NomProv, Recibido, SucursalID, NomSuc, Concepto, Estado " +
                       "FROM Vista_IngSalProd WHERE EsIngreso='" + (Tupla == "INGRESO" ? true : false).ToString() + "'";

                ConsultaDetalle = "SELECT CodIngSalProd FROM Vista_IngSalProd WHERE EsIngreso='" + (Tupla == "INGRESO" ? true : false).ToString() + "'";

                if (!string.IsNullOrWhiteSpace(txtProveedor.Text))
                {
                    Consulta += " AND NomProv LIKE '%" + txtProveedor.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NomProv LIKE '%" + txtProveedor.Text.Trim() + "%'"; ;
                }

                if (chkFecha.Checked)
                {
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() + "' AND '" + dtFechaFin.Value.ToShortDateString() + "'";
                    ConsultaDetalle += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFechaIni.Value.ToShortDateString() + "' AND '" + dtFechaFin.Value.ToShortDateString() + "'";
                }

                if (chkTipo.Checked)
                {
                    Consulta += " AND TipoIngSalProdID=" + cmbTipo.SelectedValue;
                    ConsultaDetalle += " AND TipoIngSalProdID=" + cmbTipo.SelectedValue;
                }

                if (chkAlmacen.Checked)
                {
                    Consulta += " AND SucursalID=" + cmbAlmacen.SelectedValue;
                    ConsultaDetalle += " AND SucursalID=" + cmbAlmacen.SelectedValue;
                }

                if (!string.IsNullOrWhiteSpace(txtNroCompra.Text))
                {
                    Consulta += " AND NumCompraProd LIKE '" + txtNroCompra.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NumCompraProd LIKE '" + txtNroCompra.Text.Trim() + "%'";
                }

                if (!string.IsNullOrWhiteSpace(txtNroIngrSal.Text))
                {
                    Consulta += " AND NumIngSalProducto LIKE '" + txtNroIngrSal.Text.Trim() + "%'";
                    ConsultaDetalle += " AND NumIngSalProducto LIKE '" + txtNroIngrSal.Text.Trim() + "%'";
                }
                

                Consulta += " AND Estado='" + !chkAnulado.Checked + "' ORDER BY Fecha";
                ConsultaDetalle += " AND Estado='" + !chkAnulado.Checked + "'";
                ImpAnulado = chkAnulado.Checked;

                DataTable VentasDT = DListarPersonalizado.ConsultarDT(Consulta);
                dgvDetalle.DataSource = VentasDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Seleccionamos la ultima fila
                if (dgvDetalle.Rows.Count > 0)
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[2];
            }
        }

        public override void ImprNota()
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Frm_Reporte rep = new Frm_Reporte();
            rep.Variable = Tupla;
            rep.Titulo = "NOTA DE " + Tupla + " Nº ";
            rep.Llenar_Tabla("SELECT * FROM Vista_IngSalProd WHERE CodIngSalProd='" + dgvDetalle["CodIngSalProd", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Lista_IngrSal");
            rep.Llenar_Tabla("SELECT * FROM Vista_Detalle_IngSalProd WHERE CodIngSalProd='" + dgvDetalle["CodIngSalProd", dgvDetalle.CurrentRow.Index].Value.ToString() + "'", "Detalle_IngSalProd");
            rep.Cargar(DConstantes.Imprimir.Nota_IngSalProd.NOM_REPORTE_NOTA_INGSALPROD, false,
                       DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_IMP,
                       DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_COPIAR,
                       DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_BTN_EXPORT,
                       DConstantes.Imprimir.Nota_IngSalProd.MOSTRAR_ARBOL,
                       (int)dgvDetalle["SucursalID", dgvDetalle.CurrentRow.Index].Value);
            rep.Show();

        }

        private void Frm_DetalleIngrSalProd_Load(object sender, EventArgs e)
        {
            this.Text += " " + Tupla;
            btnModif.Visible = (Tupla == "SALIDA" ? false : true);
            HabilitarDesabilControl();
            ListarSucursal();
            ListarTipoIngreso();
            Buscar();
            NombreColumnas();
        }

        private void Frm_DetalleIngrSalProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (detingr != null)
            {
                detingr.Dispose();
                detingr = null;
            }
            else if (detsal != null)
            {
                detsal.Dispose();
                detsal = null;
            }
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            ID = dgvDetalle["CodIngSalProd", dgvDetalle.CurrentRow.Index].Value.ToString();
            Anular("IngSalPRod", (Tupla == "INGRESO" ? "EL INGRESO Nº" : "LA SALIDA Nº") + 
                dgvDetalle["NumIngSalProducto", dgvDetalle.CurrentRow.Index].Value.ToString());
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFecha.Checked)
                Variable = "Del " + dtFechaIni.Value.ToShortDateString() + " Al " + dtFechaFin.Value.ToShortDateString();

            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_IngrSal";
            base.ImprLista(sql, nomtabla, "LISTA DE " + Tupla + (ImpAnulado ? " ANULADAS" : ""), Variable,
                DConstantes.Imprimir.Lista_IngSalProd.NOM_REPORTE_LISTA_INGSALPROD,
                DConstantes.Imprimir.Lista_IngSalProd.MOSTRAR_BTN_IMP,
                DConstantes.Imprimir.Lista_IngSalProd.MOSTRAR_BTN_COPIAR,
                DConstantes.Imprimir.Lista_IngSalProd.MOSTRAR_BTN_EXPORT,
                DConstantes.Imprimir.Lista_IngSalProd.MOSTRAR_ARBOL);
        }

        private void chkTipo_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipo.Enabled = chkTipo.Checked;
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtFechaIni.Enabled = chkFecha.Checked;
            dtFechaFin.Enabled = chkFecha.Checked;
        }

        private void chkAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            cmbAlmacen.Enabled = chkAlmacen.Checked;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
                return;

            Modificar(Tupla);
        }

        private void btnImpListaDetallado_Click(object sender, EventArgs e)
        {
            string Variable = string.Empty;
            if (chkFecha.Checked)
                Variable = "Del " + dtFechaIni.Value.ToShortDateString() + " Al " + dtFechaFin.Value.ToShortDateString();

            string[] sql = new string[2];
            string[] nomtabla = new string[2];
            sql[0] = Consulta;
            sql[1] = "SELECT * FROM Vista_Detalle_IngSalProd WHERE CodIngSalProd IN (" + ConsultaDetalle + ")";
            nomtabla[0] = "Lista_IngrSal";
            nomtabla[1] = "Detalle_IngSalProd";
            base.ImprLista(sql, nomtabla, "LISTA DE " + Tupla + " DETALLADO" + (ImpAnulado ? " ANULADAS" : ""), Variable,
                DConstantes.Imprimir.Lista_IngSalProd_Detallado.NOM_REPORTE_LISTA_INGSALPROD_DETALLADO,
                DConstantes.Imprimir.Lista_IngSalProd_Detallado.MOSTRAR_BTN_IMP,
                DConstantes.Imprimir.Lista_IngSalProd_Detallado.MOSTRAR_BTN_COPIAR,
                DConstantes.Imprimir.Lista_IngSalProd_Detallado.MOSTRAR_BTN_EXPORT,
                DConstantes.Imprimir.Lista_IngSalProd_Detallado.MOSTRAR_ARBOL);
        }

    }
}

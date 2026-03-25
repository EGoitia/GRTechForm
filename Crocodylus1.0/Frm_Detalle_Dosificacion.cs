using System;
using System.Windows.Forms;
using Datos;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Dosificacion : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Detalle_Dosificacion detdosific = null;
        string Consulta;

        public Frm_Detalle_Dosificacion()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;

            dgvDetalle.Columns["DosificacionID"].HeaderText = "Nº";
            dgvDetalle.Columns["Descripcion"].HeaderText = "Descripción";
            dgvDetalle.Columns["Autorizacion"].HeaderText = "Autorización";
            dgvDetalle.Columns["Llave"].HeaderText = "Llave";
            dgvDetalle.Columns["Fecha_Ini"].HeaderText = "Fecha Inicial";
            dgvDetalle.Columns["Fecha_Lim"].HeaderText = "Fecha Límite";
            dgvDetalle.Columns["Leyenda"].HeaderText = "Leyenda";
            dgvDetalle.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvDetalle.Columns["Actividad"].HeaderText = "Actividad";
            dgvDetalle.Columns["TipoDosificacion"].HeaderText = "Tipo";

            dgvDetalle.Columns["DosificacionID"].FillWeight = 60;
            dgvDetalle.Columns["Descripcion"].FillWeight = 150;
            dgvDetalle.Columns["Autorizacion"].FillWeight = 100;
            dgvDetalle.Columns["Llave"].FillWeight = 150;
            dgvDetalle.Columns["Fecha_Ini"].FillWeight = 70;
            dgvDetalle.Columns["Fecha_Lim"].FillWeight = 70;
            dgvDetalle.Columns["Leyenda"].FillWeight = 200;
            dgvDetalle.Columns["NomSuc"].FillWeight = 100;
            dgvDetalle.Columns["Actividad"].FillWeight = 200;
            dgvDetalle.Columns["TipoDosificacion"].FillWeight = 70;
        }

        private void ListarSucursal()
        {
            try
            {
                cboSucursal.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 UNION SELECT -1, '[TODAS]' ORDER BY NomSuc");
                cboSucursal.DisplayMember = "NomSuc";
                cboSucursal.ValueMember = "SucursalID";
                cboSucursal.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS AL CARGAR LAS SUCURSALES", "SUCURSALES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarActividad()
        {
            try
            {
                cboActividad.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo WHERE Estado=1 AND Tupla='Actividad' UNION SELECT -1, '[TODAS]' ORDER BY NomTipo");
                cboActividad.DisplayMember = "NomTipo";
                cboActividad.ValueMember = "TipoID";
                cboActividad.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS AL CARGAR LAS ACTIVIDADES", "ACTIVIDADES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoFactura()
        {
            try
            {
                cboTipoFact.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND Tupla='FACTURA' UNION SELECT -1, '[TODAS]' ORDER BY NomTipo");
                cboTipoFact.DisplayMember = "NomTipo";
                cboTipoFact.ValueMember = "TipoID";
                cboTipoFact.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS AL CARGAR LOS TIPOS DE FACTURAS", "TIPOS FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            try
            {
                Consulta = "SELECT DosificacionID, CodInmode, Descripcion, Autorizacion, Llave, Fecha_Ini, Fecha_Lim, " +
                    "Estado, Leyenda, NomSuc, Actividad, TipoDosificacion " +
                    "FROM Vista_Dosificacion WHERE Eliminado=0";

                if (cboSucursal.SelectedValue.ToString() != "-1")
                    Consulta += " AND SucursalID=" + cboSucursal.SelectedValue.ToString();

                if(cboActividad.SelectedValue.ToString() != "-1")
                    Consulta += " AND ActividadID=" + cboActividad.SelectedValue.ToString();

                if (cboTipoFact.SelectedValue.ToString() != "-1")
                    Consulta += " AND TipoDosificacionID=" + cboTipoFact.SelectedValue.ToString();

                if (cboEstado.Text != "[TODAS]")
                    Consulta += " AND Estado=" + (cboEstado.Text == "VIGENTE" ? 1 : 0);

                if (chkFechasVenc.Checked)
                    Consulta += " AND CONVERT(DATE, Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "'";

                Consulta += " ORDER BY DosificacionID ASC";

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
                    dgvDetalle.CurrentCell = dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Cells[2];
            }
        }

        private void Frm_Detalle_Dosificacion_Load(object sender, EventArgs e)
        {
            cboEstado.Text = "VIGENTE";
            ListarSucursal();
            ListarActividad();
            ListarTipoFactura();

            Buscar();
            NombreColumnas();
        }

        private void Frm_Detalle_Dosificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            detdosific.Dispose();
            detdosific = null;            
        }
    }
}

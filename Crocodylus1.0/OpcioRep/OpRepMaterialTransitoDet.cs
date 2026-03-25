using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Negocio;

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepMaterialTransitoDet : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        public OpRepMaterialTransitoDet()
        {
            InitializeComponent();
        }

        #region Conexion Capa de Negocio

        private void ListarAlmacen()
        {
            try
            {
                List<OAlmacen> LAlm = NAlmacen.NListarAlmacenes(-1).OrderBy(x => x.NomAlmacen).ToList();
                cboOpcionBusq.DataSource = LAlm;
                cboOpcionBusq.DisplayMember = "NomAlmacen";
                cboOpcionBusq.ValueMember = "AlmacenID";
                cboOpcionBusq.Text = OConexionGlobal.NomSuc;
                cboOpcionBusq.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarProveedor()
        {
            try
            {
                List<OProveedor> LProv = NProveedor.NListarProv().OrderBy(x => x.NomProv).ToList();
                cboOpcion.DataSource = LProv;
                cboOpcion.DisplayMember = "NomProv";
                cboOpcion.ValueMember = "ProveedorID";
                cboOpcion.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepMaterialTransitoDet_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarAlmacen();
            ListarProveedor();

            cboBusqX.Text = "TOTALES";
            cboBusqEn.Text = "Empresa";

            dtFecIni.Value = Convert.ToDateTime("01-01-2013");
            dtFecIni.MaxDate = DateTime.Now;
            dtFecFin.MaxDate = DateTime.Now;

            op.CerrarCargando();
        }

        private void OpRepMaterialTransitoDet_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cboBusqX_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBusqX.Text == "TOTALES")
                cboOpcion.Enabled = false;
            else
                cboOpcion.Enabled = true;
        }

        private void cboBusqEn_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBusqEn.Text == "Empresa")
                cboOpcionBusq.Enabled = false;
            else
                cboOpcionBusq.Enabled = true;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Reportes.RepTransitoValoradoDetallado reptrandet = new Reportes.RepTransitoValoradoDetallado(cboBusqX.Text, Convert.ToInt32(cboOpcion.SelectedValue),
                                                                                                         cboOpcion.Text, cboBusqEn.Text, Convert.ToInt32(cboOpcionBusq.SelectedValue),
                                                                                                         cboOpcionBusq.Text, dtFecIni.Value, dtFecFin.Value);
            reptrandet.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando");

            ListarProveedor();
            ListarAlmacen();

            op.CerrarCargando();
        }

        #endregion
    }
}

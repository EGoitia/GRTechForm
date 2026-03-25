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
    public partial class OpRepRevVenXProd : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<ORubroSubRubro> LRubSubrub = null;

        public OpRepRevVenXProd()
        {
            InitializeComponent();
        }

        #region Conexion Capa Negocio

        private void ListarRubSubRub()
        {
            try
            {
                LRubSubrub = NRubroSubRubro.NListarRubroSubRubro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarSuc()
        {
            try
            {
                List<OSucursal> LSuc = NSucursal.NListarSucursales().OrderBy(x => x.NomSuc).ToList();
                cboOpcionBusq.DataSource = LSuc;
                cboOpcionBusq.ValueMember = "SucursalID";
                cboOpcionBusq.DisplayMember = "NomSuc";
                cboOpcionBusq.Text = OConexionGlobal.NomSuc;
                cboOpcionBusq.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CargarDatos

        private void CargarRubSubRub(string tipo)
        {
            if(LRubSubrub != null)
            {
                List<ORubroSubRubro> lrubsubrub = LRubSubrub.FindAll(x => x.Tipo == tipo).ToList();
                cboOpcion.DataSource = lrubsubrub;
                cboOpcion.ValueMember = "RubroSubRubroID";
                cboOpcion.DisplayMember = "NomRubroSubRubro";
                cboOpcion.Refresh();
            }
        }

        private void Procesar()
        {
            Reportes.RepMovVentasXProd movvenprod = new Reportes.RepMovVentasXProd(cboBusqX.Text, Convert.ToInt32(cboOpcion.SelectedValue),
                                                                                 cboOpcion.Text, cboBusqEn.Text, Convert.ToInt32(cboOpcionBusq.SelectedValue),
                                                                                 cboOpcionBusq.Text, dtFIni.Value, dtFFin.Value, cboOrdenado.Text);
            movvenprod.Show();
        }

        #endregion

        #region Eventos Formulario

        private void OpRepRevVenXProd_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarRubSubRub();
            ListarSuc();

            cboBusqX.Text = "TOTALES";
            cboBusqEn.Text = "Empresa";
            cboOrdenado.Text = "Utilidad";

            dtFIni.MaxDate = DateTime.Now;
            dtFFin.MaxDate = DateTime.Now;

            op.CerrarCargando();
        }

        private void cboBusqX_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBusqX.Text == "TOTALES")
                cboOpcion.Enabled = false;
            else if(cboBusqX.Text == "RUBRO")
            {
                CargarRubSubRub("Rubro");
                cboOpcion.Enabled = true;
            }
            else // SUBRUBRO
            {
                CargarRubSubRub("SubRubro");
                cboOpcion.Enabled = true;
            }
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
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpRepRevVenXProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        #endregion
    }
}

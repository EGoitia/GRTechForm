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
    public partial class OpRepCuentasPorCobrarPagarGral : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OSucursal> LSuc = null;
        List<OCliente> LCli = null;

        string Opcion = string.Empty;

        public OpRepCuentasPorCobrarPagarGral(string opcion)
        {
            InitializeComponent();

            Opcion = opcion;
        }

        #region Config. Formulario

        private void HabilitarCont()
        {
        }

        #endregion

        #region Conexion Capa de Negocios

        private void ListarSuc()
        {
            try
            {
                LSuc = NSucursal.NListarSucursales().OrderBy(x => x.NomSuc).ToList();
                cboOpcionBusq.DataSource = LSuc;
                cboOpcionBusq.ValueMember = "SucursalID";
                cboOpcionBusq.DisplayMember = "NomSuc";
                cboOpcionBusq.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Funciones

        private void Procesar()
        {
            Reportes.RepCuentasPorPagarCobrar rcuenxcobpag = new Reportes.RepCuentasPorPagarCobrar(Opcion, cboBusqEn.Text, 
                                            Convert.ToInt32(cboOpcionBusq.SelectedValue), cboOpcionBusq.Text, dtFecha.Value);
            rcuenxcobpag.Show();
        }

        #endregion

        #region Eventos Formulario

        private void OpRepCuentasPorCobrarGral_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            if (Opcion == "Proveedor")
                this.Text = "Cuentas por Pagar " + Opcion;
            else
                this.Text = "Cuentas por Cobrar " + Opcion;

            cboBusqEn.Text = "Empresa";
            dtFecha.MaxDate = DateTime.Now;
            HabilitarCont();
            ListarSuc();

            op.CerrarCargando();
        }

        private void cboBusqEn_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBusqEn.Text == "Empresa")
                cboOpcionBusq.Enabled = false;
            else
                cboOpcionBusq.Enabled = true;
        }

        private void OpRepCuentasPorCobrarGral_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarSuc();

            op.CerrarCargando();
        }

        #endregion
    }
}

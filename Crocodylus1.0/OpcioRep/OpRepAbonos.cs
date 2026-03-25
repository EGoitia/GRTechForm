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
    public partial class OpRepAbonos : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        string Tipo = string.Empty;

        List<OCaja> LCaj = null;
        List<OSucursal> LSuc = null;
        List<OCliente> LCli = null;
        List<OProveedor> LProv = null;
        List<OPersonal> LPer = null;

        public OpRepAbonos(string tipo)
        {
            InitializeComponent();

            Tipo = tipo;
        }

        #region Conexion Caja de Negocio
        

        private void ListarSucursal()
        {
            try
            {
                LSuc = NSucursal.NListarSucursales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCliente()
        {
            try
            {
                LCli = NCliente.NListarClientes(OConexionGlobal.SucursalID);
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
                LProv = NProveedor.NListarProv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarPersonal()
        {
            try
            {
                LPer = NPersonal.NListarPersonales("", -1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CargarDatos

        private void CargarCaja()
        {
            if(LCaj != null)
            {
                cboOpcionBusq.DataSource = LCaj;
                cboOpcionBusq.ValueMember = "CajaID";
                cboOpcionBusq.DisplayMember = "NomCaja";
                cboOpcionBusq.Refresh();
            }
        }

        private void CargarSucursal()
        {
            if(LSuc != null)
            {
                cboOpcionBusq.DataSource = LSuc;
                cboOpcionBusq.DisplayMember = "NomSuc";
                cboOpcionBusq.ValueMember = "SucursalID";
                cboOpcionBusq.Text = OConexionGlobal.NomSuc;
                cboOpcionBusq.Refresh();
            }
        }
        
        private void Procesar()
        {

        }

        private void CargarDatos()
        {
            if(Tipo == "Cliente")
            {
                lblOpcion.Text = "Cliente..............";
                ListarCliente();
            }
            else if(Tipo == "Personal")
            {
                lblOpcion.Text = "Personal.............";
                ListarPersonal();
            }
            else if(Tipo == "Proveedor")
            {
                lblOpcion.Text = "Proveedor.............";
                ListarProveedor();
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepAbonos_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarSucursal();

            op.CerrarCargando();
        }

        private void cboBusqEn_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboBusqX_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboBusqX.Text == "TOTALES")
                cboOpcion.Enabled = false;
            else
                cboOpcion.Enabled = true;
        }

        private void OpRepAbonos_FormClosing(object sender, FormClosingEventArgs e)
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

            CargarDatos();

            op.CerrarCargando();
        }

        #endregion
    }
}

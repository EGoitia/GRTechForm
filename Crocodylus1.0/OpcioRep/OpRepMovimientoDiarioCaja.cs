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
    public partial class OpRepMovimientoDiarioCaja : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OCaja> LCaj = null;
        List<OSucursal> LSuc = null;

        string TipoCaja = string.Empty;

        public OpRepMovimientoDiarioCaja(string tipocaja)
        {
            InitializeComponent();

            TipoCaja = tipocaja;
        }

        #region Config Formulario

        private void HabilCont()
        {
        }

        #endregion

        #region Conexion Capa Negocios

        private void ListarCajas()
        {
            //try
            //{
            //    LCaj = NCaja.NListarCaja(-1, -1, "Totales");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

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

        #endregion

        #region Cargar Datos

        private void CargarCaja()
        {
            if(LCaj != null)
            {
                cboOpc.DataSource = LCaj;
                cboOpc.DisplayMember = "NomCaja";
                cboOpc.ValueMember = "CajaID";
                cboOpc.Refresh();
            }
        }

        private void CargarSucursal()
        {
            if(LSuc != null)
            {
                cboOpc.DataSource = LSuc;
                cboOpc.DisplayMember = "NomSuc";
                cboOpc.ValueMember = "SucursalID";
                cboOpc.Refresh();
            }
        }

        private void Procesar()
        {
            //Frm_Reporte rep = new Frm_Reporte();
            //rep.Titulo = "ARQUEO DE CAJA";
            //rep.Llenar_Tabla("SELECT * FROM Vista_Det_Abonos WHERE AbonoID=" + dgvDetalle["AbonoID", dgvDetalle.CurrentRow.Index].Value.ToString(), "Abono");
            //rep.Cargar("RptAbonos", false);
            //rep.Show();


            DateTime FecDel = Convert.ToDateTime(dtDel.Value.ToShortDateString());
            //FecDel = FecDel.AddHours(dtHrDel.Value.Hour).AddMinutes(dtHrDel.Value.Minute).AddSeconds(dtHrDel.Value.Second);
            DateTime FecAl = Convert.ToDateTime(dtAl.Value.ToShortDateString());
            //FecAl = FecAl.AddHours(dtHrAl.Value.Hour).AddMinutes(dtHrAl.Value.Minute).AddSeconds(dtHrAl.Value.Second);

            Reportes.RepMovDiarioCaja pmovdcaja = new Reportes.RepMovDiarioCaja(cboOpcRep.Text, cboOpc.Text, Convert.ToInt32(cboOpc.SelectedValue), FecDel, FecAl);
            pmovdcaja.Show();
        }

        #endregion

        #region Eventos Formulario

        private void MovimientoDiarioCaja_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarCajas();
            ListarSucursal();
            cboOpcRep.Text = "Sucursal";
            //HabilCont();

            dtDel.MaxDate = DateTime.Now;
            dtAl.MaxDate = DateTime.Now;

            op.CerrarCargando();
        }

        private void cboOpcRep_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cboOpcRep.Text)
            {
                case "Empresa":
                    cboOpc.Enabled = false;
                    break;
                case "Sucursal":
                    cboOpc.Enabled = true;
                    lblOpc.Text = "Sucursal...............";
                    CargarSucursal();
                    break;
                case "Caja":
                    cboOpc.Enabled = true;

                    if(TipoCaja == "Caja Chica")
                        lblOpc.Text = "Caja Chica...............";
                    else
                        lblOpc.Text = "Caja.....................";

                    CargarCaja();
                    break;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpRepMovimientoDiarioCaja_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #endregion
    }
}

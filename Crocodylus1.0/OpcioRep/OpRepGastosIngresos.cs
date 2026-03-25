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
    public partial class OpRepGastosIngresos : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OCuenta_Ingresos_Egresos> LGasIngr = null;
        List<OCaja> LCaj = null;
        List<OSucursal> LSuc = null;

        public OpRepGastosIngresos()
        {
            InitializeComponent();
        }

        #region Conexion Capa de Negocios

        private void ListarCaja()
        {
            //try
            //{
            //    LCaj = NCaja.NListarCaja(-1, -1, "Totales");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ListarGastosIngresos()
        {
            try
            {
                //LGasIngr = NGastosIngresos.NListarGastosIngresos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarCajas()
        {
            if(LCaj != null)
            {
                cboOpcionBusq.DataSource = LCaj;
                cboOpcionBusq.DisplayMember = "NomCaja";
                cboOpcionBusq.ValueMember = "CajaID";
                cboOpcionBusq.Refresh();
            }
        }

        private void CargarSucursal()
        {
            if (LSuc != null)
            {
                cboOpcionBusq.DataSource = LSuc;
                cboOpcionBusq.DisplayMember = "NomSuc";
                cboOpcionBusq.ValueMember = "SucursalID";
                cboOpcionBusq.Refresh();
            }
        }

        private void CargarGastosIngresos()
        {
            if(LGasIngr != null)
            {
                List<OCuenta_Ingresos_Egresos> lgasing = null;

                if (cboBusqX.Text == "INGRESO")
                    lgasing = LGasIngr.FindAll(x=>x.TipoIngresoEgreso == "Ingreso").OrderBy(x => x.Nombre).ToList();
                else
                    lgasing = LGasIngr.FindAll(x => x.TipoIngresoEgreso == "Egreso").OrderBy(x => x.Nombre).ToList();

                cboOpcion.DataSource = lgasing;
                cboOpcion.DisplayMember = "NomGastoIngreso";
                cboOpcion.ValueMember = "GastosIngrID";
                cboOpcion.Refresh();
            }
        }

        #endregion

        #region Funciones

        private void GastosIngr()
        {
            if (LGasIngr != null)
            {
                //mandamos por parametro la lista de gastos e ingresos que esten habilitados
               
            }
        }

        private void Procesar()
        {
            Reportes.RepGastosIngresos rgasing = new Reportes.RepGastosIngresos(cboBusqX.Text, Convert.ToInt32(cboOpcion.SelectedValue), 
                                                                                cboOpcion.Text, cboBusqEn.Text, 
                                                                                Convert.ToInt32(cboOpcionBusq.SelectedValue),
                                                                                cboOpcionBusq.Text, dtFecIni.Value, dtFecFin.Value);
            rgasing.Show();
        }

        #endregion

        #region Eventos Formulario

        private void OpRepGastosIngresos_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarCaja();
            ListarSucursal();
            ListarGastosIngresos();

            cboBusqX.Text = "EGRESO";
            cboBusqEn.Text = "CAJA";

            op.CerrarCargando();
        }

        private void OpRepGastosIngresos_FormClosing(object sender, FormClosingEventArgs e)
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
            op.AbrirCargando("Cargando....");

            ListarCaja();
            ListarSucursal();
            ListarGastosIngresos();

            op.CerrarCargando();
        }

        private void btnBuscaGastoIngre_Click(object sender, EventArgs e)
        {
            GastosIngr();
        }
        
        private void cboBusqX_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarGastosIngresos();

            switch (cboBusqX.Text)
            {
                case "INGRESO":
                    lblOpcion.Text = "Ingresos............";
                    cboOpcion.Enabled = true;
                    btnBuscaGastoIngre.Enabled = true;
                    break;
                case "EGRESO":
                    lblOpcion.Text = "Egresos.............";
                    cboOpcion.Enabled = true;
                    btnBuscaGastoIngre.Enabled = true;
                    break;
                case "TOTALES":
                    cboOpcion.Enabled = false;
                    btnBuscaGastoIngre.Enabled = false;
                    break;
            }
        }

        private void cboBusqEn_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cboBusqEn.Text)
            {
                case "CAJA":
                    CargarCajas();
                    cboOpcionBusq.Enabled = true;
                    lblOpcionBusq.Text = "Caja...............";
                    break;
                case "CAJA CHICA":
                    CargarCajas();
                    cboOpcionBusq.Enabled = true;
                    lblOpcionBusq.Text = "Caja Chica.........";
                    break;
                case "SUCURSAL":
                    CargarSucursal();
                    cboOpcionBusq.Enabled = true;
                    lblOpcionBusq.Text = "Sucursal...........";
                    break;
                case "EMPRESA":
                    cboOpcionBusq.Enabled = false;
                    break;
            }
        }

        #endregion
    }
}

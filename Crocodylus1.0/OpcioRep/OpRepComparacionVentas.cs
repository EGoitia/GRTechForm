using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; 

using Objetos;
using Negocio;
using System.Data;

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepComparacionVentas : Form, IAgregaClien, IAgregaPer, IAgregaProd
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OCliente> LCli = null;
        DataTable LPer = null;
        List<ORubroSubRubro> LRubSub = null;

        string[] mes = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

        #region ICliPerProd

        public void AgregaClien(Int32 cod, string nomcli)
        {
            cboCliProdVen.Text = nomcli;
        }

        public void AgregaProd(OProducto oprod)
        {
            cboCliProdVen.Items.Clear();
            cboCliProdVen.Items.Add(oprod.NomProd);
            cboCliProdVen.ValueMember = oprod.ProductoID.ToString();
            cboCliProdVen.Text = oprod.NomProd;
        }

        public void AgregaPer(string nomper)
        {
            cboCliProdVen.Text = nomper;
        }

        #endregion

        public OpRepComparacionVentas()
        {
            InitializeComponent();
        }

        #region Conexion Capa de Negocio

        private void Procesar()
        {
            op.AbrirCargando("Procesando....");

            //agregamos el color
            //this.chartVentas.Palette = ChartColorPalette.Excel;
            //borramos todo
            this.chartRep.Series["Mes"].Points.Clear();
            this.chartRep.Titles.Clear();

            //agregamos el titulo de la grafica
            this.chartRep.Titles.Add("Comparacion de Ventas por Meses");
            ////creamos una nueva serie
            //Series Ventas = new Series();
            //Ventas.Points[0].AxisLabel=""

            //agregamos las graficas

            try
            {
                int cont = 0;
                int suc = -1;
                int id = -1;

                if ((cboTipoBusq.Text == "Cliente") || (cboTipoBusq.Text == "Vendedor") || 
                    (cboTipoBusq.Text == "Rubro")|| (cboTipoBusq.Text == "SubRubro"))
                    id = Convert.ToInt32(cboCliProdVen.SelectedValue);
                else
                    id = Convert.ToInt32(cboCliProdVen.ValueMember);

                if (ckbxSuc.Checked)
                    suc = Convert.ToInt32(cboSuc.SelectedValue);

                foreach (var item in NComparacionVenta.DBuscarRepComparCompraVentas("Ventas", dtAnio.Value.Year, cboTipoVen.Text, suc,
                                                                                    ckbxEspecif.Checked, cboTipoBusq.Text, id))
                {
                    this.chartRep.Series["Mes"].Points.Add(Convert.ToDouble(item.Monto));
                    this.chartRep.Series["Mes"].Points[cont].AxisLabel = mes[item.NomMes - 1];
                    this.chartRep.Series["Mes"].Points[cont].LegendText = mes[item.NomMes - 1];
                    this.chartRep.Series["Mes"].Points[cont].Label = string.Format("{0:#,##0.00}", item.Monto);

                    cont++;
                }
            }
            catch (Exception)
            {        }
            
            op.CerrarCargando();
        }

        private void ListarSuc()
        {
            try
            {
                cboSuc.DataSource = NSucursal.NListarSucursales();
                cboSuc.ValueMember = "SucursalID";
                cboSuc.DisplayMember = "NomSuc";
                cboSuc.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCli()
        {
            try
            {
                LCli = NCliente.NListarClientes(OConexionGlobal.SucursalID).OrderBy(x => x.NomClien).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarVen()
        {
            try
            {
                LPer = NListarPersonalizado.ConsultarDT("SELECT PersonalID, NomPer FROM Vista_Personal WHERE CargoID IN(2, 3) AND Estado=1 " +
                        "ORDER BY NomPer");
               //NPersonal.NListarPersonales("VentasTotal", -1).OrderBy(x => x.NomPer).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarRubSub()
        {
            try
            {
                LRubSub = NRubroSubRubro.NListarRubroSubRubro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarCli()
        {
            if(LCli != null)
            {
                cboCliProdVen.DataSource = LCli;
                cboCliProdVen.ValueMember = "ClienteID";
                cboCliProdVen.DisplayMember = "NomClien";
                cboCliProdVen.Refresh();
            }
        }

        private void CargarVen()
        {
            if(LPer != null)
            {
                cboCliProdVen.DataSource = LPer;
                cboCliProdVen.ValueMember="PersonalID";
                cboCliProdVen.DisplayMember = "NomPer";
                cboCliProdVen.Refresh();
            }
        }

        private void CargarRubSub(string op)
        {
            if(LRubSub != null)
            {
                List<ORubroSubRubro> lrubsub = LRubSub.FindAll(x => x.Tipo == op).OrderBy(x => x.NomRubroSubRubro).ToList();
                cboCliProdVen.DataSource = lrubsub;
                cboCliProdVen.DisplayMember = "NomRubroSubRubro";
                cboCliProdVen.ValueMember = "RubroSubRubroID";
                cboCliProdVen.Refresh();
            }
        }

        #endregion

        #region Funciones

        private void SeleccionarTipo()
        {
            switch(cboTipoBusq.Text)
            {
                case "Cliente":
                    lblCliProdVen.Text = "Cliente........";
                    CargarCli();
                    break;
                case "Vendedor":
                    lblCliProdVen.Text = "Vendedor.......";
                    CargarVen();
                    break;
                case "Rubro":
                    lblCliProdVen.Text = cboTipoBusq.Text + "..........";
                    CargarRubSub(cboTipoBusq.Text);
                    break;
                case "SubRubro":
                    goto case "Rubro";
                case "Producto":
                    lblCliProdVen.Text = "Producto.......";
                    cboCliProdVen.DataSource = null;
                    break;
            }
        }

        private void BuscarTipo()
        {
            switch(cboTipoBusq.Text)
            {
                case "Cliente":
                    Buscadores.Buscador bcli = new Buscadores.Buscador();
                    bcli.Owner = this;
                    bcli.ShowDialog();
                    break;
                case "Vendedor":
                    
                    break;
                case "Rubro":
                    break; 
                case "SubRubro":
                    goto case "Rubro";
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepComparacionVentas_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            ListarSuc();
            ListarCli();
            ListarVen();
            ListarRubSub();

            cboTipoBusq.Text = "Cliente";
            cboTipoVen.Text = "Contado";
            cboSuc.Enabled = false;
            gbxEspecif.Enabled = false;
            dtAnio.MinDate = Convert.ToDateTime("2012-01-01 00:00:00");
            dtAnio.MaxDate = DateTime.Now;

            op.CerrarCargando();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void OpRepComparacionVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cboTipoVen_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cboTipoVen.Text)
            {
                case "Contado":
                    this.BackColor = System.Drawing.Color.LightSeaGreen;
                    break;
                case "Credito":
                    this.BackColor = System.Drawing.Color.YellowGreen;
                    break;
                case "Anticipado":
                    this.BackColor = System.Drawing.Color.Plum;
                    break;
                case "Devol. Contado":
                    this.BackColor = System.Drawing.Color.MediumSlateBlue;
                    break;
                case "Devol. Credito":
                    this.BackColor = System.Drawing.Color.MediumSpringGreen;
                    break;
                case "Intercambio Material":
                    this.BackColor = System.Drawing.Color.MintCream;
                    break;
                case "Descuentos/Ventas":
                    this.BackColor = System.Drawing.Color.MediumBlue;
                    break;
            }
        }

        private void ckbxSuc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxSuc.Checked)
                cboSuc.Enabled = true;
            else
                cboSuc.Enabled = false;
        }

        private void ckbxEspecif_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxEspecif.Checked)
                gbxEspecif.Enabled = true;
            else
                gbxEspecif.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarTipo();
        }

        private void cboTipoBusq_SelectedValueChanged(object sender, EventArgs e)
        {
            SeleccionarTipo();
        }

        #endregion
    }
}

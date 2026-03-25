using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepComparacionVentasVendedores : Form
    {
        public static OpRepComparacionVentasVendedores compvend = null;

        public OpRepComparacionVentasVendedores()
        {
            InitializeComponent();
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

        private void ListarVen()
        {
            try
            {
                DataTable LPer = NListarPersonalizado.ConsultarDT("SELECT PersonalID, NomPer FROM Vista_Personal WHERE CargoID IN(2, 3) AND Estado=1 " +
                        "UNION SELECT -1, '[TODOS LOS VENDEDORES]' ORDER BY NomPer");
                cboCliProdVen.DataSource = LPer;
                cboCliProdVen.DisplayMember = "NomPer";
                cboCliProdVen.ValueMember = "PersonalID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Procesar()
        {
            //agregamos el color
            //this.chartVentas.Palette = ChartColorPalette.Excel;
            //borramos todo
            this.chartRep.Series["Mes"].Points.Clear();
            this.chartRep.Titles.Clear();

            //agregamos el titulo de la grafica
            this.chartRep.Titles.Add("Comparacion de Ventas por Vendedores");
            ////creamos una nueva serie
            //Series Ventas = new Series();
            //Ventas.Points[0].AxisLabel=""

            //agregamos las graficas

            try
            {
                int cont = 0;
                int suc = -1;
                int id = -1;

                id = Convert.ToInt32(cboCliProdVen.SelectedValue);
                if (ckbxSuc.Checked)
                    suc = Convert.ToInt32(cboSuc.SelectedValue);

                string consulta = string.Empty;
                if (rbtnMonto.Checked)
                    consulta = "SELECT datepart(month, vv.Fecha) as Mes, SUM(vv.MontoBs) as Monto, vv.NomVendedor as Descripcion FROM Vista_Ventas vv ";
                else
                    consulta = "SELECT datepart(month, vv.Fecha) as Mes, SUM(dv.Cantidad) as Monto, vv.NomVendedor as Descripcion FROM Vista_Ventas vv " +
                               "INNER JOIN Detalle_Venta dv ON vv.CodVenta=dv.CodVenta ";

                consulta += " WHERE YEAR(vv.Fecha)='" + dtMes.Value.Year.ToString() + "' AND MONTH(vv.Fecha)=" + dtMes.Value.Month.ToString() + " ";
                 
                if (cboTipoVen.Text != "Todas las Ventas")
                    consulta += "AND vv.TipoVenta='" + cboTipoVen.Text + "' ";
               
                if (ckbxSuc.Checked)
                    consulta += "AND vv.SucursalID=" + cboSuc.SelectedValue + " ";

                if (Convert.ToInt32(cboCliProdVen.SelectedValue) > 0)
                    consulta += "AND vv.VendedorID=" + cboCliProdVen.SelectedValue + " ";

                consulta += "AND vv.Estado=1 " + (rbtnCantidad.Checked ? " AND dv.Estado=1" : "") + " GROUP BY datepart(month, vv.Fecha), vv.NomVendedor";

                List<OComparacionVentasCompras> result = NComparacionVenta.NBuscarRepComparVentasVendedores(consulta);

                if (result != null)
                {
                    foreach (var item in result)
                    {
                        this.chartRep.Series["Mes"].Points.Add(Convert.ToDouble(item.Monto));
                        this.chartRep.Series["Mes"].Points[cont].AxisLabel = item.Descripcion;// mes[item.NomMes - 1];
                        this.chartRep.Series["Mes"].Points[cont].LegendText = item.Descripcion; // mes[item.NomMes - 1];
                        this.chartRep.Series["Mes"].Points[cont].Label = string.Format("{0:#,##0.00}", item.Monto);

                        cont++;
                    }
                }
                else
                    this.chartRep.Dispose();
            }
            catch (Exception)
            { }
        }

        private void OpRepComparacionVentasVendedores_Load(object sender, EventArgs e)
        {
            ListarSuc();
            ListarVen();

            dtMes.Value = DateTime.Now;
            cboTipoVen.Text = "Todas las Ventas";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void ckbxSuc_CheckedChanged(object sender, EventArgs e)
        {
            cboSuc.Enabled = ckbxSuc.Checked;
        }

        private void OpRepComparacionVentasVendedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            compvend.Dispose();
            compvend = null;
        }
    }
}

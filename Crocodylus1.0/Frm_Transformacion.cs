using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Transformacion : Form
    {
        public static Frm_Transformacion frmtransf = null;
        private DataTable ProdSalDT = new DataTable();
        private DataTable ProdIngrDT = new DataTable();

        public Frm_Transformacion()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            ProdSalDT.Columns.Add("ProductoID");
            ProdSalDT.Columns.Add("Codigo");
            ProdSalDT.Columns.Add("NomProd");
            ProdSalDT.Columns.Add("Cantidad", Type.GetType("System.Decimal"));
            dgvSalProd.DataSource = ProdSalDT;

            ProdIngrDT = ProdSalDT.Clone();
            dgvIngrProd.DataSource = ProdIngrDT;

            dgvSalProd.Columns["ProductoID"].Visible = false;
            dgvSalProd.Columns["Codigo"].ReadOnly = false;
            dgvSalProd.Columns["NomProd"].ReadOnly = false;
            dgvSalProd.Columns["Codigo"].HeaderText = "Código";
            dgvSalProd.Columns["NomProd"].HeaderText = "Producto";
            dgvSalProd.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvSalProd.Columns["Codigo"].FillWeight = 80;
            dgvSalProd.Columns["NomProd"].FillWeight = 250;
            dgvSalProd.Columns["Cantidad"].FillWeight = 80;
            dgvSalProd.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSalProd.Columns["Cantidad"].DefaultCellStyle.Format = "N2";

            dgvIngrProd.Columns["ProductoID"].Visible = false;
            dgvIngrProd.Columns["Codigo"].ReadOnly = false;
            dgvIngrProd.Columns["NomProd"].ReadOnly = false;
            dgvIngrProd.Columns["Codigo"].HeaderText = "Código";
            dgvIngrProd.Columns["NomProd"].HeaderText = "Producto";
            dgvIngrProd.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvIngrProd.Columns["Codigo"].FillWeight = 80;
            dgvIngrProd.Columns["NomProd"].FillWeight = 250;
            dgvIngrProd.Columns["Cantidad"].FillWeight = 80;
            dgvIngrProd.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIngrProd.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
        }

        private void AbrirCerrarPanelBusqProd()
        {
            if (panelBusqProd.Width == 444)
            {
                panelBusqProd.Width = 41;
                dgvProd.Visible = false;
                panel2.Visible = false;
            }
            else
            {
                panelBusqProd.Width = 444;
                dgvProd.Visible = true;
                panel2.Visible = true;
                panelBusqProd.BackColor = Control.DefaultBackColor;
            }

            ListProdStock.FillWeight = 50;
        }

        private void ListarSucursal()
        {
            try
            {
                cboAlmacen.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc FROM Sucursal WHERE Estado=1 UNION SELECT -1, '[SELECCIONE UN ALMACÉN]' ORDER BY NomSuc");
                cboAlmacen.DisplayMember = "NomSuc";
                cboAlmacen.ValueMember = "SucursalID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAbriCerrarPanel_Click(object sender, EventArgs e)
        {
            AbrirCerrarPanelBusqProd();
        }

        private void Frm_Transformacion_Load(object sender, EventArgs e)
        {
            NombreColumnas();
            ListarSucursal();
        }

        private void Frm_Transformacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmtransf.Dispose();
            frmtransf = null;
        }
    }
}

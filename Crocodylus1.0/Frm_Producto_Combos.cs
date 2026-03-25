using Datos;
using Objetos;
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
    public partial class Frm_Producto_Combos : Form
    {
        public static Frm_Producto_Combos prod_combo = null;
        private bool BusqCombo = true;
        private DataTable ListaCombosDT;

        public Frm_Producto_Combos()
        {
            InitializeComponent();
        }

        private void AbrirCerrarPanelBusqProd()
        {
            if (panelBusqProd.Width == 317)
            {
                panelBusqProd.Width = 0;
                lblNomBusqProd.Visible = false;
                dgvBusqProd.Visible = false;
                panel2.Visible = false;
                panelBusqProd.BackColor = Color.LightSeaGreen;

                panelListaCombos.Visible = true;
                btnBusqCombo.Enabled = true;
                btnAgregarProd.Enabled = true;
                btnQuitarProd.Enabled = true;
            }
            else
            {
                panelBusqProd.Width = 317;
                lblNomBusqProd.Visible = true;
                dgvBusqProd.Visible = true;
                panel2.Visible = true;
                panelBusqProd.BackColor = Control.DefaultBackColor;

                panelListaCombos.Visible = false;
                btnBusqCombo.Enabled = false;
                btnAgregarProd.Enabled = false;
                btnQuitarProd.Enabled = false;
            }
        }

        private void ListarProductos()
        {
            try
            {
                string ConsultaSQL = "SELECT TOP 50 p.ProductoID, p.CodFabrica, p.Marca, p.NomGrupo, p.NomSubGrupo, p.NomProd, p.UnidMedida, " +
                    "s.StockAlmacen, p.PCostoEmp, p.PVentaMenorEmp, p.PVentaMayorEmp, p.Vencimiento, p.Serial, p.RegSanitario FROM Vista_Productos p " +
                    "INNER JOIN Stock_Prod s ON p.ProductoID=s.ProductoID WHERE p.Estado=1 AND s.AlmacenID=" + OConexionGlobal.SucursalID +
                    (BusqCombo ? " AND ClasificacionID=" + DConstantes.Clasificacion.Combo : " AND ClasificacionID<>" + DConstantes.Clasificacion.Combo);

                if (!string.IsNullOrWhiteSpace(txtBusqCodigo.Text))
                {
                    int prodid;
                    if (int.TryParse(txtBusqCodigo.Text, out prodid))
                        ConsultaSQL += " AND (p.ProductoID=" + txtBusqCodigo.Text.Trim() + " OR p.CodFabrica LIKE '%" + txtBusqCodigo.Text.Trim() + "%')";
                    else
                        ConsultaSQL += " AND p.CodFabrica LIKE '%" + txtBusqCodigo.Text.Trim() + "%'";
                }

                if (!string.IsNullOrWhiteSpace(txtBusqProducto.Text))
                    ConsultaSQL += " AND NomProd LIKE '%" + txtBusqProducto.Text.Trim() + "%'";
                if (!string.IsNullOrWhiteSpace(txtBusqMarca.Text))
                    ConsultaSQL += " AND Marca LIKE '%" + txtBusqMarca.Text.Trim() + "%'";
                if (!string.IsNullOrWhiteSpace(txtBusqGrupo.Text))
                    ConsultaSQL += " AND NomGrupo LIKE '%" + txtBusqGrupo.Text.Trim() + "%'";
                if (!string.IsNullOrWhiteSpace(txtBusqSubgrupo.Text))
                    ConsultaSQL += " AND NomSubGrupo LIKE '%" + txtBusqSubgrupo.Text.Trim() + "%'";

                dgvBusqProd.Rows.Clear();
                foreach (DataRow item in DListarPersonalizado.ConsultarDT(ConsultaSQL).Rows)
                {
                    dgvBusqProd.Rows.Add(item["ProductoID"], item["CodFabrica"], item["NomProd"], item["UnidMedida"], item["PVentaMenorEmp"], item["PVentaMayorEmp"], item["PCostoEmp"],
                        "Código: " + item["CodFabrica"] + Environment.NewLine + "Marca: " + item["Marca"] + Environment.NewLine +
                        "Grupo: " + item["NomGrupo"] + Environment.NewLine + "Subgrupo: " + item["NomSubGrupo"] + Environment.NewLine +
                        "Produco: " + item["NomProd"] + Environment.NewLine + "Medida: " + item["UnidMedida"] +
                        ((item.Field<bool>("Vencimiento") && (!string.IsNullOrEmpty(item["RegSanitario"].ToString()))) ? Environment.NewLine + "Reg. Sanitario:" + item["RegSanitario"] : ""));
                }

                if (dgvBusqProd.Rows.Count == 0)
                    MessageBox.Show("NO SE ENCONTRÓ EL PRODUCTO EN LA BASE DE DATOS", "PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                dgvBusqProd.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarCombos()
        {
            try
            {
                ListaCombosDT = DListarPersonalizado.ConsultarDT("SELECT * FROM ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarProducto(int fila)
        {
            if (dgvBusqProd.Rows.Count > 0)
            {
                if (fila >= 0) 
                {
                    if (BusqCombo)
                    {
                        txtID.Text = dgvBusqProd["ListBusqProdID", fila].Value.ToString();
                        txtCodigo.Text = dgvBusqProd["ListBusqProdCodigo", fila].Value.ToString();
                        txtMedida.Text = dgvBusqProd["ListBusqNomProd", fila].Value.ToString();
                        txtProducto.Text = dgvBusqProd["ListBusqUnidad", fila].Value.ToString();
                    }
                    else
                    {
                        dgvListProd.Rows.Add(dgvBusqProd["ListBusqProdID", fila].Value, dgvBusqProd["ListBusqNomProd", fila].Value,
                            dgvBusqProd["ListBusqUnidad", fila].Value, 1);
                    }
                }
            }
        }

        private void InsertModifCombo()
        { 
        
        }

        private void BorrarCampos()
        {
            txtID.Clear();
            txtCodigo.Clear();
            txtProducto.Clear();
            txtMedida.Clear();
            dgvListProd.Rows.Clear();
        }

        private void Frm_Producto_Combos_Load(object sender, EventArgs e)
        {
            AbrirCerrarPanelBusqProd();
            ListarCombos();
        }

        private void btnBusqCombo_Click(object sender, EventArgs e)
        {
            BusqCombo = true;
            AbrirCerrarPanelBusqProd();
            ListarProductos();
        }

        private void btnAbriCerrarPanel_Click(object sender, EventArgs e)
        {
            AbrirCerrarPanelBusqProd();
        }

        private void txtBusq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ListarProductos();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            BusqCombo = false;
            AbrirCerrarPanelBusqProd();
            ListarProductos();
        }

        private void dgvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AgregarProducto(e.RowIndex);
        }

        private void btnQuitarProd_Click(object sender, EventArgs e)
        {
            if (dgvListProd.Rows.Count > 0)
                if (dgvListProd.CurrentRow.Index >= 0)
                    dgvListProd.Rows.RemoveAt(dgvListProd.CurrentRow.Index);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqCombo_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAnulados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifCombo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿SEGURO QUE DESEA CANCELAR?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == System.Windows.Forms.DialogResult.Yes)
            {
                BorrarCampos();
            }
        }
    }
}

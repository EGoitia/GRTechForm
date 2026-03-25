using Datos;
using GRTechnology1._0.Clases;
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
    public partial class Frm_ImpCodigoBarra_Producto : Form
    {
        public static Frm_ImpCodigoBarra_Producto frmimpcodbarra = null;

        public Frm_ImpCodigoBarra_Producto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void Frm_ImpCodigoBarra_Producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmimpcodbarra.Dispose();
            frmimpcodbarra = null;
        }

        private void ListarProductos()
        {
            try
            {
                string consulta = @"select top 10 ProductoID, CodFabrica, NomProd, UnidMedida, Marca, NomGrupo, NomSubGrupo
                                    from Vista_Productos where Estado=1";

                if (!string.IsNullOrEmpty(txtCodigo.Text.Trim()))
                    consulta += " and CodFabrica='" + txtCodigo.Text.Trim() + "'";
                if (!string.IsNullOrEmpty(txtProducto.Text.Trim()))
                    consulta += " and NomProd like '%" + txtProducto.Text.Trim() + "%'";
                if (!string.IsNullOrEmpty(txtMarca.Text.Trim()))
                    consulta += " and Marca like '%" + txtMarca.Text.Trim() + "%'";
                if (!string.IsNullOrEmpty(txtGrupo.Text.Trim()))
                    consulta += " and NomGrupo like '%" + txtGrupo.Text.Trim() + "%'";
                if (!string.IsNullOrEmpty(txtSubgrupo.Text.Trim()))
                    consulta += " and NomSubGrupo like '%" + txtSubgrupo.Text.Trim() + "%'";

                DataTable dtproductos = DListarPersonalizado.ConsultarDT(consulta);
                DgvProductos.DataSource = dtproductos;
                NombreColumnasProd();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void NombreColumnasProd()
        {
            DgvProductos.Columns["ProductoID"].HeaderText = "ID";
            DgvProductos.Columns["ProductoID"].FillWeight = 50;
            DgvProductos.Columns["ProductoID"].ReadOnly = true;

            DgvProductos.Columns["CodFabrica"].HeaderText = "Código";
            DgvProductos.Columns["CodFabrica"].FillWeight = 50;
            DgvProductos.Columns["CodFabrica"].ReadOnly = true;

            DgvProductos.Columns["Marca"].HeaderText = "Marca";
            DgvProductos.Columns["Marca"].FillWeight = 150;
            DgvProductos.Columns["Marca"].ReadOnly = true;

            DgvProductos.Columns["NomGrupo"].HeaderText = "Grupo";
            DgvProductos.Columns["NomGrupo"].FillWeight = 150;
            DgvProductos.Columns["NomGrupo"].ReadOnly = true;

            DgvProductos.Columns["NomSubGrupo"].HeaderText = "Subgrupo";
            DgvProductos.Columns["NomSubGrupo"].FillWeight = 150;
            DgvProductos.Columns["NomSubGrupo"].ReadOnly = true;

            DgvProductos.Columns["NomProd"].HeaderText = "Producto";
            DgvProductos.Columns["NomProd"].FillWeight = 250;
            DgvProductos.Columns["NomProd"].ReadOnly = true;

            DgvProductos.Columns["UnidMedida"].HeaderText = "Medida";
            DgvProductos.Columns["UnidMedida"].FillWeight = 60;
            DgvProductos.Columns["UnidMedida"].ReadOnly = true;
        }

        private void NombreColumnasImpProd()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "ID";
            c1.HeaderText = "ID";
            c1.FillWeight = 50;
            c1.ReadOnly = true;
            DgvImpProd.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "CodFabrica";
            c2.HeaderText = "Código";
            c2.FillWeight = 50;
            c2.ReadOnly = true;
            DgvImpProd.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Marca";
            c3.HeaderText = "Marca";
            c3.FillWeight = 150;
            c3.ReadOnly = true;
            DgvImpProd.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "NomGrupo";
            c4.HeaderText = "Grupo";
            c4.FillWeight = 150;
            c4.ReadOnly = true;
            DgvImpProd.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "NomSubGrupo";
            c5.HeaderText = "Subgrupo";
            c5.FillWeight = 150;
            c5.ReadOnly = true;
            DgvImpProd.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "NomProd";
            c6.HeaderText = "Producto";
            c6.FillWeight = 250;
            c6.ReadOnly = true;
            DgvImpProd.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "CantFila";
            c7.HeaderText = "Cantidad Fila";
            c7.FillWeight = 80;
            c7.DefaultCellStyle.Format = "N0";
            c7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvImpProd.Columns.Add(c7);
        }

        private void Frm_ImpCodigoBarra_Producto_Load(object sender, EventArgs e)
        {
            NombreColumnasImpProd();
            ListarProductos();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow filakardex;
                Frm_Reporte rep = new Frm_Reporte();
                rep.Dts.Clear();

                for (int i = 0; i < DgvImpProd.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(DgvImpProd["CodFabrica", i].Value.ToString()))
                        throw new Exception("El producto " + DgvImpProd["NomProd", i].Value.ToString() + " no tiene un código válido");

                    int cantfila = Convert.ToInt32(DgvImpProd["CantFila", i].Value);
                    for (int j = 0; j < cantfila; j++)
                    {
                        filakardex = rep.Dts.Tables["Lista_Prod_Codigos"].NewRow();
                        filakardex["CodFabrica"] = DgvImpProd["CodFabrica", i].Value;
                        //filakardex["CodFabrica"] = CodigoBarras.CodigoBarrasStr(DgvProductos["CodFabrica", i].Value.ToString().Trim());
                        filakardex["NomProd"] = DgvImpProd["NomProd", i].Value;
                        filakardex["Marca"] = DgvImpProd["Marca", i].Value;
                        filakardex["NomGrupo"] = DgvImpProd["NomGrupo", i].Value;
                        filakardex["NomSubGrupo"] = DgvImpProd["NomSubGrupo", i].Value;

                        rep.Dts.Tables["Lista_Prod_Codigos"].Rows.Add(filakardex);
                    }
                }

                rep.Titulo = "KARDEX DE PRODUCTO";
                rep.Cargar("Carta\\RptListCodigoBarra", false);
                rep.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int fila = DgvProductos.CurrentRow.Index;

            if (string.IsNullOrEmpty(DgvProductos["CodFabrica", fila].Value.ToString()))
            {
                MessageBox.Show("El producto " + DgvProductos["NomProd", fila].Value.ToString() + " no tiene un código válido");
                return;
            }

            if (!ExisteItemImpProd(DgvProductos["ProductoID", fila].Value.ToString()))
            {
                DgvImpProd.Rows.Add(DgvProductos["ProductoID", fila].Value,
                        DgvProductos["CodFabrica", fila].Value,
                        DgvProductos["Marca", fila].Value,
                        DgvProductos["NomGrupo", fila].Value,
                        DgvProductos["NomSubGrupo", fila].Value,
                        DgvProductos["NomProd", fila].Value, 1);
            }
            else
            {
                MessageBox.Show("El produto " + DgvProductos["NomProd", fila].Value.ToString() + " ya se encuentra en la lista para imprimir");
            }
        }

        private bool ExisteItemImpProd(string id)
        {
            bool existe = false;
            for (int i = 0; i < DgvImpProd.Rows.Count; i++)
            {
                if (DgvImpProd["ID", i].Value.ToString() == id)
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                DgvImpProd.Rows.RemoveAt(DgvImpProd.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

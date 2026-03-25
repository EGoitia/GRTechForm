using Datos;
using Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Lista_Precios : GRTechnology1._0.Frm_Base_Detalles
    {
        public static Frm_Lista_Precios frmlprec = null;
        private string Consulta = string.Empty;

        public Frm_Lista_Precios()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvDetalle.Columns["ProductoID"].HeaderText = "ID";
            dgvDetalle.Columns["ProductoID"].FillWeight = 50;
            dgvDetalle.Columns["ProductoID"].ReadOnly = true;

            dgvDetalle.Columns["NomProd"].HeaderText = "Producto";
            dgvDetalle.Columns["NomProd"].FillWeight = 200;
            dgvDetalle.Columns["NomProd"].ReadOnly = true;

            dgvDetalle.Columns["UnidMedida"].HeaderText = "U.M.";
            dgvDetalle.Columns["UnidMedida"].FillWeight = 50;
            dgvDetalle.Columns["UnidMedida"].ReadOnly = true;

            dgvDetalle.Columns["NomGrupo"].HeaderText = "Grupo";
            dgvDetalle.Columns["NomGrupo"].ReadOnly = true;
            dgvDetalle.Columns["NomSubGrupo"].HeaderText = "SubGrupo";
            dgvDetalle.Columns["NomSubGrupo"].ReadOnly = true;

            dgvDetalle.Columns["PCostoEmp"].HeaderText = "Costo";
            dgvDetalle.Columns["PCostoEmp"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["PCostoEmp"].Visible = true;
            dgvDetalle.Columns["PCostoEmp"].ReadOnly = true;
            dgvDetalle.Columns["PCostoEmp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            dgvDetalle.Columns["PVentaMenorEmp"].HeaderText = "Precio Menor";
            dgvDetalle.Columns["PVentaMenorEmp"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["PVentaMenorEmp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDetalle.Columns["PVentaMayorEmp"].HeaderText = "Precio Mayor";
            dgvDetalle.Columns["PVentaMayorEmp"].DefaultCellStyle.Format = "N2";
            dgvDetalle.Columns["PVentaMayorEmp"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDetalle.Columns["Selec"].HeaderText = "Selec.";
            dgvDetalle.Columns["Selec"].FillWeight = 50;

            dgvDetalle.Columns["CodInmode"].Visible = false;
            dgvDetalle.Columns["Estado"].Visible = false;
        }

        private void ListarTipo()
        {
            try
            {
                cboTipoCliente.DataSource = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo WHERE Tupla='Cliente' UNION SELECT -1, '[GENERAL]' ORDER BY NomTipo");
                cboTipoCliente.DisplayMember = "NomTipo";
                cboTipoCliente.ValueMember = "TipoID";
                cboTipoCliente.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Buscar()
        {
            Consulta = "SELECT TOP 100 ProductoID, CodInmode, Estado, NomProd, UnidMedida, Marca, NomGrupo, NomSubGrupo, PCostoEmp, PVentaMenorEmp, " +
                       "PVentaMayorEmp, CONVERT(BIT, 0)Selec FROM Vista_Productos WHERE Estado=1 AND NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";

            if (!string.IsNullOrWhiteSpace(txtCodFab.Text))
                Consulta += " AND CodFabrica LIKE '%" + txtCodFab.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
                Consulta += " AND NomGrupo LIKE '%" + txtGrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtSubgrupo.Text))
                Consulta += " AND NomSubGrupo LIKE '%" + txtSubgrupo.Text.Trim() + "%'";
            if (!string.IsNullOrWhiteSpace(txtMarca.Text))
                Consulta += " AND Marca LIKE '%" + txtMarca.Text.Trim() + "%'";

            Consulta += " ORDER BY Marca, NomGrupo, NomSubGrupo, NomProd";
            DataTable ProdDT = DListarPersonalizado.ConsultarDT(Consulta);
            dgvDetalle.DataSource = ProdDT;
            NombreColumnas();
        }

        private DataTable ListPrecDT()
        {
            DataRow fila;
            DataTable ProdDT = new DataTable();
            ProdDT.Columns.Add("ProductoID");
            ProdDT.Columns.Add("Producto");
            ProdDT.Columns.Add("Rubro");
            ProdDT.Columns.Add("Subrubro");
            ProdDT.Columns.Add("UM");
            ProdDT.Columns.Add("Costo");
            ProdDT.Columns.Add("VentaMayor");
            ProdDT.Columns.Add("VentaMenor");
            ProdDT.Columns.Add("CantidadCaja");
            ProdDT.Columns.Add("CantMedida");
            ProdDT.Columns.Add("CantidadMetro");

            for (int i = 0; i < dgvDetalle.Rows.Count; i++)
            {
                if ((bool)dgvDetalle["Selec", i].Value)
                {
                    if (dgvDetalle["PVentaMayorEmp", i].Value == null || dgvDetalle["PVentaMenorEmp", i].Value == null)
                        throw new Exception("ERROR EN LA FILA " + (i + 1).ToString() + ", LOS PRECIOS NO PUEDEN ESTAR VACÍOS");
                    if (string.IsNullOrEmpty(dgvDetalle["PVentaMayorEmp", i].Value.ToString()) || string.IsNullOrEmpty(dgvDetalle["PVentaMenorEmp", i].Value.ToString()))
                        throw new Exception("ERROR EN LA FILA " + (i + 1).ToString() + ", LOS PRECIOS NO PUEDEN ESTAR VACÍOS");

                    decimal valor;
                    if (!decimal.TryParse(dgvDetalle["PVentaMayorEmp", i].Value.ToString(), out valor))
                        throw new Exception("ERROR EN LA FILA " + (i + 1).ToString() + ", EL PRECIO POR MAYOR TIENE QUE SER UN NÚMERO VÁLIDO");
                    else if (valor <= 0)
                        throw new Exception("ERROR EN LA FILA " + (i + 1).ToString() + ", EL PRECIO POR MAYOR TIENE QUE SER MAYOR A CERO");
                    else if (valor < Convert.ToDecimal(dgvDetalle["PCostoEmp", i].Value))
                        throw new Exception("ERROR EN LA FILA " + (i + 1).ToString() + ", EL PRECIO POR MAYOR NO PUEDE SER MENOR AL COSTO");

                    if (!decimal.TryParse(dgvDetalle["PVentaMenorEmp", i].Value.ToString(), out valor))
                        throw new Exception("ERROR EN LA FILA " + (i + 1).ToString() + ", EL PRECIO POR MENOR TIENE QUE SER UN NÚMERO VÁLIDO");
                    else if (valor <= 0)
                        throw new Exception("ERROR EN LA FILA " + (i + 1).ToString() + ", EL PRECIO POR MENOR TIENE QUE SER MAYOR A CERO");
                    else if (valor < Convert.ToDecimal(dgvDetalle["PCostoEmp", i].Value))
                        throw new Exception("ERROR EN LA FILA " + (i + 1).ToString() + ", EL PRECIO POR MENOR NO PUEDE SER MENOR AL COSTO");

                    fila = ProdDT.NewRow();
                    fila["ProductoID"] = dgvDetalle["ProductoID", i].Value;
                    fila["VentaMayor"] = dgvDetalle["PVentaMayorEmp", i].Value;
                    fila["VentaMenor"] = dgvDetalle["PVentaMenorEmp", i].Value;
                    ProdDT.Rows.Add(fila);
                }
            }

            if (ProdDT.Rows.Count  == 0)
                throw new Exception("NO EXISTE NINGÚN PRODUCTO EN LA LISTA PARA MODIFICAR");

            return ProdDT;
        }

        private void ModifListaPrecios()
        {
            try
            {
                bool resp = DProducto.DModifPreciosProd((int)cboTipoCliente.SelectedValue, ListPrecDT(), OInmode.DTInmode("", "MODIFICAR", "MODIFICACIÓN DE PRECIOS"));
                if (resp)
                    MessageBox.Show("LOS PRECIOS SE ACTUALIZARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Lista_Precios_Load(object sender, EventArgs e)
        {
            ListarTipo();
            Buscar();
        }

        private void Frm_Lista_Precios_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmlprec.Dispose();
            frmlprec = null;
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            string[] sql = new string[1];
            string[] nomtabla = new string[1];
            sql[0] = Consulta;
            nomtabla[0] = "Lista_Productos";
            base.ImprLista(sql, nomtabla, "LISTA DE PRECIOS", "ListPrec", "RptListaProductos", false);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            ModifListaPrecios();
        }

        private void dgvDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Buscar();
        }
    }
}

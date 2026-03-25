using System;
using System.Data;
using System.Windows.Forms;
using Datos;

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepProdVenXVendedor : Form
    {
        string Tipo = string.Empty;

        public OpRepProdVenXVendedor(string tipo)
        {
            InitializeComponent();

            Tipo = tipo;
        }

        #region Conexion Capa Negocio

        private void ListarMarcaRubroSubRubro()
        {
            try
            {
                DataSet DSDatos = DListarPersonalizado.ConsultarDS("SELECT TipoID, NomTipo FROM Tipo WHERE Estado=1 AND Tupla='Marca'; " +
                    "SELECT RubroSubRubroID, NomRubroSubRubro FROM RubroSubRubro WHERE Estado=1 AND Tipo='Rubro'; " +
                    "SELECT RubroSubRubroID, NomRubroSubRubro FROM RubroSubRubro WHERE Estado=1 AND Tipo='SubRubro'");

                //Marca
                cboMarca.DataSource = DSDatos.Tables[0];
                cboMarca.DisplayMember = "NomTipo";
                cboMarca.ValueMember = "TipoID";

                cboGrupo.DataSource = DSDatos.Tables[1];
                cboGrupo.DisplayMember = "NomRubroSubRubro";
                cboGrupo.ValueMember = "RubroSubRubroID";

                cboSubgrupo.DataSource = DSDatos.Tables[2];
                cboSubgrupo.DisplayMember = "NomRubroSubRubro";
                cboSubgrupo.ValueMember = "RubroSubRubroID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarSucursal()
        {
            try
            {
                dgvSuc.DataSource = DListarPersonalizado.ConsultarDT("SELECT SucursalID, NomSuc, CONVERT(BIT, 1) Selec FROM Sucursal ORDER BY NomSuc");

                dgvSuc.Columns["SucursalID"].Visible = false;
                dgvSuc.Columns["NomSuc"].HeaderText = "Sucursal";
                dgvSuc.Columns["NomSuc"].ReadOnly = true;
                dgvSuc.Columns["Selec"].HeaderText = "Selec.";
                dgvSuc.Columns["Selec"].FillWeight = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarClientePersonal()
        {
            try
            {
                dgvVendedores.DataSource = DListarPersonalizado.ConsultarDT((Tipo == "VENDEDOR" ? "SELECT PersonalID ID, NomPer Nombre, CONVERT(BIT, 1)Selec FROM Vista_Personal WHERE CargoID in(2, 3)" :
                    "SELECT ClienteID ID, NomClien Nombre, CONVERT(BIT, 1)Selec FROM Cliente"));

                dgvVendedores.Columns["ID"].Visible = false;
                dgvVendedores.Columns["Nombre"].HeaderText = "Nombre";
                dgvVendedores.Columns["Nombre"].FillWeight = 300;
                dgvVendedores.Columns["Nombre"].ReadOnly = true;
                dgvVendedores.Columns["Selec"].HeaderText = "Selec.";
                dgvVendedores.Columns["Selec"].FillWeight = 60;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepProdVenXVendedor_Load(object sender, EventArgs e)
        {
            ListarMarcaRubroSubRubro();
            ListarSucursal();
            ListarClientePersonal();

            this.Text = (Tipo == "VENDEDOR" ? "PRODUCTOS VENDIDOS POR VENDEDOR" : "PRODUCTOS VENDIDOS A CLIENTES");
            lblNomCliVende.Text = (Tipo == "VENDEDOR" ? "VENDEDORES" : "CLIENTES");
            
            dtFecIni.MaxDate = DateTime.Now;
            dtFecFin.MaxDate = DateTime.Now;

        }

        private void OpRepProdVenXVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string clivend = string.Empty;
            for (int i = 0; i < dgvVendedores.Rows.Count; i++)
            {
                if ((bool)dgvVendedores["Selec", i].Value)
                    clivend += dgvVendedores["ID", i].Value.ToString() + ", ";
            }

            string sucursales = string.Empty;
            for (int i = 0; i < dgvSuc.Rows.Count; i++)
            {
                if ((bool)dgvSuc["Selec", i].Value)
                    sucursales += dgvSuc["SucursalID", i].Value.ToString() + ", ";
            }

            if (clivend == string.Empty)
            {
                MessageBox.Show("SELECCIONE POR LO MENOS UN " + Tipo, Tipo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (sucursales == string.Empty)
            {
                MessageBox.Show("SELECCIONE POR LO MENOS UNA SUCURSAL", "SUCURSAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            string Consulta = "SELECT " + (Tipo == "VENDEDOR" ? "VendedorID ID, NomVendedor Nombre" : "ClienteID ID, NomClien Nombre") + ", SUM(dv.Cantidad*dv.PUnitario)Monto, SUM(dv.Cantidad) Cantidad FROM Vista_Ventas vv " +
                              "INNER JOIN Detalle_Venta dv ON vv.CodVenta=dv.CodVenta  INNER JOIN Vista_Productos vp ON vp.ProductoID=dv.ProductoID WHERE dv.Estado=1 AND vv.Estado=1 AND TipoVentaID<>6 " +
                              "AND CONVERT(DATE, vv.Fecha) BETWEEN '" + dtFecIni.Value.ToShortDateString() + "' AND '" + dtFecFin.Value.ToShortDateString() + "' " +
                              (Tipo == "VENDEDOR" ? "AND VendedorID IN (" : "AND ClienteID IN (")  + clivend.Substring(0, clivend.Length - 2) + 
                              ") AND vv.SucursalID IN(" + sucursales.Substring(0, sucursales.Length - 2) + ")";

            if (chkMarca.Checked)
                Consulta += " AND vp.MarcaID=" + cboMarca.SelectedValue;
            if(chkGrupo.Checked)
                Consulta += " AND vp.RubroID=" + cboGrupo.SelectedValue;
            if(chkSubgrupo.Checked)
                Consulta += " AND vp.SubRubroID=" + cboSubgrupo.SelectedValue;

            if (Tipo == "VENDEDOR")
                Consulta += " GROUP BY VendedorID, NomVendedor";
            else
                Consulta += " GROUP BY ClienteID, NomClien";

            Frm_Reporte rep = new Frm_Reporte();
            rep.Variable = "Del " + dtFecIni.Value.ToShortDateString() + "  Al  " + dtFecFin.Value.ToShortDateString();
            rep.Titulo = "PRODUCTOS VENDIDOS POR " + Tipo;
            rep.Llenar_Tabla(Consulta, "Rep_Ventas_Productos_Resum");

            if (rep.Dts.Tables["Rep_Ventas_Productos_Resum"].Rows.Count > 0)
            {
                rep.Cargar("RptVentasProductos", false);
                rep.Show();
            }
            else 
                MessageBox.Show("NO EXISTE NIGÚN REGISTRO CON ESTAS OPCIONES", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ListarMarcaRubroSubRubro();
            ListarSucursal();
            ListarClientePersonal();
        }
        
        private void chkMarca_CheckedChanged(object sender, EventArgs e)
        {
            cboMarca.Enabled = chkMarca.Checked;
            cboGrupo.Enabled = chkGrupo.Checked;
            cboSubgrupo.Enabled = chkSubgrupo.Checked;
        }
        
        private void chkSelec_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvVendedores.Rows.Count; i++)
            {
                dgvVendedores["Selec", i].Value = chkSelec.Checked;
            }
        }

        private void chkSelecSuc_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSuc .Rows.Count; i++)
            {
                dgvSuc["Selec", i].Value = chkSelecSuc.Checked;
            }
        }

        #endregion
    }
}

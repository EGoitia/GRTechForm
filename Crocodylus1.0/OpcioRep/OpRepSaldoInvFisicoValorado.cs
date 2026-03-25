using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;
using Datos;

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepSaldoInvFisicoValorado : Form
    {
        public OpRepSaldoInvFisicoValorado()
        {
            InitializeComponent();
        }

        #region Conexion Capa Negocio

        private void ListarMarcaRubroSubRubro()
        {
            try
            {
                DataSet DSDatos = DListarPersonalizado.ConsultarDS("SELECT TipoID, NomTipo FROM Tipo WHERE Estado=1 AND Tupla='Marca' UNION SELECT -1, '[TODAS]' ORDER BY NomTipo; " +
                    "SELECT RubroSubRubroID, NomRubroSubRubro FROM RubroSubRubro WHERE Estado=1 AND Tipo='Rubro' UNION SELECT -1, '[TODAS]' ORDER BY NomRubroSubRubro; " +
                    "SELECT RubroSubRubroID, NomRubroSubRubro FROM RubroSubRubro WHERE Estado=1 AND Tipo='SubRubro' UNION SELECT -1, '[TODAS]' ORDER BY NomRubroSubRubro");

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StockProdActual()
        {
            string sucursal = string.Empty;
            for (int i = 0; i < dgvSuc.Rows.Count; i++)
            {
                if ((bool)dgvSuc["Selec", i].Value)
                    sucursal += dgvSuc["SucursalID", i].Value.ToString() + ", ";
            }

            if (sucursal != string.Empty)
            {
                sucursal = sucursal.Substring(0, sucursal.Length - 2);
                string ConsultaSQL = "SELECT ProductoID, CodFabrica, Marca, NomGrupo, NomSubGrupo, NomProd, UnidMedida, StockAlmacen, NomSuc" +
                    (rbFisic.Checked ? " FROM Vista_Productos_Stock " : ", Costo PCostoEmp FROM Vista_Productos_Stock_Valorado") + " WHERE SucursalID IN (" + sucursal + ")";

                if (cboMarca.SelectedValue.ToString() != "-1")
                    ConsultaSQL += " AND MarcaID=" + cboMarca.SelectedValue;
                if (cboGrupo.SelectedValue.ToString() != "-1")
                    ConsultaSQL += " AND RubroID=" + cboGrupo.SelectedValue;
                if (cboSubgrupo.SelectedValue.ToString() != "-1")
                    ConsultaSQL += " AND SubRubroID=" + cboSubgrupo.SelectedValue;
                if (!string.IsNullOrWhiteSpace(txtProducto.Text))
                    ConsultaSQL += " AND NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";
                if (chkSaldoCero.Checked)
                    ConsultaSQL += " AND StockAlmacen<=0";
                else
                    ConsultaSQL += " AND StockAlmacen<>0";

                ConsultaSQL += " ORDER BY Marca, NomGrupo, NomSubGrupo, NomProd";

                Frm_Reporte rep = new Frm_Reporte();
                rep.Dts.Clear();
                rep.Variable = "Fecha de Corte: " + dtFecha.Value.ToShortDateString();
                rep.Variable2 = rbValor.Checked.ToString();
                rep.Titulo = (rbFisic.Checked ? rbFisic.Text.ToUpper() : rbValor.Text.ToUpper());
                rep.Llenar_Tabla(ConsultaSQL, "Lista_Productos");

                if (rep.Dts.Tables["Lista_Productos"].Rows.Count > 0)
                {
                    rep.Cargar("RepInventario", false);
                    rep.Show();
                }
                else
                    MessageBox.Show("NO EXISTE NINGÚN REGISTRO CON ESTAS OPCIONES", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("SELECCIONE POR LO MENOS UNA SUCURSAL", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void StockProdFecha()
        {
            DataTable DTSuc = new DataTable();
            DataRow DRSuc;
            DTSuc.Columns.Add("SucursalID");

            string sucursal = string.Empty;
            for (int i = 0; i < dgvSuc.Rows.Count; i++)
            {
                if ((bool)dgvSuc["Selec", i].Value)
                {
                    DRSuc = DTSuc.NewRow();
                    DRSuc["SucursalID"] = (int)dgvSuc["SucursalID", i].Value;
                    DTSuc.Rows.Add(DRSuc);

                    sucursal += dgvSuc["SucursalID", i].Value.ToString() + ", ";
                }
                 
            }

            if (sucursal != string.Empty)
            {
                sucursal = sucursal.Substring(0, sucursal.Length - 2);
                string ConsultaSQL = "SELECT p.ProductoID, p.CodFabrica, p.NomProd, p.UnidMedida, m.NomTipo Marca, r.NomRubroSubRubro NomGrupo, " +
                                     "sr.NomRubroSubRubro NomSubGrupo, 0 StockAlmacen, 0 PCostoEmp FROM Producto p LEFT OUTER JOIN Tipo m " +
                                     "ON p.MarcaID=m.TipoID INNER JOIN RubroSubRubro r ON r.RubroSubRubroID=p.RubroID INNER JOIN RubroSubRubro sr " +
                                     "ON p.SubRubroID=sr.RubroSubRubroID WHERE p.Estado=1 AND p.ClasificacionID NOT IN(1018, 1020)";

                if (cboMarca.SelectedValue.ToString() != "-1")
                    ConsultaSQL += " AND p.MarcaID=" + cboMarca.SelectedValue;
                if (cboGrupo.SelectedValue.ToString() != "-1")
                    ConsultaSQL += " AND p.RubroID=" + cboGrupo.SelectedValue;
                if (cboSubgrupo.SelectedValue.ToString() != "-1")
                    ConsultaSQL += " AND p.SubRubroID=" + cboSubgrupo.SelectedValue;
                if (!string.IsNullOrWhiteSpace(txtProducto.Text))
                    ConsultaSQL += " AND p.NomProd LIKE '%" + txtProducto.Text.Trim() + "%'";
                //if (chkSaldoCero.Checked)
                //    ConsultaSQL += " AND StockAlmacen<=0";
                //else
                //    ConsultaSQL += " AND StockAlmacen<>0";

                ConsultaSQL += " ORDER BY m.NomTipo, r.NomRubroSubRubro, sr.NomRubroSubRubro, p.NomProd";

                DataTable dtresultado = DSaldoInventarioFisValor.DBuscaSaldoInventarioFisValor(ConsultaSQL, dtFecha.Value, DTSuc);

                Frm_Reporte rep = new Frm_Reporte();
                rep.Dts.Clear();
                rep.Variable = "Fecha de Corte: " + dtFecha.Value.ToShortDateString();
                rep.Variable2 = rbValor.Checked.ToString();
                rep.Titulo = (rbFisic.Checked ? rbFisic.Text.ToUpper() : rbValor.Text.ToUpper());

                foreach (DataRow item in dtresultado.Rows)
                {
                    rep.Dts.Tables["Lista_Productos"].ImportRow(item);
                }
                
                //rep.Llenar_Tabla(StockFechaConsulta, "Lista_Productos");

                if (rep.Dts.Tables["Lista_Productos"].Rows.Count > 0)
                {
                    rep.Cargar("RepInventario", false);
                    rep.Show();
                }
                else
                    MessageBox.Show("NO EXISTE NINGÚN REGISTRO CON ESTAS OPCIONES", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("SELECCIONE POR LO MENOS UNA SUCURSAL", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        #region Eventos Formulario

        private void OpRepSaldoInvFisicoValorado_Load(object sender, EventArgs e)
        {
            ListarMarcaRubroSubRubro();
            ListarSucursal();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                object FechaActual = DListarPersonalizado.Dato("SELECT GETDATE()");

                if (((DateTime)FechaActual).ToShortDateString() == dtFecha.Value.ToShortDateString())
                    StockProdActual();
                else
                    StockProdFecha();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpRepSaldoInvFisicoValorado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ListarSucursal();
            ListarMarcaRubroSubRubro();
        }
                
        private void chkSelec_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSuc.Rows.Count; i++)
            {
                dgvSuc["Selec", i].Value = chkSelec.Checked;
            }
        }
        
        private void rbFisic_CheckedChanged(object sender, EventArgs e)
        {
            chkSaldoCero.Checked = false;
            chkSaldoCero.Visible = rbFisic.Checked;
        }

        #endregion
    }
}

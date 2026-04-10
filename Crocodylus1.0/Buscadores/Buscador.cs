using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Objetos;
using Datos;

namespace GRTechnology1._0.Buscadores
{
    public partial class Buscador : Form
    {
        public bool Seleccionado = false;
        public string Opcion = string.Empty;
        public string Variable = string.Empty;

        private bool Cargado = false;
        private DataTable DatosDT = null;

        public Buscador()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnas()
        {
            dgvDatos.Columns["TipoID"].Visible = false;
            dgvDatos.Columns["ID"].HeaderText = "ID";
            dgvDatos.Columns["Nombre"].HeaderText = Opcion;
            dgvDatos.Columns["Tipo"].HeaderText = "Tipo";

            dgvDatos.Columns["ID"].FillWeight = 50;
            dgvDatos.Columns["Nombre"].FillWeight = 150;
            dgvDatos.Columns["Tipo"].FillWeight = 100;
        }

        #endregion

        #region Conexion Capa de Negocio

        private void ListarTipo()
        {
            if (!chkTipo.Visible)
                return;

            try
            {
                string Consulta = string.Empty;
                switch (Opcion)
                {
                    case "Proveedor":
                    case "Cliente":
                        Consulta = "SELECT TipoID, NomTipo FROM Tipo WHERE Tupla='" + Opcion + "' AND Estado=1 ORDER BY NomTipo";
                        break;
                    case "Personal":
                        Consulta = "SELECT CargoID TipoID, NomCargo NomTipo FROM Cargo WHERE Estado=1 ORDER BY NomCargo";
                        break;
                    case "Banco":
                        Consulta = "SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Estado=1 AND Tupla='CAJA' AND TipoID IN(31, 33)";
                        break;
                }
                
                cboTipoCli.DataSource = DListarPersonalizado.ConsultarDT(Consulta);
                cboTipoCli.DisplayMember = "NomTipo";
                cboTipoCli.ValueMember = "TipoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listar_Datos()
        {
            try
            {
                string Consulta = string.Empty;
                if (Opcion == "Cliente")
                    Consulta = "SELECT ClienteID ID, NomClien Nombre, TipoClienteID TipoID, TipoClien Tipo FROM Vista_Clientes ORDER BY NomClien, TipoClien";
                else if (Opcion == "Proveedor")
                    Consulta = "SELECT ProveedorID ID, NomProv Nombre, TipoProvID TipoID, TipoProv Tipo FROM Vista_Proveedores ORDER BY NomProv, TipoProv";
                else if (Opcion == "Personal")
                    Consulta = "SELECT PersonalID ID, NomPer Nombre, CargoID TipoID, NomCargo Tipo FROM Vista_Personal WHERE Estado=1";
                else if (Opcion == "EGRESO" || Opcion == "INGRESO")
                    Consulta = "SELECT Cuenta_Ingreso_EgresoID ID, Nombre, -1 TipoID, TipoIngresoEgreso Tipo FROM Cuenta_Ingresos_Egresos WHERE Estado=1 " +
                        "AND TipoIngresoEgreso='" + Variable + "' ORDER BY Nombre";
                else if (Opcion == "Banco")
                    Consulta = "SELECT ca.CajaID ID, ca.NomCaja Nombre, ca.TipoCajaID TipoID, tip.NomTipo Tipo FROM Caja ca INNER JOIN Tipo_Sistema_Fijo tip ON ca.TipoCajaID=tip.TipoID WHERE tip.TipoID IN(31, 33)";

                DatosDT = DListarPersonalizado.ConsultarDT(Consulta);
                dgvDatos.DataSource = DatosDT;
                NombreColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos
        
        private void FiltrarTipo()
        {
            if (DatosDT != null)
                //if (cboTipoCli.Text != string.Empty)
                    DatosDT.DefaultView.RowFilter = "Nombre LIKE '%" + txtBuscador.Text.Trim() + "%'" +
                        (chkTipo.Checked ? " AND TipoID=" + cboTipoCli.SelectedValue : "");
        }
        
        #endregion

        #region Eventos Formulario

        private void BusqCliente_Load(object sender, EventArgs e)
        {
            chkTipo.Text = "Tipo " + Opcion + ":";
            lblNomBuscador.Text = Opcion + ":";

            ListarTipo();
            Listar_Datos();
            Cargado = true;
            txtBuscador.Focus();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            FiltrarTipo();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Seleccionado = true;
                this.Close();
            }
        }

        private void dgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Seleccionado = true;
                this.Close();
            }
        }

        private void Buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboTipoCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkTipo.Checked && Cargado)
                FiltrarTipo();
        }

        private void chkTipo_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoCli.Enabled = chkTipo.Checked;

            if (chkTipo.Checked)
                FiltrarTipo();
        }
        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Seleccionado = true;
                this.Close();
            }
        }

        #endregion
    }
}

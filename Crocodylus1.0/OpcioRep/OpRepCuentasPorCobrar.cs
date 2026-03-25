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
    public partial class OpRepCuentasPorCobrar : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OVenta> LVenProd = null;

        public OpRepCuentasPorCobrar()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void CargarNombreDeudas()
        {
            dgvDeudas.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "CodVenta";
            c0.Visible = false;
            dgvDeudas.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 50;
            c1.Name = "Num. Nota";
            c1.ReadOnly = true;
            c1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDeudas.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 150;
            c2.Name = "Referencia";
            c2.ReadOnly = true;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDeudas.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 90;
            c3.Name = "Fecha";
            c3.ReadOnly = true;
            c3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDeudas.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Width = 120;
            c4.Name = "Almacen";
            c4.ReadOnly = true;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDeudas.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Width = 80;
            c5.Name = "Total";
            c5.ReadOnly = true;
            c5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDeudas.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Width = 60;
            c6.Name = "Dscto.";
            c6.ReadOnly = true;
            c6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDeudas.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Width = 80;
            c7.Name = "Total Pagado";
            c7.ReadOnly = true;
            c7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDeudas.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Width = 80;
            c8.Name = "Total Dev.";
            c8.ReadOnly = true;
            c8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDeudas.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Width = 80;
            c9.Name = "Saldo";
            c9.ReadOnly = true;
            c9.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDeudas.Columns.Add(c9);
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarSuc()
        {
            try
            {
                List<OSucursal> LSuc = NSucursal.NListarSucursales().OrderBy(x => x.NomSuc).ToList();

                cboSuc.DataSource = LSuc;
                cboSuc.DisplayMember = "NomSuc";
                cboSuc.ValueMember = "SucursalID";
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
                List<OCliente> LCli = NCliente.NListarClientes(-1).OrderBy(x => x.NomClien).ToList();

                cboCli.DataSource = LCli;
                cboCli.DisplayMember = "NomClien";
                cboCli.ValueMember = "ClienteID";
                cboCli.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarDeudasCli()
        {
            try
            {
                int cli = -1;
                int suc = -1;

                if (cboRepPor.Text == "Cliente")
                    cli = Convert.ToInt32(cboCli.SelectedValue);

                if (cboRepEn.Text == "Sucursal")
                    suc = Convert.ToInt32(cboSuc.SelectedValue);

                //verificamos la diferencia de fechas
                TimeSpan ts = DateTime.Now - dtFecha.Value;
                int difdias = ts.Days;
                if (difdias == 0)
                {
                    LVenProd = NVenta.NBuscarDeudasCli(cli, suc, "Credito"); //solo de ventas al credito
                    CargarDeudasCli(LVenProd);
                }
                //else
                //{
                //    LKCli = NKardexCli.NBuscarDeudasCliFecha(cli, suc, "Credito"); //por fecha

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarDeudasCli(List<OVenta> lvenprod)
        {
            if (lvenprod != null)
            {
                CargarNombreDeudas();

                //totales
                decimal total = 0;
                decimal dscto = 0;
                decimal pagado = 0;
                decimal devol = 0;
                decimal saldo = 0;

                foreach (var item in lvenprod)
                {
                    //dgvDeudas.Rows.Add(item.CodVenta, item.NumVenta, item.Referencia, item.Fecha.ToShortDateString(), item.NomAlmacen, 
                    //                   string.Format("{0:#,##0.00}", item.MontoBs), string.Format("{0:#,##0.00}", item.TotalDsctoBs), 
                    //                   string.Format("{0:#,##0.00}", item.TotalPagadoBs), string.Format("{0:#,##0.00}", item.TotalDevolMatBs), 
                    //                   string.Format("{0:#,##0.00}", item.TotalSaldoBs));

                    //total += item.MontoBs;
                    //dscto += item.TotalDsctoBs;
                    //pagado += item.TotalPagadoBs;
                    //devol += item.TotalDevolMatBs;
                    //saldo += item.TotalSaldoBs;
                }

                //cargamos totales
                txtTot.Text = string.Format("{0:#,##0.00}", total);
                txtTotDscto.Text = string.Format("{0:#,##0.00}", dscto);
                txtTotPag.Text = string.Format("{0:#,##0.00}", pagado);
                txtTotDevol.Text = string.Format("{0:#,##0.00}", devol);
                txtTotSal.Text = string.Format("{0:#,##0.00}", saldo);
            }
            else
            {
                CargarNombreDeudas();
            }
        }

        private void BuscarDeudasCli()
        {
            if(LVenProd != null)
            {
                if(txtBuscar.Text != string.Empty)
                {
                    //List<OVenta> LBusqVenProd = LVenProd.FindAll(x => x.NumVenta.Contains(txtBuscar.Text));
                    //CargarDeudasCli(LBusqVenProd);
                }
                else
                {
                    CargarDeudasCli(LVenProd);
                }
            }
        }

        #endregion

        #region Funciones

        private void Imp()
        {

        }

        private void Registro()
        {

        }

        #endregion

        #region Eventos Formulario

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ListarDeudasCli();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboRepPor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboRepPor.Text == "Totales")
                cboCli.Enabled = false;
            else
                cboCli.Enabled = true;
        }

        private void OpRepCuentasPorCobrar_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarCli();
            ListarSuc();
            
            cboRepPor.Text = "Totales";
            cboRepEn.Text = "Empresa";
            cboOrdenado.Text = "Saldo por Cobrar";
            dtFecha.MaxDate = DateTime.Now;
            CargarNombreDeudas();

            op.CerrarCargando();
        }

        private void cboRepEn_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboRepEn.Text == "Empresa")
                cboSuc.Enabled = false;
            else
                cboSuc.Enabled = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarDeudasCli();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Imp();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void OpRepCuentasPorCobrar_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #endregion
    }
}

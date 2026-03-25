using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Objetos;

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepListaClientes : Form
    {
        List<OCliente> LCli = null;
        List<OCliente> LCliSelec = null;

        string selec = "Todos";

        public OpRepListaClientes(List<OCliente> lcli)
        {
            InitializeComponent();

            LCli = lcli;
        }

        private void CargarNombreColumnas()
        {
            dgvClientes.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 60;
            c1.ReadOnly = true;
            dgvClientes.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Cliente";
            c2.Width = 250;
            c2.ReadOnly = true;
            dgvClientes.Columns.Add(c2);

            DataGridViewCheckBoxColumn c3 = new DataGridViewCheckBoxColumn();
            c3.Name = "Impr.";
            c3.Width = 40;
            dgvClientes.Columns.Add(c3);
        }

        private void Imprimir()
        {
            if(selec == "Todos")
            {
                Reportes.RepListaClien rcli = new Reportes.RepListaClien(LCli, "LISTA GENERAL DE CLIENTES");
                rcli.Owner = this;
                rcli.Show();
            }
            else
            {
                Reportes.RepListaClien rcli = new Reportes.RepListaClien(LCliSelec, "LISTA DE CLIENTES " + selec);
                rcli.Owner = this;
                rcli.Show();
            }
        }

        private void ListarClientes(List<OCliente> lcli)
        {
            try
            {
                CargarNombreColumnas();

                int cont = 0;
                foreach (var item in lcli)
                {
                    dgvClientes.Rows.Add(item.ClienteID, item.NomClien, 1);
                    if (!item.Estado)
                        dgvClientes.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    
                    cont++;
                }
            }
            catch (Exception)
            {
                CargarNombreColumnas();
            }

        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if(LCli != null)
            {
                LCliSelec = LCli.FindAll(x => !x.Estado).ToList();
                ListarClientes(LCliSelec);
                selec = "ANULADOS";
            }
        }

        private void btnHabil_Click(object sender, EventArgs e)
        {
            if (LCli != null)
            {
                LCliSelec = LCli.FindAll(x => x.Estado).ToList();
                ListarClientes(LCliSelec);
                selec = "HABILITADOS";
            }
        }

        private void OpRepListaClientes_Load(object sender, EventArgs e)
        {
            ListarClientes(LCli);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            ListarClientes(LCli);
            selec = "Todos";
        }

    }
}

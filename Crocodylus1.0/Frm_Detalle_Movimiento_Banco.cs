using Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Detalle_Movimiento_Banco : Form
    {
        public static Frm_Detalle_Movimiento_Banco frmmovbanco = null;

        private DataTable KardexMovBancoDT = null;

        public Frm_Detalle_Movimiento_Banco()
        {
            InitializeComponent();
        }

        private void btnBusqBanco_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bbanco = new Buscadores.Buscador();
            bbanco.Owner = this;
            bbanco.Opcion = "Banco";
            bbanco.ShowDialog();

            if (bbanco.Seleccionado)
            {
                txtID.Text = bbanco.dgvDatos["ID", bbanco.dgvDatos.CurrentRow.Index].Value.ToString();
                txtNombre.Text = bbanco.dgvDatos["Nombre", bbanco.dgvDatos.CurrentRow.Index].Value.ToString();
            }

            bbanco.Dispose();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            decimal saldo = 0, entrada = 0, salida = 0;
            try
            {
                KardexMovBancoDT = DListarPersonalizado.ConsultarDT("SELECT BancoID, NomBanco, CodAbono, NumAbono, Fecha, Tipo, Ingreso, Salida, 0 Saldo " +
                    "FROM Vista_KardexBanco WHERE BancoID=" + txtID.Text + " ORDER BY Fecha");
                dgvKardexBanco.DataSource = KardexMovBancoDT;

                foreach (DataRow item in KardexMovBancoDT.Rows)
                {
                    entrada += (decimal)item["Ingreso"];
                    salida += (decimal)item["Salida"];
                    saldo += (decimal)item["Ingreso"] - (decimal)item["Salida"];
                    item["Saldo"] = saldo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtTotEntrada.Text = string.Format("{0:#,##0.00}", entrada);
                txtTotSalida.Text = string.Format("{0:#,##0.00}", salida);
                txtTotSaldo.Text = string.Format("{0:#,##0.00}", saldo);
            }
        }

        private void Frm_Movimiento_Banco_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmovbanco.Dispose();
            frmmovbanco = null;
        }

        private void btnNuevoReg_Click(object sender, EventArgs e)
        {
            Frm_Movimiento_Banco frmmov = new Frm_Movimiento_Banco();
            frmmov.Owner = this;

            if (txtNombre.Text != string.Empty)
            {
                frmmov.BancoId = Convert.ToInt32(txtID.Text);
                frmmov.NomBanco = txtNombre.Text;
            }

            frmmov.ShowDialog();

            if (frmmov.Guardado)
                btnProc.PerformClick();

            frmmov.Dispose();
        }

    }
}

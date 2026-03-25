using System;
using System.Data;
using System.Windows.Forms;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrUsuFactura : UserControl
    {
        public int FacturaID;

        public CntrUsuFactura()
        {
            InitializeComponent();
        }

        public void Borrar_Factura()
        {
            FacturaID = -1;
            txtNroFact.Clear();
            txtAutorizacion.Clear();
            txtCodControl.Clear();
            txtNIT.Clear();
            txtRazonSocial.Clear();
            txtExcentos.Text = "0.00";
            txtICE.Text = "0.00";
            txtMontoFact.Text = "0.00";
            dtFechaFact.Value = DateTime.Now;
        }

        public bool Verificar_Factura()
        {
            double valor = 0;

            if (string.IsNullOrWhiteSpace(txtAutorizacion.Text))
            {
                MessageBox.Show("INGRESE EL NÚMERO DE AUTORIZACIÓN", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAutorizacion.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtNroFact.Text))
            {
                MessageBox.Show("INGRESE EL NÚMERO DE LA FACTURA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNroFact.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtNIT.Text))
            {
                MessageBox.Show("INGRESE EL NIT", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNIT.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("INGRESE LA RAZÓN SOCIAL", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRazonSocial.Focus();
                return false;
            }
            else if (!double.TryParse(txtNIT.Text, out valor))
            {
                MessageBox.Show("INGRESE UN VALOR CORRECTO PARA EL NIT", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNIT.Focus();
                return false;
            }
            else if (!double.TryParse(txtMontoFact.Text, out valor))
            {
                MessageBox.Show("INGRESE UN MONTO VÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMontoFact.Focus();
                return false;
            }
            else if (valor <= 0)
            {
                MessageBox.Show("EL MONTO TIENE QUE SER MAYOR A CERO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMontoFact.Focus();
                return false;
            }
            
            return true;
        }

        public DataTable FacturaDT(bool selec)
        {
            DataRow fila;
            DataTable factdt = new DataTable();
            factdt.Columns.Add("FacturaID");
            factdt.Columns.Add("Numero");
            factdt.Columns.Add("Fecha");
            factdt.Columns.Add("RazonSocial");
            factdt.Columns.Add("NIT");
            factdt.Columns.Add("Codigo_Control");
            factdt.Columns.Add("Descripcion");
            factdt.Columns.Add("Monto");
            factdt.Columns.Add("Dscto");
            factdt.Columns.Add("IVA");
            factdt.Columns.Add("ICE");
            factdt.Columns.Add("Exentos");
            factdt.Columns.Add("Total");
            factdt.Columns.Add("SucursalID");
            factdt.Columns.Add("Autorizacion");
            factdt.Columns.Add("ActividadID");
            factdt.Columns.Add("DosificacionID");
            factdt.Columns.Add("Estado");

            if (selec)
            {
                fila = factdt.NewRow();
                fila["FacturaID"] = -1;
                fila["Numero"] = Convert.ToInt32(txtNroFact.Text);
                fila["Fecha"] = dtFechaFact.Value;
                fila["RazonSocial"] = txtRazonSocial.Text;
                fila["NIT"] = Convert.ToDouble(txtNIT.Text);
                fila["Codigo_Control"] = txtCodControl.Text.Trim();
                fila["Monto"] = Convert.ToDecimal(txtMontoFact.Text);
                fila["Dscto"] = 0;
                fila["ICE"] = Convert.ToDecimal(txtICE.Text);
                fila["Exentos"] = Convert.ToDecimal(txtExcentos.Text);
                fila["Total"] = Convert.ToDecimal(fila["Monto"]) - Convert.ToDecimal(fila["ICE"]) + Convert.ToDecimal(fila["Exentos"]);
                fila["Autorizacion"] = Convert.ToDouble(txtAutorizacion.Text);
                fila["Estado"] = true;
                factdt.Rows.Add(fila);
            }

            return factdt;
        }

        private void txtEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}

using Objetos;
using Datos;
using System;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Factura_Manual : Form
    {
        public string CodNota = string.Empty;
        public string Tupla = string.Empty;
        public decimal Monto = 0;
        public bool Guardado = false;
        ControlUsuario.CntrUsuFactura cufact = null;

        public Frm_Factura_Manual(int _facutraid)
        {
            InitializeComponent();

            cufact = new ControlUsuario.CntrUsuFactura();
            cufact.FacturaID = _facutraid;
            panelFactura.Controls.Add(cufact);            
        }

        private void InsertModifFactura()
        {
            if (!cufact.Verificar_Factura())
                return;

            try
            {
                string DetInmode = string.Empty;
                OFactura fact = new OFactura();
                fact.FacturaID = cufact.FacturaID;
                fact.Numero = int.Parse(cufact.txtNroFact.Text);
                fact.NIT = double.Parse(cufact.txtNIT.Text);
                fact.RazonSocial = cufact.txtRazonSocial.Text.Trim();
                fact.Autorizacion = double.Parse(cufact.txtAutorizacion.Text);
                fact.Codigo_Control = cufact.txtCodControl.Text.Trim();
                fact.CodNota = CodNota;
                fact.Tupla = Tupla;
                fact.Dscto = 0;
                fact.Exentos = decimal.Parse(cufact.txtExcentos.Text);
                fact.Fecha = cufact.dtFechaFact.Value;
                fact.ICE = decimal.Parse(cufact.txtICE.Text);
                fact.Monto = decimal.Parse(cufact.txtMontoFact.Text);
                fact.SucursalID = 1;

                if (cufact.FacturaID != -1)
                {
                    Frm_DetaModifAnul dmodif = new Frm_DetaModifAnul("MODIFICAR");
                    dmodif.ShowDialog();
                    if (dmodif.Cancelado)
                    {
                        dmodif.Dispose();
                        throw new Exception("CANCELADO POR EL USUARIO");
                    }
                    else
                        DetInmode = dmodif.DetaModAnul();

                    dmodif.Dispose();
                }

                btnGuardar.Enabled = false;

                if (DFactura.InsertModifFactura(fact, OInmode.DTInmode("", (cufact.FacturaID != -1 ? "NUEVO" : "MODIFICAR"), DetInmode)))
                {
                    Guardado = true;
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifFactura();
        }

        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            if (Monto > 0)
            {
                cufact.txtMontoFact.Text = string.Format("{0:#,##0.00}", Monto);
                cufact.txtMontoFact.ReadOnly = true;
            }
        }

    }
}

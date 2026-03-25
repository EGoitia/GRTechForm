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
    public partial class OpRepNotasVentasXCantidad : Form
    {
        List<OVenta> LVen = null;
        List<ODetalleVenta> LDVen = null;

        public OpRepNotasVentasXCantidad()
        {
            InitializeComponent();
        }

        private void ListarSuc()
        {
            try
            {
                cboSuc.DataSource = NSucursal.NListarSucursales();
                cboSuc.ValueMember = "SucursalID";
                cboSuc.DisplayMember = "NomSuc";
                cboSuc.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            
        }

        private void OpRepNotasVentasXCantidad_Load(object sender, EventArgs e)
        {
            ListarSuc();
        }
    }
}

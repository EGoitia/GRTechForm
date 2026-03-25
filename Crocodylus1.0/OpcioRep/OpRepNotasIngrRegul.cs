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
    public partial class OpRepNotasIngrRegul : Form
    {
        OpcionFormularios op=new OpcionFormularios();

        List<OIngSalProducto> LIngSalProd = null;
        List<ODetalleIngSalProducto> LDIngSalProd = null;

        public OpRepNotasIngrRegul(string codcompraprod)
        {
            InitializeComponent();

            ListarNotasIngRegul(codcompraprod);
        }

        private void ListarNotasIngRegul(string codcompraprod)
        {
            try
            {
                LIngSalProd = NIngSalProducto.NBuscarNotasIngRegul(codcompraprod);
                dgvNotas.DataSource = LIngSalProd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeleccionarNota(DataGridViewCellEventArgs e)
        {
            try
            {
                LDIngSalProd = NDetalleIngSalProducto.NBuscarDIngSalProd(dgvNotas["CodIngSalProd", e.RowIndex].Value.ToString());
                dgvDetalle.DataSource = LDIngSalProd;
            }
            catch (Exception)
            {
                dgvDetalle.DataSource = null;
            }
        }

        private void dgvNotas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarNota(e);
        }
    }
}

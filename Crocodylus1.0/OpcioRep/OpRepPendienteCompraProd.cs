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
    public partial class OpRepPendienteCompraProd : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<ODetalleCompraProd> LDComProd = null;

        string CodCompraProd = string.Empty;

        public OpRepPendienteCompraProd(string codcompraprod)
        {
            InitializeComponent();

            CodCompraProd = codcompraprod;
        }

        #region Conf Formulario

        private void NombreColumnasDetalle()
        {
            dgvDetCompra.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Cod. Item";
            c1.Width = 60;
            dgvDetCompra.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Descripcion";
            c2.Width = 200;
            dgvDetCompra.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Cant. Total";
            c3.Width = 90;
            dgvDetCompra.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Cant. Pendiente";
            c4.Width = 90;
            dgvDetCompra.Columns.Add(c4);
        }

        #endregion

        #region Conexion Capa Negocio

        private void BuscarDetCompraProd()
        {
            decimal cant = 0;
            decimal tran = 0;

            try
            {
                LDComProd = NDetalleCompraProd.NBuscarDCompraProd(CodCompraProd);

                NombreColumnasDetalle();

                foreach (var item in LDComProd)
                {
                    dgvDetCompra.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad),
                                          string.Format("{0:#,##0.00}", item.CantidadRegul));

                    cant += item.Cantidad;
                    tran += item.CantidadRegul;
                }
                dgvDetCompra.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                NombreColumnasDetalle();
            }
            finally
            {
                txtTotCantidad.Text = string.Format("{0:#,##0.00}", cant);
                txtTotTransito.Text = string.Format("{0:#,##0.00}", tran);
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepPendienteCompraProd_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            BuscarDetCompraProd();

            op.CerrarCargando();
        }

        #endregion

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            BuscarDetCompraProd();

            op.CerrarCargando();
        }
    }
}

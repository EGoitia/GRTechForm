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
    public partial class OpRepVerProdNotas : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<ODetalleVenta> LDVen = null;
        List<ODetalleCompraProd> LDCom = null;
        List<ODetalleIngSalProducto> LDIngSal = null;
        List<ODetalleTraspaso> LDTrasp = null;

        string CodNota = string.Empty;
        string Opcion = string.Empty;

        public OpRepVerProdNotas(string codnota, string opcion)
        {
            InitializeComponent();

            CodNota = codnota;
            Opcion = opcion;
        }

        #region Configuracion formulario

        private void CargarNombresProducto()
        {
            GridDetalle.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Cod Item";
            c1.Width = 60;
            c1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridDetalle.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Nombre Item";
            c2.Width = 200;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            GridDetalle.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Cantidad";
            c3.Width = 60;
            c3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridDetalle.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "P. Unitario";
            c4.Width = 60;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridDetalle.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Importe";
            c5.Width = 60;
            c5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GridDetalle.Columns.Add(c5);
        }

        #endregion

        #region Conexion Capa de Negocios

        private void BuscarDetVenta()
        {
            try
            {
                LDVen = NDetalleVenta.NBuscarDVen(CodNota);
                CargarDetVenta(LDVen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarNombresProducto();
            }
        }

        private void BuscarDetTrasp()
        {
            try
            {
                LDTrasp = NDetalleTraspaso.NBuscarTraspaso(CodNota);
                CargarDetTraso(LDTrasp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarNombresProducto();
            }
        }

        private void BuscarDetIngsalProd()
        {
            try
            {
                LDIngSal = NDetalleIngSalProducto.NBuscarDIngSalProd(CodNota);
                CargarDetIngSal(LDIngSal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarNombresProducto();
            }
        }

        private void BuscarDetCompra()
        {
            try
            {
                LDCom = NDetalleCompraProd.NBuscarDCompraProd(CodNota);
                CargarDetCompra(LDCom);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarNombresProducto();
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarDetVenta(List<ODetalleVenta> ldven)
        {
            if(ldven != null)
            {
                CargarNombresProducto();

                decimal totimp = 0;
                foreach (var item in ldven)
                {
                    GridDetalle.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad),
                                         string.Format("{0:#,##0.00}", item.PUnitario), string.Format("{0:#,##0.00}", item.PTotal));

                    totimp += item.PTotal;
                }
                GridDetalle.Refresh();

                txtImporte.Text = string.Format("{0:#,##0.00}", totimp);
            }
            else
            {
                CargarNombresProducto();
            }
        }

        private void CargarDetCompra(List<ODetalleCompraProd> ldcom)
        {
            if (ldcom != null)
            {
                CargarNombresProducto();

                decimal totimp = 0;
                foreach (var item in ldcom)
                {
                    GridDetalle.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad),
                                         string.Format("{0:#,##0.00}", item.PUnitario), string.Format("{0:#,##0.00}", item.PTotal));

                    totimp += item.PTotal;
                }
                GridDetalle.Refresh();

                txtImporte.Text= string.Format("{0:#,##0.00}", totimp);
            }
            else
            {
                CargarNombresProducto();
            }
        }

        private void CargarDetIngSal(List<ODetalleIngSalProducto> ldingsal)
        {
            if (ldingsal != null)
            {
                CargarNombresProducto();

                decimal totimp = 0;
                foreach (var item in ldingsal)
                {
                    GridDetalle.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad),
                                         string.Format("{0:#,##0.00}", item.PUnitario), string.Format("{0:#,##0.00}", item.PTotal));

                    totimp += item.PTotal;
                }
                GridDetalle.Refresh();

                txtImporte.Text = string.Format("{0:#,##0.00}", totimp);
            }
            else
            {
                CargarNombresProducto();
            }
        }

        private void CargarDetTraso(List<ODetalleTraspaso> ldtrasp)
        {
            if (ldtrasp != null)
            {
                CargarNombresProducto();

                decimal totimp = 0;
                foreach (var item in ldtrasp)
                {
                    GridDetalle.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad),
                                         string.Format("{0:#,##0.00}", item.Peso), string.Format("{0:#,##0.00}", item.Peso * item.Cantidad));

                    totimp += (item.Peso * item.Cantidad);
                }
                GridDetalle.Refresh();

                txtImporte.Text = string.Format("{0:#,##0.00}", totimp);
            }
            else
            {
                CargarNombresProducto();
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepVerProdNotas_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            switch(Opcion)
            {
                case "Venta":
                    BuscarDetVenta();
                    break;
                case "Compra":
                    BuscarDetCompra();
                    break;
                case "IngSal":
                    BuscarDetIngsalProd();
                    break;
                case "Traspaso":
                    BuscarDetTrasp();
                    break;
            }

            op.CerrarCargando();
        }

        #endregion
    }
}

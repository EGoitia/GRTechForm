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
    public partial class OpRepValorConformidad : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<ODetalleConformidad> LDConf = null;
        OValorConformidad VConf = null;
        string CodConformidad = string.Empty;
        
        public OpRepValorConformidad(List<ODetalleConformidad> ldconf, string codconformidad, string nomchofer, string valor)
        {
            InitializeComponent();

            LDConf = ldconf;
            CodConformidad = codconformidad;

            txtChofer.Text = nomchofer;
            txtValor.Text = valor;
        }

        #region Configuracion formulario

        private void NombreColumnas()
        {
            dgvValorConf.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Cod. item";
            c1.Width = 60;
            dgvValorConf.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Descripcion";
            c2.Width = 250;
            dgvValorConf.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Cantidad";
            c3.Width = 90;
            dgvValorConf.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Unid. Med.";
            c4.Width = 60;
            dgvValorConf.Columns.Add(c4);
        }

        #endregion

        #region Conexion Capa Negocio

        private void BuscarValorConf()
        {
            try
            {
                VConf = NConformidad.NValorConformidad(CodConformidad);

                txtComMtr.Text = string.Format("{0:#,##0.00}", VConf.ComxMetro);
                txtComPza.Text = string.Format("{0:#,##0.00}", VConf.ComxPza);
                txtComBolsa.Text = string.Format("{0:#,##0.00}", VConf.ComxBolsa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region CargarDatos

        private void CargarDetalle()
        {
            decimal valmtr = 0;
            decimal valbolsa = 0;
            decimal valpza = 0;
            decimal valtot = 0;

            decimal totmtr = 0;
            decimal totbolsa = 0;
            decimal totpza = 0;

            try
            {
                NombreColumnas();

                foreach (var item in LDConf)
                {
                    dgvValorConf.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad), item.UnidMedida);

                    if (item.UnidMedida.Trim() == "Mtr.")
                    {
                        totmtr += item.Cantidad;
                        valmtr += item.Cantidad * Convert.ToDecimal(txtComMtr.Text);
                    }
                    else if (item.UnidMedida.Trim() == "Bolsa")
                    {
                        totbolsa += item.Cantidad;
                        valbolsa += item.Cantidad * Convert.ToDecimal(txtComBolsa.Text);
                    }
                    else
                    {
                        totpza += item.Cantidad;
                        valpza += item.Cantidad * Convert.ToDecimal(txtComPza.Text);
                    }
                        
                }

                valtot = (valmtr + valmtr + valpza) * Convert.ToDecimal(txtValor.Text);
            }
            catch (Exception)
            {
                NombreColumnas();
            }
            finally
            {
                txtTotMtr.Text = string.Format("{0:#,##0.00}", totmtr);
                txtTotBolsa.Text = string.Format("{0:#,##0.00}", totbolsa);
                txtTotPza.Text = string.Format("{0:#,##0.00}", totpza);

                txtComMtr.Text = string.Format("{0:#,##0.00}", valmtr);
                txtComBolsa.Text = string.Format("{0:#,##0.00}", valmtr);
                txtComPza.Text = string.Format("{0:#,##0.00}", valpza);

                txtBsTotal.Text = string.Format("{0:#,##0.00}", valtot);
            }
        }

        #endregion

        #region Eventos Formulario

        private void ValorConformidad_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            BuscarValorConf();
            CargarDetalle();

            op.CerrarCargando();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            BuscarValorConf();
            CargarDetalle();

            op.CerrarCargando();
        }

        #endregion
    }
}

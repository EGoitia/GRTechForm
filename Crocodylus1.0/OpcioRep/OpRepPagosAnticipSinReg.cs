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
    public partial class OpRepPagosAnticipSinReg : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OVenta> LVen = null;
        OVenta OVen = null;

        public OpRepPagosAnticipSinReg()
        {
            InitializeComponent();
        }

        #region Config. Formulario

        private void NombreColumnas()
        {
            dgvPagAnticSinReg.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "CodVenta";
            c1.Visible = false;
            dgvPagAnticSinReg.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Num. Nota";
            c2.Width = 90;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPagAnticSinReg.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 100;
            dgvPagAnticSinReg.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Referencia";
            c4.Width = 150;
            dgvPagAnticSinReg.Columns.Add(c4);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Monto Bs.-";
            c6.Width = 80;
            c6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPagAnticSinReg.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Total Dscto.";
            c7.Width = 80;
            c7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPagAnticSinReg.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Total Pagado";
            c8.Width = 80;
            c8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPagAnticSinReg.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "Total Saldo";
            c9.Width = 80;
            c9.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPagAnticSinReg.Columns.Add(c9);
        }

        #endregion

        #region Conexion Capa de Negocio

        private void ListarPagAntiSinReg()
        {
            try
            {
                //LVen = NVenta.NListarPagosAnticipSinRegul(OConexionGlobal.SucursalID).Where(x => x.Estado).ToList();
                CargarPagAntiSinReg(LVen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                NombreColumnas();
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarPagAntiSinReg(List<OVenta> lven)
        {
            if (lven != null)
            {
                NombreColumnas();

                foreach (var item in lven)
                {
                    //dgvPagAnticSinReg.Rows.Add(item.CodVenta, item.NumVenta, item.Fecha, item.Referencia, string.Format("{0:#,##0.00}", item.MontoBs),
                    //                           string.Format("{0:#,##0.00}", item.TotalDsctoBs), string.Format("{0:#,##0.00}", item.TotalPagadoBs),
                    //                           string.Format("{0:#,##0.00}", item.TotalSaldoBs));
                }
            }
            else
                NombreColumnas();
        }

        private void BuscarNota()
        {
            try
            {
                if (txtBuscador.Text != string.Empty)
                {
                    List<OVenta> lbusqven = new List<OVenta>();

                    //if (rbNumNota.Checked)
                    //    //lbusqven = LVen.FindAll(x => x.NumVenta.Contains(txtBuscador.Text));
                    //else
                    //    lbusqven = LVen.FindAll(x => x.Referencia.ToUpper().Contains(txtBuscador.Text.ToUpper()));

                    CargarPagAntiSinReg(lbusqven);
                }
                else
                    CargarPagAntiSinReg(LVen);
            }
            catch (Exception)
            {  }
        }

        private void SeleccionarNota(DataGridViewCellEventArgs e)
        {
            try
            {
                OVen = LVen.Find(x => x.CodVenta == dgvPagAnticSinReg["CodVenta", e.RowIndex].Value.ToString());
            }
            catch (Exception)
            {   }
        }

        #endregion

        #region Funciones

        private void ImpNota()
        {
            try
            {
                //List<ODetalleVenta> LDVen = NDetalleVenta.NBuscarDVen(OVen.CodVenta);

                //Reportes.RepNotasVenta rven = new Reportes.RepNotasVenta(OVen, LDVen);
                //rven.Show();
            }
            catch (Exception)
            { }
        }

        private void ImpLista()
        {
            if(LVen != null)
            {
                Reportes.RepPagAnticipSinRegul pasinreg = new Reportes.RepPagAnticipSinRegul(LVen);
                pasinreg.Show();
            }
        }

        #endregion

        #region Eventos Formulario

        private void OpRepPagosAnticipSinReg_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarPagAntiSinReg();

            op.CerrarCargando();
        }

        private void OpRepPagosAnticipSinReg_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarNota();
        }

        private void btnVerItems_Click(object sender, EventArgs e)
        {
            if (dgvPagAnticSinReg.Rows.Count > 1)
            {
                OpcioRep.OpRepVerProdNotas verprod = new OpRepVerProdNotas(dgvPagAnticSinReg["CodVenta", dgvPagAnticSinReg.CurrentRow.Index].Value.ToString(), "Venta");
                verprod.Owner = this;
                verprod.ShowDialog();
            }
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            ImpNota();
        }

        private void btnImpLista_Click(object sender, EventArgs e)
        {
            ImpLista();
        }

        private void dgvPagAnticSinReg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarNota(e);
        }

        #endregion
    }
}

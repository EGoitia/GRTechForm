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

namespace GRTechnology1._0.Buscadores
{
    public partial class BusqDetallePagos : Form
    {
        string Codigo = string.Empty;
        string Opcion = string.Empty;

        public BusqDetallePagos(string codigo, string opcion)
        {
            InitializeComponent();

            Codigo = codigo;
            Opcion = opcion;
        }

        private void BusqDetallePagos_Load(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void CargarPagos()
        {
            try
            {
                CargarNombres();

                decimal pag = 0;
                decimal abon = 0;
                decimal devol = 0;
                decimal dscto = 0;

                if (Opcion == "Cliente")
                {
                    //LKCli = NKardexCli.NBuscarPagosCli(Codigo);

                    //foreach (var item in LKCli)
                    //{
                    //    dgvDetalle.Rows.Add(item.Fecha, item.TipoDoc, item.NroNota, string.Format("{0:#,##0.00}", item.PagadoBs),
                    //                        string.Format("{0:#,##0.00}", item.AbonoBs), string.Format("{0:#,##0.00}", item.DevueltoBs),
                    //                        string.Format("{0:#,##0.00}", item.DsctoBs));

                    //    pag += item.PagadoBs;
                    //    abon += item.AbonoBs;
                    //    dscto += item.DsctoBs;
                    //}
                }
                else if (Opcion == "Proveedor")
                {
                    //LKProv = NKardexProv.NBuscarPagosProv(Codigo);

                    //foreach (var item in LKProv)
                    //{
                    //    dgvDetalle.Rows.Add(item.Fecha, item.TipoDoc, item.NroNota, string.Format("{0:#,##0.00}", item.PagadoBs),
                    //                        string.Format("{0:#,##0.00}", item.AbonoBs), "", string.Format("{0:#,##0.00}", item.DsctoBs));

                    //    pag += item.PagadoBs;
                    //    abon += item.AbonoBs;
                    //    dscto += item.DsctoBs;
                    //}
                }
                else if(Opcion == "Personal")
                {
                    //LKPer = NKardexPer.NBuscarPagosPer(Codigo);

                    //foreach (var item in LKPer)
                    //{
                    //    dgvDetalle.Rows.Add(item.Fecha, item.TipoDoc, item.NroNota, string.Format("{0:#,##0.00}", item.TotMontoBs),
                    //                        string.Format("{0:#,##0.00}", item.AbonoBs), "", string.Format("{0:#,##0.00}", item.DsctoBs));

                    //    pag += item.TotMontoBs;
                    //    abon += item.DsctoBs;
                    //    dscto += 0;
                    //}
                }


                txtAbono.Text = string.Format("{0:#,##0.00}", abon);
                txtPag.Text = string.Format("{0:#,##0.00}", pag);
                txtDscto.Text = string.Format("{0:#,##0.00}", dscto);
                txtTotSuma.Text = string.Format("{0:#,##0.00}", (pag + abon + dscto));
            }
            catch
            {
                CargarNombres();
            }
        }

        private void CargarNombres()
        {
            dgvDetalle.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "Fecha";
            c0.Width = 120;
            c0.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetalle.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Tipo";
            c1.Width = 40;
            c1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDetalle.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Nro. Nota";
            c2.Width = 100;
            c2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalle.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Tot. Pago";
            c3.Width = 100;
            c3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Abono";
            c4.Width = 100;
            c4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Devol.";
            c5.Width = 80;
            c5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Dscto.";
            c6.Width = 80;
            c6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns.Add(c6);
        }
    }
}

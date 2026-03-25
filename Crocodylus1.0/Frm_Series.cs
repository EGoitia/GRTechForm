using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Series : Form
    {
        public DataTable ListaProdDT = null;
        public DataTable LotesSeriesDT = new DataTable();
        public bool Cancelado = true;

        public Frm_Series()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            LotesSeriesDT.Columns.Add("ProductoID");
            LotesSeriesDT.Columns.Add("NomProd");
            LotesSeriesDT.Columns.Add("NumLoteSerie");
            LotesSeriesDT.Columns.Add("Cantidad", Type.GetType("System.Decimal"));
            LotesSeriesDT.Columns.Add("Fecha_Elab");
            LotesSeriesDT.Columns.Add("Fecha_Venc");
            LotesSeriesDT.Columns.Add("EsLote");
        }

        private void CargarProductos()
        {
            foreach (DataRow item in ListaProdDT.Rows)
            {
                for (int i = 0; i < Convert.ToInt32(item["Cantidad"]); i++)
                {
                    dgvSeries.Rows.Add(item["ProductoID"], item["NomProd"], item["UnidMedida"], "");
                }
            }
        }

        private void Frm_Series_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void dgvSeries_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvSeries.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepGastosPersonal : Form
    {
        public OpRepGastosPersonal()
        {
            InitializeComponent();
        }

        private void OpRepGastosPersonal_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            string[] series = { "Elias", "Mercedes", "Monica" };
            int[] edades = { 29, 26, 24 };

            //COMBINACION DE COLORES
            chartGastoPer.Palette = ChartColorPalette.BrightPastel;
            //TITULO DEL REPORTE
            chartGastoPer.Titles.Add("GASTO PERSONAL");
            //
            //
            //this.chartGastoPer.Series["Ventas"].ChartType = SeriesChartType.Column;
            //this.chartGastoPer.Series[0].ChartType = SeriesChartType.Doughnut;

            for (int i = 0; i < series.Length; i++)
            {
                chartGastoPer.Series["Series1"].Points.AddXY(series[i], edades[i]);
                //chartGastoPer.Series["Series1"].Label = edades[i].ToString();
                //Series serie = chartGastoPer.Series.Add(series[i]);
                
                //serie.Label = edades[i].ToString();

                //serie.Points.Add(edades[i]);
            }
        }
    }
}

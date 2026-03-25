using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Objetos;
using Microsoft.Reporting.WinForms;

namespace GRTechnology1._0.Reportes
{
    public partial class RepNotasCierreCaja : Form
    {
        OAperturaCaja OApCierreCaj;
        List<ODetalleCierreCaja> LDCieCaj;

        public RepNotasCierreCaja(OAperturaCaja oapcierrecaj, List<ODetalleCierreCaja> ldciecaj)
        {
            InitializeComponent();

            OApCierreCaj = oapcierrecaj;
            LDCieCaj = ldciecaj;
        }

        private void RepNotasCierreCaja_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                //Seleccionamos el zoom que deseamos utilizar. En este caso un 100%
                reportViewer1.ZoomPercent = 130;

                OAperturaCajaBindingSource.DataSource = OApCierreCaj;
                ODetalleCierreCajaBindingSource.DataSource = LDCieCaj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}

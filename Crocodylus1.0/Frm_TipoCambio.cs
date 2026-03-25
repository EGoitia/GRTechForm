using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Objetos;
using Datos;

namespace GRTechnology1._0
{
    public partial class Frm_TipoCambio : Form
    {
        string CodInmode = string.Empty;

        List<OTipoCambio> LTC = null;
        OTipoCambio TC = null;

        public Frm_TipoCambio()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnas()
        {
            dgvTC.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Fecha";
            c1.FillWeight = 100;
            dgvTC.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Compra";
            c2.FillWeight = 60;
            dgvTC.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Venta";
            c3.FillWeight = 60;
            dgvTC.Columns.Add(c3);
        }

        private void HabilitarCont()
        {
            //op.HabilitarCont(gbxBotones, "8.1");
        }

        #endregion

        #region Conexion Capa Datos
     
        private void ListarTC()
        {
            try
            {
                LTC = DTipoCambio.DListarTC(dtFecNota.Value.Month, chkFecha.Checked);
                CargarTC(LTC);
            }
            catch (Exception)
            {
                NombreColumnas();
            }
        }

        private void InsertModifTC(bool nuevo)
        {
            try
            {
                TC = new OTipoCambio();
                TC.Fecha = dtFecha.Value;
                TC.TCCompra = numUpDownCompra.Value;
                TC.TCVenta = numUpDownVenta.Value;

                int resp = DTipoCambio.DInsertModifTC(nuevo, TC, OInmode.DTInmode("", (nuevo ? "NUEVO": "MODIFICAR"), ""));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarTC();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarTC(List<OTipoCambio> ltc)
        {
            if(ltc != null)
            {
                NombreColumnas();

                foreach (var item in ltc)
                {
                    dgvTC.Rows.Add(item.Fecha.ToShortDateString(), string.Format("{0:#,##0.00}", item.TCCompra), string.Format("{0:#,##0.00}", item.TCVenta));
                }
            }
            else
            {
                NombreColumnas();
            }
        }

        private void SeleccionarTC(DataGridViewCellEventArgs e)
        {
            if(LTC != null)
            {
                try
                {
                    if (e.RowIndex > -1)
                    {
                        dtFecha.Text = dgvTC["Fecha", e.RowIndex].Value.ToString();
                        numUpDownCompra.Value = Convert.ToDecimal(dgvTC["Compra", e.RowIndex].Value);
                        numUpDownVenta.Value = Convert.ToDecimal(dgvTC["Venta", e.RowIndex].Value);
                    }
                }
                catch (Exception)
                {     }
            }
        }

        #endregion

        #region Eventos Formulario

        private void TipoCambio_Load(object sender, EventArgs e)
        {
            ListarTC();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifTC(true);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            InsertModifTC(false);
        }

        private void dgvTC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarTC(e);
        }

        private void dtFecNota_ValueChanged(object sender, EventArgs e)
        {
            ListarTC();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Frm_Inmode inm = new Frm_Inmode(CodInmode);
            inm.Owner = this;
            inm.ShowDialog();
        }
        
        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtFecNota.Enabled = chkFecha.Checked;
            ListarTC();
        }

        #endregion
    }
}

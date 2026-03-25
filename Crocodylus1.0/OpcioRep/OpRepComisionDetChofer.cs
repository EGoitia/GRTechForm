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
    public partial class OpRepComisionDetChofer : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OPersonal> LChof = null;
        List<OConformidad> LCon = null;

        public OpRepComisionDetChofer()
        {
            InitializeComponent();
        }

        private void NombreColumnas()
        {
            dgvComChof.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "CodConf";
            c1.Visible = false;
            dgvComChof.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Num. Conf.";
            c2.Width = 60;
            dgvComChof.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha";
            c3.Width = 90;
            dgvComChof.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Sucursal";
            c4.Width = 100;
            dgvComChof.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Destino";
            c5.Width = 150;
            dgvComChof.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Valor";
            c6.Width = 60;
            dgvComChof.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Total Mtr.";
            c7.Width = 70;
            dgvComChof.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Total Bolsa";
            c8.Width = 70;
            dgvComChof.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "Total Pza.";
            c9.Width = 70;
            dgvComChof.Columns.Add(c9);
        }

        private void ListarChofer()
        {
            try
            {
                LChof = NPersonal.NListarPersonales("Chofer", -1);
                cboChofer.DataSource = LChof;
                cboChofer.DisplayMember = "NomPer";
                cboChofer.ValueMember = "PersonalID";
                cboChofer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcesarConChof()
        {
            try
            {
                LCon = NConformidad.NBuscarConfXChofer(Convert.ToInt32(cboChofer.SelectedValue), -1, dtFecIni.Value, dtFecFin.Value);
                CargarConChof();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                NombreColumnas();
            }
        }

        private void CargarConChof()
        {
            if (LCon != null)
            {
                NombreColumnas();

                decimal totmtr = 0;
                decimal totbolsa = 0;
                decimal totpza = 0;

                foreach (var item in LCon)
                {
                    dgvComChof.Rows.Add(item.CodConformidad, item.NumConform, item.Fecha, item.NomSuc, item.NomContTransporte, item.Valor,
                                        string.Format("{0:#,##0.00}", item.Totalm2), string.Format("{0:#,##0.00}", item.TotalBolsa),
                                        string.Format("{0:#,##0.00}", item.TotalPzas));

                    totmtr += (item.Valor * item.Totalm2);
                    totbolsa += (item.Valor * item.TotalBolsa);
                    totpza += (item.Valor * item.TotalPzas);
                }
                dgvComChof.Refresh();

                txtMt.Text = string.Format("{0:#,##0.00}", totmtr);
                txtBl.Text = string.Format("{0:#,##0.00}", totbolsa);
                txtPzas.Text = string.Format("{0:#,##0.00}", totpza);
            }
            else
                NombreColumnas();
        }

        private void Imprimir()
        {
            if(dgvComChof.Rows.Count > 1)
            {
                string fechas = "Del " + dtFecIni.Value.ToShortDateString() + " Al " + dtFecFin.Value.ToShortDateString();
                string nomrep = "COMISION DETALLADA DE CHOFERES";

                Reportes.RepComChofer rcomchof = new Reportes.RepComChofer(LCon, "", fechas, nomrep, cboChofer.Text);
                rcomchof.Show();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ProcesarConChof();
        }

        private void OpRepComisionDetChofer_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            NombreColumnas();
            ListarChofer();

            op.CerrarCargando();
        }

        private void OpRepComisionDetChofer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void cboChofer_SelectedValueChanged(object sender, EventArgs e)
        {
            NombreColumnas();
        }
    }
}

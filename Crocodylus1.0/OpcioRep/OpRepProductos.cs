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
    public partial class OpRepProductos : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<ORubroSubRubro> LRSRub = null;
        
        public OpRepProductos()
        {
            InitializeComponent();
        }

        private void ListarRubroSubRubro(string op)
        {
            try
            {
                List<ORubroSubRubro> lrsrub = null;
                lrsrub = LRSRub.Where(x => x.Tipo == op).OrderBy(x => x.NomRubroSubRubro).ToList();
                cboOpcion.DataSource = lrsrub;
                cboOpcion.DisplayMember = "NomRubroSubRubro";
                cboOpcion.ValueMember = "RubroSubRubroID";
                cboOpcion.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar()
        {
            op.AbrirCargando("Cargando.....");

            LRSRub = NRubroSubRubro.NListarRubroSubRubro();

            op.CerrarCargando();
        }

        private void OpRepProductos_Load(object sender, EventArgs e)
        {
            cboBusqX.Text = "Totales";
            cboOpRep.Text = "Catalogo de Items";
            Cargar();
        }

        private void cboBusqX_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cboBusqX.Text)
            {
                case "SUB-RUBRO":
                    lblOpcion.Text = cboBusqX.Text + "........";
                    lblOpcion.Visible = true;
                    cboOpcion.Visible = true;
                    ListarRubroSubRubro("SubRubro");
                    break;
                case "RUBRO":
                    lblOpcion.Text = cboBusqX.Text + "..............";
                    lblOpcion.Visible = true;
                    cboOpcion.Visible = true;
                    ListarRubroSubRubro("Rubro");
                    break;
                case "TOTALES":
                    lblOpcion.Visible = false;
                    cboOpcion.Visible = false;
                    break;
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            if (!cboOpRep.Text.Contains("---"))
            {
                string nomrep = string.Empty;
                int codigo = -1;

                if (cboBusqX.Text == "TOTALES")
                    nomrep = cboOpRep.Text.ToUpper();
                else
                {
                    nomrep = cboOpRep.Text.ToUpper() + " POR " + cboBusqX.Text;
                    codigo = Convert.ToInt32(cboOpcion.SelectedValue);
                }
                    
                Reportes.RepListaProd lprod = new Reportes.RepListaProd(nomrep, codigo, ckbxQR.Checked, ckbxImg.Checked);
                lprod.Show();
            }
            else
                MessageBox.Show("Seleccione un Reporte valido", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void OpRepProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

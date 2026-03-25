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

namespace GRTechnology1._0
{
    public partial class Cargo : Form
    {
        OpcionFormularios opc = new OpcionFormularios();

        List<OCargo> LCarg = null;

        string CodInmode = string.Empty;
        string Opcion = string.Empty;
        bool Estado = false;

        public Cargo()
        {
            InitializeComponent();
        }

        private void HabilitarCont()
        {
            btnNuevo.Enabled = true;
            btnModif.Enabled = true;
            btnAnul.Enabled = true;
            btnRest.Enabled = true;
            btnAct.Enabled = true;
            btnReg.Enabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            txtCargo.ReadOnly = true;
            txtDetalle.ReadOnly = true;
        }

        private void DesabilitarCont()
        {
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnul.Enabled = false;
            btnRest.Enabled = false;
            btnAct.Enabled = false;
            btnReg.Enabled = false;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtCargo.ReadOnly = false;
            txtDetalle.ReadOnly = false;
        }

        private void NombreColumnas()
        {
            dgvCargo.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Width = 100;
            c1.Name = "Codigo";
            dgvCargo.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Width = 250;
            c2.Name = "Cargo";
            dgvCargo.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Width = 355;
            c3.Name = "Detalle";
            dgvCargo.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Visible = false;
            c4.Name = "Estado";
            dgvCargo.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Visible = false;
            c5.Name = "CodInmode";
            dgvCargo.Columns.Add(c5);
        }

        private void ListarCargos()
        {
            try
            {
                LCarg = NCargo.NListarCargos();
                CargarCargos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnas();
            }
        }

        private void CargarCargos()
        {
            if (LCarg != null)
            {
                NombreColumnas();

                int cont = 0;
                foreach (var item in LCarg)
                {
                    dgvCargo.Rows.Add(item.CargoID, item.NomCargo, item.DetalleCargo, item.Estado, item.CodInmode);

                    if (!item.Estado)
                    {
                        dgvCargo.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    cont++;
                    dgvCargo.Refresh();
                }
            }
            else
            {
                NombreColumnas();
            }
        }

        private void BuscarCargos()
        {
            if (txtBuscar.Text != string.Empty)
            {
                NombreColumnas();

                List<OCargo> lcargbusq = LCarg.FindAll(c => c.NomCargo.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                int cont = 0;
                foreach (var item in lcargbusq)
                {

                    dgvCargo.Rows.Add(item.CargoID, item.NomCargo, item.DetalleCargo, item.Estado, item.CodInmode);

                    if (!item.Estado)
                    {
                        dgvCargo.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    cont++;
                    dgvCargo.Refresh();
                }
            }
            else
            {
                CargarCargos();
            }
        }

        private void BorrarCampos(GroupBox gbx, string param)
        {
            OpcionFormularios lim = new OpcionFormularios();
            lim.BorrarCampos(gbx, param);
        }

        private void SeleccionarListCarg(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                BorrarCampos(gbxCargos, "");

                try
                {
                    CodInmode = dgvCargo["CodInmode", e.RowIndex].Value.ToString();
                    txtCod.Text = dgvCargo["Codigo", e.RowIndex].Value.ToString();
                    txtCargo.Text = dgvCargo["Cargo", e.RowIndex].Value.ToString();
                    txtDetalle.Text = dgvCargo["Detalle", e.RowIndex].Value.ToString();
                    Estado = Convert.ToBoolean(dgvCargo["Estado", e.RowIndex].Value);
                }
                catch
                { }
            }
        }

        private void InsertModifCargo()
        {
            try
            {
                //Objeto Inmode
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.TipoInmode = Opcion;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.IPInmode = opc.SaberIP();
                inm.MacInmode = opc.SaberMac();
                inm.MaquinaInmode = opc.SaberNomMaquina();
                inm.SistOperInmode = opc.SaberSistemOper();

                OCargo carg = new OCargo();
                if (Opcion == "Nuevo")
                {
                    carg.CargoID = -1;
                }
                else
                {
                    carg.CargoID = Convert.ToInt32(txtCod.Text);

                    //Cargamos Detalle Anulado
                    Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul("Modificar Cargo");
                    dmodanul.Owner = this;
                    dmodanul.ShowDialog();
                    inm.DetalleInmode = dmodanul.DetaModAnul();
                }

                carg.NomCargo = txtCargo.Text;
                carg.DetalleCargo = txtDetalle.Text;

                int resp = NCargo.NInsertModifCargo(carg, inm);
                if (resp > 0)
                {
                    MessageBox.Show("Los Datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Opcion = string.Empty;
                    HabilitarCont();
                    ListarCargos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnulRestauCargo(string op, int est)
        {
             if (txtCod.Text != string.Empty)
             {
                 DialogResult result = MessageBox.Show("¿Desea " + op + " " + txtCargo.Text + "?", op + " Cargo", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation);

                 if (result == DialogResult.Yes)
                 {
                     try
                     {
                         OInmode inm = new OInmode();
                         inm.CodInmode = CodInmode;
                         inm.TipoInmode = Opcion;
                         inm.UsuarioID = OConexionGlobal.UsuarioID;
                         inm.NomInmode = OConexionGlobal.NomPer;
                         inm.IPInmode = opc.SaberIP();
                         inm.MacInmode = opc.SaberMac();
                         inm.MaquinaInmode = opc.SaberNomMaquina();
                         inm.SistOperInmode = opc.SaberSistemOper();

                         //Cargamos Detalle Anulado
                         Frm_DetaModifAnul dmodanul = new Frm_DetaModifAnul(op + " Cargo");
                         dmodanul.Owner = this;
                         dmodanul.ShowDialog();
                         inm.DetalleInmode = dmodanul.DetaModAnul();

                         int resp = NCargo.NAnulRestauCargo(txtCod.Text, "Cargo", est, inm);
                         if (resp > 0)
                         {
                             MessageBox.Show("Los Datos se Actualizaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             ListarCargos();
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
             }
        }

        private void Nuevo()
        {
            BorrarCampos(gbxCargos, "");
            DesabilitarCont();
            Opcion = "Nuevo";
        }

        private void Modificar()
        {
            if (txtCod.Text != string.Empty)
            {
                DesabilitarCont();
                Opcion = "Modificar";
            }
        }

        private void Cancelar()
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Opcion = string.Empty;
                HabilitarCont();
                CargarCargos();
            }
        }

        private void Registro()
        {
            if (txtCod.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            ListarCargos();
            HabilitarCont();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnAnul_Click(object sender, EventArgs e)
        {
            if (Estado)
                AnulRestauCargo("Anular", 0);
            else
                MessageBox.Show("El Cargo ya está Anulado", "Cargo Anulado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (!Estado)
                AnulRestauCargo("Restaurar", 1);
            else
                MessageBox.Show("El Cargo ya está Habilitado", "Cargo Habilitado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ListarCargos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifCargo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarCargos();
        }

        private void dgvCargo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarListCarg(e);
        }

        private void Cargo_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


    }
}

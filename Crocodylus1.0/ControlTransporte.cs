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
    public partial class ControlTransporte : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OControlTransporte> LConTrans = null;

        string Opcion = string.Empty;
        string CodInmode = string.Empty;
        bool Estado = false;

        public ControlTransporte()
        {
            InitializeComponent();
        }

        #region Config Formulario

        private void CargarNombres()
        {
            GridListaContrTranp.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Codigo";
            c1.Width = 70;
            GridListaContrTranp.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Destino";
            c2.Width = 260;
            GridListaContrTranp.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Ciudad";
            c3.Width = 100;
            GridListaContrTranp.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Valor";
            c4.Width = 50;
            GridListaContrTranp.Columns.Add(c4);
        }

        private void HabilitarCont()
        {
            //op.HabilitarCont(gbxBotones, "1.09");

            txtBuscar.Enabled = true;

            txtDestino.Enabled = false;
            cboCiudad.Enabled = false;
            numUpDownValor.Enabled = false;
        }

        private void DesabilitarCont()
        {
            //Desabilitamos
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnAnul.Enabled = false;
            btnActualizar.Enabled = false;
            btnReg.Enabled = false;

            txtBuscar.Enabled = false;
            
            //Habilitamos
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtDestino.Enabled = true;
            cboCiudad.Enabled = true;
            numUpDownValor.Enabled = true;
        }

        #endregion

        #region Conexion Capa de Negocios

        private void ListarContTransp()
        {
            try
            {
                LConTrans = NControlTransporte.NListarContTransp(string.Empty);
                CargarContTrans(LConTrans);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarNombres();
            }
        }

        private void AnularContTrans()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro desea Anular el Destino " + txtDestino.Text + "?", "Anular", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo == DialogResult.Yes)
            {
                try
                {
                    OInmode inm = new OInmode();
                    inm.CodInmode = CodInmode;
                    inm.UsuarioID = OConexionGlobal.UsuarioID;
                    inm.TipoInmode = "Anular";
                    inm.NomInmode = OConexionGlobal.NomPer;
                    inm.IPInmode = op.SaberIP();
                    inm.MacInmode = op.SaberMac();
                    inm.MaquinaInmode = op.SaberNomMaquina();
                    inm.SistOperInmode = op.SaberSistemOper();

                    Frm_DetaModifAnul danul = new Frm_DetaModifAnul("Anular");
                    danul.Owner = this;
                    danul.ShowDialog();
                    inm.DetalleInmode = danul.DetaModAnul();

                    int resp = NControlTransporte.NAnulRestauAlm(txtContTranspID.Text, "ControlTransporte", 0, inm);
                    if(resp > 0)
                    {
                        MessageBox.Show("Se Anulo correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando.....");

                        ListarContTransp();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    op.CerrarCargando();
                }
            }
        }

        private void InsertModifContTrans()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.CodInmode = CodInmode;
                inm.UsuarioID = OConexionGlobal.UsuarioID;
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.TipoInmode = Opcion;
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();

                OControlTransporte contran = new OControlTransporte();
                if(Opcion == "Nuevo")
                {
                    contran.ContTransporteID = -1;
                }
                else
                {
                    contran.ContTransporteID = Convert.ToInt32(txtContTranspID.Text);

                    Frm_DetaModifAnul mod = new Frm_DetaModifAnul("Modificar");
                    mod.Owner = this;
                    mod.ShowDialog();
                    inm.DetalleInmode = mod.DetaModAnul();
                }

                contran.NomContTransporte = txtDestino.Text;
                contran.Ciudad = cboCiudad.Text;
                contran.Valor = Convert.ToInt32(numUpDownValor.Value);

                int resp = NControlTransporte.NInsertModifContTransp(contran, inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los Datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    op.AbrirCargando("Cargando.....");

                    Opcion = string.Empty;
                    HabilitarCont();
                    ListarContTransp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                op.CerrarCargando();
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarContTrans(List<OControlTransporte> lconttrans)
        {
            if (lconttrans != null)
            {
                CargarNombres();

                int cont = 0;
                foreach (var item in lconttrans)
                {
                    GridListaContrTranp.Rows.Add(item.ContTransporteID, item.NomContTransporte, item.Ciudad, string.Format("{0:#,##0.00}", item.Valor));

                    if (!item.Estado)
                        GridListaContrTranp.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                GridListaContrTranp.Refresh();
            }
            else
            {
                CargarNombres();
            }
        }

        private void BuscarContTrans()
        {
            if(LConTrans != null)
            {
                if(txtBuscar.Text != string.Empty)
                {
                    List<OControlTransporte> lbusqctrans = LConTrans.FindAll(x => x.NomContTransporte.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                    CargarContTrans(lbusqctrans);
                }
                else
                {
                    CargarContTrans(LConTrans);
                }
            }
        }

        private void SeleccionarContTrans(DataGridViewCellEventArgs e)
        {
            if((e.RowIndex > -1) && (Opcion == string.Empty))
            {
                try
                {
                    txtContTranspID.Text = GridListaContrTranp["Codigo", e.RowIndex].Value.ToString();

                    OControlTransporte OContTrans = LConTrans.Find(x => x.ContTransporteID.ToString() == txtContTranspID.Text);
                    if(OContTrans != null)
                    {
                        CodInmode = OContTrans.CodInmode;
                        Estado = OContTrans.Estado;

                        txtDestino.Text = OContTrans.NomContTransporte;
                        numUpDownValor.Value = OContTrans.Valor;
                        cboCiudad.Text = OContTrans.Ciudad;
                    }
                }
                catch (Exception)
                {           }
            }
        }

        #endregion

        #region Funciones

        private void BorrarCampos()
        {
            txtContTranspID.Clear();
            txtDestino.Clear();
            numUpDownValor.Value = 1;
        }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            BorrarCampos();
            DesabilitarCont();
        }

        private void Modif()
        {
            if (txtContTranspID.Text != string.Empty)
            {
                Opcion = "Modificar";
                DesabilitarCont();
            }
        }

        private void Cancelar()
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogo==DialogResult.Yes)
            {
                BorrarCampos();
                HabilitarCont();
                CargarContTrans(LConTrans);
            }
        }

        private void Registro()
        {
            if(txtContTranspID.Text != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.Owner = this;
                inm.ShowDialog();
            }
        }

        #endregion

        #region Eventos formulario

        private void ControlTransporte_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("cargando....");

            cboCiudad.Text = OConexionGlobal.Ciudad;
            HabilitarCont();
            ListarContTransp();

            op.CerrarCargando();
        }

        private void ControlTransporte_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modif();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if(txtContTranspID.Text != string.Empty)
                AnularContTrans();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando.....");

            ListarContTransp();

            op.CerrarCargando();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarContTrans();
        }

        private void GridListaContrTranp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarContTrans(e);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifContTrans();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        #endregion
    }
}

using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace GRTechnology1._0
{
    public partial class Frm_Cajas : GRTechnology1._0.Frm_Base_Mantenimiento
    {
        OCaja ocaja = new OCaja();
        DataTable DTCajas = null;
        IEnumerable<DataRow> DRCaja = null;

        public Frm_Cajas()
        {
            InitializeComponent();
        }

        #region Config. Formulario

        public override void HabilitarCont()
        {
            //habilitamos botones
            base.HabilitarCont();

            //desabilitamos
            gbxDatos.Enabled = false;
        }

        public override void DesabilitarCont()
        {
            base.DesabilitarCont();

            //habilitamos campos
            gbxDatos.Enabled = true;
        }

        #endregion

        #region Conexion Caja de Datos

        private void ListarTipo()
        {
            DataTable DTTipo = DListarPersonalizado.ConsultarDT("SELECT TipoID, NomTipo FROM Tipo_Sistema_Fijo WHERE Tupla='CAJA' AND Estado=1 UNION SELECT 0, '[SELECCIONE...]' ORDER BY TipoID");
            
            cboTipo.DataSource = DTTipo;
            cboTipo.DisplayMember = "NomTipo";
            cboTipo.ValueMember = "TipoID";
            cboTipo.SelectedValue = "0";
        }

        public override void Listar(bool Local)
        {
            try
            {
                DTCajas = DListarPersonalizado.ConsultarDT("SELECT * FROM Vista_Cajas ORDER BY CajaID DESC");

                DRCaja = from caja in DTCajas.AsEnumerable()
                         select caja;

                CargarCajas(DRCaja);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void InsertModif()
        {
            if (!Verificar())
                return;

            try
            {
                string detinmode = string.Empty;
                ocaja = new OCaja();
                if (Opcion == "Nuevo")
                    ocaja.CajaID = -1;
                else
                {
                    ocaja.CajaID = Convert.ToInt32(ID);

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul("Modificar");
                    dmod.ShowDialog();
                    detinmode = dmod.DetaModAnul();
                    if (dmod.Cancelado)
                        throw new Exception("CANCELADO POR EL USUARIO");
                }

                ocaja.NomCaja = txtNombre.Text.Trim();
                ocaja.TipoCajaID = (int)cboTipo.SelectedValue;

                int resp = DCaja.DInsertModifCaja(ocaja, OInmode.DTInmode(CodInmode, Opcion, detinmode));
                if (resp > 0)
                {
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Opcion = string.Empty;
                    BorrarCampos();
                    HabilitarCont();
                    Listar(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarCajas(IEnumerable<DataRow> drcajas)
        {
            dgvDatos.Rows.Clear();

            if (drcajas != null)
            {
                int cont = 0;
                foreach (DataRow item in drcajas)
                {
                    dgvDatos.Rows.Add(item.Field<int>("CajaID"), item.Field<string>("NomCaja"), item.Field<string>("NomTipo"));

                    if (!item.Field<bool>("Estado"))
                        dgvDatos.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
            }
        }

        public override void Seleccionar(int fila)
        {
            try
            {
                BorrarCampos();

                base.ID = dgvDatos["C1", fila].Value.ToString();
                IEnumerable<DataRow> TipoQuery = DRCaja.Where(p => p.Field<int>("CajaID") == Convert.ToInt32(ID));

                foreach (var item in TipoQuery)
                {
                    base.CodInmode = item.Field<string>("CodInmode");
                    base.Estado = item.Field<bool>("Estado");

                    txtNombre.Text = item.Field<string>("NomCaja");
                    cboTipo.SelectedValue = item.Field<int>("TipoCajaID");
                }
            }
            catch (Exception)
            {
                BorrarCampos();
            }
        }

        public override void Buscar()
        {
            if (txtBuscador.Text != string.Empty)
            {
                IEnumerable<DataRow> TipoQuery = (from Caja in DTCajas.AsEnumerable()
                                                  select Caja).Where(p => p.Field<string>("NomCaja").ToUpper().Contains(txtBuscador.Text.ToUpper()));

                CargarCajas(TipoQuery);
            }
            else
                CargarCajas(DRCaja);
        }

        #endregion

        #region Funciones

        public override void BorrarCampos()
        {
            CodInmode = string.Empty;
            ID = string.Empty;
            Estado = false;

            txtNombre.Clear();
            cboTipo.SelectedValue = "0";
        }

        public override void Cancelar()
        {
            Opcion = string.Empty;
            BorrarCampos();
            CargarCajas(DRCaja);
            HabilitarCont();
        }

        private bool Verificar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("EL CAMPO NOMBRE NO PUEDE ESTAR VACÍO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cboTipo.SelectedValue.ToString() == "0")
            {
                cboTipo.Focus();
                MessageBox.Show("SELECCIONE EL TIPO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        public override void Actualizar()
        {
            Listar(false);
        }

        #endregion

        private void Frm_Cajas_Load(object sender, EventArgs e)
        {
            HabilitarCont();
            ListarTipo();
            Listar(false);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Anular("Cajas");
        }
    }
}

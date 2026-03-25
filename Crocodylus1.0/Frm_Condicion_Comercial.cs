using Datos;
using Objetos;
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
    public partial class Frm_Condicion_Comercial : Frm_Base_Mantenimiento
    {
        DataTable DTCondCom = null;
        IEnumerable<DataRow> DRCondCom = null;

        public Frm_Condicion_Comercial()
        {
            InitializeComponent();
        }

        #region Config. Formulario

        public override void HabilitarCont()
        {
            //habilitamos botones
            base.HabilitarCont();

            //desabilitamos
            txtTitulo.ReadOnly = true;
            txtDesc.ReadOnly = true;
        }

        public override void DesabilitarCont()
        {
            base.DesabilitarCont();

            //habilitamos campos
            txtTitulo.ReadOnly = false;
            txtDesc.ReadOnly = false;
        }

        #endregion

        #region Conexion Caja de Datos

        public override void Listar(bool Local)
        {
            try
            {
                DTCondCom = DListarPersonalizado.ConsultarDT("SELECT * FROM Condicion_Comercial WHERE Estado=1 ORDER BY CondComID DESC");

                DRCondCom = from CondComer in DTCondCom.AsEnumerable()
                            select CondComer;

                CargarTipo(DRCondCom);
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

                OCondicion_Comercial condcom = new OCondicion_Comercial();

                if (Opcion == "Nuevo")
                    condcom.CondComID = -1;
                else
                {
                    condcom.CondComID = Convert.ToInt32(ID);

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul("MODIFICAR");
                    dmod.ShowDialog();
                    detinmode = dmod.DetaModAnul();
                    if (dmod.Cancelado)
                        throw new Exception("CANCELADO POR EL USUARIO");
                }

                condcom.Titulo = txtTitulo.Text.Trim();
                condcom.Descripcion = txtDesc.Text;

                int resp = DCondicion_Comercial.DInsertModifCondComercial(condcom, OInmode.DTInmode(CodInmode, Opcion, detinmode));
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

        private void CargarTipo(IEnumerable<DataRow> dr)
        {
            dgvDatos.Rows.Clear();

            if (dr != null)
            {
                int cont = 0;
                foreach (DataRow item in dr)
                {
                    dgvDatos.Rows.Add(item.Field<int>("CondComID"), item.Field<string>("Titulo"));

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

                base.ID = dgvDatos["CondComID", fila].Value.ToString();
                IEnumerable<DataRow> TipoQuery = DRCondCom.Where(p => p.Field<int>("CondComID") == Convert.ToInt32(ID));

                foreach (var item in TipoQuery)
                {
                    base.CodInmode = item.Field<string>("CodInmode");
                    base.Estado = item.Field<bool>("Estado");

                    txtTitulo.Text = item.Field<string>("Titulo");
                    txtDesc.Text = item.Field<string>("Descripcion");
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
                IEnumerable<DataRow> TipoQuery = (from Caja in DTCondCom.AsEnumerable()
                                                  select Caja).Where(p => p.Field<string>("NomTipo").ToUpper().Contains(txtBuscador.Text.ToUpper()));

                CargarTipo(TipoQuery);
            }
            else
                CargarTipo(DRCondCom);
        }

        #endregion

        #region Funciones

        public override void BorrarCampos()
        {
            CodInmode = string.Empty;
            ID = string.Empty;
            Estado = false;
            txtTitulo.Clear();
            txtDesc.Clear();
        }

        public override void Cancelar()
        {
            Opcion = string.Empty;
            BorrarCampos();
            CargarTipo(DRCondCom);
            HabilitarCont();
        }

        private bool Verificar()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                txtTitulo.Focus();
                MessageBox.Show("EL TÍTULO NO PUEDE ESTAR VACÍO");
                return false;
            }

            return true;
        }

        public override void Actualizar()
        {
            Listar(false);
        }

        #endregion

        private void Frm_Condicion_Comercial_Load(object sender, EventArgs e)
        {
            HabilitarCont();
            Listar(false);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Anular("Condic_Comercial");
        }
    }
}

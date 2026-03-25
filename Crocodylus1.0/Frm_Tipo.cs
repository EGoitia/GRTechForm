using Negocio;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Tipo : Frm_Base_Mantenimiento
    {
        OTipo T = new OTipo();
        DataTable DTTipo = null;
        IEnumerable<DataRow> DRTipo = null;

        string Tupla = string.Empty;
        public bool Seleccionado = false;

        public Frm_Tipo(string _tupla)
        {
            InitializeComponent();

            this.Tupla = _tupla;
        }

        #region Config. Formulario

        public override void HabilitarCont()
        {
            //habilitamos botones
            base.HabilitarCont();

            //desabilitamos
            txtNomTipo.ReadOnly = true;
            ckbxEstado.Enabled = false;
        }

        public override void DesabilitarCont()
        {
            base.DesabilitarCont();

            //habilitamos campos
            txtNomTipo.ReadOnly = false;
            ckbxEstado.Enabled = true;
        }

        #endregion

        #region Conexion Caja de Datos

        public override void Listar(bool Local)
        {
            try
            {
                DTTipo = NTipo.Listar_TipoDT(Tupla);

                DRTipo = from Tipo in DTTipo.AsEnumerable()
                         select Tipo;

                CargarTipo(DRTipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void InsertModif()
        {
            try
            {
                Verificar();

                string detinmode = string.Empty;
                T = new OTipo();
                if (Opcion == "Nuevo")
                    T.TipoID = -1;
                else
                {
                    T.TipoID = Convert.ToInt32(ID);

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul("Modificar");
                    dmod.ShowDialog();
                    detinmode = dmod.DetaModAnul();
                    if (dmod.Cancelado)
                        throw new Exception("CANCELADO POR EL USUARIO");
                }

                T.NomTipo = txtNomTipo.Text;
                T.Tupla = Tupla;

                int resp = NTipo.InsertModif_Tipo(T, OInmode.DTInmode(CodInmode, Opcion, detinmode));
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

        private void CargarTipo(IEnumerable<DataRow> drcaj)
        {
            dgvDatos.Rows.Clear();

            if (drcaj != null)
            {
                int cont = 0;
                foreach (DataRow item in drcaj)
                {
                    dgvDatos.Rows.Add(item.Field<int>("TipoID"), item.Field<string>("NomTipo"), item.Field<bool>("Estado"));

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
                IEnumerable<DataRow> TipoQuery = DRTipo.Where(p => p.Field<int>("TipoID") == Convert.ToInt32(ID));

                foreach (var item in TipoQuery)
                {
                    base.CodInmode = item.Field<string>("CodInmode");
                    base.Estado = item.Field<bool>("Estado");

                    txtNomTipo.Text = item.Field<string>("NomTipo");
                    ckbxEstado.Checked = item.Field<bool>("Estado");
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
                IEnumerable<DataRow> TipoQuery = (from Caja in DTTipo.AsEnumerable()
                                                  select Caja).Where(p => p.Field<string>("NomTipo").ToUpper().Contains(txtBuscador.Text.ToUpper()));

                CargarTipo(TipoQuery);
            }
            else
                CargarTipo(DRTipo);
        }

        #endregion

        #region Funciones

        public override void BorrarCampos()
        {
            CodInmode = string.Empty;
            ID = string.Empty;
            Estado = false;
            txtNomTipo.Clear();
            ckbxEstado.Checked = false;
        }

        public override void Cancelar()
        {
            Opcion = string.Empty;
            BorrarCampos();
            CargarTipo(DRTipo);
            HabilitarCont();
        }

        private void Verificar()
        {
            if ((string.IsNullOrEmpty(txtNomTipo.Text)) || (string.IsNullOrWhiteSpace(txtNomTipo.Text)))
            {
                txtNomTipo.Focus();
                throw new Exception("El Campo Nombre Tipo no puede estar vacío");
            }
        }

        public override void Actualizar()
        {
            Listar(false);
        }

        #endregion

        #region Eventos Formulario

        private void Frm_Tipo_Load(object sender, EventArgs e)
        {
            this.Text = "Tipo " + Tupla;

            HabilitarCont();
            Listar(false);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Anular("Tipo");
        }

        #endregion
    }
}

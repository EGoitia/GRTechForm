using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace GRTechnology1._0
{
    public partial class Frm_Cuenta_Ingreso_Egreso : GRTechnology1._0.Frm_Base_Mantenimiento
    {
        OCuenta_Ingresos_Egresos ocuenta = new OCuenta_Ingresos_Egresos();
        DataTable DTCuenta = null;
        IEnumerable<DataRow> DRCuenta = null;
        
        public Frm_Cuenta_Ingreso_Egreso()
        {
            InitializeComponent();
        }

        #region Config. Formulario

        public override void HabilitarCont()
        {
            //habilitamos botones
            base.HabilitarCont();

            //desabilitamos
            gbxCuenIngrEgre.Enabled = false;
        }

        public override void DesabilitarCont()
        {
            base.DesabilitarCont();

            //habilitamos campos
            gbxCuenIngrEgre.Enabled = true;
        }

        #endregion

        #region Conexion Caja de Datos

        private void ListarTipo()
        {
            DataTable DTTipo = new DataTable();
            DTTipo.Columns.Add("TipoID");
            DTTipo.Columns.Add("NombreTipo");

            DataRow DRTipo;
            DRTipo = DTTipo.NewRow();
            DRTipo["TipoID"] = "";
            DRTipo["NombreTipo"] = "SELECCIONE...";
            DTTipo.Rows.Add(DRTipo);

            DRTipo = DTTipo.NewRow();
            DRTipo["TipoID"] = "I";
            DRTipo["NombreTipo"] = "INGRESO";
            DTTipo.Rows.Add(DRTipo);

            DRTipo = DTTipo.NewRow();
            DRTipo["TipoID"] = "E";
            DRTipo["NombreTipo"] = "EGRESO";
            DTTipo.Rows.Add(DRTipo);

            cboTipo.DataSource = DTTipo;
            cboTipo.DisplayMember = "NombreTipo";
            cboTipo.ValueMember = "TipoID";
            cboTipo.SelectedValue = "";
        }

        public override void Listar(bool Local)
        {
            try
            {
                DTCuenta = DListarPersonalizado.ConsultarDT("SELECT * FROM Vista_Cuenta_Ingresos_Egresos ORDER BY Cuenta_Ingreso_EgresoID DESC");

                DRCuenta = from cuenta in DTCuenta.AsEnumerable()
                           select cuenta;

                CargarCuentaIngrEgre(DRCuenta);
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
                ocuenta = new OCuenta_Ingresos_Egresos();
                if (Opcion == "Nuevo")
                    ocuenta.Cuenta_Ingreso_EgresoID = -1;
                else
                {
                    ocuenta.Cuenta_Ingreso_EgresoID = Convert.ToInt32(ID);

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul("Modificar");
                    dmod.ShowDialog();
                    detinmode = dmod.DetaModAnul();
                    if (dmod.Cancelado)
                        throw new Exception("CANCELADO POR EL USUARIO");
                }

                ocuenta.Nombre = txtNombre.Text.Trim();
                ocuenta.Descripcion = txtDescripcion.Text.Trim();
                ocuenta.TipoIngresoEgreso = cboTipo.SelectedValue.ToString();

                int resp = DCuenta_Ingreso_Egreso.DInsertModifCuentaIngrEgre(ocuenta, OInmode.DTInmode(CodInmode, Opcion, detinmode));
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

        private void CargarCuentaIngrEgre(IEnumerable<DataRow> dringregre)
        {
            dgvDatos.Rows.Clear();

            if (dringregre != null)
            {
                int cont = 0;
                foreach (DataRow item in dringregre)
                {
                    dgvDatos.Rows.Add(item.Field<int>("Cuenta_Ingreso_EgresoID"), item.Field<string>("Nombre"), item.Field<string>("TipoIngresoEgreso"));

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
                IEnumerable<DataRow> TipoQuery = DRCuenta.Where(p => p.Field<int>("Cuenta_Ingreso_EgresoID") == Convert.ToInt32(ID));

                foreach (var item in TipoQuery)
                {
                    base.CodInmode = item.Field<string>("CodInmode");
                    base.Estado = item.Field<bool>("Estado");

                    txtNombre.Text = item.Field<string>("Nombre");
                    txtDescripcion.Text = item.Field<string>("Descripcion");
                    cboTipo.SelectedValue = item.Field<string>("TipoIngresoEgreso");
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
                IEnumerable<DataRow> TipoQuery = (from Caja in DTCuenta.AsEnumerable()
                                                  select Caja).Where(p => p.Field<string>("Nombre").ToUpper().Contains(txtBuscador.Text.ToUpper()));

                CargarCuentaIngrEgre(TipoQuery);
            }
            else
                CargarCuentaIngrEgre(DRCuenta);
        }

        #endregion

        #region Funciones

        public override void BorrarCampos()
        {
            CodInmode = string.Empty;
            ID = string.Empty;
            Estado = false;

            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtNombre.Clear();
            cboTipo.SelectedValue = ""; 
        }

        public override void Cancelar()
        {
            Opcion = string.Empty;
            BorrarCampos();
            CargarCuentaIngrEgre(DRCuenta);
            HabilitarCont();
        }

        private void Verificar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Focus();
                throw new Exception("EL CAMPO NOMBRE NO PUEDE ESTAR VACÍO");
            }
            else if (cboTipo.SelectedValue.ToString() == "")
            {
                cboTipo.Focus();
                throw new Exception("SELECCIONE EL TIPO DE CUENTA");
            }
        }

        public override void Actualizar()
        {
            Listar(false);
        }

        #endregion

        #region Eventos Formulario
        
        private void Frm_Cuenta_Ingreso_Egreso_Load(object sender, EventArgs e)
        {
            HabilitarCont();
            ListarTipo();
            Listar(false);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Anular("Cuenta_Ingreso_Egreso");
        }

        #endregion

    }
}

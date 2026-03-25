using Negocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Base_Mantenimiento : Form
    {
        public string Opcion = string.Empty;
        public string CodInmode = string.Empty;
        public string ID = string.Empty;
        public bool Estado = false;

        public Frm_Base_Mantenimiento()
        {
            InitializeComponent();
        }

        #region Config Formulario

        public virtual void HabilitarCont()
        {
            //habilitamos
            txtBuscador.ReadOnly = false;

            btnNuevo.Enabled = true;
            btnModif.Enabled = true;
            btnAnular.Enabled = true;
            btnAct.Enabled = true;
            btnRegistro.Enabled = true;

            //desabilitamos
            btnGuardar.Enabled = false;
            btnCancel.Enabled = false;
        }

        public virtual void DesabilitarCont()
        {
            //desabilitamos
            btnNuevo.Enabled = false;
            btnModif.Enabled = false;
            btnAnular.Enabled = false;
            btnRegistro.Enabled = false;
            btnAct.Enabled = false;

            txtBuscador.ReadOnly = true;

            //habilitamos 
            btnGuardar.Enabled = true;
            btnCancel.Enabled = true;
        }

        #endregion

        #region Metodos

        public virtual void BorrarCampos()
        { }

        private void Nuevo()
        {
            Opcion = "Nuevo";
            DesabilitarCont();
            BorrarCampos();
        }

        private void Modificar()
        {
            if (ID != string.Empty)
            {
                if (Estado)
                {
                    Opcion = "Modificar";
                    DesabilitarCont();
                }
                else
                    MessageBox.Show("Ya esta Anulado!", "Anulado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public virtual void Anular(string Tupla)
        {
            if (ID != string.Empty)
            {
                if (Estado)
                {
                    DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA ANULAR?", "ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogo == DialogResult.Yes)
                    {
                        try
                        {
                            Frm_DetaModifAnul anul = new Frm_DetaModifAnul("Anular");
                            anul.ShowDialog();
                            string DetInm = anul.DetaModAnul();
                            if (anul.Cancelado)
                                throw new Exception("CANCELADO POR EL USUARIO");

                            bool resp = NListarPersonalizado.AnulRestau(ID.ToString(), Tupla, CodInmode, DetInm, "Anular", false);
                            if (resp)
                            {
                                MessageBox.Show("SE ANULÓ CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                BorrarCampos();
                                Listar(false);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    MessageBox.Show("YA ESTÁ ANULADO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registro()
        {
            if (CodInmode != string.Empty)
            {
                Frm_Inmode inm = new Frm_Inmode(CodInmode);
                inm.ShowDialog();
            }
        }

        public virtual void Actualizar()
        { }

        public virtual void InsertModif()
        { }

        public virtual void Listar(bool Local)
        { }

        public virtual void Cancelar()
        { }

        public virtual void Buscar()
        { }

        public virtual void Seleccionar(int fila)
        { }

        #endregion
        
        #region Eventos Formulario
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModif();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
                Cancelar();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void dgvDatos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Opcion == string.Empty)
                Seleccionar(e.RowIndex);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvDatos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvDatos.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }

        #endregion
    }
}

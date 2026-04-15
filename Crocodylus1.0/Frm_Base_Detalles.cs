using Negocio;
using Objetos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Frm_Base_Detalles : Form
    {
        public string ID = string.Empty;
        public bool Estado = false;

        public Frm_Base_Detalles()
        {
            InitializeComponent();
        }

        #region Metodos

        private void Registro()
        {
            if (dgvDetalle.Rows.Count > 0 && dgvDetalle.CurrentRow.Index > -1)
            {
                Frm_Inmode inm = new Frm_Inmode(dgvDetalle["CodInmode", dgvDetalle.CurrentRow.Index].Value.ToString());
                inm.ShowDialog();
            }
        }

        public virtual void Modificar(string opc)
        {
            if (dgvDetalle.Rows.Count > 0 && dgvDetalle.CurrentRow.Index > -1)
            {
                Estado = (bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value;
                if (Estado)
                {
                    if (opc == "Producto")
                    {
                        ID = dgvDetalle["ProductoID", dgvDetalle.CurrentRow.Index].Value.ToString();
                        
                        if (Frm_Producto.pr == null)
                        {
                            Frm_Producto.pr = new Frm_Producto();
                            Frm_Producto.pr.ProductoID = Convert.ToInt32(ID);
                            Frm_Producto.pr.WindowState = FormWindowState.Maximized;
                            Frm_Producto.pr.ShowDialog();
                        }
                        else
                            MessageBox.Show("NO PUEDE MODIFICAR PORQUE ESTÁ ABIERTO EL FORMULARIO DE PRODUCTOS");
                    }
                    else if (opc == "Compra")
                    {
                        ID = dgvDetalle["CodCompraProd", dgvDetalle.CurrentRow.Index].Value.ToString();
                        if (Frm_Compra.frmcomp == null)
                        {
                            Frm_Compra.frmcomp = new Frm_Compra();
                            Frm_Compra.frmcomp.txtCodigoNota.Text = ID;
                            Frm_Compra.frmcomp.WindowState = FormWindowState.Maximized;
                            Frm_Compra.frmcomp.ShowDialog();
                        }
                        else
                            MessageBox.Show("NO PUEDE MODIFICAR PORQUE ESTÁ ABIERTO EL FORMULARIO DE COMPRAS");
                    }
                    else if (opc == "Proyeccion")
                    {
                        ID = dgvDetalle["ProyeccionID", dgvDetalle.CurrentRow.Index].Value.ToString();
                        if (Frm_ProyeccionVenta.frmproy == null)
                        {
                            Frm_ProyeccionVenta.frmproy = new Frm_ProyeccionVenta();
                            Frm_ProyeccionVenta.frmproy.txtNumProy.Text = ID;
                            Frm_ProyeccionVenta.frmproy.WindowState = FormWindowState.Maximized;
                            Frm_ProyeccionVenta.frmproy.ShowDialog();
                        }
                        else
                            MessageBox.Show("NO PUEDE MODIFICAR PORQUE ESTÁ ABIERTO EL FORMULARIO DE COMPRAS");
                    }
                    else if (opc == "INGRESO")
                    {
                        ID = dgvDetalle["CodIngSalProd", dgvDetalle.CurrentRow.Index].Value.ToString();
                        if (Frm_IngSalProducto.frmingprod == null)
                        {
                            Frm_IngSalProducto.frmingprod = new Frm_IngSalProducto();
                            Frm_IngSalProducto.frmingprod.txtCodigoNota.Text = ID;
                            Frm_IngSalProducto.frmingprod.Tupla = "INGRESO";
                            Frm_IngSalProducto.frmingprod.TipoNota = "IngSalProd";
                            Frm_IngSalProducto.frmingprod.AbrirCerrarPanelBusqProd();
                            Frm_IngSalProducto.frmingprod.btnAbriCerrarPanel.Enabled = false;
                            Frm_IngSalProducto.frmingprod.WindowState = FormWindowState.Maximized;
                            Frm_IngSalProducto.frmingprod.ShowDialog();
                        }
                        else
                            MessageBox.Show("NO PUEDE MODIFICAR PORQUE ESTÁ ABIERTO EL FORMULARIO DE INGRESO");
                    }

                    Buscar();
                }
                else
                    MessageBox.Show("¡LA NOTA ESTA ANULADA!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public virtual void Buscar()
        { }

        public virtual void ImprNota()
        { }

        public virtual void ImprLista(string[] ConsultaSql, string[] NomTabla, string TituloRep, string Variable, string NomRep,
            bool mostrarbtnimp = true, bool mostrarbtncopiar = true, bool mostrarbtnexport = true, bool mostrararbol = true)
        {
            if (dgvDetalle.Rows.Count > 0)
            {
                Frm_Reporte rep = new Frm_Reporte();
                rep.Variable = Variable;
                rep.Titulo = TituloRep;

                for (int i = 0; i < ConsultaSql.Length; i++)
                {
                    rep.Llenar_Tabla(ConsultaSql[i], NomTabla[i]);
                }

                rep.Cargar(NomRep, false, mostrarbtnimp, mostrarbtncopiar, mostrarbtnexport, mostrararbol);
                rep.Show();
            }
        }

        public virtual void Anular(string Tupla, string msje)
        {
            if (ID != string.Empty)
            {
                Estado = (bool)dgvDetalle["Estado", dgvDetalle.CurrentRow.Index].Value;
                if (Estado)
                {
                    DialogResult dialogo = MessageBox.Show("¿SEGURO QUE DESEA ANULAR " + msje + "?", "ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogo == DialogResult.Yes)
                    {
                        Frm_DetaModifAnul anul = new Frm_DetaModifAnul("ANULAR");
                        anul.ShowDialog();
                        string DetInm = anul.DetaModAnul();
                        if (anul.Cancelado)
                        {
                            MessageBox.Show("CANCELADO POR EL USUARIO", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        try
                        {
                            bool resp = NListarPersonalizado.AnulRestau_Nota(ID.ToString(), Tupla, dgvDetalle["CodInmode", dgvDetalle.CurrentRow.Index].Value.ToString(), DetInm, "ANULAR", false);
                            if (resp)
                            {
                                MessageBox.Show("SE ANULÓ CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Buscar();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                    MessageBox.Show("YA ESTÁ ANULADO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Eventos Formulario

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void btnImpNota_Click(object sender, EventArgs e)
        {
            ImprNota();
        }

        private void dgvDetalle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvDetalle.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }

            if (dgvDetalle.Rows.Count > 0 && dgvDetalle.Columns.Contains("Estado"))
            {
                DataGridViewRow dgvr = dgvDetalle.Rows[e.RowIndex];

                if (!(bool)dgvr.Cells["Estado"].Value)
                    dgvr.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        #endregion

    }
}

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

namespace GRTechnology1._0.Buscadores
{
    public partial class BusqNotas : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<ODetalleConformidad> LDConf = null;
        List<OSucursal> LSuc = null;

        string CodNota = string.Empty;

        public BusqNotas()
        {
            InitializeComponent();
        }

        #region Configurar Formulario

        private void NombreColumnas()
        {
            dgvDetalles.Columns.Clear();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Cod. Item";
            c1.Width = 70;
            c1.ReadOnly = true;
            dgvDetalles.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Detalle";
            c2.Width = 250;
            c2.ReadOnly = true;
            dgvDetalles.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Cantidad";
            c3.Width = 80;
            c3.ReadOnly = true;
            dgvDetalles.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Unid. Medida";
            c4.Width = 80;
            c4.ReadOnly = true;
            dgvDetalles.Columns.Add(c4);

            if(cboOpcion.Text == "TR")
            {
                DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
                c5.Name = "Peso";
                c5.Width = 80;
                c5.ReadOnly = true;
                dgvDetalles.Columns.Add(c5);
            }
            else
            {
                DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
                c5.Name = "P Total";
                c5.Width = 80;
                c5.ReadOnly = true;

                if (OConexionGlobal.TipoUsu == "Administrador")
                    c5.Visible = true;
                else
                    c5.Visible = false;

                dgvDetalles.Columns.Add(c5);
            }
            

            DataGridViewCheckBoxColumn c6 = new DataGridViewCheckBoxColumn();
            c6.Name = "";
            c6.Width = 50;
            dgvDetalles.Columns.Add(c6);
        }

        private void CambiarColorForm()
        {
            NombreColumnas();

            switch (cboOpcion.Text)
            {
                case "NR":
                    this.BackColor = System.Drawing.Color.LightSeaGreen;
                    lblOpcion1.Text = "Cliente..............";
                    lblOpcion2.Text = "Referencia........";
                    break;
                case "NI":
                    this.BackColor = System.Drawing.Color.LightSeaGreen;
                    lblOpcion1.Text = "Tipo Ingreso......";
                    lblOpcion2.Text = "Recibido de......";
                    break;
                case "NS":
                    this.BackColor = System.Drawing.Color.YellowGreen;
                    lblOpcion1.Text = "Tipo Salida.......";
                    lblOpcion2.Text = "Entregado a......";
                    break;
                case "TR":
                    this.BackColor = System.Drawing.Color.Orange;
                    lblOpcion1.Text = "Del Almacen......";
                    lblOpcion2.Text = "Al Almacen........";
                    break;
                case "DEV":
                    this.BackColor = System.Drawing.Color.MediumSlateBlue;
                    lblOpcion1.Text = "Cliente..............";
                    lblOpcion2.Text = "Referencia........";
                    break;
            }
        }

        #endregion

        #region Conexion Capa de Negocio

        private void ListarSuc()
        {
            try
            {
                LSuc = NSucursal.NListarSucursales();
                CargarSuc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarNotas()
        {
            if (txtNumNota.Text != string.Empty)
            {
                NombreColumnas();
                try
                {
                    op.AbrirCargando("Buscando.....");
                    this.Cursor = Cursors.WaitCursor;

                    switch (cboOpcion.Text)
                    {
                        case "NR":
                            foreach (var item in NVenta.NBuscarVentas(txtNumNota.Text, "Numero Nota", DateTime.Now, (int)cboSuc.SelectedValue))
                            {
                                //CodNota = item.CodVenta;
                                //txtNro.Text = item.NumVenta;
                                //txtOpcion1.Text = item.NomClien;
                                //txtOpcion2.Text = item.Referencia;
                                //dtFecha.Text = item.Fecha.ToString();
                                //txtDetalle.Text = item.Detalle;

                                BuscarDetalle(item.CodVenta);
                            }
                            break;
                        case "DEV":
                            goto case "NR";
                        case "NI":
                            foreach (var item in NIngSalProducto.NBuscarIngSalProd("Ingreso", "Nro. Nota", txtNumNota.Text, (int)cboSuc.SelectedValue, DateTime.Now))
                            {
                                CodNota = item.CodIngSalProd;                                
                                txtOpcion2.Text = item.Recibido;
                                txtDetalle.Text = item.Concepto;

                                BuscarDetalle(item.CodIngSalProd);
                            }
                            break;
                        case "NS":
                            foreach (var item in NIngSalProducto.NBuscarIngSalProd("Salida", "Nro. Nota", txtNumNota.Text, (int)cboSuc.SelectedValue, DateTime.Now))
                            {
                                CodNota = item.CodIngSalProd;
                                txtOpcion2.Text = item.Recibido;
                                txtDetalle.Text = item.Concepto;

                                BuscarDetalle(item.CodIngSalProd);
                            }
                            break;
                        case "TR":
                            foreach (var item in NTraspaso.NBuscarTraspaso(txtNumNota.Text, "Numero Nota", DateTime.Now, 
                                                    Convert.ToInt32(cboSuc.SelectedValue), Convert.ToChar("0")))
                            {
                                CodNota = item.CodTraspaso;
                                
                                txtDetalle.Text = item.Detalle;

                                BuscarDetalle(item.CodTraspaso);
                            }
                            break;
                    }
                    btnExportar.Focus();
                }
                catch (Exception)
                {
                    NombreColumnas();
                    txtNumNota.Focus();
                }
                finally
                {
                    op.CerrarCargando();
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void BuscarDetalle(string cod)
        {
            decimal cant = 0;
            try
            {
                NombreColumnas();

                switch (cboOpcion.Text)
                {
                    case "NR":
                        foreach (var item in NDetalleVenta.NBuscarDVen(cod))
                        {
                            dgvDetalles.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad),
                                                 item.UnidMedida, string.Format("{0:#,##0.00}", item.PTotal), true);

                            cant += item.Cantidad;
                        }
                        break;
                    case "DEV":
                        goto case "NR";
                    case "NI":
                        foreach (var item in NDetalleIngSalProducto.NBuscarDIngSalProd(cod))
                        {
                            dgvDetalles.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad),
                                                 item.UnidMedida, string.Format("{0:#,##0.00}", item.PTotal), true);

                            cant += item.Cantidad;
                        }
                        break;
                    case "NS":
                        goto case "NI";
                    case "TR":
                        foreach (var item in NDetalleTraspaso.NBuscarTraspaso(cod))
                        {
                            dgvDetalles.Rows.Add(item.ProductoID, item.NomProd, string.Format("{0:#,##0.00}", item.Cantidad),
                                                 item.UnidMedida, string.Format("{0:#,##0.00}", item.Peso), true);

                            cant += item.Cantidad;
                        }
                        break;
                }
            }
            catch
            {
                NombreColumnas();
            }
            finally
            {
                txtCantidad.Text = string.Format("{0:#,##0.00}", cant);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarSuc()
        {
            if (LSuc != null)
            {
                List<OSucursal> lsuc = LSuc.Where(x => x.Estado).OrderBy(x => x.NomSuc).ToList();

                cboSuc.DataSource = lsuc;
                cboSuc.DisplayMember = "NomSuc";
                cboSuc.ValueMember = "SucursalID";
                cboSuc.Refresh();
                //por defecto la sucursal
                cboSuc.Text = OConexionGlobal.NomSuc;
            }
        }

        #endregion

        #region Funciones

        private void SelecTodo()
        {
            for (int i = 0; i < dgvDetalles.Rows.Count - 1; i++)
            {
                if (dgvDetalles["Cod. Item", i].Value.ToString() != "")
                {
                    dgvDetalles["", i].Value = true;
                }
                else
                {
                    break;
                }
            }
        }

        private void Invertir()
        {
            for (int i = 0; i < dgvDetalles.Rows.Count - 1; i++)
            {
                if (dgvDetalles["Cod. Item", i].Value.ToString() != "")
                {
                    dgvDetalles["", i].Value = false;
                }
                else
                {
                    break;
                }
            }
        }

        private void Exportar()
        {
            if (dgvDetalles.Rows.Count > 1)
            {
                int cont = 0;

                try
                {
                    LDConf = new List<ODetalleConformidad>();

                    for (int i = 0; i < dgvDetalles.Rows.Count - 1; i++)
                    {
                        if (Convert.ToBoolean(dgvDetalles["", i].Value))
                        {
                            ODetalleConformidad dconf = new ODetalleConformidad();

                            dconf.CodNota = CodNota;
                            dconf.NumNota = cboOpcion.Text + " " + txtNumNota.Text;
                            dconf.ProductoID = Convert.ToInt32(dgvDetalles["Cod. Item", i].Value);
                            dconf.Cantidad = Convert.ToDecimal(dgvDetalles["Cantidad", i].Value);
                            dconf.NomProd = dgvDetalles["Detalle", i].Value.ToString();
                            dconf.UnidMedida = dgvDetalles["Unid. Medida", i].Value.ToString();

                            LDConf.Add(dconf);

                            cont++;
                        }
                    }
                }
                catch
                { }
                finally
                {
                    if (cont > 0)
                    {
                        IAgregaConformidad parent = this.Owner as IAgregaConformidad;
                        parent.AgregaConformidad(LDConf);

                        this.Close();
                    }
                }
            }
        }

        #endregion

        #region Eventos Formulario

        private void cboOpcion_SelectedValueChanged(object sender, EventArgs e)
        {
            CambiarColorForm();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarNotas();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelecTodo();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            Invertir();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetalles["Cod. Item", e.RowIndex].Value.ToString() == "")
                {
                    dgvDetalles["", e.RowIndex].Value = false;
                }
            }
            catch
            {
                dgvDetalles["", e.RowIndex].Value = false;
            }
        }

        private void BusqNotas_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            NombreColumnas();
            ListarSuc();
            cboOpcion.Text = "NR";

            op.CerrarCargando();
        }

        private void txtNumNota_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                BuscarNotas();
        }

        #endregion
    }
}

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
using System.IO;

namespace GRTechnology1._0
{
    public partial class ControlChequera : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<ODetallePago> LCheqPen = null;
        List<ODetallePago> LCheqCob = null;


        string Opcion = string.Empty;
        string CodPago = string.Empty;
        string NumCheque = string.Empty;
        string CodInmode = string.Empty;

        public ControlChequera()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void NombreColumnasChequesPendientes()
        {
            dgvChequesPendientes.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "CodPago";
            c0.Visible = false;
            dgvChequesPendientes.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Fecha Emision";
            c1.Width = 100;
            dgvChequesPendientes.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Fecha Cobro";
            c2.Width = 100;
            dgvChequesPendientes.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Num. Cheque";
            c3.Width = 100;
            dgvChequesPendientes.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Cod. Cuenta";
            c4.Width = 100;
            dgvChequesPendientes.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Banco";
            c5.Width = 150;
            dgvChequesPendientes.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Referencia";
            c6.Width = 100;
            dgvChequesPendientes.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Monto Bs.-";
            c7.Width = 90;
            dgvChequesPendientes.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Monto Sus";
            c8.Width = 90;
            dgvChequesPendientes.Columns.Add(c8);
        }

        private void NombreColumnasChequesCobrados()
        {
            dgvChequeCobrados.Columns.Clear();

            DataGridViewTextBoxColumn c0 = new DataGridViewTextBoxColumn();
            c0.Name = "CodPago";
            c0.Visible = false;
            dgvChequeCobrados.Columns.Add(c0);

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.Name = "Fecha Emision";
            c1.Width = 100;
            dgvChequeCobrados.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.Name = "Fecha Cobro";
            c2.Width = 100;
            dgvChequeCobrados.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.Name = "Fecha Cobrado";
            c3.Width = 100;
            dgvChequeCobrados.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.Name = "Num. Cheque";
            c4.Width = 100;
            dgvChequeCobrados.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.Name = "Cod. Cuenta";
            c5.Width = 100;
            dgvChequeCobrados.Columns.Add(c5);

            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            c6.Name = "Banco";
            c6.Width = 150;
            dgvChequeCobrados.Columns.Add(c6);

            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            c7.Name = "Referencia";
            c7.Width = 100;
            dgvChequeCobrados.Columns.Add(c7);

            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            c8.Name = "Monto Bs.-";
            c8.Width = 90;
            dgvChequeCobrados.Columns.Add(c8);

            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
            c9.Name = "Monto Sus";
            c9.Width = 90;
            dgvChequeCobrados.Columns.Add(c9);
        }


        #endregion

        #region Conexion Capa de Negocios

        private void ListarChequesPendientes()
        {
            try
            {
                LCheqPen = NMovimientoCheque.NListarCheqPen();
                CargarChequesPendientes(LCheqPen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnasChequesPendientes();
            }
        }

        private void ListarChequesCobrados()
        {
            try
            {
                LCheqCob = NMovimientoCheque.NListarCheqCobr(dtFechaCheqCobr.Value);
                CargarChequesCobrados(LCheqCob);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreColumnasChequesCobrados();
            }
        }

        private void Cobrado(int fila)
        {
            try
            {
                CodPago = dgvChequesPendientes["CodPago", fila].Value.ToString();
                NumCheque = dgvChequesPendientes["Num. Cheque", fila].Value.ToString();

                DialogResult dialogo = MessageBox.Show("¿Seguro que ya se Cobro el Cheque Numero " + NumCheque + "?", "Cheque Cobrado",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(dialogo == DialogResult.Yes)
                {
                    OInmode inm=new OInmode();
                    inm.CodInmode=CodInmode;
                    inm.TipoInmode = "Cobrado";
                    inm.UsuarioID = OConexionGlobal.UsuarioID;
                    inm.NomInmode = OConexionGlobal.NomPer;
                    inm.IPInmode=op.SaberIP();
                    inm.MacInmode=op.SaberMac();
                    inm.MaquinaInmode=op.SaberNomMaquina();
                    inm.SistOperInmode=op.SaberSistemOper();

                    int resp = NMovimientoCheque.NChequeCobrado(CodPago, inm);
                    if(resp > 0)
                    {
                        MessageBox.Show("Los Datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        op.AbrirCargando("Cargando.....");

                        ListarChequesPendientes();
                        ListarChequesCobrados();
                    }
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

        private void AnularCheque(int fila)
        {
            try
            {
                string CodPago = dgvChequesPendientes["CodPago", fila].Value.ToString();
                string NumCheque = dgvChequesPendientes["Num. Cheque", fila].Value.ToString();

                DialogResult dialogo = MessageBox.Show("¿Seguro que desea Anular el Cheque No. " + NumCheque + "?", "Anular",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogo == DialogResult.Yes)
                {

                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifCheque()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarChequesPendientes(List<ODetallePago> lcheqpen)
        {
            if(lcheqpen != null)
            {
                NombreColumnasChequesPendientes();

                foreach (var item in lcheqpen)
                {
                    dgvChequesPendientes.Rows.Add(item.CodPago, item.FecEmision.ToShortDateString(), item.FecCobro.ToShortDateString(), 
                                                  item.NumCheque, item.NomBanco, item.Referencia, 
                                                  string.Format("{0:#,##0.00}", item.MontoPagoBs), string.Format("{0:#,##0.00}", item.MontoPagoSus));
                }
                dgvChequesPendientes.Refresh();
            }
            else
            {
                NombreColumnasChequesPendientes();
            }
        }

        private void CargarChequesCobrados(List<ODetallePago> lcheqcob)
        {
            if(lcheqcob != null)
            {
                NombreColumnasChequesCobrados();

                int cont = 0;
                foreach (var item in lcheqcob)
                {
                    dgvChequeCobrados.Rows.Add("codpago", item.FecEmision.ToShortDateString(), item.FecCobro.ToShortDateString(), 
                                               item.FecCobrado.ToShortDateString(), item.NumCheque, "", item.NomBanco, item.Referencia,
                                               string.Format("{0:#,##0.00}", item.MontoPagoBs), string.Format("{0:#,##0.00}", item.MontoPagoSus));

                    if(item.Estado == "A")
                        dgvChequeCobrados.Rows[cont].DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    cont++;
                }
                dgvChequeCobrados.Refresh();
            }
            else
            {
                NombreColumnasChequesCobrados();
            }
        }

        private void BuscarChequesCobrados()
        {
            if((LCheqCob != null)&&(txtBuscador.Text != string.Empty))
            {
                List<ODetallePago> lbusqcheqcob = LCheqCob.FindAll(x => x.NumCheque.Contains(txtBuscador.Text));
                CargarChequesCobrados(lbusqcheqcob);
            }
            else
            {
                CargarChequesCobrados(LCheqCob);
            }
        }

        #endregion

        #region Funciones

        

        #endregion

        #region Eventos Formulario

        private void ControlChequera_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando.....");

            ListarChequesPendientes();
            ListarChequesCobrados();

            op.CerrarCargando();
        }

        private void dgvChequesPendientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //SeleccionarCheqPen(e);
        }

        private void dgvChequeCobrados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //SeleccionarCheqCobr(e);
        }

        private void ControlChequera_FormClosing(object sender, FormClosingEventArgs e)
        {
        }       

        private void dgvChequesPendientes_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenuStrip mi_menu = new ContextMenuStrip();
                int posicionmouse = dgvChequesPendientes.HitTest(e.X, e.Y).RowIndex;

                if(posicionmouse >= 0)
                {
                    mi_menu.Items.Add("Cheque Cobrado").Name = "Cobrado";
                    mi_menu.Items.Add("Anular Cheque").Name = "Anular";
                    mi_menu.Items.Add("Ver Imagen").Name = "Imagen";
                }

                mi_menu.Show(dgvChequesPendientes, new Point(e.X, e.Y));

                mi_menu.ItemClicked += new ToolStripItemClickedEventHandler(mi_menu_ItemClicked);
            }
        }

        private void mi_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (LCheqPen != null)
            {
                switch (e.ClickedItem.Name)
                {
                    case "Anular":
                        AnularCheque(dgvChequesPendientes.CurrentRow.Index);
                        break;
                    case "Cobrado":
                        Cobrado(dgvChequesPendientes.CurrentRow.Index);
                        break;
                    case "Imagen":
                        break;
                }
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarChequesCobrados();
        }

        #endregion
    }
}

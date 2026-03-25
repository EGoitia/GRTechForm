using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using Objetos;
using Datos;
using System.Drawing;

namespace GRTechnology1._0
{
    public partial class Frm_KardexCliProv : Form
    {
        public static Frm_KardexCliProv kcli = null;
        public static Frm_KardexCliProv kprov = null;
        public bool EsCliente = true;

        private DataTable KardexCliProvDT = null;

        public Frm_KardexCliProv()
        {
            InitializeComponent();
        }

        #region Configuracion de Formulario

        private void NombreColumnas()
        {
            dgvKardexCliProv.Columns["ID"].Visible = false;
            dgvKardexCliProv.Columns["SucursalID"].Visible = false;
            dgvKardexCliProv.Columns["CodNota"].Visible = false;

            dgvKardexCliProv.Columns["NumNota"].HeaderText = "Nº Nota";
            dgvKardexCliProv.Columns["NomSuc"].HeaderText = "Sucursal";
            dgvKardexCliProv.Columns["Observacion"].HeaderText = "Observación";

            dgvKardexCliProv.Columns["NumNota"].FillWeight = 60;
            dgvKardexCliProv.Columns["Fecha"].FillWeight = 90;
            dgvKardexCliProv.Columns["NomSuc"].FillWeight = 120;
            dgvKardexCliProv.Columns["Entrada"].FillWeight = 80;
            dgvKardexCliProv.Columns["Salida"].FillWeight = 80;
            dgvKardexCliProv.Columns["Saldo"].FillWeight = 80;
            dgvKardexCliProv.Columns["Detalle"].FillWeight = 300;
            dgvKardexCliProv.Columns["Observacion"].FillWeight = 200;

            dgvKardexCliProv.Columns["Entrada"].DefaultCellStyle.Format = "N2";
            dgvKardexCliProv.Columns["Salida"].DefaultCellStyle.Format = "N2";
            dgvKardexCliProv.Columns["Saldo"].DefaultCellStyle.Format = "N2";

            dgvKardexCliProv.Columns["Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKardexCliProv.Columns["Salida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvKardexCliProv.Columns["Saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarSuc()
        {
            try
            {
                List<OSucursal> LSuc = DSucursal.DListarSucursales().OrderBy(x => x.NomSuc).ToList();

                cboSuc.DataSource = LSuc;
                cboSuc.DisplayMember = "NomSuc";
                cboSuc.ValueMember = "SucursalID";
                cboSuc.Refresh();

                cboSuc.Text = OConexionGlobal.NomSuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos Formulario

        private void KardexCli_Load(object sender, EventArgs e)
        {
            if (!EsCliente)
            {
                this.Text = "KARDEX PROVEEDOR";
                lblCliProv.Text = "Proveedor:";
                txtNombre.Text = DListarPersonalizado.Dato("SELECT NomProv FROM Proveedor WHERE ProveedorID=1").ToString();
            }

            ListarSuc();

            btnProc.PerformClick();
            NombreColumnas();
        }
        
        private void KardexCli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kcli != null)
            {
                kcli.Dispose();
                kcli = null;
            }
            else
            {
                kprov.Dispose();
                kprov = null;
            }
        }

        private void btnBusqCliProv_Click(object sender, EventArgs e)
        {
            Buscadores.Buscador bcliprov = new Buscadores.Buscador();
            bcliprov.Owner = this;
            bcliprov.Opcion = (this.EsCliente ? "Cliente" : "Proveedor");
            bcliprov.ShowDialog();

            if (bcliprov.Seleccionado)
            {
                txtID.Text = bcliprov.dgvDatos["ID", bcliprov.dgvDatos.CurrentRow.Index].Value.ToString();
                txtNombre.Text = bcliprov.dgvDatos["Nombre", bcliprov.dgvDatos.CurrentRow.Index].Value.ToString();
            }
            
            bcliprov.Dispose();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            decimal saldo = 0, entrada = 0, salida = 0;
            try
            {
                KardexCliProvDT = DListarPersonalizado.ConsultarDT("SELECT ID, SucursalID, CodNota, NumNota, Fecha, Tipo, Entrada, Salida, Saldo, NomSuc, Detalle, Observacion " +
                    "FROM " + (EsCliente ? "Vista_KardexCli" : "Vista_KardexProv") + "  WHERE ID=" + txtID.Text + " ORDER BY Fecha");
                dgvKardexCliProv.DataSource = KardexCliProvDT;

                foreach (DataRow item in KardexCliProvDT.Rows)
                {
                    entrada += (decimal)item["Entrada"];
                    salida += (decimal)item["Salida"];
                    saldo += (decimal)item["Entrada"] - (decimal)item["Salida"];
                    item["Saldo"] = saldo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtTotEntrada.Text = string.Format("{0:#,##0.00}", entrada);
                txtTotSalida.Text = string.Format("{0:#,##0.00}", salida);
                txtTotSaldo.Text = string.Format("{0:#,##0.00}", saldo);
            }
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Imprimir()
        {
            if (dgvKardexCliProv.Rows.Count > 0)
            {
                DataRow filakardex;
                Frm_Reporte rep = new Frm_Reporte();
                rep.Dts.Clear();

                for (int i = 0; i < dgvKardexCliProv.Rows.Count; i++)
                {
                    filakardex = rep.Dts.Tables["Kardex_CliProv"].NewRow();
                    filakardex["ID"] = dgvKardexCliProv["ID", i].Value;
                    filakardex["SucursalID"] = dgvKardexCliProv["SucursalID", i].Value;
                    filakardex["CodNota"] = dgvKardexCliProv["CodNota", i].Value;
                    filakardex["NumNota"] = dgvKardexCliProv["NumNota", i].Value;
                    filakardex["Fecha"] = dgvKardexCliProv["Fecha", i].Value;
                    filakardex["Tipo"] = dgvKardexCliProv["Tipo", i].Value;
                    filakardex["Entrada"] = dgvKardexCliProv["Entrada", i].Value;
                    filakardex["Salida"] = dgvKardexCliProv["Salida", i].Value;
                    filakardex["Saldo"] = dgvKardexCliProv["Saldo", i].Value;
                    filakardex["NomSuc"] = dgvKardexCliProv["NomSuc", i].Value;
                    filakardex["Detalle"] = dgvKardexCliProv["Detalle", i].Value;
                    filakardex["Observacion"] = dgvKardexCliProv["Observacion", i].Value;

                    rep.Dts.Tables["Kardex_CliProv"].Rows.Add(filakardex);
                }

                rep.Titulo = "KARDEX DE " + (EsCliente ? "CLIENTE" : "PROVEEDOR");
                rep.Variable = txtNombre.Text;
                rep.Cargar("RptKardexCliProv", false);
                rep.Show();
            }
        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cboSuc.Enabled = chkSucursal.Checked;
        }

        private void dgvKardexCliProv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvKardexCliProv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }

        #endregion
    }
}

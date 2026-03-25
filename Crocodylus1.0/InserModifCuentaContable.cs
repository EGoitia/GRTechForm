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
    public partial class InserModifCuentaContable : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OCuentaCont> LCuenCont = null;
        OCuentaCont CCont = null;

        string Opcion = string.Empty;
        int CuentaContID = -1;

        public InserModifCuentaContable(string opcion, OCuentaCont ccont)
        {
            InitializeComponent();

            Opcion = opcion;
            CCont = ccont;
        }

        #region Conexion Capra de Negocio

        private void ListarCuentaCont()
        {
            try
            {
                LCuenCont = NCuentaCont.NListarCuentasCont().Where(x => x.TipoCuenta == "Matricial").OrderBy(x => x.CodCuenta).ToList();

                cboPadre.DataSource = LCuenCont;
                cboPadre.DisplayMember = "NomCuenta";
                cboPadre.ValueMember = "CodCuenta";
                cboPadre.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertModifCuentaCont()
        {
            try
            {
                OInmode inm = new OInmode();
                inm.IPInmode = op.SaberIP();
                inm.MacInmode = op.SaberMac();
                inm.MaquinaInmode = op.SaberNomMaquina();
                inm.SistOperInmode = op.SaberSistemOper();
                inm.NomInmode = OConexionGlobal.NomPer;
                inm.TipoInmode = Opcion;
                inm.UsuarioID = OConexionGlobal.UsuarioID;

                CCont = new OCuentaCont();
                if(Opcion == "Nuevo")
                {
                    CCont.CuentaContID = -1;
                }
                else
                {
                    CCont.CuentaContID = CuentaContID;

                    Frm_DetaModifAnul dmod = new Frm_DetaModifAnul("Modificar");
                    dmod.Owner = this;
                    dmod.ShowDialog();
                    inm.DetalleInmode = dmod.DetaModAnul();
                }

                CCont.PadreCuenta = cboPadre.SelectedValue.ToString();
                CCont.NomCuenta = txtNomCuenta.Text;
                CCont.Moneda = cboMoneda.Text;
                CCont.TipoCuenta = cboTipoCuenta.Text;
                CCont.Detalle = txtDetalle.Text;

                int resp = NCuentaCont.NInsertModifCuentaCont(CCont, inm);
                if(resp > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarDatos()
        {
            try
            {
                CuentaContID = CCont.CuentaContID;
                cboPadre.SelectedValue = CCont.PadreCuenta;
                txtNomCuenta.Text = CCont.NomCuenta;
                cboMoneda.Text = CCont.Moneda;
                cboTipoCuenta.Text = CCont.TipoCuenta;
                txtDetalle.Text = CCont.Detalle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos Formulario

        private void InserModifCuentaContable_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando....");

            ListarCuentaCont();

            if (Opcion == "Modificar")
                CargarDatos();
            else
            {
                cboMoneda.Text = "Bolivianos";
                cboTipoCuenta.Text = "Analitica";
            }

            op.CerrarCargando();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertModifCuentaCont();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}

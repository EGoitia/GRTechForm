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

namespace GRTechnology1._0.OpcioRep
{
    public partial class OpRepSaldoInvFisicoValoradoActivosFijos : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        List<OGrupoActivos> LGActFij = null;
        List<OTipoActivo> LTipoActFij = null;

        public OpRepSaldoInvFisicoValoradoActivosFijos()
        {
            InitializeComponent();
        }

        #region Configuracion Formulario

        private void HabilitarCont()
        {
        }

        #endregion

        #region Conexion Capa Negocio

        private void ListarGrupoActFij()
        {
            try
            {
                LGActFij = NGrupoActivosFijos.NListarGrupActFij().OrderBy(x => x.NomGrupo).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarTipoActFijo()
        {
            try
            {
                LTipoActFij = NTipoActivo.NListarTipoActivo().OrderBy(x => x.NomTipoActivo).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarSucursal()
        {
            try
            {
                List<OSucursal> lsuc = NSucursal.NListarSucursales().OrderBy(x => x.NomSuc).ToList();
                cboOpcionBusq.DataSource = lsuc;
                cboOpcionBusq.DisplayMember = "NomSuc";
                cboOpcionBusq.ValueMember = "SucursalID";
                cboOpcionBusq.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Cargar Datos

        private void CargarGrupoActFijo()
        {
            cboOpcion.DataSource = LGActFij;
            cboOpcion.DisplayMember = "NomGrupo";
            cboOpcion.ValueMember = "GrupoActivoID";
            cboOpcion.Refresh();
        }

        private void CargarTipoActFijo()
        {
            cboOpcion.DataSource = LTipoActFij;
            cboOpcion.DisplayMember = "NomTipoActivo";
            cboOpcion.ValueMember = "TipoActivoID";
            cboOpcion.Refresh();
        }

        #endregion

        #region Eventos Formulario

        private void OpRepSaldoInvFisicoValoradoActivosFijos_Load(object sender, EventArgs e)
        {
            op.AbrirCargando("Cargando...");

            ListarGrupoActFij();
            ListarTipoActFijo();
            ListarSucursal();

            cboBusqX.Text = "TOTALES";
            cboBusqEn.Text = "Sucursal";

            op.CerrarCargando();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Reportes.RepSaldoInvFisicoValoradoActFij invact = new Reportes.RepSaldoInvFisicoValoradoActFij(cboOpcion.Text, Convert.ToInt32(cboOpcionBusq.SelectedValue),
            //                                                                        cboOpcionBusq.Text, cboBusqEn.Text, Convert.ToInt32(cboBusqX.SelectedValue),
            //                                                                        cboBusqX.Text, dtFecha.Value, rbValor.Checked);
            //}
            //catch (Exception)
            //{    }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            op.AbrirCargando("Actualizando....");

            ListarGrupoActFij();
            ListarTipoActFijo();
            ListarSucursal();

            op.CerrarCargando();
        }

        private void cboBusqX_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cboBusqX.Text)
            {
                case "TIPO ACTIVOS FIJOS":
                    cboOpcion.Enabled = true;
                    lblOpcion.Text = "Tipo Activo..........";
                    CargarTipoActFijo();
                    break;
                case "GRUPO ACTIVOS FIJOS":
                    cboOpcion.Enabled = true;
                    lblOpcion.Text = "Grupo...............";
                    CargarGrupoActFijo();
                    break;
                case "TOTALES":
                    cboOpcion.Enabled = false;
                    break;
            }
        }

        private void cboBusqEn_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cboBusqEn.Text)
            {
                case "Sucursal":
                    cboOpcionBusq.Enabled = true;
                    break;
                case "Empresa":
                    cboOpcionBusq.Enabled = false;
                    break;
            }
        }

        private void OpRepSaldoInvFisicoValoradoActivosFijos_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #endregion
    }
}

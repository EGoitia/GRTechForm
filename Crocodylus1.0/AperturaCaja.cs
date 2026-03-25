using System;
using System.Windows.Forms;
using Objetos;
using Datos;
using System.Data;

namespace GRTechnology1._0
{
    public partial class AperturaCaja : Form
    {        
        public AperturaCaja()
        {
            InitializeComponent();
        }

        #region Config Formulario

        private void HabilitarCont()
        {
            
        }

        #endregion

        #region Conexion Capa Negocios

        private void ListarCajas()
        {
            try
            {
                cboCaja.DataSource = DListarPersonalizado.ConsultarDT("SELECT CajaID, NomCaja FROM Vista_Cajas_Usuario WHERE UsuarioID=" + OConexionGlobal.UsuarioID);
                cboCaja.DisplayMember = "NomCaja";
                cboCaja.ValueMember = "CajaID";
                cboCaja.Refresh();            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarInicioCajaUsuario()
        {
            try
            {
                DataTable dt = DInicioCaja.ObtenerIniCajaUsuarioSucursal();
                if (dt.Rows.Count > 0)
                {
                    btnAbrir.Enabled = false;
                    numUpDownBsIni.Enabled = false;

                    numUpDownBsIni.Value = Convert.ToDecimal(dt.Rows[0]["Monto"]);
                    lblFecha.Text = dt.Rows[0]["Fecha"].ToString();
                }
                else
                {
                    btnAbrir.Enabled = true;
                    numUpDownBsIni.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertInicioCaja()
        {
            try
            {
                OInicioCaja ini = new OInicioCaja();

                if (DInicioCaja.TieneInicioCajaUsuarioSucursal())
                {
                    MessageBox.Show("YA SE REALIZO EL INICIO DE CAJA!", "INICIO DE CAJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ini.SucursalID = OConexionGlobal.SucursalID;
                ini.UsuarioID = OConexionGlobal.UsuarioID;
                ini.CajaID = Convert.ToInt32(cboCaja.SelectedValue);
                ini.Monto = numUpDownBsIni.Value;

                int resp = DInicioCaja.InsertModif_InicioCaja(OInmode.DTInmode("", "NUEVO", ""), ini);
                if (resp > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        #endregion

        #region Eventos Formulario

        private void AperturaCaja_Load(object sender, EventArgs e)
        {
            ListarCajas();
            HabilitarCont();
            VerificarInicioCajaUsuario();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            InsertInicioCaja();
        }

        private void AperturaCaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ListarCajas();
        }

        #endregion

        private void cboCaja_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VerificarInicioCajaUsuario();
        }
    }
}

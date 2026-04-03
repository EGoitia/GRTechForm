using System;
using System.Windows.Forms;
using System.Configuration;
using Objetos;
using Datos;
using System.Data;
using System.Threading;
using System.Management;

namespace GRTechnology1._0
{
    public partial class Frm_Login : Form
    {
        OpcionFormularios op = new OpcionFormularios();

        int intentos = 0;
        string serv = string.Empty;
        DataTable DTSuc = null;

        public Frm_Login()
        {
            InitializeComponent();

            this.Opacity = 0.83;
        }

        private bool Config_Regional()
        {
            string sepa_dec, sep_mil, sepa_dec_m, sep_mil_m, idioma;
            System.Globalization.DateTimeFormatInfo fecha_hora;
            
            idioma = Thread.CurrentThread.CurrentCulture.EnglishName;
            sepa_dec = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            sep_mil = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator;
            sepa_dec_m = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            sep_mil_m = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator;
            fecha_hora = Thread.CurrentThread.CurrentCulture.DateTimeFormat;

            if (idioma != "Spanish (Spain)" && idioma != "Spanish (Spain, International Sort)")
                return false;
            else if (sepa_dec != "." || sepa_dec_m != ".")
                return false;
            else if (sep_mil != "," || sep_mil_m != ",")
                return false;
            else if (fecha_hora.ShortDatePattern != "dd/MM/yyyy")
                return false;
            else if (fecha_hora.ShortTimePattern != "HH:mm" && fecha_hora.ShortTimePattern != "H:mm")
                return false;

            return true;
        }

        private void EntrarSistema()
        {
            if (cboSuc.Text != string.Empty)
            {
                DataRow[] DRSuc = DTSuc.Select("SucursalID=" + cboSuc.SelectedValue);

                OConexionGlobal.SucursalID = Convert.ToInt32(DRSuc[0]["SucursalID"]);
                OConexionGlobal.NomSuc = DRSuc[0]["NomSuc"].ToString();
                OConexionGlobal.Ciudad = DRSuc[0]["Ciudad"].ToString();
                OConexionGlobal.Direccion = DRSuc[0]["Direccion"].ToString();
                OConexionGlobal.Telf = DRSuc[0]["Telf"].ToString();
                              
                Frm_Principal prin = new Frm_Principal();
                prin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ESTE USUARIO NO TIENE NINGUNA SUCURSAL ASIGNADA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
          
        private bool Verificar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Focus();
                MessageBox.Show("USUARIO INVÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                txtContrasenia.Focus();
                MessageBox.Show("CONTRASEÑA INVÁLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if(!OpcionFormularios.VerConexion(serv))
            {
                MessageBox.Show("NO SE PUEDE CONECTAR CON EL SERVIDOR", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Conectar()
        {
            if (!Verificar())
                return;

            try
            {
                Encriptar enc = new Encriptar(txtContrasenia.Text.ToString());
                DTSuc = DUsuario.DConectarse(txtNombre.Text, enc.Encriptador(), "", "", "");

                if (DTSuc.Rows.Count > 0)
                {
                    txtNombre.Enabled = false;
                    txtContrasenia.Enabled = false;

                    btnEntrar.Text = "Entrar";
                    panelSuc.Visible = true;
                    
                    cboSuc.DataSource = DTSuc;
                    cboSuc.DisplayMember = "NomSuc";
                    cboSuc.ValueMember = "SucursalID";
                    cboSuc.Refresh();
                    cboSuc.Focus();

                    if (DTSuc.Rows.Count == 1)
                        EntrarSistema();
                    else
                        cboSuc.Focus();
                }
                else
                    throw new Exception("NOMBRE O CONTRASEÑA INVÁLIDO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Clear();
                txtContrasenia.Clear();
                txtNombre.Focus();
                panelSuc.Visible = false;

                if (intentos > 2)
                {
                    MessageBox.Show("EL NÚMERO DE INTENTOS SOBREPASÓ EL LÍMITE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                intentos++;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!Config_Regional())
            {
                Frm_ConfigRegional conf = new Frm_ConfigRegional();
                conf.ShowDialog();
                conf.Dispose();

                Application.Exit();
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            cboSuc.Items.Add(ConfigurationManager.AppSettings["Nombre"]);

            cboSuc.Text = ConfigurationManager.AppSettings["Nombre"];
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (panelSuc.Visible)
                EntrarSistema();
            else
                Conectar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (panelSuc.Visible)
            {
                txtNombre.Enabled = true;
                txtContrasenia.Enabled = true;
                txtNombre.Clear();
                txtContrasenia.Clear();
                panelSuc.Visible = false;
            }
            else
                Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                SendKeys.Send("+{TAB}");
            }
            else if (e.KeyCode == Keys.F2)
            {
                Conexion con = new Conexion();
                con.Owner = this;
                con.ShowDialog();
                con.Dispose();
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ent;
            ent = Convert.ToChar(Keys.Enter);

            if (e.KeyChar == ent)
            {
                if (txtContrasenia.Focused)
                {
                    Verificar();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                    e.Handled = true;
                }
            }
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEntrar.PerformClick();
        }

        private void cboSuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEntrar.PerformClick();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace GRTechnology1._0
{
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
        }

        private void Conectar()
        {
            this.Cursor = Cursors.WaitCursor;

            pbImg.Visible = false;
            lblMessOK.Visible = false;
            lblMessMal.Visible = false;

            btnAcep.Enabled = false;

            int result = Validar(txtServ.Text.ToString(), txtPuerto.Text.ToString(), txtBD.Text.ToString(),
                                    txtUser.Text.ToString(), txtPass.Text.ToString());

            if (result == 1)
            {
                pbImg.Visible = true;
                lblMessOK.Visible = true;
                btnAcep.Enabled = true;
            }
            else
            {
                lblMessMal.Visible = true;
            }

            this.Cursor = Cursors.Default;
        }

        private void Aceptar()
        {
            try
            {
                Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                ConnectionStringsSection css = conf.ConnectionStrings;

                string cadena = string.Empty;

                if (txtServ.Text == string.Empty)
                {
                    css.ConnectionStrings[cboConn.Text].ConnectionString =
                    "Data Source=" + txtServ.Text.ToString() + ";Initial Catalog=" + txtBD.Text.ToString() + ";Integrated Security=True";
                }
                else
                {
                    css.ConnectionStrings[cboConn.Text].ConnectionString =
                    //"Data Source=" + txtServ.Text.ToString() + "," + txtPuerto.Text.ToString() + ";Network Library=DBMSSOCN;Initial Catalog=" + txtBD.Text.ToString() + ";User Id=" + txtUser.Text.ToString() + ";Password=" + txtPass.Text.ToString();
                     "Data Source=" + txtServ.Text + ";Initial Catalog=" + txtBD.Text + ";Persist Security Info=True;User ID=" + txtUser.Text + ";Password=" + txtPass.Text;
                }

                conf.Save();

                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                switch (cboConn.Text)
                {
                    case "Comercial":
                        config.AppSettings.Settings["Serv"].Value = txtServ.Text;
                        config.AppSettings.Settings["Puert"].Value = txtPuerto.Text;
                        config.AppSettings.Settings["DB"].Value = txtBD.Text;
                        config.AppSettings.Settings["Usu"].Value = txtUser.Text;
                        config.AppSettings.Settings["Contr"].Value = txtPass.Text;
                        break;
                    //case "Decoralia":
                    //    config.AppSettings.Settings["Serv1"].Value = txtServ.Text;
                    //    config.AppSettings.Settings["Puert1"].Value = txtPuerto.Text;
                    //    config.AppSettings.Settings["DB1"].Value = txtBD.Text;
                    //    config.AppSettings.Settings["Usu1"].Value = txtUser.Text;
                    //    config.AppSettings.Settings["Contr1"].Value = txtPass.Text;
                    //    break;
                    //case "Decoralia2":
                    //    config.AppSettings.Settings["Serv2"].Value = txtServ.Text;
                    //    config.AppSettings.Settings["Puert2"].Value = txtPuerto.Text;
                    //    config.AppSettings.Settings["DB2"].Value = txtBD.Text;
                    //    config.AppSettings.Settings["Usu2"].Value = txtUser.Text;
                    //    config.AppSettings.Settings["Contr2"].Value = txtPass.Text;
                    //    break;
                }

                config.Save(ConfigurationSaveMode.Modified);


                MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("EL SISTEMA SE VA A CERRAR PARA QUE LOS CAMBIOS TENGAN EFECTO", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int Validar(string server, string puerto, string bd, string user, string pass)
        {
            string cadena = string.Empty;

            if (server == string.Empty)
            {
                cadena = "Data Source=" + server + ";Initial Catalog=" + bd + ";Integrated Security=True";
            }
            else
            {
                cadena = @"Data Source=" + server + ";Initial Catalog=" + bd + ";Persist Security Info=True;User ID=" + user + ";Password=" + pass;
                //cadena = "Data Source=" + server + "," + puerto + ";Network Library=DBMSSOCN;Initial Catalog=" + bd + ";User Id=" + user + ";Password=" + pass;
            }


            using (SqlConnection miCon = new
                SqlConnection(cadena))
            {
                try
                {
                    miCon.Open();

                    return 1;
                }
                catch
                {
                    return 0;
                }
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Conexion_Load(object sender, EventArgs e)
        {
            cboConn.Text = "Comercial";
            lblMessOK.Visible = false;
            lblMessMal.Visible = false;
            pbImg.Visible = false;
            btnAcep.Enabled = false;
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void cboConn_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cboConn.Text)
            {
                case "Comercial":
                    txtServ.Text = ConfigurationManager.AppSettings["Serv"];
                    txtPuerto.Text = ConfigurationManager.AppSettings["Puert"];
                    txtBD.Text = ConfigurationManager.AppSettings["DB"];
                    txtUser.Text = ConfigurationManager.AppSettings["Usu"];
                    txtPass.Text = ConfigurationManager.AppSettings["Contr"];
                    break;
                case "Local":
                    txtServ.Text = ConfigurationManager.AppSettings["Serv1"];
                    txtPuerto.Text = ConfigurationManager.AppSettings["Puert1"];
                    txtBD.Text = ConfigurationManager.AppSettings["DB1"];
                    txtUser.Text = ConfigurationManager.AppSettings["Usu1"];
                    txtPass.Text = ConfigurationManager.AppSettings["Contr1"];
                    break;
                //case "Decoralia2":
                //    txtServ.Text = ConfigurationManager.AppSettings["Serv2"];
                //    txtPuerto.Text = ConfigurationManager.AppSettings["Puert2"];
                //    txtBD.Text = ConfigurationManager.AppSettings["DB2"];
                //    txtUser.Text = ConfigurationManager.AppSettings["Usu2"];
                //    txtPass.Text = ConfigurationManager.AppSettings["Contr2"];
                //    break;
                //case "Conn3":
                //    txtServ.Text = ConfigurationManager.AppSettings["Serv3"];
                //    txtPuerto.Text = ConfigurationManager.AppSettings["Puert3"];
                //    txtBD.Text = ConfigurationManager.AppSettings["DB3"];
                //    txtUser.Text = ConfigurationManager.AppSettings["Usu3"];
                //    txtPass.Text = ConfigurationManager.AppSettings["Contr3"];
                //    break;
            }
        }
    }
}

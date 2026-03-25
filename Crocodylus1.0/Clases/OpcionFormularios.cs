using Objetos;
using System;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GRTechnology1._0
{
    public class OpcionFormularios
    {
        public void AbrirCargando(string msje)
        {
            Frm_Principal cr = new Frm_Principal();
            cr.Cursor = Cursors.WaitCursor;
        }

        public void CerrarCargando()
        {
            //el cursor x defecto
            Frm_Principal cr = new Frm_Principal();
            cr.Cursor = Cursors.Default;
        }

        public void BorrarCampos(GroupBox gbox, string param)
        {
            // Checar todos los textbox del formulario
            foreach (var txt in gbox.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Text = param;
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Text = param;
                }
                else if(txt is NumericUpDown)
                {
                    ((NumericUpDown)txt).Value = ((NumericUpDown)txt).Minimum;
                }
            }
        }

        public static void HabilitarCont(GroupBox gbox, int padreid)
        {
            //habilitamos controles segun la DB
            foreach (Control controlhijo in gbox.Controls)
            {
                //por parametro el nombre del hijo y el codigo del padre
                if (!ODetalleRolUsuario.HabilDesabil(controlhijo.Name, padreid))
                {
                    if (controlhijo is Button)
                        ((Button)controlhijo).Enabled = false;
                    else if (controlhijo is TextBox)
                        ((TextBox)controlhijo).Enabled = false;
                    else if (controlhijo is ComboBox)
                        ((ComboBox)controlhijo).Enabled = false;
                    else if (controlhijo is CheckBox)
                        ((CheckBox)controlhijo).Enabled = false;
                    else if (controlhijo is RadioButton)
                        ((RadioButton)controlhijo).Enabled = false;
                    else if (controlhijo is DateTimePicker)
                        ((DateTimePicker)controlhijo).Enabled = false;
                }
            }
        }

        public static void HabilitarCampo(Control campo, int padreid)
        {
            bool estado = ODetalleRolUsuario.HabilDesabil(campo.Name, padreid);

            if (campo is Button)
                ((Button)campo).Enabled = estado;
            else if (campo is TextBox)
                ((TextBox)campo).Enabled = estado;
            else if (campo is ComboBox)
                ((ComboBox)campo).Enabled = estado;
            else if (campo is NumericUpDown)
                ((NumericUpDown)campo).Enabled = estado;
            else if (campo is RadioButton)
                ((RadioButton)campo).Enabled = estado;
            else if (campo is DateTimePicker)
                ((DateTimePicker)campo).Enabled = estado;
        }

        public string SaberNomMaquina()
        {
            // Get the hostname
            string myHost = Dns.GetHostName();

            // Show the hostname
            return myHost;
        }

        public string SaberIP()
        {
            string myHost = SaberNomMaquina();
            string myIPsString = "";

            IPHostEntry myIPs = Dns.GetHostEntry(myHost);

            // Loop through all IP addresses and display each
            foreach (IPAddress myIP in myIPs.AddressList)
            {
                myIPsString = myIPsString + myIP.ToString() + "   ";
            }

            return myIPsString;
        }

        public string SaberMac()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");

            ManagementObjectCollection moc = mc.GetInstances();

            string MiDireccionMAC = string.Empty;

            foreach (ManagementObject mo in moc)
            {

                if (MiDireccionMAC == string.Empty)
                {
                    // Solo retorno la direccion MAC para la primera tarjeta

                    if ((bool)mo["IPEnabled"] == true)
                    {

                        MiDireccionMAC = MiDireccionMAC + mo["MacAddress"].ToString() + "   ";

                    }

                    mo.Dispose(); // Libero Recursos

                }

            }

           // MiDireccionMAC = MiDireccionMAC.Replace(":", ":");

            return MiDireccionMAC;
        }

        public string SaberSistemOper()
        {
            OperatingSystem os = Environment.OSVersion;

            string sistoper = "";

            sistoper = os.VersionString.ToString();

            return sistoper;
        }

        public static bool VerConexion(string ip)
        {
            if (ip != string.Empty)
            {
                Ping Pings = new Ping();
                //IPStatus status;
                try
                {
                    if (Pings.Send(ip).Status == IPStatus.Success)
                        return true;
                    else
                        return false;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public static Object DesearializarObjeto(string XMLString, Object ClaseObjeto)
        {
            try
            {
                XMLString = "<?xml version=\"1.0\" encoding=\"utf-16\"?>" + XMLString;
                XmlSerializer serializer = new XmlSerializer(XMLString.GetType());

                ClaseObjeto = serializer.Deserialize(new StringReader(XMLString));
            }
            catch (Exception)
            { }

            return ClaseObjeto;
        }

        //public string SerializarInmode(string tipo, string detalleinmode, string codinmode)
        //{
        //    string retorno = string.Empty;
        //    var stringwriter = new System.IO.StringWriter();
        //    var serializer = new XmlSerializer(typeof(OInmode));

        //    try
        //    {
        //        //Cargamos el Objeto
        //        OInmode inm = new OInmode();
        //        inm.CodInmode = codinmode;
        //        inm.UsuarioID = OConexionGlobal.UsuarioID;
        //        inm.NomInmode = OConexionGlobal.NomPer;
        //        inm.TipoInmode = tipo;
        //        inm.IPInmode = SaberIP();
        //        inm.MacInmode = SaberMac();
        //        inm.MaquinaInmode = SaberNomMaquina();
        //        inm.SistOperInmode = SaberSistemOper();
        //        inm.DetalleInmode = detalleinmode;

        //        serializer.Serialize(stringwriter, inm);
        //    }
        //    catch (System.Xml.XmlException e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //    finally
        //    {
        //        retorno = stringwriter.ToString();
        //        retorno = retorno.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
        //    }

        //    return retorno;
        //}
    }
}

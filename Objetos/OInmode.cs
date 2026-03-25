using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;

namespace Objetos
{
    public class OInmode
    {
        public OInmode()
        { }


        public static DataTable DTInmode(string _codinm, string _tipo, string _detinm)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CodInmode");
            dt.Columns.Add("UsuarioID");
            dt.Columns.Add("TipoInmode");
            dt.Columns.Add("NomInmode");
            dt.Columns.Add("IPInmode");
            dt.Columns.Add("MacInmode");
            dt.Columns.Add("MaquinaInmode");
            dt.Columns.Add("SistOperInmode");
            dt.Columns.Add("NavegInmode");
            dt.Columns.Add("DetalleInmode");
            
            DataRow dr = dt.NewRow();
            dr["CodInmode"] = _codinm;
            dr["UsuarioID"] = OConexionGlobal.UsuarioID;
            dr["TipoInmode"] = _tipo;
            dr["NomInmode"] = OConexionGlobal.NomPer;
            dr["IPInmode"] = SaberIP();
            dr["MacInmode"] = SaberMac();
            dr["MaquinaInmode"] = SaberNomMaquina();
            dr["SistOperInmode"] = SaberSistemOper();
            dr["NavegInmode"] = "";
            dr["DetalleInmode"] = _detinm;
            dt.Rows.Add(dr);

            return dt;
        }

        private static string SaberNomMaquina()
        {
            // Get the hostname
            string myHost = Dns.GetHostName();

            // Show the hostname
            return myHost;
        }

        private static string SaberIP()
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

        private static string SaberMac()
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

        private static  string SaberSistemOper()
        {
            OperatingSystem os = Environment.OSVersion;

            string sistoper = "";

            sistoper = os.VersionString.ToString();

            return sistoper;
        }

        public string CodInmode { get; set; }
        public int UsuarioID { get; set; }
        public string NomUsu { get; set; }
        public string TipoInmode { get; set; }
        public string NomInmode { get; set; }
        public DateTime FechaInmode { get; set; }
        public string IPInmode { get; set; }
        public string MacInmode { get; set; }
        public string MaquinaInmode { get; set; }
        public string SistOperInmode { get; set; }

        private string navegInmode = string.Empty;

        public string NavegInmode
        {
            get { return navegInmode; }
            set { navegInmode = value; }
        }
        private string detalleInmode = string.Empty;

        public string DetalleInmode
        {
            get { return detalleInmode; }
            set { detalleInmode = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ORestriccionUsuario
    {
        private int restriccionID = -1;

        public int RestriccionID
        {
            get { return restriccionID; }
            set { restriccionID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private int usuarioID = -1;

        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }
        private string iPConexion = string.Empty;

        public string IPConexion
        {
            get { return iPConexion; }
            set { iPConexion = value; }
        }
        private string macConexion = string.Empty;

        public string MacConexion
        {
            get { return macConexion; }
            set { macConexion = value; }
        }
        private string maquinaConexion = string.Empty;

        public string MaquinaConexion
        {
            get { return maquinaConexion; }
            set { maquinaConexion = value; }
        }
        private string navegadorConexion = string.Empty;

        public string NavegadorConexion
        {
            get { return navegadorConexion; }
            set { navegadorConexion = value; }
        }
        private string sOConexion = string.Empty;

        public string SOConexion
        {
            get { return sOConexion; }
            set { sOConexion = value; }
        }
        private string observacion = string.Empty;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
    }
}

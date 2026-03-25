using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTipoUsuario
    {
        private int tipoUsuarioID = -1;

        public int TipoUsuarioID
        {
            get { return tipoUsuarioID; }
            set { tipoUsuarioID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomTipoUsuario = string.Empty;

        public string NomTipoUsuario
        {
            get { return nomTipoUsuario; }
            set { nomTipoUsuario = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

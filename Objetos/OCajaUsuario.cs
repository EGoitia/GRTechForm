using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OCajaUsuario
    {
        private int cajaID = -1;

        public int CajaID
        {
            get { return cajaID; }
            set { cajaID = value; }
        }
        private string nomCaja = string.Empty;

        public string NomCaja
        {
            get { return nomCaja; }
            set { nomCaja = value; }
        }

        private string tipoCaja = string.Empty;

        public string TipoCaja
        {
            get { return tipoCaja; }
            set { tipoCaja = value; }
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
        private bool principal = false;

        public bool Principal
        {
            get { return principal; }
            set { principal = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

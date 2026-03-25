using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OSucursal
    {
        private Int32 sucursalID = -1;

        public Int32 SucursalID
        {
            get { return sucursalID; }
            set { sucursalID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codUbicacion = string.Empty;

        public string CodUbicacion
        {
            get { return codUbicacion; }
            set { codUbicacion = value; }
        }
        private string nomSuc = string.Empty;

        public string NomSuc
        {
            get { return nomSuc; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new Exception("El Nombre de la Sucursal no puede estar Vacio");
                else
                    nomSuc = value; 
            }
        }
        private string nomEncSuc = string.Empty;

        public string NomEncSuc
        {
            get { return nomEncSuc; }
            set { nomEncSuc = value; }
        }
        private string telf = string.Empty;

        public string Telf
        {
            get { return telf; }
            set { telf = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OCargo
    {
        private Int32 cargoID = -1;

        public Int32 CargoID
        {
            get { return cargoID; }
            set { cargoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomCargo = string.Empty;

        public string NomCargo
        {
            get { return nomCargo; }
            set { nomCargo = value; }
        }
        private string detalleCargo = string.Empty;

        public string DetalleCargo
        {
            get { return detalleCargo; }
            set { detalleCargo = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

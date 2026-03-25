using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTipoVenta
    {
        private string nomTipoVenta = string.Empty;

        public string NomTipoVenta
        {
            get { return nomTipoVenta; }
            set { nomTipoVenta = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTipoIngSalProd
    {
        private int tipoIngSalProductoID = -1;

        public int TipoIngSalProductoID
        {
            get { return tipoIngSalProductoID; }
            set { tipoIngSalProductoID = value; }
        }
        private string nomTipoIngSalProducto = string.Empty;

        public string NomTipoIngSalProducto
        {
            get { return nomTipoIngSalProducto; }
            set { nomTipoIngSalProducto = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OPais
    {
        private int paisID = -1;

        public int PaisID
        {
            get { return paisID; }
            set { paisID = value; }
        }
        private string nomPais = string.Empty;

        public string NomPais
        {
            get { return nomPais; }
            set { nomPais = value; }
        }
        private string codPais = string.Empty;

        public string CodPais
        {
            get { return codPais; }
            set { codPais = value; }
        }
    }
}

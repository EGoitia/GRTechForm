using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OUbicacionCli
    {
        private Int32 ClienteID = -1;

        public Int32 ClienteID1
        {
            get { return ClienteID; }
            set { ClienteID = value; }
        }
        private string codUbicacion = string.Empty;

        public string CodUbicacion
        {
            get { return codUbicacion; }
            set { codUbicacion = value; }
        }
    }
}

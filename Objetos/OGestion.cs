using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OGestion
    {
        private int anioGestion = 2012;

        public int AnioGestion
        {
            get { return anioGestion; }
            set { anioGestion = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codAsiento = string.Empty;

        public string CodAsiento
        {
            get { return codAsiento; }
            set { codAsiento = value; }
        }
        private string observacion = string.Empty;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
    }
}

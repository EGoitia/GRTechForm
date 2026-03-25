using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ORubroSubRubro
    {
        private Int32 rubroSubRubroID = -1;

        public Int32 RubroSubRubroID
        {
            get { return rubroSubRubroID; }
            set { rubroSubRubroID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomRubroSubRubro = string.Empty;

        public string NomRubroSubRubro
        {
            get { return nomRubroSubRubro; }
            set { nomRubroSubRubro = value; }
        }
        private string tipo = string.Empty;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

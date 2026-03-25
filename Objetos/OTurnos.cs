using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTurnos
    {
        private int turnoID = -1;

        public int TurnoID
        {
            get { return turnoID; }
            set { turnoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomTurno = string.Empty;

        public string NomTurno
        {
            get { return nomTurno; }
            set { nomTurno = value; }
        }
        private string unidCiclo = string.Empty;

        public string UnidCiclo
        {
            get { return unidCiclo; }
            set { unidCiclo = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

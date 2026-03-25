using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetalleTurno:OHorario
    {
        private int turnoID = -1;

        public int TurnoID
        {
            get { return turnoID; }
            set { turnoID = value; }
        }
        private string nomDia = string.Empty;

        public string NomDia
        {
            get { return nomDia; }
            set { nomDia = value; }
        }
        private bool estadoDTurno = false;

        public bool EstadoDTurno
        {
            get { return estadoDTurno; }
            set { estadoDTurno = value; }
        }
    }
}

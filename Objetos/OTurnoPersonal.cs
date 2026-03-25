using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTurnoPersonal
    {
        private int personalID = -1;

        public int PersonalID
        {
            get { return personalID; }
            set { personalID = value; }
        }
        private string nomPer = string.Empty;

        public string NomPer
        {
            get { return nomPer; }
            set { nomPer = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private int turnoID = -1;

        public int TurnoID
        {
            get { return turnoID; }
            set { turnoID = value; }
        }
        private string nomTurno = string.Empty;

        public string NomTurno
        {
            get { return nomTurno; }
            set { nomTurno = value; }
        }
        private DateTime fecInicial = DateTime.Now;

        public DateTime FecInicial
        {
            get { return fecInicial; }
            set { fecInicial = value; }
        }
        private DateTime fecFinal = DateTime.Now;

        public DateTime FecFinal
        {
            get { return fecFinal; }
            set { fecFinal = value; }
        }
        private bool hrsExt = false;

        public bool HrsExt
        {
            get { return hrsExt; }
            set { hrsExt = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OComision
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
        private string comision = string.Empty;

        public string Comision
        {
            get { return comision; }
            set { comision = value; }
        }
        private decimal totMetros = 0;

        public decimal TotMetros
        {
            get { return totMetros; }
            set { totMetros = value; }
        }
        private decimal totBolsas = 0;

        public decimal TotBolsas
        {
            get { return totBolsas; }
            set { totBolsas = value; }
        }
        private decimal totPiezas = 0;

        public decimal TotPiezas
        {
            get { return totPiezas; }
            set { totPiezas = value; }
        }
        private decimal totVentas = 0;

        public decimal TotVentas
        {
            get { return totVentas; }
            set { totVentas = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OComparacionVentasCompras
    {
        private int nomMes = 1;

        public int NomMes
        {
            get { return nomMes; }
            set { nomMes = value; }
        }
        private decimal monto = 0;

        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public string Descripcion { get; set; }
    }
}

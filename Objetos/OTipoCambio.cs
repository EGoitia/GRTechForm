using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTipoCambio
    {
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private decimal tCCompra = 1;

        public decimal TCCompra
        {
            get { return tCCompra; }
            set { tCCompra = value; }
        }
        private decimal tCVenta = 1;

        public decimal TCVenta
        {
            get { return tCVenta; }
            set { tCVenta = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetalleCierreCaja
    {
        private string descripcion = string.Empty;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private decimal montoTotalBs = 0;

        public decimal MontoTotalBs
        {
            get { return montoTotalBs; }
            set { montoTotalBs = value; }
        }
        private decimal pagadoBs = 0;

        public decimal PagadoBs
        {
            get { return pagadoBs; }
            set { pagadoBs = value; }
        }
        private decimal pagadoSus = 0;

        public decimal PagadoSus
        {
            get { return pagadoSus; }
            set { pagadoSus = value; }
        }
    }
}

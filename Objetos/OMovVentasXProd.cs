using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OMovVentasXProd
    {
        public string NumVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoID { get; set; }
        public string NomProd { get; set; }
        public string UnidMedida { get; set; }
        public decimal PCosto { get; set; }
        public decimal PVenta { get; set; }
        public decimal Dscto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Utilidad { get; set; }
        public decimal CostoTot { get; set; }
        public decimal VentaTot { get; set; }

    }
}

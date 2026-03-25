using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OCierreCaja
    {
        public int CierreID { get; set; }
        public int InicioID { get; set; }
        public decimal EntregEfectivoBs { get; set; }
        public decimal EntregEfectivoSus { get; set; }
        public decimal EntregTarjetaBs { get; set; }
        public decimal EntregTransfBs { get; set; }
        public decimal EntregDeposBs { get; set; }
        public string Observaciones { get; set; }
        public string NomCajero { get; set; }
        public DateTime FecIni { get; set; }
        public DateTime FecFin { get; set; }
    }
}

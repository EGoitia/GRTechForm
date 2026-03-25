using System;

namespace Objetos
{
    public class ORecibo
    {
        public int ReciboID { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int RetencionID { get; set; }
        public decimal Monto { get; set; }
    }
}

using System;

namespace Objetos
{
    public class ODescuento_Promocional
    {
        public float Porcentaje { get; set; }
        public DateTime Fecha_Ini { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public int? SucursalID { get; set; }
    }
}

using System.Data;

namespace Objetos
{
    public class OCotizacion
    {
        public string CodCotizacion { get; set; }
        public int ClienteID { get; set; }
        public int AlmacenID { get; set; }
        public int VendedorID { get; set; }
        public int CondComID { get; set; }
        public decimal TC { get; set; }
        public decimal Monto { get; set; }
        public decimal Dscto { get; set; }
        public int DiasValidez { get; set; }
        public string Referencia { get; set; }
        public string Detalle { get; set; }
        public DataTable DetalleCotizacionDT { get; set; }
    }
}

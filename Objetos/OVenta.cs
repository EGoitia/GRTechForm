using System.Data;

namespace Objetos
{
    public class OVenta
    {
        public string CodVenta { get; set; }
        public string CodPedido { get; set; }
        public string CodCotizacion { get; set; }
        public int TipoVentaID { get; set; }
        public int ClienteID { get; set; }
        public int AlmacenID { get; set; }
        public int? VendedorID { get; set; }
        public string Referencia { get; set; }
        public decimal TC { get; set; }
        public decimal Monto { get; set; }
        public decimal Dscto { get; set; }
        public decimal Anticipo { get; set; }
        public string Detalle { get; set; }
        public DataTable DetalleVentaDT { get; set; }
        public DataTable DetallePagoDT { get; set; }
        public DataTable UbicacionDT { get; set; }
    }
}

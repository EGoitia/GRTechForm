using System.Data;

namespace Objetos
{
    public class OCompraProd
    {
        public string CodCompraProd { get; set; }
        public int ProveedorID { get; set; }
        public int TipoCompraID { get; set; }
        public int SucursalID { get; set; }
        public string Referencia { get; set; }
        public string Detalle { get; set; }
        public decimal TC { get; set; }
        public decimal MontoBs { get; set; }
        public decimal DsctoBs { get; set; }
        public bool Facturado { get; set; }
        public bool IngresoDirecto { get; set; }
        public DataTable Detalle_CompraDT { get; set; }
        public DataTable Detalle_FacturaDT { get; set; }
        public DataTable Detalle_ReciboDT { get; set; }
        public DataTable Detalle_GastosDT { get; set; }

    }
}

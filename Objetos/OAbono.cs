using System;
using System.Data;

namespace Objetos
{
    public class OAbono
    {
        public string CodAbono { get; set; }
        public string TipoAbono { get; set; }
        public int SucursalID { get; set; }
        public int CajaID { get; set; }
        public int ClienteID { get; set; }
        public string Referencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public decimal TC { get; set; }
        public decimal Dscto { get; set; }
        public decimal Monto { get; set; }
        public bool PagarConCaja { get; set; }
        public DataTable DetalleAbonoDT { get; set; }
        public DataTable DetallePagoDT { get; set; }
    }
}

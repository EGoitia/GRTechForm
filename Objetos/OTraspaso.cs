using System.Data;

namespace Objetos
{
    public class OTraspaso
    {
        public string CodTraspaso { get; set; }
        public int DelAlmacenID { get; set; }
        public int AlAlmacenID { get; set; }
        public string Detalle { get; set; }
        public DataTable DetalleTraspasoDT { get; set; }

    }
}

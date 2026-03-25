using System.Data;

namespace Objetos
{
    public class OInventario
    {
        public int InventarioID { get; set; }
        public int SucursalID { get; set; }
        public string Observacion { get; set; }
        public DataTable DetalleInventarioDT { get; set; }
    }
}

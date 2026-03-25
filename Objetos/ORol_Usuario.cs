
using System.Data;
namespace Objetos
{
    public class ORol_Usuario
    {
        public int RolID { get; set; }
        public string NomRol { get; set; }
        public string TipoSistema { get; set; }
        public DataTable DetalleRolDT { get; set; }
    }
}

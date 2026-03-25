using System.Data;

namespace Objetos
{
    public class OUsuario
    {
        public int UsuarioID { get; set; }
        public int PersonalID { get; set; }
        public string NomPer { get; set; }
        public string NomUsu { get; set; }
        public string Contrasenia { get; set; }
        public int TipoUsuario { get; set; }
        public bool Estado { get; set; }
        public DataTable SucursalesDT { get; set; }
        public DataTable CajasDT { get; set; }
    }
}

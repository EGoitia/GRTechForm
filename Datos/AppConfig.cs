
using Objetos;
using System.Configuration;

namespace Datos
{
    public static class AppConfig
    {
        public static string CadenaConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[OConexionGlobal.GlobalValor].ConnectionString;
            }
        }

        public static string CadenaConexionLocal
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[OConexionGlobal.GlobalValorLocal].ConnectionString;
            }
        }
    }
}

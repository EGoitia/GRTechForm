using Datos;
using System.Data;

namespace Negocio
{
    public static class NListarPersonalizado
    {
        public static DataTable ConsultarDT(string Consulta)
        {
            return DListarPersonalizado.ConsultarDT(Consulta);
        }

        public static DataSet ConsultarDS(string Consulta)
        {
            return DListarPersonalizado.ConsultarDS(Consulta);
        }

        public static bool AnulRestau(string Cod, string Tupla, string CodInm, string DetInm, string TipInm, bool Estado)
        {
            return DListarPersonalizado.AnulRestau(Cod, Tupla, CodInm, DetInm, TipInm, Estado);
        }

        public static bool AnulRestau_Nota(string Cod, string Tupla, string CodInm, string DetInm, string TipInm, bool Estado)
        {
            return DListarPersonalizado.AnulRestau_Nota(Cod, Tupla, CodInm, DetInm, TipInm, Estado);
        }
    }
}


using Datos;
using Objetos;
using System.Data;

namespace Negocio
{
    public static class NComision
    {
        public static int NInsertModifComision(OComision com, DataTable inm)
        {
            return DComision.DInsertModifComision(com, inm);
        }

        public static OComision NListarComision(int perid)
        {
            return DComision.DListarComision(perid);
        }
    }
}

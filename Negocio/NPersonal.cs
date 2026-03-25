using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;
using System.Data;

namespace Negocio
{
    public static class NPersonal
    {
        public static int NInsertModifPer(OPersonal per, OUbicacion ubic, DataTable inm)
        {
            return DPersonal.DInsertModifPer(per, ubic, inm);
        }

        public static List<OPersonal> NListarPersonales(string @Opcion, int @SucursalID)
        {
            return DPersonal.DListarPersonales(Opcion, SucursalID);
        }

        public static List<OPersonal> NListarCumplePerson(string @Mes)
        {
            return DPersonal.DListarCumplePerson(Mes);
        }

        public static byte[] NBuscarImgPer(int perid)
        {
            return DPersonal.DBuscarImgPer(perid);
        }
    }
}

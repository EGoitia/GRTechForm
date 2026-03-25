using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NMarcaciones
    {
        public static List<OMarcaciones> NListarMarcaciones(DateTime fecha)
        {
            return DMarcaciones.DListarMarcaciones(fecha);
        }

        public static List<OMarcaciones> NBuscarMarcaciones(int personalid, DateTime fecini, DateTime fecfin)
        {
            return DMarcaciones.DBuscarMarcaciones(personalid, fecini, fecfin);
        }

        public static int NInsertModifMarcaciones(string marc, OInmode inm)
        {
            return DMarcaciones.DInsertModifMarcaciones(marc, inm);
        }

        public static int NAnulRestauAlm(string cod, string nomtupla, int estado, OInmode inm)
        {
            return DMarcaciones.DAnulRestauAlm(cod, nomtupla, estado, inm);
        }
    }
}

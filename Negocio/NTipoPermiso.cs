using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NTipoPermiso
    {
        public static List<OTipoPermiso> NListarTPer()
        {
            return DTipoPermiso.DListarTPer();
        }

        public static int NInsertModifTipoPer(OTipoPermiso tper, OInmode inm)
        {
            return DTipoPermiso.DInsertModifTipoPer(tper, inm);
        }

        public static int NAnulRestauTipoPer(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DTipoPermiso.DAnulRestauTipoPer(cod, nomtupla, estado, inmod);
        }
    }
}

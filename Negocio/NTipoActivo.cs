using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NTipoActivo
    {
        public static int NInsertarModifTipoActivo(OTipoActivo tact, OInmode inm)
        {
            return DTipoActivo.DInsertarModifTipoActivo(tact, inm);
        }

        public static int NAnulRestauConf(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DTipoActivo.DAnulRestauConf(cod, nomtupla, estado, inmod);
        }

        public static List<OTipoActivo> NListarTipoActivo()
        {
            return DTipoActivo.DListarTipoActivo();
        }
    }
}

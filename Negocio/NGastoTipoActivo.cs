using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NGastoTipoActivo
    {
        public static int NAnulRestauGastoTipoAct(string @cod, string @nomtupla, int @estado, OInmode @inmod)
        {
            return DGastoTipoActivo.DAnulRestauGastoTipoAct(cod, nomtupla, estado, inmod);
        }

        public static int NInsertModifGastoTipoAct(OGastoTipoActivo @gtact, OInmode @inm)
        {
            return DGastoTipoActivo.DInsertModifGastoTipoAct(gtact, inm);
        }

        public static List<OGastoTipoActivo> NListarGastoTipoAct(int TipoActivoID)
        {
             return DGastoTipoActivo.DListarGastoTipoAct(TipoActivoID);
        }
    }
}

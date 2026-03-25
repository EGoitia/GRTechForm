using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NGestion
    {
        public static List<OGestion> NListarGestion()
        {
            return DGestion.DListarGestion();
        }

        public static int NInsertModifGestion(OGestion ges, OInmode inm)
        {
            return DGestion.DInsertModifGestion(ges, inm);
        }
    }
}

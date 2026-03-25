using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NGrupoActivosFijos
    {
        public static List<OGrupoActivos> NListarGrupActFij()
        {
            return DGrupoActivosFijos.DListarGrupActFij();
        }

        public static int NInsertModifGrupActFij(OGrupoActivos gactfij , OInmode inm)
        {
            return DGrupoActivosFijos.DInsertModifGrupActFij(gactfij, inm);
        }

        public static int NAnulRestauGrupActFij(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DGrupoActivosFijos.DAnulRestauGrupActFij(cod, nomtupla, estado, inmod);
        }
    }
}

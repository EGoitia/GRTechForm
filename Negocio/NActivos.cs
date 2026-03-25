using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NActivos
    {
        public static List<OActivo> NListarActivos()
        {
            return DActivo.DListarActivos();
        }

        public static int NInsertarModifActivo(OActivo act, OInmode inm)
        {
            return DActivo.DInsertarModifActivo(act, inm);
        }

        public static int NAnulRestauActivo(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DActivo.DAnulRestauActivo(cod, nomtupla, estado, inmod);
        }

    }
}

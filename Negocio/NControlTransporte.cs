using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NControlTransporte
    {
        public static List<OControlTransporte> NListarContTransp(string ciudad)
        {
            return DControlTransporte.DListarContTransp(ciudad);
        }

        public static int NAnulRestauAlm(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DControlTransporte.DAnulRestauAlm(cod, nomtupla, estado, inmod);
        }

        public static int NInsertModifContTransp(OControlTransporte ctrans, OInmode inm)
        {
            return DControlTransporte.DInsertModifContTransp(ctrans, inm);
        }
    }
}

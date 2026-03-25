using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NCargo
    {
        public static int NInsertModifCargo(OCargo @carg, OInmode @inm)
        {
            return DCargo.DInsertModifCargo(carg, inm);
        }

        public static int NAnulRestauCargo(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DCargo.DAnulRestauCargo(cod, nomtupla, estado, inmod);
        }

        public static List<OCargo> NListarCargos()
        {
            return DCargo.DListarCargos();
        }
    }
}

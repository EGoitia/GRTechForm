using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NRubroSubRubro
    {
        public static int NInsertModifRubroSubRubro(ORubroSubRubro tprod, OInmode inm)
        {
            return DRubroSubRubro.DInsertModifRubroSubRubro(tprod, inm);
        }

        public static int NAnulRestauRubroSubRubro(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DRubroSubRubro.DAnulRestauRubroSubRubro(cod, nomtupla, estado, inmod);
        }

        public static List<ORubroSubRubro> NListarRubroSubRubro()
        {
            return DRubroSubRubro.DListarRubroSubRubro();
        }
    }
}

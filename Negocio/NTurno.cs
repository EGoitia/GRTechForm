using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NTurno
    {
        public static int NAnulRestauTurno(string @cod, string @nomtupla, int @estado, OInmode @inm)
        {
            return DTurno.DAnulRestauTurno(cod, nomtupla, estado, inm);
        }

        public static int NInsertModifTurno(OTurnos @turn, string @dturn, OInmode @inm)
        {
            return DTurno.DInsertModifTurno(turn, dturn, inm);
        }

        public static List<OTurnos> NListarTurno()
        {
            return DTurno.DListarTurno();
        }
    }
}

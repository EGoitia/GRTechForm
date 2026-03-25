using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NTurnoPersonal
    {
        public static int NInsertModifTurPer(OTurnoPersonal tper, OInmode inm)
        {
            return DTurnoPersonal.DInsertModifTurPer(tper, inm);
        }

        public static int NAnulTurPer(int perid, int turid, OInmode inm)
        {
            return DTurnoPersonal.DAnulTurPer(perid, turid, inm);
        }

        public static List<OTurnoPersonal> NListarTurPer(int PersonalID)
        {
            return DTurnoPersonal.DListarTurPer(PersonalID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NRegistroAsistencia
    {
        public static List<ORegistroAsistencia> NListarRegAsis(int PersonalID, DateTime Fecha)
        {
            return DRegistroAsistencia.DListarRegAsis(PersonalID, Fecha);
        }

        public static int NInsertModifRegAsis(string rasis, string cod, OInmode inm)
        {
            return DRegistroAsistencia.DInsertModifRegAsis(rasis, cod, inm);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NAsistencia
    {
        public static List<OAsistencia> NListarAsistencia(int PersonalID, int Mes, int Gestion)
        {
            return DAsistencia.DListarAsistencia(PersonalID, Mes, Gestion);
        }

        public static int NInsertarModifAsistencia(OAsistencia asis, string dasis, OInmode inm)
        {
            return DAsistencia.DInsertarModifAsistencia(asis, dasis, inm);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleTurno
    {
        public static List<ODetalleTurno> NBuscarDetTurno(int TurnoID)
        {
            return DDetalleTurno.DBuscarDetTurno(TurnoID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleAsistencia
    {
        public static List<ODetalleAsistencia> NBuscarDAsis(string CodAsistencia)
        {
            return DDetalleAsistencia.DBuscarDAsis(CodAsistencia);
        }
    }
}

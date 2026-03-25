using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleTraspaso
    {
        public static List<ODetalleTraspaso> NBuscarTraspaso(string CodTraspaso)
        {
            return DDetalleTraspaso.DBuscarDTraspaso(CodTraspaso);
        }
    }
}

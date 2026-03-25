using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleGasto
    {
        public static List<ODetalleGasto> NListarDetGasto(string @Codigo, string @Opcion)
        {
            return DDetalleGasto.DListarDetGasto(Codigo, Opcion);
        }
    }
}

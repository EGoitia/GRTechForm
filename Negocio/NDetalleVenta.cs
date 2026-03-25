using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleVenta
    {
        public static List<ODetalleVenta> NBuscarDVen(string @CodVenta)
        {
            return DDetalleVenta.DBuscarDVen(CodVenta);
        }
    }
}

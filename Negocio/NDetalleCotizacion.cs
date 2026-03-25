using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleCotizacion
    {
        public static List<ODetalleCotizacion> NBuscarDCot(string CodCotizacion)
        {
            return DDetalleCotizacion.DBuscarDCot(CodCotizacion);
        }
    }
}

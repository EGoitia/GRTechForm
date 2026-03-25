using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NTransitoDetallado
    {
        public static List<OTransitoDetallado> NBuscarTransitoDetallado(string @Opcion, int @DescOpcion, string @Lugar, int @DescLugar, DateTime @FecIni, DateTime @FecFin)
        {
            return DTransitoDetallado.DBuscarTransitoDetallado(@Opcion, @DescOpcion, @Lugar, @DescLugar, @FecIni, @FecFin);
        }
    }
}

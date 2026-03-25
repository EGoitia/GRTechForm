using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleAbono
    {
        public static List<ODetalleAbono> NBuscarDAbono(string CodAbono, string TipoAbono)
        {
            return DDetalleAbono.DBuscarDAbono(CodAbono, TipoAbono);
        }
    }
}

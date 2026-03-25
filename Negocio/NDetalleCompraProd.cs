using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleCompraProd
    {
        public static List<ODetalleCompraProd> NBuscarDCompraProd(string CodCompraProd)
        {
            return DDetalleCompraProd.DBuscarDCompraProd(CodCompraProd);
        }
    }
}

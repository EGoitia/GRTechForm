using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDetalleIngSalProducto
    {
        public static List<ODetalleIngSalProducto> NBuscarDIngSalProd(string CodIngSalProd)
        {
            return DDetalleIngSalProducto.DBuscarDIngSalProd(CodIngSalProd);
        }
    }
}

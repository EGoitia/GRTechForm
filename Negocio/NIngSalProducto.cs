using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NIngSalProducto
    {
        public static List<OIngSalProducto> NListarIngSalProd(string Opcion, int @AlmacenID, DateTime @fec)
        {
            return DIngSalProducto.DListarIngSalProd(Opcion, AlmacenID, fec);
        }

        public static List<OIngSalProducto> NBuscarNotasIngRegul(string @CodCompraProd)
        {
            return DIngSalProducto.DBuscarNotasIngRegul(CodCompraProd);
        }

        public static List<OIngSalProducto> NBuscarIngSalProd(string Tipo, string Opcion, string Busqueda, int AlmacenID, DateTime Fecha)
        {
            return DIngSalProducto.DBuscarIngSalProd(Tipo, Opcion, Busqueda, AlmacenID, Fecha);
        }
    }
}

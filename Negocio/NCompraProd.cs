using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NCompraProd
    {
        public static int NAnulRestauCompraProd(string @cod, string @nomtupla, int @estado, OInmode @inmod)
        {
            return DCompraProd.DAnulRestauCompraProd(cod, nomtupla, estado, inmod);
        }

        public static List<OCompraProd> NListarCompraProd(int @CajaID, DateTime @fec)
        {
            return DCompraProd.DListarCompraProd(CajaID, fec);
        }

        public static List<OCompraProd> NListarRevComProv(int @SucID, int @ProvID, DateTime @FecIni, DateTime @FecFin)
        {
            return DCompraProd.DListarRevComProv(SucID, ProvID, FecIni, FecFin);
        }

        public static List<OCompraPorFecha> NBuscarCompraProdXFecha(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            return DCompraProd.DBuscarCompraProdXFecha(CajaID, FecIni, FecFin);
        }

        public static List<OCompraProd> NListarCompraProdTransito(int @SucID)
        {
            return DCompraProd.DListarCompraProdTransito(SucID);
        }

        public static List<OCompraProd> NBuscarCompraProd(string @Tipo, string @Busqueda, int @CajaID, DateTime Fecha)
        {
            return DCompraProd.DBuscarCompraProd(Tipo, Busqueda, CajaID, Fecha);
        }

        public static List<OCompraProd> NBuscarDeudasProv(int @ProveedorID, int @SucursalID)
        {
            return DCompraProd.DBuscarDeudasProv(ProveedorID, SucursalID);
        }
    }
}

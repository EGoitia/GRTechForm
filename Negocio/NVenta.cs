using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NVenta
    {
        public static List<OVenta> NListarRevVentasXCliente(int @SucID, int @CliID, DateTime @FIni, DateTime @FFin)
        {
            return DVenta.DListarRevVentasXCliente(SucID, CliID, FIni, FFin);
        }

        public static List<OVenta> NBuscarVentas(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @SucursalID)
        {
            return DVenta.DBuscarVentas(Busqueda, TipoBusq, FechaBusq, SucursalID);
        }

        public static List<OVentasPorFecha> NBuscarVentasXFecha(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            return DVenta.DBuscarVentasXFecha(CajaID, FecIni, FecFin);
        }

        public static List<OVentasPorFecha> NBuscarVenAbonProy(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            return DVenta.DBuscarVenAbonProy(CajaID, FecIni, FecFin);
        }

        public static List<OVenta> NBuscarDeudasCli(int @ClienteID, int @SucursalID, string @Opcion)
        {
            return DVenta.DBuscarDeudasCli(ClienteID, SucursalID, Opcion);
        }

    }
}

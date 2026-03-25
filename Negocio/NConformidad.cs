using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NConformidad
    {
        public static int NInsertarModifConf(OConformidad conf, string dconf, OUbicacion ubic, OInmode inm)
        {
            return DConformidad.DInsertarModifConf(conf, dconf, ubic, inm);
        }

        public static int NAnulRestauConf(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DConformidad.DAnulRestauConf(cod, nomtupla, estado, inmod);
        }

        public static List<OConformidad> NListarConformidad(int @SucID, DateTime @fec)
        {
            return DConformidad.DListarConformidad(SucID, fec);
        }

        public static List<OConformidad> NBuscarConf(string @Opcion, string @Busqueda, int @SucursalID, DateTime Fecha)
        {
            return DConformidad.DBuscarConf(Opcion, Busqueda, SucursalID, Fecha);
        }

        public static List<OConformidad> NBuscarConfXChofer(int @ChoferID, int @SucursalID, DateTime @FecIni, DateTime @FecFin) 
        {
            return DConformidad.DBuscarConfXChofer(@ChoferID, @SucursalID, @FecIni, @FecFin);
        }

        public static OValorConformidad NValorConformidad(string @CodConformidad)
        {
            return DConformidad.DValorConformidad(CodConformidad);
        }

        public static int NInsertModifValorConformidad(string dvalconf, OInmode inm)
        {
            return DConformidad.DInsertModifValorConformidad(dvalconf, inm);
        }
    }
}

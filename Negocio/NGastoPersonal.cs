using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NGastoPersonal
    {
        public static int NAnulRestauGastoPer(string @cod, string @nomtupla, int @estado, OInmode @inmod)
        {
            return DGastoPersonal.DAnulRestauGastoPer(cod, nomtupla, estado, inmod);
        }

        public static int NInsertModifGastoPer(OGastoPersonal @gper, OInmode @inm)
        {
            return DGastoPersonal.DInsertModifGastoPer(gper, inm);
        }

        public static List<OGastoPersonal> NListarGastoPer(int @CajaID, DateTime @fec)
        {
             return DGastoPersonal.DListarGastoPer(CajaID, fec);
        }

        public static List<OGastoPersonal> NListarRevGastoXPersonal(int @SucID, int @PerID, string @Opcion, DateTime @FIni, DateTime @FFin)
        {
            return DGastoPersonal.DListarRevGastoXPersonal(SucID, PerID, Opcion, FIni, FFin);
        }

        public static List<OGastoPersonal> NListarGastoPerXFecha(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            return DGastoPersonal.DListarGastoPerXFecha(CajaID, FecIni, FecFin);
        }

        public static List<OGastoPersonal> NBuscarGastoPer(string @Opcion, string @Busqueda, int @CajaID, DateTime Fecha)
        {
            return DGastoPersonal.DBuscarGastoPer(Opcion, Busqueda, CajaID, Fecha);
        }

        public static List<OGastoPersonal> NBuscarDeudasPer(int @PersonalID)
        {
            return DGastoPersonal.DBuscarDeudasPer(PersonalID);
        }
    }
}

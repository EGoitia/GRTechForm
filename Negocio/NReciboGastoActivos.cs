using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NReciboGastoActivos
    {
        public static List<OReciboGastoActivo> NListarReciboGastoActivo(int @CajaID, DateTime @fec)
        {
            return DReciboGastoActivos.DListarReciboGastoActivo(CajaID, fec);
        }

        public static int NAnulRestauReciboGastoActivo(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DReciboGastoActivos.DAnulRestauReciboGastoActivo(cod, nomtupla, estado, inmod);
        }

        public static int NInsertModifReciboGastoActivo(OReciboGastoActivo recgasact, OInmode inm)
        {
            return DReciboGastoActivos.DInsertModifReciboGastoActivo(recgasact, inm);
        }

        public static List<OReciboGastoActivo> NBuscarReciboGastoActivo(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @CajaID)
        {
            return DReciboGastoActivos.DBuscarReciboGastoActivo(Busqueda, TipoBusq, FechaBusq, CajaID);
        }

        public static List<OReciboGastoActivo> NKardexActivo(int @ActivoID, DateTime @FecIni, DateTime @FecFin)
        {
            return DReciboGastoActivos.DKardexActivo(ActivoID, FecIni, FecFin);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NTraspasoCaja
    {
        public static List<OTraspasoCaja> NListarTraspCaja(int @cajaid, DateTime @fecha, bool @amicaja)
        {
            return DTraspasoCaja.DListarTraspCaja(cajaid, fecha, amicaja);
        }

        public static List<OTraspasoCaja> NBuscarTraspCaja(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @CajaID, bool @AMiCaja)
        {
            return DTraspasoCaja.DBuscarTraspCaja(Busqueda, TipoBusq, FechaBusq, CajaID, AMiCaja);
        }

        public static List<OTraspasoCaja> NBuscarTraspCajaXFechas(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            return DTraspasoCaja.DBuscarTraspCajaXFechas(CajaID, FecIni, FecFin);
        }

        public static int NInsertModifTraspCaja(OTraspasoCaja tcaj, OInmode inm)
        {
            return DTraspasoCaja.DInsertModifTraspCaja(tcaj, inm); 
        }

        public static int NAnulRestauTraspCaja(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DTraspasoCaja.DAnulRestauTraspCaja(cod, nomtupla, estado, inmod);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NDepositoBanco
    {
        public static List<ODepositoBanco> NListarDepBanco(int @cajaid, DateTime @fecha)
        {
            return DDepositoBanco.DListarDepBanco(cajaid, fecha);
        }

        public static int NInsertModifDepBanco(ODepositoBanco dban, OInmode inm)
        {
            return DDepositoBanco.DInsertModifDepBanco(dban, inm);
        }

        public static List<ODepositoBanco> NBuscarDepBanco(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @CajaID)
        {
            return DDepositoBanco.DBuscarDepBanco(Busqueda, TipoBusq, FechaBusq, CajaID);
        }

        public static List<ODepositoBanco> NBuscarDepBancoxFecha(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            return DDepositoBanco.DBuscarDepBancoxFecha(CajaID, FecIni, FecFin);
        }

        public static int NAnulRestauDepBanco(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DDepositoBanco.DAnulRestauDepBanco(cod, nomtupla, estado, inmod); 
        }
    }
}

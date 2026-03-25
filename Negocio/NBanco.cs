using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NBanco
    {
        public static int NAnulRestauBan(string cod, string nomtupla, int estado, OInmode inm)
        {
            return DBanco.DAnulRestauBanco(cod, nomtupla, estado, inm);
        }

        public static int NInsertModifBanco(OBanco ban, OInmode inm)
        {
            return DBanco.DInsertModifBanco(ban, inm);
        }

        public static List<OBanco> NListarBancos()
        {
            return DBanco.DListarBancos();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NFeriados
    {
        public static List<OFeriados> NListarFeriados()
        {
            return DFeriados.DListarFeriados();
        }

        public static List<OFeriados> NBuscarFeriados(DateTime fecini, DateTime fecfin)
        {
            return DFeriados.DBuscarFeriados(fecini, fecfin);
        }

        public static int NAnulRestauFeriado(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DFeriados.DAnulRestauFeriado(cod, nomtupla, estado, inmod);
        }

        public static int NInsertModifFeriados(OFeriados fer, OInmode inm)
        {
             return DFeriados.DInsertModifFeriados(fer, inm);
        }
    }
}

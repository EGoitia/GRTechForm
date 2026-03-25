using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NHorario
    {
        public static int NAnulRestauHorario(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DHorarios.DAnulRestauHorario(cod, nomtupla, estado, inmod);
        }

        public static int NInsertModifHorario(OHorario hor, OInmode inm)
        {
            return DHorarios.DInsertModifHorario(hor, inm);
        }

         public static List<OHorario> NListarHorario()
         {
             return DHorarios.DListarHorario();
         }
    }
}

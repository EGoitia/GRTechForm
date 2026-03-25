using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;
using System.Data;

namespace Negocio
{
    public static class NReferenciaPersonal
    {
         public static int NAnulRestauReferPer(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DReferenciaPersonal.DAnulRestauReferPer(cod, nomtupla, estado, inmod);
        }

         public static List<OReferenciaPersonal> NListarReferPer(int personalid)
         {
             return DReferenciaPersonal.DListarReferPer(personalid);
         }

         public static int NInsertModifReferPer(OReferenciaPersonal rper, OUbicacion ubic, DataTable inm)
         {
             return DReferenciaPersonal.DInsertModifReferPer(rper, ubic, inm);
         }
    }
}

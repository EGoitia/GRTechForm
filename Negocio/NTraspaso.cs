using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

using Objetos;
using Datos;

namespace Negocio
{
    public class NTraspaso
    {

        public static int NAnulRestauTrasp(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DTraspaso.DAnulRestauTrasp(cod, nomtupla, estado, inmod);
        }

        public static List<OTraspaso> NListarTraspasos(int @SucID, DateTime @fec, char @AMiAlm)
        {
            return DTraspaso.DListarTraspasos(SucID, fec, AMiAlm);
        }

        public static List<OTraspaso> NBuscarTraspaso(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @AlmacenID, char @AMiAlm)
        {
            return DTraspaso.DBuscarTraspaso(Busqueda, TipoBusq, FechaBusq, AlmacenID, AMiAlm);
        }

        //public static XmlDocument[] NBuscarTraspaso(string CodTraspaso)
        //{
        //    return DTraspaso.DBuscarTraspaso(CodTraspaso);
        //}
    }
}

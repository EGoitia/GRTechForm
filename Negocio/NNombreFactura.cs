using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;
using System.Data;

namespace Negocio
{
    public static class NNombreFactura
    {
        private static List<ONombreFactura> LNonFact = null;
        private static List<ONombreFactura> lbusqnomfact = null;

        public static int NAnulRestauNomFact(string @cod, string @nomtupla, int @estado, OInmode @inmod)
        {
            return DNombreFactura.DAnulRestauNomFact(cod, nomtupla, estado, inmod); 
        }

        public static int NInsertModifNomFact(ONombreFactura @nfact, DataTable @inm)
        {
            return DNombreFactura.DInsertModifNomFact(nfact, inm);
        }

        public static List<ONombreFactura> NListarNomFact(string @opc, int @id)
        {
            LNonFact = DNombreFactura.DListarNomFact(opc, id);
            return LNonFact;
        }

        public static List<ONombreFactura> NListarNomFactHabilDesabil(bool est)
        {
            lbusqnomfact = LNonFact.Where(x => x.Estado = est).OrderBy(y => y.NomFact).ToList();
            return lbusqnomfact;
        }

        public static List<ONombreFactura> NBuscarNomFactLista(string busq)
        {
            lbusqnomfact = LNonFact.FindAll(c => c.NomFact.ToUpper().Contains(busq.ToUpper()));
            return lbusqnomfact;
        }

        public static ONombreFactura NSeleccionarNomFact(string cod)
        {
            ONombreFactura objnomfact = LNonFact.Find(x => x.NomFactID == Convert.ToInt32(cod));
            return objnomfact;
        }

        public static List<ONombreFactura> NCargarNomFact()
        {
            return LNonFact;
        }
    }
}

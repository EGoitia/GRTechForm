using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;
using System.Data;

namespace Negocio
{
    public static class NUbicacion
    {
        private static List<OUbicacion> LUbic = null;
        private static List<OUbicacion> lbusqubic = null;

        public static OUbicacion NBuscarUbic(string @codigo, string @opcion)
        {
            return DUbicacion.DBuscarUbicacion(codigo, opcion);
        }

        public static List<OUbicacion> NListarUbic(string @codigo, string @tupla)
        {
            LUbic = DUbicacion.DListarUbicaciones(codigo, tupla);
            return LUbic;
        }

        public static int NInsertModifUbic(Int32 codigo, string tupla, OUbicacion ubic, DataTable inm)
        {
            return DUbicacion.DInsertModifUbic(codigo, tupla, ubic, inm);
        }

        //public static int NAnulRestauUbic(string cod, string nomtupla, int estado, OInmode inmod)
        //{
        //    return DContacto. DProveedor.DAnulRestauProv(cod, nomtupla, estado, inmod);
        //}

        public static List<OUbicacion> NListarUbicHabilDesabil(bool est)
        {
            lbusqubic = LUbic.Where(x => x.Estado = est).OrderBy(y => y.CodUbicacion).ToList();
            return lbusqubic;
        }

        public static List<OUbicacion> NBuscarUbicLista(string busq)
        {
            lbusqubic = LUbic.FindAll(c => c.Direccion.ToUpper().Contains(busq.ToUpper()));
            return lbusqubic;
        }

        public static OUbicacion NSeleccionarUbic(string cod)
        {
            OUbicacion objubic = LUbic.Find(x => x.CodUbicacion == cod);
            return objubic;
        }

        public static List<OUbicacion> NCargarUbic()
        {
            return LUbic;
        }
    }
}

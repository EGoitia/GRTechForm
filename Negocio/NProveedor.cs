using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Datos;
using Objetos;

namespace Negocio
{
    public static class NProveedor
    {
        private static List<OProveedor> LProv = null;
        private static List<OProveedor> lbusqprov = null;

        public static int NInsertModifProveedor(OProveedor prov, DataTable inm)
        {
            return DProveedor.DInsertModifProveedor(prov, inm);
        }

        public static List<OProveedor> NListarProv()
        {
            LProv = DProveedor.DListarProveedores();
            return LProv;
        }

        public static List<OProveedor> NListarProvHabilDesabil(bool est)
        {
            lbusqprov = LProv.Where(x => x.Estado = est).OrderBy(y => y.NomProv).ToList();
            return lbusqprov;
        }

        public static List<OProveedor> NBuscarProv(string busq)
        {
            int val = 0;
            if (int.TryParse(busq, out val))
            {
                //Buscamos por codigo de Proveedor
                OProveedor objprov = LProv.Find(x => x.ProveedorID == Convert.ToInt32(busq));
                lbusqprov = new List<OProveedor>();
                lbusqprov.Add(objprov);
            }
            else
            {
                lbusqprov = LProv.FindAll(c => c.NomProv.ToUpper().Contains(busq.ToUpper()));
            }

            return lbusqprov;
        }

        public static OProveedor NSeleccionarProv(string cod)
        {
            OProveedor objprov = LProv.Find(x => x.ProveedorID == Convert.ToInt32(cod));
            return objprov;
        }

        public static List<OProveedor> NCargarProv()
        {
            return LProv;
        }
    }
}

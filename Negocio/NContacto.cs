using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;
using System.Data;

namespace Negocio
{
    public static class NContacto
    {
        private static List<OContacto> LContac = null;
        private static List<OContacto> lbusqcontac = null;

        public static int NInsertModifContacto(int codigo, string tupla, OContacto contact, DataTable inm)
        {
            return DContacto.DInsertModifContact(codigo, tupla, contact, inm);
        }

        public static List<OContacto> NListarContacto(string @tupla, int @codigo)
        {
            LContac = DContacto.DListarContactos(tupla, codigo);
            return LContac;
        }

        //public static int NAnulRestauContacto(string cod, string nomtupla, int estado, OInmode inmod)
        //{
        //    return DContacto. DProveedor.DAnulRestauProv(cod, nomtupla, estado, inmod);
        //}

        public static List<OContacto> NListarContactoHabilDesabil(bool est)
        {
            lbusqcontac = LContac.Where(x => x.Estado = est).OrderBy(y => y.NomContact).ToList();
            return lbusqcontac;
        }

        public static List<OContacto> NBuscarContacto(string busq)
        {
            int val = 0;
            if (int.TryParse(busq, out val))
            {
                //Buscamos por codigo de Proveedor
                OContacto objcontac = LContac.Find(x => x.ContactoID == Convert.ToInt32(busq));
                lbusqcontac = new List<OContacto>();
                lbusqcontac.Add(objcontac);
            }
            else
            {
                lbusqcontac = LContac.FindAll(c => c.NomContact.ToUpper().Contains(busq.ToUpper()));
            }

            return lbusqcontac;
        }

        public static OContacto NSeleccionarContacto(string cod)
        {
            OContacto objcontac = LContac.Find(x => x.ContactoID == Convert.ToInt32(cod));
            return objcontac;
        }

        public static List<OContacto> NCargarContacto()
        {
            return LContac;
        }
    }
}

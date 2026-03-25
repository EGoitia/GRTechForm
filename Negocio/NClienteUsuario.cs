using Datos;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class NClienteUsuario
    {
        private static List<OClienteUsuario> LCliUsu = null;

        public static int NInsertModifCliUsu(OClienteUsuario cliusu, DataTable inm)
        {
            return DClienteUsuario.DInsertModifCliUsu(cliusu, inm);
        }

        public static List<OClienteUsuario> DListarCliUsu(int ClienteID)
        {
            LCliUsu = DClienteUsuario.DListarCliUsu(ClienteID);
            return LCliUsu;
        }

        public static List<OClienteUsuario> NCargarCliUsu()
        {
            return LCliUsu;
        }

        public static OClienteUsuario NSeleccionarCliUsu(string cod)
        {
            OClienteUsuario objcliusu = LCliUsu.Find(x => x.ClienteUsuarioID == Convert.ToInt32(cod));
            return objcliusu;
        }
    }
}

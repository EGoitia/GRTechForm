using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Datos;
using Objetos;
using System.Data;

namespace Negocio
{
    public static class NCliente
    {
        public static int NInsertModifCli(OCliente cli, OUbicacion ubic, DataTable inm)
        {
            return DCliente.DInsertModifCli(cli, ubic, inm);
        }
    
        public static List<OCliente> NListarClientes(int @SucursalID)
        {
            return DCliente.DListarClientes(SucursalID);
        }
    }
}

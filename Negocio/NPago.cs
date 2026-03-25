using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

using Datos;

namespace Negocio
{
    public static class NPago
    {
        public static XmlDocument[] NBuscarPago(string CodPago)
        {
            return DPago.DBuscarPago(CodPago);
        }
    }
}

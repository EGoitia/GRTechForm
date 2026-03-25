using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

using Datos;

namespace Negocio
{
    public static class NAsiento
    {
        public static XmlDocument[] NBuscarAsiento(string CodAsiento)
        {
            return DAsiento.DBuscarAsiento(CodAsiento);
        }
    }
}

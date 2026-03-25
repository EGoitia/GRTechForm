using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;
using System.Xml;

namespace Negocio
{
    public static class NBalanceGeneral
    {
        public static XmlDocument[] NCargarCuentBalanceInicial()
        {
            return DBalanceGeneral.DCargarCuentBalanceInicial();
        }
    }
}

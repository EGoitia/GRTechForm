using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;
using Datos;

namespace Negocio
{
    public static class NPermisoVacacion
    {
        public static List<OPermisoVacacion> NListarPermisoVacacion(DateTime @Fecha)
        {
            return DPermisoVacacion.DListarPermisoVacacion(Fecha);
        }

        public static List<OPermisoVacacion> NBuscarPermisoVacacion(string @Busqueda, string @TipoBusq, DateTime @FechaBusq)
        {
            return DPermisoVacacion.DBuscarPermisoVacacion(Busqueda, TipoBusq, FechaBusq);
        }

        public static int NAnulRestauPermisoVacacion(string cod, string nomtupla, int estado, OInmode inm)
        {
            return DPermisoVacacion.DAnulRestauPermisoVacacion(cod, nomtupla, estado, inm);
        }

        public static int NInsertModifPermisoVacacion(OPermisoVacacion pervac, OInmode inm)
        {
            return DPermisoVacacion.DInsertModifPermisoVacacion(pervac, inm);
        }
    }
}

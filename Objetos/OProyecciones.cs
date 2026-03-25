using System;
using System.Data;

namespace Objetos
{
    public class OProyecciones
    {
        public int ProyeccionID { get; set; }
        public int SucursalID { get; set; }
        public int VendedorID { get; set; }
        public string NomProyeccion { get; set; }
        public decimal DiasLaborales { get; set; }
        public decimal MontoProyectado { get; set; }
        public decimal MontoEjecutado { get; set; }
        public decimal PorcentAvance { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public DataTable DetalleProyeccionDT { get; set; }

    }
}

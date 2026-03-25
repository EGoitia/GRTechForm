using System;

namespace Objetos
{
    public class ODosificacion
    {
        public int DosificacionID { get; set; }
        public string Descripcion { get; set; }
        public string Autorizacion { get; set; }
        public string Llave { get; set; }
        public string Leyenda { get; set; }
        public DateTime Fecha_Ini { get; set; }
        public DateTime Fecha_Lim { get; set; }
        public int SucursalID { get; set; }
        public int ActividadID { get; set; }
        public int TipoDosificacionID { get; set; }
    }
}

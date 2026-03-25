using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OEntregas
    {
        private string codEntrega = string.Empty;

        public string CodEntrega
        {
            get { return codEntrega; }
            set { codEntrega = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codUbicacion = string.Empty;

        public string CodUbicacion
        {
            get { return codUbicacion; }
            set { codUbicacion = value; }
        }
        private string codVenta = string.Empty;

        public string CodVenta
        {
            get { return codVenta; }
            set { codVenta = value; }
        }
        private DateTime fechaCreacion = DateTime.Now;

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        private DateTime fechaEntrega = DateTime.Now;

        public DateTime FechaEntrega
        {
            get { return fechaEntrega; }
            set { fechaEntrega = value; }
        }
        private string descripcion = string.Empty;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private string estado = string.Empty;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

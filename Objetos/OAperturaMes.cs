using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OAperturaCierreMes
    {
        private int aperturaMesID = -1;

        public int AperturaMesID
        {
            get { return aperturaMesID; }
            set { aperturaMesID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private DateTime fechaAperturaMes = DateTime.Now;

        public DateTime FechaAperturaMes
        {
            get { return fechaAperturaMes; }
            set { fechaAperturaMes = value; }
        }
        private DateTime fechaPlazoCierreMes = DateTime.Now;

        public DateTime FechaPlazoCierreMes
        {
            get { return fechaPlazoCierreMes; }
            set { fechaPlazoCierreMes = value; }
        }
        private DateTime fechaCierreMes = DateTime.Now;

        public DateTime FechaCierreMes
        {
            get { return fechaCierreMes; }
            set { fechaCierreMes = value; }
        }

        private string obsApertura = string.Empty;

        public string ObsApertura
        {
            get { return obsApertura; }
            set { obsApertura = value; }
        }
        private string obsCierre = string.Empty;

        public string ObsCierre
        {
            get { return obsCierre; }
            set { obsCierre = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

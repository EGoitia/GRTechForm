using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OValorConformidad
    {
        private string codConformidad = string.Empty;

        public string CodConformidad
        {
            get { return codConformidad; }
            set { codConformidad = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private decimal comxMetro = 0;

        public decimal ComxMetro
        {
            get { return comxMetro; }
            set { comxMetro = value; }
        }
        private decimal comxBolsa = 0;

        public decimal ComxBolsa
        {
            get { return comxBolsa; }
            set { comxBolsa = value; }
        }
        private decimal comxPza = 0;

        public decimal ComxPza
        {
            get { return comxPza; }
            set { comxPza = value; }
        }
    }
}

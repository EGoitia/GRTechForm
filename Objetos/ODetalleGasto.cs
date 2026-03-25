using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetalleGasto
    {
        private int gastoID = -1;

        public int GastoID
        {
            get { return gastoID; }
            set { gastoID = value; }
        }
        private string nomGasto = string.Empty;

        public string NomGasto
        {
            get { return nomGasto; }
            set { nomGasto = value; }
        }
        private decimal montoGastoBs = 0;

        public decimal MontoGastoBs
        {
            get { return montoGastoBs; }
            set { montoGastoBs = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

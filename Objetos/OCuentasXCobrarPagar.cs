using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OCuentasXCobrarPagar
    {
        private int cliPerProvID = -1;

        public int CliPerProvID
        {
            get { return cliPerProvID; }
            set { cliPerProvID = value; }
        }
        private string nomCliPerProv = string.Empty;

        public string NomCliPerProv
        {
            get { return nomCliPerProv; }
            set { nomCliPerProv = value; }
        }
        private decimal totalSaldoBs = 0;

        public decimal TotalSaldoBs
        {
            get { return totalSaldoBs; }
            set { totalSaldoBs = value; }
        }
    }
}

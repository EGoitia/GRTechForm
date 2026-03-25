using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OPlanillaSueldo
    {
        private string codPlanilla = string.Empty;

        public string CodPlanilla
        {
            get { return codPlanilla; }
            set { codPlanilla = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string observacion = string.Empty;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        private int mes = 1;

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        private int gestion = 2012;

        public int Gestion
        {
            get { return gestion; }
            set { gestion = value; }
        }
        private decimal liquidoPagable = 0;

        public decimal LiquidoPagable
        {
            get { return liquidoPagable; }
            set { liquidoPagable = value; }
        }
        private bool autorizado = false;

        public bool Autorizado
        {
            get { return autorizado; }
            set { autorizado = value; }
        }
        private bool pagado = false;

        public bool Pagado
        {
            get { return pagado; }
            set { pagado = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

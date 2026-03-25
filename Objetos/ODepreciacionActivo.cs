using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODepreciacionActivo
    {
        private int activoID = -1;

        public int ActivoID
        {
            get { return activoID; }
            set { activoID = value; }
        }
        private string nomActivo = String.Empty;

        public string NomActivo
        {
            get { return nomActivo; }
            set { nomActivo = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private decimal valorContabilizado = 0;

        public decimal ValorContabilizado
        {
            get { return valorContabilizado; }
            set { valorContabilizado = value; }
        }
        private decimal factorActualizado = 0;

        public decimal FactorActualizado
        {
            get { return factorActualizado; }
            set { factorActualizado = value; }
        }
        private decimal valorActualizado = 0;

        public decimal ValorActualizado
        {
            get { return valorActualizado; }
            set { valorActualizado = value; }
        }
        private decimal incrementoActualizado = 0;

        public decimal IncrementoActualizado
        {
            get { return incrementoActualizado; }
            set { incrementoActualizado = value; }
        }
        private decimal deprecAcumAnt = 0;

        public decimal DeprecAcumAnt
        {
            get { return deprecAcumAnt; }
            set { deprecAcumAnt = value; }
        }
        private decimal incremenDeprecAcum = 0;

        public decimal IncremenDeprecAcum
        {
            get { return incremenDeprecAcum; }
            set { incremenDeprecAcum = value; }
        }
        private decimal deprecPeriodo = 0;

        public decimal DeprecPeriodo
        {
            get { return deprecPeriodo; }
            set { deprecPeriodo = value; }
        }
        private decimal deprecAcumActual = 0;

        public decimal DeprecAcumActual
        {
            get { return deprecAcumActual; }
            set { deprecAcumActual = value; }
        }
        private decimal valorNetoBs = 0;

        public decimal ValorNetoBs
        {
            get { return valorNetoBs; }
            set { valorNetoBs = value; }
        }
        private decimal vidaUtilRest = 0;

        public decimal VidaUtilRest
        {
            get { return vidaUtilRest; }
            set { vidaUtilRest = value; }
        }
    }
}

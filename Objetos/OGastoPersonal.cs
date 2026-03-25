using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OGastoPersonal
    {
        private string codGastoPer = string.Empty;

        public string CodGastoPer
        {
            get { return codGastoPer; }
            set { codGastoPer = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codAsiento = string.Empty;

        public string CodAsiento
        {
            get { return codAsiento; }
            set { codAsiento = value; }
        }
        private string numGastoPer = string.Empty;

        public string NumGastoPer
        {
            get { return numGastoPer; }
            set { numGastoPer = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string opcion = string.Empty;

        public string Opcion
        {
            get { return opcion; }
            set { opcion = value; }
        }
        private int personalID = -1;

        public int PersonalID
        {
            get { return personalID; }
            set 
            {
                if (value > 0)
                    personalID = value;
                else
                    throw new Exception("Tiene que seleccionar un Personal");
            }
        }
        private string nomPer = string.Empty;

        public string NomPer
        {
            get { return nomPer; }
            set { nomPer = value; }
        }
        private int cajaID = -1;

        public int CajaID
        {
            get { return cajaID; }
            set { cajaID = value; }
        }
        private string nomCaja = string.Empty;

        public string NomCaja
        {
            get { return nomCaja; }
            set { nomCaja = value; }
        }
        private string concepto = string.Empty;

        public string Concepto
        {
            get { return concepto; }
            set 
            {
                if((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    concepto = value;
                else
                    throw new Exception("Tiene que ingresar el concepto");
            }
        }
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set 
            {
                if ((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    detalle = value;
                else
                    throw new Exception("Tiene que ingresar el detalle");
            }
        }
        private decimal montoBs = 0;

        public decimal MontoBs
        {
            get { return montoBs; }
            set { montoBs = value; }
        }
        private decimal montoSus = 0;

        public decimal MontoSus
        {
            get { return montoSus; }
            set { montoSus = value; }
        }
        private decimal tC = 0;

        public decimal TC
        {
            get { return tC; }
            set { tC = value; }
        }
        private string suma = string.Empty;

        public string Suma
        {
            get { return suma; }
            set { suma = value; }
        }
        private decimal totaldsctoBs = 0;

        public decimal TotalDsctoBs
        {
            get { return totaldsctoBs; }
            set { totaldsctoBs = value; }
        }
        private decimal totalPagadoBs = 0;

        public decimal TotalPagadoBs
        {
            get { return totalPagadoBs; }
            set { totalPagadoBs = value; }
        }
        private decimal totalSaldoBs = 0;

        public decimal TotalSaldoBs
        {
            get { return totalSaldoBs; }
            set { totalSaldoBs = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

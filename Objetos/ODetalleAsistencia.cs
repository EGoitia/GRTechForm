using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetalleAsistencia
    {
        private string codAsistencia = string.Empty;

        public string CodAsistencia
        {
            get { return codAsistencia; }
            set { codAsistencia = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private string horario = string.Empty;

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        private DateTime hrEntrada = DateTime.Now;

        public DateTime HrEntrada
        {
            get { return hrEntrada; }
            set { hrEntrada = value; }
        }
        private DateTime hrSalida = DateTime.Now;

        public DateTime HrSalida
        {
            get { return hrSalida; }
            set { hrSalida = value; }
        }
        private DateTime marcEntrada = DateTime.Now;

        public DateTime MarcEntrada
        {
            get { return marcEntrada; }
            set { marcEntrada = value; }
        }
        private DateTime marcSalida = DateTime.Now;

        public DateTime MarcSalida
        {
            get { return marcSalida; }
            set { marcSalida = value; }
        }
        private decimal tardanza = 0;

        public decimal Tardanza
        {
            get { return tardanza; }
            set { tardanza = value; }
        }
        private decimal salioTemp = 0;

        public decimal SalioTemp
        {
            get { return salioTemp; }
            set { salioTemp = value; }
        }
        private decimal hrsExtras = 0;

        public decimal HrsExtras
        {
            get { return hrsExtras; }
            set { hrsExtras = value; }
        }
        private decimal hrsPermiso = 0;

        public decimal HrsPermiso
        {
            get { return hrsPermiso; }
            set { hrsPermiso = value; }
        }
        private decimal hrsFalta = 0;

        public decimal HrsFalta
        {
            get { return hrsFalta; }
            set { hrsFalta = value; }
        }
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private bool falta = false;

        public bool Falta
        {
            get { return falta; }
            set { falta = value; }
        }
        private bool vacacion = false;

        public bool Vacacion
        {
            get { return vacacion; }
            set { vacacion = value; }
        }
        private bool feriado = false;

        public bool Feriado
        {
            get { return feriado; }
            set { feriado = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

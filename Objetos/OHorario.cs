using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OHorario
    {
        private int horarioID = -1;

        public int HorarioID
        {
            get { return horarioID; }
            set { horarioID = value; }
        }
        private string nomHorario = string.Empty;

        public string NomHorario
        {
            get { return nomHorario; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    nomHorario = value;
                else
                    throw new Exception("Ingrese el Nombre del Horario");
            }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
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
        private int minTolerEnt = 0;

        public int MinTolerEnt
        {
            get { return minTolerEnt; }
            set { minTolerEnt = value; }
        }
        private int minTolerSal = 0;

        public int MinTolerSal
        {
            get { return minTolerSal; }
            set { minTolerSal = value; }
        }
        private DateTime inicioEntr = DateTime.Now;

        public DateTime InicioEntr
        {
            get { return inicioEntr; }
            set { inicioEntr = value; }
        }
        private DateTime finEntr = DateTime.Now;

        public DateTime FinEntr
        {
            get { return finEntr; }
            set { finEntr = value; }
        }
        private DateTime inicioSal = DateTime.Now;

        public DateTime InicioSal
        {
            get { return inicioSal; }
            set { inicioSal = value; }
        }
        private DateTime finSal = DateTime.Now;

        public DateTime FinSal
        {
            get { return finSal; }
            set { finSal = value; }
        }
        private int valorDiaTrab = 0;

        public int ValorDiaTrab
        {
            get { return valorDiaTrab; }
            set { valorDiaTrab = value; }
        }
        private string color = string.Empty;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

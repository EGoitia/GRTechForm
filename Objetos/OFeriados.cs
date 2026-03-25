using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OFeriados
    {
        private int feriadoID = 0;

        public int FeriadoID
        {
            get { return feriadoID; }
            set { feriadoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomFeriado = string.Empty;

        public string NomFeriado
        {
            get { return nomFeriado; }
            set { nomFeriado = value; }
        }
        private string descripcion = string.Empty;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private DateTime fecha = DateTime.Now;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private decimal duracion = 0;

        public decimal Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

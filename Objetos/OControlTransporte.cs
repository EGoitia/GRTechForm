using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OControlTransporte
    {
        private Int32 contTransporteID = -1;

        public Int32 ContTransporteID
        {
            get { return contTransporteID; }
            set { contTransporteID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomContTransporte = string.Empty;

        public string NomContTransporte
        {
            get { return nomContTransporte; }
            set { nomContTransporte = value; }
        }
        private string ciudad = string.Empty;

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        private int valor = 1;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

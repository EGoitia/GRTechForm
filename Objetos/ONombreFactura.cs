using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ONombreFactura
    {
        private int nomFactID = -1;

        public int NomFactID
        {
            get { return nomFactID; }
            set { nomFactID = value; }
        }
        private int clienteID = -1;

        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }
        private int proveedorID = -1;

        public int ProveedorID
        {
            get { return proveedorID; }
            set { proveedorID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomFact = string.Empty;

        public string NomFact
        {
            get { return nomFact; }
            set { nomFact = value; }
        }
        private string nIT = string.Empty;

        public string NIT
        {
            get { return nIT; }
            set { nIT = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

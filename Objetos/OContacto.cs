using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OContacto
    {
        private Int32 contactoID = -1;

        public Int32 ContactoID
        {
            get { return contactoID; }
            set { contactoID = value; }
        }
        private string nomContact = string.Empty;

        public string NomContact
        {
            get { return nomContact; }
            set { nomContact = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string cargo = string.Empty;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        private string dpto = string.Empty;

        public string Dpto
        {
            get { return dpto; }
            set { dpto = value; }
        }
        private string telf = string.Empty;

        public string Telf
        {
            get { return telf; }
            set { telf = value; }
        }        
        private string celular = string.Empty;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string pagWeb = string.Empty;

        public string PagWeb
        {
            get { return pagWeb; }
            set { pagWeb = value; }
        }
        private string correo = string.Empty;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

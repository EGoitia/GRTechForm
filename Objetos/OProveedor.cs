using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OProveedor
    {
        private Int32 proveedorID = -1;

        public Int32 ProveedorID
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
        private string nomProv = string.Empty;

        public string NomProv
        {
            get { return nomProv; }
            set { nomProv = value; }   
        }
        private int tipoProvID = -1;
        public int TipoProvID
        {
            get { return tipoProvID; }
            set { tipoProvID = value; }
        }
        private string tipoProv = string.Empty;

        public string TipoProv
        {
            get { return tipoProv; }
            set { tipoProv = value; }
        }
        private string nota = string.Empty;

        public string Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        private string telf = string.Empty;

        public string Telf
        {
            get { return telf; }
            set { telf = value; }
        }
        private string fax = string.Empty;

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
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

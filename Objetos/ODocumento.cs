using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Objetos
{
    public class ODocumento
    {
        private string codDocumento = string.Empty;

        public string CodDocumento
        {
            get { return codDocumento; }
            set
            {
                codDocumento = value;
            }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomDcto = string.Empty;

        public string NomDcto
        {
            get { return nomDcto; }
            set 
            {
                if(!string.IsNullOrEmpty(value))
                    nomDcto = value;
                else
                    throw new Exception("El nombre del Documento no puede estar vacio");
            }
        }
        private string tipoDcto = string.Empty;

        public string TipoDcto
        {
            get { return tipoDcto; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    tipoDcto = value;
                else
                    throw new Exception("Seleccione un tipo de documento Valido");
            }
        }
        private string formato = string.Empty;

        public string Formato
        {
            get { return formato; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    formato = value;
                else
                    throw new Exception("Seleccione un formato Valido");
            }
        }
        private string palClave = string.Empty;

        public string PalClave
        {
            get { return palClave; }
            set 
            {
                if ((!string.IsNullOrEmpty(value) || (!string.IsNullOrWhiteSpace(value))))
                    palClave = value;
                else
                    throw new Exception("Tiene que ingresar palabras claves");
            }
        }
        private string descripcion = string.Empty;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private byte[] doc;

        public byte[] Doc
        {
            get { return doc; }
            set 
            {
                if (value.Length > 0)
                    doc = value;
                else
                    throw new Exception("Seleccione un Documento");
            }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

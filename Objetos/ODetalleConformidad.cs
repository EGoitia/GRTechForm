using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Objetos
{
    public class ODetalleConformidad
    {
        private string codConformidad = string.Empty;

        public string CodConformidad
        {
            get { return codConformidad; }
            set { codConformidad = value; }
        }
        private string codNota = string.Empty;

        public string CodNota
        {
            get { return codNota; }
            set { codNota = value; }
        }
        private Int32 productoID = -1;

        public Int32 ProductoID
        {
            get { return productoID; }
            set { productoID = value; }
        }
        private string nomProd = string.Empty;
        [XmlIgnore] 
        public string NomProd
        {
            get { return nomProd; }
            set { nomProd = value; }
        }
        private string numNota = string.Empty;

        public string NumNota
        {
            get { return numNota; }
            set { numNota = value; }
        }
        private decimal cantidad = 0;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private string unidMedida = string.Empty;
        [XmlIgnore] 
        public string UnidMedida
        {
            get { return unidMedida; }
            set { unidMedida = value; }
        }
        private decimal cantUnidMedida = 0;
        [XmlIgnore] 
        public decimal CantUnidMedida
        {
            get { return cantUnidMedida; }
            set { cantUnidMedida = value; }
        }
        private decimal peso = 0;
        [XmlIgnore] 
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

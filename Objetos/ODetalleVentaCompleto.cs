using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetalleVentaCompleto : OVenta
    {
        private string codVenta = string.Empty;

        public string CodVenta
        {
            get { return codVenta; }
            set { codVenta = value; }
        }
        private string codKardexProd = string.Empty;
        public string CodKardexProd
        {
            get { return codKardexProd; }
            set { codKardexProd = value; }
        }
        private int productoID = -1;

        public int ProductoID
        {
            get { return productoID; }
            set { productoID = value; }
        }
        private string nomProd = string.Empty;
        public string NomProd
        {
            get { return nomProd; }
            set { nomProd = value; }
        }
        private string unidMedida = string.Empty;
        public string UnidMedida
        {
            get { return unidMedida; }
            set { unidMedida = value; }
        }
        private decimal cantUnidMedida = 0;
        public decimal CantUnidMedida
        {
            get { return cantUnidMedida; }
            set { cantUnidMedida = value; }
        }
        private decimal peso = 0;
        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private byte[] img;
        public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }
        private decimal cantidad = 0;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal pUnitario = 0;

        public decimal PUnitario
        {
            get { return pUnitario; }
            set { pUnitario = value; }
        }
        private decimal pTotal = 0;

        public decimal PTotal
        {
            get { return pTotal; }
            set { pTotal = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

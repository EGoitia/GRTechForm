using System;
using System.Data;

namespace Objetos
{
    public class OIngSalProducto
    {
        private string codIngSalProd = string.Empty;

        public string CodIngSalProd
        {
            get { return codIngSalProd; }
            set { codIngSalProd = value; }
        }
        private string codCompraProd = string.Empty;

        public string CodCompraProd
        {
            get { return codCompraProd; }
            set { codCompraProd = value; }
        }
        private int almacenID = -1;

        public int AlmacenID
        {
            get { return almacenID; }
            set
            {
                if (value > 0)
                    almacenID = value;
                else
                    throw new Exception("Error con el ID del Almacen, vuelva a reiniciar el sistema");
            }
        }
        private int proveedorID = -1;

        public int ProveedorID
        {
            get { return proveedorID; }
            set 
            {
                if (value > 0)
                    proveedorID = value;
                else
                    throw new Exception("SELECCIONE UN PROVEEDOR");
            }
        }
        private int tipoIngSalProdID = -1;

        public int TipoIngSalProdID
        {
            get { return tipoIngSalProdID; }
            set { tipoIngSalProdID = value; }
        }
        private string recibido = string.Empty;

        public string Recibido
        {
            get { return recibido; }
            set { recibido = value; }
        }
        private string concepto = string.Empty;

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }
        public bool EsIngreso { get; set; }
        public DataTable DetalleIngSalProd { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OAlmacen
    {
        private Int32 almacenID = -1;

        public Int32 AlmacenID
        {
            get { return almacenID; }
            set { almacenID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codUbicacion = string.Empty;

        public string CodUbicacion
        {
            get { return codUbicacion; }
            set { codUbicacion = value; }
        }
        private int sucursalID = -1;

        public int SucursalID
        {
            get { return sucursalID; }
            set 
            {
                if (value > 0)
                    sucursalID = value;
                else
                    throw new Exception("Tiene que seleccionar una Sucursal");
            }
        }
        private string nomSuc = string.Empty;

        public string NomSuc
        {
            get { return nomSuc; }
            set { nomSuc = value; }
        }
        private string nomAlmacen = string.Empty;

        public string NomAlmacen
        {
            get { return nomAlmacen; }
            set 
            {
                if ((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    nomAlmacen = value;
                else
                    throw new Exception("El nombre del Almacen no puede estar en Blanco");
            }
        }
        private string nomEncAlmacen = string.Empty;

        public string NomEncAlmacen
        {
            get { return nomEncAlmacen; }
            set { nomEncAlmacen = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

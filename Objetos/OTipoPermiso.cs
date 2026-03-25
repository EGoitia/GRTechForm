using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTipoPermiso
    {
        private int tipoPermisoID = -1;

        public int TipoPermisoID
        {
            get { return tipoPermisoID; }
            set { tipoPermisoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomTipoPermiso = string.Empty;

        public string NomTipoPermiso
        {
            get { return nomTipoPermiso; }
            set { nomTipoPermiso = value; }
        }
        private string descripcion = string.Empty;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private bool afectaVac = false;

        public bool AfectaVac
        {
            get { return afectaVac; }
            set { afectaVac = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

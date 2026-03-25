using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OGrupoActivos
    {
        private int grupoActivoID = -1;

        public int GrupoActivoID
        {
            get { return grupoActivoID; }
            set { grupoActivoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string nomGrupo = string.Empty;

        public string NomGrupo
        {
            get { return nomGrupo; }
            set { nomGrupo = value; }
        }
        private string descripcion = string.Empty;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

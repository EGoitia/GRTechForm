using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OTipoActivo
    {
        private int tipoActivoID = -1;

        public int TipoActivoID
        {
            get { return tipoActivoID; }
            set { tipoActivoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private int grupoActivoID = -1;

        public int GrupoActivoID
        {
            get { return grupoActivoID; }
            set 
            {
                if (value > 0)
                    grupoActivoID = value;
                else
                    throw new Exception("Seleccione un grupo valido");
            }
        }
        private string nomGrupo = string.Empty;

        public string NomGrupo
        {
            get { return nomGrupo; }
            set { nomGrupo = value; }
        }
        private string nomTipoActivo = string.Empty;

        public string NomTipoActivo
        {
            get { return nomTipoActivo; }
            set 
            {
                if ((!string.IsNullOrEmpty(value) && (!string.IsNullOrWhiteSpace(value))))
                    nomTipoActivo = value;
                else
                    throw new Exception("El nombre no puede estar vacio");
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

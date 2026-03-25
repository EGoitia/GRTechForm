using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OUbicacion
    {
        private string codUbicacion = string.Empty;

        public string CodUbicacion
        {
            get { return codUbicacion; }
            set { codUbicacion = value; }
        }
        private string codInmodeUbic = string.Empty;

        public string CodInmodeUbic
        {
            get { return codInmodeUbic; }
            set { codInmodeUbic = value; }
        }
        private Int32 paisID = -1;

        public Int32 PaisID
        {
            get { return paisID; }
            set 
            {
                if (value > 0)
                    paisID = value;
                else
                    throw new Exception("Tiene que seleccionar un Pais"); 
            }
        }
        private string nomPais = string.Empty;

        public string NomPais
        {
            get { return nomPais; }
            set { nomPais = value; }
        }
        private string dptoEstado = string.Empty;

        public string DptoEstado
        {
            get { return dptoEstado; }
            set { dptoEstado = value; }
        }
        private string ciudad = string.Empty;

        public string Ciudad
        {
            get { return ciudad; }
            set 
            {
                //if((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    ciudad = value; 
                //else
                  //  throw new Exception("Tiene que seleccionar una Ciudad");
            }
        }
        private string zona = string.Empty;

        public string Zona
        {
            get { return zona; }
            set { zona = value; }
        }
        private string barrio = string.Empty;

        public string Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        private string direccion = string.Empty;

        public string Direccion
        {
            get { return direccion; }
            set 
            {
                //if ((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    direccion = value;
                //else
                  //  throw new Exception("El campo Direccion no puede estar vacío");
            }
        }
        private string latitud = string.Empty;

        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        private string longitud = string.Empty;

        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        private string altura = string.Empty;

        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        private string exactitud = string.Empty;

        public string Exactitud
        {
            get { return exactitud; }
            set { exactitud = value; }
        }
        private string escala = string.Empty;

        public string Escala
        {
            get { return escala; }
            set { escala = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}

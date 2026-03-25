using System;

using System.Data;

namespace Datos
{
    public class Parametros
    {
        //parametros
        public string Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }
        
        //constructor entrada
        public Parametros(string _nombre, Object _valor)
        {
            Nombre = _nombre;
            Valor = _valor;
            Direccion = ParameterDirection.Input;
        }

        //contructor salida
        public Parametros(string _nombre, SqlDbType _tipoDato, Int32 _tamaño)
        {
            Nombre = _nombre;
            TipoDato = _tipoDato;
            Tamaño = _tamaño;
            Direccion = ParameterDirection.Output;
        }
    }
}

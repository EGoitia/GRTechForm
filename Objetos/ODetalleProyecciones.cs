using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetalleProyecciones
    {
        private Int32 proyeccionID = -1;

        public Int32 ProyeccionID
        {
            get { return proyeccionID; }
            set { proyeccionID = value; }
        }
        private string dia = string.Empty;

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        private decimal valorDia = 0;

        public decimal ValorDia
        {
            get { return valorDia; }
            set { valorDia = value; }
        }
        private string fecha = string.Empty;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private decimal realSucursal = 0;

        public decimal RealSucursal
        {
            get { return realSucursal; }
            set { realSucursal = value; }
        }
        private decimal realAcumulado = 0;

        public decimal RealAcumulado
        {
            get { return realAcumulado; }
            set { realAcumulado = value; }
        }
        private decimal proyectDiario = 0;

        public decimal ProyectDiario
        {
            get { return proyectDiario; }
            set { proyectDiario = value; }
        }
        private decimal proyectAcumulado = 0;

        public decimal ProyectAcumulado
        {
            get { return proyectAcumulado; }
            set { proyectAcumulado = value; }
        }
        private decimal diferencia = 0;

        public decimal Diferencia
        {
            get { return diferencia; }
            set { diferencia = value; }
        }
        private decimal porcentaje = 0;

        public decimal Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }
        private decimal contra = 0;

        public decimal Contra
        {
            get { return contra; }
            set { contra = value; }
        }
        private decimal favor = 0;

        public decimal Favor
        {
            get { return favor; }
            set { favor = value; }
        }
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private bool habil = false;

        public bool Habil
        {
            get { return habil; }
            set { habil = value; }
        }
    }
}

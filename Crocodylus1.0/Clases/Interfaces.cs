using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Objetos;

namespace GRTechnology1._0
{
    interface ICargaDatosPrin
    {
        void CargarDatosPrin(string emp);
    }

    interface IAgregaProd
    {
        void AgregaProd(OProducto oprod);
    }

    interface IAgregaClien
    {
        void AgregaClien(Int32 cod, string nomcli);
    }

    interface IAgregaActivo
    {
        void AgregaActivo(Int32 cod, string nomact);
    }

    interface IAgregaHorario
    {
        void AgregaHorario(OHorario hor);
    }

    interface IAgregaControlTransp
    {
        void AgregaControlTransp(Int32 cod, string nomconttrans);
    }
   
    interface IAgregaProv
    {
        void AgregaProv(string nomprov);
    }

    interface IAgregaPer
    {
        void AgregaPer(string nomper);
    }

    interface IAgregaPerCompleto
    {
        void AgregaPerCompleto(OPersonal per);
    }

    interface IAgregaTotGasto
    {
        void AgregaTotGasto(List<ODetalleGasto> ldgas, decimal totgasto);
    }

    interface IAgregaTurno
    {
        void AgregaTurno(int turnoid, string nomturno);
    }

    interface IAgregaConformidad
    {
        void AgregaConformidad(List<ODetalleConformidad> ldconf);
    }

    interface IAgregaNotaRegul
    {
        void AgregaNotaRegul(List<ODetalleVenta> ldven, List<OVenta> lven);
    }

    interface IAgregaCompraProd
    {
        void AgregaCompraProd(OCompraProd ComProd, List<ODetalleCompraProd> LDComProd);
    }

    interface IAgregaDetPlanilla
    {
        void AgregaDetPlanilla(ODetallePlanillaSueldo ldpla);
    }

    interface IAgregaDetAbono
    {
        void AgregaDetAbono(List<ODetalleAbono> ldabon);
    }

    interface IAgregaCuentaCont
    {
        void AgregaCuentaCont(string cod, string nomcuenta);
    }

    interface IAgregaValorProy
    {
        void AgregaValorProy(DateTime fec, decimal monto);
    }

    class Interfaces
    {
    }
}

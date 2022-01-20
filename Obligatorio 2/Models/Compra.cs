using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    public class Compra
    {
        private static int UltimoIdCompra = 1;
        public int IdCompra { get; set; }   
        public Actividad Actividad { get; set; }
        public int CantidadEntradas { get; set; }
        public Cliente Cliente { get; set; }      
        public DateTime FechaHoraCompra { get; set; }

        private bool EstadoInicial = true;
        public bool Estado { get; set; }
        public double PrecioFinalPagar { get; set; }


        public Compra(Actividad actividad, int cantidadEntradas, Cliente cliente)
        {
            IdCompra = UltimoIdCompra;
            UltimoIdCompra++;
            Actividad = actividad;
            CantidadEntradas = cantidadEntradas;
            Cliente =cliente;
            FechaHoraCompra=DateTime.Now;
            Estado = EstadoInicial;

        }

        public double CalcularPrecioFinalCompra()
        {
            double precioFinal = Actividad.CalcularCosto() * CantidadEntradas;
                        
            return precioFinal;
        }



        public override string ToString()
        {
            return $"Id Compra: {IdCompra}, Actividad: {Actividad}, Cantidad de Entradas: {CantidadEntradas}, Cliente: {Cliente}, Fecha y Hora de la compra { FechaHoraCompra}, Estado {Estado}, Precio a pagar {PrecioFinalPagar}";
        }


}

}

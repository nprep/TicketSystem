using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    public class Actividad
    {
        private static int UltimoIdActividad = 1;
        public int IdActividad { get; set; }
        public string   Nombre{ get; set; }
        public Categoria Categoria { get; set; }
        public DateTime FechaHora { get; set; }
        public Lugar Lugar { get; set; }
        public TipoEdad EdadMinima { get; set; }

        private static double PrecioBaseEntrada  = 100;
        public int meGustaValor { get; set; }

        public enum TipoEdad
        {
            P,
            C13,
            C16,
            C18
        }

        public Actividad(string nombre, Categoria categoria, DateTime fechaHora, Lugar lugar, TipoEdad edadMinima)
        {
            IdActividad = UltimoIdActividad;
            UltimoIdActividad++;
            Nombre = nombre;
            Categoria = categoria;
            FechaHora = fechaHora;
            Lugar = lugar;
            EdadMinima = edadMinima;
            meGustaValor = 0;
            
        }

        public double CalcularCosto()
        {
            return Lugar.CalcularPrecioFinal(PrecioBaseEntrada);

        }
        
        public override string ToString()
        {
            return $"Id Actividad: {IdActividad}, Nombre: {Nombre}, Categoria: {Categoria}, Fecha y Hora: {FechaHora}, Lugar: {Lugar}, Edad Minima: {EdadMinima}, Precio Base de la Entrada: {PrecioBaseEntrada}, Edad Minima: {EdadMinima}, Me gusta: {meGustaValor}";
        }
    }
}

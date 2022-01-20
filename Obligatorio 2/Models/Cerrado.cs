using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    public class Cerrado : Lugar // herencia de clase Lugar
    {
        public static double Aforo = 50;
        public bool Accesibilidad { get; set; }

        public Cerrado(string nombre, bool accesibilidad)
        {
            IdLugar = ultimoIdLugar;
            ultimoIdLugar++;
            Nombre = nombre;      
            Accesibilidad = accesibilidad;
         
        }

        public bool CambiarValorAforoMaximo(int nuevoValor)
        {
            bool ret = false;
            if (nuevoValor >= 0 && nuevoValor <= 100)
            {
                Aforo = nuevoValor;
                ret = true;
            }
            return ret;
        }
        public double GetAforo()
        {
            return Aforo;
        }
        public override string ToString()
        {
            return base.ToString() + $"Nombre: {Nombre} Accesibilidad: {Accesibilidad}"; // properties del padre + propias
        }

        public override double CalcularPrecioFinal(double precioBase)
        {
            double precioFinal = precioBase;
            if (Aforo > 70)
            {
                return precioFinal;
            }
            else if (Aforo > 50)
            {
                precioFinal = precioBase * 1.15;
                return precioFinal;
            }
            else
            {
                return precioBase * 1.3;
            }
        }
    }
}

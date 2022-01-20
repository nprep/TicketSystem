using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    public class Abierto : Lugar // herencia de Clase Lugar
    {
       

        public Abierto(string nombre, double kmsCuadrados)
        {
            IdLugar = ultimoIdLugar;
            ultimoIdLugar++;
            Nombre = nombre;
            KmsCuadrados = kmsCuadrados;
            
            

        }

        public override double CalcularPrecioFinal(double precioBase)
        {
            if (KmsCuadrados > 1)
            {
                return precioBase * 1.1;
            }
            return precioBase;
        }

    }
}

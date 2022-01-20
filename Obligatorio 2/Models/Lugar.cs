using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    public abstract class Lugar // padre de herencia
    {
        protected static int ultimoIdLugar = 1;
        public int IdLugar { get; set; }
        public string Nombre { get; set; }
        public double KmsCuadrados { get; set; }
      

        public abstract double CalcularPrecioFinal(double precioBase);
        

        public override string ToString()
        {
            return $"Id: {IdLugar}, Nombre: {Nombre}, MtsCuadrados: {KmsCuadrados}";
        }

       

    }
    
}

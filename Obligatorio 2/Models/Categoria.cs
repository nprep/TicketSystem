using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    public class Categoria
    {
        private static int ultimoIdCategoria = 1;
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }


        public Categoria(string nombre, string descripcion)
        {
            IdCategoria  =  ultimoIdCategoria;
            ultimoIdCategoria++;
            Nombre = nombre;
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return $"Id: {IdCategoria}, Nombre: {Nombre}, Descripción: {Descripcion}";
        }
    }
}


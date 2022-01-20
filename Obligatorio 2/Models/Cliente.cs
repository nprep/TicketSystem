using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Obligatorio_P2
{
    public class Cliente : IComparable<Cliente>
    {

        private static int UltimoIdCliente = 1;
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        public string Apellido { get; set; }

        private List<Compra> compras = new List<Compra>();

        public string Email { get; set; }

        public List<Compra> Compras { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Cliente(string nombre, string apellido, string username, string password, string email, DateTime fechaNacimiento)
        {
            IdCliente = UltimoIdCliente;
            UltimoIdCliente++;
            Nombre = nombre;
            Apellido = apellido;
            Username = username;
            Password = password;
            Rol = "cliente";
            Email = email;
            FechaNacimiento = fechaNacimiento;

        }



        public override string ToString()
        {
            return $"IdUsuario: {IdCliente}, Nombre: {Nombre}, Apellido: {Apellido}, EMail: {Email}, Fecha de Nacimiento: {FechaNacimiento}";
        }

        public int CompareTo([AllowNull] Cliente other)
        {
            if (this.Apellido.CompareTo(other.Apellido) > 0)
            {
                return 1;
            }
            else if (this.Apellido.CompareTo(other.Apellido) < 0)
            {
                return -1;
            }
            else
            {
                if (this.Nombre.CompareTo(other.Nombre) > 0)
                {
                    return 1;
                }
                else if (this.Nombre.CompareTo(other.Nombre) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

        }
    }
}

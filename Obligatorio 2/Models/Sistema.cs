using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    public class Sistema
    {
        private List<Lugar> lugares = new List<Lugar>();
        private List<Categoria> categorias = new List<Categoria>();
        private List<Actividad> actividades = new List<Actividad>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Compra> compras = new List<Compra>();


        private static Sistema instancia = null;

        public static Sistema GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Sistema();
            }
            return instancia;
        }

        public Sistema()
        {
            PreCargadeDatos();
        }
        #region Get y Altas
        public List<Lugar> GetLugar() { return lugares; }
        public List<Categoria> GetCategoria() { return categorias; }
        public List<Actividad> GetActividad() { return actividades; }
        public List<Cliente> GetClientes() { return clientes; }
        public List<Compra> GetCompra() { return compras; }




        public Lugar AltaLugarAbierto(string nombre, double kmsCuadrados)
        {
            Abierto nuevo = null;
            if (nombre != "" && kmsCuadrados > 0)
            {
                nuevo = new Abierto(nombre, kmsCuadrados);
                lugares.Add(nuevo);

            }
            return nuevo;
        }

        public Lugar AltaLugarCerrado(string nombre, bool accesibilidad)
        {
            Cerrado nuevo = null;
            if (nombre != "")
            {
                nuevo = new Cerrado(nombre, accesibilidad);
                lugares.Add(nuevo);

            }
            return nuevo;
        }

        public Categoria AltaCategoria(string nombre, string descripcion)
        {
            Categoria nuevo = null;

            if (nombre != "" && descripcion != "")
            {
                nuevo = new Categoria(nombre, descripcion);
                categorias.Add(nuevo);
            }
            return nuevo;
        }

        public Actividad AltaActividad(string nombre, Categoria categoria, DateTime fecha, Lugar lugar, Actividad.TipoEdad edadMinima, int meGusta)
        {
            Actividad nuevo = null;
            if (nombre != "" && categoria != null && lugar != null)
            {
                nuevo = new Actividad(nombre, categoria, fecha, lugar, edadMinima);
                actividades.Add(nuevo);
            }

            return nuevo;
        }

        internal List<Compra> GetComprasCliente(int? idClienteLogueado)
        {
            List<Compra> ret = new List<Compra>();

            foreach (Compra c in compras)
            {
                if (c.Cliente.IdCliente.Equals(idClienteLogueado))
                    ret.Add(c);
            }
            return ret;
        }



        internal Cliente Login(string email, string password)
        {
            bool encontrado = false;
            Cliente c = null;

            foreach (Cliente cli in clientes) if  (!encontrado)
                    {
                        if  (cli.Email.Equals(email) && cli.Password.Equals(password))
                    {
                        encontrado = true;
                        c = cli;
                    }
                    }
            return c;
        }



        public Cliente AltaCliente(string nombre, string apellido, string username, string password, string email, DateTime fechaNac)
        {
            Cliente nuevo = null;

            if (minimoCaracterNombre(nombre) && minimoCaracterApellido(apellido) && emailEsUnico(email) && passwordEsValido(password) && usernameEsUnico(username))
            {
                nuevo = new Cliente(nombre, apellido, username, password, email, fechaNac);
                clientes.Add(nuevo);
            }
            return nuevo;
        }

        public Compra GetCompraId(int unIdCompra)
        {
            foreach (Compra c in compras)
            {
                if (c.IdCompra == unIdCompra)
                {
                    return c;
                }
            }
            return null;
        }


        internal Cliente GetCliente(int? idClienteLogueado)
        {
            Cliente c = null;
            foreach  (Cliente cli in clientes)
            {
                if (cli.IdCliente == idClienteLogueado)
                {
                    c = cli;
                }
            }
            return c;
        }

        private bool passwordEsValido(string password)
        {
            bool valido = false;
            bool mayuscula = false;
            bool minuscula = false;
            bool numero = false;

            foreach (var aux in password)
                {

                    if (char.IsUpper(aux))
                    {
                        mayuscula = true;
                    }
                    if (char.IsLower(aux))
                    {
                        minuscula = true;
                    }
                    if (char.IsDigit(aux))
                    {
                        numero = true;
                    }
                 }
            if (mayuscula && minuscula && numero && password.Length>=6)
            {
                valido = true;
            }
          
   
    return valido;
}

private bool minimoCaracterNombre(string nombre)
        {
            bool retorno = false;

            if(nombre.Length >= 2)
            {
                retorno = true;
            }
            else if(nombre == null)
            {
                retorno = false;
            }

            return retorno;
        }


        private bool minimoCaracterApellido(string apellido)
        {
            bool retorno = false;

            if (apellido.Length >= 2)
            {
                retorno = true;
            }

            return retorno;
        }

        private bool usernameEsUnico(string username)
        {
            if (username == null)
            {
                return false;
            }
            
            bool existe = false;

            foreach(Cliente c in clientes)
            {
                if (c.Username.Equals(username))
                {
                    existe = true;
                }
            }

            if (existe)
            {
                return false;
            }

            return true;
        }

        private bool emailEsUnico(string email)
        {
            if(email == null)
            {
                return false;
            }

            bool tieneArroba = false;
            foreach(char c in email)
            {
                if (c.ToString().Equals("@"))
                {
                    tieneArroba = true;
                }
            }

            if (!tieneArroba)
            {
                return false;
            }

            bool existe = false;

            foreach(Cliente c in clientes)
            {
                if (c.Email.Equals(email))
                {
                    existe = true;
                }
            }

            if (existe)
            {
                return false;
            }

            return true;
        }

        public Compra AltaCompra(Actividad actividad, int cantidadEntradas, Cliente cliente)
        {
            Compra nuevo = null;
            if (actividad != null && cantidadEntradas > 0 && cliente != null)
            {
                nuevo = new Compra(actividad, cantidadEntradas, cliente);
                compras.Add(nuevo);
            }
            return nuevo;
        }

        
        public Actividad GetActividad(int unIdActividad)
        {

            Actividad b = null;
            foreach (Actividad a in actividades)
            {
                if (a.IdActividad.Equals(unIdActividad))
                {
                    b = a;
                }
            }
            return b;
        }

        #endregion

        #region Metodos


        /* public bool CambiarValorPrecioButaca(double nuevoValor)
         {
             bool ret = false;
             if (nuevoValor > 0)
             {
                 Abierto.FijarPrecioButaca(nuevoValor);
                 ret = true;
             }
             return ret;
         }*/

        public bool CancelarCompra(int IdCompra)
        {
            bool res = false;
            foreach (Compra c in compras)
            {
                if (c.IdCompra == IdCompra && c.Actividad.FechaHora > (DateTime.Now.AddDays(1)))
                {
                    c.Estado = false;
                    res = true;
                }
            }
            return res;
        }
        //public double GetPrecioButaca() // pasamano desde Lugar Abierto para devolver el valor de la butaca en Porgram. 
        //{
        //    return Abierto.GetPrecioButaca();
        //}

        //public List<Actividad> EspectaculosTodoPublico()
        //{
        //    List<Actividad> act = new List<Actividad>();

        //    foreach (Actividad a in actividades)
        //    {
        //        if (a.EdadMinima == Actividad.TipoEdad.P)
        //        {
        //            act.Add(a);
        //        }
        //    }
        //    return act;
        //}

   

        public List<Actividad> ListarActividadesLugar(string unLugar)
        {
           
            List<Actividad> act = new List<Actividad>();
            foreach (Actividad a in actividades)
            {
                if (a.Lugar.Nombre == unLugar)
                {
                    act.Add(a);
                }
            }
                return act;
        }

        public List<Compra> ListarComprasEntreFechas(DateTime F1, DateTime F2)
        {
            List<Compra> comp = new List<Compra>();
            DateTime aux = new DateTime(1111, 1, 1);
            if (F1 > F2)
            {
                aux = F1;
                F1 = F2;
                F2 = aux;
            }
            foreach (Compra c in compras)
            {
                if (c.FechaHoraCompra >= F1 && c.FechaHoraCompra <= F2)
                {
                    comp.Add(c);
                }
            }
            return comp;
        }

        public double SumadeComprasEntreFechas(DateTime F1, DateTime F2)
        {
            double suma = 0;
            DateTime aux = new DateTime(1111, 1, 1);
            if (F1 > F2)
            {
                aux = F1;
                F1 = F2;
                F2 = aux;
            }
            foreach (Compra c in ListarComprasEntreFechas(F1, F2))
            {
                
                suma += c.CalcularPrecioFinalCompra();
            }
            return suma;
        }

        public List<Actividad> ListarActividadesFechaYCategoria(DateTime F1, DateTime F2, string nombre)
        {
            List<Actividad> act = new List<Actividad>();
            DateTime aux = new DateTime(1111, 1, 1);
            if (F1 > F2)
            {
                aux = F1;
                F1 = F2;
                F2 = aux;
            }

            foreach (Actividad a in actividades)
            {
                if (a.FechaHora >= F1 && a.FechaHora <= F2 && a.Categoria.Nombre == nombre) 
                {
                    act.Add(a);
                }
            }
            return act;
        }

        public List<Compra> ListarComprasMayorValor()
        {

            List<Compra> comp = new List<Compra>();
            double max  =  0;

            foreach(Compra c in compras)
            {
                if (c.CalcularPrecioFinalCompra() > max)
                {
                    max  =  c.CalcularPrecioFinalCompra();
                    comp.Clear();
                    comp.Add(c);

                }
                else if (c.CalcularPrecioFinalCompra() == max)
                {
                    comp.Add(c);
                }

            }
            return comp;

        }

        public int SumarMeGusta(int IdActividad)
        {
            int MeGusta = 0;
            foreach (Actividad a in actividades)
            {
                if (a.IdActividad == IdActividad)
                {
                    a.meGustaValor++;
                }

            }
            return MeGusta;
        }


        public List<Cliente> ListarSoloClientes()
        {

            List<Cliente> cli = new List<Cliente>();
            foreach (Cliente c in clientes)
            {
                if (c.Rol == "cliente")
                {
                    cli.Add(c);
                }
            }
            clientes.Sort();
            return cli;
        }


        #endregion

        #region precarga de datos
        public void PreCargadeDatos()
        {
            Lugar a1 = AltaLugarAbierto("Velódromo", 0.5);
            Lugar a2 = AltaLugarAbierto("Estadio Centenario", 3);
            Lugar a3 = AltaLugarAbierto("Teatro de verano", 1);

            Lugar c1 = AltaLugarCerrado("Antel Arena", false);
            Lugar c2 = AltaLugarCerrado("Teatro Solís", true);
            Lugar c3 = AltaLugarCerrado("Sala Zitarrosa", true);
            Lugar c4 = AltaLugarCerrado("Sala Florencio Sanchez", true);


            Cliente u1 = AltaCliente("Agustin", "Gonzalez", "agonzalez" ,"Abc12345", "agonzalez@mail.com", new DateTime(1966, 2, 25));
            Cliente u2 = AltaCliente("Pablo", "Del Pino", "pdelpino", "Abc12345", "pdelpino@mail.com", new DateTime(1990,1,14));
            Cliente u3 = AltaCliente("Ana", "Diaz", "amaria", "Abc12345", "amaria@mail.com", new DateTime(2000, 11, 8));
            Cliente u4 = AltaCliente("Lucia", "Ferreira", "luferreira", "Abc12345", "luferreira@mail.com", new DateTime(2010, 1, 6));
            Cliente u5 = AltaCliente("Pedro", "Fernández", "pfernandez", "Abc12345", "pfernandez@mail.com", new DateTime(2008, 2, 26));
            u4.Rol= "operador";
            u5.Rol= "operador";

            Categoria cat1 = AltaCategoria("Futbol", "Deporte de pelota colectivo");
            Categoria cat2 = AltaCategoria("Música", "Música en vivo");
            Categoria cat3 = AltaCategoria("Teatro", "Obras teatrales clásicas");
            Categoria cat4 = AltaCategoria("Basketball", "Deporte de pelota colectivo");

            Actividad act1 = AltaActividad("Clasico", cat1, new DateTime(2022, 7, 27), a1, Actividad.TipoEdad.P, 6);
            act1.meGustaValor = 20;
            Actividad act2 = AltaActividad("Hamlet", cat3, new DateTime(2022, 9, 2), c2, Actividad.TipoEdad.C18, 15);
            act2.meGustaValor = 15;
            Actividad act3 = AltaActividad("La beriso", cat2, new DateTime(2022, 5, 15), c3, Actividad.TipoEdad.C16, 2);
            act3.meGustaValor = 5;
            Actividad act4 = AltaActividad("Ciro y los Persas", cat2, new DateTime(2022, 1, 21), c1, Actividad.TipoEdad.C18, 120);
            act4.meGustaValor = 100;
            Actividad act5 = AltaActividad("Aguada vs Nacional", cat4, new DateTime(2022, 3, 30), c1, Actividad.TipoEdad.P, 300);
            act5.meGustaValor = 2;
            Actividad act6 = AltaActividad("Danubio vs Defensor Sporting", cat1, new DateTime(2022, 3, 4), a2, Actividad.TipoEdad.P, 0);
            act6.meGustaValor = 88;
            Actividad act7 = AltaActividad("4 pesos de propina", cat2, new DateTime(2022, 8, 8), a3, Actividad.TipoEdad.C16, 35);
            act7.meGustaValor = 22;
            Actividad act8 = AltaActividad("NTVG", cat2, new DateTime(2022, 7, 20), c1, Actividad.TipoEdad.P, 180);
            act8.meGustaValor = 66;
            Actividad act9 = AltaActividad("El fantasma de la ópera", cat3, new DateTime(2022, 2, 20), c2, Actividad.TipoEdad.C18, 400);
            act9.meGustaValor = 150;
            Actividad act10 = AltaActividad("El cuarteto de nos", cat2, DateTime.Now.AddDays(1), a2, Actividad.TipoEdad.P, 670);
            act10.meGustaValor = 35;


            Compra co1 = AltaCompra(act1, 4, u1);
            co1.FechaHoraCompra = new DateTime(2018, 3, 20);
            Compra co2 = AltaCompra(act2, 6, u2);
            co2.FechaHoraCompra = new DateTime(2021, 4, 30);
            Compra co3 = AltaCompra(act3, 3, u2);
            co3.FechaHoraCompra = new DateTime(2021, 4, 30);
            Compra co4 = AltaCompra(act4, 4, u1);
            co4.FechaHoraCompra = new DateTime(2021, 7, 15);
            Compra co5 = AltaCompra(act6, 2, u2);
            co5.FechaHoraCompra = new DateTime(2021, 7, 15);

        }
        #endregion
    }
}
        


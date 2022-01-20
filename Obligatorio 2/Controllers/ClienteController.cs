using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Obligatorio_2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Obligatorio_P2;

namespace Obligatorio_2.Controllers
{
    public class ClienteController : Controller
    {                    
        
        Sistema s = Sistema.GetInstancia(); 
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("logueadoEmail") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        

        [HttpPost]

        public IActionResult Login(string email, string password)
        {
            Cliente c = s.Login(email, password);
            if (c != null)
            {
                HttpContext.Session.SetInt32("logueadoId", c.IdCliente);
                HttpContext.Session.SetString("logueadoNombre", c.Nombre);
                HttpContext.Session.SetString("logueadoApellido", c.Apellido);
                HttpContext.Session.SetString("logueadoEmail", c.Email);
                HttpContext.Session.SetString("logueadoUsername", c.Username);
                HttpContext.Session.SetString("logueadoRol", c.Rol);

              
                return RedirectToAction("Index", "Cliente");
            }
            else
            {
                ViewBag.Resultado = "Ingrese los datos correctamemte";
                return View();
            }
        }

        public IActionResult Logout()
        {

            if (HttpContext.Session.GetString("logueadoNombre") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public IActionResult Logout(string n)
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult ListaCompras()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "cliente")
            {

                int? idClienteLogueado = HttpContext.Session.GetInt32("logueadoId");
                List<Compra> compras = s.GetComprasCliente(idClienteLogueado);
                return View(compras);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }


        }

        public IActionResult Comprar(int id)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "cliente")
            {
                Actividad a = s.GetActividad(id);
                ViewBag.Actividad = a;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public IActionResult Comprar(int id, int cant)
        {
            Actividad a = s.GetActividad(id);
            ViewBag.Actividad = a;
            int? idClienteLogueado = HttpContext.Session.GetInt32("logueadoId");
            Cliente c = s.GetCliente(idClienteLogueado);
            Compra nueva = s.AltaCompra(a, cant, c);
            if (nueva != null)
            {
                return RedirectToAction("ListaCompras", "Cliente");
            }
            else
            {
                ViewBag.Resultado = "Error";
            }

            return View();
        }


        public IActionResult Cancelar(int id)
        {

            if (HttpContext.Session.GetString("logueadoRol") == "cliente")
            {
                Compra c = s.GetCompraId(id);
                ViewBag.Compra = c;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public IActionResult Cancelar(int id, string n)
        {
            Compra c = s.GetCompraId(id);
            ViewBag.Compra = c;
            bool cancelada = s.CancelarCompra(id);
            if (cancelada == true)
            {
                ViewBag.Resultado = "Compra cancelada con éxito";
            }
            else
            {
                ViewBag.Resultado = "No es posible cancelar su compra";
            }
            return View();
        }
    }
}

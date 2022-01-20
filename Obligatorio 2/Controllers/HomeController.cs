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
    public class HomeController : Controller
    {

        Sistema s = Sistema.GetInstancia();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaActividades()
        {
            return View(s.GetActividad());
        }


        public IActionResult Registro()
        {
            if (HttpContext.Session.GetString("logueadoEmail") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Cliente");
            }
        }

        [HttpPost]

        public IActionResult Registro(string nombre, string apellido, string username, string password, string email, DateTime fechaNac)
        {
            Cliente nuevo = s.AltaCliente(nombre, apellido, username, password, email, fechaNac);
            if (nuevo != null)
            {
                ViewBag.Resultado = "Registro exitoso, inicie sesión";
                
            }
            else
            {
                ViewBag.Resultado = "Error de alta, recuerde que: nombre y apellido tengan un largo mínimo de 2 caracteres y la contraseña tendrá un largo mínimo de 6 caracteres y contendrá al menos una mayúscula, una minúscula y un dígito.El nombre de usuario y el email deben ser únicos.";
            }

            return View();
        }

        public IActionResult MeGusta(int id)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "cliente")
            {
                s.SumarMeGusta(id);
            }
            return RedirectToAction("ListaActividades", "Home");
        }

    }
}

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
    public class OperadorController : Controller
    {

        Sistema s = Sistema.GetInstancia();
        // GET: OperadorController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ComprasEntreFechas(DateTime f1, DateTime f2)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "operador")
            {
                return View(s.ListarComprasEntreFechas(f1, f2));
            }
            else
            {
                return RedirectToAction("Index", "Home");
            } 
        
        }

   

        [HttpPost]
        public ActionResult ComprasEntreFechas(DateTime f1, DateTime f2, int idCompras)
        {
            if(f1!=null && f2 != null)
            {
                if (s.ListarComprasEntreFechas(f1, f2).Count() != 0)
                {
                    double sum = s.SumadeComprasEntreFechas(f1, f2);
                    ViewBag.Suma = sum;
                    return View(s.ListarComprasEntreFechas(f1, f2));

                }
                else
                {
                    ViewBag.Error = "No hay registros para las fechas seleccionadas";
                    return View();
                }
            }

            else
            {
              return View();
            }

        }


        public ActionResult ActividadesporLugar(string nombre)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "operador")
            {
                
                List<Lugar> lugares = s.GetLugar();
                ViewBag.lugares = lugares;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

 

        [HttpPost]
        public ActionResult ActividadesporLugar(string nombre, int id)
        {

            if (s.ListarActividadesLugar(nombre).Count() != 0)
            {
                return View(s.ListarActividadesLugar(nombre));
            }

            else
            {
                ViewBag.Error = "No hay actividades para el lugar seleccionado";
                return View(s.ListarActividadesLugar(nombre));
            }

        }


        public ActionResult ActividadesPorFechaYCategoria(DateTime F1, DateTime F2, string nombre)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "operador")
            {
                List<Categoria> categorias = s.GetCategoria();
                ViewBag.categorias = categorias;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public ActionResult ActividadesPorFechaYCategoria(DateTime F1, DateTime F2, string nombre, int id)
        {

            if (s.ListarActividadesFechaYCategoria(F1, F2, nombre).Count() != 0)
            {
                return View(s.ListarActividadesFechaYCategoria(F1, F2, nombre));
            }

            else
            {
                ViewBag.Error = "No hay actividades para esas fechas y el lugar seleccionado";
                return View(s.ListarActividadesFechaYCategoria(F1, F2, nombre));
            }

        }


        public ActionResult VerClientesOrdenados()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "operador")
            {
                return View(s.ListarSoloClientes());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }



        public ActionResult ComprasMayorValor()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "operador")
            {
                return View(s.ListarComprasMayorValor());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


    }
}

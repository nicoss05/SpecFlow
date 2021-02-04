using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraWeb.Controllers
{
    public class CalculadorasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ObtenerSuma(int primerNumero, int segundoNumero)
        {
            //To Do: Ejecutar la suma con la libreria de negocio matematica para obetener suma
            var suma = 0;
            ViewBag.Suma = suma;
            return View();
        }
    }
}

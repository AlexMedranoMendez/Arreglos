using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio2.Controllers
{
    public class ArregloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Arreglo());
        }

        [HttpPost]
        public IActionResult Index(Arreglo arr, string calcular)
        {
            if (calcular == "cal")
            {
                for (int i = 0; i < 10; i++)
                {
                    arr.Numeros[i] = int.Parse(Request.Form["num"][i]);                 
                }

                arr.Mayor = arr.Numeros.Max().ToString();
                arr.Menor = arr.Numeros.Min().ToString();
            }

            return View(arr);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using PLATZI_ASP_NET_CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PLATZI_ASP_NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {

            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Guadalajara";
            escuela.Pais = "México";
            escuela.Dirección = "Guadalajara";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            ViewBag.CosaDinamica = "La monja";

            return View(escuela);
        }
    }
}




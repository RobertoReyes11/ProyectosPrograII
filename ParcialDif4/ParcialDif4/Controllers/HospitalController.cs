using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParcialDif4.Models;

namespace ParcialDif4.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        public ActionResult Presupuesto()
        {
            return View();
        }
        // POST: Hospital/Presupuesto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Presupuesto(budget obpresu, string command)
        {
            if(command == "Ginecologia")
            {
                double resultado = obpresu.presupuesto * 0.4;
                ViewBag.resultado = resultado;
            }
            if (command == "Traumatologia" || command == "Pediatria")
            {
                double resultado = obpresu.presupuesto * 0.3;
                ViewBag.resultado = resultado;
            }
            return View(obpresu);
        }
    }
}
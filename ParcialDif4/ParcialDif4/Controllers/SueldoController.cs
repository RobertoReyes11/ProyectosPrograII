using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParcialDif4.Models;

namespace ParcialDif4.Controllers
{
    public class sueldoController : Controller
    {
        // GET: sueldo
        public ActionResult Sueldo()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sueldo(sueldo obsueldo)
        {
            double resultado = obsueldo.ventast + obsueldo.ventast * 0.1 + obsueldo.sueldob;
            ViewBag.resultado = resultado;
            return View(obsueldo);
        }
    }
}
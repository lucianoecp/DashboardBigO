using AnaliseDeComplexidade1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaliseDeComplexidade1.Controllers
{
    public class LinearController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult DataLinearTempo()
        {
            SerieLinearTempo serie = new SerieLinearTempo();
            return Json(serie.GetDataDummy());
        }

        public JsonResult DataLinearEtapas()
        {
            SerieLinearEtapas serie = new SerieLinearEtapas();
            return Json(serie.GetDataDummy());
        }
    }
}

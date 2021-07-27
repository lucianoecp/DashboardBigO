using AnaliseDeComplexidade1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaliseDeComplexidade1.Controllers
{
    public class AninhadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult DataAninhadosTempo()
        {
            SerieAninhadosTempo serie = new SerieAninhadosTempo();
            return Json(serie.GetDataDummy());
        }

        public JsonResult DataAninhadosEtapas()
        {
            SerieAninhadosEtapas serie = new SerieAninhadosEtapas();
            return Json(serie.GetDataDummy());
        }
    }
}

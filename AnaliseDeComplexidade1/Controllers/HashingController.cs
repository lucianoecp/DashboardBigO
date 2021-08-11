using AnaliseDeComplexidade1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaliseDeComplexidade1.Controllers
{
    public class HashingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult DataHashingTempo()
        {
            SerieHashingTempo serie = new SerieHashingTempo();
            return Json(serie.GetDataDummy());
        }

        public JsonResult DataHashingEtapas()
        {
            SerieHashingEtapas serie = new SerieHashingEtapas();
            return Json(serie.GetDataDummy());
        }
    }
}

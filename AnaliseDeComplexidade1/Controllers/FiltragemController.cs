using AnaliseDeComplexidade1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaliseDeComplexidade1.Controllers
{
    public class FiltragemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult DataFiltragemTempo()
        {
            SerieFiltragemTempo serie = new SerieFiltragemTempo();
            return Json(serie.GetDataDummy());
        }

        public JsonResult DataFiltragemEtapas()
        {
            SerieFiltragemEtapas serie = new SerieFiltragemEtapas();
            return Json(serie.GetDataDummy());
        }
    }
}

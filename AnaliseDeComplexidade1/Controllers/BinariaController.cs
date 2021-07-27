using AnaliseDeComplexidade1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnaliseDeComplexidade1.Controllers
{
    public class BinariaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult DataBinariaTempo()
        {
            SerieBinariaTempo serie = new SerieBinariaTempo();
            return Json(serie.GetDataDummy());
        }

        public JsonResult DataBinariaEtapas()
        {
            SerieBinariaEtapas serie = new SerieBinariaEtapas();
            return Json(serie.GetDataDummy());
        }
    }
}

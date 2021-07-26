using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnaliseDeComplexidade1.Models;

namespace WebApplication1.Controllers
{
    public class AninhadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult DataAninhados()
        {
            SerieComplexidade serie = new SerieComplexidade();
            return Json( serie.GetDataDummy());

        } 
    }
}

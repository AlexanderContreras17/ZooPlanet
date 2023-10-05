using Microsoft.AspNetCore.Mvc;
using ZooPlanet.Models.Entities;
using ZooPlanet.Models.ViewModels;
using ZooPlanet.Controllers;

namespace ZooPlanet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
             
             AnimalesContext context = new();
            var datos = context.Clase.OrderBy(x => x.Nombre).Select(x=>new ClasesViewModel
            {
                Id = x.Id,
                Nombre=x.Nombre?? "",
                Descripcion=x.Descripcion?? ""
            });
            return View(datos);
        }
    }
}

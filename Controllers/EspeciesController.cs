using Microsoft.AspNetCore.Mvc;
using ZooPlanet.Models.ViewModels;
using ZooPlanet.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ZooPlanet.Controllers
{
    public class EspeciesController : Controller
    {
        public IActionResult Index(string Id)
        {
            AnimalesContext context = new();
           
               var datos = context.Especies
               .Include(x=>x.IdClaseNavigation)
               .Where(x=>x.IdClaseNavigation.Nombre== Id)
               .Select(X=> new EspecieAnimal
               {
                   Id=X.Id,
                   Nombre=X.Especie,
                   IdClase=X.IdClase
               });
            EspeciesViewModel vm = new()
            {
                Clase = Id,
                Animales = datos,
                Id = datos.First().IdClase,
            };
            return View(vm);
        }
        public IActionResult Especie(string Id)
        {
            AnimalesContext context = new();
            var datos = context.Especies.Include
                (x=>x.IdClaseNavigation)
                .FirstOrDefault(x=>x.Especie==Id);
            if (datos == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                EspecieViewModel vm = new()
                {
                    Id = datos.Id,
                    Especie = datos.Especie,
                    Clase = datos.IdClaseNavigation.Nombre,
                    Habitat = datos.Habitat ?? "No Disponible",
                    Peso = datos.Peso,
                    Tamaño = datos.Tamaño,
                    Observaciones = datos.Observaciones ??= "No Disponible"
                };
                return View(vm);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unidad2Actividad3.Models;
namespace Unidad2Actividad3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            villancicosContext context = new villancicosContext();
            var villancico = context.Villancico.OrderBy(x => x.Nombre);
            return View(villancico);
        }
        public IActionResult Villancicos(int? id)
        {
            if(id== null)
            {
                return RedirectToAction("Index");
            }
            villancicosContext context = new villancicosContext();
            var villancico = context.Villancico.FirstOrDefault(x => x.Id == id);
            if(villancico==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(villancico);
            }
            
        }
    }
}

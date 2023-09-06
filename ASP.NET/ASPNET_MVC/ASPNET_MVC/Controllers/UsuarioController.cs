using ASPNET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

namespace ASPNET_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            //return View(Resultado);
            }

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                var errorMessage = error.ErrorMessage;
                System.Diagnostics.Debug.WriteLine(errorMessage);
            }


            return View(usuario);
        }

        public IActionResult Resultado(Usuario usuario) 
        {
            return View(usuario);        
        }

        public IActionResult LogingUnico(string Login) 
        {
            var dbExemple = new Collection<string> 
            {
                "Igor",
                "Jose",
                "Mario",
                "Maria"
            };
            bool result = dbExemple.All(x => x.ToLower() != Login.ToLower());

            return Json(result);
        }

        [HttpPost]
        public IActionResult Search(string searchTerm)
        {
            // Lógica para buscar resultados com base em 'searchTerm'
            var results = new Collection<string>
            {
                "Igor",
                "Jose",
                "Mario",
                "Maria"
            };

            return PartialView("_SearchResultsPartial", results);
        }
    }
}

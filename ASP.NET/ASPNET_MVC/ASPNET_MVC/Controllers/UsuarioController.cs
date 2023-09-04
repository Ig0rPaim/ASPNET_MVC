using ASPNET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

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
            if(ModelState.IsValid)
            {
                return View("Resultado");
            }
            return View(usuario);
        }

        public IActionResult Resultado(Usuario usuario) 
        {
            return View(usuario);        
        }
    }
}

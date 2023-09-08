using BuilderAux_MVC.Models;
using BuilderAux_MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BuilderAux_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        public HomeController(IUsersRepository userRepository)
        {
            _usersRepository = userRepository;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(UsuarioModel User)
        {
            _usersRepository.Add(User);
            return RedirectToAction("Index");
        }

        public IActionResult Entrar()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
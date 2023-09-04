using ASPNET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC.Controllers
{
    public class Home_1Controller : Controller
    {
        public IActionResult Index()
        {
            Pessoa pessoa = new Pessoa
            {
                PessoaId = 1, // geralmente a passagem é feita por variáveis que veem do banco de dados
                Nome = "Igor",
                Tipo = "Dev"
            };

            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.Nome = pessoa.Nome;
            //ViewBag.Tipo = pessoa.Tipo;

            return View(pessoa);
        }

        public IActionResult Contatos()
        {
            return View();
        }

        [HttpPost] // usar o http post, pq se usar o get as informações são passadas na url 
        public IActionResult List(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}

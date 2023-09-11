using BuilderAux_MVC.Models;
using BuilderAux_MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BuilderAux_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersRepository _usersRepository;

        public UserController(IUsersRepository userRepository)
        {
            _usersRepository = userRepository;
        }

        public IActionResult Index()
        {
            List<UsuarioModel> ListUsers = _usersRepository.GetAll();
            return View(ListUsers);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(UsuarioModel User)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usersRepository.Add(User);
                    TempData["MensagemSucesso"] = "Usuário cadastrado com Sucesso";
                    return RedirectToAction("Index");
                }
                return View(User);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Opa! Tivemos um erro ao te Cadastrar, tente novamente. Detalhes do erro{erro.Message}";
                return RedirectToAction("Index");
            }
        }        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Editar(int id)
        {
            UsuarioModel UsuarioEditar = _usersRepository.ListById(id);
            return View(UsuarioEditar);
        }
        [HttpPost]
        public IActionResult Editar(UsuarioModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usersRepository.Atualizar(user);
                    TempData["MensagemSucesso"] = "Usuário alterado Com Sucesso";
                    return RedirectToAction("Index");
                }
                return View("Editar", user);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Opa! Tivemos um erro ao editar o usuário, tente novamente. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult ApagarConfimacao(int id)
        {
            UsuarioModel UsuarioApagar = _usersRepository.ListById(id);
            return View(UsuarioApagar);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usersRepository.DeleteUser(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuário apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Opa! Tivemos um erro ao apagar o usuário";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Opa! Tivemos um erro ao apagar o usuário. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
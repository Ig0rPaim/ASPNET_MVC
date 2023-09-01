using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC.Controllers
{
    public class Home_1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

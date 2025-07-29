using Microsoft.AspNetCore.Mvc;

namespace DEmo_Web_App_Hello_World.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();//We will use for rendering a HTMl page 
        }
    }
}

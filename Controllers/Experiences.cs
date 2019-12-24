using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class Experiences : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
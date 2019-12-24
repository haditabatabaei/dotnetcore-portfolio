using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class Education : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
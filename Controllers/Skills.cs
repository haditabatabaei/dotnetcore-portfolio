using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class Skills : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
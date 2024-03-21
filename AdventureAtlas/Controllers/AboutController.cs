using Microsoft.AspNetCore.Mvc;

namespace AdventureAtlas.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

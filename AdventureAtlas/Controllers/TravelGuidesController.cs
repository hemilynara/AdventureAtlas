using Microsoft.AspNetCore.Mvc;

namespace AdventureAtlas.Controllers
{
    public class TravelGuidesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

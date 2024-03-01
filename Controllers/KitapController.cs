using Microsoft.AspNetCore.Mvc;

namespace MVCProjem.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

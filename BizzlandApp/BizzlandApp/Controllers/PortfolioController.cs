using Microsoft.AspNetCore.Mvc;

namespace BizzlandApp.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Detail()
        {
            return View();
        }
    }
}

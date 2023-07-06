using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class HomeController : Controller
    {
        private EternaDbContext _context;
        public HomeController(EternaDbContext context)  
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Features = _context.Features.ToList()
            };
            return View(vm);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

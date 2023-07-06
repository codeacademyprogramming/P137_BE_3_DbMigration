using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private UniversityDbContext _context;
        public HomeController(UniversityDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Students.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
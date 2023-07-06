using BizzlandApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BizzlandApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Services = Data.Services,
                Members = Data.TeamMembers
            };
            return View(vm);
        }
     
    }
}
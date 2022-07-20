using BeeEngineering.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BeeEngineering.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.Name = "Bee Engineering!";
            return View(model);
        }

        public IActionResult Delete()
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
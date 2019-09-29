using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Exercicios.Models.ViewModels;

namespace MVC_02.Controllers
{
    public class PerguntasController : Controller
    {
        public IActionResult Index()
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
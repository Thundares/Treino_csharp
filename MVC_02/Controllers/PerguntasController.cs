using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Exercicios.Models.ViewModels;
using MVC_02.Services;

namespace MVC_02.Controllers
{
    public class PerguntasController : Controller
    {
        private readonly PerguntasService _context;

        public PerguntasController(PerguntasService c)
        {
            _context = c;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _context.FindAllAsync();
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }
        
        public IActionResult Remove()
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
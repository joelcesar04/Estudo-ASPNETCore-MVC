using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoMVC.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index()
        {
            //var filme = new Filme
            //{
            //    Titulo = "Oi",
            //    DataLancamento = DateTime.Now,
            //    Genero = null,
            //    Avaliacao = 10,
            //    Valor = 20000
            //};

            //return RedirectToAction("Privacy", filme);
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            //return Json("{'nome':'Joel'}");
            //var fileBytes = System.IO.File.ReadAllBytes(@"D:\Cursos\ESTUDOS\c#\arquivo.txt");
            //var fileName = "ola.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            if (ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Av1.Models;
using Av1.ViewModels;


namespace Av1.Controllers;

public class HomeController : Controller
{
    private static List<Estabelecimento> estabelecimentos = new List<Estabelecimento>();


    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Cadastro()
    {
        return View();
    }

    public IActionResult Cadastrar([FromForm] int id, [FromForm] int piso, [FromForm] string nome, [FromForm] string email, [FromForm] string descricao, [FromForm] bool tipo)
    {
        foreach (Estabelecimento estabelecimento in estabelecimentos)
        {
            if (estabelecimento.Id == id)
            {
                return Content("Estabelecimento já cadastrado");
            }
        }
        estabelecimentos.Add(new Estabelecimento(id, piso, nome, descricao, email, tipo));
        return View("Cadastro");
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

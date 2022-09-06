using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Av1.Models;
using Av1.ViewModels;


namespace Av1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private static List<Estabelecimento> estabelecimentos = new List<Estabelecimento>();
    /*
    private static List estudantes = new List{
        new EstudanteViewModel(1, "Miles Milhares", "Rua Testa, 1", true),
        new EstudanteViewModel(2, "Antedeguemon", "Rua yugi, 66", true),
        new EstudanteViewModel(3, "Verdin Gadinho", "Rua fumo, 420", false),
        new EstudanteViewModel(4, "Sujiro Kimimame", "Jacinto Leite, 69", true)
    }; */

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Cadastrar()
    {
        return View();
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

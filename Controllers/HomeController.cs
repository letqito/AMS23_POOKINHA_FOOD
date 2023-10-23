using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMS23_CAROUSEL.Models;

namespace AMS23_CAROUSEL.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Cadastrar()
    {
        return View();
    }

        public IActionResult Produtos()
    {
        return View();
    }

        public IActionResult Categoria()
    {
        return View();
    }

         public IActionResult Login(LoginModel loginModel)
    {
        var request = loginModel;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

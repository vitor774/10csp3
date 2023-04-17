using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        histórico histórico1 = new histórico(01, "2.3", "back-end", "Ryan Chrystian Da Silva Marques");
        List<histórico> listahistórico  = new List<histórico>();
        listahistórico.Add(histórico1);
        ViewBag.listahistórico = listahistórico;



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

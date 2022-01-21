using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chapter9.Models;

namespace Chapter9.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGetCustomerServices _getCustomer;
    public HomeController(ILogger<HomeController> logger, IGetCustomerServices getCustomer)
    {
        _logger = logger;
        _getCustomer = getCustomer;
    }

    public IActionResult Index()
    {

        return View(_getCustomer.Get());
    }

    public IActionResult Detail(int ID)
    {
        return View(_getCustomer.Detail(ID));
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

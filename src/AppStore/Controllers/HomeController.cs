using Microsoft.AspNetCore.Mvc;
namespace AppSotore.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
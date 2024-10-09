using AppStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace AppSotore.Controllers;
using AppStore.Repositories.Abstract;


public class HomeController : Controller
{
    private readonly ILibroService _libroService;

    public HomeController(ILibroService libroService)
        {
            _libroService = libroService;
        }


    public IActionResult Index(string term="", int currentPage = 1)
    {

        var LibroList = _libroService.List(term, true, currentPage);
        
        return View(LibroList);
    }

    public IActionResult LibroDetail(int libroId)
    {
        var libro = _libroService.GetById(libroId);
        return View(libro);
    } 

    public IActionResult About()
    {
        return View();
    }


}
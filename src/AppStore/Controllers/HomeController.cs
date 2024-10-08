using AppStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace AppSotore.Controllers;
using AppStore.Repositories.Abstract;


public class HomeController : Controller
{
    private readonly ILibroService _libroService;

    public HomeController(ILibroService libroService)
        {
            _libroService = libroService ?? throw new ArgumentNullException(nameof(libroService)); // Verifica que no sea nulo
        }


    public IActionResult Index(string term="", int currentPage = 1)
    {

        var libros = _libroService.List(term, true, currentPage);
        
        return View();
    }
}
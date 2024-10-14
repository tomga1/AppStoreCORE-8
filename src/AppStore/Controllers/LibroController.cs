using Microsoft.AspNetCore.Mvc;
namespace AppStore.Controllers;
using AppStore.Models.Domain;
using AppStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
public class LibroController : Controller
{
    private readonly ILibroService _libroService; 
    private readonly IFileService _fileService ;
    private readonly ICategoriaService _categoriaService;

    public LibroController(ILibroService libroService, IFileService fileService, ICategoriaService categoriaService)
    {
        _libroService = libroService ; 
        _fileService = fileService; 
        _categoriaService = categoriaService;
    }


    [HttpPost]
    public IActionResult Add(Libro libro)
    {
        if(!ModelState.IsValid)
        {
            return View(libro);
        }
        if(libro.ImageFile != null)
        {
            
        }
    }


    public IActionResult Add()
    {
        return View();
    }
    

    public IActionResult Edit(int id)
    {
        return View();
    }

    public IActionResult LibroList()
    {
        return View();
    }

    public IActionResult Delete(int id)
    {
        return RedirectToAction(nameof(LibroList));
    }

}
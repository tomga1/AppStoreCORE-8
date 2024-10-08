using AppStore.Repositories.Abstract;
using AppStore.Models.Domain;
using AppStore.Models.DTO;
namespace AppStore.Repositories.Implementation;


public class LibroService : ILibroService{

    public bool Add(LibroService libro)
    {
        return false; 
    }

    public bool Delete(int id)
    {
        return false; 
    }

    public Libro GetById(int id)
    {
        return null! ; 
    }

    public LibroListVm List(string term="", bool paging=false, int currentPage= 0)
    {
        return null;
    }


}
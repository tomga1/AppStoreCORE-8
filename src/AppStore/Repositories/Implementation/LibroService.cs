using AppStore.Repositories.Abstract;
using AppStore.Models.Domain;
using AppStore.Models.DTO;
namespace AppStore.Repositories.Implementation;


public class LibroService : ILibroService{


    private readonly DatabaseContext ctx;
    public LibroService(DatabaseContext ctxParameter)
    {
        ctx = ctxParameter;
    }

    public bool Add(LibroService libro)
    {
        try
        {
            ctx.Libros!.Add(libro);
            ctx.SaveChanges();
            foreach(int CategoriaId in libro.Categoria)
        }
        catch (Exception)
        {
            return false; 
        }

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

    public bool Update(Libro libro)
    {
        return false; 
    }

    public List<int> GetCategoriaByLibroId(int libroId)
    {
        return null;
    }


}
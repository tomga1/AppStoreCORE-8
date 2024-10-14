using AppStore.Repositories.Abstract;
using AppStore.Models.Domain;
using AppStore.Models.Domain.data;

namespace AppStore.Repositories.Implementation; 

public class CategoriaService : ICategoriaService
{
    private readonly DatabaseContext ctx ;

    public CategoriaService(DatabaseContext ctx)
    {
        this.ctx = ctx;
    }

    public IQueryable<Categoria> List()
    {
        return ctx.Categorias!.AsQueryable();
    }
}
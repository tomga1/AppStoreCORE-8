using AppStore.Models.Domain;

namespace AppStore.Repositories.Abstract; 
using AppStore.Models.Domain;

public interface ICategoriaService
{
    IQueryable<Categoria> List();
}
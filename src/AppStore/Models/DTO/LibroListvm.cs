namespace AppStore.Models.DTO;
using AppStore.Models.Domain;

public class LibroListVm
{
    public IQueryable<Libro>? LibroList{get;set;}

    public int PageSize{get; set;}
    public int currentPage{get; set;}

    public int TotalPages {get; set;}
    public string? Term {get; set;} 
    
}
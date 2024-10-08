namespace AppStore.Models.Domain;
using Microsoft.AspNetCore.Identity;
using AppStore.Models.Domain.data;

public class LoadDatabase
{
    public static async Task InsertarData(DatabaseContext context, 
                                            UserManager<ApplicationUser> usuarioManager, 
                                            RoleManager<IdentityRole> roleManager)                                         
    
    {
        if(!roleManager.Roles.Any())
        {
            await roleManager.CreateAsync(new IdentityRole("ADMIN"));
        }


        if(!usuarioManager.Users.Any())
        {
            var usuario = new ApplicationUser{
                Nombre = "Tomas Garcia",
                Email = "tomas@gmail.com",
                UserName = "Tomas.Garcia"
            };

            await usuarioManager.CreateAsync(usuario, "PasswordTomas123$");
            await usuarioManager.AddToRoleAsync(usuario, "ADMIN");
        }

        if(!context.Categorias!.Any())
        {
            await context.Categorias!.AddRangeAsync(
                new Categoria {Nombre = "Drama"},
                new Categoria {Nombre = "Comedia"},
                new Categoria {Nombre = "Accion"},
                new Categoria {Nombre = "Terror"},
                new Categoria {Nombre = "Aventura"}
            );

            await context.SaveChangesAsync();
        }

        if (!context.Libros!.Any())
        {
            await context.Libros!.AddRangeAsync(
                new Libro {
                    Titulo = "El Señor de los Anillos",
                    CreateDate = "06/06/2020",
                    Imagen = "Anillos.jpg",
                    Autor = "Miguel de Cervantes"
                },
                new Libro {
                    Titulo = "Harry Potter",
                    CreateDate = "06/06/2019",
                    Imagen = "Harry.jpg",
                    Autor = "Juan de la vega"
                }
            );

            await context.SaveChangesAsync();
        }

        if (!context.LibroCategorias!.Any())
        {
            await context.LibroCategorias.AddRangeAsync(
                new LibroCategoria { CategoriaId = 1, LibroId = 1 },
                new LibroCategoria { CategoriaId = 1, LibroId = 2 }
            );

            await context.SaveChangesAsync();
        }

}
}
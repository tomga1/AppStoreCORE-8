using System.Diagnostics.Eventing.Reader;
using AppStore.Repositories.Abstract;

namespace AppStore.Repositories.Implementation;

public class FileService : IFileService 
{
    
    private readonly IWebHostEnvironment environment;

    public FileService(IWebHostEnvironment environment)
    {
        this.environment = environment;
    }

    public Tuple<int, string> SaveImage(IFormFile imageFile)
    {
        try
        {
            var wwwPath = this.environment.WebRootPath;
            var path = Path.Combine(wwwPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var ext = Path.GetExtension(imageFile.FileName);
            var allowedExtension = new string[]{".jpg", ".png", ".jpeg"};
            if(!allowedExtension.Contains(ext))
            {
                var message = $"Solo estan permitidas las extensiones {allowedExtension}";
                return new Tuple<int, string>(0,message);
            }

            string uniqueString = Guid.NewGuid().ToString();
            var NewFileName = uniqueString + ext ; 

            var fileWithPath = Path.Combine(path, NewFileName);

            var stream = new FileStream(fileWithPath, FileMode.Create);

            imageFile.CopyTo(stream); 
            stream.Close() ;
            return new Tuple<int, string>(1,NewFileName);

        }
        catch (Exception)
        {
            
            return new Tuple<int, string>(0, "Errores guardando la imagen");
        }
    }

    public bool DeleteImage(string imageFileName)
    {
        try
        {
            var wwwPath = environment.WebRootPath;
            var path = Path.Combine(wwwPath, "Uploads\\", imageFileName);
            if(System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
            return false; 
        }
        catch (Exception)
        {
            
            return false;
        }
    }

}
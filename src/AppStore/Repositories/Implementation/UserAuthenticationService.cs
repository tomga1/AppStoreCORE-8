using AppStore.Models.Domain;
using AppStore.Models.DTO;
using AppStore.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;


namespace AppStore.Repositories.Implementation;

public class UserAuthenticationService : IUserAuthenticationService
{
    private readonly UserManager<ApplicationUser> userManager;
    private readonly SignInManager<ApplicationUser> signInManager;

    public UserAuthenticationService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager; 
    }

    public async Task<Status> LoginAsync(LoginModel login)
    {
        var status = new Status();
    }

    public async Task LogoutAsync()
    {
        await signInManager.SignOutAsync();
    }



}
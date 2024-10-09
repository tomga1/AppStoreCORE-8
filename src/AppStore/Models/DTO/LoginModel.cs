using Microsoft.AspNetCore.SignalR.Protocol;

namespace AppStore.Models.DTO;

public class LoginModel
{
    public string? Username { get; set; }
    public string? Password { get; set; }
}
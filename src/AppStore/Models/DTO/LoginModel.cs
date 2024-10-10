using Microsoft.AspNetCore.SignalR.Protocol;
using System.ComponentModel.DataAnnotations;
namespace AppStore.Models.DTO;

public class LoginModel
{

    [Required]
    public string? Username { get; set; }

    [Required]
    public string? Password { get; set; }


}
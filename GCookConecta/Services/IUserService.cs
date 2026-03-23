using GCookConecta.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GCookConecta.Services;

public interface IUserService
{
    Task<UsuarioVM> GetUsuarioLogado();
    Task<SignInResult> Login(LoginVM login);
    Task Logout();
}

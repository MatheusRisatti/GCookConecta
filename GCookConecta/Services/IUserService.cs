using GCookConecta.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GCookConecta.Services;

public interface IUserService
{
    Task<SignInResult> Login(LoginVM login);
    Task Logout();
}

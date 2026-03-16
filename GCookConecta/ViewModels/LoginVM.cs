using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace GCookConecta.ViewModels;

public class LoginVM
{
    [Display(Name = "E-mail", Prompt = "seuemail@gmail.com")]
    [Required(ErrorMessage = "O e-mail é obrigatório!")]
    [EmailAddress(ErrorMessage = "Informe um e-mail válido!")]
    public string Email { get; set; }

    [Display(Name = "Senha", Prompt = "*******")]
    [Required(ErrorMessage = "A senha é obrigatória!")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado ?")]
    public bool Lembrar { get; set; }

    [HiddenInput]
    public string UrlRetorno { get; set; }
}
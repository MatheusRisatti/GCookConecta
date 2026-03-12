using GCookConecta.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GCookConecta.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Popular Perfil
        List<IdentityRole> roles = new()
        {
            new(){
                Id = "37de5753-b6d8-41e9-8655-64362239f3f8",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new()
            {
                Id = "1238f228-aa89-4b7e-bafc-6d3bdfb6e81c",
                Name = "Moderador",
                NormalizedName = "MODERADOR"
            },
            new()
            {
                Id = "d45a3045-92de-4ac1-a544-ad53ef9aa695",
                Name = "Usuário",
                NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion
    
        #region Popular Usuários  
        List<Usuario> usuarios = new()
        {
          new(){
            Id = "78da1812-0f4c-40af-a477-f4d08a53ff96",
            Nome = "Mapoko",
            UserName = "administrador@gcook.com",
            NormalizedUserName = "ADMINISTRADOR@GCOOK.COM",
            Email = "administrador@gcook.com",
            NormalizedEmail = "ADMINISTRADOR@GCOOK.COM",
            DataNascimento = DateTime.Parse("22/02/2007"),
            Foto = "/img/usuarios/78da1812-0f4c-40af-a477-f4d08a53ff96.png",
            EmailConfirmed = true,
            LockoutEnabled = false
            }, 
          new(){
            Id = "6a7ab764-82e6-4fd7-80f1-1c5f5abf8ff9",
            Nome = "Matheus Clementino Risatti",
            UserName = "risattimaheus@gmail.com",
            NormalizedUserName = "RISATTIMATHEUS@GMAIL.COM",
            Email = "risattimatheus@gmail.com",
            NormalizedEmail = "RISATTIMATHEUS@GMAIL.COM",
            DataNascimento = DateTime.Parse("22/02/2007"),
            Foto = "/img/usuarios/6a7ab764-82e6-4fd7-80f1-1c5f5abf8ff9.png",
            EmailConfirmed = true,
            LockoutEnabled = false
            }, 
        };
        foreach (var usuario in usuarios){
            PasswordHasher<IdentityUser> passwordHasher = new();
            usuario.PasswordHash = passwordHasher.HashPassword(usuario, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Popular Perfil Usuário
        List<IdentityUserRole<string>> userRoles = new(){
            new(){
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            },
            new(){
                UserId = usuarios[1].Id,
                RoleId = roles[2].Id
            },
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion

        #region Popular Categoria
        List<Categoria> categorias = new(){
            new(){
                Id = 1,
                Nome = "Massas",
                Icone = "fas fa-pizza-slice",
            },
            new(){
                Id = 2,
                Nome = "Peixes",
                Icone = "fas fa-fish",
            },
            new(){
                Id = 3,
                Nome = "Vegetariano",
                Icone = "fas fa-leaf",
            },
            new(){
                Id = 4,
                Nome = "Carnes",
                Icone = "fas fa-drumstick-bite",
            },
            new(){
                Id = 5,
                Nome = "Doces",
                Icone = "fas fa-cake-candles",
            },
            new(){
                Id = 6,
                Nome = "Pães",
                Icone = "fas fa-bread-slice",
            },
            new(){
                Id = 7,
                Nome = "Sopas",
                Icone = "fas fa-mug-hot",
            },
            new(){
                Id = 8,
                Nome = "Picantes",
                Icone = "fas fa-pepper-hot",
            },
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Popular Ingredientes 
        List<Ingrediente> ingredientes = new(){
            new Ingrediente() {
                Id = 1,
                Nome = "Carne Moída"
            },
            new Ingrediente() {
                Id = 2,
                Nome = "Pimentão Verde"
            },
            new Ingrediente() {
                Id = 3,
                Nome = "Pimentão Vermelho"
            },
            new Ingrediente() {
                Id = 4,
                Nome = "Pimentão Amarelo"
            },
            new Ingrediente() {
                Id = 5,
                Nome = "Cebola"
            },
            new Ingrediente() {
                Id = 6,
                Nome = "Curry"
            },
            new Ingrediente() {
                Id = 7,
                Nome = "Pimenta Calabresa"
            },
            new Ingrediente() {
                Id = 8,
                Nome = "Páprica Picante"
            },
            new Ingrediente() {
                Id = 9,
                Nome = "Sal"
            },
            new Ingrediente() {
                Id = 10,
                Nome = "Orégano"
            },
            new Ingrediente() {
                Id = 11,
                Nome = "Pão Sirio"
            },
            new Ingrediente() {
                Id = 12,
                Nome = "Cream Cheese"
            },
            new Ingrediente() {
                Id = 13,
                Nome = "Cheddar"
            },
            new Ingrediente() {
                Id = 14,
                Nome = "Azeite"
            },
            new Ingrediente() { 
                Id = 15, 
                Nome = "Leite Condensado" 
            },
            new Ingrediente() { 
                Id = 16, 
                Nome = "Achocolatado em Pó" 
            },
            new Ingrediente() { 
                Id = 17, 
                Nome = "Manteiga" 
            },
            new Ingrediente() { 
                Id = 18, 
                Nome = "Macarrão Espaguete" 
            },
            new Ingrediente() {
                Id = 19, 
                Nome = "Molho de Tomate" 
            },
            new Ingrediente() { 
                Id = 20, 
                Nome = "Manjericão Fresco" 
            }
        };
        builder.Entity<Ingrediente>().HasData(ingredientes);
        #endregion

        #region Popular Receita
        List<Receita> receitas = new(){
            new Receita() {
                Id = 1,
                Nome = "Carne Moída Mexicana",
                Descricao = "Prato perfeito para um lanche rápido ou mesmo uma refeição picante. Carne moída, pimentões, temperos e muito queijooooo",
                CategoriaId = 4,
                Dificuldade = Dificuldade.Difícil,
                Rendimento = 5,
                TempoPreparo = "20 minutos",
                Foto = "/img/receitas/1.png",
                UsuarioId = usuarios[0].Id
            },
            new Receita() {
                Id = 2,
                Nome = "Brigadeiro Gourmet",
                Descricao = "O clássico brasileiro que não pode faltar. Cremoso, doce na medida certa e muito fácil de fazer.",
                CategoriaId = 5,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 20,
                TempoPreparo = "15 minutos",
                Foto = "/img/receitas/2.png",
                UsuarioId = usuarios[0].Id
            },
            new Receita() {
                Id = 3,
                Nome = "Espaguete ao Pomodoro",
                Descricao = "Uma massa leve e clássica italiana com molho de tomates frescos e manjericão.",
                CategoriaId = 1,
                Dificuldade = Dificuldade.Médio,
                Rendimento = 2,
                TempoPreparo = "25 minutos",
                Foto = "/img/receitas/3.png",
                UsuarioId = usuarios[0].Id
            }
        };
        builder.Entity<Receita>().HasData(receitas);
        #endregion
    
        #region Popular Preparo
        List<Preparo> preparos = new(){
          new()
            {
                Id = 1,
                ReceitaId = 1,
                Texto = "Comece pela preparação dos ingredientes, pique os pimentões e a cebola em pequenos cubos, se preferir você também pode usar um processador de alimentos."
            },
            new()
            {
                Id = 2,
                ReceitaId = 1,
                Texto = "Coloque a carne moída para fritar em uma panela com um pouco de azeite."
            },
            new()
            {
                Id = 3,
                ReceitaId = 1,
                Texto = "Quando a carne moída já não estiver mais crua, adicione os pimentões e a cebola, mexendo bem para misturar todos os ingredientes."
            },
            new()
            {
                Id = 4,
                ReceitaId = 1,
                Texto = "Aguarde alguns instante e adicione os temperos, mexendo novamente para misturar."
            },
            new()
            {
                Id = 5,
                ReceitaId = 1,
                Texto = "Frite por mais alguns minutos a carne com os demais ingredientes."
            },
            new()
            {
                Id = 6,
                ReceitaId = 1,
                Texto = "Adicione o Cream Cheese e o Queijo Cheddar, mexendo bem para evitar que queime o fundo e ajudar os queijos a derreterem."
            },
            new()
            {
                Id = 7,
                ReceitaId = 1,
                Texto = "Quando os queijos já estiverem bem derretidos e misturados com os demais ingredientes, sirva acompanhado do Pão Sirio ou de Doritos."
            },
            new() { 
                Id = 8, 
                ReceitaId = 2, 
                Texto = "Em uma panela, misture o leite condensado, o achocolatado e a manteiga." 
            },
            new() { 
                Id = 9, 
                ReceitaId = 2, 
                Texto = "Cozinhe em fogo baixo, mexendo sem parar até que a mistura desprenda do fundo da panela." 
            },
            new() { 
                Id = 10, 
                ReceitaId = 2, 
                Texto = "Deixe esfriar em um prato untado e depois enrole as bolinhas." 
            },
            new() { 
                Id = 11, 
                ReceitaId = 3, 
                Texto = "Cozinhe o macarrão em água fervente com sal até ficar al dente." 
            },
            new() { 
                Id = 12, 
                ReceitaId = 3, 
                Texto = "Em outra panela, aqueça o azeite e refogue o molho de tomate com manjericão." 
            },
            new() { 
                Id = 13, 
                ReceitaId = 3, 
                Texto = "Misture a massa ao molho e sirva imediatamente." 
            }
        };
        builder.Entity<Preparo>().HasData(preparos);
        #endregion
    
        #region Popular Receita Ingrediente
        List<ReceitaIngrediente> receitaIngredientes = new() {
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 1,
                Quantidade = "500g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 3,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 4,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 5,
                Quantidade = "1 pequeno"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 6,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 7,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 8,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 9,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 10,
                Quantidade = "1 colher sopa"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 11,
                Quantidade = "A vontade"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 12,
                Quantidade = "200g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 13,
                Quantidade = "200g"
            },
            new ReceitaIngrediente() {
                ReceitaId = 1,
                IngredienteId = 14,
                Quantidade = "Um pouco"
            },
            new ReceitaIngrediente() { 
                ReceitaId = 2, 
                IngredienteId = 15, 
                Quantidade = "1 lata" 
            },
            new ReceitaIngrediente() { 
                ReceitaId = 2, 
                IngredienteId = 16, 
                Quantidade = "4 colheres sopa" 
            },
            new ReceitaIngrediente() { 
                ReceitaId = 2, 
                IngredienteId = 17, 
                Quantidade = "1 colher sopa" 
            },
            new ReceitaIngrediente() { 
                ReceitaId = 3, 
                IngredienteId = 18, 
                Quantidade = "250g" 
            },
            new ReceitaIngrediente() {
                ReceitaId = 3, 
                IngredienteId = 19, 
                Quantidade = "300g" 
            },
            new ReceitaIngrediente() { 
                ReceitaId = 3, 
                IngredienteId = 20, 
                Quantidade = "A gosto" 
            },
            new ReceitaIngrediente() { 
                ReceitaId = 3, 
                IngredienteId = 14, 
                Quantidade = "2 colheres sopa" 
            }
        };
        builder.Entity<ReceitaIngrediente>().HasData(receitaIngredientes);
        #endregion
    }
}

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
            },
            new Ingrediente() { 
                Id = 21, 
                Nome = "Filé de Tilápia" 
                },
            new Ingrediente() {
                 Id = 22, 
                 Nome = "Limão"
                  },
            new Ingrediente() { 
                Id = 23, 
                Nome = "Grão de Bico" 
                },
            new Ingrediente() {
                Id = 24, 
                Nome = "Abóbora Cabotiá" 
                },
            new Ingrediente() { 
                Id = 25, 
                Nome = "Gengibre" 
                },
            new Ingrediente() { 
                Id = 26, 
                Nome = "Filé Mignon" 
                },
            new Ingrediente() { 
                Id = 27, 
                Nome = "Vinho Tinto Seco" 
                },
            new Ingrediente() {
                Id = 28, 
                Nome = "Farinha de Trigo" 
                },
            new Ingrediente() { 
                Id = 29, 
                Nome = "Creme de Leite Fresco" 
                },
            new Ingrediente() { 
                Id = 30, 
                Nome = "Fava de Baunilha" 
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
            },
            new Receita() {
                Id = 4,
                Nome = "Tilápia ao Forno",
                Descricao = "Filés de tilápia suculentos temperados com ervas e limão, assados rapidamente para uma refeição leve.",
                CategoriaId = 2,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 3,
                TempoPreparo = "30 minutos",
                Foto = "/img/receitas/4.png",
                UsuarioId = usuarios[0].Id
            },
            new Receita() {
                Id = 5,
                Nome = "Salada de Grão de Bico",
                Descricao = "Uma opção vegetariana proteica, refrescante e cheia de cores com tempero cítrico.",
                CategoriaId = 3,
                Dificuldade = Dificuldade.Fácil,
                Rendimento = 4,
                TempoPreparo = "15 minutos",
                Foto = "/img/receitas/5.png",
                UsuarioId = usuarios[0].Id
            },
            new Receita() {
                Id = 6,
                Nome = "Creme de Abóbora com Gengibre",
                Descricao = "Sopa cremosa e termogênica, perfeita para dias frios e muito nutritiva.",
                CategoriaId = 7,
                Dificuldade = Dificuldade.Médio,
                Rendimento = 4,
                TempoPreparo = "40 minutos",
                Foto = "/img/receitas/6.png",
                UsuarioId = usuarios[0].Id
            },
            new Receita() {
                Id = 7,
                Nome = "Medalhão ao Molho Madeira",
                Descricao = "Clássico da alta gastronomia. Exige o ponto perfeito da carne e a redução correta do molho com vinho e técnica de roux.",
                CategoriaId = 4,
                Dificuldade = Dificuldade.Difícil,
                Rendimento = 2,
                TempoPreparo = "50 minutos",
                Foto = "/img/receitas/7.png",
                UsuarioId = usuarios[0].Id
            },
            new Receita() {
                Id = 8,
                Nome = "Crème Brûlée",
                Descricao = "Sobremesa francesa delicada que exige cozimento em banho-maria e finalização com maçarico para a crosta de açúcar.",
                CategoriaId = 5,
                Dificuldade = Dificuldade.Difícil,
                Rendimento = 4,
                TempoPreparo = "1 hora",
                Foto = "/img/receitas/8.png",
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
            },
            // Preparo Tilápia (ID 4)
            new() { 
                Id = 14, 
                ReceitaId = 4, 
                Texto = "Tempere os filés com sal, limão e um pouco de azeite." 
                },
            new() { 
                Id = 15, 
                ReceitaId = 4, 
                Texto = "Disponha em uma assadeira e leve ao forno pré-aquecido a 180°C por 20 minutos."
                 },
            
            // Preparo Salada (ID 5)
            new() { 
                Id = 16, 
                ReceitaId = 5, 
                Texto = "Em uma tigela, misture o grão de bico cozido com cebola picada e pimentões." 
                },
            new() { 
                Id = 17, 
                ReceitaId = 5, 
                Texto = "Tempere com azeite, sal e limão a gosto e sirva frio." 
                },

            // Preparo Creme de Abóbora (ID 6)
            new() { 
                Id = 18, 
                ReceitaId = 6, 
                Texto = "Cozinhe a abóbora com água e sal até que esteja bem macia." 
                },
            new() { 
                Id = 19, 
                ReceitaId = 6, 
                Texto = "Bata no liquidificador com um pedaço pequeno de gengibre até ficar homogêneo." 
                },
            new() { 
                Id = 20, 
                ReceitaId = 6, 
                Texto = "Volte ao fogo para apurar o sal e sirva quente." 
                },
                // Preparo Medalhão (ID 7)
            new() { 
                Id = 21, 
                ReceitaId = 7, 
                Texto = "Sele os medalhões em fogo alto para criar a crosta de Maillard e reserve." 
                },
            new() { 
                Id = 22, 
                ReceitaId = 7, 
                Texto = "Na mesma panela, faça um roux com manteiga e farinha, adicione o vinho e reduza até encorpar." 
                },
            new() { 
                Id = 23,
                ReceitaId = 7, 
                Texto = "Retorne a carne ao molho para finalizar o cozimento até o ponto desejado." 
                },

            // Preparo Crème Brûlée (ID 8)
            new() { 
                Id = 24, 
                ReceitaId = 8,
                Texto = "Aqueça o creme de leite com a baunilha sem deixar ferver e misture lentamente às gemas e açúcar." 
                },
            new() { 
                Id = 25, 
                ReceitaId = 8, 
                Texto = "Asse em banho-maria no forno a 150°C até que as bordas estejam firmes e o centro balance levemente." 
            },
            new() { 
                Id = 26, 
                ReceitaId = 8, 
                Texto = "Após gelar por 6 horas, polvilhe açúcar e queime com maçarico até caramelizar." 
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
            },
            // Ingredientes Tilápia
            new ReceitaIngrediente() { 
                ReceitaId = 4, 
                IngredienteId = 21, 
                Quantidade = "600g" 
                },
            new ReceitaIngrediente() { 
                ReceitaId = 4, 
                IngredienteId = 22, 
                Quantidade = "1 unidade" 
                },
            new ReceitaIngrediente() { 
                ReceitaId = 4, 
                IngredienteId = 14, 
                Quantidade = "A gosto" 
                },

            // Ingredientes Salada
            new ReceitaIngrediente() { 
                ReceitaId = 5, 
                IngredienteId = 23, 
                Quantidade = "400g" 
                },
            new ReceitaIngrediente() {
                ReceitaId = 5, 
                IngredienteId = 5, 
                Quantidade = "1/2 unidade"
                 },
            new ReceitaIngrediente() { 
                ReceitaId = 5, 
                IngredienteId = 22, 
                Quantidade = "1/2 unidade" 
                },

            // Ingredientes Creme
            new ReceitaIngrediente() { 
                ReceitaId = 6, 
                IngredienteId = 24, 
                Quantidade = "1kg" 
                },
            new ReceitaIngrediente() { 
                ReceitaId = 6, 
                IngredienteId = 25, 
                Quantidade = "10g" 
                },
            new ReceitaIngrediente() {
                ReceitaId = 6, 
                IngredienteId = 9, 
                Quantidade = "1 pitada" 
                },
                // Ingredientes Medalhão
            new ReceitaIngrediente() { 
                ReceitaId = 7, 
                IngredienteId = 26, 
                Quantidade = "400g" 
                },
            new ReceitaIngrediente() { 
                ReceitaId = 7, 
                IngredienteId = 27, 
                Quantidade = "150ml" 
                },
            new ReceitaIngrediente() { 
                ReceitaId = 7, 
                IngredienteId = 28, 
                Quantidade = "1 colher sopa" 
                },
            new ReceitaIngrediente() { 
                ReceitaId = 7, 
                IngredienteId = 17, 
                Quantidade = "50g" 
                },

            // Ingredientes Crème Brûlée
            new ReceitaIngrediente() { 
                ReceitaId = 8, 
                IngredienteId = 29, 
                Quantidade = "500ml" 
                },
            new ReceitaIngrediente() { 
                ReceitaId = 8, 
                IngredienteId = 30, 
                Quantidade = "1 unidade" 
                },
            new ReceitaIngrediente() { 
                ReceitaId = 8, 
                IngredienteId = 9, 
                Quantidade = "80g de açúcar" 
                }
        };
        builder.Entity<ReceitaIngrediente>().HasData(receitaIngredientes);
        #endregion
    }
}

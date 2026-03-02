using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCookConecta.Models;

[Table("Ingredientes")]
public class Ingrediente
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome é obrigatório!")]
    [StringLength(50)]
    public string Nome { get; set; }

    public List<ReceitaIngrediente> Receitas { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace MiniApi.Models;

public class Jogador
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "O nome está muito grande. Máximo de 20 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [Range(10, int.MaxValue, ErrorMessage = "Deve conter mais de um dígito.")]
    public int Vida { get; set; }

    [Required]
    [Range(10, int.MaxValue, ErrorMessage = "Deve conter mais de um dígito.")]
    public int Ataque { get; set; }

    [Required]
    [Range(10, int.MaxValue, ErrorMessage = "Deve conter mais de um dígito.")]
    public int Defesa { get; set; }
}

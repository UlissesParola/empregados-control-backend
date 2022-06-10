using System.ComponentModel.DataAnnotations;

namespace ControleEmpregadosApi.Models;

public class Funcao
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Função")]
    public string NomeFuncao { get; set; }
}

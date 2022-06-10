using System.ComponentModel.DataAnnotations;

namespace ControleEmpregadosApi.Models;

public class Escolaridade
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Escolaridade")]
    public string NivelEscolaridade { get; set; }
}

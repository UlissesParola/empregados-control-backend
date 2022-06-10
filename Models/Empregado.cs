using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEmpregadosApi.Models;

public class Empregado
{
    [Required]
    public int Id { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Matrícula obrigatória")]
    [Display(Name = "Matrícula")]
    [RegularExpression(@"^([Cc]{1}\d{6})")]
    public string Matricula { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Nome obrigatório")]
    [StringLength(100)]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    //[Required]
    [Display(Name = "Data de Nascimento")]
    //[DisplayFormat(DataFormatString = "dd/mm/yyyy")]
    public string DataDeNascimento { get; set; }

    [ForeignKey("Funcao")]
    public int FuncaoId { get; set; }

    [Display(Name = "Função")]
    public Funcao? Funcao { get; set; }

    //[ForeignKey("Escolaridade")]
    public int EscolaridadeId { get; set; }

    [Display(Name = "Escolaridade")]
    public Escolaridade? Escolaridade { get; set; }
}

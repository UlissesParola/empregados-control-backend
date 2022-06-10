using ControleEmpregadosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEmpregadosApi.Data;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }

    public DbSet<Empregado> Empregados { get; set; }
    public DbSet<Funcao> Funcoes { get; set; }
    public DbSet<Escolaridade> Escolaridades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empregado>()
           .HasData(
                new Empregado()
                {
                    Id = 1,
                    Matricula = "c071615",
                    Nome = "Ulisses Parola",
                    DataDeNascimento = "1984-06-29",
                    EscolaridadeId = 4,
                    FuncaoId = 1
                 }
            );

       modelBuilder.Entity<Funcao>()
            .HasData(
                new Funcao()
                {
                    Id = 1,
                    NomeFuncao = "Técnico Bancário Novo"
                },
                new Funcao()
                {
                    Id = 2,
                    NomeFuncao = "Escriturário"
                },
                new Funcao()
                {
                    Id = 3,
                    NomeFuncao = "Auxiliar Operacional"
                },
                new Funcao()
                {
                    Id = 4,
                    NomeFuncao = "Assistente Junior"
                },
                new Funcao()
                {
                    Id = 5,
                    NomeFuncao = "Assistente Junior 6hrs"
                },
                new Funcao()
                {
                    Id = 6,
                    NomeFuncao = "Assistente Pleno"
                },
                new Funcao()
                {
                    Id = 7,
                    NomeFuncao = "Assistente Senior"
                },
                new Funcao()
                {
                    Id = 8,
                    NomeFuncao = "Supervisor Central Filial"
                },
                new Funcao()
                {
                    Id = 9,
                    NomeFuncao = "Coordenador Central Filial"
                },
                new Funcao()
                {
                    Id = 10,
                    NomeFuncao = "Gerente Centralizadora"
                }
            );


        modelBuilder.Entity<Escolaridade>()
            .HasData(
                new Escolaridade()
                {
                    Id = 1,
                    NivelEscolaridade = "Ensino Médio Completo"
                },
                new Escolaridade()
                {
                    Id = 2,
                    NivelEscolaridade = "Ensino Superior Incompleto"
                },
                new Escolaridade()
                {
                    Id = 3,
                    NivelEscolaridade = "Ensino Superior Completo"
                },
                new Escolaridade()
                {
                    Id = 4,
                    NivelEscolaridade = "Pós-Graduação"
                },
                new Escolaridade()
                {
                    Id = 5,
                    NivelEscolaridade = "Mestrado"
                },
                new Escolaridade()
                {
                    Id = 6,
                    NivelEscolaridade = "Doutorado"
                }
            );

    }
}

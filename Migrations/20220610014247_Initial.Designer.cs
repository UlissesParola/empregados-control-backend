﻿// <auto-generated />
using ControleEmpregadosApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControleEmpregadosApi.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220610014247_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ControleEmpregadosApi.Models.Empregado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EscolaridadeId")
                        .HasColumnType("integer");

                    b.Property<int>("FuncaoId")
                        .HasColumnType("integer");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("EscolaridadeId");

                    b.HasIndex("FuncaoId");

                    b.ToTable("Empregados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataDeNascimento = "29/06/1984",
                            EscolaridadeId = 4,
                            FuncaoId = 1,
                            Matricula = "c071615",
                            Nome = "Ulisses Parola"
                        });
                });

            modelBuilder.Entity("ControleEmpregadosApi.Models.Escolaridade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("NivelEscolaridade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Escolaridades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NivelEscolaridade = "Ensino Médio Completo"
                        },
                        new
                        {
                            Id = 2,
                            NivelEscolaridade = "Ensino Superior Incompleto"
                        },
                        new
                        {
                            Id = 3,
                            NivelEscolaridade = "Ensino Superior Completo"
                        },
                        new
                        {
                            Id = 4,
                            NivelEscolaridade = "Pós-Graduação"
                        },
                        new
                        {
                            Id = 5,
                            NivelEscolaridade = "Mestrado"
                        },
                        new
                        {
                            Id = 6,
                            NivelEscolaridade = "Doutorado"
                        });
                });

            modelBuilder.Entity("ControleEmpregadosApi.Models.Funcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeFuncao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Funcoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NomeFuncao = "Técnico Bancário Novo"
                        },
                        new
                        {
                            Id = 2,
                            NomeFuncao = "Escriturário"
                        },
                        new
                        {
                            Id = 3,
                            NomeFuncao = "Auxiliar Operacional"
                        },
                        new
                        {
                            Id = 4,
                            NomeFuncao = "Assistente Junior"
                        },
                        new
                        {
                            Id = 5,
                            NomeFuncao = "Assistente Junior 6hrs"
                        },
                        new
                        {
                            Id = 6,
                            NomeFuncao = "Assistente Pleno"
                        },
                        new
                        {
                            Id = 7,
                            NomeFuncao = "Assistente Senior"
                        },
                        new
                        {
                            Id = 8,
                            NomeFuncao = "Supervisor Central Filial"
                        },
                        new
                        {
                            Id = 9,
                            NomeFuncao = "Coordenador Central Filial"
                        },
                        new
                        {
                            Id = 10,
                            NomeFuncao = "Gerente Centralizadora"
                        });
                });

            modelBuilder.Entity("ControleEmpregadosApi.Models.Empregado", b =>
                {
                    b.HasOne("ControleEmpregadosApi.Models.Escolaridade", "Escolaridade")
                        .WithMany()
                        .HasForeignKey("EscolaridadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleEmpregadosApi.Models.Funcao", "Funcao")
                        .WithMany()
                        .HasForeignKey("FuncaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escolaridade");

                    b.Navigation("Funcao");
                });
#pragma warning restore 612, 618
        }
    }
}
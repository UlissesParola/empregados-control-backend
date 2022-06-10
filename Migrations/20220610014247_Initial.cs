using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControleEmpregadosApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Escolaridades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NivelEscolaridade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolaridades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeFuncao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empregados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Matricula = table.Column<string>(type: "text", nullable: false),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DataDeNascimento = table.Column<string>(type: "text", nullable: false),
                    FuncaoId = table.Column<int>(type: "integer", nullable: false),
                    EscolaridadeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empregados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empregados_Escolaridades_EscolaridadeId",
                        column: x => x.EscolaridadeId,
                        principalTable: "Escolaridades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empregados_Funcoes_FuncaoId",
                        column: x => x.FuncaoId,
                        principalTable: "Funcoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Escolaridades",
                columns: new[] { "Id", "NivelEscolaridade" },
                values: new object[,]
                {
                    { 1, "Ensino Médio Completo" },
                    { 2, "Ensino Superior Incompleto" },
                    { 3, "Ensino Superior Completo" },
                    { 4, "Pós-Graduação" },
                    { 5, "Mestrado" },
                    { 6, "Doutorado" }
                });

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "NomeFuncao" },
                values: new object[,]
                {
                    { 1, "Técnico Bancário Novo" },
                    { 2, "Escriturário" },
                    { 3, "Auxiliar Operacional" },
                    { 4, "Assistente Junior" },
                    { 5, "Assistente Junior 6hrs" },
                    { 6, "Assistente Pleno" },
                    { 7, "Assistente Senior" },
                    { 8, "Supervisor Central Filial" },
                    { 9, "Coordenador Central Filial" },
                    { 10, "Gerente Centralizadora" }
                });

            migrationBuilder.InsertData(
                table: "Empregados",
                columns: new[] { "Id", "DataDeNascimento", "EscolaridadeId", "FuncaoId", "Matricula", "Nome" },
                values: new object[] { 1, "29/06/1984", 4, 1, "c071615", "Ulisses Parola" });

            migrationBuilder.CreateIndex(
                name: "IX_Empregados_EscolaridadeId",
                table: "Empregados",
                column: "EscolaridadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Empregados_FuncaoId",
                table: "Empregados",
                column: "FuncaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empregados");

            migrationBuilder.DropTable(
                name: "Escolaridades");

            migrationBuilder.DropTable(
                name: "Funcoes");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvelockAPI.Migrations
{
    /// <inheritdoc />
    public partial class TableFuncionarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(15)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    Admissao = table.Column<DateTime>(type: "date", nullable: true),
                    Demissao = table.Column<DateTime>(type: "date", nullable: true),
                    Nascimento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}

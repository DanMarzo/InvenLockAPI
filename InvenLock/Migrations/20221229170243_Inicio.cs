using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstoqueEquipamentos",
                columns: table => new
                {
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(250)", nullable: true),
                    NomeEquip = table.Column<string>(type: "varchar(20)", nullable: true),
                    Fabricante = table.Column<int>(type: "int", nullable: false),
                    DataCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFimEquip = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueEquipamentos", x => x.EstoqueEquipamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: true),
                    Admissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Demissao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cpf = table.Column<string>(type: "char(11)", nullable: true),
                    Situacao = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FotoFuncionario = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CelPessoal = table.Column<string>(type: "char(11)", nullable: true),
                    Ramal = table.Column<string>(type: "char(4)", nullable: true),
                    EmailCorp = table.Column<string>(type: "varchar(70)", nullable: true),
                    EmailPessoal = table.Column<string>(type: "varchar(70)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioId);
                });

            migrationBuilder.CreateTable(
                name: "ManutEquips",
                columns: table => new
                {
                    ManutEquipId = table.Column<int>(type: "int", nullable: false),
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Desc = table.Column<string>(type: "varchar(250)", nullable: true),
                    Situacao = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManutEquips", x => x.ManutEquipId);
                    table.ForeignKey(
                        name: "FK_ManutEquips_EstoqueEquipamentos_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamentos",
                        principalColumn: "EstoqueEquipamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormEmprestimos",
                columns: table => new
                {
                    FormEmprestimoId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    Devolucao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Emissao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormEmprestimos", x => x.FormEmprestimoId);
                    table.ForeignKey(
                        name: "FK_FormEmprestimos_EstoqueEquipamentos_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamentos",
                        principalColumn: "EstoqueEquipamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormEmprestimos_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencias",
                columns: table => new
                {
                    OcorrenciaId = table.Column<int>(type: "int", nullable: false),
                    ManutEquipId = table.Column<int>(type: "int", nullable: true),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    IdEquipamento = table.Column<int>(type: "int", nullable: false),
                    DescOcorrencia = table.Column<string>(type: "varchar(250)", nullable: true),
                    DataOcorrencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencias", x => x.OcorrenciaId);
                    table.ForeignKey(
                        name: "FK_Ocorrencias_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocorrencias_ManutEquips_ManutEquipId",
                        column: x => x.ManutEquipId,
                        principalTable: "ManutEquips",
                        principalColumn: "ManutEquipId");
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Admissao", "CelPessoal", "Cpf", "Demissao", "EmailCorp", "EmailPessoal", "FotoFuncionario", "Nome", "PasswordHash", "PasswordSalt", "Ramal", "Situacao" },
                values: new object[] { 1, new DateTime(2022, 12, 29, 14, 2, 42, 996, DateTimeKind.Local).AddTicks(6896), "11955008212", "12345678901", null, "marzogildan@invenlock.com", "marzogildan@gmail.com", null, "Dan", new byte[] { 177, 241, 203, 59, 188, 130, 252, 25, 252, 71, 76, 97, 128, 205, 184, 227, 192, 8, 240, 201, 208, 83, 15, 35, 188, 201, 183, 131, 101, 97, 233, 181, 195, 249, 11, 205, 59, 52, 198, 247, 127, 206, 43, 251, 98, 70, 250, 45, 46, 114, 150, 140, 225, 241, 112, 237, 187, 200, 203, 95, 152, 160, 176, 134 }, new byte[] { 43, 60, 194, 249, 158, 102, 35, 204, 100, 51, 177, 228, 173, 54, 30, 22, 209, 186, 117, 112, 57, 218, 100, 241, 60, 112, 218, 90, 115, 206, 157, 164, 194, 149, 40, 229, 9, 251, 99, 8, 42, 182, 58, 150, 226, 87, 14, 70, 140, 82, 69, 122, 105, 3, 104, 70, 245, 212, 132, 40, 241, 60, 9, 49, 57, 194, 185, 1, 195, 53, 10, 165, 203, 141, 104, 99, 182, 68, 1, 172, 57, 138, 46, 95, 3, 175, 31, 84, 114, 112, 80, 5, 2, 64, 45, 115, 255, 114, 66, 60, 114, 32, 251, 76, 89, 119, 56, 35, 187, 21, 104, 152, 28, 142, 163, 151, 187, 75, 175, 81, 49, 75, 190, 235, 47, 122, 193, 118 }, "1010", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_FormEmprestimos_EstoqueEquipamentoId",
                table: "FormEmprestimos",
                column: "EstoqueEquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmprestimos_FuncionarioId",
                table: "FormEmprestimos",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ManutEquips_EstoqueEquipamentoId",
                table: "ManutEquips",
                column: "EstoqueEquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_FuncionarioId",
                table: "Ocorrencias",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_ManutEquipId",
                table: "Ocorrencias",
                column: "ManutEquipId",
                unique: true,
                filter: "[ManutEquipId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormEmprestimos");

            migrationBuilder.DropTable(
                name: "Ocorrencias");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "ManutEquips");

            migrationBuilder.DropTable(
                name: "EstoqueEquipamentos");
        }
    }
}

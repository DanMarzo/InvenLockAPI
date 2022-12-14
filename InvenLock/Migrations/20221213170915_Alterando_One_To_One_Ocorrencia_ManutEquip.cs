using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoOneToOneOcorrenciaManutEquip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstoqueEquipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_EstoqueEquipamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManutEquips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Desc = table.Column<string>(type: "varchar(250)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManutEquips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManutEquips_EstoqueEquipamentos_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SucataEquips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    DsOcorrido = table.Column<string>(type: "varchar(250)", nullable: true),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucataEquips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SucataEquips_EstoqueEquipamentos_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormEmprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    Devolucao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Emissao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormEmprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmprestimos_EstoqueEquipamentos_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormEmprestimos_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManutEquipId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    DescOcorrencia = table.Column<string>(type: "varchar(250)", nullable: true),
                    DataOcorrencia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocorrencias_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocorrencias_ManutEquips_ManutEquipId",
                        column: x => x.ManutEquipId,
                        principalTable: "ManutEquips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Admissao", "CelPessoal", "Cpf", "Demissao", "EmailCorp", "EmailPessoal", "FotoFuncionario", "Nome", "PasswordHash", "PasswordSalt", "Ramal", "Situacao" },
                values: new object[] { 1, new DateTime(2022, 12, 13, 14, 9, 15, 104, DateTimeKind.Local).AddTicks(6175), "11955008212", "12345678901", null, "marzogildan@invenlock.com", "marzogildan@gmail.com", null, "Dan", new byte[] { 27, 251, 167, 145, 204, 94, 6, 173, 0, 1, 164, 164, 213, 19, 148, 203, 229, 236, 119, 139, 192, 130, 28, 28, 40, 16, 48, 81, 7, 75, 174, 214, 45, 118, 219, 10, 198, 44, 202, 102, 205, 249, 84, 121, 232, 60, 30, 135, 125, 136, 191, 67, 198, 242, 32, 133, 196, 109, 97, 168, 11, 81, 219, 140 }, new byte[] { 71, 87, 81, 149, 1, 152, 242, 207, 210, 108, 188, 27, 67, 27, 174, 191, 112, 243, 137, 219, 109, 16, 7, 231, 146, 213, 168, 193, 167, 71, 28, 239, 196, 51, 235, 69, 184, 48, 205, 109, 253, 189, 86, 46, 97, 2, 116, 13, 31, 244, 165, 20, 20, 128, 34, 220, 22, 64, 172, 185, 239, 54, 106, 195, 134, 83, 12, 208, 152, 240, 124, 203, 160, 25, 86, 253, 106, 41, 120, 152, 149, 237, 139, 110, 170, 146, 243, 171, 178, 194, 179, 122, 26, 225, 9, 90, 86, 13, 109, 191, 251, 248, 36, 110, 243, 58, 117, 126, 179, 143, 31, 228, 185, 68, 121, 80, 161, 103, 73, 203, 46, 83, 93, 178, 74, 203, 152, 81 }, "1010", 1 });

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
                column: "EstoqueEquipamentoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_FuncionarioId",
                table: "Ocorrencias",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_ManutEquipId",
                table: "Ocorrencias",
                column: "ManutEquipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SucataEquips_EstoqueEquipamentoId",
                table: "SucataEquips",
                column: "EstoqueEquipamentoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormEmprestimos");

            migrationBuilder.DropTable(
                name: "Ocorrencias");

            migrationBuilder.DropTable(
                name: "SucataEquips");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "ManutEquips");

            migrationBuilder.DropTable(
                name: "EstoqueEquipamentos");
        }
    }
}

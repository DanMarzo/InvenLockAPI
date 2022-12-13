using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class RetirandoContato : Migration
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
                });

            migrationBuilder.CreateTable(
                name: "ManutEquips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    OcorrenciaId = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_ManutEquips_Ocorrencias_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Admissao", "CelPessoal", "Cpf", "Demissao", "EmailCorp", "EmailPessoal", "FotoFuncionario", "Nome", "PasswordHash", "PasswordSalt", "Ramal", "Situacao" },
                values: new object[] { 1, new DateTime(2022, 12, 13, 13, 6, 16, 5, DateTimeKind.Local).AddTicks(4695), "11955008212", "12345678901", null, "marzogildan@invenlock.com", "marzogildan@gmail.com", null, "Dan", new byte[] { 219, 98, 106, 66, 97, 109, 100, 117, 161, 119, 36, 129, 222, 138, 2, 127, 36, 25, 190, 238, 96, 222, 36, 229, 247, 213, 154, 154, 223, 91, 72, 129, 253, 147, 225, 48, 119, 246, 103, 53, 253, 4, 42, 192, 174, 176, 222, 241, 201, 125, 15, 23, 61, 58, 206, 104, 124, 129, 113, 129, 243, 94, 229, 96 }, new byte[] { 105, 139, 107, 110, 0, 137, 150, 195, 40, 123, 12, 179, 53, 252, 143, 8, 161, 211, 68, 136, 178, 191, 149, 185, 250, 125, 214, 51, 32, 120, 250, 17, 245, 75, 116, 17, 28, 46, 24, 107, 54, 201, 117, 174, 182, 100, 114, 172, 242, 179, 157, 152, 15, 74, 125, 193, 0, 56, 154, 7, 112, 242, 209, 157, 100, 84, 67, 203, 52, 149, 60, 165, 207, 52, 247, 28, 238, 254, 233, 53, 15, 113, 241, 42, 45, 10, 0, 251, 47, 123, 227, 111, 33, 215, 111, 107, 249, 171, 95, 216, 244, 128, 209, 222, 235, 90, 228, 231, 50, 164, 111, 75, 80, 77, 39, 185, 144, 184, 110, 224, 91, 30, 252, 80, 2, 208, 116, 111 }, "1010", 1 });

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
                name: "IX_ManutEquips_OcorrenciaId",
                table: "ManutEquips",
                column: "OcorrenciaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_FuncionarioId",
                table: "Ocorrencias",
                column: "FuncionarioId");

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
                name: "ManutEquips");

            migrationBuilder.DropTable(
                name: "SucataEquips");

            migrationBuilder.DropTable(
                name: "Ocorrencias");

            migrationBuilder.DropTable(
                name: "EstoqueEquipamentos");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}

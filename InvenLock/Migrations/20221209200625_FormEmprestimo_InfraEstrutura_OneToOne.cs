using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class FormEmprestimoInfraEstruturaOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstoqueEquipamento",
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
                    table.PrimaryKey("PK_EstoqueEquipamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencias", x => x.Id);
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
                        name: "FK_SucataEquips_EstoqueEquipamento_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuncionarioContatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    CelPessoal = table.Column<string>(type: "char(11)", nullable: true),
                    RamalCorporativo = table.Column<string>(type: "char(4)", nullable: true),
                    EmailPessoal = table.Column<string>(type: "varchar(70)", nullable: true),
                    EmailCorporativo = table.Column<string>(type: "varchar(70)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionarioContatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuncionarioContatos_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfraFuncionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfraFuncionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfraFuncionarios_Funcionarios_FuncionarioId",
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
                        name: "FK_ManutEquips_EstoqueEquipamento_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManutEquips_Ocorrencias_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencias",
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
                    InfraFuncionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormEmprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmprestimos_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormEmprestimos_InfraFuncionarios_InfraFuncionarioId",
                        column: x => x.InfraFuncionarioId,
                        principalTable: "InfraFuncionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmprestimoEquip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    FormEmprestimoId = table.Column<int>(type: "int", nullable: false),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmprestimoEquip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmprestimoEquip_EstoqueEquipamento_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmprestimoEquip_FormEmprestimos_FormEmprestimoId",
                        column: x => x.FormEmprestimoId,
                        principalTable: "FormEmprestimos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimoEquip_EstoqueEquipamentoId",
                table: "EmprestimoEquip",
                column: "EstoqueEquipamentoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimoEquip_FormEmprestimoId",
                table: "EmprestimoEquip",
                column: "FormEmprestimoId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmprestimos_FuncionarioId",
                table: "FormEmprestimos",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmprestimos_InfraFuncionarioId",
                table: "FormEmprestimos",
                column: "InfraFuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioContatos_FuncionarioId",
                table: "FuncionarioContatos",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InfraFuncionarios_FuncionarioId",
                table: "InfraFuncionarios",
                column: "FuncionarioId",
                unique: true);

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
                name: "IX_SucataEquips_EstoqueEquipamentoId",
                table: "SucataEquips",
                column: "EstoqueEquipamentoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmprestimoEquip");

            migrationBuilder.DropTable(
                name: "FuncionarioContatos");

            migrationBuilder.DropTable(
                name: "ManutEquips");

            migrationBuilder.DropTable(
                name: "SucataEquips");

            migrationBuilder.DropTable(
                name: "FormEmprestimos");

            migrationBuilder.DropTable(
                name: "Ocorrencias");

            migrationBuilder.DropTable(
                name: "EstoqueEquipamento");

            migrationBuilder.DropTable(
                name: "InfraFuncionarios");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}

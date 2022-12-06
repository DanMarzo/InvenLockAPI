using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class novaTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipSucatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DsOcorrido = table.Column<string>(type: "varchar(250)", nullable: true),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipSucatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: true),
                    SobreNome = table.Column<string>(type: "varchar(20)", nullable: true),
                    Admissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Demissao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cpf = table.Column<string>(type: "char(11)", nullable: true),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContatoFuncs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true),
                    CelPessoal = table.Column<string>(type: "char(11)", nullable: true),
                    RamalCorporativo = table.Column<string>(type: "char(4)", nullable: true),
                    EmailPessoal = table.Column<string>(type: "varchar(70)", nullable: true),
                    EmailCorporativo = table.Column<string>(type: "varchar(70)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoFuncs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContatoFuncs_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FuncInfras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFunc = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true),
                    TipoFunc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncInfras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuncInfras_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFunc = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true),
                    DescOcorrencia = table.Column<string>(type: "varchar(250)", nullable: true),
                    DataOcorrencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEquip = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ocorrencias_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormEmprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEquipEmprestimo = table.Column<int>(type: "int", nullable: false),
                    IdFunc = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: true),
                    IdTecnico = table.Column<int>(type: "int", nullable: false),
                    FuncInfraId = table.Column<int>(type: "int", nullable: true),
                    Devolucao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Emissao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormEmprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormEmprestimos_FuncInfras_FuncInfraId",
                        column: x => x.FuncInfraId,
                        principalTable: "FuncInfras",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormEmprestimos_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EquipManuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOcorrencia = table.Column<int>(type: "int", nullable: false),
                    OcorrenciaId = table.Column<int>(type: "int", nullable: true),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Desc = table.Column<string>(type: "varchar(250)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipManuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipManuts_Ocorrencias_OcorrenciaId",
                        column: x => x.OcorrenciaId,
                        principalTable: "Ocorrencias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EquipEmprestimo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdForm = table.Column<int>(type: "int", nullable: false),
                    FormEmprestimoId = table.Column<int>(type: "int", nullable: true),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipEmprestimo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipEmprestimo_FormEmprestimos_FormEmprestimoId",
                        column: x => x.FormEmprestimoId,
                        principalTable: "FormEmprestimos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EstoqueEquips",
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
                    DataFimEquip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EquipEmprestimoId = table.Column<int>(type: "int", nullable: true),
                    EquipManutId = table.Column<int>(type: "int", nullable: true),
                    EquipSucataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueEquips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstoqueEquips_EquipEmprestimo_EquipEmprestimoId",
                        column: x => x.EquipEmprestimoId,
                        principalTable: "EquipEmprestimo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EstoqueEquips_EquipManuts_EquipManutId",
                        column: x => x.EquipManutId,
                        principalTable: "EquipManuts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EstoqueEquips_EquipSucatas_EquipSucataId",
                        column: x => x.EquipSucataId,
                        principalTable: "EquipSucatas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContatoFuncs_FuncionarioId",
                table: "ContatoFuncs",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipEmprestimo_FormEmprestimoId",
                table: "EquipEmprestimo",
                column: "FormEmprestimoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipManuts_OcorrenciaId",
                table: "EquipManuts",
                column: "OcorrenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueEquips_EquipEmprestimoId",
                table: "EstoqueEquips",
                column: "EquipEmprestimoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueEquips_EquipManutId",
                table: "EstoqueEquips",
                column: "EquipManutId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueEquips_EquipSucataId",
                table: "EstoqueEquips",
                column: "EquipSucataId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmprestimos_FuncInfraId",
                table: "FormEmprestimos",
                column: "FuncInfraId");

            migrationBuilder.CreateIndex(
                name: "IX_FormEmprestimos_FuncionarioId",
                table: "FormEmprestimos",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_FuncInfras_FuncionarioId",
                table: "FuncInfras",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_FuncionarioId",
                table: "Ocorrencias",
                column: "FuncionarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContatoFuncs");

            migrationBuilder.DropTable(
                name: "EstoqueEquips");

            migrationBuilder.DropTable(
                name: "EquipEmprestimo");

            migrationBuilder.DropTable(
                name: "EquipManuts");

            migrationBuilder.DropTable(
                name: "EquipSucatas");

            migrationBuilder.DropTable(
                name: "FormEmprestimos");

            migrationBuilder.DropTable(
                name: "Ocorrencias");

            migrationBuilder.DropTable(
                name: "FuncInfras");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}

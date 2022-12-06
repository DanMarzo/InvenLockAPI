using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class InserindoDadosAlterados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueEquips_EquipManuts_EquipManutId",
                table: "EstoqueEquips");

            migrationBuilder.DropIndex(
                name: "IX_EstoqueEquips_EquipManutId",
                table: "EstoqueEquips");

            migrationBuilder.DropColumn(
                name: "EquipManutId",
                table: "EstoqueEquips");

            migrationBuilder.AddColumn<int>(
                name: "EstoqueEquipId",
                table: "EquipManuts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEquip",
                table: "EquipManuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "EquipEmprestimo",
                columns: new[] { "Id", "DataDevolucao", "DataEmprestimo", "FormEmprestimoId", "IdForm" },
                values: new object[] { 1, null, new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9738), null, 1 });

            migrationBuilder.InsertData(
                table: "EquipManuts",
                columns: new[] { "Id", "DataEntrada", "DataSaida", "Desc", "EstoqueEquipId", "IdEquip", "IdOcorrencia", "OcorrenciaId", "Status" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9564), null, "O infeliz molhou", null, 2, 1, null, 2 });

            migrationBuilder.InsertData(
                table: "EstoqueEquips",
                columns: new[] { "Id", "DataCompra", "DataFimEquip", "Descricao", "EquipEmprestimoId", "EquipSucataId", "Fabricante", "NomeEquip", "Situacao", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9080), null, "Notebook empresarial", null, null, 4, "DAN-DESKTOP-001", 4, 1 },
                    { 2, new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9097), null, "Maquina empresarial em posse do Thiago", null, null, 1, "THI-DESKTOP-002", 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "FormEmprestimos",
                columns: new[] { "Id", "Devolucao", "Emissao", "FuncInfraId", "FuncionarioId", "IdEquipEmprestimo", "IdFunc", "IdTecnico" },
                values: new object[] { 1, null, new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9812), null, null, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "FuncInfras",
                columns: new[] { "Id", "FuncionarioId", "IdFunc", "TipoFunc" },
                values: new object[] { 1, null, 1, 3 });

            migrationBuilder.InsertData(
                table: "Ocorrencias",
                columns: new[] { "Id", "DataOcorrencia", "DescOcorrencia", "FuncionarioId", "IdEquip", "IdFunc" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9665), "O infeliz deixo cair na agua", null, 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_EquipManuts_EstoqueEquipId",
                table: "EquipManuts",
                column: "EstoqueEquipId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipManuts_EstoqueEquips_EstoqueEquipId",
                table: "EquipManuts",
                column: "EstoqueEquipId",
                principalTable: "EstoqueEquips",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipManuts_EstoqueEquips_EstoqueEquipId",
                table: "EquipManuts");

            migrationBuilder.DropIndex(
                name: "IX_EquipManuts_EstoqueEquipId",
                table: "EquipManuts");

            migrationBuilder.DeleteData(
                table: "EquipEmprestimo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipManuts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstoqueEquips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstoqueEquips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormEmprestimos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FuncInfras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ocorrencias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "EstoqueEquipId",
                table: "EquipManuts");

            migrationBuilder.DropColumn(
                name: "IdEquip",
                table: "EquipManuts");

            migrationBuilder.AddColumn<int>(
                name: "EquipManutId",
                table: "EstoqueEquips",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueEquips_EquipManutId",
                table: "EstoqueEquips",
                column: "EquipManutId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueEquips_EquipManuts_EquipManutId",
                table: "EstoqueEquips",
                column: "EquipManutId",
                principalTable: "EquipManuts",
                principalColumn: "Id");
        }
    }
}

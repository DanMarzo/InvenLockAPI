using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class NovaRelacao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmprestimoEquip_EstoqueEquipamento_EstoqueEquipamentoId",
                table: "EmprestimoEquip");

            migrationBuilder.DropForeignKey(
                name: "FK_ManutEquips_EstoqueEquipamento_EstoqueEquipamentoId",
                table: "ManutEquips");

            migrationBuilder.DropForeignKey(
                name: "FK_SucataEquips_EstoqueEquipamento_EstoqueEquipamentoId",
                table: "SucataEquips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstoqueEquipamento",
                table: "EstoqueEquipamento");

            migrationBuilder.RenameTable(
                name: "EstoqueEquipamento",
                newName: "EstoqueEquipamentos");

            migrationBuilder.RenameColumn(
                name: "SobreNome",
                table: "Funcionarios",
                newName: "Nome");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstoqueEquipamentos",
                table: "EstoqueEquipamentos",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Admissao", "Cpf", "Demissao", "FotoFuncionario", "Nome", "PasswordHash", "PasswordSalt", "Situacao" },
                values: new object[] { 1, new DateTime(2022, 12, 10, 23, 14, 3, 522, DateTimeKind.Local).AddTicks(1753), "12345678901", null, null, "Dan", new byte[] { 195, 198, 248, 164, 243, 116, 172, 127, 162, 122, 244, 94, 226, 97, 164, 249, 30, 223, 241, 212, 180, 231, 252, 149, 4, 123, 5, 9, 57, 32, 96, 42, 238, 203, 123, 177, 182, 8, 223, 9, 40, 181, 7, 47, 51, 251, 164, 156, 131, 120, 23, 113, 26, 224, 96, 149, 24, 223, 152, 114, 149, 232, 219, 179 }, new byte[] { 223, 156, 219, 65, 4, 94, 155, 226, 174, 55, 247, 100, 254, 89, 70, 84, 111, 110, 117, 60, 129, 137, 74, 161, 171, 81, 192, 158, 51, 113, 187, 170, 142, 117, 18, 210, 176, 250, 167, 202, 148, 189, 166, 240, 22, 46, 201, 84, 113, 50, 238, 89, 29, 139, 27, 101, 146, 52, 235, 50, 253, 50, 189, 145, 200, 151, 4, 63, 186, 194, 35, 241, 201, 68, 125, 9, 14, 221, 124, 220, 86, 149, 47, 195, 23, 158, 188, 142, 238, 246, 84, 106, 31, 226, 106, 192, 37, 10, 209, 222, 245, 231, 194, 55, 50, 255, 168, 166, 19, 214, 94, 223, 42, 209, 121, 200, 109, 168, 52, 138, 234, 59, 184, 76, 147, 89, 161, 233 }, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_EmprestimoEquip_EstoqueEquipamentos_EstoqueEquipamentoId",
                table: "EmprestimoEquip",
                column: "EstoqueEquipamentoId",
                principalTable: "EstoqueEquipamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManutEquips_EstoqueEquipamentos_EstoqueEquipamentoId",
                table: "ManutEquips",
                column: "EstoqueEquipamentoId",
                principalTable: "EstoqueEquipamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SucataEquips_EstoqueEquipamentos_EstoqueEquipamentoId",
                table: "SucataEquips",
                column: "EstoqueEquipamentoId",
                principalTable: "EstoqueEquipamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmprestimoEquip_EstoqueEquipamentos_EstoqueEquipamentoId",
                table: "EmprestimoEquip");

            migrationBuilder.DropForeignKey(
                name: "FK_ManutEquips_EstoqueEquipamentos_EstoqueEquipamentoId",
                table: "ManutEquips");

            migrationBuilder.DropForeignKey(
                name: "FK_SucataEquips_EstoqueEquipamentos_EstoqueEquipamentoId",
                table: "SucataEquips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstoqueEquipamentos",
                table: "EstoqueEquipamentos");

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "EstoqueEquipamentos",
                newName: "EstoqueEquipamento");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Funcionarios",
                newName: "SobreNome");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstoqueEquipamento",
                table: "EstoqueEquipamento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmprestimoEquip_EstoqueEquipamento_EstoqueEquipamentoId",
                table: "EmprestimoEquip",
                column: "EstoqueEquipamentoId",
                principalTable: "EstoqueEquipamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManutEquips_EstoqueEquipamento_EstoqueEquipamentoId",
                table: "ManutEquips",
                column: "EstoqueEquipamentoId",
                principalTable: "EstoqueEquipamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SucataEquips_EstoqueEquipamento_EstoqueEquipamentoId",
                table: "SucataEquips",
                column: "EstoqueEquipamentoId",
                principalTable: "EstoqueEquipamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class InserindoDadosPelaSegundaVez : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EquipEmprestimo",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEmprestimo",
                value: new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "EquipManuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "EstoqueEquips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCompra",
                value: new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "EstoqueEquips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCompra",
                value: new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "FormEmprestimos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Emissao",
                value: new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Admissao", "Cpf", "Demissao", "Nome", "PasswordHash", "PasswordSalt", "Situacao", "SobreNome" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 17, 47, 5, 456, DateTimeKind.Local).AddTicks(1301), "12345678901", null, "Dan", new byte[] { 248, 126, 126, 192, 224, 237, 109, 250, 123, 5, 47, 181, 43, 144, 221, 100, 250, 143, 92, 163, 87, 134, 71, 86, 38, 110, 159, 98, 153, 83, 57, 219, 115, 62, 170, 125, 127, 215, 88, 236, 245, 9, 106, 248, 110, 92, 177, 150, 11, 245, 3, 161, 234, 238, 54, 199, 250, 106, 198, 6, 34, 80, 113, 67 }, new byte[] { 123, 155, 155, 8, 130, 182, 155, 134, 38, 250, 229, 183, 121, 214, 173, 143, 29, 176, 205, 213, 60, 196, 176, 160, 107, 128, 186, 23, 154, 83, 52, 225, 225, 189, 94, 227, 7, 240, 150, 227, 63, 211, 233, 11, 186, 228, 229, 168, 62, 135, 207, 20, 27, 17, 55, 75, 250, 33, 2, 214, 90, 102, 111, 50, 213, 162, 221, 241, 194, 136, 39, 28, 164, 10, 111, 134, 83, 161, 12, 143, 144, 137, 228, 206, 101, 204, 138, 109, 165, 162, 198, 64, 94, 125, 50, 88, 208, 169, 233, 30, 161, 188, 83, 46, 31, 175, 26, 106, 56, 243, 232, 70, 4, 24, 1, 156, 11, 47, 78, 212, 109, 129, 140, 29, 233, 60, 197, 95 }, 1, "Marzo" });

            migrationBuilder.UpdateData(
                table: "Ocorrencias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOcorrencia",
                value: new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9546));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "EquipEmprestimo",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEmprestimo",
                value: new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "EquipManuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "EstoqueEquips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCompra",
                value: new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "EstoqueEquips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCompra",
                value: new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "FormEmprestimos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Emissao",
                value: new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Ocorrencias",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOcorrencia",
                value: new DateTime(2022, 12, 6, 17, 37, 13, 714, DateTimeKind.Local).AddTicks(9665));
        }
    }
}

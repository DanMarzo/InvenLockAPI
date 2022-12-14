using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class alteracaoOcorrencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ManutEquips");

            migrationBuilder.AddColumn<int>(
                name: "Situacao",
                table: "Ocorrencias",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Situacao",
                table: "ManutEquips",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Admissao", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 13, 16, 21, 22, 397, DateTimeKind.Local).AddTicks(274), new byte[] { 66, 250, 107, 232, 243, 170, 145, 252, 123, 29, 187, 240, 63, 191, 89, 163, 165, 34, 188, 197, 164, 105, 48, 75, 178, 238, 158, 35, 72, 229, 213, 96, 14, 144, 135, 71, 49, 36, 250, 214, 21, 151, 77, 212, 67, 64, 221, 183, 165, 221, 239, 177, 21, 146, 41, 52, 240, 43, 138, 139, 236, 0, 234, 190 }, new byte[] { 181, 201, 186, 16, 47, 177, 199, 122, 184, 76, 161, 7, 30, 168, 239, 9, 163, 13, 127, 118, 125, 130, 211, 213, 140, 175, 214, 249, 83, 74, 121, 217, 74, 60, 99, 231, 186, 2, 40, 60, 71, 76, 183, 65, 164, 250, 162, 87, 195, 17, 178, 164, 234, 6, 187, 39, 15, 212, 160, 126, 211, 221, 94, 96, 39, 76, 106, 233, 15, 92, 95, 162, 155, 141, 251, 5, 211, 103, 149, 55, 9, 65, 36, 72, 23, 220, 125, 34, 68, 50, 92, 17, 30, 134, 190, 8, 160, 5, 164, 172, 179, 46, 195, 100, 24, 27, 136, 21, 165, 1, 93, 215, 210, 74, 179, 29, 213, 99, 187, 100, 126, 202, 221, 166, 77, 212, 255, 78 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Ocorrencias");

            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "ManutEquips");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ManutEquips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Admissao", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 13, 14, 56, 31, 31, DateTimeKind.Local).AddTicks(6615), new byte[] { 15, 25, 110, 147, 200, 59, 107, 238, 180, 152, 41, 84, 94, 61, 181, 107, 178, 8, 55, 146, 169, 143, 52, 99, 89, 208, 123, 109, 175, 125, 46, 87, 74, 220, 162, 40, 105, 133, 55, 201, 8, 29, 139, 196, 241, 24, 197, 188, 176, 138, 230, 184, 46, 29, 132, 17, 99, 248, 133, 126, 102, 192, 143, 161 }, new byte[] { 194, 209, 173, 154, 86, 69, 101, 68, 249, 195, 189, 150, 160, 38, 91, 14, 63, 108, 117, 204, 77, 37, 147, 122, 241, 163, 26, 93, 107, 62, 36, 236, 250, 8, 166, 207, 225, 26, 182, 102, 177, 19, 224, 157, 167, 145, 68, 68, 150, 143, 201, 71, 73, 41, 112, 243, 192, 238, 60, 158, 192, 191, 181, 94, 211, 36, 68, 160, 14, 56, 41, 168, 82, 114, 152, 111, 49, 250, 22, 49, 236, 191, 39, 192, 187, 175, 250, 7, 170, 224, 98, 190, 166, 139, 253, 16, 12, 43, 119, 202, 164, 148, 246, 96, 191, 112, 158, 56, 51, 83, 43, 101, 94, 77, 27, 120, 243, 14, 166, 96, 197, 48, 153, 230, 32, 248, 183, 185 } });
        }
    }
}

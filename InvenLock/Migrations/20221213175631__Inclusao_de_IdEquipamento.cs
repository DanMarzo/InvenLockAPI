using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class InclusaodeIdEquipamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEquipamento",
                table: "Ocorrencias",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEquipamento",
                table: "Ocorrencias");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Admissao", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 13, 14, 9, 15, 104, DateTimeKind.Local).AddTicks(6175), new byte[] { 27, 251, 167, 145, 204, 94, 6, 173, 0, 1, 164, 164, 213, 19, 148, 203, 229, 236, 119, 139, 192, 130, 28, 28, 40, 16, 48, 81, 7, 75, 174, 214, 45, 118, 219, 10, 198, 44, 202, 102, 205, 249, 84, 121, 232, 60, 30, 135, 125, 136, 191, 67, 198, 242, 32, 133, 196, 109, 97, 168, 11, 81, 219, 140 }, new byte[] { 71, 87, 81, 149, 1, 152, 242, 207, 210, 108, 188, 27, 67, 27, 174, 191, 112, 243, 137, 219, 109, 16, 7, 231, 146, 213, 168, 193, 167, 71, 28, 239, 196, 51, 235, 69, 184, 48, 205, 109, 253, 189, 86, 46, 97, 2, 116, 13, 31, 244, 165, 20, 20, 128, 34, 220, 22, 64, 172, 185, 239, 54, 106, 195, 134, 83, 12, 208, 152, 240, 124, 203, 160, 25, 86, 253, 106, 41, 120, 152, 149, 237, 139, 110, 170, 146, 243, 171, 178, 194, 179, 122, 26, 225, 9, 90, 86, 13, 109, 191, 251, 248, 36, 110, 243, 58, 117, 126, 179, 143, 31, 228, 185, 68, 121, 80, 161, 103, 73, 203, 46, 83, 93, 178, 74, 203, 152, 81 } });
        }
    }
}

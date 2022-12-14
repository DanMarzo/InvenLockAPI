using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class PoisInterrogacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencias_ManutEquips_ManutEquipId",
                table: "Ocorrencias");

            migrationBuilder.DropIndex(
                name: "IX_Ocorrencias_ManutEquipId",
                table: "Ocorrencias");

            migrationBuilder.AlterColumn<int>(
                name: "ManutEquipId",
                table: "Ocorrencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Admissao", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 13, 20, 17, 57, 544, DateTimeKind.Local).AddTicks(2299), new byte[] { 103, 239, 47, 147, 112, 6, 94, 54, 163, 132, 151, 209, 247, 139, 94, 22, 145, 103, 48, 208, 151, 102, 41, 37, 137, 8, 197, 86, 11, 17, 240, 150, 48, 115, 173, 170, 35, 246, 164, 142, 240, 183, 86, 190, 251, 165, 187, 206, 25, 29, 194, 9, 131, 240, 9, 230, 201, 148, 116, 136, 110, 34, 83, 233 }, new byte[] { 18, 33, 86, 187, 101, 46, 60, 215, 92, 106, 154, 65, 240, 117, 198, 73, 192, 228, 75, 93, 125, 100, 44, 91, 69, 26, 2, 90, 19, 69, 42, 40, 46, 76, 200, 39, 205, 83, 117, 53, 142, 96, 93, 223, 65, 158, 13, 36, 132, 228, 95, 221, 23, 131, 137, 127, 67, 140, 186, 245, 124, 221, 43, 216, 202, 21, 189, 19, 179, 93, 210, 8, 192, 23, 4, 233, 51, 120, 198, 235, 37, 117, 168, 71, 97, 153, 120, 114, 139, 88, 57, 98, 50, 129, 175, 21, 76, 234, 104, 141, 203, 195, 59, 43, 197, 157, 24, 26, 194, 40, 193, 149, 85, 149, 79, 245, 189, 30, 130, 212, 210, 121, 188, 117, 155, 106, 27, 80 } });

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_ManutEquipId",
                table: "Ocorrencias",
                column: "ManutEquipId",
                unique: true,
                filter: "[ManutEquipId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencias_ManutEquips_ManutEquipId",
                table: "Ocorrencias",
                column: "ManutEquipId",
                principalTable: "ManutEquips",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocorrencias_ManutEquips_ManutEquipId",
                table: "Ocorrencias");

            migrationBuilder.DropIndex(
                name: "IX_Ocorrencias_ManutEquipId",
                table: "Ocorrencias");

            migrationBuilder.AlterColumn<int>(
                name: "ManutEquipId",
                table: "Ocorrencias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Admissao", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 13, 18, 59, 11, 194, DateTimeKind.Local).AddTicks(2757), new byte[] { 94, 109, 187, 253, 98, 28, 163, 125, 60, 144, 219, 83, 199, 206, 86, 157, 96, 217, 122, 79, 40, 102, 151, 103, 200, 238, 82, 236, 111, 181, 255, 85, 60, 142, 219, 199, 68, 45, 41, 27, 17, 23, 222, 35, 183, 242, 109, 149, 52, 137, 56, 128, 136, 137, 51, 52, 23, 249, 173, 20, 187, 220, 1, 80 }, new byte[] { 155, 46, 59, 23, 122, 94, 8, 208, 211, 15, 37, 208, 52, 83, 178, 46, 110, 175, 20, 5, 136, 44, 173, 47, 91, 69, 135, 141, 114, 132, 94, 32, 88, 140, 91, 239, 207, 134, 140, 152, 240, 118, 24, 157, 222, 200, 76, 8, 154, 44, 26, 245, 66, 35, 171, 0, 168, 67, 224, 108, 8, 227, 152, 195, 246, 170, 239, 249, 123, 26, 63, 20, 68, 69, 69, 136, 56, 2, 141, 189, 142, 164, 10, 229, 209, 224, 158, 68, 241, 65, 38, 201, 7, 7, 21, 17, 117, 193, 26, 13, 183, 14, 83, 7, 243, 204, 206, 153, 21, 30, 121, 23, 212, 251, 124, 77, 205, 142, 197, 229, 114, 233, 13, 207, 183, 163, 42, 169 } });

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencias_ManutEquipId",
                table: "Ocorrencias",
                column: "ManutEquipId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocorrencias_ManutEquips_ManutEquipId",
                table: "Ocorrencias",
                column: "ManutEquipId",
                principalTable: "ManutEquips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

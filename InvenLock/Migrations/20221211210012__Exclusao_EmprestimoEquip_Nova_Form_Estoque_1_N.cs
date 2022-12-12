using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvenLock.Migrations
{
    /// <inheritdoc />
    public partial class ExclusaoEmprestimoEquipNovaFormEstoque1N : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmprestimoEquip");

            migrationBuilder.AddColumn<int>(
                name: "EstoqueEquipamentoId",
                table: "FormEmprestimos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Admissao", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 11, 18, 0, 12, 85, DateTimeKind.Local).AddTicks(2964), new byte[] { 87, 168, 234, 193, 33, 196, 12, 140, 152, 96, 78, 46, 148, 228, 121, 55, 254, 158, 69, 63, 214, 102, 133, 102, 56, 135, 209, 222, 74, 103, 5, 249, 57, 127, 182, 132, 232, 137, 193, 156, 146, 189, 67, 52, 29, 95, 88, 93, 96, 10, 156, 185, 36, 180, 74, 244, 142, 69, 196, 188, 107, 200, 170, 238 }, new byte[] { 31, 136, 211, 28, 195, 95, 167, 185, 111, 151, 187, 81, 102, 60, 141, 145, 20, 151, 26, 60, 107, 170, 103, 69, 179, 47, 92, 129, 177, 79, 185, 6, 181, 252, 84, 241, 174, 154, 165, 94, 29, 71, 223, 121, 214, 64, 1, 67, 100, 164, 160, 239, 52, 59, 185, 174, 226, 38, 212, 57, 165, 94, 77, 133, 247, 84, 19, 133, 172, 111, 211, 144, 147, 89, 109, 96, 25, 1, 42, 109, 206, 235, 37, 190, 189, 247, 116, 186, 254, 90, 244, 106, 46, 47, 211, 250, 99, 248, 63, 149, 73, 121, 180, 45, 2, 214, 199, 29, 18, 15, 6, 196, 151, 43, 2, 176, 134, 182, 14, 226, 112, 234, 249, 21, 135, 158, 48, 155 } });

            migrationBuilder.CreateIndex(
                name: "IX_FormEmprestimos_EstoqueEquipamentoId",
                table: "FormEmprestimos",
                column: "EstoqueEquipamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormEmprestimos_EstoqueEquipamentos_EstoqueEquipamentoId",
                table: "FormEmprestimos",
                column: "EstoqueEquipamentoId",
                principalTable: "EstoqueEquipamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormEmprestimos_EstoqueEquipamentos_EstoqueEquipamentoId",
                table: "FormEmprestimos");

            migrationBuilder.DropIndex(
                name: "IX_FormEmprestimos_EstoqueEquipamentoId",
                table: "FormEmprestimos");

            migrationBuilder.DropColumn(
                name: "EstoqueEquipamentoId",
                table: "FormEmprestimos");

            migrationBuilder.CreateTable(
                name: "EmprestimoEquip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    FormEmprestimoId = table.Column<int>(type: "int", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmprestimoEquip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmprestimoEquip_EstoqueEquipamentos_EstoqueEquipamentoId",
                        column: x => x.EstoqueEquipamentoId,
                        principalTable: "EstoqueEquipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmprestimoEquip_FormEmprestimos_FormEmprestimoId",
                        column: x => x.FormEmprestimoId,
                        principalTable: "FormEmprestimos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Admissao", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 14, 3, 522, DateTimeKind.Local).AddTicks(1753), new byte[] { 195, 198, 248, 164, 243, 116, 172, 127, 162, 122, 244, 94, 226, 97, 164, 249, 30, 223, 241, 212, 180, 231, 252, 149, 4, 123, 5, 9, 57, 32, 96, 42, 238, 203, 123, 177, 182, 8, 223, 9, 40, 181, 7, 47, 51, 251, 164, 156, 131, 120, 23, 113, 26, 224, 96, 149, 24, 223, 152, 114, 149, 232, 219, 179 }, new byte[] { 223, 156, 219, 65, 4, 94, 155, 226, 174, 55, 247, 100, 254, 89, 70, 84, 111, 110, 117, 60, 129, 137, 74, 161, 171, 81, 192, 158, 51, 113, 187, 170, 142, 117, 18, 210, 176, 250, 167, 202, 148, 189, 166, 240, 22, 46, 201, 84, 113, 50, 238, 89, 29, 139, 27, 101, 146, 52, 235, 50, 253, 50, 189, 145, 200, 151, 4, 63, 186, 194, 35, 241, 201, 68, 125, 9, 14, 221, 124, 220, 86, 149, 47, 195, 23, 158, 188, 142, 238, 246, 84, 106, 31, 226, 106, 192, 37, 10, 209, 222, 245, 231, 194, 55, 50, 255, 168, 166, 19, 214, 94, 223, 42, 209, 121, 200, 109, 168, 52, 138, 234, 59, 184, 76, 147, 89, 161, 233 } });

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimoEquip_EstoqueEquipamentoId",
                table: "EmprestimoEquip",
                column: "EstoqueEquipamentoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmprestimoEquip_FormEmprestimoId",
                table: "EmprestimoEquip",
                column: "FormEmprestimoId");
        }
    }
}

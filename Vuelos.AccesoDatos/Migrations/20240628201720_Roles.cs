using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vuelos.Entities.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 18, 17, 20, 47, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 16, 17, 20, 47, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 20, 17, 20, 47, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 22, 17, 20, 47, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 14, 17, 20, 47, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 17, 37, 42, 290, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 15, 37, 42, 290, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 19, 37, 42, 290, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 21, 37, 42, 290, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 13, 37, 42, 290, DateTimeKind.Local).AddTicks(8683));
        }
    }
}

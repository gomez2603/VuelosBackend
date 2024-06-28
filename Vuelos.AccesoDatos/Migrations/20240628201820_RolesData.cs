using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vuelos.Entities.Migrations
{
    public partial class RolesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "BASICA" },
                    { 2, "PREMIUM" }
                });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 18, 18, 20, 497, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 16, 18, 20, 497, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 20, 18, 20, 497, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 22, 18, 20, 497, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 14, 18, 20, 497, DateTimeKind.Local).AddTicks(7736));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

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
        }
    }
}

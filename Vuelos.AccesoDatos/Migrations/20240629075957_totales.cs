using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vuelos.Entities.Migrations
{
    public partial class totales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 5, 59, 57, 505, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 3, 59, 57, 505, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 7, 59, 57, 505, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 9, 59, 57, 505, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 1, 59, 57, 505, DateTimeKind.Local).AddTicks(3239));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Reservaciones");

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 5, 29, 39, 659, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 3, 29, 39, 659, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 7, 29, 39, 659, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 9, 29, 39, 659, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Horario",
                value: new DateTime(2024, 6, 30, 1, 29, 39, 659, DateTimeKind.Local).AddTicks(8833));
        }
    }
}

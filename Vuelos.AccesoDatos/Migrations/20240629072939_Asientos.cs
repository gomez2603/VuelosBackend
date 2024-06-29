using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vuelos.Entities.Migrations
{
    public partial class Asientos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Asiento",
                table: "Reservaciones");

            migrationBuilder.AddColumn<string>(
                name: "Asientos",
                table: "Reservaciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Asientos",
                table: "Reservaciones");

            migrationBuilder.AddColumn<int>(
                name: "Asiento",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 18, 29, 6, 127, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 16, 29, 6, 127, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 20, 29, 6, 127, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 22, 29, 6, 127, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Horario",
                value: new DateTime(2024, 6, 29, 14, 29, 6, 127, DateTimeKind.Local).AddTicks(2663));
        }
    }
}

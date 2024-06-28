using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vuelos.Entities.Migrations
{
    public partial class DatosFaltantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aerolinea",
                table: "Vuelos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DuracionViaje",
                table: "Vuelos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Estatus",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aerolinea", "DuracionViaje", "Horario" },
                values: new object[] { "Volaris", "1:25", new DateTime(2024, 6, 29, 18, 29, 6, 127, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aerolinea", "DuracionViaje", "Horario" },
                values: new object[] { "AeroMexico", "2:35", new DateTime(2024, 6, 29, 16, 29, 6, 127, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Aerolinea", "DuracionViaje", "Horario" },
                values: new object[] { "Viva Aerobus", "1:45", new DateTime(2024, 6, 29, 20, 29, 6, 127, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aerolinea", "DuracionViaje", "Horario" },
                values: new object[] { "Volaris", "1:05", new DateTime(2024, 6, 29, 22, 29, 6, 127, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Aerolinea", "DuracionViaje", "Horario" },
                values: new object[] { "AeroMexico", "0:35", new DateTime(2024, 6, 29, 14, 29, 6, 127, DateTimeKind.Local).AddTicks(2663) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aerolinea",
                table: "Vuelos");

            migrationBuilder.DropColumn(
                name: "DuracionViaje",
                table: "Vuelos");

            migrationBuilder.DropColumn(
                name: "Estatus",
                table: "Reservaciones");

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
    }
}

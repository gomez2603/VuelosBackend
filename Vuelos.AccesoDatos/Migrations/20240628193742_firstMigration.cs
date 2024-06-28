using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vuelos.Entities.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vuelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asientos = table.Column<int>(type: "int", nullable: false),
                    AsientosOcupados = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VueloId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Asiento = table.Column<int>(type: "int", nullable: false),
                    TimeSpan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Vuelos_VueloId",
                        column: x => x.VueloId,
                        principalTable: "Vuelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vuelos",
                columns: new[] { "Id", "Asientos", "AsientosOcupados", "Destino", "Horario", "Origen", "Precio" },
                values: new object[,]
                {
                    { 1, 30, 0, "ACA", new DateTime(2024, 6, 29, 17, 37, 42, 290, DateTimeKind.Local).AddTicks(8665), "MID", 400.0 },
                    { 2, 30, 4, "QRO", new DateTime(2024, 6, 29, 15, 37, 42, 290, DateTimeKind.Local).AddTicks(8679), "MID", 800.0 },
                    { 3, 30, 8, "MTY", new DateTime(2024, 6, 29, 19, 37, 42, 290, DateTimeKind.Local).AddTicks(8680), "MID", 2200.0 },
                    { 4, 30, 12, "CUN", new DateTime(2024, 6, 29, 21, 37, 42, 290, DateTimeKind.Local).AddTicks(8682), "MID", 2400.0 },
                    { 5, 30, 18, "TCN", new DateTime(2024, 6, 29, 13, 37, 42, 290, DateTimeKind.Local).AddTicks(8683), "MID", 700.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_UsuarioId",
                table: "Reservaciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_VueloId",
                table: "Reservaciones",
                column: "VueloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservaciones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vuelos");
        }
    }
}

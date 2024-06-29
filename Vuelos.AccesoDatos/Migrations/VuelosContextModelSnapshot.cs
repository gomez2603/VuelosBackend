﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vuelos.Entities;

#nullable disable

namespace Vuelos.Entities.Migrations
{
    [DbContext(typeof(VuelosContext))]
    partial class VuelosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Vuelos.Entities.Modelos.Reservaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Asientos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Confirmacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeSpan")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("VueloId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VueloId");

                    b.ToTable("Reservaciones");
                });

            modelBuilder.Entity("Vuelos.Entities.Modelos.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "BASICA"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "PREMIUM"
                        });
                });

            modelBuilder.Entity("Vuelos.Entities.Modelos.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Vuelos.Entities.Modelos.VuelosA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aerolinea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Asientos")
                        .HasColumnType("int");

                    b.Property<int>("AsientosOcupados")
                        .HasColumnType("int");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DuracionViaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Vuelos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aerolinea = "Volaris",
                            Asientos = 30,
                            AsientosOcupados = 0,
                            Destino = "ACA",
                            DuracionViaje = "1:25",
                            Horario = new DateTime(2024, 6, 30, 13, 17, 49, 305, DateTimeKind.Local).AddTicks(3464),
                            Origen = "MID",
                            Precio = 400.0
                        },
                        new
                        {
                            Id = 2,
                            Aerolinea = "AeroMexico",
                            Asientos = 30,
                            AsientosOcupados = 4,
                            Destino = "QRO",
                            DuracionViaje = "2:35",
                            Horario = new DateTime(2024, 6, 30, 11, 17, 49, 305, DateTimeKind.Local).AddTicks(3477),
                            Origen = "MID",
                            Precio = 800.0
                        },
                        new
                        {
                            Id = 3,
                            Aerolinea = "Viva Aerobus",
                            Asientos = 30,
                            AsientosOcupados = 8,
                            Destino = "MTY",
                            DuracionViaje = "1:45",
                            Horario = new DateTime(2024, 6, 30, 15, 17, 49, 305, DateTimeKind.Local).AddTicks(3479),
                            Origen = "MID",
                            Precio = 2200.0
                        },
                        new
                        {
                            Id = 4,
                            Aerolinea = "Volaris",
                            Asientos = 30,
                            AsientosOcupados = 12,
                            Destino = "CUN",
                            DuracionViaje = "1:05",
                            Horario = new DateTime(2024, 6, 30, 17, 17, 49, 305, DateTimeKind.Local).AddTicks(3480),
                            Origen = "MID",
                            Precio = 2400.0
                        },
                        new
                        {
                            Id = 5,
                            Aerolinea = "AeroMexico",
                            Asientos = 30,
                            AsientosOcupados = 18,
                            Destino = "TCN",
                            DuracionViaje = "0:35",
                            Horario = new DateTime(2024, 6, 30, 9, 17, 49, 305, DateTimeKind.Local).AddTicks(3481),
                            Origen = "MID",
                            Precio = 700.0
                        });
                });

            modelBuilder.Entity("Vuelos.Entities.Modelos.Reservaciones", b =>
                {
                    b.HasOne("Vuelos.Entities.Modelos.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vuelos.Entities.Modelos.VuelosA", "Vuelo")
                        .WithMany()
                        .HasForeignKey("VueloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");

                    b.Navigation("Vuelo");
                });

            modelBuilder.Entity("Vuelos.Entities.Modelos.Usuario", b =>
                {
                    b.HasOne("Vuelos.Entities.Modelos.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}

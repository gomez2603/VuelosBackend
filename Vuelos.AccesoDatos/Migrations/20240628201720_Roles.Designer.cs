﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vuelos.Entities;

#nullable disable

namespace Vuelos.Entities.Migrations
{
    [DbContext(typeof(VuelosContext))]
    [Migration("20240628201720_Roles")]
    partial class Roles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Asiento")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeSpan")
                        .HasColumnType("datetime2");

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

                    b.Property<int>("Asientos")
                        .HasColumnType("int");

                    b.Property<int>("AsientosOcupados")
                        .HasColumnType("int");

                    b.Property<string>("Destino")
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
                            Asientos = 30,
                            AsientosOcupados = 0,
                            Destino = "ACA",
                            Horario = new DateTime(2024, 6, 29, 18, 17, 20, 47, DateTimeKind.Local).AddTicks(304),
                            Origen = "MID",
                            Precio = 400.0
                        },
                        new
                        {
                            Id = 2,
                            Asientos = 30,
                            AsientosOcupados = 4,
                            Destino = "QRO",
                            Horario = new DateTime(2024, 6, 29, 16, 17, 20, 47, DateTimeKind.Local).AddTicks(317),
                            Origen = "MID",
                            Precio = 800.0
                        },
                        new
                        {
                            Id = 3,
                            Asientos = 30,
                            AsientosOcupados = 8,
                            Destino = "MTY",
                            Horario = new DateTime(2024, 6, 29, 20, 17, 20, 47, DateTimeKind.Local).AddTicks(318),
                            Origen = "MID",
                            Precio = 2200.0
                        },
                        new
                        {
                            Id = 4,
                            Asientos = 30,
                            AsientosOcupados = 12,
                            Destino = "CUN",
                            Horario = new DateTime(2024, 6, 29, 22, 17, 20, 47, DateTimeKind.Local).AddTicks(319),
                            Origen = "MID",
                            Precio = 2400.0
                        },
                        new
                        {
                            Id = 5,
                            Asientos = 30,
                            AsientosOcupados = 18,
                            Destino = "TCN",
                            Horario = new DateTime(2024, 6, 29, 14, 17, 20, 47, DateTimeKind.Local).AddTicks(320),
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

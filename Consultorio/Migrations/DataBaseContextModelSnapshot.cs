﻿// <auto-generated />
using System;
using Consultorio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Consultorio.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Consultorio.Data.Consultorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Consultorios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            direccion = "Calle Novena 2342",
                            name = "Almater",
                            telefono = "6861034325"
                        },
                        new
                        {
                            Id = 2,
                            direccion = "Calle F Reforma 2342",
                            name = "Consultorio Medico de la Familia",
                            telefono = "6865233525"
                        },
                        new
                        {
                            Id = 3,
                            direccion = "S/N",
                            name = "Torre de Especialidades Almater",
                            telefono = "6864534374"
                        });
                });

            modelBuilder.Entity("Consultorio.Data.Expediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ConsultorioId")
                        .HasColumnType("int");

                    b.Property<float>("Estatura")
                        .HasColumnType("real");

                    b.Property<DateTime>("FechaReg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Folio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsultorioId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Expedientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConsultorioId = 1,
                            Estatura = 1.84f,
                            FechaReg = new DateTime(2022, 5, 21, 21, 26, 25, 936, DateTimeKind.Local).AddTicks(5119),
                            Folio = "TEST1",
                            Notas = "Unas Notas aqui del paciente 1",
                            PacienteId = 1,
                            Peso = 93.42f,
                            Sexo = "Masculino"
                        },
                        new
                        {
                            Id = 2,
                            ConsultorioId = 1,
                            Estatura = 1.54f,
                            FechaReg = new DateTime(2022, 5, 21, 21, 26, 25, 937, DateTimeKind.Local).AddTicks(9686),
                            Folio = "TEST2",
                            Notas = "Unas Notas aqui del paciente 2",
                            PacienteId = 2,
                            Peso = 52.71f,
                            Sexo = "Femenino"
                        },
                        new
                        {
                            Id = 3,
                            ConsultorioId = 1,
                            Estatura = 1.64f,
                            FechaReg = new DateTime(2022, 5, 21, 21, 26, 25, 937, DateTimeKind.Local).AddTicks(9715),
                            Folio = "TEST3",
                            Notas = "Unas Notas aqui del paciente 3",
                            PacienteId = 3,
                            Peso = 63.27f,
                            Sexo = "Femenino"
                        });
                });

            modelBuilder.Entity("Consultorio.Data.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ApellidoM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApellidoP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApellidoM = "Sanchez",
                            ApellidoP = "Marquez",
                            FechaNacimiento = new DateTime(1989, 7, 24, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Eric"
                        },
                        new
                        {
                            Id = 2,
                            ApellidoM = "Hernandez",
                            ApellidoP = "Marquez",
                            FechaNacimiento = new DateTime(1991, 3, 7, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ana"
                        },
                        new
                        {
                            Id = 3,
                            ApellidoM = "Cazares",
                            ApellidoP = "Gutierrez",
                            FechaNacimiento = new DateTime(1992, 4, 20, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Adriana"
                        });
                });

            modelBuilder.Entity("Consultorio.Data.Expediente", b =>
                {
                    b.HasOne("Consultorio.Data.Consultorio", "Consultorio")
                        .WithMany()
                        .HasForeignKey("ConsultorioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Data.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultorio");

                    b.Navigation("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}

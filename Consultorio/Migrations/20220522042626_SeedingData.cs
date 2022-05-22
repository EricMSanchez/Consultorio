using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultorio.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Consultorios",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Expedientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Consultorios",
                columns: new[] { "Id", "direccion", "name", "telefono" },
                values: new object[,]
                {
                    { 1, "Calle Novena 2342", "Almater", "6861034325" },
                    { 2, "Calle F Reforma 2342", "Consultorio Medico de la Familia", "6865233525" },
                    { 3, "S/N", "Torre de Especialidades Almater", "6864534374" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "ApellidoM", "ApellidoP", "FechaNacimiento", "Name" },
                values: new object[,]
                {
                    { 1, "Sanchez", "Marquez", new DateTime(1989, 7, 24, 1, 0, 0, 0, DateTimeKind.Unspecified), "Eric" },
                    { 2, "Hernandez", "Marquez", new DateTime(1991, 3, 7, 1, 0, 0, 0, DateTimeKind.Unspecified), "Ana" },
                    { 3, "Cazares", "Gutierrez", new DateTime(1992, 4, 20, 1, 0, 0, 0, DateTimeKind.Unspecified), "Adriana" }
                });

            migrationBuilder.InsertData(
                table: "Expedientes",
                columns: new[] { "Id", "ConsultorioId", "Estatura", "FechaReg", "Folio", "Notas", "PacienteId", "Peso", "Sexo" },
                values: new object[] { 1, 1, 1.84f, new DateTime(2022, 5, 21, 21, 26, 25, 936, DateTimeKind.Local).AddTicks(5119), "TEST1", "Unas Notas aqui del paciente 1", 1, 93.42f, "Masculino" });

            migrationBuilder.InsertData(
                table: "Expedientes",
                columns: new[] { "Id", "ConsultorioId", "Estatura", "FechaReg", "Folio", "Notas", "PacienteId", "Peso", "Sexo" },
                values: new object[] { 2, 1, 1.54f, new DateTime(2022, 5, 21, 21, 26, 25, 937, DateTimeKind.Local).AddTicks(9686), "TEST2", "Unas Notas aqui del paciente 2", 2, 52.71f, "Femenino" });

            migrationBuilder.InsertData(
                table: "Expedientes",
                columns: new[] { "Id", "ConsultorioId", "Estatura", "FechaReg", "Folio", "Notas", "PacienteId", "Peso", "Sexo" },
                values: new object[] { 3, 1, 1.64f, new DateTime(2022, 5, 21, 21, 26, 25, 937, DateTimeKind.Local).AddTicks(9715), "TEST3", "Unas Notas aqui del paciente 3", 3, 63.27f, "Femenino" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consultorios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consultorios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expedientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expedientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expedientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consultorios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Expedientes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consultorios",
                newName: "id");
        }
    }
}

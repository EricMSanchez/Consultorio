using Microsoft.EntityFrameworkCore;

namespace Consultorio.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions options):base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Consultorio>().HasData(
                new Consultorio 
                { 
                    Id = 1,
                    name = "Almater",
                    direccion = "Calle Novena 2342",
                    telefono = "6861034325"
                },
                new Consultorio
                {
                    Id = 2,
                    name = "Consultorio Medico de la Familia",
                    direccion = "Calle F Reforma 2342",
                    telefono = "6865233525"
                },
                new Consultorio
                {
                    Id = 3,
                    name = "Torre de Especialidades Almater",
                    direccion = "S/N",
                    telefono = "6864534374"
                }

                );
            
            builder.Entity<Paciente>().HasData(
                new Paciente
                {
                    Id=1,
                    Name="Eric",
                    ApellidoP="Marquez",
                    ApellidoM="Sanchez",
                    FechaNacimiento = System.DateTime.Parse("1989/07/24 01:00:00")
                    
                },
                new Paciente
                {
                    Id = 2,
                    Name = "Ana",
                    ApellidoP = "Marquez",
                    ApellidoM = "Hernandez",
                    FechaNacimiento = System.DateTime.Parse("1991/03/07 01:00:00")
                },
                new Paciente
                {
                    Id = 3,
                    Name = "Adriana",
                    ApellidoP = "Gutierrez",
                    ApellidoM = "Cazares",
                    FechaNacimiento = System.DateTime.Parse("1992/04/20 01:00:00")
                }

                );

            builder.Entity<Expediente>().HasData(
                new Expediente
                {
                    Id = 1,
                    Folio= "TEST1",
                    PacienteId= 1,
                    ConsultorioId= 1,
                    FechaReg = System.DateTime.Now,
                    Estatura = float.Parse("1.84"),
                    Peso = float.Parse("93.42"),
                    Sexo = "Masculino",
                    Notas = "Unas Notas aqui del paciente 1"
                },
                new Expediente
                {
                    Id = 2,
                    Folio = "TEST2",
                    PacienteId = 2,
                    ConsultorioId = 1,
                    FechaReg = System.DateTime.Now,
                    Estatura = float.Parse("1.54"),
                    Peso = float.Parse("52.71"),
                    Sexo = "Femenino",
                    Notas = "Unas Notas aqui del paciente 2"
                },
                new Expediente
                {
                    Id = 3,
                    Folio = "TEST3",
                    PacienteId = 3,
                    ConsultorioId = 1,
                    FechaReg = System.DateTime.Now,
                    Estatura = float.Parse("1.64"),
                    Peso = float.Parse("63.27"),
                    Sexo = "Femenino",
                    Notas = "Unas Notas aqui del paciente 3"
                }

                );
        }

        DbSet<Consultorio> Consultorios { get; set; }
        DbSet<Paciente> Pacientes { get; set; }
        DbSet<Expediente> Expedientes { get; set; }
    }
}

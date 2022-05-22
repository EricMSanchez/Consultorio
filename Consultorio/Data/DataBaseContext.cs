using Microsoft.EntityFrameworkCore;

namespace Consultorio.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions options):base(options)
        {

        }

        DbSet<Consultorio> Consultorios { get; set; }
        DbSet<Paciente> Pacientes { get; set; }

        DbSet<Expediente> Expedientes { get; set; }
    }
}

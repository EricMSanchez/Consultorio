using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Consultorio.Data
{
    public class Expediente
    {
        public int Id { get; set; }

        public string Folio { get; set; }

        [ForeignKey(nameof(Paciente))]
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }


        [ForeignKey(nameof(Consultorio))]
        public int ConsultorioId { get; set; }
        public Consultorio Consultorio { get; set; }


        public DateTime FechaReg { get; set; }

        public float Estatura { get; set; }

        public float Peso { get; set; }

        public string Sexo { get; set; }

        public string Notas { get; set; }
    }
}

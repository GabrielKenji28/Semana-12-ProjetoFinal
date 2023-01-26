using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Object
{
    [Table("Participante")]
    public class ParticipanteModel
    {
        [Key]
        public int ParticipanteId { get; set; }

        [Required(ErrorMessage ="Nome não pode ser nulo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Idade não pode ser nulo")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Gols não pode ser nulo")]
        public int Gols { get; set; }

        [Required(ErrorMessage = "Total de partidas não pode ser nulo")]
        public int TotalPartidas { get => Vitorias + Derrotas; }

        [Required(ErrorMessage = "Derrotas não pode ser nulo")]
        public int Derrotas { get; set; }

        [Required(ErrorMessage = "Vitórias não pode ser nulo")]
        public int Vitorias { get; set; }

    }
}

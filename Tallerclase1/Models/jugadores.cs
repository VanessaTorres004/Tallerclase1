using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tallerclase1.Models
{
    public class jugadores
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public Equipo Equipo { get; set; }
        [ForeignKey("nombre")]
        public int Edad { get; set; }
        public string Posicion { get; set; }

    }
}

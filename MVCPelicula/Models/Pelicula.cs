using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula.Models
{
    public class Pelicula
    {
        public int ID { get; set; }

        [Display(Name = "Título")]
        [StringLength(60, MinimumLength =3)]
        [Required]
        public String? Titulo { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Género")]
        public int? GeneroId { get; set; }
        public Genero? Genero { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Precio { get; set; }

        [StringLength(250)]
        [Required]
        public string Director { get; set; }
    }
}

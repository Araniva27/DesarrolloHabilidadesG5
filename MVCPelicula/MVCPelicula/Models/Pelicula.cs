using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula.Models
{
    public class Pelicula
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "El campo título es requerido")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Fecha de Lanzamiento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo fecha de lanzamiento es requerido")]
        public DateTime FechaLanzamiento { get; set; }

        //propiedad de llave foránea
        [Required]
        [ForeignKey("Genero")]
        [Display(Name = "Género")]
        public int? GeneroId { get; set; }
        
        //propiedad de navegación
        public Genero Genero { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "El campo director es requerido")]
        public string Director {  get; set; }


    }
}

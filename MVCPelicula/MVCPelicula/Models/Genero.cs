using System.ComponentModel.DataAnnotations;

namespace MVCPelicula.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [StringLength(250)]
        [Required]
        public string Nombre { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; }
       
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCPelicula.Models.Seeds
{
    public class PeliculaSeed: IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.HasData(
                new Pelicula
                {
                    ID = 1,
                    Titulo = "Matrix recargado",
                    FechaLanzamiento = DateTime.Parse("2003-11-13"),
                    GeneroId = 4,
                    Precio = 10.99M,
                    Director = "Hermanas Wachoski"
                },
                new Pelicula
                {
                    ID = 2,
                    Titulo = "El señor de los anillos: Las dos torres",
                    FechaLanzamiento = DateTime.Parse("2002-12-18"),
                    GeneroId = 3,
                    Precio = 11.99M,
                    Director = "Peter Jackson"
                },
                new Pelicula
                {
                    ID = 3,
                    Titulo = "Harry potter y la cámara secreta",
                    FechaLanzamiento = DateTime.Parse("2002-11-15"),
                    GeneroId = 5,
                    Precio = 9.99M,
                    Director = "Chris Columbus"
                }
            );
        }
    }
}

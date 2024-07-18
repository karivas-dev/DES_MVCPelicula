using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace MVCPelicula.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PeliculasDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PeliculasDBContext>>()))
            {
                //Look for any genres.
                if (!context.Generos.Any())
                {
                    context.Generos.AddRange(
                        new Genero
                        {
                            Nombre = "Fantasía",
                        },
                        new Genero
                        {
                            Nombre = "Ficción de aventuras",
                        },
                        new Genero
                        {
                            Nombre = "Crimen",
                        },
                        new Genero
                        {
                            Nombre = "Acción",
                        }
                    );
                }
                else
                {
                    return;
                }

                //Look for any movies.
                if (!context.Peliculas.Any())
                {
                    context.Peliculas.AddRange(
                        new Pelicula
                        {
                            Titulo = "Harry Potter y la hipoteca de la casa",
                            FechaLanzamiento = DateTime.Parse("2001-11-16"),
                            GeneroId = 1,
                            Precio = 9.99M,
                            Director = "Diego Gómez"
                        },
                        new Pelicula
                        {
                            Titulo = "El señor de los anillos: La comunidad del anilo",
                            FechaLanzamiento = DateTime.Parse("2001-11-13"),
                            GeneroId = 2,
                            Precio = 8.99M,
                            Director = "Luis Bonilla"
                        },
                        new Pelicula
                        {
                            Titulo = "Atrapame si puedes AKA DICOM",
                            FechaLanzamiento = DateTime.Parse("2002-5-15"),
                            GeneroId = 3,
                            Precio = 9.99M,
                            Director = "Alfonso Cotto"
                        },
                        new Pelicula
                        {
                            Titulo = "Mátrix recargado: Último ciclo de la U",
                            FechaLanzamiento = DateTime.Parse("2003-11-13"),
                            GeneroId = 4,
                            Precio = 10.99M,
                            Director = "Josías Alvarenga"
                        }
                    );
                }
                else
                {
                    return;
                }
             
                context.SaveChanges();
            }
        }
    }
}

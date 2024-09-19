}using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCine.clases
{
    internal class Pelicula
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public decimal Duracion { get; set; }
        public string Fecha { get; set; }
        public List<Actor> Actores { get; set; }
        public Director Director { get; set; }
        public Pelicula(string titulo, string genero, decimal duracion, string fecha, List<Actor> actores, Director director)
        {
            Genero = genero;
            Duracion = duracion;
            Fecha = fecha;
            Titulo = titulo;
            Actores = new List<Actor>();
            Director = director;
        }
        public void MostrarDetallePelicula()
        {
            Console.WriteLine($"{Titulo}\n{Duracion}\n{Fecha}\n{Genero}\n{Director.Nombre}\n");
            foreach (Actor actor in Actores)
            {
                actor.MostrarDetallesActor();
            }
        }
    }
}
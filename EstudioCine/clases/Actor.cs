using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCine.clases
{
    internal class Actor
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Genero { get; set; }



        public Actor(string nombre, string edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;

        }
        public void MostrarDetallesActor()
        {

            Console.WriteLine($"El actor es: {Nombre} " +
                $"\n {Edad}" +
                $"\n {Genero}   ");

        }
    }
}


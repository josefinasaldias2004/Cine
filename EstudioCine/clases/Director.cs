using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCine.clases
{
    internal class Director
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Genero { get; set; }


        public Director(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }
        public void MostrarDetallesDirector()
        {

            Console.WriteLine($"El director es: {Nombre} " +
                $"\n {Edad}" +
                $"\n {Genero}   ");

        }

    }
}

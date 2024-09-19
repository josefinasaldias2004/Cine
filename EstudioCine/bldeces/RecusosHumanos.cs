using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudioCine.bldeces
{
    internal class RecusosHumanos
    {
        public decimal TiempoPelicula { get; set; }
        public string ElencoSeleccion { get; set; }

        public float PresupuestoPelicula { get; set; }



        public RecusosHumanos(decimal tiempoPelicula, string elencoSeleccion, float presupuestoPelicula)
        {
            TiempoPelicula = tiempoPelicula;
            ElencoSeleccion = elencoSeleccion;
            PresupuestoPelicula = presupuestoPelicula;
        }
    }
}

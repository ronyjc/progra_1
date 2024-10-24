using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_clases
{
    internal class Animales
    {
        string nombre;
        string especie;
        string clasificacion;
        int edad;

        public Animales(string nombre_in, string especie_in, string clasificacion_in, int edad_in)
        { 
            nombre = nombre_in;
            especie = especie_in;
            clasificacion = clasificacion_in;
            edad = edad_in;
        
        }

        public string getNombre() { 
            return nombre;
        }
        public string getEspecie() { 
            return especie;
        }
        public string getClasificacion() {
            return clasificacion;
        }
        public int getEdad() {
            return edad;
        }


    }
}

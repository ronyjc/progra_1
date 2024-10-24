using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases2
{
    public class Vehiculos
    {
        string propietario;
        string marca;
        string modelo;
        string año;
        string color;
        double cilindrada;
        string placa;
        string falla;

        public Vehiculos(string propietario,
                         string marca, string modelo, string año, string color,
                         double cilindrada, string placa, string falla)
        { 
            this.propietario = propietario;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.color = color;
            this.cilindrada = cilindrada;
            this.placa = placa;
            this.falla = falla;
        
        
        }

        public string Propietario { get => propietario; set => propietario = value; } 
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Año { get => año; set => año = value; }
        public string Color { get => color; set => color = value; }
        public double Cilindrada { get => cilindrada; set => cilindrada = value; }
        public string Placa { get => placa; set => placa = value;  }
        public string Falla { get => falla; set => falla = value; }



        public void MostrarInfo() { 
            Console.WriteLine(this.Marca+"; "+this.Modelo+ "; " + this.Año+ "; " + this.color);
            
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercado
{
    public class Productos
    {
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string marca { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }

        public Productos(string nombre, string codigo, string marca, double precio, int existencia) { 
        
            this.nombre = nombre;
            this.codigo = codigo;
            this.marca = marca;
            this.precio = precio;
            this.existencia = existencia;

        }

    }
}

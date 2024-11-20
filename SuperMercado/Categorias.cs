using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMercado
{
    public class Categorias
    {
        public string nombre {  get; set; }

        List<Productos> articulos;


        public Categorias(string nombre) { 
        
            this.nombre = nombre;
            this.articulos = new List<Productos>();
        
        
        }


        public void AgregarProducto(Productos producto) { 
        
            this.articulos.Add(producto);
        
        
        }


        public string VerProductos() {
            string mensaje = "Productos: \n";


            foreach (Productos cualquiera in articulos) {

                mensaje += cualquiera.nombre + "\n";
                mensaje += cualquiera.marca + "\n";
                mensaje += cualquiera.codigo + "\n";
                mensaje += cualquiera.precio + "\n";
                mensaje += cualquiera.existencia + "\n";
                mensaje += "---------------------------";
            
            
            }


            return mensaje;

        
        
        }


    }
}

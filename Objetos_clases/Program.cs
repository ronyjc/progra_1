using Objetos_clases;

Console.WriteLine("Vamos a crear un objeto, de la clase \"Animales\"");
Console.WriteLine("Por favor ingrese el nombre del animal: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese la especie del animal: ");
string especie = Console.ReadLine();
Console.WriteLine("Ingrese la clasificación: ");
string clasificacion = Console.ReadLine();
Console.WriteLine("Ingrese la edad del animal");
int edad = Convert.ToInt16(Console.ReadLine());

Animales animal1 = new Animales(nombre, especie, clasificacion, edad);

Console.WriteLine("El objeto creado es: ");
Console.WriteLine(animal1.getNombre());
Console.WriteLine(animal1.getEspecie());
Console.WriteLine(animal1.getClasificacion());
Console.WriteLine(animal1.getEdad());
//Solicitar datos al usuario
using EjercicioClases2;

Console.WriteLine("Bienvenido, por favor ingrese los siguientes datos");
Console.WriteLine("Por favor ingrese el nombre del propietario");
string propietario = Console.ReadLine();
Console.WriteLine("Ingrese la marca");
string marca = Console.ReadLine();
Console.WriteLine("Ingrese el modelo: ");
string modelo = Console.ReadLine();
Console.WriteLine("Ingrese el año");
string año = Console.ReadLine();
Console.WriteLine("Ingrese el color: ");
string color = Console.ReadLine();
Console.WriteLine("Ingrese la cilindrada ");
double cilindrada = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el numero de placa ");
string placa = Console.ReadLine();
Console.WriteLine("Ingrese la falla que presenta el vehículo");
string falla = Console.ReadLine();

Vehiculos nuevo_vehiculo = new Vehiculos(propietario,marca,modelo,año,color,cilindrada,placa,falla);

nuevo_vehiculo.MostrarInfo();

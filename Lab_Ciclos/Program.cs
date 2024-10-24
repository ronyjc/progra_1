Console.WriteLine("Por favor ingrese los nombres separados por espacio");

string[] nombres = new string[100];

string captura = Console.ReadLine();

nombres = captura.Split(" ");

for (int i = 0; i < nombres.Length; i++) { 
    Console.WriteLine(nombres[i]);
}
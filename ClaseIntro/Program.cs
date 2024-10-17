internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Este programa realiza la suma de dos numeros");
        Console.WriteLine("Por favor ingrese el primer numero: ");
        int numero_a = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingrese el segundo numero: ");
        int numero_b = int.Parse(Console.ReadLine());
        int total = numero_a + numero_b;
        Console.WriteLine("El resultado de la suma es: " + total);
        



    }
}
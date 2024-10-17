
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bienvenido, por favor seleccione una operación \n 1. Suma \n 2. Resta \n 3. Multiplicación \n 4. División");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el primero numero");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el segundo numero");
            double b = Convert.ToDouble(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    double resultado = a + b;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;
                case 2:
                    double resultado_2 = a - b;
                    Console.WriteLine("El resultado es: " + resultado_2);
                    break;
                case 3:
                    double resultado_3 = a * b;
                    Console.WriteLine("El resultado es: " + resultado_3);
                    break;
                case 4:
                    double resultado_4 = a / b;
                    Console.WriteLine("El resultado es: " + resultado_4);
                    break;
            }
        }
    }
}
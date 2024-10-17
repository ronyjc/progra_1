internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido, este programa le ayudará a encontrar el MCM de dos numeros");
        Console.WriteLine("Por favor ingrese el primer numero");
        int factor_a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Por favor ingrese el segundo numero");
        int factor_b = Convert.ToInt32(Console.ReadLine());
        int divisor;

        if (factor_a > factor_b)
        {
            divisor = factor_a;
        }
        else
        {
            divisor = factor_b;
        }

        while (divisor > 0) {
            if ((factor_a % divisor == 0) && (factor_b % divisor == 0))
            { 
                Console.WriteLine("El MCM de "+factor_a+" y "+factor_b+" es: "+divisor);
                break;
            }
            divisor--;
        
        
        }
    }
}
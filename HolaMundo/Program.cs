internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        double b = 20.5;
        string s = "Hola Mundo";
        char c = 'a';
        bool b1 = true;

        Console.WriteLine("Dato tipo entero " + a);
        Console.WriteLine("Dato tipo double " + b);
        Console.WriteLine("Dato tipo String " + s);
        Console.WriteLine("Dato tipo Char " + c);
        Console.WriteLine("Dato tipo bool " + b1);


       /* int contador = 0;
        int x = 100;
        while (contador < x)
        {
            Console.WriteLine("Estoy contando de 0 a " + x + " y voy por " + contador);
            contador++;
            Console.ReadLine();
        }*/


        //string s = "Hola Mundo";
        foreach (char caracter in s)
        {
            Console.WriteLine(caracter);


        }

        int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach (int numero2 in numero) { 
        
                Console.WriteLine(numero2);
        
        }
    }
}
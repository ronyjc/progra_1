//

Console.WriteLine("Por favor ingrese un numero");
int valor = Convert.ToInt32(Console.ReadLine());

int contador = valor;
int cociente; int residuo;

while (contador > 0) {

   cociente = valor / contador;
    residuo = valor % contador;

    if ((cociente == 3)&&(residuo == 0))
    {
        Console.WriteLine("El divisor " + contador + " da como cociente el numero 3");   
        break;
    }
    contador--;
    if (contador == 1) Console.WriteLine("No se encontró ningun valor");
}




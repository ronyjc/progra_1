//Solicitar al usuario el ingreso de los datos
Console.WriteLine("Por favor ingrese 10 numeros, uno a uno, presionando \"ENTER\" en cada ingreso");

//Declarar el arreglo de datos
double[] numeros = new double[10];

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Convert.ToDouble(Console.ReadLine());

}

double total = 0;

for (int i = 0; i < numeros.Length; i++) {

    total = total + numeros[i];
}

double promedio = total / numeros.Length;
Console.WriteLine("El promedio de los numeros es: "+promedio);
Console.WriteLine("Los valores superiores al prmedio son: ");

for (int i = 0; i < numeros.Length; i++) {

    if (numeros[i] < promedio)
    {
        continue;

    }

    else {
        Console.WriteLine(numeros[i]);
    
    }

}

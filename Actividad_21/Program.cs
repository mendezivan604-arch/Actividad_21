Console.WriteLine("Ejercicio #1");
int cantidadnumeros;
double suma = 0;
double promedio;
while (true)
{
    Console.Write("Ingrese la cantidad de números: ");
    if (int.TryParse(Console.ReadLine(), out cantidadnumeros) && cantidadnumeros > 0)
    {
        break;
    }
    Console.WriteLine("Cantidad inválida");
}

int[] numeros = new int[cantidadnumeros];
for (int i = 0; i < cantidadnumeros; i++)
{
    while (true)
    {
        Console.Write($"Ingrese el número {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out numeros[i]))
        {
            break;
        }
        Console.WriteLine("Número inválido");
    }
    suma += numeros[i];
}

promedio = suma / cantidadnumeros;
for (int i = 0; i < cantidadnumeros; i++)
{
    if (numeros[i] > promedio)
    {
        Console.WriteLine($"Número {i + 1} es mayor que el promedio: {numeros[i]}");
    }

}
Console.WriteLine($"El promedio es: {promedio}");

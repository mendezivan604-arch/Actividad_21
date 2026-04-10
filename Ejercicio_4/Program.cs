Console.WriteLine("Ejercicio #4");
int cantidadnumeros;
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
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Ingrese el número {i}: ");
    int valor;
    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Entrada inválida. Intente de nuevo: ");
    }
    numeros[i] = valor;
}
Console.WriteLine();
Console.Write($"Ingrese la posicion (0 a {cantidadnumeros - 1}): ");
int pos;
while (!int.TryParse(Console.ReadLine(), out pos) || pos < 0 || pos >= cantidadnumeros)
{
    Console.Write($"Posicion invalida. Ingrese un número entre 0 y {cantidadnumeros - 1}: ");
}

Console.WriteLine($"El valor en la posicion {pos} es: {numeros[pos]}");

Console.WriteLine("Ejercicio #3");
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
    while (true)
    {
        Console.Write($"Ingrese el número {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out numeros[i]))
        {
            break;
        }
        Console.WriteLine("Número inválido");
    }
}

int contadorPares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        contadorPares++;
    }
}

int[] numerosPares = new int[contadorPares];
for (int i = 0; i < numerosPares.Length; i++)
{
    numerosPares[i] = numeros[i];
}

Console.WriteLine("Arreglo con números pares:");
for (int i = 0; i < numerosPares.Length; i++)
{
    Console.WriteLine(numerosPares[i]);
}


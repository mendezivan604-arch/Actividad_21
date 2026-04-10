Console.WriteLine("Ejercicio #2");
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

int buscado;
Console.Write("Ingrese el valor a contar: ");
buscado = int.Parse(Console.ReadLine());

int contador = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == buscado)
    {
        contador++;
        Console.WriteLine($"El número {buscado} se repite {contador} veces en las posiciones {i}");
    }
}


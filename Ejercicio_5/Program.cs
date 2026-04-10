Console.WriteLine("Ejercicio #5");

int n;

while (true)
{
    Console.Write("Ingrese la cantidad de números: ");
    if (int.TryParse(Console.ReadLine(), out n) && n > 0)
    {
        break;
    }
    Console.WriteLine("Cantidad inválida");
}

int[] numeros = new int[n];

for (int i = 0; i < numeros.Length; i++)
{
    while (true)
    {
        Console.Write($"Ingrese número {i + 1}: ");
        if (int.TryParse(Console.ReadLine(), out numeros[i]))
        {
            break;
        }
        Console.WriteLine("Número inválido");
    }
}

int opcion;

do
{
    Console.WriteLine("\n--- MENÚ ---");
    Console.WriteLine("1. Modificar un valor");
    Console.WriteLine("2. Mostrar arreglo");
    Console.WriteLine("3. Buscar un número");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            int posicion;

            while (true)
            {
                Console.Write($"Ingrese la posición (0 a {n - 1}): ");
                if (int.TryParse(Console.ReadLine(), out posicion) && posicion >= 0 && posicion < n)
                {
                    break;
                }
                Console.WriteLine("Posición inválida");
            }

            int nuevoValor;
            while (true)
            {
                Console.Write("Ingrese el nuevo valor: ");
                if (int.TryParse(Console.ReadLine(), out nuevoValor))
                {
                    break;
                }
                Console.WriteLine("Valor inválido");
            }

            numeros[posicion] = nuevoValor;
            Console.WriteLine("Valor modificado correctamente");
            break;

        case 2:
            
            Console.WriteLine("Elementos del arreglo:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {numeros[i]}");
            }
            break;

        case 3:
           
            int buscado;
            Console.Write("Ingrese el número a buscar: ");
            int.TryParse(Console.ReadLine(), out buscado);

            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine($"Encontrado en la posición {i}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El número no existe en el arreglo");
            }
            break;

        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción inválida");
            break;

    }

} while (opcion != 0);

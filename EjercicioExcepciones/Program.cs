using EjercicioExcepciones;

Operaciones operaciones = new Operaciones();

bool continuar = true;

while (continuar)
{
    
    Console.WriteLine("Bienvenido al programa para realizar operaciones de matematicas basicas:");
    Console.WriteLine("Seleccione una opción del 1 al 4 para realizar la operacion:");
    Console.WriteLine("\n1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.WriteLine("");

    string opcion = Console.ReadLine();

    try
    {
        double n1, n2;

        switch (opcion)
        {
            case "1":
                Console.WriteLine("Ingrese el primer número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Sumar(n1, n2)}");
                break;
            case "2":
                Console.WriteLine("Ingrese el primer número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Restar(n1, n2)}");
                break;
            case "3":
                Console.WriteLine("Ingrese el primer número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Multiplicar(n1, n2)}");
                break;
            case "4":
                Console.WriteLine("Ingrese el primer número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Dividir(n1, n2)}");
                break;
            case "5":
                continuar = false;
                Console.WriteLine("\nEl programa a finalizado.");
                break;
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingresó un formato de número no válido.");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ha ocurrido un error inesperado: {ex.Message}");
    }

    if (continuar)
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}


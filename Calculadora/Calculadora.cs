//Esta es una calculadora basica elaborada en C#
Console.Clear();// Limpia la consola para mejor presentacion
Console.WriteLine("---Calculadora---");
Console.WriteLine("---Seleccione una operación:");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicación");
Console.WriteLine("4. División");
Console.WriteLine("5. Porcentaje");
Console.Write("---> ");

int choice;
if (!int.TryParse(Console.ReadLine(), out choice))
{
    Console.WriteLine("---Entrada no válida. Por favor, ingrese un número entero.");
    return;  // Terminar el programa
}

if (choice < 1 || choice > 5)
{
    Console.WriteLine("---Opción no válida. Por favor, elija una opción del 1 al 5.");
    return;
}

Console.Write("---Ingrese el primer número: ");
if (!double.TryParse(Console.ReadLine(), out double num1))
{
    Console.WriteLine("---Entrada inválida. Por favor, ingrese un número válido.");
    return;
}

Console.Write("---Ingrese el segundo número: ");
if (!double.TryParse(Console.ReadLine(), out double num2))
{
    Console.WriteLine("---Entrada inválida. Por favor, ingrese un número válido.");
    return;
}

double result = 0;

switch (choice)
{
    case 1: // Suma
        result = num1 + num2;
        break;
    case 2: // Resta
        result = num1 - num2;
        break;
    case 3: // Multiplicación
        result = num1 * num2;
        break;
    case 4: // División
        if (num2 != 0)
            result = num1 / num2;
        else
            Console.WriteLine("Error: División por cero.");
        break;
    case 5: // Porcentaje
        result = (num1 * num2) / 100;
        break;
    default:
        Console.WriteLine("---Opción no válida.");
        return;  // Terminar el programa
}

Console.WriteLine("--El resultado es: {0}", result);
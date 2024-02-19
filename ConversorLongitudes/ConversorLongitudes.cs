//Este es un conversor que nos permite convertir cualquier longitud en otra. KR
Console.Clear();// Limpia la consola para mejor presentacion

//While para volver a empezar
while (true)
{
    Console.WriteLine("---Seleccione la unidad de longitud que desea convertir: ");
    Console.WriteLine("1. Metros");
    Console.WriteLine("2. Pies");
    Console.WriteLine("3. Pulgadas");
    Console.WriteLine("4. Millas");
    Console.WriteLine("5. Centímetros");
    Console.WriteLine("6. Kilómetros");
    Console.WriteLine("0. Salir");
    Console.Write("---> ");

    int inputOption = Convert.ToInt32(Console.ReadLine());

    if (inputOption == 0)
    {
        Console.WriteLine("---Saliendo del programa");
        break;
    }

    Console.WriteLine("---Ingrese la longitud: ");
    Console.Write("---> ");

    double inputLength = Convert.ToDouble(Console.ReadLine());
    double result = 0;

    Console.WriteLine("---Seleccione la unidad de longitud a la que desea convertir:");
    Console.WriteLine("1. Metros");
    Console.WriteLine("2. Pies");
    Console.WriteLine("3. Pulgadas");
    Console.WriteLine("4. Millas");
    Console.WriteLine("5. Centímetros");
    Console.WriteLine("6. Kilómetros");
    Console.Write("---> ");

    int outputOption = Convert.ToInt32(Console.ReadLine());

    switch (inputOption)
    {
        case 1: // Metros
            switch (outputOption)
            {
                case 1: // Metros a Metros
                    Console.WriteLine("--Ya estás en Metros. No es necesario convertir.");
                    break;
                case 2: // Metros a Pies
                    result = inputLength * 3.28084;
                    Console.WriteLine("--{0} metros son {1} pies.", inputLength, result);
                    break;
                case 3: // Metros a Pulgadas
                    result = inputLength * 39.3701;
                    Console.WriteLine("--{0} metros son {1} pulgadas.", inputLength, result);
                    break;
                case 4: // Metros a Millas
                    result = inputLength / 1609.34;
                    Console.WriteLine("--{0} metros son {1} millas.", inputLength, result);
                    break;
                case 5: // Metros a Centímetros
                    result = inputLength * 100;
                    Console.WriteLine("--{0} metros son {1} centímetros.", inputLength, result);
                    break;
                case 6: // Metros a Kilómetros
                    result = inputLength / 1000;
                    Console.WriteLine("{0} metros son {1} kilómetros.", inputLength, result);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            break;
        case 2: // Pies
            switch (outputOption)
            {
                case 1: // Pies a Metros
                    result = inputLength / 3.28084;
                    Console.WriteLine("--{0} pies son {1} metros.", inputLength, result);
                    break;
                case 2: // Pies a Pies
                    Console.WriteLine("--Ya estás en Pies. No es necesario convertir.");
                    break;
                case 3: // Pies a Pulgadas
                    result = inputLength * 12;
                    Console.WriteLine("--{0} pies son {1} pulgadas.", inputLength, result);
                    break;
                case 4: // Pies a Millas
                    result = inputLength / 5280;
                    Console.WriteLine("--{0} pies son {1} millas.", inputLength, result);
                    break;
                case 5: // Pies a Centímetros
                    result = inputLength * 30.48;
                    Console.WriteLine("--{0} pies son {1} centímetros.", inputLength, result);
                    break;
                case 6: // Pies a Kilómetros
                    result = inputLength * 0.0003048;
                    Console.WriteLine("{0} pies son {1} kilómetros.", inputLength, result);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            break;
        case 3: // Pulgadas
            switch (outputOption)
            {
                case 1: // Pulgadas a Metros
                    result = inputLength / 39.3701;
                    Console.WriteLine("--{0} pulgadas son {1} metros.", inputLength, result);
                    break;
                case 2: // Pulgadas a Pies
                    result = inputLength / 12;
                    Console.WriteLine("--{0} pulgadas son {1} pies.", inputLength, result);
                    break;
                case 3: // Pulgadas a Pulgadas
                    Console.WriteLine("--Ya estás en Pulgadas. No es necesario convertir.");
                    break;
                case 4: // Pulgadas a Millas
                    result = inputLength / 63360;
                    Console.WriteLine("--{0} pulgadas son {1} millas.", inputLength, result);
                    break;
                case 5: // Pulgadas a Centímetros
                    result = inputLength * 2.54;
                    Console.WriteLine("--{0} pulgadas son {1} centímetros.", inputLength, result);
                    break;
                case 6: // Pulgadas a Kilómetros
                    result = inputLength * 0.0000254;
                    Console.WriteLine("{0} pulgadas son {1} kilómetros.", inputLength, result);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            break;
        case 4: // Millas
            switch (outputOption)
            {
                case 1: // Millas a Metros
                    result = inputLength * 1609.34;
                    Console.WriteLine("--{0} millas son {1} metros.", inputLength, result);
                    break;
                case 2: // Millas a Pies
                    result = inputLength * 5280;
                    Console.WriteLine("--{0} millas son {1} pies.", inputLength, result);
                    break;
                case 3: // Millas a Pulgadas
                    result = inputLength * 63360;
                    Console.WriteLine("--{0} millas son {1} pulgadas.", inputLength, result);
                    break;
                case 4: // Millas a Millas
                    Console.WriteLine("--Ya estás en Pulgadas. No es necesario convertir.");
                    break;
                case 5: // Millas a Centímetros
                    result = inputLength * 160934;
                    Console.WriteLine("--{0} millas son {1} centímetros.", inputLength, result);
                    break;
                case 6: // Millas a Kilómetros
                    result = inputLength * 1.60934;
                    Console.WriteLine("{0} millas son {1} kilómetros.", inputLength, result);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            break;
        case 5: // Centímetros
            switch (outputOption)
            {
                case 1: // Centímetros a Metros
                    result = inputLength / 100;
                    Console.WriteLine("--{0} centímetros son {1} metros.", inputLength, result);
                    break;
                case 2: // Centímetros a Pies
                    result = inputLength / 30.48;
                    Console.WriteLine("--{0} centímetros son {1} pies.", inputLength, result);
                    break;
                case 3: // Centímetros a Pulgadas
                    result = inputLength / 2.54;
                    Console.WriteLine("--{0} centímetros son {1} pulgadas.", inputLength, result);
                    break;
                case 4: // Centímetros a Millas
                    result = inputLength / 160934;
                    Console.WriteLine("--{0} centímetros son {1} millas.", inputLength, result);
                    break;
                case 5: // Centímetros a Centímetros
                    Console.WriteLine("--Ya estás en Centímetros. No es necesario convertir.");
                    break;
                case 6: // Centímetros a Kilómetros
                    result = inputLength / 100000;
                    Console.WriteLine("{0} centímetros son {1} kilómetros.", inputLength, result);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            break;
        case 6: // Kilómetros
            switch (outputOption)
            {
                case 1: // Kilómetros a Metros
                    result = inputLength * 1000;
                    Console.WriteLine("{0} kilómetros son {1} metros.", inputLength, result);
                    break;
                case 2: // Kilómetros a Pies
                    result = inputLength * 3280.84;
                    Console.WriteLine("{0} kilómetros son {1} pies.", inputLength, result);
                    break;
                case 3: // Kilómetros a Pulgadas
                    result = inputLength * 39370.1;
                    Console.WriteLine("{0} kilómetros son {1} pulgadas.", inputLength, result);
                    break;
                case 4: // Kilómetros a Millas
                    result = inputLength * 0.621371;
                    Console.WriteLine("{0} kilómetros son {1} Millas.", inputLength, result);
                    break;
                case 5: // Kilómetros a Centímetros
                    result = inputLength * 100000;
                    Console.WriteLine("{0} kilómetros son {1} centímetros.", inputLength, result);
                    break;
                case 6: // Kilómetros a Kilómetros
                    Console.WriteLine("Ya estás en kilómetros. No es necesario convertir.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
//Para volver a empezar
Console.WriteLine("\n---¿Desea realizar otra conversion? (s/n): ");
    string ContinueOption = Console.ReadLine().ToLower();
    
    if(ContinueOption != "s")
    {
        Console.WriteLine("---Saliendo del Programa");
        break;
    }
}
//Este es un conversor de temperaturas que convierte a los 3 tipos de temperaturas existentes: Celsius, Fahrenheit y Kelvin
Console.WriteLine("---Seleccione la unidad de temperatura a convertir:");
        Console.WriteLine("1. Celsius");
        Console.WriteLine("2. Fahrenheit");
        Console.WriteLine("3. Kelvin");
        Console.Write("---> ");

        int inputOption = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la temperatura:");
        Console.Write("---> ");

        double inputTemperature = Convert.ToDouble(Console.ReadLine());
        double result = 0;

        Console.WriteLine("\n---Seleccione la unidad de temperatura a la que desea convertir:");
        Console.WriteLine("1. Celsius");
        Console.WriteLine("2. Fahrenheit");
        Console.WriteLine("3. Kelvin");
        Console.Write("---> ");

        int outputOption = Convert.ToInt32(Console.ReadLine());

        switch (inputOption)
        {
            case 1: // Celsius
                switch (outputOption)
                {
                    case 1: // Celsius a Celsius
                        Console.WriteLine("Esta en Celsius, no es necesario convertir.");
                        break;
                    case 2: // Celsius a Fahrenheit
                        result = (inputTemperature * 9 / 5) + 32;
                        Console.WriteLine("{0} grados Celsius son {1} grados Fahrenheit.", inputTemperature, result);
                        break;
                    case 3: // Celsius a Kelvin
                        result = inputTemperature + 273.15;
                        Console.WriteLine("{0} grados Celsius son {1} Kelvin.", inputTemperature, result);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                break;
            case 2: // Fahrenheit
                switch (outputOption)
                {
                    case 1: // Fahrenheit a Celsius
                        result = (inputTemperature - 32) * 5 / 9;
                        Console.WriteLine("{0} grados Fahrenheit son {1} grados Celsius.", inputTemperature, result);
                        break;
                    case 2: // Fahrenheit a Fahrenheit
                        Console.WriteLine("Esta en Fahrenheit, No es necesario convertir.");
                        break;
                    case 3: // Fahrenheit a Kelvin
                        result = (inputTemperature + 459.67) * 5 / 9;
                        Console.WriteLine("{0} grados Fahrenheit son {1} Kelvin.", inputTemperature, result);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                break;
            case 3: // Kelvin
                switch (outputOption)
                {
                    case 1: // Kelvin a Celsius
                        result = inputTemperature - 273.15;
                        Console.WriteLine("{0} Kelvin son {1} grados Celsius.", inputTemperature, result);
                        break;
                    case 2: // Kelvin a Fahrenheit
                        result = (inputTemperature * 9 / 5) - 459.67;
                        Console.WriteLine("{0} Kelvin son {1} grados Fahrenheit.", inputTemperature, result);
                        break;
                    case 3: // Kelvin a Kelvin
                        Console.WriteLine("Esta en Kelvin, No es necesario convertir.");
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

        Console.ReadLine();



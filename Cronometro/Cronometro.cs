// Este es un cronometro funcional hecho en consola con la entrada de segundos.
Console.Clear();
Console.WriteLine("---Bienvenido al cronómetro en la consola");

while (true)
{
    Console.Write("---Ingresa el tiempo en segundos para el temporizador: ");
    if (!int.TryParse(Console.ReadLine(), out int tiempo) || tiempo < 0)
    {
        Console.WriteLine("---Por favor, ingresa un valor válido.");
        break;
    }

    if (tiempo == 0)
    {
        Console.WriteLine("---Saliendo del cronómetro.");
        break;
    }

    // Utilizar un hilo separado para el cronómetro
    var cronometroThread = new Thread(() => IniciarCronometro(tiempo));
    cronometroThread.Start();
    break;
}

// Recorre la cantidad de segundos ingresados en la entrada tiempo
static void IniciarCronometro(int segundos)
{
Console.WriteLine($"\n---Cronómetro iniciado para {segundos} segundos.");

for (int i = segundos; i > 0; i--)
{
    Console.WriteLine($"Tiempo restante: {i} segundos");
    Thread.Sleep(1000); // Pausa de 1 segundo
}

Console.WriteLine("¡Tiempo agotado!");
}
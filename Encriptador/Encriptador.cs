//Este es un encriptador simple que utiliza el cifrado cesar que recorre 3 letras hacia adelante, nos ayuda a ocultar informacion valiosa de los demas.
Console.Clear();


while (true)
{
    Console.WriteLine("\n---Seleccione una opcion: ");
    Console.WriteLine("1. Encriptar");
    Console.WriteLine("2. Desencriptar");
    Console.WriteLine("3. Salir");
    Console.Write("---> ");

    int inputOption = Convert.ToInt32(Console.ReadLine());

    switch (inputOption)
    {
        case 1:
            Console.WriteLine("---Mensaje a encriptar: ");
            Console.Write("---> ");
            string message = Console.ReadLine();

            string encryptedMessage = "";

            //Recorre cada letra del mensaje introducido e intercambia cada letra por la que esta 3 posiciones adelante en el abecedario.
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                char encryptedC = (char)(c + 9);// (c + 9) Cantidad que se recorrera del caracter
                encryptedMessage += encryptedC;
            }

            Console.WriteLine("\nMensaje encriptado: " + encryptedMessage);
            break;

        case 2:
            Console.WriteLine("---Mensaje a Desencriptar: ");
            Console.Write("---> ");
            string encryptedMessageToDescrypt = Console.ReadLine();

            string decryptedMessage = "";

            //Hace lo mismo pero en vez de agregar recorre hacia atras las posiciones agregadas en el mensaje encriptado la cantidad de veces especificada.
            for (int i = 0; i < encryptedMessageToDescrypt.Length; i++)
            {
                char c = encryptedMessageToDescrypt[i];
                char decryptedC = (char)(c - 9);// (c - 9) cantidad que cada valor retrocedera hacia atras
                decryptedMessage += decryptedC;
            }

            Console.WriteLine("---Mensaje desencriptado: " + decryptedMessage);
            break;
        case 3:
            Console.WriteLine("---Saliendo del programa");
            return;
        default:
            Console.WriteLine("---Opcion no valida, seleccione un numero del 1 - 2");
            break;
    }

//Volver a empezar
Console.WriteLine("\n---¿Desea realizar otra operación? (s/n): ");
    string continueOption = Console.ReadLine().ToLower();

    if (continueOption != "s")
    {
        Console.WriteLine("---Saliendo del programa.");
        break;
    }

}
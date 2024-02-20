//Este es un pequeño proyecto sobre adivinanzas que muestra 1 numero al azar y nos dice que tan cerca estamos de el hasta acertar.
Console.Clear();// Limpia la consola para mejor presentacion
Random random = new Random(); //Nos da un numero random
int NumeroRandom = random.Next(1, 101);//Nos da un numero random del 1 al 100 a la variable "NumeroRandom"

int Adivina = 0;
int NumeroDeAdivinanzas = 0;

while (Adivina != NumeroRandom)
{
    Console.Write("\n---Adivina el numero entre 1 y 100: ");
    Adivina = Convert.ToInt32(Console.ReadLine());

    NumeroDeAdivinanzas++; // Agrega el numero de intentos

    if (Adivina < NumeroRandom)
    {
        Console.WriteLine("-Muy bajo.");
    }
    else if (Adivina > NumeroRandom)
    {
        Console.WriteLine("-Muy alto.");
    }
    else
    {
        Console.WriteLine("-Felicidades! Has acertado en {0} intentos!", NumeroDeAdivinanzas);
    }
}

Console.ReadLine();
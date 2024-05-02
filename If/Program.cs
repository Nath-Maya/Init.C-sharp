// See https://aka.ms/new-console-template for more information

int totalJugador = 20;
int totalDealer = 15;
string message = "";

if ( totalJugador < totalDealer )
{
   message = "Venciste al dealer, felicidades";
}
else if (totalJugador <= totalDealer)
{
   message = "Perdiste, lo siento";
}
else
{
   message = "Condición no valida";
}

Console.WriteLine(message);


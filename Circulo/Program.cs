// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var radio = 0d;
//Se declara con 0d que indica que es double

var resultado = 0d;

Console.WriteLine("Bienvenido, calculemos circulos");
//Pi * radio * radio

Console.WriteLine("Ingresa el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio;

Console.WriteLine("El area de tu circulo es: " + resultado);
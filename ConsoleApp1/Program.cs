// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//PROGRAMA QUE CALCULA EL AREA DE UN RECTANGULO

//Declaracion de una variable tipo entero

int ladoA;
int ladoB;
int resultado;

Console.WriteLine("Calcula el area del rectangulo");
Console.WriteLine("Ingrese el valor del lado A");

ladoA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToInt32(Console.ReadLine());

resultado = ladoA * ladoB;

Console.WriteLine("El resultado es: " + resultado);
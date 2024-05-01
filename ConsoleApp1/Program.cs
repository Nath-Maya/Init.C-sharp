// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//PROGRAMA QUE CALCULA EL AREA DE UN RECTANGULO

//Declaracion de una variable tipo entero
//Explicita

// int ladoA;
// int ladoB;
// int resultado;

//Implicita
var ladoA = 0d;
var ladoB = 0d;
var resultado = 0d;

Console.WriteLine("Calcula el area del rectangulo");
Console.WriteLine("Ingrese el valor del lado A");

ladoA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

resultado = ladoA * ladoB;

Console.WriteLine("El resultado es: " + resultado);
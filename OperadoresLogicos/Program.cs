﻿// See https://aka.ms/new-console-template for more information

var (valor1, valor2, valor3) = (true, true, false);

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);


bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);

bool resultNot = !valor1;
Console.WriteLine(resultNot);


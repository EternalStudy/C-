﻿/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Пример:
4 -> да
-3 -> нет
7 -> нет*/
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine()!);
if (x % 2 == 0) Console.WriteLine($"Число {x} четное");
else Console.WriteLine($"Число {x} нечетное");
﻿/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Пример
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine()!);
int y = x % 10;
if (x >= 100 && x < 1000)
    Console.WriteLine($"Третья цифра введенного числа {y}");
else
    Console.WriteLine("Третьей цифры нет");
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine()!);
int b = x % 10;
Console.WriteLine(b);
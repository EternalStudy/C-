/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Пример:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число C");
int c = int.Parse(Console.ReadLine()!);
if (a > b && a > c)
{
    Console.WriteLine($"Максимальное число A={a}");
}
else if (b > a && b > c) Console.WriteLine($"Максимальное число B={b}");
else if (c > a && c > b) Console.WriteLine($"Максимальное число C={c}");
else if (a == b && a == c && b ==c) Console.WriteLine("Введеные числа равны");
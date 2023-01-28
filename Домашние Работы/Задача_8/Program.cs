/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Пример:
5 -> 2, 4
8 -> 2, 4, 6, */
Console.WriteLine("Введиче число");
int x = int.Parse(Console.ReadLine()!);
int i = 0;
while (x > i)
{
    i++;
    if (i % 2 == 0) Console.WriteLine(i);
}
/*Напишите программу,
которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).*/
Console.Clear();
Console.Write("Введите номер четверти");
int X = int.Parse(Console.ReadLine()!);
if (X == 1)
{
    Console.Write("X>0 и Y>0");
}
else if (X == 2)
{
    Console.Write("X<0 и Y>0");
}
else if (X == 3)
{
    Console.Write("X<0 и Y<0");
}
else if (X == 4)
{
    Console.Write("X>0 и Y<0");
}


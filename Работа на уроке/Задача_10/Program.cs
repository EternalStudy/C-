//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (Y > 0)
{
    if (X > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else
    {
        Console.WriteLine("Вторая четверть");
    }
}
else
{
    if (X > 0)
    {
        Console.WriteLine("Четвертая четверть");
    }
    else
    {
        Console.WriteLine("Третья четверть");
    }
}

// напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

bool CheckTreeEngl(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}

Console.WriteLine("ведите первое число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("ведите второе число");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("ведите третие число");
int z = int.Parse(Console.ReadLine()!);

if (CheckTreeEngl(x, y, z))
{
    Console.WriteLine("существует");
}
else
{
    Console.WriteLine("не существует");
}
/*Возведите число А в натуральную степень B используя цикл*/
Console.Clear();
Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);
double result = a;
if (b > 0)
{
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
}
else if (b < 0)
{
    b = -b;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    result = 1 / result;
}
else result = 1;
Console.WriteLine(result);
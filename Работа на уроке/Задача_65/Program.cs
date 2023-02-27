/*Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/
Console.Clear();
string Recursiv(int N, int M)
{
    if (N == M) return N.ToString();
    else
    {
        return Recursiv(N - 1, M) +", "+ N.ToString();
    }
}

Console.WriteLine("Введите начальное число");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное число");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recursiv(N, M));

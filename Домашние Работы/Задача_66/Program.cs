/*Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.Clear();
int Recursiv(int N, int M)
{
    int sum = 0;
    if (N == M) return N;
    else
    {
        return sum = N + Recursiv(N + 1, M);
    }
}

Console.WriteLine("Введите число от: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число до: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(Recursiv(N, M));
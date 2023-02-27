
/*Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/
Console.Clear();
string Recursiv(int N)
{
    if (N == 1) return N.ToString();
    else
    {
        return Recursiv(N - 1) +", "+ N.ToString();
    }
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recursiv(N));
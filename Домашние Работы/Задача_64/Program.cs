/*Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.Clear();
int Recur(int N)
{
    if (N == 1) return N;
    else
    {
        for (int i = N; i > 1; i--)
        {
            Console.Write(i + ", ");
        }
        return N;
    }
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
Console.Write(Recur(N));
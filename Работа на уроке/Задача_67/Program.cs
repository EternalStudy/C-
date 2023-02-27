/*Напишите программу, которая будет принимать
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
Console.Clear();
int Recursiv(int N)
{
    if (N == 0) return 0;
    else
    {
        return N % 10 + Recursiv(N / 10);
    }
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recursiv(N));
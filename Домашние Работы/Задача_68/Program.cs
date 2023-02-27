/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int Ackermann(int M, int N)
{
    if(M == 0) return N + 1;
    else if (N == 0) return Ackermann(M - 1, 1);
    else return Ackermann(M - 1, Ackermann(M, N - 1));

}

Console.Clear();
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(Ackermann(M, N));
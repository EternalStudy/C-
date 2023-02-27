/*Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/
Console.Clear();
int Recursiv(int A, int B)
{
    if (B == 0) return 1;
    else
    {
        return A*Recursiv(A,B-1);
    }
}
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень B");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recursiv(A,B));
// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число");
int chislo = int.Parse(Console.ReadLine()!);
int result = 1;
for (int i = 1; i < chislo; i++)
{
    result *= i;
}
Console.WriteLine($"Произведение чисел от 1 до {chislo} = {result}");
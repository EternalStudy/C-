internal class Program
{
    private static void Main(string[] args)
    {
        // Определить количество цифр в числе
        Console.Clear();

        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine()!);

        int count = 1;

        while (a >= 10 || a <= -10)
        {
            a = a / 10;
            count++;
        }
        Console.WriteLine(count);
    }
}
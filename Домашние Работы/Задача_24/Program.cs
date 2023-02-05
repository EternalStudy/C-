// Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите число");
int chislo = int.Parse(Console.ReadLine()!);
int result = 0;
while (chislo != 0)
{
    result += chislo % 10;
    chislo /= 10;
}
Console.WriteLine($"Сумма цифр введенного числа = {Math.Abs(result)}");

/*Найти сумму чисел от 1 до А*/
Console.Clear();
Console.WriteLine("Введите число");
int chislo = int.Parse(Console.ReadLine()!);
int result = 0;
for (int i = 0; i <= chislo; i++)
{
    result += i;
}
Console.WriteLine(result);
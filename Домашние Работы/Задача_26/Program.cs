// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.WriteLine("Введите число");
int chislo = int.Parse(Console.ReadLine()!);
int result = 0;
for (int i = 0; i < chislo; i++)
{
result = i*i*i;
if (result % 2 == 0) Console.WriteLine(result);
}

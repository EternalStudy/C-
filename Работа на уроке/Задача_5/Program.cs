/*Написать программу, которая выводит случайное число
из отрезка [10,99]. И показывает наибольшую цифру числа.*/
Console.Clear();
int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2)
{
    max = a2;
}
Console.WriteLine($"Максимальная цифра числа {num} равна {max}");
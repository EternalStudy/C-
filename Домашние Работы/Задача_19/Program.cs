/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Пример
14212 -> нет
12821 -> да
23432 -> да*/
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int chislo = int.Parse(Console.ReadLine()!);
if (9999 < chislo & chislo < 100000)
{
    if (chislo / 10000 == chislo % 10 & (chislo / 1000) % 10 == (chislo / 10) % 10) Console.WriteLine($"Число {chislo} является полиномом");
    else Console.WriteLine($"Число {chislo} не является полиномом");
}
else Console.WriteLine("Введено не пятизначное число");

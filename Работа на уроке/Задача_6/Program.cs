/*Напишите программу, которая выводит 
случайное трехзначное число и удаляет
вторую цифру этого числа.*/
Console.Clear();

int a = new Random().Next(100, 1000);
int result = a / 100 * 10 + a % 10;
Console.WriteLine($"Рандомное число: {a}");
Console.WriteLine($"Получилось число: {result}");
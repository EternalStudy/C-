/*Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
Пример:
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.Clear();
Console.WriteLine("Введите X1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y1");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z1");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите X2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y2");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Z1");
int z2 = int.Parse(Console.ReadLine()!);

double result_x = Math.Pow(x1 - x2, 2);
double result_y = Math.Pow(y1 - y2, 2);
double result_z = Math.Pow(z1 - z2, 2);
double result = Math.Sqrt(result_x + result_y + result_z);
Console.WriteLine($"Результат {Math.Round(result, 2)}");


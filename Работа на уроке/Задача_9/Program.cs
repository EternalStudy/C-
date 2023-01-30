/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

 • 5, 25  ->  да
 • -4, 16  ->  да
 • 25, 5  ->  да
 • 8,9  ->  нет */
  Console.Clear();
 double first = Convert.ToDouble(Console.ReadLine());
 double second = Convert.ToDouble(Console.ReadLine());
 if (first == second * second || second == first*first) 
 Console.WriteLine("Да");
 else Console.WriteLine("Числа не являются квадратами друг друга");
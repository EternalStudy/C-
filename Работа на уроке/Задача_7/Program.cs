/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
 Если число 2 не кратно числу 1, то программа выводит остаток от деления.
 • 34, 5 -> не кратно, остаток 4 
 • 16, 4 -> кратно*/
 Console.Clear();
 int first = new Random().Next(1,100);
 int second = new Random().Next(1,100);
 int ost = first % second;
if (ost == 0) Console.WriteLine($"Число {first} кратное {second}");
else Console.WriteLine($"Остаток от деления {ost}");
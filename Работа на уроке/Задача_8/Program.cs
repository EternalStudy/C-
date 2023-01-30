/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

 • 14 -> нет 
 • 46 -> нет 
 • 161 -> да*/
 Console.Clear();
 int chislo = Convert.ToInt32(Console.ReadLine());
 int krasem = chislo % 7;
 int kradvatri = chislo %23;
 if (krasem == 0 && kradvatri ==0) Console.WriteLine($"Число {chislo} кратно и 7 и 23");
 else Console.WriteLine($"Число {chislo} не кратно и 7 и 23");
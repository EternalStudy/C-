/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,является ли этот день выходным.
Пример
6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.WriteLine("Введите цифру");
int x = int.Parse(Console.ReadLine()!);
string[] days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (x > 7) Console.WriteLine("Неправильно введен номер дня недели");
else
{
    for (int i = 0; i <= days.Length; i++)
    {
        if (days[x - 1] == "Суббота" ^ days[x - 1] == "Воскресенье") Console.WriteLine($"День {x} - выходной {days[x - 1]}");
        else Console.WriteLine($"День {x} - не выходной {days[x - 1]}");
        break;
    }
}


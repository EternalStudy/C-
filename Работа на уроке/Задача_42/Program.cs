// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

string DecToBin(int dec)
{
    string result = "";
    while (dec > 0)
    {
        result = (dec % 2).ToString() + result;
        dec /= 2;
    }
    return result;
}

Console.WriteLine("введите число");
int ten = int.Parse(Console.ReadLine()!);
Console.WriteLine(DecToBin(ten));
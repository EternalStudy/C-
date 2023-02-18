/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void ElSearch(int[,] inArray, int numStr, int numCol)
{
    if (inArray.GetLength(0) > numStr && inArray.GetLength(1) > numCol)
    Console.WriteLine(inArray[numStr,numCol]);
    else
    Console.WriteLine("Такого числа нет");
}
Console.Write("Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(str, col, -15, 20);
Console.Write("Введите номер строки: ");
int numStr = int.Parse(Console.ReadLine()!)-1;
Console.Write("Введите номер столбца: ");
int numCol = int.Parse(Console.ReadLine()!)-1;
PrintArray(array);
ElSearch(array, numStr, numCol);
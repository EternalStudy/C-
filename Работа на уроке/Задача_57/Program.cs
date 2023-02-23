/* Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.*/
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
int[] convert2DTo1D(int[,] inArray)
{
    int[] convert = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int k = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            convert[k++] = inArray[i, j];
        }
    }
    return convert;
}
void sortConvert(int[] inArray)
{
    int temp;
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
}
void countResult(int[] inArray)
{
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] == inArray[i - 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"Количество {inArray[i - 1]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"Количество {inArray[inArray.Length-1]} встречается {count} раз");
}
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, 0, 3);
PrintArray(array2D);
int[] convert = convert2DTo1D(array2D);
sortConvert(convert);
countResult(convert);


/*Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int Result(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
/*{
    int count = 0;
    foreach (int elent in inArray)
    {
        if (elent % 2 == 0)
        {
            count++;
        }
    }
    return count;
}*/
int[] array = GetArray(10, 100, 999);
Console.WriteLine(String.Join(", ", array));
int count = Result(array);
Console.WriteLine(count);
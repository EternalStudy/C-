//  Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int CountNumbers(int[] array)
{
    int count = 0;
    foreach (int elent in array)
    {
        if (elent >= 10 && elent <= 99 )
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(123, 0, 150);
Console.WriteLine(String.Join(", ", array));
int count = CountNumbers(array);
Console.WriteLine(count);

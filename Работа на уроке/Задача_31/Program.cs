/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.*/
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

Console.Clear();

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int element in array)
{
    // if (element > 0)
    // {
    //     positiveSum += element;
    // }
    positiveSum += element > 0 ? element : 0;
    negativeSum += element < 0 ? element : 0;
}

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         positiveSum += array[i];
//     } 
//     else 
//     {
//         negativeSum += array[i];
//     }
// }

Console.WriteLine($"Сумма положительных чисел равна: {positiveSum}, а отрицательных: {negativeSum}");
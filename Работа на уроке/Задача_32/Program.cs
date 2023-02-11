/*Напишите программу замена элементов массива: положительные элементы
замените на соответствующие отрицательные, и наоборот.*/
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

void ChangeSign(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] *= -1;
    }
}

int[] array = GetArray(10, -10, 10);
Console.WriteLine(String.Join(", ", array));
ChangeSign(array);
Console.WriteLine(String.Join(", ", array));
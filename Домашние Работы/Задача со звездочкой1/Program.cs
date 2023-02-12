/*Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]*/
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
void MaxNum(int[] inArray)
{
    int max = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length - 1 - i; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                max = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = max;
            }
        }
    }
    for (int i = 0; i < inArray.Length; i++)
    Console.Write(inArray[i] + " ");
}
int[] array = GetArray(10, -10, 100);
Console.WriteLine(String.Join(", ", array));
int mass = MaxNum(array);

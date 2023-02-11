//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
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

bool FindNumber(int[] inArray, int number)
{
    foreach (int element in inArray)
    {
        if (element == number)
            return true;
    }
    return false;
}

int[] arr = GetArray(5, -10, 10);
Console.WriteLine(String.Join(", ", arr));
int chislo = int.Parse(Console.ReadLine());
if (FindNumber(arr, chislo))
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");
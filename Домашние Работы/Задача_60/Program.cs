/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
Console.Clear();
void GetArray(int[,,] inArray)
{
     int count = Convert.ToInt32(Console.ReadLine()!);
    for (int i = 0; i <inArray.GetLength(0) ; i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                inArray[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintArray(int[,,] inArray)
{
    for(int i =0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k})");
            }
        }
    }
}

int[,,] array = new int[2, 2, 2];
Console.WriteLine("Введиче число");
GetArray(array);
PrintArray(array);
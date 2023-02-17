// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.Clear();
int[] Fib(int N)
{
    int[] arr = new int[N];
    arr[0] = 0;
    arr[1] = 1;
    for(int i=2; i<N; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}
int N = int.Parse(Console.ReadLine()!);
int[] array = Fib(N);
Console.WriteLine(string.Join(", ", array));
// От M до N

void Values(int M, int N)
{
    if (N < M)
    {
        return;
    }
    Values(M, N-1);
    Console.Write($"{N}, ");
}

Console.WriteLine("Введите от какого числа: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите до какого числа: ");
int N = int.Parse(Console.ReadLine());

Values(M, N);

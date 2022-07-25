// Натуральные числа от 1 до N

void Values(int num)
{
    if (num == 0)
    {
        return;
    }
    Values(num-1);
    Console.Write($"{num}, ");
}

Console.WriteLine("Введите до какого числа: ");
int N = int.Parse(Console.ReadLine());
Values(N);
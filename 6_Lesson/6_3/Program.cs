// Фибоначчи без рекурсии

void Fibonachi(int num)
{
    int a = 0;
    int b = 1;

    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a+b);
    }
}

Fibonachi(46);
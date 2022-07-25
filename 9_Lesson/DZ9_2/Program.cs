// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Values(int M, int N)
{
    if(N < M)
    {
        return 0;
    }
     return (Values(M, N-1)+N);
   
}

Console.WriteLine("Введите от какого числа: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите до какого числа: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(Values(M, N));
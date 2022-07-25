// A в степени B


int Values(int A, int B)
{
     if(B == 0)
    {
        return 1;
    }

   return Values(A, B-1)*A;
  
}

Console.WriteLine("Введите от какого числа: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите до какого числа: ");
int N = int.Parse(Console.ReadLine());

Console.Write(Values(M, N));



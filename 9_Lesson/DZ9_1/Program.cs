// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

//  M = 1; N = 5 -> "2, 4"
//  M = 4; N = 8 -> "4, 6, 8"

 void Values(int M, int N)
{
    

     if(N < M)
    {
        return;
    }
    
  
    else if (M%2==0)
    {
        
         Console.Write($"{M}, ");
         
    }
    
    Values(M+1, N);
  
}

Console.WriteLine("Введите от какого числа: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите до какого числа: ");
int N = int.Parse(Console.ReadLine());
Values(M, N);

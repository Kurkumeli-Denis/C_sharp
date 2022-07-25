// 123 -> 1+2+3 = 6


int Values(int num)
{
    if (num == 0)
    {
        return 0;
    }
    return Values(num/10) + num % 10;
   
}

Console.WriteLine("Введите числo: ");
int num = int.Parse(Console.ReadLine());
 Console.Write(Values(num));

int Stepen(int x, int y)
{
    int count=0;
    int sum = 1;
    while (count<y)
    {
        sum=sum*x;
        count++;
    }
    return sum;
}
Console.WriteLine(Stepen(2, 10));


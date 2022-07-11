int SumNum(int x)
{
    string y = x.ToString();
    int sum = 0;
    for (int i = 0; i < y.Length; i++)
    {
        Console.WriteLine(y[i]);
        int z = Convert.ToInt32(y[i]);
        sum = sum + z;
    }
    return sum;
}
Console.WriteLine(SumNum(123));
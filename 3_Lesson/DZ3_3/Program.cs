void Kubi (int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{Math.Pow(count, 3)}");
        count = count + 1;
    }
}
Kubi(5);

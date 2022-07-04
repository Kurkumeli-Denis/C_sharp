void Kvadrati (int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{Math.Pow(count, 2)}");
        count = count + 1;
    }
}
Kvadrati(5);
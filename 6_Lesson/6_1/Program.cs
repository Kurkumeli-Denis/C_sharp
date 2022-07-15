// Сумма двух сторон больше чем третья

void Priem (int x, int y, int z)
{
    Console.WriteLine($"{x}, {y}, {z}");

    if(x+y > z && x+z > y && y+z > x)
    {
        Console.Write("Существует");
    }
    else
    {
        Console.Write("Не существует");
    }
}

 Priem(1, 5, 3);
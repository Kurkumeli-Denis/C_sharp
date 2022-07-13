// сумма элементов на нечетных позициях


void Print (int[] array)
{
    int size = array.Length;
    for(int i=0; i<size; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

int [] MassNums (int size)
{
    int [] array = new int [size];
    for(int i=0;i<size; i++)
    {
        array[i] = new Random().Next(1,10);
    }
    return array;
}

void Poisk ( int [] mass)
{
    int k = 0;
    for (int i=0; i<mass.Length; i=i+2)
    {
        k = k + mass[i];
        
    }
    Console.WriteLine($"Сумма = {k}");
}

int [] arr_1 = MassNums (5);
Print(arr_1);
Poisk(arr_1);

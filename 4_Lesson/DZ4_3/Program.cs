void Print (int[] array)
{
    int size = array.Length;
    for(int i=0; i<size; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

int [] Arr (int size=8)
{
    int [] array = new int [size];
    for(int i=0;i<size; i++)
    {
        array[i] = new Random().Next(1,10);
    }
    return array;
}

int [] array_1=Arr();
Print (array_1);

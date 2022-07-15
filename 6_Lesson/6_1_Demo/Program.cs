// Перевернуть массив

void Print (int[] array)
{
    int size = array.Length;
    for(int i=0; i<size; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

int [] MassNums (int size, int from, int to)
{
    int [] array = new int [size];
    for(int i=0;i<size; i++)
    {
        array[i] = new Random().Next(from,to);
    }
    return array;
}

int [] RevMass(int[] arr)
{
    int size = arr.Length - 1;
    for(int i = 0; i < size / 2 + 1; i++)
    {
        (arr[i], arr[size - i]) = (arr[size - i], arr[i]);
    }
    return arr;
}

int[] arr_1 = MassNums(5, 1, 21);
Print(arr_1);
RevMass(arr_1);
Print(arr_1);


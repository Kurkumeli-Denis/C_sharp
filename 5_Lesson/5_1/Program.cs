﻿void Print (int[] array)
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
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

void SumMaxMin(int [] arr)
{
    int s_max, s_min;
    s_max = s_min = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            s_max += arr[i];
        }
        else
        {
            s_min +=arr[i];
        }
    }
    Console.WriteLine($"sum max: {s_max}, sum min: {s_min}");
}


int [] array_1= MassNums(12);
Print (array_1);
SumMaxMin(array_1);

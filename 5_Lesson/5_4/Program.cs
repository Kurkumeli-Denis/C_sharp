// массив из 123 элементов, найти количество элементов от 10 до 99

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
        array[i] = new Random().Next(1,500);
    }
    return array;
}

void Poisk ( int [] mass)
{
    int k = 0;
    for (int i=0; i<mass.Length; i++)
    {
        
        if(mass[i] > 9 && mass[i] < 100)
        {
            k = k + 1;
            Console.WriteLine($"{mass[i]}, {k}, DA ");
            
        }

        else
        {
            Console.WriteLine($"{mass[i]}, HET ");
        }
    }
}

int [] arr_1 = MassNums (123);
Print(arr_1);
Poisk(arr_1);


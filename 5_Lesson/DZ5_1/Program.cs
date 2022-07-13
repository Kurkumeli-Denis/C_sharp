//массив 3х значных чисел, найти количество четных чисел в массиве

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
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void Poisk ( int [] mass)
{
    int k = 0;
    for (int i=0; i<mass.Length; i++)
    {
        
        if(mass[i] % 2 == 0)
        {
            k = k + 1;
            Console.WriteLine($"{mass[i]}, {k}, DA ");
            
        }

        else
        {
            Console.WriteLine($"{mass[i]}, HET ");
        }
    }
    
    Console.WriteLine($"Количество четных = {k}");
}

int [] arr_1 = MassNums (100);
Print(arr_1);
Poisk(arr_1);


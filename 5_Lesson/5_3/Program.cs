// Присутствует ли данное число в массиве



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
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

void Poisk (int number, int [] mass)
{
    for (int i=0; i<mass.Length; i++)
    {
        if(mass[i] == number)
        {
            Console.WriteLine($"{number}, {mass[i]}, DA ");
            
        }

        else
        {
            Console.WriteLine($"{number}, {mass[i]}, HET ");
        }
    }
}

int [] arr_1 = MassNums (6);
Print(arr_1);
Poisk(4, arr_1);



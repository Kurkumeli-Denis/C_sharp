// Массив вещественных чисел, найти разницу между максимумом и минимумом 

void Print (float[] array)
{
    int size = array.Length;
    for(int i=0; i<size; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

float [] MassNums (int size)
{
    float [] array = new float [size];
    for(int i=0;i<size; i++)
    {
        array[i] = new Random().Next(1,10);
    }
    return array;
}

void Poisk ( float [] mass)
{
    float max = mass[0];
    float min = mass[0];
        for (int i=0; i<mass.Length; i++)
    {
        if (mass[i] > max)
        {
            max = mass[i];
        }
        else if (mass[i] < min)
        {
            min = mass[i];
        }
    }
    float result = max - min;
    Console.WriteLine($" Максимум = {max} , Минимум = {min}, Разница = {result}");
}

float [] arr_1 = MassNums (10);
Print(arr_1);
Poisk(arr_1);

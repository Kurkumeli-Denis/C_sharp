// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

void Print (int[,] array)
{
    int rows = array.GetUpperBound(0) + 1; // строки
    int columns = array.Length / rows; // столбцы
    for(int i=0; i<rows; i++)
    {
        for (int j = 0; j < columns; j++ )
        {
            Console.Write($"{array[i, j], 3} ");
        }
        Console.WriteLine();
    }
    
}

void Print_2 (int[] array)
{
    
    int columns = array.Length;
    
        for (int j = 0; j < columns; j++ )
        {
            Console.Write($"{array[j]} ");
        }
        Console.WriteLine();
    
    
}

 int [,] MassNums ()
 {
     Console.WriteLine("Введите количество строк: ");
     int rows = int.Parse(Console.ReadLine());
     Console.WriteLine("Введите количество столбцов: ");
     int columns = int.Parse(Console.ReadLine());
     int [,] array = new int [rows, columns];
     for(int i=0;i<rows; i++)
     {

        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
     }
     return array;
}

int [] Minimal_Index (int [,] mass)
{
    int min = mass[0,0];
    int [] arr = new int [2];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            
            if (min > mass[i,j])
            {
                
                arr[0] = i;
                arr[1] = j;
               min = mass[i, j];
            }
        }
        
    }
     
    return arr;
}

void Delete(int [,] mass, int [] arr)
{
    
    for (int i = 0; i < mass.GetLength(0); i++) 
    { 
        for (int j = 0; j < mass.GetLength(1); j++) 
        { 
            if (i != arr[0] && j != arr[1])
            {
                Console.Write($"{mass[i,j]}");
                
            }
            
        } 
        Console.WriteLine();
    } 
    
}

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
int [] arr_2 = Minimal_Index(arr_1);
Console.WriteLine("Координаты минимума: ");
Print_2(arr_2);
Console.WriteLine();
Delete(arr_1, arr_2);

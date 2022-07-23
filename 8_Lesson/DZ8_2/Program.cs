// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print (int[,] array)
{
    int rows = array.GetUpperBound(0) + 1; // строки
    int columns = array.Length / rows; // столбцы
    for(int i=0; i<rows; i++)
    {
        for (int j = 0; j < columns; j++ )
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    
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

int Stroka(int [,] mass) 
{ 
    int max = 0; 
    int index = 0; 
    int count = 0; 
     
     
    for (int i = 0; i<mass.GetLength(0); i++) 
    { 
        int sum = 0; 
        for (int j = 0; j<mass.GetLength(1); j++) 
        { 
            sum = sum + mass[i, j]; 
         } 
        if (max < sum) 
        { 
            max = sum; 
            index = count  ; 
        } 
       count++; 
    } 
    return index; 
}

int [] Vivod(int [,] mass, int index)
{
    int [] array = new int [mass.GetLength(1)];

    
        for(int k = 0; k < mass.GetLength(1); k++)
        {
            array[k] = mass[index, k];
            Console.Write($"{array[k]} ");
        }
    
    return array;
}

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
int index = Stroka(arr_1);
int [] arr_2 = Vivod(arr_1, index);


// поэллементно создать копию двумерного массива

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

 int [,] MassNums (int rows, int columns)
 {
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

void Copy(int [,] mass)
{
    
    int rows = mass.GetUpperBound(0) + 1; // строки
    int columns = mass.Length / rows; // столбцы
    for(int i = 0; i < rows ; i++)
    {
        for (int j = 0; j < columns; j++ )
        {
           Console.Write( $"{mass[i , j]} ");

        }
        Console.WriteLine();
    }
    

    
}


int [,] arr_1 = MassNums (3, 3);
Print(arr_1);
Console.WriteLine();
Copy(arr_1);


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
            array[i, j] = new Random().Next(1,5);
        }
     }
     return array;
}

void SrArefmet(int [,] mass)
{
    double sum=0;
    int j = 0;
    int i = 0;
    while (j < mass.GetLength(1))
    {
        sum = 0;
        i = 0;
        while ( i < mass.GetLength(0))
        {
            sum = sum + mass[i, j];
            
            i++;
          
        }
        sum = sum / mass.GetLength(0);
        Console.WriteLine($"Среднее арефметическое {j+1} столбца = {Math.Round(sum, 2)}");
        
        j++;
    }
    
    
}

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
SrArefmet(arr_1);

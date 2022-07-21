// транспонировать матрицу

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

string Replace(int [,] mass)
{
    int rows = mass.GetLength(0);
    int columns = mass.GetLength(1);
    if( rows != columns) return "no";
    for (int i=0; i<rows; i++)
    {
        for (int j = 0; j<i; j++)
        {
            (mass[i,j] ,mass[j,i]) = (mass[j,i], mass[i,j]);
        }
        
    }
   return "yes";
}

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
Console.WriteLine(Replace(arr_1));
Print(arr_1);

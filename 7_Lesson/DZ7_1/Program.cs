// Двумерный массив с рандомными веществ числами

void Print (double[,] array)
{
    int rows = array.GetUpperBound(0) + 1; // строки
    int columns = array.Length / rows; // столбцы
    for(int i=0; i<rows; i++)
    {
        for (int j = 0; j < columns; j++ )
        {
            Console.Write("{0,6:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
    
}

 double [,] MassNums ()
 {
     Console.WriteLine("Введите количество строк: ");
     int rows = int.Parse(Console.ReadLine());
     Console.WriteLine("Введите количество столбцов: ");
     int columns = int.Parse(Console.ReadLine());
     double [,] array = new double [rows, columns];
     for(int i=0;i<rows; i++)
     {

        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble()*100;
        }
     }
     return array;
}
double [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
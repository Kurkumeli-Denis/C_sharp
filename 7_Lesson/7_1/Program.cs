// Двумерный массив заполненный целыми рандомными числами


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

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);

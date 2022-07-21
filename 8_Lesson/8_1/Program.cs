// Двумерный массив, поменять первую и последнюю строку местами

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

void Replace(int [,] mass)
{
    int rows = mass.GetLength(0);
    int columns = mass.GetLength(1);

    for (int i=0; i<rows; i++)
    {
        (mass[0,i] ,mass[rows-1, i]) = (mass[rows-1, i], mass[0,i]);
    }
   
}

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
Replace(arr_1);
Print(arr_1);

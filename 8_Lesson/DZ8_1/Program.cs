//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void PoPoraydku(int [,] mass)
{
    int num = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        
        for (int k = 0; k < mass.GetLength(1); k++)
        {

        
            for ( int j = 0; j < mass.GetLength(1)-1; j++)
            {
                if (mass[i, j] < mass[i, j+1])
                {
                    num = mass[i, j];
                    mass[i, j] = mass[i, j+1];
                    mass[i, j+1] = num;
                }
            }
        }
    }
    
}

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
PoPoraydku(arr_1);
Print(arr_1);
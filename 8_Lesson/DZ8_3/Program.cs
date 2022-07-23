// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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



int [,] Proizvedenie (int [,] mass, int [,] arr) 
{ 
    if (mass.GetLength(0) != arr.GetLength(1))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
    }

    int [,] res = new int [mass.GetLength(0), arr.GetLength(1)];

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(0); k++)
            {
                res[i,j] += mass[i,k] * arr[k,j];
            }
        }
    }
    return res;
}
 

int [,] arr_1 = MassNums (); 
Console.WriteLine(); 
Print(arr_1); 
Console.WriteLine(); 
int [,] arr_2 = MassNums (); 
Console.WriteLine(); 
Print(arr_2); 
Console.WriteLine(); 
int [,] arr_3 = Proizvedenie(arr_1, arr_2);
Print (arr_3);

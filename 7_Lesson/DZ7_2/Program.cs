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

void Diagonal(int [,] mass)
{
    Console.WriteLine("Введите координаты точки по горизонтали: ");
    int gorizont = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты точки по вертикали: ");
    int vertikal = int.Parse(Console.ReadLine());
    if (gorizont > mass.GetLength(0)-1 || vertikal > mass.GetLength(1)-1)
            {
                Console.WriteLine("Такой точки нет");
                return;
            }
    for (int i = 0; i<mass.GetLength(0); i++ )
    {
        for (int j = 0; j<mass.GetLength(1); j++)
        {
            
             if (gorizont == i && vertikal == j)
            {
                Console.WriteLine($"Число в этих координатах: {mass[i, j]}");
            }
          
        }
    }
    
    
}

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
Diagonal(arr_1);

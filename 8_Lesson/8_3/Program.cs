// 


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

int [] Replace(int [,] mass)
{
    int [] arr = new int [10];
    foreach(int item in mass)
    {
        arr[item]++;
    }
    return arr;
   
}
void Result (int[] array)
{
    int rows = array.Length; // строки
  
    for(int i=0; i<rows; i++)
    {
        
            Console.Write($"{i} - {array[i]} ");
            Console.WriteLine();
    }
        Console.WriteLine();
    
    
}

int [,] arr_1 = MassNums ();
Console.WriteLine();
Print(arr_1);
Console.WriteLine();
int [] arr_2 = Replace(arr_1);
Result(arr_2);


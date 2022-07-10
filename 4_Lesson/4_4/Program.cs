void Arr()
{
    int [] arrray = new int [8];
    for(int i=0; i<8; i++)
    {
        arrray [i] = new Random().Next (0, 2);
        Console.Write($"{arrray [i]} ");
     }
}
Arr();
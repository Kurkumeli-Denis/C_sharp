void Kubi (int num)
{
    int x = num/10000;
    int y = num%10;
    int z = num/1000%10;
    int q = num%100/10;


    if (x==y & z==q)
    {
        Console.WriteLine("ДА");
    }
    else 
    {
        Console.WriteLine("НЕТ");
    }
}
Kubi(23432);


// 2  3  4  3  2
// x  z  w  q  y
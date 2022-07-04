int maxnumber (int num)
{
    if (num%10 > num/10)
    {
        return num%10;
    }
    else
    {
        return num/10;
    }
}
int secomdnum = new Random().Next(10, 100);
Console.WriteLine(secomdnum);
Console.WriteLine(maxnumber(secomdnum));

int x = int.Parse(Console.ReadLine());
if(x<100)
{
    Console.WriteLine("Третьей цифры нет");
}
while (x>999)
{
     x = x/10;
}
x = x%100;
x = x%10;
Console.WriteLine(x);

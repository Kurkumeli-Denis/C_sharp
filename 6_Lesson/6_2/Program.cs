// переводим десятичное число в двоичное

void Dvoichnoe(int x)
{
    string dec = "";
    while(x > 0)
    {
        dec = x % 2 + dec;
        x = x / 2;
    }
    Console.WriteLine(dec);
}

Dvoichnoe(45);

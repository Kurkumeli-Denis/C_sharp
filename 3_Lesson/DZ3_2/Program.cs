double XY (double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
}


Console.WriteLine(XY (7, 1, -5, -1, 0, 9));


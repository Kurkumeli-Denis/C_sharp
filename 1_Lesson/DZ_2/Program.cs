int[] a = new int[3];
for (int i = 0; i < 3; i++)
    a[i] = int.Parse(Console.ReadLine());

   int max = 0;

for (int i=0; i<3; i++)
        if (a[i] > max)
    {
        max = a[i];
    }

Console.WriteLine("Max =" + max);

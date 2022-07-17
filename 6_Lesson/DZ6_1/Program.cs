// Сколько чисел больше 0 ввел пользователь

int [] Vvod()
{     
    Console.WriteLine("Введите количество чисел: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [M];
    Console.WriteLine("Введите числа через Enter: ");

    for (int i = 0; i < M; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    return array;
}

void Scolko(int [] mass)
{
    int k = 0;
    for(int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0)
        {
            k++;
        }
    }
    Console.WriteLine($"Чисел больше 0: {k}");

}

int [] Arr_1 = Vvod();
Scolko(Arr_1);



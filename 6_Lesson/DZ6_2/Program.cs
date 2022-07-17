// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1,     y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) В ПРИМЕРЕ НЕПРАВИЛЬНО НАЙДЕНА ТОЧКА ПЕРЕСЕЧЕНИЯ

// k1 * x + b1 = k2 * x + b2
// k1*x - k2*x = b2 - b1
// 

double [] Vvod()
{     
    Console.WriteLine("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    
    double [] array = new double [4] {b1, k1, b2, k2};
    return array;
}

void System(double [] mass)
{
    double x = (mass[2] - mass[0]) / (mass[1] - mass[3]);
    double y = (mass[1] * x) + mass[0];
    Console.WriteLine($"Точка пересечения:( {x}; {y} )");
}

double [] arr_1 = Vvod();
System (arr_1);


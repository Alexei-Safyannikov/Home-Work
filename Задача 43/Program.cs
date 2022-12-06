// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

double SearchUnknownX(double bx1, double kx1, double bx2, double kx2)
{
    return (bx2 - bx1) / (kx1 - kx2);
}
double SearchUnknownY(double x, double bx1, double kx1, double bx2, double kx2)
{
    return kx1 * x + bx1;
}

if (k1 != k2)
{
    double x = Math.Round(SearchUnknownX(b1, k1, b2, k2), 1, MidpointRounding.ToZero);
    double y = Math.Round(SearchUnknownY(x, b1, k1, b2, k2), 1, MidpointRounding.ToZero);
    Console.WriteLine($"Точка пересечения двух прямых --> ({x};{y})");
}
else Console.WriteLine("Прямые параллельны!");